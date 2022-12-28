<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRequest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_DeleteBorrower = New System.Windows.Forms.Button()
        Me.btnBorrowerReq = New System.Windows.Forms.Button()
        Me.dtgBorrowerReq = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_DelBook = New System.Windows.Forms.Button()
        Me.btn_bbook = New System.Windows.Forms.Button()
        Me.dtgBookReq = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_delBookReq = New System.Windows.Forms.Button()
        Me.btn_readReq = New System.Windows.Forms.Button()
        Me.dtgReadReq = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2NotificationPaint1 = New Guna.UI2.WinForms.Guna2NotificationPaint(Me.components)
        Me.Guna2NotificationPaint2 = New Guna.UI2.WinForms.Guna2NotificationPaint(Me.components)
        Me.Guna2NotificationPaint3 = New Guna.UI2.WinForms.Guna2NotificationPaint(Me.components)
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgBorrowerReq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgBookReq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dtgReadReq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage3)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1120, 681)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 0
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_DeleteBorrower)
        Me.TabPage1.Controls.Add(Me.btnBorrowerReq)
        Me.TabPage1.Controls.Add(Me.dtgBorrowerReq)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(932, 673)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Register Borrower Request"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_DeleteBorrower
        '
        Me.btn_DeleteBorrower.Location = New System.Drawing.Point(684, 439)
        Me.btn_DeleteBorrower.Name = "btn_DeleteBorrower"
        Me.btn_DeleteBorrower.Size = New System.Drawing.Size(116, 39)
        Me.btn_DeleteBorrower.TabIndex = 4
        Me.btn_DeleteBorrower.Text = "Decline Request"
        Me.btn_DeleteBorrower.UseVisualStyleBackColor = True
        '
        'btnBorrowerReq
        '
        Me.btnBorrowerReq.Location = New System.Drawing.Point(806, 439)
        Me.btnBorrowerReq.Name = "btnBorrowerReq"
        Me.btnBorrowerReq.Size = New System.Drawing.Size(116, 39)
        Me.btnBorrowerReq.TabIndex = 3
        Me.btnBorrowerReq.Text = "Accept Request"
        Me.btnBorrowerReq.UseVisualStyleBackColor = True
        '
        'dtgBorrowerReq
        '
        Me.dtgBorrowerReq.AllowUserToAddRows = False
        Me.dtgBorrowerReq.AllowUserToDeleteRows = False
        Me.dtgBorrowerReq.AllowUserToResizeColumns = False
        Me.dtgBorrowerReq.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dtgBorrowerReq.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgBorrowerReq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgBorrowerReq.BackgroundColor = System.Drawing.Color.White
        Me.dtgBorrowerReq.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgBorrowerReq.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgBorrowerReq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgBorrowerReq.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgBorrowerReq.ColumnHeadersHeight = 21
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgBorrowerReq.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgBorrowerReq.EnableHeadersVisualStyles = False
        Me.dtgBorrowerReq.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBorrowerReq.Location = New System.Drawing.Point(11, 194)
        Me.dtgBorrowerReq.Name = "dtgBorrowerReq"
        Me.dtgBorrowerReq.ReadOnly = True
        Me.dtgBorrowerReq.RowHeadersVisible = False
        Me.dtgBorrowerReq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgBorrowerReq.Size = New System.Drawing.Size(911, 239)
        Me.dtgBorrowerReq.TabIndex = 2
        Me.dtgBorrowerReq.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgBorrowerReq.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtgBorrowerReq.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtgBorrowerReq.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtgBorrowerReq.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtgBorrowerReq.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtgBorrowerReq.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBorrowerReq.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBorrowerReq.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgBorrowerReq.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgBorrowerReq.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtgBorrowerReq.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtgBorrowerReq.ThemeStyle.HeaderStyle.Height = 21
        Me.dtgBorrowerReq.ThemeStyle.ReadOnly = True
        Me.dtgBorrowerReq.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgBorrowerReq.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgBorrowerReq.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgBorrowerReq.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtgBorrowerReq.ThemeStyle.RowsStyle.Height = 22
        Me.dtgBorrowerReq.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBorrowerReq.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_DelBook)
        Me.TabPage2.Controls.Add(Me.btn_bbook)
        Me.TabPage2.Controls.Add(Me.dtgBookReq)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(932, 673)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Borrow Book Request"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_DelBook
        '
        Me.btn_DelBook.Location = New System.Drawing.Point(684, 439)
        Me.btn_DelBook.Name = "btn_DelBook"
        Me.btn_DelBook.Size = New System.Drawing.Size(116, 39)
        Me.btn_DelBook.TabIndex = 5
        Me.btn_DelBook.Text = "Decline Request"
        Me.btn_DelBook.UseVisualStyleBackColor = True
        '
        'btn_bbook
        '
        Me.btn_bbook.Location = New System.Drawing.Point(806, 439)
        Me.btn_bbook.Name = "btn_bbook"
        Me.btn_bbook.Size = New System.Drawing.Size(116, 39)
        Me.btn_bbook.TabIndex = 3
        Me.btn_bbook.Text = "Accept Request"
        Me.btn_bbook.UseVisualStyleBackColor = True
        '
        'dtgBookReq
        '
        Me.dtgBookReq.AllowUserToAddRows = False
        Me.dtgBookReq.AllowUserToDeleteRows = False
        Me.dtgBookReq.AllowUserToResizeColumns = False
        Me.dtgBookReq.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dtgBookReq.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgBookReq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgBookReq.BackgroundColor = System.Drawing.Color.White
        Me.dtgBookReq.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgBookReq.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgBookReq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgBookReq.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgBookReq.ColumnHeadersHeight = 21
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgBookReq.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtgBookReq.EnableHeadersVisualStyles = False
        Me.dtgBookReq.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBookReq.Location = New System.Drawing.Point(11, 194)
        Me.dtgBookReq.Name = "dtgBookReq"
        Me.dtgBookReq.ReadOnly = True
        Me.dtgBookReq.RowHeadersVisible = False
        Me.dtgBookReq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgBookReq.Size = New System.Drawing.Size(911, 239)
        Me.dtgBookReq.TabIndex = 2
        Me.dtgBookReq.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgBookReq.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtgBookReq.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtgBookReq.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtgBookReq.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtgBookReq.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtgBookReq.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBookReq.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBookReq.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgBookReq.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgBookReq.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtgBookReq.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtgBookReq.ThemeStyle.HeaderStyle.Height = 21
        Me.dtgBookReq.ThemeStyle.ReadOnly = True
        Me.dtgBookReq.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgBookReq.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgBookReq.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgBookReq.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtgBookReq.ThemeStyle.RowsStyle.Height = 22
        Me.dtgBookReq.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBookReq.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_delBookReq)
        Me.TabPage3.Controls.Add(Me.btn_readReq)
        Me.TabPage3.Controls.Add(Me.dtgReadReq)
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(932, 673)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Read Book Request"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_delBookReq
        '
        Me.btn_delBookReq.Location = New System.Drawing.Point(683, 362)
        Me.btn_delBookReq.Name = "btn_delBookReq"
        Me.btn_delBookReq.Size = New System.Drawing.Size(116, 39)
        Me.btn_delBookReq.TabIndex = 5
        Me.btn_delBookReq.Text = "Decline Request"
        Me.btn_delBookReq.UseVisualStyleBackColor = True
        '
        'btn_readReq
        '
        Me.btn_readReq.Location = New System.Drawing.Point(805, 362)
        Me.btn_readReq.Name = "btn_readReq"
        Me.btn_readReq.Size = New System.Drawing.Size(116, 39)
        Me.btn_readReq.TabIndex = 1
        Me.btn_readReq.Text = "Accept Request"
        Me.btn_readReq.UseVisualStyleBackColor = True
        '
        'dtgReadReq
        '
        Me.dtgReadReq.AllowUserToAddRows = False
        Me.dtgReadReq.AllowUserToDeleteRows = False
        Me.dtgReadReq.AllowUserToResizeColumns = False
        Me.dtgReadReq.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dtgReadReq.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dtgReadReq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgReadReq.BackgroundColor = System.Drawing.Color.White
        Me.dtgReadReq.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgReadReq.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgReadReq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgReadReq.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgReadReq.ColumnHeadersHeight = 21
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgReadReq.DefaultCellStyle = DataGridViewCellStyle9
        Me.dtgReadReq.EnableHeadersVisualStyles = False
        Me.dtgReadReq.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgReadReq.Location = New System.Drawing.Point(10, 117)
        Me.dtgReadReq.Name = "dtgReadReq"
        Me.dtgReadReq.ReadOnly = True
        Me.dtgReadReq.RowHeadersVisible = False
        Me.dtgReadReq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgReadReq.Size = New System.Drawing.Size(911, 239)
        Me.dtgReadReq.TabIndex = 0
        Me.dtgReadReq.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgReadReq.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtgReadReq.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtgReadReq.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtgReadReq.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtgReadReq.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtgReadReq.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgReadReq.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgReadReq.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgReadReq.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgReadReq.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtgReadReq.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtgReadReq.ThemeStyle.HeaderStyle.Height = 21
        Me.dtgReadReq.ThemeStyle.ReadOnly = True
        Me.dtgReadReq.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgReadReq.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgReadReq.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtgReadReq.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtgReadReq.ThemeStyle.RowsStyle.Height = 22
        Me.dtgReadReq.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgReadReq.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2NotificationPaint1
        '
        Me.Guna2NotificationPaint1.Location = New System.Drawing.Point(7, 43)
        Me.Guna2NotificationPaint1.TargetControl = Me.Guna2TabControl1
        '
        'Guna2NotificationPaint2
        '
        Me.Guna2NotificationPaint2.Location = New System.Drawing.Point(7, 2)
        Me.Guna2NotificationPaint2.TargetControl = Me.Guna2TabControl1
        '
        'Guna2NotificationPaint3
        '
        Me.Guna2NotificationPaint3.Location = New System.Drawing.Point(7, 83)
        Me.Guna2NotificationPaint3.TargetControl = Me.Guna2TabControl1
        '
        'frmRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRequest"
        Me.Text = "frmRequest"
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dtgBorrowerReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtgBookReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dtgReadReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dtgReadReq As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btn_readReq As Button
    Friend WithEvents btnBorrowerReq As Button
    Friend WithEvents dtgBorrowerReq As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btn_bbook As Button
    Friend WithEvents dtgBookReq As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2NotificationPaint1 As Guna.UI2.WinForms.Guna2NotificationPaint
    Friend WithEvents Guna2NotificationPaint2 As Guna.UI2.WinForms.Guna2NotificationPaint
    Friend WithEvents Guna2NotificationPaint3 As Guna.UI2.WinForms.Guna2NotificationPaint
    Friend WithEvents btn_DeleteBorrower As Button
    Friend WithEvents btn_DelBook As Button
    Friend WithEvents btn_delBookReq As Button
End Class
