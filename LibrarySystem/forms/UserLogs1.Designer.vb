<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogs1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.dtg_logs = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cid = New System.Windows.Forms.TextBox()
        Me.Textlm = New System.Windows.Forms.TextBox()
        Me.txtdl = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtur = New System.Windows.Forms.TextBox()
        Me.tbld = New System.Windows.Forms.Label()
        Me.tbur = New System.Windows.Forms.Label()
        Me.txtu = New System.Windows.Forms.TextBox()
        Me.tbu = New System.Windows.Forms.Label()
        Me.txtf = New System.Windows.Forms.TextBox()
        Me.tbf = New System.Windows.Forms.Label()
        CType(Me.dtg_logs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1122, 42)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "User Logs"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_delete
        '
        Me.btn_delete.Animated = True
        Me.btn_delete.BorderRadius = 1
        Me.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_delete.FillColor = System.Drawing.Color.Red
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(751, 265)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(180, 45)
        Me.btn_delete.TabIndex = 41
        Me.btn_delete.Text = "Delete"
        '
        'btnExport
        '
        Me.btnExport.BorderRadius = 1
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.FillColor = System.Drawing.Color.ForestGreen
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(937, 265)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(180, 45)
        Me.btnExport.TabIndex = 42
        Me.btnExport.Text = "Export"
        '
        'dtg_logs
        '
        Me.dtg_logs.AllowUserToAddRows = False
        Me.dtg_logs.AllowUserToDeleteRows = False
        Me.dtg_logs.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dtg_logs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_logs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_logs.BackgroundColor = System.Drawing.Color.White
        Me.dtg_logs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_logs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_logs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_logs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtg_logs.ColumnHeadersHeight = 21
        Me.dtg_logs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg_logs.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtg_logs.EnableHeadersVisualStyles = False
        Me.dtg_logs.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_logs.Location = New System.Drawing.Point(3, 316)
        Me.dtg_logs.Name = "dtg_logs"
        Me.dtg_logs.ReadOnly = True
        Me.dtg_logs.RowHeadersVisible = False
        Me.dtg_logs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_logs.Size = New System.Drawing.Size(1114, 243)
        Me.dtg_logs.TabIndex = 40
        Me.dtg_logs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtg_logs.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtg_logs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtg_logs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtg_logs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtg_logs.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtg_logs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_logs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_logs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtg_logs.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtg_logs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtg_logs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtg_logs.ThemeStyle.HeaderStyle.Height = 21
        Me.dtg_logs.ThemeStyle.ReadOnly = True
        Me.dtg_logs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtg_logs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_logs.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtg_logs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtg_logs.ThemeStyle.RowsStyle.Height = 22
        Me.dtg_logs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_logs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Fullname"
        Me.Column1.HeaderText = "Fullname"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "User_name"
        Me.Column2.HeaderText = "Username"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "UserRole"
        Me.Column3.HeaderText = "User Role"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "LogDate"
        Me.Column4.HeaderText = "Log Date"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "LogMode"
        Me.Column5.HeaderText = "Log Mode"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.cid)
        Me.Guna2Panel1.Controls.Add(Me.Textlm)
        Me.Guna2Panel1.Controls.Add(Me.txtdl)
        Me.Guna2Panel1.Controls.Add(Me.Label12)
        Me.Guna2Panel1.Controls.Add(Me.txtur)
        Me.Guna2Panel1.Controls.Add(Me.tbld)
        Me.Guna2Panel1.Controls.Add(Me.tbur)
        Me.Guna2Panel1.Controls.Add(Me.txtu)
        Me.Guna2Panel1.Controls.Add(Me.tbu)
        Me.Guna2Panel1.Controls.Add(Me.txtf)
        Me.Guna2Panel1.Controls.Add(Me.tbf)
        Me.Guna2Panel1.Controls.Add(Me.dtg_logs)
        Me.Guna2Panel1.Controls.Add(Me.btnExport)
        Me.Guna2Panel1.Controls.Add(Me.btn_delete)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1122, 758)
        Me.Guna2Panel1.TabIndex = 0
        '
        'cid
        '
        Me.cid.Location = New System.Drawing.Point(112, 131)
        Me.cid.Name = "cid"
        Me.cid.Size = New System.Drawing.Size(128, 20)
        Me.cid.TabIndex = 82
        Me.cid.Visible = False
        '
        'Textlm
        '
        Me.Textlm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Textlm.Enabled = False
        Me.Textlm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textlm.Location = New System.Drawing.Point(870, 211)
        Me.Textlm.Name = "Textlm"
        Me.Textlm.Size = New System.Drawing.Size(239, 23)
        Me.Textlm.TabIndex = 80
        '
        'txtdl
        '
        Me.txtdl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdl.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtdl.Enabled = False
        Me.txtdl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdl.Location = New System.Drawing.Point(870, 184)
        Me.txtdl.Name = "txtdl"
        Me.txtdl.ReadOnly = True
        Me.txtdl.Size = New System.Drawing.Size(239, 23)
        Me.txtdl.TabIndex = 77
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(785, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 17)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Log Mode :"
        '
        'txtur
        '
        Me.txtur.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtur.Enabled = False
        Me.txtur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtur.Location = New System.Drawing.Point(870, 157)
        Me.txtur.Name = "txtur"
        Me.txtur.Size = New System.Drawing.Size(239, 23)
        Me.txtur.TabIndex = 76
        '
        'tbld
        '
        Me.tbld.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbld.AutoSize = True
        Me.tbld.BackColor = System.Drawing.Color.Transparent
        Me.tbld.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbld.Location = New System.Drawing.Point(790, 187)
        Me.tbld.Name = "tbld"
        Me.tbld.Size = New System.Drawing.Size(74, 17)
        Me.tbld.TabIndex = 71
        Me.tbld.Text = "Log Date :"
        '
        'tbur
        '
        Me.tbur.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbur.AutoSize = True
        Me.tbur.BackColor = System.Drawing.Color.Transparent
        Me.tbur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbur.Location = New System.Drawing.Point(785, 160)
        Me.tbur.Name = "tbur"
        Me.tbur.Size = New System.Drawing.Size(79, 17)
        Me.tbur.TabIndex = 70
        Me.tbur.Text = "User Role :"
        '
        'txtu
        '
        Me.txtu.Enabled = False
        Me.txtu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtu.Location = New System.Drawing.Point(112, 183)
        Me.txtu.Name = "txtu"
        Me.txtu.Size = New System.Drawing.Size(239, 23)
        Me.txtu.TabIndex = 73
        '
        'tbu
        '
        Me.tbu.AutoSize = True
        Me.tbu.BackColor = System.Drawing.Color.Transparent
        Me.tbu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbu.Location = New System.Drawing.Point(25, 186)
        Me.tbu.Name = "tbu"
        Me.tbu.Size = New System.Drawing.Size(81, 17)
        Me.tbu.TabIndex = 67
        Me.tbu.Text = "Username :"
        '
        'txtf
        '
        Me.txtf.Enabled = False
        Me.txtf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtf.Location = New System.Drawing.Point(112, 157)
        Me.txtf.Name = "txtf"
        Me.txtf.Size = New System.Drawing.Size(239, 23)
        Me.txtf.TabIndex = 72
        '
        'tbf
        '
        Me.tbf.AutoSize = True
        Me.tbf.BackColor = System.Drawing.Color.Transparent
        Me.tbf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbf.Location = New System.Drawing.Point(33, 160)
        Me.tbf.Name = "tbf"
        Me.tbf.Size = New System.Drawing.Size(73, 17)
        Me.tbf.TabIndex = 66
        Me.tbf.Text = "Fullname :"
        '
        'UserLogs1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 758)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserLogs1"
        Me.Text = "UserLogs1"
        CType(Me.dtg_logs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtg_logs As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cid As TextBox
    Friend WithEvents Textlm As TextBox
    Friend WithEvents txtdl As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtur As TextBox
    Friend WithEvents tbld As Label
    Friend WithEvents tbur As Label
    Friend WithEvents txtu As TextBox
    Friend WithEvents tbu As Label
    Friend WithEvents txtf As TextBox
    Friend WithEvents tbf As Label
End Class
