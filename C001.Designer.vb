<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmC001
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents tblCommon As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents cboCusCode As System.Windows.Forms.ComboBox
	Public WithEvents txtSaleID As System.Windows.Forms.TextBox
	Public WithEvents iglProcess As System.Windows.Forms.ImageList
	Public WithEvents _tbrProcess_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button6 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button9 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button10 As System.Windows.Forms.ToolStripButton
	Public WithEvents _tbrProcess_Button11 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _tbrProcess_Button12 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbrProcess As System.Windows.Forms.ToolStrip
	Public WithEvents lblCusAddress1 As System.Windows.Forms.Label
	Public WithEvents lblDspCusRgnDesc As System.Windows.Forms.Label
	Public WithEvents lblCusRgnCode As System.Windows.Forms.Label
	Public WithEvents txtCusAddress1 As System.Windows.Forms.TextBox
	Public WithEvents txtCusAddress2 As System.Windows.Forms.TextBox
	Public WithEvents txtCusAddress3 As System.Windows.Forms.TextBox
	Public WithEvents txtCusAddress4 As System.Windows.Forms.TextBox
	Public WithEvents cboCusRgnCode As System.Windows.Forms.ComboBox
	Public WithEvents _tabDetailInfo_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents txtCusShipAdd12 As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipContactPerson2 As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipAdd32 As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipAdd42 As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipTel2 As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipAdd22 As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipFax2 As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipTerrName2 As System.Windows.Forms.TextBox
	Public WithEvents lblCusShipAdd2 As System.Windows.Forms.Label
	Public WithEvents lblCusShipContactPerson2 As System.Windows.Forms.Label
	Public WithEvents lblCusShipTel2 As System.Windows.Forms.Label
	Public WithEvents lblCusShipTerrCode2 As System.Windows.Forms.Label
	Public WithEvents fraCusShipAddr2 As System.Windows.Forms.GroupBox
	Public WithEvents txtCusShipTerrName As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipFax As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipAdd2 As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipTel As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipAdd4 As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipAdd3 As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipContactPerson As System.Windows.Forms.TextBox
	Public WithEvents txtCusShipAdd1 As System.Windows.Forms.TextBox
	Public WithEvents lblCusShipTerrCode As System.Windows.Forms.Label
	Public WithEvents lblCusShipTel As System.Windows.Forms.Label
	Public WithEvents lblCusShipContactPerson As System.Windows.Forms.Label
	Public WithEvents lblCusShipAdd1 As System.Windows.Forms.Label
	Public WithEvents fraCusShipAddr1 As System.Windows.Forms.GroupBox
	Public WithEvents cboCusShipTerrCode2 As System.Windows.Forms.ComboBox
	Public WithEvents cboCusShipTerrCode As System.Windows.Forms.ComboBox
	Public WithEvents _tabDetailInfo_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents lblCusSpecDis As System.Windows.Forms.Label
	Public WithEvents lblCusCurr As System.Windows.Forms.Label
	Public WithEvents lblCusPayCode As System.Windows.Forms.Label
	Public WithEvents lblCusCreditLimit As System.Windows.Forms.Label
	Public WithEvents lblCusSaleName As System.Windows.Forms.Label
	Public WithEvents lblCusMLCode As System.Windows.Forms.Label
	Public WithEvents lblDspCusMLDesc As System.Windows.Forms.Label
	Public WithEvents lblCusRemark As System.Windows.Forms.Label
	Public WithEvents lblDspCusLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblDspCusLastUpd As System.Windows.Forms.Label
	Public WithEvents lblCusLastUpdDate As System.Windows.Forms.Label
	Public WithEvents lblCusLastUpd As System.Windows.Forms.Label
	Public WithEvents lblDspCusSaleName As System.Windows.Forms.Label
	Public WithEvents cboCusPayCode As System.Windows.Forms.ComboBox
	Public WithEvents cboCusCurr As System.Windows.Forms.ComboBox
	Public WithEvents cboCusSaleCode As System.Windows.Forms.ComboBox
	Public WithEvents txtCusSpecDis As System.Windows.Forms.TextBox
	Public WithEvents txtCusPayDesc As System.Windows.Forms.TextBox
	Public WithEvents txtCusCreditLimit As System.Windows.Forms.TextBox
	Public WithEvents cboCusMLCode As System.Windows.Forms.ComboBox
	Public WithEvents txtCusRemark As System.Windows.Forms.TextBox
	Public WithEvents _tabDetailInfo_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents tblDetail As AxTrueDBGrid60.AxTDBGrid
	Public WithEvents lblOpenBal As System.Windows.Forms.Label
	Public WithEvents lblDspOpenBal As System.Windows.Forms.Label
	Public WithEvents lblDspARBal As System.Windows.Forms.Label
	Public WithEvents lblARBal As System.Windows.Forms.Label
	Public WithEvents lblDspCloseBal As System.Windows.Forms.Label
	Public WithEvents lblCloseBal As System.Windows.Forms.Label
	Public WithEvents lblAcmMnSale As System.Windows.Forms.Label
	Public WithEvents lblDspAcmMnSaleNet As System.Windows.Forms.Label
	Public WithEvents lblDspAcmMnSaleAmt As System.Windows.Forms.Label
	Public WithEvents lblDspAcmMnSaleQty As System.Windows.Forms.Label
	Public WithEvents lblAcmYrSale As System.Windows.Forms.Label
	Public WithEvents lblDspAcmYrSaleNet As System.Windows.Forms.Label
	Public WithEvents lblDspAcmYrSaleAmt As System.Windows.Forms.Label
	Public WithEvents lblDspAcmYrSaleQty As System.Windows.Forms.Label
	Public WithEvents lblAcmSale As System.Windows.Forms.Label
	Public WithEvents lblDspAcmSaleNet As System.Windows.Forms.Label
	Public WithEvents lblDspAcmSaleAmt As System.Windows.Forms.Label
	Public WithEvents lblNet As System.Windows.Forms.Label
	Public WithEvents lblAmt As System.Windows.Forms.Label
	Public WithEvents lblDspAcmSaleQty As System.Windows.Forms.Label
	Public WithEvents lblQty As System.Windows.Forms.Label
	Public WithEvents lblCusCrtDate As System.Windows.Forms.Label
	Public WithEvents lblDspCrtDate As System.Windows.Forms.Label
	Public WithEvents _tabDetailInfo_TabPage3 As System.Windows.Forms.TabPage
	Public WithEvents tabDetailInfo As System.Windows.Forms.TabControl
	Public WithEvents txtCusContactPerson1 As System.Windows.Forms.TextBox
	Public WithEvents txtCusName As System.Windows.Forms.TextBox
	Public WithEvents txtCusTel As System.Windows.Forms.TextBox
	Public WithEvents txtCusFax As System.Windows.Forms.TextBox
	Public WithEvents chkBadList As System.Windows.Forms.CheckBox
	Public WithEvents chkInActive As System.Windows.Forms.CheckBox
	Public WithEvents txtCusContactPerson As System.Windows.Forms.TextBox
	Public WithEvents txtCusEmail As System.Windows.Forms.TextBox
	Public WithEvents txtCusCode As System.Windows.Forms.TextBox
	Public WithEvents lblCusContactPerson1 As System.Windows.Forms.Label
	Public WithEvents lblCusCode As System.Windows.Forms.Label
	Public WithEvents lblCusName As System.Windows.Forms.Label
	Public WithEvents lblCusTel As System.Windows.Forms.Label
	Public WithEvents lblCusFax As System.Windows.Forms.Label
	Public WithEvents lblCusContactPerson As System.Windows.Forms.Label
	Public WithEvents lblCusEmail As System.Windows.Forms.Label
	Public WithEvents fraCustomerInfo As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmC001))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.tblCommon = New AxTrueDBGrid60.AxTDBGrid
		Me.cboCusCode = New System.Windows.Forms.ComboBox
		Me.txtSaleID = New System.Windows.Forms.TextBox
		Me.iglProcess = New System.Windows.Forms.ImageList
		Me.tbrProcess = New System.Windows.Forms.ToolStrip
		Me._tbrProcess_Button1 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button2 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button3 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button4 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button5 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button6 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button7 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button8 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button9 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button10 = New System.Windows.Forms.ToolStripButton
		Me._tbrProcess_Button11 = New System.Windows.Forms.ToolStripSeparator
		Me._tbrProcess_Button12 = New System.Windows.Forms.ToolStripButton
		Me.tabDetailInfo = New System.Windows.Forms.TabControl
		Me._tabDetailInfo_TabPage0 = New System.Windows.Forms.TabPage
		Me.lblCusAddress1 = New System.Windows.Forms.Label
		Me.lblDspCusRgnDesc = New System.Windows.Forms.Label
		Me.lblCusRgnCode = New System.Windows.Forms.Label
		Me.txtCusAddress1 = New System.Windows.Forms.TextBox
		Me.txtCusAddress2 = New System.Windows.Forms.TextBox
		Me.txtCusAddress3 = New System.Windows.Forms.TextBox
		Me.txtCusAddress4 = New System.Windows.Forms.TextBox
		Me.cboCusRgnCode = New System.Windows.Forms.ComboBox
		Me._tabDetailInfo_TabPage1 = New System.Windows.Forms.TabPage
		Me.fraCusShipAddr2 = New System.Windows.Forms.GroupBox
		Me.txtCusShipAdd12 = New System.Windows.Forms.TextBox
		Me.txtCusShipContactPerson2 = New System.Windows.Forms.TextBox
		Me.txtCusShipAdd32 = New System.Windows.Forms.TextBox
		Me.txtCusShipAdd42 = New System.Windows.Forms.TextBox
		Me.txtCusShipTel2 = New System.Windows.Forms.TextBox
		Me.txtCusShipAdd22 = New System.Windows.Forms.TextBox
		Me.txtCusShipFax2 = New System.Windows.Forms.TextBox
		Me.txtCusShipTerrName2 = New System.Windows.Forms.TextBox
		Me.lblCusShipAdd2 = New System.Windows.Forms.Label
		Me.lblCusShipContactPerson2 = New System.Windows.Forms.Label
		Me.lblCusShipTel2 = New System.Windows.Forms.Label
		Me.lblCusShipTerrCode2 = New System.Windows.Forms.Label
		Me.fraCusShipAddr1 = New System.Windows.Forms.GroupBox
		Me.txtCusShipTerrName = New System.Windows.Forms.TextBox
		Me.txtCusShipFax = New System.Windows.Forms.TextBox
		Me.txtCusShipAdd2 = New System.Windows.Forms.TextBox
		Me.txtCusShipTel = New System.Windows.Forms.TextBox
		Me.txtCusShipAdd4 = New System.Windows.Forms.TextBox
		Me.txtCusShipAdd3 = New System.Windows.Forms.TextBox
		Me.txtCusShipContactPerson = New System.Windows.Forms.TextBox
		Me.txtCusShipAdd1 = New System.Windows.Forms.TextBox
		Me.lblCusShipTerrCode = New System.Windows.Forms.Label
		Me.lblCusShipTel = New System.Windows.Forms.Label
		Me.lblCusShipContactPerson = New System.Windows.Forms.Label
		Me.lblCusShipAdd1 = New System.Windows.Forms.Label
		Me.cboCusShipTerrCode2 = New System.Windows.Forms.ComboBox
		Me.cboCusShipTerrCode = New System.Windows.Forms.ComboBox
		Me._tabDetailInfo_TabPage2 = New System.Windows.Forms.TabPage
		Me.lblCusSpecDis = New System.Windows.Forms.Label
		Me.lblCusCurr = New System.Windows.Forms.Label
		Me.lblCusPayCode = New System.Windows.Forms.Label
		Me.lblCusCreditLimit = New System.Windows.Forms.Label
		Me.lblCusSaleName = New System.Windows.Forms.Label
		Me.lblCusMLCode = New System.Windows.Forms.Label
		Me.lblDspCusMLDesc = New System.Windows.Forms.Label
		Me.lblCusRemark = New System.Windows.Forms.Label
		Me.lblDspCusLastUpdDate = New System.Windows.Forms.Label
		Me.lblDspCusLastUpd = New System.Windows.Forms.Label
		Me.lblCusLastUpdDate = New System.Windows.Forms.Label
		Me.lblCusLastUpd = New System.Windows.Forms.Label
		Me.lblDspCusSaleName = New System.Windows.Forms.Label
		Me.cboCusPayCode = New System.Windows.Forms.ComboBox
		Me.cboCusCurr = New System.Windows.Forms.ComboBox
		Me.cboCusSaleCode = New System.Windows.Forms.ComboBox
		Me.txtCusSpecDis = New System.Windows.Forms.TextBox
		Me.txtCusPayDesc = New System.Windows.Forms.TextBox
		Me.txtCusCreditLimit = New System.Windows.Forms.TextBox
		Me.cboCusMLCode = New System.Windows.Forms.ComboBox
		Me.txtCusRemark = New System.Windows.Forms.TextBox
		Me._tabDetailInfo_TabPage3 = New System.Windows.Forms.TabPage
		Me.tblDetail = New AxTrueDBGrid60.AxTDBGrid
		Me.lblOpenBal = New System.Windows.Forms.Label
		Me.lblDspOpenBal = New System.Windows.Forms.Label
		Me.lblDspARBal = New System.Windows.Forms.Label
		Me.lblARBal = New System.Windows.Forms.Label
		Me.lblDspCloseBal = New System.Windows.Forms.Label
		Me.lblCloseBal = New System.Windows.Forms.Label
		Me.lblAcmMnSale = New System.Windows.Forms.Label
		Me.lblDspAcmMnSaleNet = New System.Windows.Forms.Label
		Me.lblDspAcmMnSaleAmt = New System.Windows.Forms.Label
		Me.lblDspAcmMnSaleQty = New System.Windows.Forms.Label
		Me.lblAcmYrSale = New System.Windows.Forms.Label
		Me.lblDspAcmYrSaleNet = New System.Windows.Forms.Label
		Me.lblDspAcmYrSaleAmt = New System.Windows.Forms.Label
		Me.lblDspAcmYrSaleQty = New System.Windows.Forms.Label
		Me.lblAcmSale = New System.Windows.Forms.Label
		Me.lblDspAcmSaleNet = New System.Windows.Forms.Label
		Me.lblDspAcmSaleAmt = New System.Windows.Forms.Label
		Me.lblNet = New System.Windows.Forms.Label
		Me.lblAmt = New System.Windows.Forms.Label
		Me.lblDspAcmSaleQty = New System.Windows.Forms.Label
		Me.lblQty = New System.Windows.Forms.Label
		Me.lblCusCrtDate = New System.Windows.Forms.Label
		Me.lblDspCrtDate = New System.Windows.Forms.Label
		Me.fraCustomerInfo = New System.Windows.Forms.GroupBox
		Me.txtCusContactPerson1 = New System.Windows.Forms.TextBox
		Me.txtCusName = New System.Windows.Forms.TextBox
		Me.txtCusTel = New System.Windows.Forms.TextBox
		Me.txtCusFax = New System.Windows.Forms.TextBox
		Me.chkBadList = New System.Windows.Forms.CheckBox
		Me.chkInActive = New System.Windows.Forms.CheckBox
		Me.txtCusContactPerson = New System.Windows.Forms.TextBox
		Me.txtCusEmail = New System.Windows.Forms.TextBox
		Me.txtCusCode = New System.Windows.Forms.TextBox
		Me.lblCusContactPerson1 = New System.Windows.Forms.Label
		Me.lblCusCode = New System.Windows.Forms.Label
		Me.lblCusName = New System.Windows.Forms.Label
		Me.lblCusTel = New System.Windows.Forms.Label
		Me.lblCusFax = New System.Windows.Forms.Label
		Me.lblCusContactPerson = New System.Windows.Forms.Label
		Me.lblCusEmail = New System.Windows.Forms.Label
		Me.tbrProcess.SuspendLayout()
		Me.tabDetailInfo.SuspendLayout()
		Me._tabDetailInfo_TabPage0.SuspendLayout()
		Me._tabDetailInfo_TabPage1.SuspendLayout()
		Me.fraCusShipAddr2.SuspendLayout()
		Me.fraCusShipAddr1.SuspendLayout()
		Me._tabDetailInfo_TabPage2.SuspendLayout()
		Me._tabDetailInfo_TabPage3.SuspendLayout()
		Me.fraCustomerInfo.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.Text = "客戶資料"
		Me.ClientSize = New System.Drawing.Size(663, 405)
		Me.Location = New System.Drawing.Point(44, 85)
		Me.Icon = CType(resources.GetObject("frmC001.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmC001"
		tblCommon.OcxState = CType(resources.GetObject("tblCommon.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblCommon.Size = New System.Drawing.Size(305, 138)
		Me.tblCommon.Location = New System.Drawing.Point(784, 32)
		Me.tblCommon.TabIndex = 43
		Me.tblCommon.Visible = False
		Me.tblCommon.Name = "tblCommon"
		Me.cboCusCode.Size = New System.Drawing.Size(159, 20)
		Me.cboCusCode.Location = New System.Drawing.Point(88, 64)
		Me.cboCusCode.TabIndex = 1
		Me.cboCusCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusCode.CausesValidation = True
		Me.cboCusCode.Enabled = True
		Me.cboCusCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusCode.IntegralHeight = True
		Me.cboCusCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusCode.Sorted = False
		Me.cboCusCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusCode.TabStop = True
		Me.cboCusCode.Visible = True
		Me.cboCusCode.Name = "cboCusCode"
		Me.txtSaleID.AutoSize = False
		Me.txtSaleID.Size = New System.Drawing.Size(33, 18)
		Me.txtSaleID.Location = New System.Drawing.Point(608, 40)
		Me.txtSaleID.TabIndex = 41
		Me.txtSaleID.Visible = False
		Me.txtSaleID.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSaleID.AcceptsReturn = True
		Me.txtSaleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSaleID.BackColor = System.Drawing.SystemColors.Window
		Me.txtSaleID.CausesValidation = True
		Me.txtSaleID.Enabled = True
		Me.txtSaleID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSaleID.HideSelection = True
		Me.txtSaleID.ReadOnly = False
		Me.txtSaleID.Maxlength = 0
		Me.txtSaleID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSaleID.MultiLine = False
		Me.txtSaleID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSaleID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSaleID.TabStop = True
		Me.txtSaleID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSaleID.Name = "txtSaleID"
		Me.iglProcess.ImageSize = New System.Drawing.Size(16, 16)
		Me.iglProcess.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.iglProcess.ImageStream = CType(resources.GetObject("iglProcess.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.iglProcess.Images.SetKeyName(0, "")
		Me.iglProcess.Images.SetKeyName(1, "")
		Me.iglProcess.Images.SetKeyName(2, "")
		Me.iglProcess.Images.SetKeyName(3, "")
		Me.iglProcess.Images.SetKeyName(4, "")
		Me.iglProcess.Images.SetKeyName(5, "")
		Me.iglProcess.Images.SetKeyName(6, "")
		Me.iglProcess.Images.SetKeyName(7, "")
		Me.iglProcess.Images.SetKeyName(8, "")
		Me.iglProcess.Images.SetKeyName(9, "")
		Me.iglProcess.Images.SetKeyName(10, "")
		Me.iglProcess.Images.SetKeyName(11, "")
		Me.tbrProcess.ShowItemToolTips = True
		Me.tbrProcess.Dock = System.Windows.Forms.DockStyle.Top
		Me.tbrProcess.Size = New System.Drawing.Size(663, 24)
		Me.tbrProcess.Location = New System.Drawing.Point(0, 0)
		Me.tbrProcess.TabIndex = 42
		Me.tbrProcess.ImageList = iglProcess
		Me.tbrProcess.Name = "tbrProcess"
		Me._tbrProcess_Button1.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button1.AutoSize = False
		Me._tbrProcess_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button2.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button2.AutoSize = False
		Me._tbrProcess_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button2.Name = "Open"
		Me._tbrProcess_Button2.ToolTipText = "開新視窗 (F8)"
		Me._tbrProcess_Button2.ImageIndex = 11
		Me._tbrProcess_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button3.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button3.AutoSize = False
		Me._tbrProcess_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button3.Name = "Add"
		Me._tbrProcess_Button3.ToolTipText = "新增 (F2)"
		Me._tbrProcess_Button3.ImageIndex = 0
		Me._tbrProcess_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button4.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button4.AutoSize = False
		Me._tbrProcess_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button4.Name = "Edit"
		Me._tbrProcess_Button4.ToolTipText = "修改 (F5)"
		Me._tbrProcess_Button4.ImageIndex = 1
		Me._tbrProcess_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button5.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button5.AutoSize = False
		Me._tbrProcess_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button5.Name = "Delete"
		Me._tbrProcess_Button5.ToolTipText = "刪除 (F3)"
		Me._tbrProcess_Button5.ImageIndex = 2
		Me._tbrProcess_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button6.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button6.AutoSize = False
		Me._tbrProcess_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button7.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button7.AutoSize = False
		Me._tbrProcess_Button7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button7.Name = "Save"
		Me._tbrProcess_Button7.ToolTipText = "儲存 (F10)"
		Me._tbrProcess_Button7.ImageIndex = 3
		Me._tbrProcess_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button8.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button8.AutoSize = False
		Me._tbrProcess_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button8.Name = "Cancel"
		Me._tbrProcess_Button8.ToolTipText = "取消 (F11)"
		Me._tbrProcess_Button8.ImageIndex = 4
		Me._tbrProcess_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button9.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button9.AutoSize = False
		Me._tbrProcess_Button9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button10.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button10.AutoSize = False
		Me._tbrProcess_Button10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button10.Name = "Find"
		Me._tbrProcess_Button10.ToolTipText = "尋找 (F9)"
		Me._tbrProcess_Button10.ImageIndex = 6
		Me._tbrProcess_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button11.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button11.AutoSize = False
		Me._tbrProcess_Button11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._tbrProcess_Button12.Size = New System.Drawing.Size(24, 22)
		Me._tbrProcess_Button12.AutoSize = False
		Me._tbrProcess_Button12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._tbrProcess_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._tbrProcess_Button12.Name = "Exit"
		Me._tbrProcess_Button12.ToolTipText = "退出 (F12)"
		Me._tbrProcess_Button12.ImageIndex = 8
		Me._tbrProcess_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tabDetailInfo.Size = New System.Drawing.Size(633, 225)
		Me.tabDetailInfo.Location = New System.Drawing.Point(8, 168)
		Me.tabDetailInfo.TabIndex = 51
		Me.tabDetailInfo.TabStop = False
		Me.tabDetailInfo.Alignment = System.Windows.Forms.TabAlignment.Bottom
		Me.tabDetailInfo.SelectedIndex = 2
		Me.tabDetailInfo.ItemSize = New System.Drawing.Size(42, 18)
		Me.tabDetailInfo.HotTrack = False
		Me.tabDetailInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabDetailInfo.Name = "tabDetailInfo"
		Me._tabDetailInfo_TabPage0.Text = "附加通訊資料"
		Me.lblCusAddress1.Text = "發票地址 :"
		Me.lblCusAddress1.Size = New System.Drawing.Size(57, 17)
		Me.lblCusAddress1.Location = New System.Drawing.Point(16, 24)
		Me.lblCusAddress1.TabIndex = 64
		Me.lblCusAddress1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusAddress1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusAddress1.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusAddress1.Enabled = True
		Me.lblCusAddress1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusAddress1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusAddress1.UseMnemonic = True
		Me.lblCusAddress1.Visible = True
		Me.lblCusAddress1.AutoSize = False
		Me.lblCusAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusAddress1.Name = "lblCusAddress1"
		Me.lblDspCusRgnDesc.Size = New System.Drawing.Size(351, 20)
		Me.lblDspCusRgnDesc.Location = New System.Drawing.Point(240, 116)
		Me.lblDspCusRgnDesc.TabIndex = 70
		Me.lblDspCusRgnDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCusRgnDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCusRgnDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCusRgnDesc.Enabled = True
		Me.lblDspCusRgnDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCusRgnDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCusRgnDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCusRgnDesc.UseMnemonic = True
		Me.lblDspCusRgnDesc.Visible = True
		Me.lblDspCusRgnDesc.AutoSize = False
		Me.lblDspCusRgnDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCusRgnDesc.Name = "lblDspCusRgnDesc"
		Me.lblCusRgnCode.Text = "CUSRGNCODE"
		Me.lblCusRgnCode.Size = New System.Drawing.Size(69, 16)
		Me.lblCusRgnCode.Location = New System.Drawing.Point(8, 120)
		Me.lblCusRgnCode.TabIndex = 71
		Me.lblCusRgnCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusRgnCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusRgnCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusRgnCode.Enabled = True
		Me.lblCusRgnCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusRgnCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusRgnCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusRgnCode.UseMnemonic = True
		Me.lblCusRgnCode.Visible = True
		Me.lblCusRgnCode.AutoSize = False
		Me.lblCusRgnCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusRgnCode.Name = "lblCusRgnCode"
		Me.txtCusAddress1.AutoSize = False
		Me.txtCusAddress1.Size = New System.Drawing.Size(513, 20)
		Me.txtCusAddress1.Location = New System.Drawing.Point(80, 20)
		Me.txtCusAddress1.TabIndex = 10
		Me.txtCusAddress1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusAddress1.AcceptsReturn = True
		Me.txtCusAddress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusAddress1.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusAddress1.CausesValidation = True
		Me.txtCusAddress1.Enabled = True
		Me.txtCusAddress1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusAddress1.HideSelection = True
		Me.txtCusAddress1.ReadOnly = False
		Me.txtCusAddress1.Maxlength = 0
		Me.txtCusAddress1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusAddress1.MultiLine = False
		Me.txtCusAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusAddress1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusAddress1.TabStop = True
		Me.txtCusAddress1.Visible = True
		Me.txtCusAddress1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusAddress1.Name = "txtCusAddress1"
		Me.txtCusAddress2.AutoSize = False
		Me.txtCusAddress2.Size = New System.Drawing.Size(513, 20)
		Me.txtCusAddress2.Location = New System.Drawing.Point(80, 44)
		Me.txtCusAddress2.TabIndex = 11
		Me.txtCusAddress2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusAddress2.AcceptsReturn = True
		Me.txtCusAddress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusAddress2.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusAddress2.CausesValidation = True
		Me.txtCusAddress2.Enabled = True
		Me.txtCusAddress2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusAddress2.HideSelection = True
		Me.txtCusAddress2.ReadOnly = False
		Me.txtCusAddress2.Maxlength = 0
		Me.txtCusAddress2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusAddress2.MultiLine = False
		Me.txtCusAddress2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusAddress2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusAddress2.TabStop = True
		Me.txtCusAddress2.Visible = True
		Me.txtCusAddress2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusAddress2.Name = "txtCusAddress2"
		Me.txtCusAddress3.AutoSize = False
		Me.txtCusAddress3.Size = New System.Drawing.Size(513, 20)
		Me.txtCusAddress3.Location = New System.Drawing.Point(80, 68)
		Me.txtCusAddress3.TabIndex = 12
		Me.txtCusAddress3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusAddress3.AcceptsReturn = True
		Me.txtCusAddress3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusAddress3.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusAddress3.CausesValidation = True
		Me.txtCusAddress3.Enabled = True
		Me.txtCusAddress3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusAddress3.HideSelection = True
		Me.txtCusAddress3.ReadOnly = False
		Me.txtCusAddress3.Maxlength = 0
		Me.txtCusAddress3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusAddress3.MultiLine = False
		Me.txtCusAddress3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusAddress3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusAddress3.TabStop = True
		Me.txtCusAddress3.Visible = True
		Me.txtCusAddress3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusAddress3.Name = "txtCusAddress3"
		Me.txtCusAddress4.AutoSize = False
		Me.txtCusAddress4.Size = New System.Drawing.Size(513, 20)
		Me.txtCusAddress4.Location = New System.Drawing.Point(80, 92)
		Me.txtCusAddress4.TabIndex = 13
		Me.txtCusAddress4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusAddress4.AcceptsReturn = True
		Me.txtCusAddress4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusAddress4.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusAddress4.CausesValidation = True
		Me.txtCusAddress4.Enabled = True
		Me.txtCusAddress4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusAddress4.HideSelection = True
		Me.txtCusAddress4.ReadOnly = False
		Me.txtCusAddress4.Maxlength = 0
		Me.txtCusAddress4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusAddress4.MultiLine = False
		Me.txtCusAddress4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusAddress4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusAddress4.TabStop = True
		Me.txtCusAddress4.Visible = True
		Me.txtCusAddress4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusAddress4.Name = "txtCusAddress4"
		Me.cboCusRgnCode.Enabled = False
		Me.cboCusRgnCode.Size = New System.Drawing.Size(157, 20)
		Me.cboCusRgnCode.Location = New System.Drawing.Point(80, 116)
		Me.cboCusRgnCode.TabIndex = 14
		Me.cboCusRgnCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusRgnCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusRgnCode.CausesValidation = True
		Me.cboCusRgnCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusRgnCode.IntegralHeight = True
		Me.cboCusRgnCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusRgnCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusRgnCode.Sorted = False
		Me.cboCusRgnCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusRgnCode.TabStop = True
		Me.cboCusRgnCode.Visible = True
		Me.cboCusRgnCode.Name = "cboCusRgnCode"
		Me._tabDetailInfo_TabPage1.Text = "貨運資料"
		Me.fraCusShipAddr2.Text = "地址 (二)"
		Me.fraCusShipAddr2.Size = New System.Drawing.Size(297, 185)
		Me.fraCusShipAddr2.Location = New System.Drawing.Point(304, 8)
		Me.fraCusShipAddr2.TabIndex = 57
		Me.fraCusShipAddr2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraCusShipAddr2.BackColor = System.Drawing.SystemColors.Control
		Me.fraCusShipAddr2.Enabled = True
		Me.fraCusShipAddr2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraCusShipAddr2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraCusShipAddr2.Visible = True
		Me.fraCusShipAddr2.Padding = New System.Windows.Forms.Padding(0)
		Me.fraCusShipAddr2.Name = "fraCusShipAddr2"
		Me.txtCusShipAdd12.AutoSize = False
		Me.txtCusShipAdd12.Enabled = False
		Me.txtCusShipAdd12.Size = New System.Drawing.Size(209, 20)
		Me.txtCusShipAdd12.Location = New System.Drawing.Point(80, 16)
		Me.txtCusShipAdd12.TabIndex = 24
		Me.txtCusShipAdd12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipAdd12.AcceptsReturn = True
		Me.txtCusShipAdd12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipAdd12.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipAdd12.CausesValidation = True
		Me.txtCusShipAdd12.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipAdd12.HideSelection = True
		Me.txtCusShipAdd12.ReadOnly = False
		Me.txtCusShipAdd12.Maxlength = 0
		Me.txtCusShipAdd12.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipAdd12.MultiLine = False
		Me.txtCusShipAdd12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipAdd12.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipAdd12.TabStop = True
		Me.txtCusShipAdd12.Visible = True
		Me.txtCusShipAdd12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipAdd12.Name = "txtCusShipAdd12"
		Me.txtCusShipContactPerson2.AutoSize = False
		Me.txtCusShipContactPerson2.Enabled = False
		Me.txtCusShipContactPerson2.Size = New System.Drawing.Size(209, 20)
		Me.txtCusShipContactPerson2.Location = New System.Drawing.Point(80, 112)
		Me.txtCusShipContactPerson2.TabIndex = 28
		Me.txtCusShipContactPerson2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipContactPerson2.AcceptsReturn = True
		Me.txtCusShipContactPerson2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipContactPerson2.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipContactPerson2.CausesValidation = True
		Me.txtCusShipContactPerson2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipContactPerson2.HideSelection = True
		Me.txtCusShipContactPerson2.ReadOnly = False
		Me.txtCusShipContactPerson2.Maxlength = 0
		Me.txtCusShipContactPerson2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipContactPerson2.MultiLine = False
		Me.txtCusShipContactPerson2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipContactPerson2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipContactPerson2.TabStop = True
		Me.txtCusShipContactPerson2.Visible = True
		Me.txtCusShipContactPerson2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipContactPerson2.Name = "txtCusShipContactPerson2"
		Me.txtCusShipAdd32.AutoSize = False
		Me.txtCusShipAdd32.Enabled = False
		Me.txtCusShipAdd32.Size = New System.Drawing.Size(209, 20)
		Me.txtCusShipAdd32.Location = New System.Drawing.Point(80, 64)
		Me.txtCusShipAdd32.TabIndex = 26
		Me.txtCusShipAdd32.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipAdd32.AcceptsReturn = True
		Me.txtCusShipAdd32.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipAdd32.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipAdd32.CausesValidation = True
		Me.txtCusShipAdd32.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipAdd32.HideSelection = True
		Me.txtCusShipAdd32.ReadOnly = False
		Me.txtCusShipAdd32.Maxlength = 0
		Me.txtCusShipAdd32.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipAdd32.MultiLine = False
		Me.txtCusShipAdd32.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipAdd32.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipAdd32.TabStop = True
		Me.txtCusShipAdd32.Visible = True
		Me.txtCusShipAdd32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipAdd32.Name = "txtCusShipAdd32"
		Me.txtCusShipAdd42.AutoSize = False
		Me.txtCusShipAdd42.Enabled = False
		Me.txtCusShipAdd42.Size = New System.Drawing.Size(209, 20)
		Me.txtCusShipAdd42.Location = New System.Drawing.Point(80, 88)
		Me.txtCusShipAdd42.TabIndex = 27
		Me.txtCusShipAdd42.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipAdd42.AcceptsReturn = True
		Me.txtCusShipAdd42.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipAdd42.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipAdd42.CausesValidation = True
		Me.txtCusShipAdd42.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipAdd42.HideSelection = True
		Me.txtCusShipAdd42.ReadOnly = False
		Me.txtCusShipAdd42.Maxlength = 0
		Me.txtCusShipAdd42.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipAdd42.MultiLine = False
		Me.txtCusShipAdd42.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipAdd42.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipAdd42.TabStop = True
		Me.txtCusShipAdd42.Visible = True
		Me.txtCusShipAdd42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipAdd42.Name = "txtCusShipAdd42"
		Me.txtCusShipTel2.AutoSize = False
		Me.txtCusShipTel2.Enabled = False
		Me.txtCusShipTel2.Size = New System.Drawing.Size(95, 20)
		Me.txtCusShipTel2.Location = New System.Drawing.Point(80, 136)
		Me.txtCusShipTel2.TabIndex = 29
		Me.txtCusShipTel2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipTel2.AcceptsReturn = True
		Me.txtCusShipTel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipTel2.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipTel2.CausesValidation = True
		Me.txtCusShipTel2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipTel2.HideSelection = True
		Me.txtCusShipTel2.ReadOnly = False
		Me.txtCusShipTel2.Maxlength = 0
		Me.txtCusShipTel2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipTel2.MultiLine = False
		Me.txtCusShipTel2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipTel2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipTel2.TabStop = True
		Me.txtCusShipTel2.Visible = True
		Me.txtCusShipTel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipTel2.Name = "txtCusShipTel2"
		Me.txtCusShipAdd22.AutoSize = False
		Me.txtCusShipAdd22.Enabled = False
		Me.txtCusShipAdd22.Size = New System.Drawing.Size(209, 20)
		Me.txtCusShipAdd22.Location = New System.Drawing.Point(80, 40)
		Me.txtCusShipAdd22.TabIndex = 25
		Me.txtCusShipAdd22.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipAdd22.AcceptsReturn = True
		Me.txtCusShipAdd22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipAdd22.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipAdd22.CausesValidation = True
		Me.txtCusShipAdd22.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipAdd22.HideSelection = True
		Me.txtCusShipAdd22.ReadOnly = False
		Me.txtCusShipAdd22.Maxlength = 0
		Me.txtCusShipAdd22.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipAdd22.MultiLine = False
		Me.txtCusShipAdd22.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipAdd22.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipAdd22.TabStop = True
		Me.txtCusShipAdd22.Visible = True
		Me.txtCusShipAdd22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipAdd22.Name = "txtCusShipAdd22"
		Me.txtCusShipFax2.AutoSize = False
		Me.txtCusShipFax2.Enabled = False
		Me.txtCusShipFax2.Size = New System.Drawing.Size(105, 20)
		Me.txtCusShipFax2.Location = New System.Drawing.Point(184, 136)
		Me.txtCusShipFax2.TabIndex = 30
		Me.txtCusShipFax2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipFax2.AcceptsReturn = True
		Me.txtCusShipFax2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipFax2.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipFax2.CausesValidation = True
		Me.txtCusShipFax2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipFax2.HideSelection = True
		Me.txtCusShipFax2.ReadOnly = False
		Me.txtCusShipFax2.Maxlength = 0
		Me.txtCusShipFax2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipFax2.MultiLine = False
		Me.txtCusShipFax2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipFax2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipFax2.TabStop = True
		Me.txtCusShipFax2.Visible = True
		Me.txtCusShipFax2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipFax2.Name = "txtCusShipFax2"
		Me.txtCusShipTerrName2.AutoSize = False
		Me.txtCusShipTerrName2.Enabled = False
		Me.txtCusShipTerrName2.Size = New System.Drawing.Size(129, 20)
		Me.txtCusShipTerrName2.Location = New System.Drawing.Point(160, 160)
		Me.txtCusShipTerrName2.TabIndex = 32
		Me.txtCusShipTerrName2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipTerrName2.AcceptsReturn = True
		Me.txtCusShipTerrName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipTerrName2.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipTerrName2.CausesValidation = True
		Me.txtCusShipTerrName2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipTerrName2.HideSelection = True
		Me.txtCusShipTerrName2.ReadOnly = False
		Me.txtCusShipTerrName2.Maxlength = 0
		Me.txtCusShipTerrName2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipTerrName2.MultiLine = False
		Me.txtCusShipTerrName2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipTerrName2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipTerrName2.TabStop = True
		Me.txtCusShipTerrName2.Visible = True
		Me.txtCusShipTerrName2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipTerrName2.Name = "txtCusShipTerrName2"
		Me.lblCusShipAdd2.Text = "送貨地址 :"
		Me.lblCusShipAdd2.Size = New System.Drawing.Size(60, 40)
		Me.lblCusShipAdd2.Location = New System.Drawing.Point(8, 20)
		Me.lblCusShipAdd2.TabIndex = 61
		Me.lblCusShipAdd2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusShipAdd2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusShipAdd2.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusShipAdd2.Enabled = True
		Me.lblCusShipAdd2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusShipAdd2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusShipAdd2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusShipAdd2.UseMnemonic = True
		Me.lblCusShipAdd2.Visible = True
		Me.lblCusShipAdd2.AutoSize = False
		Me.lblCusShipAdd2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusShipAdd2.Name = "lblCusShipAdd2"
		Me.lblCusShipContactPerson2.Text = "聯絡人 :"
		Me.lblCusShipContactPerson2.Size = New System.Drawing.Size(60, 16)
		Me.lblCusShipContactPerson2.Location = New System.Drawing.Point(8, 115)
		Me.lblCusShipContactPerson2.TabIndex = 60
		Me.lblCusShipContactPerson2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusShipContactPerson2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusShipContactPerson2.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusShipContactPerson2.Enabled = True
		Me.lblCusShipContactPerson2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusShipContactPerson2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusShipContactPerson2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusShipContactPerson2.UseMnemonic = True
		Me.lblCusShipContactPerson2.Visible = True
		Me.lblCusShipContactPerson2.AutoSize = False
		Me.lblCusShipContactPerson2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusShipContactPerson2.Name = "lblCusShipContactPerson2"
		Me.lblCusShipTel2.Text = "電話 / 傳真 :"
		Me.lblCusShipTel2.Size = New System.Drawing.Size(68, 16)
		Me.lblCusShipTel2.Location = New System.Drawing.Point(8, 140)
		Me.lblCusShipTel2.TabIndex = 59
		Me.lblCusShipTel2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusShipTel2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusShipTel2.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusShipTel2.Enabled = True
		Me.lblCusShipTel2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusShipTel2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusShipTel2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusShipTel2.UseMnemonic = True
		Me.lblCusShipTel2.Visible = True
		Me.lblCusShipTel2.AutoSize = False
		Me.lblCusShipTel2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusShipTel2.Name = "lblCusShipTel2"
		Me.lblCusShipTerrCode2.Text = "分區代號 :"
		Me.lblCusShipTerrCode2.Size = New System.Drawing.Size(68, 16)
		Me.lblCusShipTerrCode2.Location = New System.Drawing.Point(8, 164)
		Me.lblCusShipTerrCode2.TabIndex = 58
		Me.lblCusShipTerrCode2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusShipTerrCode2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusShipTerrCode2.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusShipTerrCode2.Enabled = True
		Me.lblCusShipTerrCode2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusShipTerrCode2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusShipTerrCode2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusShipTerrCode2.UseMnemonic = True
		Me.lblCusShipTerrCode2.Visible = True
		Me.lblCusShipTerrCode2.AutoSize = False
		Me.lblCusShipTerrCode2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusShipTerrCode2.Name = "lblCusShipTerrCode2"
		Me.fraCusShipAddr1.Text = "地址 (一)"
		Me.fraCusShipAddr1.Size = New System.Drawing.Size(297, 185)
		Me.fraCusShipAddr1.Location = New System.Drawing.Point(8, 8)
		Me.fraCusShipAddr1.TabIndex = 52
		Me.fraCusShipAddr1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraCusShipAddr1.BackColor = System.Drawing.SystemColors.Control
		Me.fraCusShipAddr1.Enabled = True
		Me.fraCusShipAddr1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraCusShipAddr1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraCusShipAddr1.Visible = True
		Me.fraCusShipAddr1.Padding = New System.Windows.Forms.Padding(0)
		Me.fraCusShipAddr1.Name = "fraCusShipAddr1"
		Me.txtCusShipTerrName.AutoSize = False
		Me.txtCusShipTerrName.Enabled = False
		Me.txtCusShipTerrName.Size = New System.Drawing.Size(129, 20)
		Me.txtCusShipTerrName.Location = New System.Drawing.Point(160, 160)
		Me.txtCusShipTerrName.TabIndex = 23
		Me.txtCusShipTerrName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipTerrName.AcceptsReturn = True
		Me.txtCusShipTerrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipTerrName.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipTerrName.CausesValidation = True
		Me.txtCusShipTerrName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipTerrName.HideSelection = True
		Me.txtCusShipTerrName.ReadOnly = False
		Me.txtCusShipTerrName.Maxlength = 0
		Me.txtCusShipTerrName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipTerrName.MultiLine = False
		Me.txtCusShipTerrName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipTerrName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipTerrName.TabStop = True
		Me.txtCusShipTerrName.Visible = True
		Me.txtCusShipTerrName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipTerrName.Name = "txtCusShipTerrName"
		Me.txtCusShipFax.AutoSize = False
		Me.txtCusShipFax.Enabled = False
		Me.txtCusShipFax.Size = New System.Drawing.Size(105, 20)
		Me.txtCusShipFax.Location = New System.Drawing.Point(184, 136)
		Me.txtCusShipFax.TabIndex = 21
		Me.txtCusShipFax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipFax.AcceptsReturn = True
		Me.txtCusShipFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipFax.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipFax.CausesValidation = True
		Me.txtCusShipFax.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipFax.HideSelection = True
		Me.txtCusShipFax.ReadOnly = False
		Me.txtCusShipFax.Maxlength = 0
		Me.txtCusShipFax.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipFax.MultiLine = False
		Me.txtCusShipFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipFax.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipFax.TabStop = True
		Me.txtCusShipFax.Visible = True
		Me.txtCusShipFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipFax.Name = "txtCusShipFax"
		Me.txtCusShipAdd2.AutoSize = False
		Me.txtCusShipAdd2.Enabled = False
		Me.txtCusShipAdd2.Size = New System.Drawing.Size(209, 20)
		Me.txtCusShipAdd2.Location = New System.Drawing.Point(80, 40)
		Me.txtCusShipAdd2.TabIndex = 16
		Me.txtCusShipAdd2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipAdd2.AcceptsReturn = True
		Me.txtCusShipAdd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipAdd2.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipAdd2.CausesValidation = True
		Me.txtCusShipAdd2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipAdd2.HideSelection = True
		Me.txtCusShipAdd2.ReadOnly = False
		Me.txtCusShipAdd2.Maxlength = 0
		Me.txtCusShipAdd2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipAdd2.MultiLine = False
		Me.txtCusShipAdd2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipAdd2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipAdd2.TabStop = True
		Me.txtCusShipAdd2.Visible = True
		Me.txtCusShipAdd2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipAdd2.Name = "txtCusShipAdd2"
		Me.txtCusShipTel.AutoSize = False
		Me.txtCusShipTel.Enabled = False
		Me.txtCusShipTel.Size = New System.Drawing.Size(95, 20)
		Me.txtCusShipTel.Location = New System.Drawing.Point(80, 136)
		Me.txtCusShipTel.TabIndex = 20
		Me.txtCusShipTel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipTel.AcceptsReturn = True
		Me.txtCusShipTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipTel.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipTel.CausesValidation = True
		Me.txtCusShipTel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipTel.HideSelection = True
		Me.txtCusShipTel.ReadOnly = False
		Me.txtCusShipTel.Maxlength = 0
		Me.txtCusShipTel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipTel.MultiLine = False
		Me.txtCusShipTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipTel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipTel.TabStop = True
		Me.txtCusShipTel.Visible = True
		Me.txtCusShipTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipTel.Name = "txtCusShipTel"
		Me.txtCusShipAdd4.AutoSize = False
		Me.txtCusShipAdd4.Enabled = False
		Me.txtCusShipAdd4.Size = New System.Drawing.Size(209, 20)
		Me.txtCusShipAdd4.Location = New System.Drawing.Point(80, 88)
		Me.txtCusShipAdd4.TabIndex = 18
		Me.txtCusShipAdd4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipAdd4.AcceptsReturn = True
		Me.txtCusShipAdd4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipAdd4.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipAdd4.CausesValidation = True
		Me.txtCusShipAdd4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipAdd4.HideSelection = True
		Me.txtCusShipAdd4.ReadOnly = False
		Me.txtCusShipAdd4.Maxlength = 0
		Me.txtCusShipAdd4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipAdd4.MultiLine = False
		Me.txtCusShipAdd4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipAdd4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipAdd4.TabStop = True
		Me.txtCusShipAdd4.Visible = True
		Me.txtCusShipAdd4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipAdd4.Name = "txtCusShipAdd4"
		Me.txtCusShipAdd3.AutoSize = False
		Me.txtCusShipAdd3.Enabled = False
		Me.txtCusShipAdd3.Size = New System.Drawing.Size(209, 20)
		Me.txtCusShipAdd3.Location = New System.Drawing.Point(80, 64)
		Me.txtCusShipAdd3.TabIndex = 17
		Me.txtCusShipAdd3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipAdd3.AcceptsReturn = True
		Me.txtCusShipAdd3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipAdd3.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipAdd3.CausesValidation = True
		Me.txtCusShipAdd3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipAdd3.HideSelection = True
		Me.txtCusShipAdd3.ReadOnly = False
		Me.txtCusShipAdd3.Maxlength = 0
		Me.txtCusShipAdd3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipAdd3.MultiLine = False
		Me.txtCusShipAdd3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipAdd3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipAdd3.TabStop = True
		Me.txtCusShipAdd3.Visible = True
		Me.txtCusShipAdd3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipAdd3.Name = "txtCusShipAdd3"
		Me.txtCusShipContactPerson.AutoSize = False
		Me.txtCusShipContactPerson.Enabled = False
		Me.txtCusShipContactPerson.Size = New System.Drawing.Size(209, 20)
		Me.txtCusShipContactPerson.Location = New System.Drawing.Point(80, 112)
		Me.txtCusShipContactPerson.TabIndex = 19
		Me.txtCusShipContactPerson.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipContactPerson.AcceptsReturn = True
		Me.txtCusShipContactPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipContactPerson.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipContactPerson.CausesValidation = True
		Me.txtCusShipContactPerson.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipContactPerson.HideSelection = True
		Me.txtCusShipContactPerson.ReadOnly = False
		Me.txtCusShipContactPerson.Maxlength = 0
		Me.txtCusShipContactPerson.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipContactPerson.MultiLine = False
		Me.txtCusShipContactPerson.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipContactPerson.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipContactPerson.TabStop = True
		Me.txtCusShipContactPerson.Visible = True
		Me.txtCusShipContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipContactPerson.Name = "txtCusShipContactPerson"
		Me.txtCusShipAdd1.AutoSize = False
		Me.txtCusShipAdd1.Enabled = False
		Me.txtCusShipAdd1.Size = New System.Drawing.Size(209, 20)
		Me.txtCusShipAdd1.Location = New System.Drawing.Point(80, 16)
		Me.txtCusShipAdd1.TabIndex = 15
		Me.txtCusShipAdd1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusShipAdd1.AcceptsReturn = True
		Me.txtCusShipAdd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusShipAdd1.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusShipAdd1.CausesValidation = True
		Me.txtCusShipAdd1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusShipAdd1.HideSelection = True
		Me.txtCusShipAdd1.ReadOnly = False
		Me.txtCusShipAdd1.Maxlength = 0
		Me.txtCusShipAdd1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusShipAdd1.MultiLine = False
		Me.txtCusShipAdd1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusShipAdd1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusShipAdd1.TabStop = True
		Me.txtCusShipAdd1.Visible = True
		Me.txtCusShipAdd1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusShipAdd1.Name = "txtCusShipAdd1"
		Me.lblCusShipTerrCode.Text = "分區代號 :"
		Me.lblCusShipTerrCode.Size = New System.Drawing.Size(68, 16)
		Me.lblCusShipTerrCode.Location = New System.Drawing.Point(8, 164)
		Me.lblCusShipTerrCode.TabIndex = 56
		Me.lblCusShipTerrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusShipTerrCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusShipTerrCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusShipTerrCode.Enabled = True
		Me.lblCusShipTerrCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusShipTerrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusShipTerrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusShipTerrCode.UseMnemonic = True
		Me.lblCusShipTerrCode.Visible = True
		Me.lblCusShipTerrCode.AutoSize = False
		Me.lblCusShipTerrCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusShipTerrCode.Name = "lblCusShipTerrCode"
		Me.lblCusShipTel.Text = "電話 / 傳真 :"
		Me.lblCusShipTel.Size = New System.Drawing.Size(68, 16)
		Me.lblCusShipTel.Location = New System.Drawing.Point(8, 140)
		Me.lblCusShipTel.TabIndex = 55
		Me.lblCusShipTel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusShipTel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusShipTel.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusShipTel.Enabled = True
		Me.lblCusShipTel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusShipTel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusShipTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusShipTel.UseMnemonic = True
		Me.lblCusShipTel.Visible = True
		Me.lblCusShipTel.AutoSize = False
		Me.lblCusShipTel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusShipTel.Name = "lblCusShipTel"
		Me.lblCusShipContactPerson.Text = "聯絡人 :"
		Me.lblCusShipContactPerson.Size = New System.Drawing.Size(60, 16)
		Me.lblCusShipContactPerson.Location = New System.Drawing.Point(8, 115)
		Me.lblCusShipContactPerson.TabIndex = 54
		Me.lblCusShipContactPerson.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusShipContactPerson.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusShipContactPerson.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusShipContactPerson.Enabled = True
		Me.lblCusShipContactPerson.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusShipContactPerson.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusShipContactPerson.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusShipContactPerson.UseMnemonic = True
		Me.lblCusShipContactPerson.Visible = True
		Me.lblCusShipContactPerson.AutoSize = False
		Me.lblCusShipContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusShipContactPerson.Name = "lblCusShipContactPerson"
		Me.lblCusShipAdd1.Text = "送貨地址 :"
		Me.lblCusShipAdd1.Size = New System.Drawing.Size(60, 40)
		Me.lblCusShipAdd1.Location = New System.Drawing.Point(8, 20)
		Me.lblCusShipAdd1.TabIndex = 53
		Me.lblCusShipAdd1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusShipAdd1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusShipAdd1.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusShipAdd1.Enabled = True
		Me.lblCusShipAdd1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusShipAdd1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusShipAdd1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusShipAdd1.UseMnemonic = True
		Me.lblCusShipAdd1.Visible = True
		Me.lblCusShipAdd1.AutoSize = False
		Me.lblCusShipAdd1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusShipAdd1.Name = "lblCusShipAdd1"
		Me.cboCusShipTerrCode2.Size = New System.Drawing.Size(77, 20)
		Me.cboCusShipTerrCode2.Location = New System.Drawing.Point(384, 168)
		Me.cboCusShipTerrCode2.TabIndex = 31
		Me.cboCusShipTerrCode2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusShipTerrCode2.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusShipTerrCode2.CausesValidation = True
		Me.cboCusShipTerrCode2.Enabled = True
		Me.cboCusShipTerrCode2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusShipTerrCode2.IntegralHeight = True
		Me.cboCusShipTerrCode2.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusShipTerrCode2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusShipTerrCode2.Sorted = False
		Me.cboCusShipTerrCode2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusShipTerrCode2.TabStop = True
		Me.cboCusShipTerrCode2.Visible = True
		Me.cboCusShipTerrCode2.Name = "cboCusShipTerrCode2"
		Me.cboCusShipTerrCode.Size = New System.Drawing.Size(77, 20)
		Me.cboCusShipTerrCode.Location = New System.Drawing.Point(88, 168)
		Me.cboCusShipTerrCode.TabIndex = 22
		Me.cboCusShipTerrCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusShipTerrCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusShipTerrCode.CausesValidation = True
		Me.cboCusShipTerrCode.Enabled = True
		Me.cboCusShipTerrCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusShipTerrCode.IntegralHeight = True
		Me.cboCusShipTerrCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusShipTerrCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusShipTerrCode.Sorted = False
		Me.cboCusShipTerrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusShipTerrCode.TabStop = True
		Me.cboCusShipTerrCode.Visible = True
		Me.cboCusShipTerrCode.Name = "cboCusShipTerrCode"
		Me._tabDetailInfo_TabPage2.Text = "其他資料"
		Me.lblCusSpecDis.Text = "特別折扣 :"
		Me.lblCusSpecDis.Size = New System.Drawing.Size(116, 16)
		Me.lblCusSpecDis.Location = New System.Drawing.Point(320, 44)
		Me.lblCusSpecDis.TabIndex = 62
		Me.lblCusSpecDis.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusSpecDis.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusSpecDis.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusSpecDis.Enabled = True
		Me.lblCusSpecDis.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusSpecDis.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusSpecDis.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusSpecDis.UseMnemonic = True
		Me.lblCusSpecDis.Visible = True
		Me.lblCusSpecDis.AutoSize = False
		Me.lblCusSpecDis.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusSpecDis.Name = "lblCusSpecDis"
		Me.lblCusCurr.Text = "貨幣 :"
		Me.lblCusCurr.Size = New System.Drawing.Size(61, 16)
		Me.lblCusCurr.Location = New System.Drawing.Point(16, 44)
		Me.lblCusCurr.TabIndex = 63
		Me.lblCusCurr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusCurr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusCurr.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusCurr.Enabled = True
		Me.lblCusCurr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusCurr.UseMnemonic = True
		Me.lblCusCurr.Visible = True
		Me.lblCusCurr.AutoSize = False
		Me.lblCusCurr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusCurr.Name = "lblCusCurr"
		Me.lblCusPayCode.Text = "付款條款 :"
		Me.lblCusPayCode.Size = New System.Drawing.Size(84, 16)
		Me.lblCusPayCode.Location = New System.Drawing.Point(16, 21)
		Me.lblCusPayCode.TabIndex = 65
		Me.lblCusPayCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusPayCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusPayCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusPayCode.Enabled = True
		Me.lblCusPayCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusPayCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusPayCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusPayCode.UseMnemonic = True
		Me.lblCusPayCode.Visible = True
		Me.lblCusPayCode.AutoSize = False
		Me.lblCusPayCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusPayCode.Name = "lblCusPayCode"
		Me.lblCusCreditLimit.Text = "信用限度 :"
		Me.lblCusCreditLimit.Size = New System.Drawing.Size(68, 16)
		Me.lblCusCreditLimit.Location = New System.Drawing.Point(176, 44)
		Me.lblCusCreditLimit.TabIndex = 66
		Me.lblCusCreditLimit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusCreditLimit.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusCreditLimit.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusCreditLimit.Enabled = True
		Me.lblCusCreditLimit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusCreditLimit.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusCreditLimit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusCreditLimit.UseMnemonic = True
		Me.lblCusCreditLimit.Visible = True
		Me.lblCusCreditLimit.AutoSize = False
		Me.lblCusCreditLimit.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusCreditLimit.Name = "lblCusCreditLimit"
		Me.lblCusSaleName.Text = "營業員 :"
		Me.lblCusSaleName.Size = New System.Drawing.Size(63, 16)
		Me.lblCusSaleName.Location = New System.Drawing.Point(320, 21)
		Me.lblCusSaleName.TabIndex = 67
		Me.lblCusSaleName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusSaleName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusSaleName.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusSaleName.Enabled = True
		Me.lblCusSaleName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusSaleName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusSaleName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusSaleName.UseMnemonic = True
		Me.lblCusSaleName.Visible = True
		Me.lblCusSaleName.AutoSize = False
		Me.lblCusSaleName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusSaleName.Name = "lblCusSaleName"
		Me.lblCusMLCode.Text = "CUSMLCODE"
		Me.lblCusMLCode.Size = New System.Drawing.Size(93, 16)
		Me.lblCusMLCode.Location = New System.Drawing.Point(16, 68)
		Me.lblCusMLCode.TabIndex = 68
		Me.lblCusMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusMLCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusMLCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusMLCode.Enabled = True
		Me.lblCusMLCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusMLCode.UseMnemonic = True
		Me.lblCusMLCode.Visible = True
		Me.lblCusMLCode.AutoSize = False
		Me.lblCusMLCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusMLCode.Name = "lblCusMLCode"
		Me.lblDspCusMLDesc.Size = New System.Drawing.Size(384, 20)
		Me.lblDspCusMLDesc.Location = New System.Drawing.Point(240, 64)
		Me.lblDspCusMLDesc.TabIndex = 69
		Me.lblDspCusMLDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCusMLDesc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCusMLDesc.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCusMLDesc.Enabled = True
		Me.lblDspCusMLDesc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCusMLDesc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCusMLDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCusMLDesc.UseMnemonic = True
		Me.lblDspCusMLDesc.Visible = True
		Me.lblDspCusMLDesc.AutoSize = False
		Me.lblDspCusMLDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCusMLDesc.Name = "lblDspCusMLDesc"
		Me.lblCusRemark.Text = "備註 :"
		Me.lblCusRemark.Size = New System.Drawing.Size(60, 16)
		Me.lblCusRemark.Location = New System.Drawing.Point(16, 88)
		Me.lblCusRemark.TabIndex = 72
		Me.lblCusRemark.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusRemark.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusRemark.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusRemark.Enabled = True
		Me.lblCusRemark.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusRemark.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusRemark.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusRemark.UseMnemonic = True
		Me.lblCusRemark.Visible = True
		Me.lblCusRemark.AutoSize = False
		Me.lblCusRemark.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusRemark.Name = "lblCusRemark"
		Me.lblDspCusLastUpdDate.Size = New System.Drawing.Size(129, 20)
		Me.lblDspCusLastUpdDate.Location = New System.Drawing.Point(496, 176)
		Me.lblDspCusLastUpdDate.TabIndex = 95
		Me.lblDspCusLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCusLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCusLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCusLastUpdDate.Enabled = True
		Me.lblDspCusLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCusLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCusLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCusLastUpdDate.UseMnemonic = True
		Me.lblDspCusLastUpdDate.Visible = True
		Me.lblDspCusLastUpdDate.AutoSize = False
		Me.lblDspCusLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCusLastUpdDate.Name = "lblDspCusLastUpdDate"
		Me.lblDspCusLastUpd.Size = New System.Drawing.Size(121, 20)
		Me.lblDspCusLastUpd.Location = New System.Drawing.Point(168, 176)
		Me.lblDspCusLastUpd.TabIndex = 96
		Me.lblDspCusLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCusLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCusLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCusLastUpd.Enabled = True
		Me.lblDspCusLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCusLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCusLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCusLastUpd.UseMnemonic = True
		Me.lblDspCusLastUpd.Visible = True
		Me.lblDspCusLastUpd.AutoSize = False
		Me.lblDspCusLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCusLastUpd.Name = "lblDspCusLastUpd"
		Me.lblCusLastUpdDate.Text = "最後修改日期 :"
		Me.lblCusLastUpdDate.Size = New System.Drawing.Size(172, 16)
		Me.lblCusLastUpdDate.Location = New System.Drawing.Point(304, 181)
		Me.lblCusLastUpdDate.TabIndex = 97
		Me.lblCusLastUpdDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusLastUpdDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusLastUpdDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusLastUpdDate.Enabled = True
		Me.lblCusLastUpdDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusLastUpdDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusLastUpdDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusLastUpdDate.UseMnemonic = True
		Me.lblCusLastUpdDate.Visible = True
		Me.lblCusLastUpdDate.AutoSize = False
		Me.lblCusLastUpdDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusLastUpdDate.Name = "lblCusLastUpdDate"
		Me.lblCusLastUpd.Text = "最後修改人 :"
		Me.lblCusLastUpd.Size = New System.Drawing.Size(143, 16)
		Me.lblCusLastUpd.Location = New System.Drawing.Point(16, 181)
		Me.lblCusLastUpd.TabIndex = 98
		Me.lblCusLastUpd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusLastUpd.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusLastUpd.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusLastUpd.Enabled = True
		Me.lblCusLastUpd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusLastUpd.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusLastUpd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusLastUpd.UseMnemonic = True
		Me.lblCusLastUpd.Visible = True
		Me.lblCusLastUpd.AutoSize = False
		Me.lblCusLastUpd.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusLastUpd.Name = "lblCusLastUpd"
		Me.lblDspCusSaleName.Size = New System.Drawing.Size(127, 20)
		Me.lblDspCusSaleName.Location = New System.Drawing.Point(496, 16)
		Me.lblDspCusSaleName.TabIndex = 101
		Me.lblDspCusSaleName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCusSaleName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCusSaleName.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCusSaleName.Enabled = True
		Me.lblDspCusSaleName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCusSaleName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCusSaleName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCusSaleName.UseMnemonic = True
		Me.lblDspCusSaleName.Visible = True
		Me.lblDspCusSaleName.AutoSize = False
		Me.lblDspCusSaleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCusSaleName.Name = "lblDspCusSaleName"
		Me.cboCusPayCode.Size = New System.Drawing.Size(85, 20)
		Me.cboCusPayCode.Location = New System.Drawing.Point(112, 16)
		Me.cboCusPayCode.TabIndex = 33
		Me.cboCusPayCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusPayCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusPayCode.CausesValidation = True
		Me.cboCusPayCode.Enabled = True
		Me.cboCusPayCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusPayCode.IntegralHeight = True
		Me.cboCusPayCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusPayCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusPayCode.Sorted = False
		Me.cboCusPayCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusPayCode.TabStop = True
		Me.cboCusPayCode.Visible = True
		Me.cboCusPayCode.Name = "cboCusPayCode"
		Me.cboCusCurr.Enabled = False
		Me.cboCusCurr.Size = New System.Drawing.Size(61, 20)
		Me.cboCusCurr.Location = New System.Drawing.Point(112, 40)
		Me.cboCusCurr.TabIndex = 36
		Me.cboCusCurr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusCurr.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusCurr.CausesValidation = True
		Me.cboCusCurr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusCurr.IntegralHeight = True
		Me.cboCusCurr.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusCurr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusCurr.Sorted = False
		Me.cboCusCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusCurr.TabStop = True
		Me.cboCusCurr.Visible = True
		Me.cboCusCurr.Name = "cboCusCurr"
		Me.cboCusSaleCode.Size = New System.Drawing.Size(85, 20)
		Me.cboCusSaleCode.Location = New System.Drawing.Point(408, 16)
		Me.cboCusSaleCode.TabIndex = 35
		Me.cboCusSaleCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusSaleCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusSaleCode.CausesValidation = True
		Me.cboCusSaleCode.Enabled = True
		Me.cboCusSaleCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusSaleCode.IntegralHeight = True
		Me.cboCusSaleCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusSaleCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusSaleCode.Sorted = False
		Me.cboCusSaleCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusSaleCode.TabStop = True
		Me.cboCusSaleCode.Visible = True
		Me.cboCusSaleCode.Name = "cboCusSaleCode"
		Me.txtCusSpecDis.AutoSize = False
		Me.txtCusSpecDis.Enabled = False
		Me.txtCusSpecDis.Size = New System.Drawing.Size(89, 20)
		Me.txtCusSpecDis.Location = New System.Drawing.Point(408, 40)
		Me.txtCusSpecDis.TabIndex = 38
		Me.txtCusSpecDis.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusSpecDis.AcceptsReturn = True
		Me.txtCusSpecDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusSpecDis.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusSpecDis.CausesValidation = True
		Me.txtCusSpecDis.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusSpecDis.HideSelection = True
		Me.txtCusSpecDis.ReadOnly = False
		Me.txtCusSpecDis.Maxlength = 0
		Me.txtCusSpecDis.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusSpecDis.MultiLine = False
		Me.txtCusSpecDis.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusSpecDis.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusSpecDis.TabStop = True
		Me.txtCusSpecDis.Visible = True
		Me.txtCusSpecDis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusSpecDis.Name = "txtCusSpecDis"
		Me.txtCusPayDesc.AutoSize = False
		Me.txtCusPayDesc.Enabled = False
		Me.txtCusPayDesc.Size = New System.Drawing.Size(116, 20)
		Me.txtCusPayDesc.Location = New System.Drawing.Point(200, 16)
		Me.txtCusPayDesc.TabIndex = 34
		Me.txtCusPayDesc.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusPayDesc.AcceptsReturn = True
		Me.txtCusPayDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusPayDesc.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusPayDesc.CausesValidation = True
		Me.txtCusPayDesc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusPayDesc.HideSelection = True
		Me.txtCusPayDesc.ReadOnly = False
		Me.txtCusPayDesc.Maxlength = 0
		Me.txtCusPayDesc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusPayDesc.MultiLine = False
		Me.txtCusPayDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusPayDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusPayDesc.TabStop = True
		Me.txtCusPayDesc.Visible = True
		Me.txtCusPayDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusPayDesc.Name = "txtCusPayDesc"
		Me.txtCusCreditLimit.AutoSize = False
		Me.txtCusCreditLimit.Enabled = False
		Me.txtCusCreditLimit.Size = New System.Drawing.Size(77, 20)
		Me.txtCusCreditLimit.Location = New System.Drawing.Point(240, 40)
		Me.txtCusCreditLimit.TabIndex = 37
		Me.txtCusCreditLimit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusCreditLimit.AcceptsReturn = True
		Me.txtCusCreditLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusCreditLimit.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusCreditLimit.CausesValidation = True
		Me.txtCusCreditLimit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusCreditLimit.HideSelection = True
		Me.txtCusCreditLimit.ReadOnly = False
		Me.txtCusCreditLimit.Maxlength = 0
		Me.txtCusCreditLimit.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusCreditLimit.MultiLine = False
		Me.txtCusCreditLimit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusCreditLimit.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusCreditLimit.TabStop = True
		Me.txtCusCreditLimit.Visible = True
		Me.txtCusCreditLimit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusCreditLimit.Name = "txtCusCreditLimit"
		Me.cboCusMLCode.Enabled = False
		Me.cboCusMLCode.Size = New System.Drawing.Size(125, 20)
		Me.cboCusMLCode.Location = New System.Drawing.Point(112, 64)
		Me.cboCusMLCode.TabIndex = 39
		Me.cboCusMLCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCusMLCode.BackColor = System.Drawing.SystemColors.Window
		Me.cboCusMLCode.CausesValidation = True
		Me.cboCusMLCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCusMLCode.IntegralHeight = True
		Me.cboCusMLCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCusMLCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCusMLCode.Sorted = False
		Me.cboCusMLCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCusMLCode.TabStop = True
		Me.cboCusMLCode.Visible = True
		Me.cboCusMLCode.Name = "cboCusMLCode"
		Me.txtCusRemark.AutoSize = False
		Me.txtCusRemark.Enabled = False
		Me.txtCusRemark.Size = New System.Drawing.Size(511, 68)
		Me.txtCusRemark.Location = New System.Drawing.Point(112, 88)
		Me.txtCusRemark.MultiLine = True
		Me.txtCusRemark.TabIndex = 40
		Me.txtCusRemark.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusRemark.AcceptsReturn = True
		Me.txtCusRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusRemark.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusRemark.CausesValidation = True
		Me.txtCusRemark.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusRemark.HideSelection = True
		Me.txtCusRemark.ReadOnly = False
		Me.txtCusRemark.Maxlength = 0
		Me.txtCusRemark.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusRemark.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusRemark.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusRemark.TabStop = True
		Me.txtCusRemark.Visible = True
		Me.txtCusRemark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusRemark.Name = "txtCusRemark"
		Me._tabDetailInfo_TabPage3.Text = "備註"
		tblDetail.OcxState = CType(resources.GetObject("tblDetail.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tblDetail.Size = New System.Drawing.Size(257, 177)
		Me.tblDetail.Location = New System.Drawing.Point(344, 16)
		Me.tblDetail.TabIndex = 94
		Me.tblDetail.Name = "tblDetail"
		Me.lblOpenBal.Text = "OPENBAL"
		Me.lblOpenBal.Size = New System.Drawing.Size(141, 16)
		Me.lblOpenBal.Location = New System.Drawing.Point(16, 132)
		Me.lblOpenBal.TabIndex = 100
		Me.lblOpenBal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOpenBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblOpenBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblOpenBal.Enabled = True
		Me.lblOpenBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblOpenBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblOpenBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblOpenBal.UseMnemonic = True
		Me.lblOpenBal.Visible = True
		Me.lblOpenBal.AutoSize = False
		Me.lblOpenBal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblOpenBal.Name = "lblOpenBal"
		Me.lblDspOpenBal.Size = New System.Drawing.Size(103, 20)
		Me.lblDspOpenBal.Location = New System.Drawing.Point(232, 128)
		Me.lblDspOpenBal.TabIndex = 99
		Me.lblDspOpenBal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspOpenBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspOpenBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspOpenBal.Enabled = True
		Me.lblDspOpenBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspOpenBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspOpenBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspOpenBal.UseMnemonic = True
		Me.lblDspOpenBal.Visible = True
		Me.lblDspOpenBal.AutoSize = False
		Me.lblDspOpenBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspOpenBal.Name = "lblDspOpenBal"
		Me.lblDspARBal.Size = New System.Drawing.Size(103, 20)
		Me.lblDspARBal.Location = New System.Drawing.Point(232, 176)
		Me.lblDspARBal.TabIndex = 93
		Me.lblDspARBal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspARBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspARBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspARBal.Enabled = True
		Me.lblDspARBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspARBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspARBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspARBal.UseMnemonic = True
		Me.lblDspARBal.Visible = True
		Me.lblDspARBal.AutoSize = False
		Me.lblDspARBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspARBal.Name = "lblDspARBal"
		Me.lblARBal.Text = "ARBAL"
		Me.lblARBal.Size = New System.Drawing.Size(141, 16)
		Me.lblARBal.Location = New System.Drawing.Point(16, 180)
		Me.lblARBal.TabIndex = 92
		Me.lblARBal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblARBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblARBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblARBal.Enabled = True
		Me.lblARBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblARBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblARBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblARBal.UseMnemonic = True
		Me.lblARBal.Visible = True
		Me.lblARBal.AutoSize = False
		Me.lblARBal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblARBal.Name = "lblARBal"
		Me.lblDspCloseBal.Size = New System.Drawing.Size(103, 20)
		Me.lblDspCloseBal.Location = New System.Drawing.Point(232, 152)
		Me.lblDspCloseBal.TabIndex = 91
		Me.lblDspCloseBal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCloseBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCloseBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCloseBal.Enabled = True
		Me.lblDspCloseBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCloseBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCloseBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCloseBal.UseMnemonic = True
		Me.lblDspCloseBal.Visible = True
		Me.lblDspCloseBal.AutoSize = False
		Me.lblDspCloseBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCloseBal.Name = "lblDspCloseBal"
		Me.lblCloseBal.Text = "CLOSEBAL"
		Me.lblCloseBal.Size = New System.Drawing.Size(141, 16)
		Me.lblCloseBal.Location = New System.Drawing.Point(16, 156)
		Me.lblCloseBal.TabIndex = 90
		Me.lblCloseBal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCloseBal.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCloseBal.BackColor = System.Drawing.SystemColors.Control
		Me.lblCloseBal.Enabled = True
		Me.lblCloseBal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCloseBal.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCloseBal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCloseBal.UseMnemonic = True
		Me.lblCloseBal.Visible = True
		Me.lblCloseBal.AutoSize = False
		Me.lblCloseBal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCloseBal.Name = "lblCloseBal"
		Me.lblAcmMnSale.Text = "ACMMNSALE"
		Me.lblAcmMnSale.Size = New System.Drawing.Size(101, 16)
		Me.lblAcmMnSale.Location = New System.Drawing.Point(16, 108)
		Me.lblAcmMnSale.TabIndex = 89
		Me.lblAcmMnSale.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAcmMnSale.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAcmMnSale.BackColor = System.Drawing.SystemColors.Control
		Me.lblAcmMnSale.Enabled = True
		Me.lblAcmMnSale.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAcmMnSale.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAcmMnSale.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAcmMnSale.UseMnemonic = True
		Me.lblAcmMnSale.Visible = True
		Me.lblAcmMnSale.AutoSize = False
		Me.lblAcmMnSale.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAcmMnSale.Name = "lblAcmMnSale"
		Me.lblDspAcmMnSaleNet.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmMnSaleNet.Location = New System.Drawing.Point(264, 104)
		Me.lblDspAcmMnSaleNet.TabIndex = 88
		Me.lblDspAcmMnSaleNet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspAcmMnSaleNet.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmMnSaleNet.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmMnSaleNet.Enabled = True
		Me.lblDspAcmMnSaleNet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmMnSaleNet.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmMnSaleNet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmMnSaleNet.UseMnemonic = True
		Me.lblDspAcmMnSaleNet.Visible = True
		Me.lblDspAcmMnSaleNet.AutoSize = False
		Me.lblDspAcmMnSaleNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmMnSaleNet.Name = "lblDspAcmMnSaleNet"
		Me.lblDspAcmMnSaleAmt.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmMnSaleAmt.Location = New System.Drawing.Point(192, 104)
		Me.lblDspAcmMnSaleAmt.TabIndex = 87
		Me.lblDspAcmMnSaleAmt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspAcmMnSaleAmt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmMnSaleAmt.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmMnSaleAmt.Enabled = True
		Me.lblDspAcmMnSaleAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmMnSaleAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmMnSaleAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmMnSaleAmt.UseMnemonic = True
		Me.lblDspAcmMnSaleAmt.Visible = True
		Me.lblDspAcmMnSaleAmt.AutoSize = False
		Me.lblDspAcmMnSaleAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmMnSaleAmt.Name = "lblDspAcmMnSaleAmt"
		Me.lblDspAcmMnSaleQty.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmMnSaleQty.Location = New System.Drawing.Point(120, 104)
		Me.lblDspAcmMnSaleQty.TabIndex = 86
		Me.lblDspAcmMnSaleQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspAcmMnSaleQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmMnSaleQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmMnSaleQty.Enabled = True
		Me.lblDspAcmMnSaleQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmMnSaleQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmMnSaleQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmMnSaleQty.UseMnemonic = True
		Me.lblDspAcmMnSaleQty.Visible = True
		Me.lblDspAcmMnSaleQty.AutoSize = False
		Me.lblDspAcmMnSaleQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmMnSaleQty.Name = "lblDspAcmMnSaleQty"
		Me.lblAcmYrSale.Text = "ACMYRSALE"
		Me.lblAcmYrSale.Size = New System.Drawing.Size(101, 16)
		Me.lblAcmYrSale.Location = New System.Drawing.Point(16, 84)
		Me.lblAcmYrSale.TabIndex = 85
		Me.lblAcmYrSale.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAcmYrSale.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAcmYrSale.BackColor = System.Drawing.SystemColors.Control
		Me.lblAcmYrSale.Enabled = True
		Me.lblAcmYrSale.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAcmYrSale.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAcmYrSale.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAcmYrSale.UseMnemonic = True
		Me.lblAcmYrSale.Visible = True
		Me.lblAcmYrSale.AutoSize = False
		Me.lblAcmYrSale.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAcmYrSale.Name = "lblAcmYrSale"
		Me.lblDspAcmYrSaleNet.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmYrSaleNet.Location = New System.Drawing.Point(264, 80)
		Me.lblDspAcmYrSaleNet.TabIndex = 84
		Me.lblDspAcmYrSaleNet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspAcmYrSaleNet.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmYrSaleNet.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmYrSaleNet.Enabled = True
		Me.lblDspAcmYrSaleNet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmYrSaleNet.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmYrSaleNet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmYrSaleNet.UseMnemonic = True
		Me.lblDspAcmYrSaleNet.Visible = True
		Me.lblDspAcmYrSaleNet.AutoSize = False
		Me.lblDspAcmYrSaleNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmYrSaleNet.Name = "lblDspAcmYrSaleNet"
		Me.lblDspAcmYrSaleAmt.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmYrSaleAmt.Location = New System.Drawing.Point(192, 80)
		Me.lblDspAcmYrSaleAmt.TabIndex = 83
		Me.lblDspAcmYrSaleAmt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspAcmYrSaleAmt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmYrSaleAmt.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmYrSaleAmt.Enabled = True
		Me.lblDspAcmYrSaleAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmYrSaleAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmYrSaleAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmYrSaleAmt.UseMnemonic = True
		Me.lblDspAcmYrSaleAmt.Visible = True
		Me.lblDspAcmYrSaleAmt.AutoSize = False
		Me.lblDspAcmYrSaleAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmYrSaleAmt.Name = "lblDspAcmYrSaleAmt"
		Me.lblDspAcmYrSaleQty.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmYrSaleQty.Location = New System.Drawing.Point(120, 80)
		Me.lblDspAcmYrSaleQty.TabIndex = 82
		Me.lblDspAcmYrSaleQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspAcmYrSaleQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmYrSaleQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmYrSaleQty.Enabled = True
		Me.lblDspAcmYrSaleQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmYrSaleQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmYrSaleQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmYrSaleQty.UseMnemonic = True
		Me.lblDspAcmYrSaleQty.Visible = True
		Me.lblDspAcmYrSaleQty.AutoSize = False
		Me.lblDspAcmYrSaleQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmYrSaleQty.Name = "lblDspAcmYrSaleQty"
		Me.lblAcmSale.Text = "ACMSALE"
		Me.lblAcmSale.Size = New System.Drawing.Size(101, 16)
		Me.lblAcmSale.Location = New System.Drawing.Point(16, 60)
		Me.lblAcmSale.TabIndex = 81
		Me.lblAcmSale.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAcmSale.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAcmSale.BackColor = System.Drawing.SystemColors.Control
		Me.lblAcmSale.Enabled = True
		Me.lblAcmSale.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAcmSale.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAcmSale.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAcmSale.UseMnemonic = True
		Me.lblAcmSale.Visible = True
		Me.lblAcmSale.AutoSize = False
		Me.lblAcmSale.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAcmSale.Name = "lblAcmSale"
		Me.lblDspAcmSaleNet.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmSaleNet.Location = New System.Drawing.Point(264, 56)
		Me.lblDspAcmSaleNet.TabIndex = 80
		Me.lblDspAcmSaleNet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspAcmSaleNet.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmSaleNet.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmSaleNet.Enabled = True
		Me.lblDspAcmSaleNet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmSaleNet.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmSaleNet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmSaleNet.UseMnemonic = True
		Me.lblDspAcmSaleNet.Visible = True
		Me.lblDspAcmSaleNet.AutoSize = False
		Me.lblDspAcmSaleNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmSaleNet.Name = "lblDspAcmSaleNet"
		Me.lblDspAcmSaleAmt.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmSaleAmt.Location = New System.Drawing.Point(192, 56)
		Me.lblDspAcmSaleAmt.TabIndex = 79
		Me.lblDspAcmSaleAmt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspAcmSaleAmt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmSaleAmt.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmSaleAmt.Enabled = True
		Me.lblDspAcmSaleAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmSaleAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmSaleAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmSaleAmt.UseMnemonic = True
		Me.lblDspAcmSaleAmt.Visible = True
		Me.lblDspAcmSaleAmt.AutoSize = False
		Me.lblDspAcmSaleAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmSaleAmt.Name = "lblDspAcmSaleAmt"
		Me.lblNet.Text = "NET"
		Me.lblNet.Size = New System.Drawing.Size(37, 16)
		Me.lblNet.Location = New System.Drawing.Point(288, 40)
		Me.lblNet.TabIndex = 78
		Me.lblNet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNet.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNet.BackColor = System.Drawing.SystemColors.Control
		Me.lblNet.Enabled = True
		Me.lblNet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNet.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNet.UseMnemonic = True
		Me.lblNet.Visible = True
		Me.lblNet.AutoSize = False
		Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNet.Name = "lblNet"
		Me.lblAmt.Text = "AMT"
		Me.lblAmt.Size = New System.Drawing.Size(37, 16)
		Me.lblAmt.Location = New System.Drawing.Point(216, 40)
		Me.lblAmt.TabIndex = 77
		Me.lblAmt.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAmt.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAmt.BackColor = System.Drawing.SystemColors.Control
		Me.lblAmt.Enabled = True
		Me.lblAmt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAmt.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAmt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAmt.UseMnemonic = True
		Me.lblAmt.Visible = True
		Me.lblAmt.AutoSize = False
		Me.lblAmt.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAmt.Name = "lblAmt"
		Me.lblDspAcmSaleQty.Size = New System.Drawing.Size(71, 20)
		Me.lblDspAcmSaleQty.Location = New System.Drawing.Point(120, 56)
		Me.lblDspAcmSaleQty.TabIndex = 76
		Me.lblDspAcmSaleQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspAcmSaleQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspAcmSaleQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspAcmSaleQty.Enabled = True
		Me.lblDspAcmSaleQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspAcmSaleQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspAcmSaleQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspAcmSaleQty.UseMnemonic = True
		Me.lblDspAcmSaleQty.Visible = True
		Me.lblDspAcmSaleQty.AutoSize = False
		Me.lblDspAcmSaleQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspAcmSaleQty.Name = "lblDspAcmSaleQty"
		Me.lblQty.Text = "QTY"
		Me.lblQty.Size = New System.Drawing.Size(37, 16)
		Me.lblQty.Location = New System.Drawing.Point(144, 40)
		Me.lblQty.TabIndex = 75
		Me.lblQty.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblQty.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblQty.BackColor = System.Drawing.SystemColors.Control
		Me.lblQty.Enabled = True
		Me.lblQty.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblQty.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblQty.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblQty.UseMnemonic = True
		Me.lblQty.Visible = True
		Me.lblQty.AutoSize = False
		Me.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblQty.Name = "lblQty"
		Me.lblCusCrtDate.Text = "CUSCRTDATE"
		Me.lblCusCrtDate.Size = New System.Drawing.Size(61, 16)
		Me.lblCusCrtDate.Location = New System.Drawing.Point(16, 20)
		Me.lblCusCrtDate.TabIndex = 74
		Me.lblCusCrtDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusCrtDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusCrtDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusCrtDate.Enabled = True
		Me.lblCusCrtDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusCrtDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusCrtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusCrtDate.UseMnemonic = True
		Me.lblCusCrtDate.Visible = True
		Me.lblCusCrtDate.AutoSize = False
		Me.lblCusCrtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusCrtDate.Name = "lblCusCrtDate"
		Me.lblDspCrtDate.Size = New System.Drawing.Size(103, 20)
		Me.lblDspCrtDate.Location = New System.Drawing.Point(120, 16)
		Me.lblDspCrtDate.TabIndex = 73
		Me.lblDspCrtDate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDspCrtDate.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDspCrtDate.BackColor = System.Drawing.SystemColors.Control
		Me.lblDspCrtDate.Enabled = True
		Me.lblDspCrtDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDspCrtDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDspCrtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDspCrtDate.UseMnemonic = True
		Me.lblDspCrtDate.Visible = True
		Me.lblDspCrtDate.AutoSize = False
		Me.lblDspCrtDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblDspCrtDate.Name = "lblDspCrtDate"
		Me.fraCustomerInfo.Text = "客戶資料"
		Me.fraCustomerInfo.Size = New System.Drawing.Size(633, 113)
		Me.fraCustomerInfo.Location = New System.Drawing.Point(8, 48)
		Me.fraCustomerInfo.TabIndex = 44
		Me.fraCustomerInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraCustomerInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraCustomerInfo.Enabled = True
		Me.fraCustomerInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraCustomerInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraCustomerInfo.Visible = True
		Me.fraCustomerInfo.Padding = New System.Windows.Forms.Padding(0)
		Me.fraCustomerInfo.Name = "fraCustomerInfo"
		Me.txtCusContactPerson1.AutoSize = False
		Me.txtCusContactPerson1.Enabled = False
		Me.txtCusContactPerson1.Size = New System.Drawing.Size(151, 20)
		Me.txtCusContactPerson1.Location = New System.Drawing.Point(352, 88)
		Me.txtCusContactPerson1.TabIndex = 7
		Me.txtCusContactPerson1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusContactPerson1.AcceptsReturn = True
		Me.txtCusContactPerson1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusContactPerson1.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusContactPerson1.CausesValidation = True
		Me.txtCusContactPerson1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusContactPerson1.HideSelection = True
		Me.txtCusContactPerson1.ReadOnly = False
		Me.txtCusContactPerson1.Maxlength = 0
		Me.txtCusContactPerson1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusContactPerson1.MultiLine = False
		Me.txtCusContactPerson1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusContactPerson1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusContactPerson1.TabStop = True
		Me.txtCusContactPerson1.Visible = True
		Me.txtCusContactPerson1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusContactPerson1.Name = "txtCusContactPerson1"
		Me.txtCusName.AutoSize = False
		Me.txtCusName.BackColor = System.Drawing.SystemColors.ControlLight
		Me.txtCusName.Enabled = False
		Me.txtCusName.Size = New System.Drawing.Size(423, 20)
		Me.txtCusName.Location = New System.Drawing.Point(80, 40)
		Me.txtCusName.TabIndex = 3
		Me.txtCusName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusName.AcceptsReturn = True
		Me.txtCusName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusName.CausesValidation = True
		Me.txtCusName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusName.HideSelection = True
		Me.txtCusName.ReadOnly = False
		Me.txtCusName.Maxlength = 0
		Me.txtCusName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusName.MultiLine = False
		Me.txtCusName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusName.TabStop = True
		Me.txtCusName.Visible = True
		Me.txtCusName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusName.Name = "txtCusName"
		Me.txtCusTel.AutoSize = False
		Me.txtCusTel.Enabled = False
		Me.txtCusTel.Size = New System.Drawing.Size(159, 20)
		Me.txtCusTel.Location = New System.Drawing.Point(80, 64)
		Me.txtCusTel.TabIndex = 4
		Me.txtCusTel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusTel.AcceptsReturn = True
		Me.txtCusTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusTel.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusTel.CausesValidation = True
		Me.txtCusTel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusTel.HideSelection = True
		Me.txtCusTel.ReadOnly = False
		Me.txtCusTel.Maxlength = 0
		Me.txtCusTel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusTel.MultiLine = False
		Me.txtCusTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusTel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusTel.TabStop = True
		Me.txtCusTel.Visible = True
		Me.txtCusTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusTel.Name = "txtCusTel"
		Me.txtCusFax.AutoSize = False
		Me.txtCusFax.Enabled = False
		Me.txtCusFax.Size = New System.Drawing.Size(151, 20)
		Me.txtCusFax.Location = New System.Drawing.Point(352, 64)
		Me.txtCusFax.TabIndex = 5
		Me.txtCusFax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusFax.AcceptsReturn = True
		Me.txtCusFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusFax.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusFax.CausesValidation = True
		Me.txtCusFax.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusFax.HideSelection = True
		Me.txtCusFax.ReadOnly = False
		Me.txtCusFax.Maxlength = 0
		Me.txtCusFax.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusFax.MultiLine = False
		Me.txtCusFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusFax.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusFax.TabStop = True
		Me.txtCusFax.Visible = True
		Me.txtCusFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusFax.Name = "txtCusFax"
		Me.chkBadList.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkBadList.Text = "黑名單 :"
		Me.chkBadList.Size = New System.Drawing.Size(81, 15)
		Me.chkBadList.Location = New System.Drawing.Point(512, 43)
		Me.chkBadList.TabIndex = 8
		Me.chkBadList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkBadList.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkBadList.BackColor = System.Drawing.SystemColors.Control
		Me.chkBadList.CausesValidation = True
		Me.chkBadList.Enabled = True
		Me.chkBadList.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkBadList.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkBadList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkBadList.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkBadList.TabStop = True
		Me.chkBadList.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkBadList.Visible = True
		Me.chkBadList.Name = "chkBadList"
		Me.chkInActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkInActive.Text = "有效 :"
		Me.chkInActive.Size = New System.Drawing.Size(81, 12)
		Me.chkInActive.Location = New System.Drawing.Point(512, 67)
		Me.chkInActive.TabIndex = 9
		Me.chkInActive.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkInActive.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkInActive.BackColor = System.Drawing.SystemColors.Control
		Me.chkInActive.CausesValidation = True
		Me.chkInActive.Enabled = True
		Me.chkInActive.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkInActive.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkInActive.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkInActive.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkInActive.TabStop = True
		Me.chkInActive.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkInActive.Visible = True
		Me.chkInActive.Name = "chkInActive"
		Me.txtCusContactPerson.AutoSize = False
		Me.txtCusContactPerson.Enabled = False
		Me.txtCusContactPerson.Size = New System.Drawing.Size(159, 20)
		Me.txtCusContactPerson.Location = New System.Drawing.Point(80, 88)
		Me.txtCusContactPerson.TabIndex = 6
		Me.txtCusContactPerson.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusContactPerson.AcceptsReturn = True
		Me.txtCusContactPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusContactPerson.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusContactPerson.CausesValidation = True
		Me.txtCusContactPerson.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusContactPerson.HideSelection = True
		Me.txtCusContactPerson.ReadOnly = False
		Me.txtCusContactPerson.Maxlength = 0
		Me.txtCusContactPerson.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusContactPerson.MultiLine = False
		Me.txtCusContactPerson.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusContactPerson.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusContactPerson.TabStop = True
		Me.txtCusContactPerson.Visible = True
		Me.txtCusContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusContactPerson.Name = "txtCusContactPerson"
		Me.txtCusEmail.AutoSize = False
		Me.txtCusEmail.Enabled = False
		Me.txtCusEmail.Size = New System.Drawing.Size(239, 20)
		Me.txtCusEmail.Location = New System.Drawing.Point(352, 16)
		Me.txtCusEmail.TabIndex = 2
		Me.txtCusEmail.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusEmail.AcceptsReturn = True
		Me.txtCusEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusEmail.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusEmail.CausesValidation = True
		Me.txtCusEmail.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusEmail.HideSelection = True
		Me.txtCusEmail.ReadOnly = False
		Me.txtCusEmail.Maxlength = 0
		Me.txtCusEmail.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusEmail.MultiLine = False
		Me.txtCusEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusEmail.TabStop = True
		Me.txtCusEmail.Visible = True
		Me.txtCusEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusEmail.Name = "txtCusEmail"
		Me.txtCusCode.AutoSize = False
		Me.txtCusCode.Enabled = False
		Me.txtCusCode.Size = New System.Drawing.Size(159, 20)
		Me.txtCusCode.Location = New System.Drawing.Point(80, 16)
		Me.txtCusCode.TabIndex = 0
		Me.txtCusCode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCusCode.AcceptsReturn = True
		Me.txtCusCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCusCode.BackColor = System.Drawing.SystemColors.Window
		Me.txtCusCode.CausesValidation = True
		Me.txtCusCode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCusCode.HideSelection = True
		Me.txtCusCode.ReadOnly = False
		Me.txtCusCode.Maxlength = 0
		Me.txtCusCode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCusCode.MultiLine = False
		Me.txtCusCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCusCode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCusCode.TabStop = True
		Me.txtCusCode.Visible = True
		Me.txtCusCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCusCode.Name = "txtCusCode"
		Me.lblCusContactPerson1.Text = "CUSCONTACTPERSON1"
		Me.lblCusContactPerson1.Size = New System.Drawing.Size(100, 16)
		Me.lblCusContactPerson1.Location = New System.Drawing.Point(248, 92)
		Me.lblCusContactPerson1.TabIndex = 102
		Me.lblCusContactPerson1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusContactPerson1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusContactPerson1.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusContactPerson1.Enabled = True
		Me.lblCusContactPerson1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusContactPerson1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusContactPerson1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusContactPerson1.UseMnemonic = True
		Me.lblCusContactPerson1.Visible = True
		Me.lblCusContactPerson1.AutoSize = False
		Me.lblCusContactPerson1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusContactPerson1.Name = "lblCusContactPerson1"
		Me.lblCusCode.Text = "編號 :"
		Me.lblCusCode.Font = New System.Drawing.Font("細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.lblCusCode.Size = New System.Drawing.Size(84, 16)
		Me.lblCusCode.Location = New System.Drawing.Point(16, 16)
		Me.lblCusCode.TabIndex = 50
		Me.lblCusCode.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusCode.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusCode.Enabled = True
		Me.lblCusCode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusCode.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusCode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusCode.UseMnemonic = True
		Me.lblCusCode.Visible = True
		Me.lblCusCode.AutoSize = False
		Me.lblCusCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusCode.Name = "lblCusCode"
		Me.lblCusName.Text = "名稱 :"
		Me.lblCusName.Size = New System.Drawing.Size(60, 16)
		Me.lblCusName.Location = New System.Drawing.Point(16, 44)
		Me.lblCusName.TabIndex = 49
		Me.lblCusName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusName.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusName.Enabled = True
		Me.lblCusName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusName.UseMnemonic = True
		Me.lblCusName.Visible = True
		Me.lblCusName.AutoSize = False
		Me.lblCusName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusName.Name = "lblCusName"
		Me.lblCusTel.Text = "電話 :"
		Me.lblCusTel.Size = New System.Drawing.Size(60, 16)
		Me.lblCusTel.Location = New System.Drawing.Point(16, 68)
		Me.lblCusTel.TabIndex = 48
		Me.lblCusTel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusTel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusTel.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusTel.Enabled = True
		Me.lblCusTel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusTel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusTel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusTel.UseMnemonic = True
		Me.lblCusTel.Visible = True
		Me.lblCusTel.AutoSize = False
		Me.lblCusTel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusTel.Name = "lblCusTel"
		Me.lblCusFax.Text = "傳真 :"
		Me.lblCusFax.Size = New System.Drawing.Size(92, 16)
		Me.lblCusFax.Location = New System.Drawing.Point(248, 68)
		Me.lblCusFax.TabIndex = 47
		Me.lblCusFax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusFax.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusFax.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusFax.Enabled = True
		Me.lblCusFax.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusFax.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusFax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusFax.UseMnemonic = True
		Me.lblCusFax.Visible = True
		Me.lblCusFax.AutoSize = False
		Me.lblCusFax.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusFax.Name = "lblCusFax"
		Me.lblCusContactPerson.Text = "聯絡人 :"
		Me.lblCusContactPerson.Size = New System.Drawing.Size(60, 16)
		Me.lblCusContactPerson.Location = New System.Drawing.Point(16, 92)
		Me.lblCusContactPerson.TabIndex = 46
		Me.lblCusContactPerson.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusContactPerson.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusContactPerson.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusContactPerson.Enabled = True
		Me.lblCusContactPerson.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusContactPerson.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusContactPerson.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusContactPerson.UseMnemonic = True
		Me.lblCusContactPerson.Visible = True
		Me.lblCusContactPerson.AutoSize = False
		Me.lblCusContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusContactPerson.Name = "lblCusContactPerson"
		Me.lblCusEmail.Text = "電郵 :"
		Me.lblCusEmail.Size = New System.Drawing.Size(84, 16)
		Me.lblCusEmail.Location = New System.Drawing.Point(248, 20)
		Me.lblCusEmail.TabIndex = 45
		Me.lblCusEmail.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCusEmail.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCusEmail.BackColor = System.Drawing.SystemColors.Control
		Me.lblCusEmail.Enabled = True
		Me.lblCusEmail.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCusEmail.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCusEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCusEmail.UseMnemonic = True
		Me.lblCusEmail.Visible = True
		Me.lblCusEmail.AutoSize = False
		Me.lblCusEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCusEmail.Name = "lblCusEmail"
		Me.Controls.Add(tblCommon)
		Me.Controls.Add(cboCusCode)
		Me.Controls.Add(txtSaleID)
		Me.Controls.Add(tbrProcess)
		Me.Controls.Add(tabDetailInfo)
		Me.Controls.Add(fraCustomerInfo)
		Me.tbrProcess.Items.Add(_tbrProcess_Button1)
		Me.tbrProcess.Items.Add(_tbrProcess_Button2)
		Me.tbrProcess.Items.Add(_tbrProcess_Button3)
		Me.tbrProcess.Items.Add(_tbrProcess_Button4)
		Me.tbrProcess.Items.Add(_tbrProcess_Button5)
		Me.tbrProcess.Items.Add(_tbrProcess_Button6)
		Me.tbrProcess.Items.Add(_tbrProcess_Button7)
		Me.tbrProcess.Items.Add(_tbrProcess_Button8)
		Me.tbrProcess.Items.Add(_tbrProcess_Button9)
		Me.tbrProcess.Items.Add(_tbrProcess_Button10)
		Me.tbrProcess.Items.Add(_tbrProcess_Button11)
		Me.tbrProcess.Items.Add(_tbrProcess_Button12)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage0)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage1)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage2)
		Me.tabDetailInfo.Controls.Add(_tabDetailInfo_TabPage3)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblCusAddress1)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblDspCusRgnDesc)
		Me._tabDetailInfo_TabPage0.Controls.Add(lblCusRgnCode)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtCusAddress1)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtCusAddress2)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtCusAddress3)
		Me._tabDetailInfo_TabPage0.Controls.Add(txtCusAddress4)
		Me._tabDetailInfo_TabPage0.Controls.Add(cboCusRgnCode)
		Me._tabDetailInfo_TabPage1.Controls.Add(fraCusShipAddr2)
		Me._tabDetailInfo_TabPage1.Controls.Add(fraCusShipAddr1)
		Me._tabDetailInfo_TabPage1.Controls.Add(cboCusShipTerrCode2)
		Me._tabDetailInfo_TabPage1.Controls.Add(cboCusShipTerrCode)
		Me.fraCusShipAddr2.Controls.Add(txtCusShipAdd12)
		Me.fraCusShipAddr2.Controls.Add(txtCusShipContactPerson2)
		Me.fraCusShipAddr2.Controls.Add(txtCusShipAdd32)
		Me.fraCusShipAddr2.Controls.Add(txtCusShipAdd42)
		Me.fraCusShipAddr2.Controls.Add(txtCusShipTel2)
		Me.fraCusShipAddr2.Controls.Add(txtCusShipAdd22)
		Me.fraCusShipAddr2.Controls.Add(txtCusShipFax2)
		Me.fraCusShipAddr2.Controls.Add(txtCusShipTerrName2)
		Me.fraCusShipAddr2.Controls.Add(lblCusShipAdd2)
		Me.fraCusShipAddr2.Controls.Add(lblCusShipContactPerson2)
		Me.fraCusShipAddr2.Controls.Add(lblCusShipTel2)
		Me.fraCusShipAddr2.Controls.Add(lblCusShipTerrCode2)
		Me.fraCusShipAddr1.Controls.Add(txtCusShipTerrName)
		Me.fraCusShipAddr1.Controls.Add(txtCusShipFax)
		Me.fraCusShipAddr1.Controls.Add(txtCusShipAdd2)
		Me.fraCusShipAddr1.Controls.Add(txtCusShipTel)
		Me.fraCusShipAddr1.Controls.Add(txtCusShipAdd4)
		Me.fraCusShipAddr1.Controls.Add(txtCusShipAdd3)
		Me.fraCusShipAddr1.Controls.Add(txtCusShipContactPerson)
		Me.fraCusShipAddr1.Controls.Add(txtCusShipAdd1)
		Me.fraCusShipAddr1.Controls.Add(lblCusShipTerrCode)
		Me.fraCusShipAddr1.Controls.Add(lblCusShipTel)
		Me.fraCusShipAddr1.Controls.Add(lblCusShipContactPerson)
		Me.fraCusShipAddr1.Controls.Add(lblCusShipAdd1)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCusSpecDis)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCusCurr)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCusPayCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCusCreditLimit)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCusSaleName)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCusMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblDspCusMLDesc)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCusRemark)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblDspCusLastUpdDate)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblDspCusLastUpd)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCusLastUpdDate)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblCusLastUpd)
		Me._tabDetailInfo_TabPage2.Controls.Add(lblDspCusSaleName)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCusPayCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCusCurr)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCusSaleCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(txtCusSpecDis)
		Me._tabDetailInfo_TabPage2.Controls.Add(txtCusPayDesc)
		Me._tabDetailInfo_TabPage2.Controls.Add(txtCusCreditLimit)
		Me._tabDetailInfo_TabPage2.Controls.Add(cboCusMLCode)
		Me._tabDetailInfo_TabPage2.Controls.Add(txtCusRemark)
		Me._tabDetailInfo_TabPage3.Controls.Add(tblDetail)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblOpenBal)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspOpenBal)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspARBal)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblARBal)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspCloseBal)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblCloseBal)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblAcmMnSale)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmMnSaleNet)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmMnSaleAmt)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmMnSaleQty)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblAcmYrSale)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmYrSaleNet)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmYrSaleAmt)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmYrSaleQty)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblAcmSale)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmSaleNet)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmSaleAmt)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblNet)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblAmt)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspAcmSaleQty)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblQty)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblCusCrtDate)
		Me._tabDetailInfo_TabPage3.Controls.Add(lblDspCrtDate)
		Me.fraCustomerInfo.Controls.Add(txtCusContactPerson1)
		Me.fraCustomerInfo.Controls.Add(txtCusName)
		Me.fraCustomerInfo.Controls.Add(txtCusTel)
		Me.fraCustomerInfo.Controls.Add(txtCusFax)
		Me.fraCustomerInfo.Controls.Add(chkBadList)
		Me.fraCustomerInfo.Controls.Add(chkInActive)
		Me.fraCustomerInfo.Controls.Add(txtCusContactPerson)
		Me.fraCustomerInfo.Controls.Add(txtCusEmail)
		Me.fraCustomerInfo.Controls.Add(txtCusCode)
		Me.fraCustomerInfo.Controls.Add(lblCusContactPerson1)
		Me.fraCustomerInfo.Controls.Add(lblCusCode)
		Me.fraCustomerInfo.Controls.Add(lblCusName)
		Me.fraCustomerInfo.Controls.Add(lblCusTel)
		Me.fraCustomerInfo.Controls.Add(lblCusFax)
		Me.fraCustomerInfo.Controls.Add(lblCusContactPerson)
		Me.fraCustomerInfo.Controls.Add(lblCusEmail)
		CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tblCommon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tbrProcess.ResumeLayout(False)
		Me.tabDetailInfo.ResumeLayout(False)
		Me._tabDetailInfo_TabPage0.ResumeLayout(False)
		Me._tabDetailInfo_TabPage1.ResumeLayout(False)
		Me.fraCusShipAddr2.ResumeLayout(False)
		Me.fraCusShipAddr1.ResumeLayout(False)
		Me._tabDetailInfo_TabPage2.ResumeLayout(False)
		Me._tabDetailInfo_TabPage3.ResumeLayout(False)
		Me.fraCustomerInfo.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class