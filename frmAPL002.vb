Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmAPL002
	Inherits System.Windows.Forms.Form
	
	Dim wsFormID As String
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Dim wcCombo As System.Windows.Forms.Control
	Dim wsMsg As String
	
	Private waScrToolTip As New XArrayDBObject.XArrayDB
	Private waResult As New XArrayDBObject.XArrayDB
	Dim wgsTitle As String
	Private wsFormCaption As String
	
	Private Const tcGo As String = "Go"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	
	Private Const Curr As Short = 0
	Private Const CurrDesc As Short = 1
	Private Const Excr As Short = 2
	Private Const Dummy As Short = 3
	'Maximum Exchange Rate
	Private Const wdExchangeRate As Double = 9999.999999
	
	Private wsBaseCurCd As String
	Private wsCtlPrd As String
	
	Private Sub cmdCancel()
		Ini_Scr()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsDate As String
		Dim wsSQL As String
		Dim wsMapPrd As String
		Dim adcmdSave As New ADODB.Command
		Dim wlCtr As Integer
		
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		
		
		On Error GoTo cmdSave_Err
		
		wsDteTim = gsSystemDate
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'If MsgBox("Are you sure to update exchange rate Now?", vbYesNo, gsTitle) = vbNo Then
		'        cmdCancel
		'        MousePointer = vbDefault
		'        Exit Sub
		'End If
		
		wsDate = medPrdFr.Text
		wsMapPrd = Get_FiscalPeriod(wsDate)
		
		cnCon.BeginTrans()
		adcmdSave.ActiveConnection = cnCon
		
		adcmdSave.CommandText = "USP_CRTTMPEXCR"
		adcmdSave.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		adcmdSave.Parameters.Refresh()
		
		For wlCtr = 0 To waResult.get_UpperBound(1)
			If Trim(waResult.get_Value(wlCtr, Curr)) <> "" Then
				Call SetSPPara(adcmdSave, 1, gsUserID)
				Call SetSPPara(adcmdSave, 2, Change_SQLDate(wsDteTim))
				Call SetSPPara(adcmdSave, 3, wsFormID)
				Call SetSPPara(adcmdSave, 4, Set_Quote(waResult.get_Value(wlCtr, Curr)))
				Call SetSPPara(adcmdSave, 5, To_Value(waResult.get_Value(wlCtr, Excr)))
				adcmdSave.Execute()
			End If
		Next wlCtr
		
		cnCon.CommitTrans() 'Create Stored Procedure String
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
		
		'Create Selection Criteria
		ReDim wsSelection(2)
		wsSelection(1) = lblCusNoFr.Text & " " & Set_Quote(cboCusNoFr.Text) & " " & lblCusNoTo.Text & " " & Set_Quote(cboCusNoTo.Text)
		wsSelection(2) = lblPrdFr.Text & " " & Set_Quote(medPrdFr.Text)
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTAPL002 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboCusNoFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboCusNoTo.Text) = "", New String("z", 10), Set_Quote(cboCusNoTo.Text)) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(medPrdFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Opt_Getfocus(optPrn, 2, 0) = 0, "1", "2") & "', "
		wsSQL = wsSQL & "" & IIf(Opt_Getfocus(optBy, 2, 0) = 0, "0", "1") & ", "
		wsSQL = wsSQL & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTAPL002"
		Else
			wsRptName = "RPTAPL002"
		End If
		
		NewfrmPrint.ReportID = "APL002"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "APL002"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		'gsMsg = "Update Process is completed!"
		'MsgBox gsMsg, vbInformation + vbOKOnly, gsTitle
		
		Call cmdCancel()
		
		Exit Sub
		
