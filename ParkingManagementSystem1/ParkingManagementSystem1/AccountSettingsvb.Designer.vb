<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountSettingsvb
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
        Me.txtCurrentPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.txtConfirmNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.BorderColor = System.Drawing.Color.Transparent
        Me.txtCurrentPassword.BorderThickness = 0
        Me.txtCurrentPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCurrentPassword.DefaultText = ""
        Me.txtCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCurrentPassword.DisabledState.Parent = Me.txtCurrentPassword
        Me.txtCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCurrentPassword.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCurrentPassword.FocusedState.Parent = Me.txtCurrentPassword
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCurrentPassword.HoverState.Parent = Me.txtCurrentPassword
        Me.txtCurrentPassword.Location = New System.Drawing.Point(37, 125)
        Me.txtCurrentPassword.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPassword.PlaceholderText = ""
        Me.txtCurrentPassword.SelectedText = ""
        Me.txtCurrentPassword.ShadowDecoration.Color = System.Drawing.Color.MidnightBlue
        Me.txtCurrentPassword.ShadowDecoration.Depth = 255
        Me.txtCurrentPassword.ShadowDecoration.Enabled = True
        Me.txtCurrentPassword.ShadowDecoration.Parent = Me.txtCurrentPassword
        Me.txtCurrentPassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(1186, 52)
        Me.txtCurrentPassword.TabIndex = 4
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.btnSubmit)
        Me.Guna2Panel1.Controls.Add(Me.txtConfirmNewPassword)
        Me.Guna2Panel1.Controls.Add(Me.txtNewPassword)
        Me.Guna2Panel1.Controls.Add(Me.txtCurrentPassword)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Panel1.Location = New System.Drawing.Point(160, 109)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 0
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.SystemColors.Control
        Me.Guna2Panel1.ShadowDecoration.Depth = 250
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1248, 525)
        Me.Guna2Panel1.TabIndex = 5
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
        Me.btnSubmit.Size = New System.Drawing.Size(1186, 54)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "SUBMIT"
        '
        'txtConfirmNewPassword
        '
        Me.txtConfirmNewPassword.BorderColor = System.Drawing.Color.Transparent
        Me.txtConfirmNewPassword.BorderThickness = 0
        Me.txtConfirmNewPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConfirmNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmNewPassword.DefaultText = ""
        Me.txtConfirmNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmNewPassword.DisabledState.Parent = Me.txtConfirmNewPassword
        Me.txtConfirmNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmNewPassword.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtConfirmNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmNewPassword.FocusedState.Parent = Me.txtConfirmNewPassword
        Me.txtConfirmNewPassword.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmNewPassword.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtConfirmNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmNewPassword.HoverState.Parent = Me.txtConfirmNewPassword
        Me.txtConfirmNewPassword.Location = New System.Drawing.Point(37, 343)
        Me.txtConfirmNewPassword.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtConfirmNewPassword.Name = "txtConfirmNewPassword"
        Me.txtConfirmNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmNewPassword.PlaceholderText = ""
        Me.txtConfirmNewPassword.SelectedText = ""
        Me.txtConfirmNewPassword.ShadowDecoration.Color = System.Drawing.Color.MidnightBlue
        Me.txtConfirmNewPassword.ShadowDecoration.Depth = 255
        Me.txtConfirmNewPassword.ShadowDecoration.Enabled = True
        Me.txtConfirmNewPassword.ShadowDecoration.Parent = Me.txtConfirmNewPassword
        Me.txtConfirmNewPassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.txtConfirmNewPassword.Size = New System.Drawing.Size(1186, 52)
        Me.txtConfirmNewPassword.TabIndex = 4
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BorderColor = System.Drawing.Color.Transparent
        Me.txtNewPassword.BorderThickness = 0
        Me.txtNewPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.DefaultText = ""
        Me.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.DisabledState.Parent = Me.txtNewPassword
        Me.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.FocusedState.Parent = Me.txtNewPassword
        Me.txtNewPassword.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.HoverState.Parent = Me.txtNewPassword
        Me.txtNewPassword.Location = New System.Drawing.Point(37, 234)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.PlaceholderText = ""
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.ShadowDecoration.Color = System.Drawing.Color.MidnightBlue
        Me.txtNewPassword.ShadowDecoration.Depth = 255
        Me.txtNewPassword.ShadowDecoration.Enabled = True
        Me.txtNewPassword.ShadowDecoration.Parent = Me.txtNewPassword
        Me.txtNewPassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.txtNewPassword.Size = New System.Drawing.Size(1178, 52)
        Me.txtNewPassword.TabIndex = 4
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
        Me.Guna2HtmlLabel5.Text = "CONFIRM NEW PASSWORD"
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
        Me.Guna2HtmlLabel4.Text = "NEW PASSWORD"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Guna2HtmlLabel2.Text = "CURRENT PASSWORD"
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
        Me.Guna2HtmlLabel1.Text = "CHANGE YOUR PASSWORD"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AccountSettingsvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1568, 1080)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountSettingsvb"
        Me.Text = "AccountSettingsvb"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtConfirmNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCurrentPassword As Guna.UI2.WinForms.Guna2TextBox
End Class
