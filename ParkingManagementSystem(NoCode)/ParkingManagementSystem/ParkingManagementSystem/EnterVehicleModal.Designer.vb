<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterVehicleModal
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
        Me.components = New System.ComponentModel.Container()
        Dim btnCancel As Guna.UI2.WinForms.Guna2Button
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSecurityQuestion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtVehicleRegistrationNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtTimeIn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCarMakerModel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtTimeOut = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtBodyType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtPrimaryColor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSEcondaryColor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtContactNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.picQR = New System.Windows.Forms.PictureBox()
        Me.btnAttach = New Guna.UI2.WinForms.Guna2Button()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel10.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).BeginInit()
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
        btnCancel.Location = New System.Drawing.Point(431, 602)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.Parent = btnCancel
        btnCancel.Size = New System.Drawing.Size(209, 50)
        btnCancel.TabIndex = 20
        btnCancel.Text = "Cancel"
        AddHandler btnCancel.Click, AddressOf Me.btnCancel_Click
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel10
        '
        Me.Guna2Panel10.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel10.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel10.Location = New System.Drawing.Point(1, 2)
        Me.Guna2Panel10.Name = "Guna2Panel10"
        Me.Guna2Panel10.ShadowDecoration.Parent = Me.Guna2Panel10
        Me.Guna2Panel10.Size = New System.Drawing.Size(832, 60)
        Me.Guna2Panel10.TabIndex = 13
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(334, 8)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(159, 31)
        Me.Guna2HtmlLabel2.TabIndex = 6
        Me.Guna2HtmlLabel2.Text = "Enter Vehicle"
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel8.Controls.Add(Me.txtSecurityQuestion)
        Me.Guna2Panel8.Location = New System.Drawing.Point(32, 362)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.ShadowDecoration.Parent = Me.Guna2Panel8
        Me.Guna2Panel8.Size = New System.Drawing.Size(352, 43)
        Me.Guna2Panel8.TabIndex = 17
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
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel6.Controls.Add(Me.txtVehicleRegistrationNumber)
        Me.Guna2Panel6.Location = New System.Drawing.Point(32, 239)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(354, 43)
        Me.Guna2Panel6.TabIndex = 18
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
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel3.Controls.Add(Me.txtTimeIn)
        Me.Guna2Panel3.Location = New System.Drawing.Point(32, 121)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(352, 43)
        Me.Guna2Panel3.TabIndex = 19
        '
        'txtTimeIn
        '
        Me.txtTimeIn.BorderColor = System.Drawing.Color.Transparent
        Me.txtTimeIn.BorderThickness = 0
        Me.txtTimeIn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimeIn.DefaultText = ""
        Me.txtTimeIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTimeIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTimeIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTimeIn.DisabledState.Parent = Me.txtTimeIn
        Me.txtTimeIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTimeIn.FillColor = System.Drawing.SystemColors.Control
        Me.txtTimeIn.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtTimeIn.FocusedState.Parent = Me.txtTimeIn
        Me.txtTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeIn.ForeColor = System.Drawing.Color.CadetBlue
        Me.txtTimeIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTimeIn.HoverState.Parent = Me.txtTimeIn
        Me.txtTimeIn.Location = New System.Drawing.Point(-3, -4)
        Me.txtTimeIn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTimeIn.Name = "txtTimeIn"
        Me.txtTimeIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTimeIn.PlaceholderText = ""
        Me.txtTimeIn.ReadOnly = True
        Me.txtTimeIn.SelectedText = ""
        Me.txtTimeIn.ShadowDecoration.Parent = Me.txtTimeIn
        Me.txtTimeIn.Size = New System.Drawing.Size(357, 45)
        Me.txtTimeIn.TabIndex = 0
        '
        'txtCarMakerModel
        '
        Me.txtCarMakerModel.BackColor = System.Drawing.Color.Transparent
        Me.txtCarMakerModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarMakerModel.ForeColor = System.Drawing.Color.CadetBlue
        Me.txtCarMakerModel.Location = New System.Drawing.Point(29, 331)
        Me.txtCarMakerModel.Name = "txtCarMakerModel"
        Me.txtCarMakerModel.Size = New System.Drawing.Size(152, 26)
        Me.txtCarMakerModel.TabIndex = 15
        Me.txtCarMakerModel.Text = "Car Maker Model:"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(29, 208)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(249, 26)
        Me.Guna2HtmlLabel4.TabIndex = 14
        Me.Guna2HtmlLabel4.Text = "Vehicle Registration Number:"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(29, 90)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(71, 26)
        Me.Guna2HtmlLabel3.TabIndex = 16
        Me.Guna2HtmlLabel3.Text = "Time In:"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(442, 90)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(86, 26)
        Me.Guna2HtmlLabel1.TabIndex = 16
        Me.Guna2HtmlLabel1.Text = "Time Out:"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(442, 331)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(99, 26)
        Me.Guna2HtmlLabel6.TabIndex = 15
        Me.Guna2HtmlLabel6.Text = "Body Type:"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel1.Controls.Add(Me.txtTimeOut)
        Me.Guna2Panel1.Location = New System.Drawing.Point(445, 121)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(352, 43)
        Me.Guna2Panel1.TabIndex = 19
        '
        'txtTimeOut
        '
        Me.txtTimeOut.BorderColor = System.Drawing.Color.Transparent
        Me.txtTimeOut.BorderThickness = 0
        Me.txtTimeOut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimeOut.DefaultText = ""
        Me.txtTimeOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTimeOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTimeOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTimeOut.DisabledState.Parent = Me.txtTimeOut
        Me.txtTimeOut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTimeOut.FillColor = System.Drawing.SystemColors.Control
        Me.txtTimeOut.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtTimeOut.FocusedState.Parent = Me.txtTimeOut
        Me.txtTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeOut.ForeColor = System.Drawing.Color.CadetBlue
        Me.txtTimeOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTimeOut.HoverState.Parent = Me.txtTimeOut
        Me.txtTimeOut.Location = New System.Drawing.Point(-3, -4)
        Me.txtTimeOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTimeOut.PlaceholderText = ""
        Me.txtTimeOut.SelectedText = ""
        Me.txtTimeOut.ShadowDecoration.Parent = Me.txtTimeOut
        Me.txtTimeOut.Size = New System.Drawing.Size(357, 45)
        Me.txtTimeOut.TabIndex = 0
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel4.Controls.Add(Me.txtBodyType)
        Me.Guna2Panel4.Location = New System.Drawing.Point(445, 362)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(352, 43)
        Me.Guna2Panel4.TabIndex = 17
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
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(26, 447)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(121, 26)
        Me.Guna2HtmlLabel5.TabIndex = 15
        Me.Guna2HtmlLabel5.Text = "Primary Color:"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(439, 447)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(149, 26)
        Me.Guna2HtmlLabel8.TabIndex = 15
        Me.Guna2HtmlLabel8.Text = "Secondary Color:"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel2.Controls.Add(Me.txtPrimaryColor)
        Me.Guna2Panel2.Location = New System.Drawing.Point(29, 478)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(352, 43)
        Me.Guna2Panel2.TabIndex = 17
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
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel5.Controls.Add(Me.txtSEcondaryColor)
        Me.Guna2Panel5.Location = New System.Drawing.Point(442, 478)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(352, 43)
        Me.Guna2Panel5.TabIndex = 17
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
        'btnConfirm
        '
        Me.btnConfirm.BorderRadius = 15
        Me.btnConfirm.CheckedState.Parent = Me.btnConfirm
        Me.btnConfirm.CustomImages.Parent = Me.btnConfirm
        Me.btnConfirm.FillColor = System.Drawing.Color.CadetBlue
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.HoverState.Parent = Me.btnConfirm
        Me.btnConfirm.Location = New System.Drawing.Point(194, 602)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.ShadowDecoration.Parent = Me.btnConfirm
        Me.btnConfirm.Size = New System.Drawing.Size(209, 50)
        Me.btnConfirm.TabIndex = 20
        Me.btnConfirm.Text = "Confirm"
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel7.Controls.Add(Me.txtContactNum)
        Me.Guna2Panel7.Location = New System.Drawing.Point(445, 235)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.Size = New System.Drawing.Size(354, 43)
        Me.Guna2Panel7.TabIndex = 19
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
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(442, 208)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(145, 26)
        Me.Guna2HtmlLabel7.TabIndex = 21
        Me.Guna2HtmlLabel7.Text = "Contact Number:"
        '
        'picQR
        '
        Me.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picQR.Location = New System.Drawing.Point(726, 569)
        Me.picQR.Name = "picQR"
        Me.picQR.Size = New System.Drawing.Size(67, 62)
        Me.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQR.TabIndex = 22
        Me.picQR.TabStop = False
        '
        'btnAttach
        '
        Me.btnAttach.BorderRadius = 15
        Me.btnAttach.CheckedState.Parent = Me.btnAttach
        Me.btnAttach.CustomImages.Parent = Me.btnAttach
        Me.btnAttach.FillColor = System.Drawing.Color.CadetBlue
        Me.btnAttach.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttach.ForeColor = System.Drawing.Color.White
        Me.btnAttach.HoverState.Parent = Me.btnAttach
        Me.btnAttach.Location = New System.Drawing.Point(505, 546)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.ShadowDecoration.Parent = Me.btnAttach
        Me.btnAttach.Size = New System.Drawing.Size(135, 37)
        Me.btnAttach.TabIndex = 23
        Me.btnAttach.Text = "Attach"
        '
        'EnterVehicleModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 667)
        Me.Controls.Add(Me.btnAttach)
        Me.Controls.Add(Me.picQR)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.Guna2Panel7)
        Me.Controls.Add(btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel8)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.txtCarMakerModel)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2Panel10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EnterVehicleModal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EnterVehicleModal"
        Me.Guna2Panel10.ResumeLayout(False)
        Me.Guna2Panel10.PerformLayout()
        Me.Guna2Panel8.ResumeLayout(False)
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSEcondaryColor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtBodyType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtPrimaryColor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSecurityQuestion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtVehicleRegistrationNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtTimeOut As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtTimeIn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCarMakerModel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtContactNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents picQR As System.Windows.Forms.PictureBox
    Friend WithEvents btnAttach As Guna.UI2.WinForms.Guna2Button
End Class
