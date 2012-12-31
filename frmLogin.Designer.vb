<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmLogin
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
	Public WithEvents cboLangID As System.Windows.Forms.ComboBox
	Public WithEvents cboCompany As System.Windows.Forms.ComboBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
	Public WithEvents txtUserID As System.Windows.Forms.TextBox
	Public WithEvents lblLanguage As System.Windows.Forms.Label
	Public WithEvents lblCompany As System.Windows.Forms.Label
	Public WithEvents lblPassword As System.Windows.Forms.Label
	Public WithEvents lblUser As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogin))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cboLangID = New System.Windows.Forms.ComboBox
		Me.cboCompany = New System.Windows.Forms.ComboBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOK = New System.Windows.Forms.Button
		Me.txtPassword = New System.Windows.Forms.TextBox
		Me.txtUserID = New System.Windows.Forms.TextBox
		Me.lblLanguage = New System.Windows.Forms.Label
		Me.lblCompany = New System.Windows.Forms.Label
		Me.lblPassword = New System.Windows.Forms.Label
		Me.lblUser = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Login"
		Me.ClientSize = New System.Drawing.Size(510, 225)
		Me.Location = New System.Drawing.Point(2, 18)
		Me.ControlBox = False
		Me.Icon = CType(resources.GetObject("frmLogin.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BackgroundImage = CType(resources.GetObject("frmLogin.BackgroundImage"), System.Drawing.Image)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Tag = "Login"
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmLogin"
		Me.cboLangID.Size = New System.Drawing.Size(150, 20)
		Me.cboLangID.Location = New System.Drawing.Point(232, 120)
		Me.cboLangID.TabIndex = 3
		Me.cboLangID.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboLangID.BackColor = System.Drawing.SystemColors.Window
		Me.cboLangID.CausesValidation = True
		Me.cboLangID.Enabled = True
		Me.cboLangID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboLangID.IntegralHeight = True
		Me.cboLangID.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboLangID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboLangID.Sorted = False
		Me.cboLangID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboLangID.TabStop = True
		Me.cboLangID.Visible = True
		Me.cboLangID.Name = "cboLangID"
		Me.cboCompany.Size = New System.Drawing.Size(271, 20)
		Me.cboCompany.Location = New System.Drawing.Point(231, 42)
		Me.cboCompany.TabIndex = 0
		Me.cboCompany.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCompany.BackColor = System.Drawing.SystemColors.Window
		Me.cboCompany.CausesValidation = True
		Me.cboCompany.Enabled = True
		Me.cboCompany.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboCompany.IntegralHeight = True
		Me.cboCompany.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboCompany.Sorted = False
		Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboCompany.TabStop = True
		Me.cboCompany.Visible = True
		Me.cboCompany.Name = "cboCompany"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(108, 48)
		Me.cmdCancel.Location = New System.Drawing.Point(336, 160)
		Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
		Me.cmdCancel.TabIndex = 5
		Me.cmdCancel.Tag = "Cancel"
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdOK.Text = "OK"
		Me.cmdOK.Size = New System.Drawing.Size(108, 48)
		Me.cmdOK.Location = New System.Drawing.Point(224, 160)
		Me.cmdOK.Image = CType(resources.GetObject("cmdOK.Image"), System.Drawing.Image)
		Me.cmdOK.TabIndex = 4
		Me.cmdOK.Tag = "OK"
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.txtPassword.AutoSize = False
		Me.txtPassword.Size = New System.Drawing.Size(155, 20)
		Me.txtPassword.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtPassword.Location = New System.Drawing.Point(231, 93)
		Me.txtPassword.PasswordChar = ChrW(42)
		Me.txtPassword.TabIndex = 2
		Me.txtPassword.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.AcceptsReturn = True
		Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtPassword.CausesValidation = True
		Me.txtPassword.Enabled = True
		Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPassword.HideSelection = True
		Me.txtPassword.ReadOnly = False
		Me.txtPassword.Maxlength = 0
		Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPassword.MultiLine = False
		Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPassword.TabStop = True
		Me.txtPassword.Visible = True
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPassword.Name = "txtPassword"
		Me.txtUserID.AutoSize = False
		Me.txtUserID.Size = New System.Drawing.Size(155, 20)
		Me.txtUserID.Location = New System.Drawing.Point(231, 66)
		Me.txtUserID.TabIndex = 1
		Me.txtUserID.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUserID.AcceptsReturn = True
		Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUserID.BackColor = System.Drawing.SystemColors.Window
		Me.txtUserID.CausesValidation = True
		Me.txtUserID.Enabled = True
		Me.txtUserID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUserID.HideSelection = True
		Me.txtUserID.ReadOnly = False
		Me.txtUserID.Maxlength = 0
		Me.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUserID.MultiLine = False
		Me.txtUserID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUserID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUserID.TabStop = True
		Me.txtUserID.Visible = True
		Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUserID.Name = "txtUserID"
		Me.lblLanguage.Text = "&Language:"
		Me.lblLanguage.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLanguage.Size = New System.Drawing.Size(72, 17)
		Me.lblLanguage.Location = New System.Drawing.Point(151, 120)
		Me.lblLanguage.TabIndex = 9
		Me.lblLanguage.Tag = "&User Name:"
		Me.lblLanguage.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLanguage.BackColor = System.Drawing.Color.Transparent
		Me.lblLanguage.Enabled = True
		Me.lblLanguage.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLanguage.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLanguage.UseMnemonic = True
		Me.lblLanguage.Visible = True
		Me.lblLanguage.AutoSize = False
		Me.lblLanguage.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLanguage.Name = "lblLanguage"
		Me.lblCompany.Text = "&Company:"
		Me.lblCompany.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCompany.Size = New System.Drawing.Size(72, 17)
		Me.lblCompany.Location = New System.Drawing.Point(151, 42)
		Me.lblCompany.TabIndex = 8
		Me.lblCompany.Tag = "&User Name:"
		Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCompany.BackColor = System.Drawing.Color.Transparent
		Me.lblCompany.Enabled = True
		Me.lblCompany.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCompany.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCompany.UseMnemonic = True
		Me.lblCompany.Visible = True
		Me.lblCompany.AutoSize = False
		Me.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCompany.Name = "lblCompany"
		Me.lblPassword.Text = "&Password:"
		Me.lblPassword.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPassword.Size = New System.Drawing.Size(72, 17)
		Me.lblPassword.Location = New System.Drawing.Point(151, 94)
		Me.lblPassword.TabIndex = 6
		Me.lblPassword.Tag = "&Password:"
		Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPassword.BackColor = System.Drawing.Color.Transparent
		Me.lblPassword.Enabled = True
		Me.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPassword.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPassword.UseMnemonic = True
		Me.lblPassword.Visible = True
		Me.lblPassword.AutoSize = False
		Me.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPassword.Name = "lblPassword"
		Me.lblUser.Text = "&User ID:"
		Me.lblUser.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUser.Size = New System.Drawing.Size(72, 17)
		Me.lblUser.Location = New System.Drawing.Point(151, 68)
		Me.lblUser.TabIndex = 7
		Me.lblUser.Tag = "&User Name:"
		Me.lblUser.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUser.BackColor = System.Drawing.Color.Transparent
		Me.lblUser.Enabled = True
		Me.lblUser.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUser.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUser.UseMnemonic = True
		Me.lblUser.Visible = True
		Me.lblUser.AutoSize = False
		Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUser.Name = "lblUser"
		Me.Controls.Add(cboLangID)
		Me.Controls.Add(cboCompany)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(txtPassword)
		Me.Controls.Add(txtUserID)
		Me.Controls.Add(lblLanguage)
		Me.Controls.Add(lblCompany)
		Me.Controls.Add(lblPassword)
		Me.Controls.Add(lblUser)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class