cmdSave_Err: 
		MsgBox(Err.Description)
		Cursor = System.Windows.Forms.Cursors.Default
		cnCon.RollbackTrans()
		'UPGRADE_NOTE: Object adcmdSave may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		adcmdSave = Nothing
	End Sub
	
	Private Sub cboCusNoFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.Leave
		FocusMe(cboCusNoFr, True)
	End Sub
	
	Private Sub cboCusNoTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoTo.Leave
		FocusMe(cboCusNoTo, True)
	End Sub
	
	Private Sub frmAPL002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Select Case KeyCode
			Case System.Windows.Forms.Keys.F9
				Call cmdOK()
				
			Case System.Windows.Forms.Keys.F11
				Call cmdCancel()
				
			Case System.Windows.Forms.Keys.F12
				Me.Close()
		End Select
	End Sub
	
	Private Sub frmAPL002_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Grid()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		wsBaseCurCd = Get_CompanyFlag("CMPCURR")
		wsFormID = "APL002"
		
	End Sub
	
	Private Sub Ini_Scr()
		Dim wsFromDate As String
		
		waResult.ReDim(0, -1, Curr, Excr)
		tblDetail.Array = waResult
		tblDetail.ReBind()
		tblDetail.Bookmark = 0
		
		Me.Text = wsFormCaption
		
		'wsCtlPrd = getCtrlMth("AP")
		wsCtlPrd = getCtrlMth("AP")
		wsFromDate = VB.Left(wsCtlPrd, 4) & "/" & VB.Right(wsCtlPrd, 2) & "/01"
		
		tblCommon.Visible = False
		cboCusNoFr.Text = ""
		cboCusNoTo.Text = ""
		
		Call SetDateMask(medPrdFr)
		
		medPrdFr.Text = VB6.Format(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(wsFromDate))), "YYYY/MM/DD")
		
		optBy(0).Checked = True
		tblDetail.Enabled = False
		
		Call LoadRecord()
		
		'cboCusNoFr.SetFocus
	End Sub
	
	Private Function InputValidation() As Boolean
		InputValidation = False
		
		With tblDetail
			If .EditActive = True Then Exit Function
			
			'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			.CtlUpdate()
			If Chk_GrdRow(To_Value(.FirstRow) + .Row) = False Then
				.Focus()
				Exit Function
			End If
		End With
		
		If chk_medPrdFr = False Then
			Exit Function
		End If
		
		InputValidation = True
	End Function
	
	'UPGRADE_WARNING: Event frmAPL002.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmAPL002_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(6600)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmAPL002_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object waScrToolTip may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrToolTip = Nothing
		'UPGRADE_NOTE: Object waResult may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waResult = Nothing
		'UPGRADE_NOTE: Object frmAPL002 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Me = Nothing
	End Sub
	
	Private Sub medPrdFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Leave
		FocusMe(medPrdFr, True)
	End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		Call Get_Scr_Item("TOOLTIP", waScrToolTip)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		lblPrdFr.Text = Get_Caption(waScrItm, "PRDFR")
		optBy(0).Text = Get_Caption(waScrItm, "OPT1")
		optBy(1).Text = Get_Caption(waScrItm, "OPT2")
		optPrn(0).Text = Get_Caption(waScrItm, "PRN1")
		optPrn(1).Text = Get_Caption(waScrItm, "PRN2")
		
		lblCusNoFr.Text = Get_Caption(waScrItm, "CUSNOFR")
		lblCusNoTo.Text = Get_Caption(waScrItm, "CUSNOTO")
		lblTitle.Text = Get_Caption(waScrItm, "TITLE")
		txtTitle.Text = Get_Caption(waScrItm, "RPTTITLE")
		
		With tblDetail
			.Columns(Curr).Caption = Get_Caption(waScrItm, "CURR")
			.Columns(CurrDesc).Caption = Get_Caption(waScrItm, "CURRDESC")
			.Columns(Excr).Caption = Get_Caption(waScrItm, "EXCR")
		End With
		
		tbrProcess.Items.Item(tcCancel).ToolTipText = Get_Caption(waScrToolTip, tcCancel) & "(F11)"
		tbrProcess.Items.Item(tcGo).ToolTipText = Get_Caption(waScrToolTip, tcGo) & "(F9)"
		tbrProcess.Items.Item(tcExit).ToolTipText = Get_Caption(waScrToolTip, tcExit) & "(F12)"
	End Sub
	
	Private Function chk_medPrdFr() As Boolean
		chk_medPrdFr = False
		
		If Trim(medPrdFr.Text) = "/  /" Then
			gsMsg = "Must Input Date!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdFr.Focus()
			Exit Function
		End If
		
		If Chk_Date(medPrdFr) = False Then
			gsMsg = "Invalid Date!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			medPrdFr.Focus()
			Exit Function
		End If
		
		chk_medPrdFr = True
	End Function
	
	Private Sub medPrdFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles medPrdFr.Enter
		FocusMe(medPrdFr)
	End Sub
	
	Private Sub medPrdFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles medPrdFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			
			If chk_medPrdFr = False Then
				GoTo EventExitSub
			End If
			
			Call Opt_Setfocus(optPrn, 2, 0)
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optBy.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optBy_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optBy.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optBy.GetIndex(eventSender)
			If Index = 0 Then
				Call LoadRecord()
				tblDetail.Enabled = False
			Else
				tblDetail.Enabled = True
			End If
		End If
	End Sub
	
	Private Sub optBy_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optBy.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = optBy.GetIndex(eventSender)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			If Index = 1 Then
				tblDetail.Focus()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub optBy_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optBy.Leave
		Dim Index As Short = optBy.GetIndex(eventSender)
		tblDetail.Enabled = IIf(Opt_Getfocus(optBy, 2, 0) = 0, False, True)
	End Sub
	
	Private Sub optPrn_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optPrn.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = optPrn.GetIndex(eventSender)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			If Index = 1 Then
				Call Opt_Setfocus(optBy, 2, 0)
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub tblDetail_AfterColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_AfterColUpdateEvent) Handles tblDetail.AfterColUpdate
		On Error GoTo tblDetail_AfterColUpdate_Err
		With tblDetail
			'UPGRADE_NOTE: Update was upgraded to CtlUpdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			.CtlUpdate()
		End With
		Exit Sub
		
