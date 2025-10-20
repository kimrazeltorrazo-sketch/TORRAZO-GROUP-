<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertHistory
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.dgvAlertHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvAlertHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'dgvAlertHistory
        '
        Me.dgvAlertHistory.AllowUserToAddRows = False
        Me.dgvAlertHistory.AllowUserToDeleteRows = False
        Me.dgvAlertHistory.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue
        Me.dgvAlertHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAlertHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlertHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvAlertHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAlertHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAlertHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAlertHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAlertHistory.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAlertHistory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAlertHistory.EnableHeadersVisualStyles = False
        Me.dgvAlertHistory.GridColor = System.Drawing.Color.CadetBlue
        Me.dgvAlertHistory.Location = New System.Drawing.Point(35, 82)
        Me.dgvAlertHistory.Name = "dgvAlertHistory"
        Me.dgvAlertHistory.ReadOnly = True
        Me.dgvAlertHistory.RowHeadersVisible = False
        Me.dgvAlertHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlertHistory.Size = New System.Drawing.Size(1325, 685)
        Me.dgvAlertHistory.TabIndex = 1
        Me.dgvAlertHistory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvAlertHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.PowderBlue
        Me.dgvAlertHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAlertHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAlertHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAlertHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAlertHistory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvAlertHistory.ThemeStyle.GridColor = System.Drawing.Color.CadetBlue
        Me.dgvAlertHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.dgvAlertHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvAlertHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAlertHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAlertHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAlertHistory.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvAlertHistory.ThemeStyle.ReadOnly = True
        Me.dgvAlertHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAlertHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAlertHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvAlertHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvAlertHistory.ThemeStyle.RowsStyle.Height = 22
        Me.dgvAlertHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAlertHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.btnBack.Location = New System.Drawing.Point(1142, 19)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.ShadowDecoration.Parent = Me.btnBack
        Me.btnBack.Size = New System.Drawing.Size(209, 50)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Back"
        '
        'AlertHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvAlertHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AlertHistory"
        Me.Text = "AlertHsitory"
        CType(Me.dgvAlertHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents dgvAlertHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
End Class
