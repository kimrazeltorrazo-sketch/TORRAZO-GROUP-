<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlotInformation
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
        Me.Guna2Panel10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAreaNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTimeIn = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTimeOut = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRegistrationNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCarMakerModel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblBodyType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPrimaryColor = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSecondaryColor = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnEnterVehicle = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExitVehicle = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel10.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Guna2Panel10.Size = New System.Drawing.Size(701, 60)
        Me.Guna2Panel10.TabIndex = 12
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(320, 10)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(70, 31)
        Me.Guna2HtmlLabel2.TabIndex = 6
        Me.Guna2HtmlLabel2.Text = "Slot 1 "
        '
        'lblAreaNumber
        '
        Me.lblAreaNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblAreaNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAreaNumber.Location = New System.Drawing.Point(12, 90)
        Me.lblAreaNumber.Name = "lblAreaNumber"
        Me.lblAreaNumber.Size = New System.Drawing.Size(122, 26)
        Me.lblAreaNumber.TabIndex = 13
        Me.lblAreaNumber.Text = "Area Number:"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStatus.Location = New System.Drawing.Point(12, 134)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(58, 26)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "Status:"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.CadetBlue
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(12, 181)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(186, 27)
        Me.Guna2HtmlLabel3.TabIndex = 14
        Me.Guna2HtmlLabel3.Text = "Vehicle Information"
        '
        'lblTimeIn
        '
        Me.lblTimeIn.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTimeIn.Location = New System.Drawing.Point(12, 225)
        Me.lblTimeIn.Name = "lblTimeIn"
        Me.lblTimeIn.Size = New System.Drawing.Size(71, 26)
        Me.lblTimeIn.TabIndex = 15
        Me.lblTimeIn.Text = "Time In:"
        '
        'lblTimeOut
        '
        Me.lblTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTimeOut.Location = New System.Drawing.Point(12, 273)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(86, 26)
        Me.lblTimeOut.TabIndex = 16
        Me.lblTimeOut.Text = "Time Out:"
        '
        'lblRegistrationNumber
        '
        Me.lblRegistrationNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistrationNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRegistrationNumber.Location = New System.Drawing.Point(12, 315)
        Me.lblRegistrationNumber.Name = "lblRegistrationNumber"
        Me.lblRegistrationNumber.Size = New System.Drawing.Size(180, 26)
        Me.lblRegistrationNumber.TabIndex = 16
        Me.lblRegistrationNumber.Text = "Registration Number:"
        '
        'lblCarMakerModel
        '
        Me.lblCarMakerModel.BackColor = System.Drawing.Color.Transparent
        Me.lblCarMakerModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarMakerModel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCarMakerModel.Location = New System.Drawing.Point(12, 356)
        Me.lblCarMakerModel.Name = "lblCarMakerModel"
        Me.lblCarMakerModel.Size = New System.Drawing.Size(152, 26)
        Me.lblCarMakerModel.TabIndex = 16
        Me.lblCarMakerModel.Text = "Car Maker Model:"
        '
        'lblBodyType
        '
        Me.lblBodyType.BackColor = System.Drawing.Color.Transparent
        Me.lblBodyType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodyType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBodyType.Location = New System.Drawing.Point(12, 401)
        Me.lblBodyType.Name = "lblBodyType"
        Me.lblBodyType.Size = New System.Drawing.Size(99, 26)
        Me.lblBodyType.TabIndex = 16
        Me.lblBodyType.Text = "Body Type:"
        '
        'lblPrimaryColor
        '
        Me.lblPrimaryColor.BackColor = System.Drawing.Color.Transparent
        Me.lblPrimaryColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimaryColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPrimaryColor.Location = New System.Drawing.Point(12, 451)
        Me.lblPrimaryColor.Name = "lblPrimaryColor"
        Me.lblPrimaryColor.Size = New System.Drawing.Size(121, 26)
        Me.lblPrimaryColor.TabIndex = 16
        Me.lblPrimaryColor.Text = "Primary Color:"
        '
        'lblSecondaryColor
        '
        Me.lblSecondaryColor.BackColor = System.Drawing.Color.Transparent
        Me.lblSecondaryColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondaryColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSecondaryColor.Location = New System.Drawing.Point(12, 499)
        Me.lblSecondaryColor.Name = "lblSecondaryColor"
        Me.lblSecondaryColor.Size = New System.Drawing.Size(149, 26)
        Me.lblSecondaryColor.TabIndex = 16
        Me.lblSecondaryColor.Text = "Secondary Color:"
        '
        'btnEnterVehicle
        '
        Me.btnEnterVehicle.BorderRadius = 15
        Me.btnEnterVehicle.CheckedState.Parent = Me.btnEnterVehicle
        Me.btnEnterVehicle.CustomImages.Parent = Me.btnEnterVehicle
        Me.btnEnterVehicle.FillColor = System.Drawing.Color.CadetBlue
        Me.btnEnterVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterVehicle.ForeColor = System.Drawing.Color.White
        Me.btnEnterVehicle.HoverState.Parent = Me.btnEnterVehicle
        Me.btnEnterVehicle.Location = New System.Drawing.Point(17, 565)
        Me.btnEnterVehicle.Name = "btnEnterVehicle"
        Me.btnEnterVehicle.ShadowDecoration.Parent = Me.btnEnterVehicle
        Me.btnEnterVehicle.Size = New System.Drawing.Size(209, 50)
        Me.btnEnterVehicle.TabIndex = 17
        Me.btnEnterVehicle.Text = "Enter Vehicle"
        '
        'btnExitVehicle
        '
        Me.btnExitVehicle.BorderRadius = 15
        Me.btnExitVehicle.CheckedState.Parent = Me.btnExitVehicle
        Me.btnExitVehicle.CustomImages.Parent = Me.btnExitVehicle
        Me.btnExitVehicle.FillColor = System.Drawing.Color.CadetBlue
        Me.btnExitVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitVehicle.ForeColor = System.Drawing.Color.White
        Me.btnExitVehicle.HoverState.Parent = Me.btnExitVehicle
        Me.btnExitVehicle.Location = New System.Drawing.Point(249, 565)
        Me.btnExitVehicle.Name = "btnExitVehicle"
        Me.btnExitVehicle.ShadowDecoration.Parent = Me.btnExitVehicle
        Me.btnExitVehicle.Size = New System.Drawing.Size(209, 50)
        Me.btnExitVehicle.TabIndex = 17
        Me.btnExitVehicle.Text = "Exit Vehicle"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 15
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.CadetBlue
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(479, 565)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(209, 50)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        '
        'SlotInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 654)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnExitVehicle)
        Me.Controls.Add(Me.btnEnterVehicle)
        Me.Controls.Add(Me.lblSecondaryColor)
        Me.Controls.Add(Me.lblPrimaryColor)
        Me.Controls.Add(Me.lblBodyType)
        Me.Controls.Add(Me.lblCarMakerModel)
        Me.Controls.Add(Me.lblRegistrationNumber)
        Me.Controls.Add(Me.lblTimeOut)
        Me.Controls.Add(Me.lblTimeIn)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblAreaNumber)
        Me.Controls.Add(Me.Guna2Panel10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SlotInformation"
        Me.Text = "SlotInformation"
        Me.Guna2Panel10.ResumeLayout(False)
        Me.Guna2Panel10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSecondaryColor As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPrimaryColor As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblBodyType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCarMakerModel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRegistrationNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTimeOut As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStatus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblAreaNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExitVehicle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEnterVehicle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTimeIn As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
