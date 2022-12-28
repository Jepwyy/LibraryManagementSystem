<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserPortalLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserPortalLog))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txbfname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnlog = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txblname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txbcnumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txboffice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.rdio_O = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdio_Pw = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdio_Sc = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdio_Pr = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdio_C = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdio_S = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdio_J = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdio_E = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.rdio_m = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdio_F = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolStriplogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.GroupBox1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(917, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 42)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date and Time"
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(7, 18)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(152, 21)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Label1"
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(190, 16)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(170, 23)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "Label1"
        '
        'txbfname
        '
        Me.txbfname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txbfname.Animated = True
        Me.txbfname.AutoRoundedCorners = True
        Me.txbfname.BackColor = System.Drawing.Color.Transparent
        Me.txbfname.BorderRadius = 17
        Me.txbfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbfname.DefaultText = ""
        Me.txbfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbfname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbfname.Location = New System.Drawing.Point(86, 492)
        Me.txbfname.Name = "txbfname"
        Me.txbfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbfname.PlaceholderText = "First Name"
        Me.txbfname.SelectedText = ""
        Me.txbfname.Size = New System.Drawing.Size(200, 36)
        Me.txbfname.TabIndex = 22
        '
        'btnlog
        '
        Me.btnlog.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlog.Animated = True
        Me.btnlog.AutoRoundedCorners = True
        Me.btnlog.BackColor = System.Drawing.Color.Transparent
        Me.btnlog.BorderRadius = 21
        Me.btnlog.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnlog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnlog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlog.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlog.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlog.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnlog.ForeColor = System.Drawing.Color.White
        Me.btnlog.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnlog.Location = New System.Drawing.Point(561, 617)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(180, 45)
        Me.btnlog.TabIndex = 23
        Me.btnlog.Text = "Save Log"
        '
        'txblname
        '
        Me.txblname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txblname.Animated = True
        Me.txblname.AutoRoundedCorners = True
        Me.txblname.BackColor = System.Drawing.Color.Transparent
        Me.txblname.BorderRadius = 17
        Me.txblname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txblname.DefaultText = ""
        Me.txblname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txblname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txblname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txblname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txblname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txblname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txblname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txblname.Location = New System.Drawing.Point(292, 492)
        Me.txblname.Name = "txblname"
        Me.txblname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txblname.PlaceholderText = "Last Name"
        Me.txblname.SelectedText = ""
        Me.txblname.Size = New System.Drawing.Size(200, 36)
        Me.txblname.TabIndex = 25
        '
        'txbaddress
        '
        Me.txbaddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txbaddress.Animated = True
        Me.txbaddress.AutoRoundedCorners = True
        Me.txbaddress.BackColor = System.Drawing.Color.Transparent
        Me.txbaddress.BorderRadius = 17
        Me.txbaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbaddress.DefaultText = ""
        Me.txbaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbaddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbaddress.Location = New System.Drawing.Point(498, 492)
        Me.txbaddress.Name = "txbaddress"
        Me.txbaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbaddress.PlaceholderText = "Address"
        Me.txbaddress.SelectedText = ""
        Me.txbaddress.Size = New System.Drawing.Size(310, 36)
        Me.txbaddress.TabIndex = 26
        '
        'txbcnumber
        '
        Me.txbcnumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txbcnumber.Animated = True
        Me.txbcnumber.AutoRoundedCorners = True
        Me.txbcnumber.BackColor = System.Drawing.Color.Transparent
        Me.txbcnumber.BorderRadius = 17
        Me.txbcnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbcnumber.DefaultText = ""
        Me.txbcnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txbcnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txbcnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbcnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txbcnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbcnumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txbcnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txbcnumber.Location = New System.Drawing.Point(814, 492)
        Me.txbcnumber.Name = "txbcnumber"
        Me.txbcnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbcnumber.PlaceholderText = "Contact Number"
        Me.txbcnumber.SelectedText = ""
        Me.txbcnumber.Size = New System.Drawing.Size(200, 36)
        Me.txbcnumber.TabIndex = 27
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.Location = New System.Drawing.Point(39, 385)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1233, 18)
        Me.Guna2Separator1.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(554, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Visitors Log"
        '
        'txboffice
        '
        Me.txboffice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txboffice.Animated = True
        Me.txboffice.AutoRoundedCorners = True
        Me.txboffice.BackColor = System.Drawing.Color.Transparent
        Me.txboffice.BorderRadius = 17
        Me.txboffice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txboffice.DefaultText = ""
        Me.txboffice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txboffice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txboffice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txboffice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txboffice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txboffice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txboffice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txboffice.Location = New System.Drawing.Point(1020, 492)
        Me.txboffice.Name = "txboffice"
        Me.txboffice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txboffice.PlaceholderText = "School/Office"
        Me.txboffice.SelectedText = ""
        Me.txboffice.Size = New System.Drawing.Size(200, 36)
        Me.txboffice.TabIndex = 32
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox1.Controls.Add(Me.rdio_O)
        Me.Guna2GroupBox1.Controls.Add(Me.rdio_Pw)
        Me.Guna2GroupBox1.Controls.Add(Me.rdio_Sc)
        Me.Guna2GroupBox1.Controls.Add(Me.rdio_Pr)
        Me.Guna2GroupBox1.Controls.Add(Me.rdio_C)
        Me.Guna2GroupBox1.Controls.Add(Me.rdio_S)
        Me.Guna2GroupBox1.Controls.Add(Me.rdio_J)
        Me.Guna2GroupBox1.Controls.Add(Me.rdio_E)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(237, 534)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(627, 79)
        Me.Guna2GroupBox1.TabIndex = 45
        Me.Guna2GroupBox1.Text = "Academic Category :"
        '
        'rdio_O
        '
        Me.rdio_O.AutoSize = True
        Me.rdio_O.BackColor = System.Drawing.Color.Transparent
        Me.rdio_O.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_O.CheckedState.BorderThickness = 0
        Me.rdio_O.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_O.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_O.CheckedState.InnerOffset = -4
        Me.rdio_O.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdio_O.Location = New System.Drawing.Point(485, 51)
        Me.rdio_O.Name = "rdio_O"
        Me.rdio_O.Size = New System.Drawing.Size(112, 17)
        Me.rdio_O.TabIndex = 50
        Me.rdio_O.Text = "OUT OF SCHOOL"
        Me.rdio_O.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rdio_O.UncheckedState.BorderThickness = 2
        Me.rdio_O.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdio_O.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdio_O.UseVisualStyleBackColor = False
        '
        'rdio_Pw
        '
        Me.rdio_Pw.AutoSize = True
        Me.rdio_Pw.BackColor = System.Drawing.Color.Transparent
        Me.rdio_Pw.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_Pw.CheckedState.BorderThickness = 0
        Me.rdio_Pw.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_Pw.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_Pw.CheckedState.InnerOffset = -4
        Me.rdio_Pw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdio_Pw.Location = New System.Drawing.Point(311, 51)
        Me.rdio_Pw.Name = "rdio_Pw"
        Me.rdio_Pw.Size = New System.Drawing.Size(51, 17)
        Me.rdio_Pw.TabIndex = 49
        Me.rdio_Pw.Text = "PWD"
        Me.rdio_Pw.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rdio_Pw.UncheckedState.BorderThickness = 2
        Me.rdio_Pw.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdio_Pw.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdio_Pw.UseVisualStyleBackColor = False
        '
        'rdio_Sc
        '
        Me.rdio_Sc.AutoSize = True
        Me.rdio_Sc.BackColor = System.Drawing.Color.Transparent
        Me.rdio_Sc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_Sc.CheckedState.BorderThickness = 0
        Me.rdio_Sc.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_Sc.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_Sc.CheckedState.InnerOffset = -4
        Me.rdio_Sc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdio_Sc.Location = New System.Drawing.Point(368, 51)
        Me.rdio_Sc.Name = "rdio_Sc"
        Me.rdio_Sc.Size = New System.Drawing.Size(111, 17)
        Me.rdio_Sc.TabIndex = 48
        Me.rdio_Sc.Text = "SENIOR CITIZEN"
        Me.rdio_Sc.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rdio_Sc.UncheckedState.BorderThickness = 2
        Me.rdio_Sc.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdio_Sc.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdio_Sc.UseVisualStyleBackColor = False
        '
        'rdio_Pr
        '
        Me.rdio_Pr.AutoSize = True
        Me.rdio_Pr.BackColor = System.Drawing.Color.Transparent
        Me.rdio_Pr.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_Pr.CheckedState.BorderThickness = 0
        Me.rdio_Pr.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_Pr.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_Pr.CheckedState.InnerOffset = -4
        Me.rdio_Pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdio_Pr.Location = New System.Drawing.Point(251, 51)
        Me.rdio_Pr.Name = "rdio_Pr"
        Me.rdio_Pr.Size = New System.Drawing.Size(54, 17)
        Me.rdio_Pr.TabIndex = 47
        Me.rdio_Pr.Text = "PROF"
        Me.rdio_Pr.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rdio_Pr.UncheckedState.BorderThickness = 2
        Me.rdio_Pr.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdio_Pr.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdio_Pr.UseVisualStyleBackColor = False
        '
        'rdio_C
        '
        Me.rdio_C.AutoSize = True
        Me.rdio_C.BackColor = System.Drawing.Color.Transparent
        Me.rdio_C.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_C.CheckedState.BorderThickness = 0
        Me.rdio_C.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_C.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_C.CheckedState.InnerOffset = -4
        Me.rdio_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdio_C.Location = New System.Drawing.Point(193, 50)
        Me.rdio_C.Name = "rdio_C"
        Me.rdio_C.Size = New System.Drawing.Size(52, 17)
        Me.rdio_C.TabIndex = 46
        Me.rdio_C.Text = "COLL"
        Me.rdio_C.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rdio_C.UncheckedState.BorderThickness = 2
        Me.rdio_C.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdio_C.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdio_C.UseVisualStyleBackColor = False
        '
        'rdio_S
        '
        Me.rdio_S.AutoSize = True
        Me.rdio_S.BackColor = System.Drawing.Color.Transparent
        Me.rdio_S.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_S.CheckedState.BorderThickness = 0
        Me.rdio_S.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_S.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_S.CheckedState.InnerOffset = -4
        Me.rdio_S.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdio_S.Location = New System.Drawing.Point(140, 51)
        Me.rdio_S.Name = "rdio_S"
        Me.rdio_S.Size = New System.Drawing.Size(47, 17)
        Me.rdio_S.TabIndex = 45
        Me.rdio_S.Text = "SHS"
        Me.rdio_S.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rdio_S.UncheckedState.BorderThickness = 2
        Me.rdio_S.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdio_S.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdio_S.UseVisualStyleBackColor = False
        '
        'rdio_J
        '
        Me.rdio_J.AutoSize = True
        Me.rdio_J.BackColor = System.Drawing.Color.Transparent
        Me.rdio_J.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_J.CheckedState.BorderThickness = 0
        Me.rdio_J.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_J.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_J.CheckedState.InnerOffset = -4
        Me.rdio_J.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdio_J.Location = New System.Drawing.Point(89, 51)
        Me.rdio_J.Name = "rdio_J"
        Me.rdio_J.Size = New System.Drawing.Size(45, 17)
        Me.rdio_J.TabIndex = 44
        Me.rdio_J.Text = "JHS"
        Me.rdio_J.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rdio_J.UncheckedState.BorderThickness = 2
        Me.rdio_J.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdio_J.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdio_J.UseVisualStyleBackColor = False
        '
        'rdio_E
        '
        Me.rdio_E.AutoSize = True
        Me.rdio_E.BackColor = System.Drawing.Color.Transparent
        Me.rdio_E.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_E.CheckedState.BorderThickness = 0
        Me.rdio_E.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_E.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_E.CheckedState.InnerOffset = -4
        Me.rdio_E.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdio_E.Location = New System.Drawing.Point(29, 51)
        Me.rdio_E.Name = "rdio_E"
        Me.rdio_E.Size = New System.Drawing.Size(54, 17)
        Me.rdio_E.TabIndex = 43
        Me.rdio_E.Text = "ELEM"
        Me.rdio_E.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rdio_E.UncheckedState.BorderThickness = 2
        Me.rdio_E.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdio_E.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdio_E.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox2.Controls.Add(Me.rdio_m)
        Me.Guna2GroupBox2.Controls.Add(Me.rdio_F)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(859, 534)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(210, 79)
        Me.Guna2GroupBox2.TabIndex = 51
        Me.Guna2GroupBox2.Text = "Gender :"
        '
        'rdio_m
        '
        Me.rdio_m.AutoSize = True
        Me.rdio_m.BackColor = System.Drawing.Color.Transparent
        Me.rdio_m.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_m.CheckedState.BorderThickness = 0
        Me.rdio_m.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_m.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_m.CheckedState.InnerOffset = -4
        Me.rdio_m.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdio_m.Location = New System.Drawing.Point(42, 50)
        Me.rdio_m.Name = "rdio_m"
        Me.rdio_m.Size = New System.Drawing.Size(54, 17)
        Me.rdio_m.TabIndex = 48
        Me.rdio_m.Text = "MALE"
        Me.rdio_m.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rdio_m.UncheckedState.BorderThickness = 2
        Me.rdio_m.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdio_m.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdio_m.UseVisualStyleBackColor = False
        '
        'rdio_F
        '
        Me.rdio_F.AutoSize = True
        Me.rdio_F.BackColor = System.Drawing.Color.Transparent
        Me.rdio_F.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_F.CheckedState.BorderThickness = 0
        Me.rdio_F.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_F.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdio_F.CheckedState.InnerOffset = -4
        Me.rdio_F.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rdio_F.Location = New System.Drawing.Point(102, 51)
        Me.rdio_F.Name = "rdio_F"
        Me.rdio_F.Size = New System.Drawing.Size(67, 17)
        Me.rdio_F.TabIndex = 47
        Me.rdio_F.Text = "FEMALE"
        Me.rdio_F.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rdio_F.UncheckedState.BorderThickness = 2
        Me.rdio_F.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdio_F.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdio_F.UseVisualStyleBackColor = False
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(297, 137)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(195, 193)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 52
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(495, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 29)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "WELCOME TO"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(493, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(530, 37)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "QUEZON CITY PUBLIC LIBRARY"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(495, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(426, 37)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "KRUS NA LIGAS BRANCH"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(498, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(618, 20)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "2nd floor, Daza Hall Bldg, P. Francisco St. Brgy. Krus na Ligas , Quezon City"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(498, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(436, 20)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Open Hours of Library: Monday to Friday (8AM - 5PM)"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(498, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(349, 20)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "8922-4060 | qcplibrary@quezoncity.gov.ph"
        '
        'ToolStriplogin
        '
        Me.ToolStriplogin.AutoRoundedCorners = True
        Me.ToolStriplogin.BackColor = System.Drawing.Color.Transparent
        Me.ToolStriplogin.BorderRadius = 16
        Me.ToolStriplogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ToolStriplogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ToolStriplogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ToolStriplogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ToolStriplogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ToolStriplogin.FillColor = System.Drawing.Color.Black
        Me.ToolStriplogin.FillColor2 = System.Drawing.Color.Blue
        Me.ToolStriplogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStriplogin.ForeColor = System.Drawing.Color.White
        Me.ToolStriplogin.Location = New System.Drawing.Point(3, 4)
        Me.ToolStriplogin.Name = "ToolStriplogin"
        Me.ToolStriplogin.Size = New System.Drawing.Size(133, 35)
        Me.ToolStriplogin.TabIndex = 0
        Me.ToolStriplogin.Text = "Admin Login"
        '
        'UserPortalLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1306, 721)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ToolStriplogin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.txboffice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.txbcnumber)
        Me.Controls.Add(Me.txbaddress)
        Me.Controls.Add(Me.txblname)
        Me.Controls.Add(Me.btnlog)
        Me.Controls.Add(Me.txbfname)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserPortalLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Portal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsLogin As ToolStripButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents txbfname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnlog As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txblname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txbcnumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txboffice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents rdio_O As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdio_Pw As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdio_Sc As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdio_Pr As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdio_C As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdio_S As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdio_J As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdio_E As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents rdio_m As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdio_F As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolStriplogin As Guna.UI2.WinForms.Guna2GradientButton
End Class
