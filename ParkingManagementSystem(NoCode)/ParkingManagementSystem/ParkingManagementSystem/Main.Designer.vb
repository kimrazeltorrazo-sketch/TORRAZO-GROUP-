<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLogOut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAlertHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnParkingHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnManageSlots = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.panelControl = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTimeAndDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox4 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.panelMainContent = New Guna.UI2.WinForms.Guna2Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnCustomer = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.panelControl.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Guna2Panel1.Controls.Add(Me.btnLogOut)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(350, 1080)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.ParkingManagementSystem.My.Resources.Resources.car_side_solid_full
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(47, 40)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(256, 48)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 5
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(15, 94)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(309, 27)
        Me.Guna2HtmlLabel5.TabIndex = 4
        Me.Guna2HtmlLabel5.Text = "Parking Management System"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Guna2Panel2.Controls.Add(Me.btnCustomer)
        Me.Guna2Panel2.Controls.Add(Me.btnAlertHistory)
        Me.Guna2Panel2.Controls.Add(Me.btnParkingHistory)
        Me.Guna2Panel2.Controls.Add(Me.btnManageSlots)
        Me.Guna2Panel2.Controls.Add(Me.btnDashboard)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 181)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(350, 457)
        Me.Guna2Panel2.TabIndex = 6
        '
        'btnLogOut
        '
        Me.btnLogOut.CheckedState.Parent = Me.btnLogOut
        Me.btnLogOut.CustomImages.Parent = Me.btnLogOut
        Me.btnLogOut.FillColor = System.Drawing.Color.CadetBlue
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnLogOut.HoverState.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnLogOut.HoverState.Parent = Me.btnLogOut
        Me.btnLogOut.Location = New System.Drawing.Point(-6, 557)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.ShadowDecoration.Parent = Me.btnLogOut
        Me.btnLogOut.Size = New System.Drawing.Size(356, 73)
        Me.btnLogOut.TabIndex = 7
        Me.btnLogOut.Text = "LOG OUT"
        '
        'btnAlertHistory
        '
        Me.btnAlertHistory.CheckedState.Parent = Me.btnAlertHistory
        Me.btnAlertHistory.CustomImages.Parent = Me.btnAlertHistory
        Me.btnAlertHistory.FillColor = System.Drawing.Color.CadetBlue
        Me.btnAlertHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlertHistory.ForeColor = System.Drawing.Color.White
        Me.btnAlertHistory.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnAlertHistory.HoverState.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnAlertHistory.HoverState.Parent = Me.btnAlertHistory
        Me.btnAlertHistory.Location = New System.Drawing.Point(0, 226)
        Me.btnAlertHistory.Name = "btnAlertHistory"
        Me.btnAlertHistory.ShadowDecoration.Parent = Me.btnAlertHistory
        Me.btnAlertHistory.Size = New System.Drawing.Size(356, 73)
        Me.btnAlertHistory.TabIndex = 7
        Me.btnAlertHistory.Text = "ALERT HISTORY"
        '
        'btnParkingHistory
        '
        Me.btnParkingHistory.CheckedState.Parent = Me.btnParkingHistory
        Me.btnParkingHistory.CustomImages.Parent = Me.btnParkingHistory
        Me.btnParkingHistory.FillColor = System.Drawing.Color.CadetBlue
        Me.btnParkingHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParkingHistory.ForeColor = System.Drawing.Color.White
        Me.btnParkingHistory.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnParkingHistory.HoverState.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnParkingHistory.HoverState.Parent = Me.btnParkingHistory
        Me.btnParkingHistory.Location = New System.Drawing.Point(0, 151)
        Me.btnParkingHistory.Name = "btnParkingHistory"
        Me.btnParkingHistory.ShadowDecoration.Parent = Me.btnParkingHistory
        Me.btnParkingHistory.Size = New System.Drawing.Size(356, 73)
        Me.btnParkingHistory.TabIndex = 7
        Me.btnParkingHistory.Text = "PARKING HISTORY"
        '
        'btnManageSlots
        '
        Me.btnManageSlots.CheckedState.Parent = Me.btnManageSlots
        Me.btnManageSlots.CustomImages.Parent = Me.btnManageSlots
        Me.btnManageSlots.FillColor = System.Drawing.Color.CadetBlue
        Me.btnManageSlots.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageSlots.ForeColor = System.Drawing.Color.White
        Me.btnManageSlots.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnManageSlots.HoverState.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnManageSlots.HoverState.Parent = Me.btnManageSlots
        Me.btnManageSlots.Location = New System.Drawing.Point(0, 76)
        Me.btnManageSlots.Name = "btnManageSlots"
        Me.btnManageSlots.ShadowDecoration.Parent = Me.btnManageSlots
        Me.btnManageSlots.Size = New System.Drawing.Size(356, 73)
        Me.btnManageSlots.TabIndex = 7
        Me.btnManageSlots.Text = "MANAGE SLOTS"
        '
        'btnDashboard
        '
        Me.btnDashboard.CheckedState.Parent = Me.btnDashboard
        Me.btnDashboard.CustomImages.Parent = Me.btnDashboard
        Me.btnDashboard.FillColor = System.Drawing.Color.CadetBlue
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnDashboard.HoverState.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnDashboard.HoverState.Parent = Me.btnDashboard
        Me.btnDashboard.Location = New System.Drawing.Point(0, 3)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.ShadowDecoration.Parent = Me.btnDashboard
        Me.btnDashboard.Size = New System.Drawing.Size(356, 71)
        Me.btnDashboard.TabIndex = 7
        Me.btnDashboard.Text = "DASHBOARD"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(179, 675)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(591, 26)
        Me.Guna2HtmlLabel2.TabIndex = 4
        Me.Guna2HtmlLabel2.Text = "Streamlining parking operations with precision, security, and efficiency."
        '
        'panelControl
        '
        Me.panelControl.BackColor = System.Drawing.SystemColors.Control
        Me.panelControl.Controls.Add(Me.lblTimeAndDate)
        Me.panelControl.Controls.Add(Me.Guna2Panel4)
        Me.panelControl.Controls.Add(Me.Guna2ControlBox3)
        Me.panelControl.Controls.Add(Me.Guna2ControlBox2)
        Me.panelControl.Location = New System.Drawing.Point(350, 0)
        Me.panelControl.Name = "panelControl"
        Me.panelControl.ShadowDecoration.Parent = Me.panelControl
        Me.panelControl.Size = New System.Drawing.Size(1570, 60)
        Me.panelControl.TabIndex = 2
        '
        'lblTimeAndDate
        '
        Me.lblTimeAndDate.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeAndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeAndDate.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblTimeAndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTimeAndDate.Location = New System.Drawing.Point(592, 12)
        Me.lblTimeAndDate.Name = "lblTimeAndDate"
        Me.lblTimeAndDate.Size = New System.Drawing.Size(3, 2)
        Me.lblTimeAndDate.TabIndex = 7
        Me.lblTimeAndDate.Text = Nothing
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel4.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel4.Controls.Add(Me.Guna2ControlBox4)
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 61)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(1570, 1016)
        Me.Guna2Panel4.TabIndex = 3
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1461, 5)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(50, 50)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2ControlBox4
        '
        Me.Guna2ControlBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox4.HoverState.Parent = Me.Guna2ControlBox4
        Me.Guna2ControlBox4.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox4.Location = New System.Drawing.Point(1517, 5)
        Me.Guna2ControlBox4.Name = "Guna2ControlBox4"
        Me.Guna2ControlBox4.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox4.ShadowDecoration.Parent = Me.Guna2ControlBox4
        Me.Guna2ControlBox4.Size = New System.Drawing.Size(50, 50)
        Me.Guna2ControlBox4.TabIndex = 0
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.HoverState.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(1461, 5)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.ShadowDecoration.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(50, 50)
        Me.Guna2ControlBox3.TabIndex = 0
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1517, 5)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(50, 50)
        Me.Guna2ControlBox2.TabIndex = 0
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(15, 94)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(309, 27)
        Me.Guna2HtmlLabel1.TabIndex = 4
        Me.Guna2HtmlLabel1.Text = "Parking Management System"
        '
        'panelMainContent
        '
        Me.panelMainContent.AutoRoundedCorners = True
        Me.panelMainContent.AutoSize = True
        Me.panelMainContent.BackColor = System.Drawing.Color.Transparent
        Me.panelMainContent.BorderRadius = 362
        Me.panelMainContent.Location = New System.Drawing.Point(350, 61)
        Me.panelMainContent.Margin = New System.Windows.Forms.Padding(5)
        Me.panelMainContent.Name = "panelMainContent"
        Me.panelMainContent.ShadowDecoration.Parent = Me.panelMainContent
        Me.panelMainContent.Size = New System.Drawing.Size(1038, 726)
        Me.panelMainContent.TabIndex = 4
        Me.panelMainContent.UseTransparentBackground = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnCustomer
        '
        Me.btnCustomer.CheckedState.Parent = Me.btnCustomer
        Me.btnCustomer.CustomImages.Parent = Me.btnCustomer
        Me.btnCustomer.FillColor = System.Drawing.Color.CadetBlue
        Me.btnCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.White
        Me.btnCustomer.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnCustomer.HoverState.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnCustomer.HoverState.Parent = Me.btnCustomer
        Me.btnCustomer.Location = New System.Drawing.Point(-6, 301)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.ShadowDecoration.Parent = Me.btnCustomer
        Me.btnCustomer.Size = New System.Drawing.Size(356, 73)
        Me.btnCustomer.TabIndex = 8
        Me.btnCustomer.Text = "REGISTER"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.panelMainContent)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.panelControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "Main"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.panelControl.ResumeLayout(False)
        Me.panelControl.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAlertHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnParkingHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnManageSlots As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelMainContent As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelControl As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox4 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimeAndDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnCustomer As Guna.UI2.WinForms.Guna2Button
End Class
