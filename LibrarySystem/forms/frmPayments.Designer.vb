<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayments
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPenNew = New System.Windows.Forms.Button()
        Me.btnPSave = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttothours = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txthours = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txttenderedAmount = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtTotPay = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtOverdueTime = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSearchPborrower = New System.Windows.Forms.TextBox()
        Me.dtgPenalties = New System.Windows.Forms.DataGridView()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtg_Penalties = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtrbooksSearch = New System.Windows.Forms.TextBox()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtgPenalties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtg_Penalties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1157, 758)
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
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnPenNew)
        Me.TabPage1.Controls.Add(Me.btnPSave)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(969, 750)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Overdue"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(324, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 44)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Overdues"
        '
        'btnPenNew
        '
        Me.btnPenNew.Location = New System.Drawing.Point(565, 421)
        Me.btnPenNew.Name = "btnPenNew"
        Me.btnPenNew.Size = New System.Drawing.Size(125, 31)
        Me.btnPenNew.TabIndex = 26
        Me.btnPenNew.Text = "New"
        Me.btnPenNew.UseVisualStyleBackColor = True
        '
        'btnPSave
        '
        Me.btnPSave.Location = New System.Drawing.Point(434, 421)
        Me.btnPSave.Name = "btnPSave"
        Me.btnPSave.Size = New System.Drawing.Size(125, 31)
        Me.btnPSave.TabIndex = 27
        Me.btnPSave.Text = "Save"
        Me.btnPSave.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txttothours)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.GroupBox10)
        Me.GroupBox7.Controls.Add(Me.txtChange)
        Me.GroupBox7.Controls.Add(Me.Label33)
        Me.GroupBox7.Controls.Add(Me.txttenderedAmount)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.txtTotPay)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.txtOverdueTime)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(420, 155)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(423, 253)
        Me.GroupBox7.TabIndex = 25
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Payments"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(382, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "hr(s)"
        '
        'txttothours
        '
        Me.txttothours.Enabled = False
        Me.txttothours.Location = New System.Drawing.Point(318, 35)
        Me.txttothours.Name = "txttothours"
        Me.txttothours.Size = New System.Drawing.Size(64, 25)
        Me.txttothours.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "="
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtamount)
        Me.GroupBox10.Controls.Add(Me.Label29)
        Me.GroupBox10.Controls.Add(Me.Label2)
        Me.GroupBox10.Controls.Add(Me.Label30)
        Me.GroupBox10.Controls.Add(Me.txthours)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 69)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(411, 60)
        Me.GroupBox10.TabIndex = 17
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Payment Per Hours"
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(89, 27)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtamount.Size = New System.Drawing.Size(106, 25)
        Me.txtamount.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(23, 30)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(60, 17)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Amount :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "hour"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(201, 30)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(28, 17)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "per"
        '
        'txthours
        '
        Me.txthours.Location = New System.Drawing.Point(247, 27)
        Me.txthours.Name = "txthours"
        Me.txthours.Size = New System.Drawing.Size(88, 25)
        Me.txthours.TabIndex = 10
        '
        'txtChange
        '
        Me.txtChange.Enabled = False
        Me.txtChange.Location = New System.Drawing.Point(147, 197)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(254, 25)
        Me.txtChange.TabIndex = 16
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(82, 200)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(59, 17)
        Me.Label33.TabIndex = 15
        Me.Label33.Text = "Change :"
        '
        'txttenderedAmount
        '
        Me.txttenderedAmount.Location = New System.Drawing.Point(147, 166)
        Me.txttenderedAmount.Name = "txttenderedAmount"
        Me.txttenderedAmount.Size = New System.Drawing.Size(254, 25)
        Me.txttenderedAmount.TabIndex = 14
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(21, 169)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(119, 17)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "Tendered Amount :"
        '
        'txtTotPay
        '
        Me.txtTotPay.Enabled = False
        Me.txtTotPay.Location = New System.Drawing.Point(147, 135)
        Me.txtTotPay.Name = "txtTotPay"
        Me.txtTotPay.Size = New System.Drawing.Size(254, 25)
        Me.txtTotPay.TabIndex = 12
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(38, 138)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(102, 17)
        Me.Label31.TabIndex = 11
        Me.Label31.Text = "Total Payments :"
        '
        'txtOverdueTime
        '
        Me.txtOverdueTime.Enabled = False
        Me.txtOverdueTime.Location = New System.Drawing.Point(120, 35)
        Me.txtOverdueTime.Name = "txtOverdueTime"
        Me.txtOverdueTime.Size = New System.Drawing.Size(142, 25)
        Me.txtOverdueTime.TabIndex = 6
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(21, 38)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(93, 17)
        Me.Label28.TabIndex = 5
        Me.Label28.Text = "Overdue Time:"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label34)
        Me.GroupBox9.Controls.Add(Me.Label35)
        Me.GroupBox9.Controls.Add(Me.Label36)
        Me.GroupBox9.Controls.Add(Me.Label37)
        Me.GroupBox9.Controls.Add(Me.Label38)
        Me.GroupBox9.Controls.Add(Me.TextBox7)
        Me.GroupBox9.Controls.Add(Me.Label39)
        Me.GroupBox9.Controls.Add(Me.Label40)
        Me.GroupBox9.Location = New System.Drawing.Point(506, 144)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(45, 25)
        Me.GroupBox9.TabIndex = 4
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "do not touch.Time and Days for the future used. "
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(71, 26)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 17)
        Me.Label34.TabIndex = 7
        Me.Label34.Text = "Label25"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(71, 52)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 17)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Label25"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(75, 122)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(53, 17)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Label26"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(15, 122)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(59, 17)
        Me.Label37.TabIndex = 5
        Me.Label37.Text = "Change :"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 87)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(119, 17)
        Me.Label38.TabIndex = 3
        Me.Label38.Text = "Tendered Amount :"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(132, 84)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(177, 25)
        Me.TextBox7.TabIndex = 2
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(6, 52)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(70, 17)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "Payments :"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(6, 26)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(70, 17)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Over Due :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSearchPborrower)
        Me.GroupBox4.Controls.Add(Me.dtgPenalties)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(49, 132)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(365, 365)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "View Details of unreturned books with Penalties"
        '
        'txtSearchPborrower
        '
        Me.txtSearchPborrower.Location = New System.Drawing.Point(96, 42)
        Me.txtSearchPborrower.Name = "txtSearchPborrower"
        Me.txtSearchPborrower.Size = New System.Drawing.Size(263, 25)
        Me.txtSearchPborrower.TabIndex = 23
        '
        'dtgPenalties
        '
        Me.dtgPenalties.AllowUserToAddRows = False
        Me.dtgPenalties.AllowUserToDeleteRows = False
        Me.dtgPenalties.AllowUserToResizeColumns = False
        Me.dtgPenalties.AllowUserToResizeRows = False
        Me.dtgPenalties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgPenalties.BackgroundColor = System.Drawing.Color.White
        Me.dtgPenalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPenalties.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgPenalties.Location = New System.Drawing.Point(9, 73)
        Me.dtgPenalties.MultiSelect = False
        Me.dtgPenalties.Name = "dtgPenalties"
        Me.dtgPenalties.RowHeadersVisible = False
        Me.dtgPenalties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgPenalties.Size = New System.Drawing.Size(350, 271)
        Me.dtgPenalties.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 45)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 17)
        Me.Label27.TabIndex = 22
        Me.Label27.Text = "Borrower Id :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtg_Penalties)
        Me.TabPage2.Controls.Add(Me.Label60)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtrbooksSearch)
        Me.TabPage2.ImageKey = "(none)"
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(969, 750)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Overdue History"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtg_Penalties
        '
        Me.dtg_Penalties.AllowUserToAddRows = False
        Me.dtg_Penalties.AllowUserToDeleteRows = False
        Me.dtg_Penalties.AllowUserToResizeColumns = False
        Me.dtg_Penalties.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dtg_Penalties.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_Penalties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_Penalties.BackgroundColor = System.Drawing.Color.White
        Me.dtg_Penalties.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_Penalties.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_Penalties.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_Penalties.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtg_Penalties.ColumnHeadersHeight = 21
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg_Penalties.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtg_Penalties.EnableHeadersVisualStyles = False
        Me.dtg_Penalties.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_Penalties.Location = New System.Drawing.Point(24, 132)
        Me.dtg_Penalties.Name = "dtg_Penalties"
        Me.dtg_Penalties.RowHeadersVisible = False
        Me.dtg_Penalties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_Penalties.Size = New System.Drawing.Size(794, 243)
        Me.dtg_Penalties.TabIndex = 33
        Me.dtg_Penalties.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtg_Penalties.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtg_Penalties.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtg_Penalties.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtg_Penalties.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtg_Penalties.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtg_Penalties.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_Penalties.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_Penalties.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtg_Penalties.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtg_Penalties.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtg_Penalties.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtg_Penalties.ThemeStyle.HeaderStyle.Height = 21
        Me.dtg_Penalties.ThemeStyle.ReadOnly = False
        Me.dtg_Penalties.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtg_Penalties.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_Penalties.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtg_Penalties.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtg_Penalties.ThemeStyle.RowsStyle.Height = 22
        Me.dtg_Penalties.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_Penalties.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(21, 90)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(289, 31)
        Me.Label60.TabIndex = 30
        Me.Label60.Text = "List of Returned Books"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(431, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 25)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Search :"
        '
        'txtrbooksSearch
        '
        Me.txtrbooksSearch.BackColor = System.Drawing.Color.White
        Me.txtrbooksSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrbooksSearch.Location = New System.Drawing.Point(523, 381)
        Me.txtrbooksSearch.Name = "txtrbooksSearch"
        Me.txtrbooksSearch.Size = New System.Drawing.Size(295, 30)
        Me.txtrbooksSearch.TabIndex = 28
        '
        'frmPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1156, 758)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library System"
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dtgPenalties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dtg_Penalties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPenNew As Button
    Friend WithEvents btnPSave As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txttothours As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents txtamount As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txthours As TextBox
    Friend WithEvents txtChange As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txttenderedAmount As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtTotPay As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtOverdueTime As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtSearchPborrower As TextBox
    Friend WithEvents dtgPenalties As DataGridView
    Friend WithEvents Label27 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtrbooksSearch As TextBox
    Friend WithEvents dtg_Penalties As Guna.UI2.WinForms.Guna2DataGridView
End Class
