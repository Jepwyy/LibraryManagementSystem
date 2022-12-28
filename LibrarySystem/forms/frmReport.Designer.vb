<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dtg_report = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTotalbooks = New System.Windows.Forms.Button()
        Me.btnListBooks = New System.Windows.Forms.Button()
        Me.rdoMonthly = New System.Windows.Forms.RadioButton()
        Me.rdoWeekly = New System.Windows.Forms.RadioButton()
        Me.rdoDaily = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtp_strtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_endDate = New System.Windows.Forms.DateTimePicker()
        Me.btn_preview = New System.Windows.Forms.Button()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dtg_report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.dtg_report)
        Me.Guna2Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1138, 758)
        Me.Guna2Panel1.TabIndex = 0
        '
        'dtg_report
        '
        Me.dtg_report.AllowUserToAddRows = False
        Me.dtg_report.AllowUserToDeleteRows = False
        Me.dtg_report.AllowUserToResizeColumns = False
        Me.dtg_report.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dtg_report.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dtg_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_report.BackgroundColor = System.Drawing.Color.White
        Me.dtg_report.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_report.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_report.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_report.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dtg_report.ColumnHeadersHeight = 21
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg_report.DefaultCellStyle = DataGridViewCellStyle12
        Me.dtg_report.EnableHeadersVisualStyles = False
        Me.dtg_report.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_report.Location = New System.Drawing.Point(167, 58)
        Me.dtg_report.Name = "dtg_report"
        Me.dtg_report.ReadOnly = True
        Me.dtg_report.RowHeadersVisible = False
        Me.dtg_report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_report.Size = New System.Drawing.Size(968, 549)
        Me.dtg_report.TabIndex = 6
        Me.dtg_report.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtg_report.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtg_report.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtg_report.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtg_report.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtg_report.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtg_report.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_report.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_report.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtg_report.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtg_report.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtg_report.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtg_report.ThemeStyle.HeaderStyle.Height = 21
        Me.dtg_report.ThemeStyle.ReadOnly = True
        Me.dtg_report.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtg_report.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_report.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtg_report.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtg_report.ThemeStyle.RowsStyle.Height = 22
        Me.dtg_report.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_report.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_export)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 55)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(161, 703)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnDonate)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnTotalbooks)
        Me.GroupBox1.Controls.Add(Me.btnListBooks)
        Me.GroupBox1.Controls.Add(Me.rdoMonthly)
        Me.GroupBox1.Controls.Add(Me.rdoWeekly)
        Me.GroupBox1.Controls.Add(Me.rdoDaily)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 288)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Books"
        '
        'btnTotalbooks
        '
        Me.btnTotalbooks.Location = New System.Drawing.Point(9, 53)
        Me.btnTotalbooks.Name = "btnTotalbooks"
        Me.btnTotalbooks.Size = New System.Drawing.Size(133, 22)
        Me.btnTotalbooks.TabIndex = 3
        Me.btnTotalbooks.Text = "Total No. of Books"
        Me.btnTotalbooks.UseVisualStyleBackColor = True
        '
        'btnListBooks
        '
        Me.btnListBooks.Location = New System.Drawing.Point(9, 25)
        Me.btnListBooks.Name = "btnListBooks"
        Me.btnListBooks.Size = New System.Drawing.Size(133, 22)
        Me.btnListBooks.TabIndex = 2
        Me.btnListBooks.Text = "List of Books"
        Me.btnListBooks.UseVisualStyleBackColor = True
        '
        'rdoMonthly
        '
        Me.rdoMonthly.AutoSize = True
        Me.rdoMonthly.Location = New System.Drawing.Point(24, 250)
        Me.rdoMonthly.Name = "rdoMonthly"
        Me.rdoMonthly.Size = New System.Drawing.Size(97, 17)
        Me.rdoMonthly.TabIndex = 2
        Me.rdoMonthly.TabStop = True
        Me.rdoMonthly.Text = "Monthly Report"
        Me.rdoMonthly.UseVisualStyleBackColor = True
        '
        'rdoWeekly
        '
        Me.rdoWeekly.AutoSize = True
        Me.rdoWeekly.Location = New System.Drawing.Point(24, 227)
        Me.rdoWeekly.Name = "rdoWeekly"
        Me.rdoWeekly.Size = New System.Drawing.Size(96, 17)
        Me.rdoWeekly.TabIndex = 2
        Me.rdoWeekly.TabStop = True
        Me.rdoWeekly.Text = "Weekly Report"
        Me.rdoWeekly.UseVisualStyleBackColor = True
        '
        'rdoDaily
        '
        Me.rdoDaily.AutoSize = True
        Me.rdoDaily.Location = New System.Drawing.Point(24, 204)
        Me.rdoDaily.Name = "rdoDaily"
        Me.rdoDaily.Size = New System.Drawing.Size(83, 17)
        Me.rdoDaily.TabIndex = 2
        Me.rdoDaily.TabStop = True
        Me.rdoDaily.Text = "Daily Report"
        Me.rdoDaily.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status :"
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Borrowed", "Returned", "Overdue", "Read"})
        Me.cboStatus.Location = New System.Drawing.Point(6, 167)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(137, 21)
        Me.cboStatus.TabIndex = 0
        Me.cboStatus.Text = "Borrowed"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp_strtDate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtp_endDate)
        Me.GroupBox2.Controls.Add(Me.btn_preview)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 162)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date Filter"
        '
        'dtp_strtDate
        '
        Me.dtp_strtDate.CustomFormat = "yyyy-MM-dd"
        Me.dtp_strtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_strtDate.Location = New System.Drawing.Point(10, 41)
        Me.dtp_strtDate.Name = "dtp_strtDate"
        Me.dtp_strtDate.Size = New System.Drawing.Size(132, 20)
        Me.dtp_strtDate.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Start Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "End Date :"
        '
        'dtp_endDate
        '
        Me.dtp_endDate.CustomFormat = "yyyy-MM-dd"
        Me.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_endDate.Location = New System.Drawing.Point(10, 89)
        Me.dtp_endDate.Name = "dtp_endDate"
        Me.dtp_endDate.Size = New System.Drawing.Size(132, 20)
        Me.dtp_endDate.TabIndex = 17
        '
        'btn_preview
        '
        Me.btn_preview.Location = New System.Drawing.Point(64, 120)
        Me.btn_preview.Name = "btn_preview"
        Me.btn_preview.Size = New System.Drawing.Size(78, 28)
        Me.btn_preview.TabIndex = 15
        Me.btn_preview.Text = "Preview"
        Me.btn_preview.UseVisualStyleBackColor = True
        '
        'btn_export
        '
        Me.btn_export.Location = New System.Drawing.Point(3, 465)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(152, 23)
        Me.btn_export.TabIndex = 5
        Me.btn_export.Text = "Export"
        Me.btn_export.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 31.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1138, 55)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Books Inventory Report"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 22)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "List of Purchased Books"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDonate
        '
        Me.btnDonate.Location = New System.Drawing.Point(9, 81)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(133, 22)
        Me.btnDonate.TabIndex = 5
        Me.btnDonate.Text = "List of Donated Books"
        Me.btnDonate.UseVisualStyleBackColor = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1156, 758)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReport"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.dtg_report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dtg_report As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTotalbooks As Button
    Friend WithEvents btnListBooks As Button
    Friend WithEvents rdoMonthly As RadioButton
    Friend WithEvents rdoWeekly As RadioButton
    Friend WithEvents rdoDaily As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtp_strtDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_endDate As DateTimePicker
    Friend WithEvents btn_preview As Button
    Friend WithEvents btn_export As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDonate As Button
    Friend WithEvents Button1 As Button
End Class
