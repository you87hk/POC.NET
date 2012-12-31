Option Strict Off
Option Explicit On
Friend Class frmICP004
	Inherits System.Windows.Forms.Form
	
	Dim wsFormID As String
	Dim waScrItm As New XArrayDBObject.XArrayDB
	Dim wcCombo As System.Windows.Forms.Control
	Dim wgsTitle As String
	Private wsFormCaption As String
	
	Private Const tcGo As String = "Go"
	Private Const tcCancel As String = "Cancel"
	Private Const tcExit As String = "Exit"
	
	Private wsMsg As String
	
	Private Sub cmdCancel()
		Ini_Scr()
		cboItmCodeFr.Focus()
	End Sub
	
	Private Sub cmdOK()
		Dim wsDteTim As String
		Dim wsSQL As String
		Dim wsSelection() As String
		Dim NewfrmPrint As New frmPrint
		Dim wsRptName As String
		
		If InputValidation = False Then Exit Sub
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'Create Selection Criteria
		ReDim wsSelection(3)
		wsSelection(1) = lblItmCodeFr.Text & " " & Set_Quote(cboItmCodeFr.Text) & " " & lblItmCodeTo.Text & " " & Set_Quote(cboItmCodeTo.Text)
		wsSelection(2) = lblItmTypeCodeFr.Text & " " & Set_Quote(Me.cboItmTypeCodeFr.Text) & " " & lblItmTypeCodeTo.Text & " " & Set_Quote(cboItmTypeCodeTo.Text)
		wsSelection(3) = lblWhsCodeFr.Text & " " & Set_Quote(cboWhsCodeFr.Text) & " " & lblWhsCodeTo.Text & " " & Set_Quote(cboWhsCodeTo.Text)
		
		'Create Stored Procedure String
		wsDteTim = CStr(Now)
		wsSQL = "EXEC usp_RPTICP004 '" & Set_Quote(gsUserID) & "', "
		wsSQL = wsSQL & "'" & Change_SQLDate(wsDteTim) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(txtTitle.Text) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboItmCodeFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboItmCodeTo.Text) = "", New String("z", 30), Set_Quote(cboItmCodeTo.Text)) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboItmTypeCodeFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboItmTypeCodeTo.Text) = "", New String("z", 10), Set_Quote(cboItmTypeCodeTo.Text)) & "', "
		wsSQL = wsSQL & "'" & Set_Quote(cboWhsCodeFr.Text) & "', "
		wsSQL = wsSQL & "'" & IIf(Trim(cboWhsCodeTo.Text) = "", New String("z", 10), Set_Quote(cboWhsCodeTo.Text)) & "', "
		wsSQL = wsSQL & "'" & IIf(chkNoZero.CheckState = 1, "Y", "N") & "', "
		wsSQL = wsSQL & "'" & IIf(chkShowBin.CheckState = 1, "Y", "N") & "', "
		wsSQL = wsSQL & gsLangID
		
		If gsLangID = "2" Then
			wsRptName = "C" & "RPTICP004"
		Else
			wsRptName = "RPTICP004"
		End If
		
		If chkShowBin.CheckState = 1 Then
			wsRptName = wsRptName & "B"
		End If
		
		NewfrmPrint.ReportID = "ICP004"
		NewfrmPrint.RptTitle = Me.Text
		NewfrmPrint.TableID = "ICP004"
		NewfrmPrint.RptDteTim = wsDteTim
		NewfrmPrint.StoreP = wsSQL
		NewfrmPrint.Selection = VB6.CopyArray(wsSelection)
		NewfrmPrint.RptName = wsRptName
		NewfrmPrint.ShowDialog()
		
		'UPGRADE_NOTE: Object NewfrmPrint may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		NewfrmPrint = Nothing
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub chkNoZero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkNoZero.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			
			cboItmCodeFr.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub chkShowBin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles chkShowBin.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			
			cboItmCodeFr.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub frmICP004_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
	
	Private Sub frmICP004_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		Call Ini_Form()
		Call Ini_Caption()
		Call Ini_Scr()
		
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub Ini_Form()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		wsFormID = "ICP004"
		
	End Sub
	
	Private Sub Ini_Scr()
		
		Me.Text = wsFormCaption
		
		tblCommon.Visible = False
		cboItmCodeFr.Text = ""
		cboItmCodeTo.Text = ""
		
		cboItmTypeCodeFr.Text = ""
		cboItmTypeCodeTo.Text = ""
		cboWhsCodeFr.Text = Get_WorkStation_Info("WSWHSCODE")
		cboWhsCodeTo.Text = cboWhsCodeFr.Text
		chkNoZero.CheckState = System.Windows.Forms.CheckState.Checked
		chkShowBin.CheckState = System.Windows.Forms.CheckState.Unchecked
		
		wgsTitle = "Stock In/Out Ledger"
		
	End Sub
	
	Private Function InputValidation() As Boolean
		
		InputValidation = False
		
		'If chk_cboMethodCodeTo = False Then
		'    cboMethodCodeTo.SetFocus
		'    Exit Function
		'End If
		
		InputValidation = True
		
	End Function
	
	'UPGRADE_WARNING: Event frmICP004.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmICP004_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = 0 Then
			Me.Height = VB6.TwipsToPixelsY(3840)
			Me.Width = VB6.TwipsToPixelsX(9315)
		End If
	End Sub
	
	Private Sub frmICP004_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: Object waScrItm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		waScrItm = Nothing
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		'UPGRADE_NOTE: Object frmICP004 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Me = Nothing
	End Sub
	
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
		
		
		On Error GoTo tblCommon_LostFocus_Err
		
		tblCommon.Visible = False
		If wcCombo.Enabled = True Then
			wcCombo.Focus()
		Else
			'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			wcCombo = Nothing
		End If
		
		Exit Sub