tblDetail_AfterColUpdate_Err: 
		MsgBox("tblDetail_AfterColUpdate_Err!")
	End Sub
	
	Private Sub tblDetail_BeforeColUpdate(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeColUpdateEvent) Handles tblDetail.BeforeColUpdate
		
		On Error GoTo tblDetail_BeforeColUpdate_Err
		
		With tblDetail
			Select Case eventArgs.ColIndex
				Case Excr
					If chk_grdExchRate(.Columns(eventArgs.ColIndex).Text) = False Then
						GoTo Tbl_BeforeColUpdate_Err
					End If
					
					.Columns(eventArgs.ColIndex).Text = NBRnd(CDbl(.Columns(eventArgs.ColIndex).Text), giExrDp)
			End Select
		End With
		
		Exit Sub
		
Tbl_BeforeColUpdate_Err: 
		'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
		eventArgs.Cancel = True
		Exit Sub
		
tblDetail_BeforeColUpdate_Err: 
		MsgBox("tblDetail_BeforeColUpdate_Err!")
		'UPGRADE_WARNING: Couldn't resolve default property of object OldValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		tblDetail.Columns(eventArgs.ColIndex).Text = eventArgs.OldValue
		eventArgs.Cancel = True
		
	End Sub
	
	Private Sub tblDetail_BeforeRowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_BeforeRowColChangeEvent) Handles tblDetail.BeforeRowColChange
		
		On Error GoTo tblDetail_BeforeRowColChange_Err
		
		With tblDetail
			'UPGRADE_WARNING: Couldn't resolve default property of object tblDetail.DestinationRow. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object tblDetail.Bookmark. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If .Bookmark <> .DestinationRow Then
				If Chk_GrdRow(To_Value(.Bookmark)) = False Then
					eventArgs.Cancel = True
					Exit Sub
				End If
			End If
		End With
		
		Exit Sub
		
tblDetail_BeforeRowColChange_Err: 
		MsgBox("tblDetail_BeforeRowColChange_Err!")
		eventArgs.Cancel = True
		
	End Sub
	
	Private Sub tblDetail_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblDetail.KeyDownEvent
		
		On Error GoTo tblDetail_KeyDown_Err
		
		With tblDetail
			Select Case eventArgs.KeyCode
				Case System.Windows.Forms.Keys.Return
					Select Case .Col
						Case Excr
							eventArgs.KeyCode = System.Windows.Forms.Keys.Down
							.Col = Excr
					End Select
			End Select
		End With
		
		Exit Sub
		
tblDetail_KeyDown_Err: 
		MsgBox("tblDetail_KeyDown_Err!")
	End Sub
	
	Private Sub tblDetail_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyPressEvent) Handles tblDetail.KeyPressEvent
		
		On Error GoTo tblDetail_KeyPress_Err
		
		With tblDetail
			Select Case .Col
				Case Excr
					Call Chk_InpNum(eventArgs.KeyAscii, .Text, False, True)
					Call chk_InpLen(tblDetail, 11, eventArgs.KeyAscii)
			End Select
		End With
		
		Exit Sub
		
