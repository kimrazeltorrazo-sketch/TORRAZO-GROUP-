<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlertNotifier
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblAlertMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAlertMessage
        '
        Me.lblAlertMessage.AutoSize = True
        Me.lblAlertMessage.Location = New System.Drawing.Point(104, 56)
        Me.lblAlertMessage.Name = "lblAlertMessage"
        Me.lblAlertMessage.Size = New System.Drawing.Size(39, 13)
        Me.lblAlertMessage.TabIndex = 0
        Me.lblAlertMessage.Text = "Label1"
        '
        'frmAlertNotifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 309)
        Me.Controls.Add(Me.lblAlertMessage)
        Me.Name = "frmAlertNotifier"
        Me.Text = "frmAlertNotifier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblAlertMessage As System.Windows.Forms.Label
End Class