tblCommon_LostFocus_Err: 
		
		'UPGRADE_NOTE: Object wcCombo may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		wcCombo = Nothing
		
	End Sub
	
	Private Sub Ini_Caption()
		Call Get_Scr_Item(wsFormID, waScrItm)
		
		wsFormCaption = Get_Caption(waScrItm, "SCRHDR")
		
		lblTitle.Text = Get_Caption(waScrItm, "TITLE")
		txtTitle.Text = Get_Caption(waScrItm, "RPTTITLE")
		lblItmCodeFr.Text = Get_Caption(waScrItm, "ITMCODEFR")
		lblItmCodeTo.Text = Get_Caption(waScrItm, "ITMCODETO")
		lblItmTypeCodeFr.Text = Get_Caption(waScrItm, "ITMTYPECODEFR")
		lblItmTypeCodeTo.Text = Get_Caption(waScrItm, "ITMTYPECODETO")
		lblWhsCodeFr.Text = Get_Caption(waScrItm, "WHSCODEFR")
		lblWhsCodeTo.Text = Get_Caption(waScrItm, "WHSCODETO")
		chkNoZero.Text = Get_Caption(waScrItm, "NOZERO")
		chkShowBin.Text = Get_Caption(waScrItm, "SHOWBIN")
		
		
		
		
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
	
	Private Sub txtTitle_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Enter
		FocusMe(txtTitle)
	End Sub
	
	Private Sub txtTitle_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtTitle.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(txtTitle, 60, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			
			cboItmCodeFr.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtTitle_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTitle.Leave
		FocusMe(txtTitle, True)
	End Sub
	
	Private Sub cboItmCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmCodeFr
		
		wsSQL = "SELECT ItmCode, ItmItmTypeCode, " & IIf(gsLangID = "1", "ItmEngName", "ItmChiName") & " "
		wsSQL = wsSQL & " FROM mstItem "
		wsSQL = wsSQL & " WHERE ItmCode LIKE '%" & IIf(cboItmCodeFr.SelectionLength > 0, "", Set_Quote(cboItmCodeFr.Text)) & "%' "
		wsSQL = wsSQL & " AND ItmSTATUS = '1' "
		wsSQL = wsSQL & " ORDER BY ItmCode "
		
		Call Ini_Combo(3, wsSQL, (VB6.PixelsToTwipsX(cboItmCodeFr.Left)), VB6.PixelsToTwipsY(cboItmCodeFr.Top) + VB6.PixelsToTwipsY(cboItmCodeFr.Height), tblCommon, wsFormID, "TBLItmCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboItmCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.Enter
		FocusMe(cboItmCodeFr)
		wcCombo = cboItmCodeFr
	End Sub
	
	Private Sub cboItmCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmCodeFr, 30, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			
			If Trim(cboItmCodeFr.Text) <> "" And Trim(cboItmCodeTo.Text) = "" Then
				cboItmCodeTo.Text = cboItmCodeFr.Text
			End If
			
			cboItmCodeTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeFr.Leave
		FocusMe(cboItmCodeFr, True)
	End Sub
	
	Private Sub cboItmCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmCodeTo
		
		wsSQL = "SELECT ItmCode, ItmItmTypeCode, " & IIf(gsLangID = "1", "ItmEngName", "ItmChiName") & " "
		wsSQL = wsSQL & " FROM mstItem "
		wsSQL = wsSQL & " WHERE ItmCode LIKE '%" & IIf(cboItmCodeTo.SelectionLength > 0, "", Set_Quote(cboItmCodeTo.Text)) & "%' "
		wsSQL = wsSQL & " AND ItmSTATUS = '1' "
		wsSQL = wsSQL & " ORDER BY ItmCode "
		
		Call Ini_Combo(3, wsSQL, (VB6.PixelsToTwipsX(cboItmCodeTo.Left)), VB6.PixelsToTwipsY(cboItmCodeTo.Top) + VB6.PixelsToTwipsY(cboItmCodeTo.Height), tblCommon, wsFormID, "TBLItmCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboItmCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.Enter
		FocusMe(cboItmCodeTo)
		wcCombo = cboItmCodeTo
	End Sub
	
	Private Sub cboItmCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmCodeTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmCodeTo, 30, KeyAscii)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			
			If chk_cboItmCodeTo = False Then
				Call cboItmCodeTo_Enter(cboItmCodeTo, New System.EventArgs())
				GoTo EventExitSub
			End If
			
			cboItmTypeCodeFr.Focus()
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmCodeTo.Leave
		FocusMe(cboItmCodeTo, True)
	End Sub
	
	Private Function chk_cboItmCodeTo() As Boolean
		chk_cboItmCodeTo = False
		
		If UCase(cboItmCodeFr.Text) > UCase(cboItmCodeTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			Exit Function
		End If
		
		chk_cboItmCodeTo = True
	End Function
	
	
	Private Sub cboItmTypeCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmTypeCodeFr
		
		If gsLangID = "1" Then
			wsSQL = "SELECT ItmTypeCode, ItmTypeEngDesc FROM MstItemType "
		Else
			wsSQL = "SELECT ItmTypeCode, ItmTypeChiDesc FROM MstItemType "
		End If
		wsSQL = wsSQL & " WHERE ItmTypeStatus = '1'"
		wsSQL = wsSQL & " AND ItmTypeCode LIKE '%" & IIf(cboItmTypeCodeFr.SelectionLength > 0, "", Set_Quote(cboItmTypeCodeFr.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY ItmTypeCode "
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboItmTypeCodeFr.Left)), VB6.PixelsToTwipsY(cboItmTypeCodeFr.Top) + VB6.PixelsToTwipsY(cboItmTypeCodeFr.Height), tblCommon, wsFormID, "TBLItmTypeCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboItmTypeCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeFr.Enter
		FocusMe(cboItmTypeCodeFr)
		wcCombo = cboItmTypeCodeFr
	End Sub
	
	Private Sub cboItmTypeCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmTypeCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmTypeCodeFr, 15, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			If Trim(cboItmTypeCodeFr.Text) <> "" And Trim(cboItmTypeCodeTo.Text) = "" Then
				cboItmTypeCodeTo.Text = cboItmTypeCodeFr.Text
			End If
			cboItmTypeCodeTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmTypeCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeFr.Leave
		FocusMe(cboItmTypeCodeFr, True)
	End Sub
	
	Private Sub cboItmTypeCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboItmTypeCodeTo
		
		If gsLangID = "1" Then
			wsSQL = "SELECT ItmTypeCode, ItmTypeEngDesc FROM MstItemType "
		Else
			wsSQL = "SELECT ItmTypeCode, ItmTypeChiDesc FROM MstItemType "
		End If
		wsSQL = wsSQL & " WHERE ItmTypeStatus = '1'"
		wsSQL = wsSQL & " AND ItmTypeCode LIKE '%" & IIf(cboItmTypeCodeTo.SelectionLength > 0, "", Set_Quote(cboItmTypeCodeTo.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY ItmTypeCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboItmTypeCodeTo.Left)), VB6.PixelsToTwipsY(cboItmTypeCodeTo.Top) + VB6.PixelsToTwipsY(cboItmTypeCodeTo.Height), tblCommon, wsFormID, "TBLItmTypeCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboItmTypeCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.Enter
		FocusMe(cboItmTypeCodeTo)
		wcCombo = cboItmTypeCodeTo
	End Sub
	
	Private Sub cboItmTypeCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboItmTypeCodeTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboItmTypeCodeTo, 15, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			
			If chk_cboItmTypeCodeTo = False Then
				Call cboItmTypeCodeTo_Enter(cboItmTypeCodeTo, New System.EventArgs())
				GoTo EventExitSub
			End If
			
			cboWhsCodeFr.Focus()
			
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboItmTypeCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboItmTypeCodeTo.Leave
		FocusMe(cboItmTypeCodeTo, True)
	End Sub
	
	Private Function chk_cboItmTypeCodeTo() As Boolean
		chk_cboItmTypeCodeTo = False
		
		If UCase(cboItmTypeCodeFr.Text) > UCase(cboItmTypeCodeTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			Exit Function
		End If
		
		chk_cboItmTypeCodeTo = True
	End Function
	
	Private Sub cboWhsCodeFr_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeFr.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWhsCodeFr
		
		wsSQL = "SELECT WhsCode, WhsDesc FROM MstWarehouse "
		wsSQL = wsSQL & " WHERE WhsStatus = '1'"
		wsSQL = wsSQL & " AND WhsCode LIKE '%" & IIf(cboWhsCodeFr.SelectionLength > 0, "", Set_Quote(cboWhsCodeFr.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY WhsCode "
		
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboWhsCodeFr.Left)), VB6.PixelsToTwipsY(cboWhsCodeFr.Top) + VB6.PixelsToTwipsY(cboWhsCodeFr.Height), tblCommon, wsFormID, "TBLWhsCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboWhsCodeFr_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeFr.Enter
		FocusMe(cboWhsCodeFr)
		wcCombo = cboWhsCodeFr
	End Sub
	
	Private Sub cboWhsCodeFr_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWhsCodeFr.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWhsCodeFr, 15, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			If Trim(cboWhsCodeFr.Text) <> "" And Trim(cboWhsCodeTo.Text) = "" Then
				cboWhsCodeTo.Text = cboWhsCodeFr.Text
			End If
			cboWhsCodeTo.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWhsCodeFr_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeFr.Leave
		FocusMe(cboWhsCodeFr, True)
	End Sub
	
	Private Sub cboWhsCodeTo_DropDown(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeTo.DropDown
		Dim wsSQL As String
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		wcCombo = cboWhsCodeTo
		
		wsSQL = "SELECT WhsCode, WhsDesc FROM MstWarehouse "
		wsSQL = wsSQL & " WHERE WhsStatus = '1'"
		wsSQL = wsSQL & " AND WhsCode LIKE '%" & IIf(cboWhsCodeTo.SelectionLength > 0, "", Set_Quote(cboWhsCodeTo.Text)) & "%' "
		wsSQL = wsSQL & " ORDER BY WhsCode "
		Call Ini_Combo(2, wsSQL, (VB6.PixelsToTwipsX(cboWhsCodeTo.Left)), VB6.PixelsToTwipsY(cboWhsCodeTo.Top) + VB6.PixelsToTwipsY(cboWhsCodeTo.Height), tblCommon, wsFormID, "TBLWhsCode", VB6.PixelsToTwipsX(Me.Width), VB6.PixelsToTwipsY(Me.Height))
		
		tblCommon.Visible = True
		tblCommon.Focus()
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	Private Sub cboWhsCodeTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeTo.Enter
		FocusMe(cboWhsCodeTo)
		wcCombo = cboWhsCodeTo
	End Sub
	
	Private Sub cboWhsCodeTo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboWhsCodeTo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Call chk_InpLen(cboWhsCodeTo, 15, KeyAscii)
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = System.Windows.Forms.Cursors.Default
			
			If chk_cboWhsCodeTo = False Then
				cboWhsCodeTo.Focus()
				GoTo EventExitSub
			End If
			
			chkNoZero.Focus()
			
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub cboWhsCodeTo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboWhsCodeTo.Leave
		FocusMe(cboWhsCodeTo, True)
	End Sub
	
	Private Function chk_cboWhsCodeTo() As Boolean
		chk_cboWhsCodeTo = False
		
		If UCase(cboWhsCodeFr.Text) > UCase(cboWhsCodeTo.Text) Then
			gsMsg = "To > From!"
			MsgBox(gsMsg, MsgBoxStyle.OKOnly, gsTitle)
			
			Exit Function
		End If
		
		chk_cboWhsCodeTo = True
	End Function
End Class