tblDetail_KeyPress_Err: 
		MsgBox("tblDetail_KeyPress_Err!")
		
	End Sub
	
	Private Sub tbrProcess_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _tbrProcess_Button1.Click, _tbrProcess_Button2.Click, _tbrProcess_Button3.Click, _tbrProcess_Button4.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		Select Case Button.Name
			Case tcGo
				Call cmdOK()
			Case tcCancel
				Call cmdCancel()
			Case tcExit
				Me.Close()
		End Select
	End Sub
	
	Private Sub Ini_Grid()
		
		Dim wiCtr As Short
		
		With tblDetail
			.EmptyRows = True
			.MultipleLines = 0
			.AllowAddNew = True
			.AllowUpdate = True
			.AllowDelete = True
			.AlternatingRowStyle = True
			.RecordSelectors = False
			.AllowColMove = False
			.AllowColSelect = False
			
			For wiCtr = Curr To Excr
				.Columns(wiCtr).AllowSizing = True
				.Columns(wiCtr).Visible = True
				.Columns(wiCtr).Locked = False
				.Columns(wiCtr).Button = False
				.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgLeft
				
				Select Case wiCtr
					Case Curr
						.Columns(wiCtr).Width = 1500
						.Columns(wiCtr).Locked = True
						.Columns(wiCtr).DataWidth = 3
					Case CurrDesc
						.Columns(wiCtr).Width = 3500
						.Columns(wiCtr).DataWidth = 50
						.Columns(wiCtr).Locked = True
					Case Excr
						.Columns(wiCtr).Width = 1500
						.Columns(wiCtr).HeadAlignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).Alignment = TrueDBGrid60.AlignmentConstants.dbgRight
						.Columns(wiCtr).DataWidth = 11
						.Columns(wiCtr).NumberFormat = gsExrFmt
						
						
				End Select
			Next 
			.Styles("EvenRow").BackColor = System.Convert.ToUInt32(&H8000000F)
		End With
		
	End Sub
	
	Private Function LoadRecord() As Boolean
		Dim rsRcd As New ADODB.Recordset
		Dim wsSQL As String
		Dim wiCtr As Integer
		Dim wsCtlYr As String
		Dim wsCtlMon As String
		
		LoadRecord = False
		
		wsCtlYr = VB.Left(wsCtlPrd, 4)
		wsCtlMon = VB.Right(wsCtlPrd, 2)
		
		
		wsSQL = "SELECT EXCCURR, EXCDESC, EXCRATE FROM mstEXCHANGERATE "
		wsSQL = wsSQL & "WHERE EXCYR = '" & Set_Quote(wsCtlYr) & "' "
		wsSQL = wsSQL & "AND EXCMN = '" & To_Value(wsCtlMon) & "' "
		
		rsRcd.Open(wsSQL, cnCon, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		
		If rsRcd.RecordCount <= 0 Then
			rsRcd.Close()
			'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			rsRcd = Nothing
			Exit Function
		End If
		
		rsRcd.MoveFirst()
		With waResult
			.ReDim(0, -1, Curr, Excr)
			Do While Not rsRcd.EOF
				.AppendRows()
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), Curr) = ReadRs(rsRcd, "EXCCURR")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), CurrDesc) = ReadRs(rsRcd, "EXCDESC")
				'UPGRADE_WARNING: Couldn't resolve default property of object ReadRs(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				waResult.get_Value(.get_UpperBound(1), Excr) = VB6.Format(ReadRs(rsRcd, "EXCRATE"), gsExrFmt)
				rsRcd.MoveNext()
			Loop 
		End With
		tblDetail.ReBind()
		tblDetail.FirstRow = 0
		rsRcd.Close()
		
		'UPGRADE_NOTE: Object rsRcd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsRcd = Nothing
		
		
		LoadRecord = True
		
	End Function
	
	Private Function Chk_GrdRow(ByVal LastRow As Integer) As Boolean
		
		On Error GoTo Chk_GrdRow_Err
		
		Chk_GrdRow = False
		
		If waResult.get_UpperBound(1) < 0 Then
			Chk_GrdRow = True
			Exit Function
		End If
		
		With tblDetail
			If To_Value(LastRow) > waResult.get_UpperBound(1) Then
				Chk_GrdRow = True
				Exit Function
			End If
			
			If chk_grdExchRate(waResult.get_Value(LastRow, Excr)) = False Then
				.Col = Excr
				.Row = LastRow
				Exit Function
			End If
		End With
		
		Chk_GrdRow = True
		
		Exit Function
		
Chk_GrdRow_Err: 
		MsgBox("Chk_GrdRow_Err!")
		
	End Function
	
	Private Function chk_grdExchRate(ByVal inExchRate As String) As Boolean
		
		chk_grdExchRate = False
		
		If To_Value(inExchRate) = 0 Then
			gsMsg = "Exchange Rate Can not equal to 0!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		If To_Value(inExchRate) > wdExchangeRate Then
			gsMsg = "Exchange Rate too great!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		chk_grdExchRate = True
		
	End Function
	
	Private Sub cboCusNoFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboCusNoFr
		
		wsSQL = "SELECT VdrCode, VdrName "
		wsSQL = wsSQL & " FROM MstVendor "
		wsSQL = wsSQL & " WHERE VdrCode LIKE '%" & IIf(cboCusNoFr.SelectionLength > 0, "", Set_Quote(cboCusNoFr.Text)) & "%' "
		wsSQL = wsSQL & " AND VdrStatus ='1' "
		wsSQL = wsSQL & " AND VdrInactive = 'N' "
		wsSQL = wsSQL & " ORDER BY VdrCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCusNoFr.Left)), VB6.PixelsToTwipsY(cboCusNoFr.Top) + VB6.PixelsToTwipsY(cboCusNoFr.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboCusNoFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoFr.Enter
		FocusMe(cboCusNoFr)
	End Sub
	
	Private Sub cboCusNoFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCusNoFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboCusNoFr, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			
			If Trim(cboCusNoFr.Text) <> "" And Trim(cboCusNoTo.Text) = "" Then
				cboCusNoTo.Text = cboCusNoFr.Text
			End If
			
			cboCusNoTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboCusNoTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboCusNoTo
		
		wsSQL = "SELECT VdrCode, VdrName "
		wsSQL = wsSQL & " FROM MstVendor "
		wsSQL = wsSQL & " WHERE VdrCode LIKE '%" & IIf(cboCusNoTo.SelectionLength > 0, "", Set_Quote(cboCusNoTo.Text)) & "%' "
		wsSQL = wsSQL & " AND VdrStatus ='1' "
		wsSQL = wsSQL & " AND VdrInactive = 'N' "
		wsSQL = wsSQL & " ORDER BY VdrCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboCusNoTo.Left)), VB6.PixelsToTwipsY(cboCusNoTo.Top) + VB6.PixelsToTwipsY(cboCusNoTo.Height), tblCommon, wsFormID, "TBLCUSNO", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboCusNoTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboCusNoTo.Enter
		FocusMe(cboCusNoTo)
	End Sub
	
	Private Sub cboCusNoTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboCusNoTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboCusNoTo, 10, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			
			If chk_cboCusNoTo = False Then
				cboCusNoTo.Focus()
				GoTo EventExitSub
			End If
			
			medPrdFr.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Function chk_cboCusNoTo() As Boolean
		chk_cboCusNoTo = False
		
		If UCase(cboCusNoFr.Text) > UCase(cboCusNoTo.Text) Then
			wsMsg = "To > From!"
			MsgBox(wsMsg, MsgBoxStyle.OKOnly, gsTitle)
			Exit Function
		End If
		
		chk_cboCusNoTo = True
	End Function
	
	
	Private Sub tblCommon_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.DblClick
		
		wcCombo.Text = tblCommon.Columns(0).Text
		tblCommon.Visible = False
		wcCombo.Focus()
		System.Windows.Forms.SendKeys.Send("{Enter}")
		
	End Sub
	
	Private Sub tblCommon_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueDBGrid60.TrueDBGridEvents_KeyDownEvent) Handles tblCommon.KeyDownEvent
		
		If eventArgs.KeyCode = System.Windows.Forms.Keys.Escape Then
			eventArgs.KeyCode = System.Windows.Forms.Cursors.Default
			tblCommon.Visible = False
			wcCombo.Focus()
		ElseIf eventArgs.KeyCode = System.Windows.Forms.Keys.Return Then 
			eventArgs.KeyCode = System.Windows.Forms.Cursors.Default
			wcCombo.Text = tblCommon.Columns(0).Text
			tblCommon.Visible = False
			wcCombo.Focus()
			System.Windows.Forms.SendKeys.Send("{Enter}")
		End If
		
	End Sub
	
	Private Sub tblCommon_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tblCommon.Leave
		
		tblCommon.Visible = False
		If wcCombo.Enabled = True Then wcCombo.Focus()
		
	End Sub
End Class