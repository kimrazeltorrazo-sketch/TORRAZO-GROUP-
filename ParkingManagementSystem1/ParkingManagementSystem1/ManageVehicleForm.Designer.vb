<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageVehicleForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cbSearch = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnDone = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvManageVehicles = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.dgvManageVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
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
        Me.Guna2Panel3.Controls.Add(Me.btnDone)
        Me.Guna2Panel3.Controls.Add(Me.dgvManageVehicles)
        Me.Guna2Panel3.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel3.Location = New System.Drawing.Point(43, 29)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.BorderRadius = 0
        Me.Guna2Panel3.ShadowDecoration.Color = System.Drawing.SystemColors.Control
        Me.Guna2Panel3.ShadowDecoration.Depth = 250
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel3.Size = New System.Drawing.Size(1482, 1016)
        Me.Guna2Panel3.TabIndex = 5
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
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(273, 47)
        Me.Guna2HtmlLabel3.TabIndex = 10
        Me.Guna2HtmlLabel3.Text = "MANAGE VEHICLE"
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
        Me.cbSearch.Location = New System.Drawing.Point(860, 13)
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
        Me.Guna2TextBox1.Location = New System.Drawing.Point(860, 17)
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
        Me.txtSearch.IconRight = Global.ParkingManagementSystem.My.Resources.Resources.search_24dp_0000F5_FILL0_wght400_GRAD0_opsz24
        Me.txtSearch.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.txtSearch.IconRightSize = New System.Drawing.Size(25, 25)
        Me.txtSearch.Location = New System.Drawing.Point(464, 17)
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
        Me.txtSearch.Size = New System.Drawing.Size(387, 52)
        Me.txtSearch.TabIndex = 9
        '
        'btnDone
        '
        Me.btnDone.BorderRadius = 8
        Me.btnDone.CheckedState.Parent = Me.btnDone
        Me.btnDone.CustomImages.Parent = Me.btnDone
        Me.btnDone.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnDone.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.HoverState.Parent = Me.btnDone
        Me.btnDone.Location = New System.Drawing.Point(1208, 15)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.ShadowDecoration.Parent = Me.btnDone
        Me.btnDone.Size = New System.Drawing.Size(254, 54)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "DONE"
        '
        'dgvManageVehicles
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvManageVehicles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvManageVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvManageVehicles.BackgroundColor = System.Drawing.Color.White
        Me.dgvManageVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvManageVehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvManageVehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvManageVehicles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvManageVehicles.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvManageVehicles.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvManageVehicles.EnableHeadersVisualStyles = False
        Me.dgvManageVehicles.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvManageVehicles.Location = New System.Drawing.Point(19, 90)
        Me.dgvManageVehicles.Name = "dgvManageVehicles"
        Me.dgvManageVehicles.RowHeadersVisible = False
        Me.dgvManageVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvManageVehicles.Size = New System.Drawing.Size(1431, 900)
        Me.dgvManageVehicles.TabIndex = 5
        Me.dgvManageVehicles.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvManageVehicles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvManageVehicles.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvManageVehicles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvManageVehicles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvManageVehicles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvManageVehicles.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvManageVehicles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvManageVehicles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvManageVehicles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvManageVehicles.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvManageVehicles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvManageVehicles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvManageVehicles.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvManageVehicles.ThemeStyle.ReadOnly = False
        Me.dgvManageVehicles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvManageVehicles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvManageVehicles.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvManageVehicles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvManageVehicles.ThemeStyle.RowsStyle.Height = 22
        Me.dgvManageVehicles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvManageVehicles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ManageVehicleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1568, 1080)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageVehicleForm"
        Me.Text = "ManageVehicleForm"
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.dgvManageVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cbSearch As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDone As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvManageVehicles As Guna.UI2.WinForms.Guna2DataGridView
End Class
