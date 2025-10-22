<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtParkingAreaNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.txtParkingCharge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtVehicleLimit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtVehicleType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvDetails = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cbSearch = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeactivate = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvCategory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnCancelEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtParkingAreaNumber
        '
        Me.txtParkingAreaNumber.BorderColor = System.Drawing.Color.Transparent
        Me.txtParkingAreaNumber.BorderThickness = 0
        Me.txtParkingAreaNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParkingAreaNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtParkingAreaNumber.DefaultText = ""
        Me.txtParkingAreaNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtParkingAreaNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtParkingAreaNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtParkingAreaNumber.DisabledState.Parent = Me.txtParkingAreaNumber
        Me.txtParkingAreaNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtParkingAreaNumber.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtParkingAreaNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtParkingAreaNumber.FocusedState.Parent = Me.txtParkingAreaNumber
        Me.txtParkingAreaNumber.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParkingAreaNumber.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtParkingAreaNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtParkingAreaNumber.HoverState.Parent = Me.txtParkingAreaNumber
        Me.txtParkingAreaNumber.Location = New System.Drawing.Point(37, 125)
        Me.txtParkingAreaNumber.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtParkingAreaNumber.Name = "txtParkingAreaNumber"
        Me.txtParkingAreaNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtParkingAreaNumber.PlaceholderText = ""
        Me.txtParkingAreaNumber.SelectedText = ""
        Me.txtParkingAreaNumber.ShadowDecoration.Color = System.Drawing.Color.MidnightBlue
        Me.txtParkingAreaNumber.ShadowDecoration.Depth = 255
        Me.txtParkingAreaNumber.ShadowDecoration.Enabled = True
        Me.txtParkingAreaNumber.ShadowDecoration.Parent = Me.txtParkingAreaNumber
        Me.txtParkingAreaNumber.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.txtParkingAreaNumber.Size = New System.Drawing.Size(438, 52)
        Me.txtParkingAreaNumber.TabIndex = 4
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 0
        Me.Guna2Elipse2.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.btnSubmit)
        Me.Guna2Panel1.Controls.Add(Me.txtParkingCharge)
        Me.Guna2Panel1.Controls.Add(Me.txtVehicleLimit)
        Me.Guna2Panel1.Controls.Add(Me.txtVehicleType)
        Me.Guna2Panel1.Controls.Add(Me.txtParkingAreaNumber)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Panel1.Location = New System.Drawing.Point(43, 34)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 0
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.SystemColors.Control
        Me.Guna2Panel1.ShadowDecoration.Depth = 250
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1009, 525)
        Me.Guna2Panel1.TabIndex = 4
        '
        'btnSubmit
        '
        Me.btnSubmit.BorderRadius = 8
        Me.btnSubmit.CheckedState.Parent = Me.btnSubmit
        Me.btnSubmit.CustomImages.Parent = Me.btnSubmit
        Me.btnSubmit.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.Parent = Me.btnSubmit
        Me.btnSubmit.Location = New System.Drawing.Point(37, 437)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.Parent = Me.btnSubmit
        Me.btnSubmit.Size = New System.Drawing.Size(935, 54)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "SUBMIT"
        '
        'txtParkingCharge
        '
        Me.txtParkingCharge.BorderColor = System.Drawing.Color.Transparent
        Me.txtParkingCharge.BorderThickness = 0
        Me.txtParkingCharge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParkingCharge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtParkingCharge.DefaultText = ""
        Me.txtParkingCharge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtParkingCharge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtParkingCharge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtParkingCharge.DisabledState.Parent = Me.txtParkingCharge
        Me.txtParkingCharge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtParkingCharge.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtParkingCharge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtParkingCharge.FocusedState.Parent = Me.txtParkingCharge
        Me.txtParkingCharge.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParkingCharge.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtParkingCharge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtParkingCharge.HoverState.Parent = Me.txtParkingCharge
        Me.txtParkingCharge.Location = New System.Drawing.Point(37, 343)
        Me.txtParkingCharge.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtParkingCharge.Name = "txtParkingCharge"
        Me.txtParkingCharge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtParkingCharge.PlaceholderText = ""
        Me.txtParkingCharge.SelectedText = ""
        Me.txtParkingCharge.ShadowDecoration.Color = System.Drawing.Color.MidnightBlue
        Me.txtParkingCharge.ShadowDecoration.Depth = 255
        Me.txtParkingCharge.ShadowDecoration.Enabled = True
        Me.txtParkingCharge.ShadowDecoration.Parent = Me.txtParkingCharge
        Me.txtParkingCharge.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.txtParkingCharge.Size = New System.Drawing.Size(935, 52)
        Me.txtParkingCharge.TabIndex = 4
        '
        'txtVehicleLimit
        '
        Me.txtVehicleLimit.BorderColor = System.Drawing.Color.Transparent
        Me.txtVehicleLimit.BorderThickness = 0
        Me.txtVehicleLimit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVehicleLimit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVehicleLimit.DefaultText = ""
        Me.txtVehicleLimit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVehicleLimit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVehicleLimit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVehicleLimit.DisabledState.Parent = Me.txtVehicleLimit
        Me.txtVehicleLimit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVehicleLimit.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtVehicleLimit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVehicleLimit.FocusedState.Parent = Me.txtVehicleLimit
        Me.txtVehicleLimit.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicleLimit.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtVehicleLimit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVehicleLimit.HoverState.Parent = Me.txtVehicleLimit
        Me.txtVehicleLimit.Location = New System.Drawing.Point(37, 234)
        Me.txtVehicleLimit.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtVehicleLimit.Name = "txtVehicleLimit"
        Me.txtVehicleLimit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVehicleLimit.PlaceholderText = ""
        Me.txtVehicleLimit.SelectedText = ""
        Me.txtVehicleLimit.ShadowDecoration.Color = System.Drawing.Color.MidnightBlue
        Me.txtVehicleLimit.ShadowDecoration.Depth = 255
        Me.txtVehicleLimit.ShadowDecoration.Enabled = True
        Me.txtVehicleLimit.ShadowDecoration.Parent = Me.txtVehicleLimit
        Me.txtVehicleLimit.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.txtVehicleLimit.Size = New System.Drawing.Size(935, 52)
        Me.txtVehicleLimit.TabIndex = 4
        '
        'txtVehicleType
        '
        Me.txtVehicleType.BorderColor = System.Drawing.Color.Transparent
        Me.txtVehicleType.BorderThickness = 0
        Me.txtVehicleType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVehicleType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVehicleType.DefaultText = ""
        Me.txtVehicleType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVehicleType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVehicleType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVehicleType.DisabledState.Parent = Me.txtVehicleType
        Me.txtVehicleType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVehicleType.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtVehicleType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVehicleType.FocusedState.Parent = Me.txtVehicleType
        Me.txtVehicleType.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicleType.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtVehicleType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVehicleType.HoverState.Parent = Me.txtVehicleType
        Me.txtVehicleType.Location = New System.Drawing.Point(526, 125)
        Me.txtVehicleType.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtVehicleType.Name = "txtVehicleType"
        Me.txtVehicleType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVehicleType.PlaceholderText = ""
        Me.txtVehicleType.SelectedText = ""
        Me.txtVehicleType.ShadowDecoration.Color = System.Drawing.Color.MidnightBlue
        Me.txtVehicleType.ShadowDecoration.Depth = 255
        Me.txtVehicleType.ShadowDecoration.Enabled = True
        Me.txtVehicleType.ShadowDecoration.Parent = Me.txtVehicleType
        Me.txtVehicleType.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.txtVehicleType.Size = New System.Drawing.Size(438, 52)
        Me.txtVehicleType.TabIndex = 4
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.AutoSizeHeightOnly = True
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(37, 292)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(346, 41)
        Me.Guna2HtmlLabel5.TabIndex = 3
        Me.Guna2HtmlLabel5.Text = "PARKING CHARGE"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.AutoSizeHeightOnly = True
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(37, 183)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(346, 41)
        Me.Guna2HtmlLabel4.TabIndex = 3
        Me.Guna2HtmlLabel4.Text = "VEHICLE LIMIT"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.AutoSize = False
        Me.Guna2HtmlLabel8.AutoSizeHeightOnly = True
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(526, 74)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(346, 41)
        Me.Guna2HtmlLabel8.TabIndex = 3
        Me.Guna2HtmlLabel8.Text = "VEHICLE TYPE"
        Me.Guna2HtmlLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.AutoSizeHeightOnly = True
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(37, 74)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(346, 41)
        Me.Guna2HtmlLabel2.TabIndex = 3
        Me.Guna2HtmlLabel2.Text = "PARKING AREA NUMBER"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.AutoSizeHeightOnly = True
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(37, 19)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(561, 47)
        Me.Guna2HtmlLabel1.TabIndex = 2
        Me.Guna2HtmlLabel1.Text = "ADD CATEGORY"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel2.BorderRadius = 15
        Me.Guna2Panel2.BorderThickness = 2
        Me.Guna2Panel2.Controls.Add(Me.dgvDetails)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel2.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel2.Location = New System.Drawing.Point(1069, 34)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.BorderRadius = 0
        Me.Guna2Panel2.ShadowDecoration.Color = System.Drawing.SystemColors.Control
        Me.Guna2Panel2.ShadowDecoration.Depth = 250
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel2.Size = New System.Drawing.Size(456, 525)
        Me.Guna2Panel2.TabIndex = 5
        '
        'dgvDetails
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetails.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetails.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetails.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetails.EnableHeadersVisualStyles = False
        Me.dgvDetails.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetails.Location = New System.Drawing.Point(23, 74)
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.RowHeadersVisible = False
        Me.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetails.Size = New System.Drawing.Size(413, 428)
        Me.dgvDetails.TabIndex = 4
        Me.dgvDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDetails.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDetails.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDetails.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDetails.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvDetails.ThemeStyle.ReadOnly = False
        Me.dgvDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDetails.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvDetails.ThemeStyle.RowsStyle.Height = 22
        Me.dgvDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.AutoSizeHeightOnly = True
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(23, 19)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(271, 47)
        Me.Guna2HtmlLabel6.TabIndex = 3
        Me.Guna2HtmlLabel6.Text = "DETAILS"
        Me.Guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel3.BorderRadius = 15
        Me.Guna2Panel3.BorderThickness = 2
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel3.Controls.Add(Me.cbSearch)
        Me.Guna2Panel3.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel3.Controls.Add(Me.txtSearch)
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel3.Controls.Add(Me.btnCancelEdit)
        Me.Guna2Panel3.Controls.Add(Me.btnUpdate)
        Me.Guna2Panel3.Controls.Add(Me.btnDelete)
        Me.Guna2Panel3.Controls.Add(Me.btnDeactivate)
        Me.Guna2Panel3.Controls.Add(Me.dgvCategory)
        Me.Guna2Panel3.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel3.Location = New System.Drawing.Point(43, 586)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.BorderRadius = 0
        Me.Guna2Panel3.ShadowDecoration.Color = System.Drawing.SystemColors.Control
        Me.Guna2Panel3.ShadowDecoration.Depth = 250
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel3.Size = New System.Drawing.Size(1482, 460)
        Me.Guna2Panel3.TabIndex = 4
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.AutoSizeHeightOnly = True
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(19, 13)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(561, 47)
        Me.Guna2HtmlLabel3.TabIndex = 10
        Me.Guna2HtmlLabel3.Text = "MANAGE CATEGORY"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbSearch
        '
        Me.cbSearch.BackColor = System.Drawing.Color.Transparent
        Me.cbSearch.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearch.FocusedColor = System.Drawing.Color.Empty
        Me.cbSearch.FocusedState.Parent = Me.cbSearch
        Me.cbSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbSearch.FormattingEnabled = True
        Me.cbSearch.HoverState.Parent = Me.cbSearch
        Me.cbSearch.ItemHeight = 50
        Me.cbSearch.ItemsAppearance.Parent = Me.cbSearch
        Me.cbSearch.Location = New System.Drawing.Point(1141, 129)
        Me.cbSearch.Name = "cbSearch"
        Me.cbSearch.ShadowDecoration.Parent = Me.cbSearch
        Me.cbSearch.Size = New System.Drawing.Size(312, 56)
        Me.cbSearch.TabIndex = 5
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BorderThickness = 0
        Me.Guna2TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(1141, 133)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Color = System.Drawing.Color.MidnightBlue
        Me.Guna2TextBox1.ShadowDecoration.Depth = 255
        Me.Guna2TextBox1.ShadowDecoration.Enabled = True
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Guna2TextBox1.Size = New System.Drawing.Size(312, 52)
        Me.Guna2TextBox1.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.Transparent
        Me.txtSearch.BorderThickness = 0
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(1141, 66)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = ""
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Color = System.Drawing.Color.MidnightBlue
        Me.txtSearch.ShadowDecoration.Depth = 255
        Me.txtSearch.ShadowDecoration.Enabled = True
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.txtSearch.Size = New System.Drawing.Size(303, 52)
        Me.txtSearch.TabIndex = 9
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.AutoSize = False
        Me.Guna2HtmlLabel7.AutoSizeHeightOnly = True
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(1141, 17)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(312, 41)
        Me.Guna2HtmlLabel7.TabIndex = 8
        Me.Guna2HtmlLabel7.Text = "SEARCH"
        Me.Guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnUpdate
        '
        Me.btnUpdate.BorderRadius = 8
        Me.btnUpdate.CheckedState.Parent = Me.btnUpdate
        Me.btnUpdate.CustomImages.Parent = Me.btnUpdate
        Me.btnUpdate.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.Parent = Me.btnUpdate
        Me.btnUpdate.Location = New System.Drawing.Point(1141, 316)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(321, 54)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "UPDATE"
        '
        'btnDelete
        '
        Me.btnDelete.BorderRadius = 8
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnDelete.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(1141, 256)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(321, 54)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "DELETE"
        '
        'btnDeactivate
        '
        Me.btnDeactivate.BorderRadius = 8
        Me.btnDeactivate.CheckedState.Parent = Me.btnDeactivate
        Me.btnDeactivate.CustomImages.Parent = Me.btnDeactivate
        Me.btnDeactivate.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnDeactivate.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeactivate.ForeColor = System.Drawing.Color.White
        Me.btnDeactivate.HoverState.Parent = Me.btnDeactivate
        Me.btnDeactivate.Location = New System.Drawing.Point(1141, 196)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.ShadowDecoration.Parent = Me.btnDeactivate
        Me.btnDeactivate.Size = New System.Drawing.Size(321, 54)
        Me.btnDeactivate.TabIndex = 7
        Me.btnDeactivate.Text = "DEACTIVATE"
        '
        'dgvCategory
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvCategory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCategory.BackgroundColor = System.Drawing.Color.White
        Me.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCategory.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCategory.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCategory.EnableHeadersVisualStyles = False
        Me.dgvCategory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCategory.Location = New System.Drawing.Point(19, 75)
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.RowHeadersVisible = False
        Me.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategory.Size = New System.Drawing.Size(1101, 382)
        Me.dgvCategory.TabIndex = 5
        Me.dgvCategory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCategory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCategory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCategory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCategory.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvCategory.ThemeStyle.ReadOnly = False
        Me.dgvCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCategory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCategory.ThemeStyle.RowsStyle.Height = 22
        Me.dgvCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.BorderRadius = 8
        Me.btnCancelEdit.CheckedState.Parent = Me.btnCancelEdit
        Me.btnCancelEdit.CustomImages.Parent = Me.btnCancelEdit
        Me.btnCancelEdit.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnCancelEdit.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelEdit.ForeColor = System.Drawing.Color.White
        Me.btnCancelEdit.HoverState.Parent = Me.btnCancelEdit
        Me.btnCancelEdit.Location = New System.Drawing.Point(1141, 376)
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.ShadowDecoration.Parent = Me.btnCancelEdit
        Me.btnCancelEdit.Size = New System.Drawing.Size(321, 54)
        Me.btnCancelEdit.TabIndex = 7
        Me.btnCancelEdit.Text = "CANCEL UPDATE"
        '
        'CategoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1568, 1080)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CategoryForm"
        Me.Text = "Category"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbSearch As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtParkingCharge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtVehicleLimit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvDetails As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeactivate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtVehicleType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgvCategory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtParkingAreaNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCancelEdit As Guna.UI2.WinForms.Guna2Button
End Class
