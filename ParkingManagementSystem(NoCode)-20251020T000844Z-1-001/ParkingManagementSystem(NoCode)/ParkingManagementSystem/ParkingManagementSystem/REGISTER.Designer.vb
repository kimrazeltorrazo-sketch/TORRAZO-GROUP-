<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTER
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim btnCancel As Guna.UI2.WinForms.Guna2Button
        Me.picQR = New System.Windows.Forms.PictureBox()
        Me.Guna2HtmlLabel15 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel17 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtContactNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel16 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSEcondaryColor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel15 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtBodyType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel14 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtPrimaryColor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel13 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSecurityQuestion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel12 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtVehicleRegistrationNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel14 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel13 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox8 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox6 = New Guna.UI2.WinForms.Guna2TextBox()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel17.SuspendLayout()
        Me.Guna2Panel16.SuspendLayout()
        Me.Guna2Panel15.SuspendLayout()
        Me.Guna2Panel14.SuspendLayout()
        Me.Guna2Panel13.SuspendLayout()
        Me.Guna2Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        btnCancel.BorderRadius = 15
        btnCancel.CheckedState.Parent = btnCancel
        btnCancel.CustomImages.Parent = btnCancel
        btnCancel.FillColor = System.Drawing.Color.CadetBlue
        btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnCancel.ForeColor = System.Drawing.Color.White
        btnCancel.HoverState.Parent = btnCancel
        btnCancel.Location = New System.Drawing.Point(431, 443)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.Parent = btnCancel
        btnCancel.Size = New System.Drawing.Size(209, 50)
        btnCancel.TabIndex = 39
        btnCancel.Text = "Cancel"
        AddHandler btnCancel.Click, AddressOf Me.btnCancel_Click
        '
        'picQR
        '
        Me.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picQR.Location = New System.Drawing.Point(735, 431)
        Me.picQR.Name = "picQR"
        Me.picQR.Size = New System.Drawing.Size(67, 62)
        Me.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQR.TabIndex = 37
        Me.picQR.TabStop = False
        '
        'Guna2HtmlLabel15
        '
        Me.Guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel15.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel15.Location = New System.Drawing.Point(451, 70)
        Me.Guna2HtmlLabel15.Name = "Guna2HtmlLabel15"
        Me.Guna2HtmlLabel15.Size = New System.Drawing.Size(145, 26)
        Me.Guna2HtmlLabel15.TabIndex = 36
        Me.Guna2HtmlLabel15.Text = "Contact Number:"
        '
        'Guna2Panel17
        '
        Me.Guna2Panel17.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel17.Controls.Add(Me.txtContactNum)
        Me.Guna2Panel17.Location = New System.Drawing.Point(454, 97)
        Me.Guna2Panel17.Name = "Guna2Panel17"
        Me.Guna2Panel17.ShadowDecoration.Parent = Me.Guna2Panel17
        Me.Guna2Panel17.Size = New System.Drawing.Size(354, 43)
        Me.Guna2Panel17.TabIndex = 34
        '
        'txtContactNum
        '
        Me.txtContactNum.BorderColor = System.Drawing.Color.Transparent
        Me.txtContactNum.BorderThickness = 0
        Me.txtContactNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContactNum.DefaultText = ""
        Me.txtContactNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContactNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContactNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContactNum.DisabledState.Parent = Me.txtContactNum
        Me.txtContactNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContactNum.FillColor = System.Drawing.SystemColors.Control
        Me.txtContactNum.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtContactNum.FocusedState.Parent = Me.txtContactNum
        Me.txtContactNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNum.ForeColor = System.Drawing.Color.CadetBlue
        Me.txtContactNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNum.HoverState.Parent = Me.txtContactNum
        Me.txtContactNum.Location = New System.Drawing.Point(0, -5)
        Me.txtContactNum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContactNum.PlaceholderText = ""
        Me.txtContactNum.SelectedText = ""
        Me.txtContactNum.ShadowDecoration.Parent = Me.txtContactNum
        Me.txtContactNum.Size = New System.Drawing.Size(357, 45)
        Me.txtContactNum.TabIndex = 21
        '
        'Guna2Panel16
        '
        Me.Guna2Panel16.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel16.Controls.Add(Me.txtSEcondaryColor)
        Me.Guna2Panel16.Location = New System.Drawing.Point(451, 340)
        Me.Guna2Panel16.Name = "Guna2Panel16"
        Me.Guna2Panel16.ShadowDecoration.Parent = Me.Guna2Panel16
        Me.Guna2Panel16.Size = New System.Drawing.Size(352, 43)
        Me.Guna2Panel16.TabIndex = 30
        '
        'txtSEcondaryColor
        '
        Me.txtSEcondaryColor.BorderColor = System.Drawing.Color.Transparent
        Me.txtSEcondaryColor.BorderThickness = 0
        Me.txtSEcondaryColor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSEcondaryColor.DefaultText = ""
        Me.txtSEcondaryColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSEcondaryColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSEcondaryColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSEcondaryColor.DisabledState.Parent = Me.txtSEcondaryColor
        Me.txtSEcondaryColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSEcondaryColor.FillColor = System.Drawing.SystemColors.Control
        Me.txtSEcondaryColor.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtSEcondaryColor.FocusedState.Parent = Me.txtSEcondaryColor
        Me.txtSEcondaryColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSEcondaryColor.ForeColor = System.Drawing.Color.CadetBlue
        Me.txtSEcondaryColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSEcondaryColor.HoverState.Parent = Me.txtSEcondaryColor
        Me.txtSEcondaryColor.Location = New System.Drawing.Point(-3, -4)
        Me.txtSEcondaryColor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSEcondaryColor.Name = "txtSEcondaryColor"
        Me.txtSEcondaryColor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSEcondaryColor.PlaceholderText = ""
        Me.txtSEcondaryColor.SelectedText = ""
        Me.txtSEcondaryColor.ShadowDecoration.Parent = Me.txtSEcondaryColor
        Me.txtSEcondaryColor.Size = New System.Drawing.Size(357, 45)
        Me.txtSEcondaryColor.TabIndex = 0
        '
        'Guna2Panel15
        '
        Me.Guna2Panel15.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel15.Controls.Add(Me.txtBodyType)
        Me.Guna2Panel15.Location = New System.Drawing.Point(454, 224)
        Me.Guna2Panel15.Name = "Guna2Panel15"
        Me.Guna2Panel15.ShadowDecoration.Parent = Me.Guna2Panel15
        Me.Guna2Panel15.Size = New System.Drawing.Size(352, 43)
        Me.Guna2Panel15.TabIndex = 28
        '
        'txtBodyType
        '
        Me.txtBodyType.BorderColor = System.Drawing.Color.Transparent
        Me.txtBodyType.BorderThickness = 0
        Me.txtBodyType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBodyType.DefaultText = ""
        Me.txtBodyType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBodyType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBodyType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBodyType.DisabledState.Parent = Me.txtBodyType
        Me.txtBodyType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBodyType.FillColor = System.Drawing.SystemColors.Control
        Me.txtBodyType.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtBodyType.FocusedState.Parent = Me.txtBodyType
        Me.txtBodyType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBodyType.ForeColor = System.Drawing.Color.CadetBlue
        Me.txtBodyType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBodyType.HoverState.Parent = Me.txtBodyType
        Me.txtBodyType.Location = New System.Drawing.Point(-3, -4)
        Me.txtBodyType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBodyType.Name = "txtBodyType"
        Me.txtBodyType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBodyType.PlaceholderText = ""
        Me.txtBodyType.SelectedText = ""
        Me.txtBodyType.ShadowDecoration.Parent = Me.txtBodyType
        Me.txtBodyType.Size = New System.Drawing.Size(357, 45)
        Me.txtBodyType.TabIndex = 0
        '
        'Guna2Panel14
        '
        Me.Guna2Panel14.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel14.Controls.Add(Me.txtPrimaryColor)
        Me.Guna2Panel14.Location = New System.Drawing.Point(38, 340)
        Me.Guna2Panel14.Name = "Guna2Panel14"
        Me.Guna2Panel14.ShadowDecoration.Parent = Me.Guna2Panel14
        Me.Guna2Panel14.Size = New System.Drawing.Size(352, 43)
        Me.Guna2Panel14.TabIndex = 31
        '
        'txtPrimaryColor
        '
        Me.txtPrimaryColor.BorderColor = System.Drawing.Color.Transparent
        Me.txtPrimaryColor.BorderThickness = 0
        Me.txtPrimaryColor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrimaryColor.DefaultText = ""
        Me.txtPrimaryColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrimaryColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrimaryColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrimaryColor.DisabledState.Parent = Me.txtPrimaryColor
        Me.txtPrimaryColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrimaryColor.FillColor = System.Drawing.SystemColors.Control
        Me.txtPrimaryColor.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtPrimaryColor.FocusedState.Parent = Me.txtPrimaryColor
        Me.txtPrimaryColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimaryColor.ForeColor = System.Drawing.Color.CadetBlue
        Me.txtPrimaryColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrimaryColor.HoverState.Parent = Me.txtPrimaryColor
        Me.txtPrimaryColor.Location = New System.Drawing.Point(-3, -4)
        Me.txtPrimaryColor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrimaryColor.Name = "txtPrimaryColor"
        Me.txtPrimaryColor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimaryColor.PlaceholderText = ""
        Me.txtPrimaryColor.SelectedText = ""
        Me.txtPrimaryColor.ShadowDecoration.Parent = Me.txtPrimaryColor
        Me.txtPrimaryColor.Size = New System.Drawing.Size(357, 45)
        Me.txtPrimaryColor.TabIndex = 0
        '
        'Guna2Panel13
        '
        Me.Guna2Panel13.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel13.Controls.Add(Me.txtSecurityQuestion)
        Me.Guna2Panel13.Location = New System.Drawing.Point(41, 224)
        Me.Guna2Panel13.Name = "Guna2Panel13"
        Me.Guna2Panel13.ShadowDecoration.Parent = Me.Guna2Panel13
        Me.Guna2Panel13.Size = New System.Drawing.Size(352, 43)
        Me.Guna2Panel13.TabIndex = 29
        '
        'txtSecurityQuestion
        '
        Me.txtSecurityQuestion.BorderColor = System.Drawing.Color.Transparent
        Me.txtSecurityQuestion.BorderThickness = 0
        Me.txtSecurityQuestion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecurityQuestion.DefaultText = ""
        Me.txtSecurityQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecurityQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecurityQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecurityQuestion.DisabledState.Parent = Me.txtSecurityQuestion
        Me.txtSecurityQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecurityQuestion.FillColor = System.Drawing.SystemColors.Control
        Me.txtSecurityQuestion.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtSecurityQuestion.FocusedState.Parent = Me.txtSecurityQuestion
        Me.txtSecurityQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecurityQuestion.ForeColor = System.Drawing.Color.CadetBlue
        Me.txtSecurityQuestion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecurityQuestion.HoverState.Parent = Me.txtSecurityQuestion
        Me.txtSecurityQuestion.Location = New System.Drawing.Point(-3, -4)
        Me.txtSecurityQuestion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSecurityQuestion.Name = "txtSecurityQuestion"
        Me.txtSecurityQuestion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecurityQuestion.PlaceholderText = ""
        Me.txtSecurityQuestion.SelectedText = ""
        Me.txtSecurityQuestion.ShadowDecoration.Parent = Me.txtSecurityQuestion
        Me.txtSecurityQuestion.Size = New System.Drawing.Size(357, 45)
        Me.txtSecurityQuestion.TabIndex = 0
        '
        'Guna2Panel12
        '
        Me.Guna2Panel12.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel12.Controls.Add(Me.txtVehicleRegistrationNumber)
        Me.Guna2Panel12.Location = New System.Drawing.Point(41, 101)
        Me.Guna2Panel12.Name = "Guna2Panel12"
        Me.Guna2Panel12.ShadowDecoration.Parent = Me.Guna2Panel12
        Me.Guna2Panel12.Size = New System.Drawing.Size(354, 43)
        Me.Guna2Panel12.TabIndex = 32
        '
        'txtVehicleRegistrationNumber
        '
        Me.txtVehicleRegistrationNumber.BorderColor = System.Drawing.Color.Transparent
        Me.txtVehicleRegistrationNumber.BorderThickness = 0
        Me.txtVehicleRegistrationNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVehicleRegistrationNumber.DefaultText = ""
        Me.txtVehicleRegistrationNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVehicleRegistrationNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVehicleRegistrationNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVehicleRegistrationNumber.DisabledState.Parent = Me.txtVehicleRegistrationNumber
        Me.txtVehicleRegistrationNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVehicleRegistrationNumber.FillColor = System.Drawing.SystemColors.Control
        Me.txtVehicleRegistrationNumber.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtVehicleRegistrationNumber.FocusedState.Parent = Me.txtVehicleRegistrationNumber
        Me.txtVehicleRegistrationNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicleRegistrationNumber.ForeColor = System.Drawing.Color.CadetBlue
        Me.txtVehicleRegistrationNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVehicleRegistrationNumber.HoverState.Parent = Me.txtVehicleRegistrationNumber
        Me.txtVehicleRegistrationNumber.Location = New System.Drawing.Point(0, -4)
        Me.txtVehicleRegistrationNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtVehicleRegistrationNumber.Name = "txtVehicleRegistrationNumber"
        Me.txtVehicleRegistrationNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVehicleRegistrationNumber.PlaceholderText = ""
        Me.txtVehicleRegistrationNumber.SelectedText = ""
        Me.txtVehicleRegistrationNumber.ShadowDecoration.Parent = Me.txtVehicleRegistrationNumber
        Me.txtVehicleRegistrationNumber.Size = New System.Drawing.Size(357, 45)
        Me.txtVehicleRegistrationNumber.TabIndex = 0
        '
        'Guna2HtmlLabel14
        '
        Me.Guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel14.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel14.Location = New System.Drawing.Point(448, 309)
        Me.Guna2HtmlLabel14.Name = "Guna2HtmlLabel14"
        Me.Guna2HtmlLabel14.Size = New System.Drawing.Size(149, 26)
        Me.Guna2HtmlLabel14.TabIndex = 24
        Me.Guna2HtmlLabel14.Text = "Secondary Color:"
        '
        'Guna2HtmlLabel13
        '
        Me.Guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel13.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel13.Location = New System.Drawing.Point(451, 193)
        Me.Guna2HtmlLabel13.Name = "Guna2HtmlLabel13"
        Me.Guna2HtmlLabel13.Size = New System.Drawing.Size(99, 26)
        Me.Guna2HtmlLabel13.TabIndex = 25
        Me.Guna2HtmlLabel13.Text = "Body Type:"
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel12.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(35, 309)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(121, 26)
        Me.Guna2HtmlLabel12.TabIndex = 27
        Me.Guna2HtmlLabel12.Text = "Primary Color:"
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(38, 193)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(152, 26)
        Me.Guna2HtmlLabel11.TabIndex = 26
        Me.Guna2HtmlLabel11.Text = "Car Maker Model:"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(38, 70)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(249, 26)
        Me.Guna2HtmlLabel9.TabIndex = 23
        Me.Guna2HtmlLabel9.Text = "Vehicle Registration Number:"
        '
        'btnConfirm
        '
        Me.btnConfirm.BorderRadius = 15
        Me.btnConfirm.CheckedState.Parent = Me.btnConfirm
        Me.btnConfirm.CustomImages.Parent = Me.btnConfirm
        Me.btnConfirm.FillColor = System.Drawing.Color.CadetBlue
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.HoverState.Parent = Me.btnConfirm
        Me.btnConfirm.Location = New System.Drawing.Point(194, 443)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.ShadowDecoration.Parent = Me.btnConfirm
        Me.btnConfirm.Size = New System.Drawing.Size(209, 50)
        Me.btnConfirm.TabIndex = 38
        Me.btnConfirm.Text = "Confirm"
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox3.BorderThickness = 0
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = ""
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox3.FocusedState.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox3.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.HoverState.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.Location = New System.Drawing.Point(0, -4)
        Me.Guna2TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderText = ""
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.ShadowDecoration.Parent = Me.Guna2TextBox3
        Me.Guna2TextBox3.Size = New System.Drawing.Size(357, 45)
        Me.Guna2TextBox3.TabIndex = 0
        '
        'Guna2TextBox8
        '
        Me.Guna2TextBox8.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox8.BorderThickness = 0
        Me.Guna2TextBox8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox8.DefaultText = ""
        Me.Guna2TextBox8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox8.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox8.DisabledState.Parent = Me.Guna2TextBox8
        Me.Guna2TextBox8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox8.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBox8.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox8.FocusedState.Parent = Me.Guna2TextBox8
        Me.Guna2TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox8.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2TextBox8.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox8.HoverState.Parent = Me.Guna2TextBox8
        Me.Guna2TextBox8.Location = New System.Drawing.Point(0, -5)
        Me.Guna2TextBox8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2TextBox8.Name = "Guna2TextBox8"
        Me.Guna2TextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox8.PlaceholderText = ""
        Me.Guna2TextBox8.SelectedText = ""
        Me.Guna2TextBox8.ShadowDecoration.Parent = Me.Guna2TextBox8
        Me.Guna2TextBox8.Size = New System.Drawing.Size(357, 45)
        Me.Guna2TextBox8.TabIndex = 21
        '
        'Guna2TextBox6
        '
        Me.Guna2TextBox6.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox6.BorderThickness = 0
        Me.Guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox6.DefaultText = ""
        Me.Guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.Parent = Me.Guna2TextBox6
        Me.Guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox6.FocusedState.Parent = Me.Guna2TextBox6
        Me.Guna2TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox6.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.HoverState.Parent = Me.Guna2TextBox6
        Me.Guna2TextBox6.Location = New System.Drawing.Point(-3, -4)
        Me.Guna2TextBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2TextBox6.Name = "Guna2TextBox6"
        Me.Guna2TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox6.PlaceholderText = ""
        Me.Guna2TextBox6.SelectedText = ""
        Me.Guna2TextBox6.ShadowDecoration.Parent = Me.Guna2TextBox6
        Me.Guna2TextBox6.Size = New System.Drawing.Size(357, 45)
        Me.Guna2TextBox6.TabIndex = 0
        '
        'REGISTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 507)
        Me.Controls.Add(btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.picQR)
        Me.Controls.Add(Me.Guna2HtmlLabel15)
        Me.Controls.Add(Me.Guna2Panel17)
        Me.Controls.Add(Me.Guna2Panel16)
        Me.Controls.Add(Me.Guna2Panel15)
        Me.Controls.Add(Me.Guna2Panel14)
        Me.Controls.Add(Me.Guna2Panel13)
        Me.Controls.Add(Me.Guna2Panel12)
        Me.Controls.Add(Me.Guna2HtmlLabel14)
        Me.Controls.Add(Me.Guna2HtmlLabel13)
        Me.Controls.Add(Me.Guna2HtmlLabel12)
        Me.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Name = "REGISTER"
        Me.Text = "REGISTER"
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel17.ResumeLayout(False)
        Me.Guna2Panel16.ResumeLayout(False)
        Me.Guna2Panel15.ResumeLayout(False)
        Me.Guna2Panel14.ResumeLayout(False)
        Me.Guna2Panel13.ResumeLayout(False)
        Me.Guna2Panel12.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picQR As System.Windows.Forms.PictureBox
    Friend WithEvents Guna2HtmlLabel15 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel17 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtContactNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel16 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSEcondaryColor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel15 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox6 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel14 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtPrimaryColor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel13 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSecurityQuestion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel12 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel14 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel13 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtVehicleRegistrationNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox8 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBodyType As Guna.UI2.WinForms.Guna2TextBox

    Private Sub Guna2TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVehicleRegistrationNumber.TextChanged

    End Sub

    Private Sub REGISTER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


End Class
