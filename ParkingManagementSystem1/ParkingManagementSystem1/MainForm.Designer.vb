<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLogOut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAccountSetting = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVehicleEntry = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCategory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashBoard = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.panelMainContent = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Panel1.Controls.Add(Me.btnLogOut)
        Me.Guna2Panel1.Controls.Add(Me.btnAccountSetting)
        Me.Guna2Panel1.Controls.Add(Me.btnReport)
        Me.Guna2Panel1.Controls.Add(Me.btnVehicleEntry)
        Me.Guna2Panel1.Controls.Add(Me.btnCategory)
        Me.Guna2Panel1.Controls.Add(Me.btnDashBoard)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(350, 1080)
        Me.Guna2Panel1.TabIndex = 2
        '
        'btnLogOut
        '
        Me.btnLogOut.CheckedState.Parent = Me.btnLogOut
        Me.btnLogOut.CustomImages.Parent = Me.btnLogOut
        Me.btnLogOut.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnLogOut.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.HoverState.Parent = Me.btnLogOut
        Me.btnLogOut.Location = New System.Drawing.Point(0, 459)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.ShadowDecoration.Color = System.Drawing.SystemColors.Control
        Me.btnLogOut.ShadowDecoration.Depth = 255
        Me.btnLogOut.ShadowDecoration.Enabled = True
        Me.btnLogOut.ShadowDecoration.Parent = Me.btnLogOut
        Me.btnLogOut.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btnLogOut.Size = New System.Drawing.Size(350, 54)
        Me.btnLogOut.TabIndex = 5
        Me.btnLogOut.Text = "LOGOUT"
        '
        'btnAccountSetting
        '
        Me.btnAccountSetting.CheckedState.Parent = Me.btnAccountSetting
        Me.btnAccountSetting.CustomImages.Parent = Me.btnAccountSetting
        Me.btnAccountSetting.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnAccountSetting.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountSetting.ForeColor = System.Drawing.Color.White
        Me.btnAccountSetting.HoverState.Parent = Me.btnAccountSetting
        Me.btnAccountSetting.Location = New System.Drawing.Point(0, 399)
        Me.btnAccountSetting.Name = "btnAccountSetting"
        Me.btnAccountSetting.ShadowDecoration.Color = System.Drawing.SystemColors.Control
        Me.btnAccountSetting.ShadowDecoration.Depth = 255
        Me.btnAccountSetting.ShadowDecoration.Enabled = True
        Me.btnAccountSetting.ShadowDecoration.Parent = Me.btnAccountSetting
        Me.btnAccountSetting.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btnAccountSetting.Size = New System.Drawing.Size(350, 54)
        Me.btnAccountSetting.TabIndex = 5
        Me.btnAccountSetting.Text = "ACCOUNT SETTINGS"
        '
        'btnReport
        '
        Me.btnReport.CheckedState.Parent = Me.btnReport
        Me.btnReport.CustomImages.Parent = Me.btnReport
        Me.btnReport.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnReport.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.HoverState.Parent = Me.btnReport
        Me.btnReport.Location = New System.Drawing.Point(0, 339)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.ShadowDecoration.Color = System.Drawing.SystemColors.Control
        Me.btnReport.ShadowDecoration.Depth = 255
        Me.btnReport.ShadowDecoration.Enabled = True
        Me.btnReport.ShadowDecoration.Parent = Me.btnReport
        Me.btnReport.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btnReport.Size = New System.Drawing.Size(350, 54)
        Me.btnReport.TabIndex = 5
        Me.btnReport.Text = "REPORT"
        '
        'btnVehicleEntry
        '
        Me.btnVehicleEntry.CheckedState.Parent = Me.btnVehicleEntry
        Me.btnVehicleEntry.CustomImages.Parent = Me.btnVehicleEntry
        Me.btnVehicleEntry.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnVehicleEntry.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehicleEntry.ForeColor = System.Drawing.Color.White
        Me.btnVehicleEntry.HoverState.Parent = Me.btnVehicleEntry
        Me.btnVehicleEntry.Location = New System.Drawing.Point(0, 272)
        Me.btnVehicleEntry.Name = "btnVehicleEntry"
        Me.btnVehicleEntry.ShadowDecoration.Color = System.Drawing.SystemColors.Control
        Me.btnVehicleEntry.ShadowDecoration.Depth = 255
        Me.btnVehicleEntry.ShadowDecoration.Enabled = True
        Me.btnVehicleEntry.ShadowDecoration.Parent = Me.btnVehicleEntry
        Me.btnVehicleEntry.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btnVehicleEntry.Size = New System.Drawing.Size(350, 54)
        Me.btnVehicleEntry.TabIndex = 5
        Me.btnVehicleEntry.Text = "VEHICLE ENTRY"
        '
        'btnCategory
        '
        Me.btnCategory.CheckedState.Parent = Me.btnCategory
        Me.btnCategory.CustomImages.Parent = Me.btnCategory
        Me.btnCategory.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnCategory.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategory.ForeColor = System.Drawing.Color.White
        Me.btnCategory.HoverState.Parent = Me.btnCategory
        Me.btnCategory.Location = New System.Drawing.Point(0, 212)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.ShadowDecoration.Color = System.Drawing.SystemColors.Control
        Me.btnCategory.ShadowDecoration.Depth = 255
        Me.btnCategory.ShadowDecoration.Enabled = True
        Me.btnCategory.ShadowDecoration.Parent = Me.btnCategory
        Me.btnCategory.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btnCategory.Size = New System.Drawing.Size(350, 54)
        Me.btnCategory.TabIndex = 5
        Me.btnCategory.Text = "CATEGORY"
        '
        'btnDashBoard
        '
        Me.btnDashBoard.CheckedState.Parent = Me.btnDashBoard
        Me.btnDashBoard.CustomImages.Parent = Me.btnDashBoard
        Me.btnDashBoard.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnDashBoard.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashBoard.ForeColor = System.Drawing.Color.White
        Me.btnDashBoard.HoverState.Parent = Me.btnDashBoard
        Me.btnDashBoard.Location = New System.Drawing.Point(0, 152)
        Me.btnDashBoard.Name = "btnDashBoard"
        Me.btnDashBoard.ShadowDecoration.Color = System.Drawing.SystemColors.Control
        Me.btnDashBoard.ShadowDecoration.Depth = 255
        Me.btnDashBoard.ShadowDecoration.Enabled = True
        Me.btnDashBoard.ShadowDecoration.Parent = Me.btnDashBoard
        Me.btnDashBoard.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btnDashBoard.Size = New System.Drawing.Size(350, 54)
        Me.btnDashBoard.TabIndex = 5
        Me.btnDashBoard.Text = "DASHBOARD"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.AutoSizeHeightOnly = True
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(25, 33)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(301, 75)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "PARKING MANAGEMENT SYSTEM"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'panelMainContent
        '
        Me.panelMainContent.BackColor = System.Drawing.SystemColors.Control
        Me.panelMainContent.Location = New System.Drawing.Point(350, -1)
        Me.panelMainContent.Name = "panelMainContent"
        Me.panelMainContent.ShadowDecoration.Parent = Me.panelMainContent
        Me.panelMainContent.Size = New System.Drawing.Size(1568, 1080)
        Me.panelMainContent.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.panelMainContent)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents panelMainContent As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnDashBoard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAccountSetting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVehicleEntry As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCategory As Guna.UI2.WinForms.Guna2Button
End Class
