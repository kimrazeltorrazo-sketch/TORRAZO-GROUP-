<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageSlots
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
        Me.btnPrevious = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
        Me.lblAreaName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.panelAreaContent = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Guna2Panel1.Controls.Add(Me.btnPrevious)
        Me.Guna2Panel1.Controls.Add(Me.btnNext)
        Me.Guna2Panel1.Controls.Add(Me.lblAreaName)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1571, 80)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnPrevious
        '
        Me.btnPrevious.BorderRadius = 15
        Me.btnPrevious.CheckedState.Parent = Me.btnPrevious
        Me.btnPrevious.CustomImages.Parent = Me.btnPrevious
        Me.btnPrevious.FillColor = System.Drawing.Color.CadetBlue
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.HoverState.Parent = Me.btnPrevious
        Me.btnPrevious.Location = New System.Drawing.Point(14, 12)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.ShadowDecoration.Parent = Me.btnPrevious
        Me.btnPrevious.Size = New System.Drawing.Size(260, 50)
        Me.btnPrevious.TabIndex = 7
        Me.btnPrevious.Text = "PREVIOUS"
        '
        'btnNext
        '
        Me.btnNext.BorderRadius = 15
        Me.btnNext.CheckedState.Parent = Me.btnNext
        Me.btnNext.CustomImages.Parent = Me.btnNext
        Me.btnNext.FillColor = System.Drawing.Color.CadetBlue
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.HoverState.Parent = Me.btnNext
        Me.btnNext.Location = New System.Drawing.Point(1106, 12)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.ShadowDecoration.Parent = Me.btnNext
        Me.btnNext.Size = New System.Drawing.Size(260, 50)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "NEXT"
        '
        'lblAreaName
        '
        Me.lblAreaName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAreaName.BackColor = System.Drawing.Color.Transparent
        Me.lblAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaName.ForeColor = System.Drawing.Color.CadetBlue
        Me.lblAreaName.Location = New System.Drawing.Point(585, 21)
        Me.lblAreaName.Name = "lblAreaName"
        Me.lblAreaName.Size = New System.Drawing.Size(78, 31)
        Me.lblAreaName.TabIndex = 6
        Me.lblAreaName.Text = "Area 1"
        Me.lblAreaName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelAreaContent
        '
        Me.panelAreaContent.Location = New System.Drawing.Point(12, 99)
        Me.panelAreaContent.Name = "panelAreaContent"
        Me.panelAreaContent.ShadowDecoration.Parent = Me.panelAreaContent
        Me.panelAreaContent.Size = New System.Drawing.Size(1352, 603)
        Me.panelAreaContent.TabIndex = 8
        '
        'btnBack
        '
        Me.btnBack.BorderRadius = 15
        Me.btnBack.CheckedState.Parent = Me.btnBack
        Me.btnBack.CustomImages.Parent = Me.btnBack
        Me.btnBack.FillColor = System.Drawing.Color.CadetBlue
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.HoverState.Parent = Me.btnBack
        Me.btnBack.Location = New System.Drawing.Point(1155, 708)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(209, 50)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "Back"
        '
        'ManageSlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.panelAreaContent)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageSlots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageSlots"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblAreaName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents panelAreaContent As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnPrevious As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
End Class
