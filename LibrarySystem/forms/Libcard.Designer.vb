<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Libcard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Libcard))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TextBFN = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextBLN = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextBID = New System.Windows.Forms.Label()
        Me.TextBCN = New System.Windows.Forms.Label()
        Me.TextBAddress = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(27, 91)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Controls.Add(Me.TextBID)
        Me.Panel1.Controls.Add(Me.TextBCN)
        Me.Panel1.Controls.Add(Me.TextBAddress)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(41, 37)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 232)
        Me.Panel1.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextBFN, Me.TextBLN})
        Me.StatusStrip1.Location = New System.Drawing.Point(274, 91)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(177, 25)
        Me.StatusStrip1.Stretch = False
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TextBFN
        '
        Me.TextBFN.Name = "TextBFN"
        Me.TextBFN.Size = New System.Drawing.Size(76, 20)
        Me.TextBFN.Text = "FirstName"
        '
        'TextBLN
        '
        Me.TextBLN.Name = "TextBLN"
        Me.TextBLN.Size = New System.Drawing.Size(75, 20)
        Me.TextBLN.Text = "LastName"
        '
        'TextBID
        '
        Me.TextBID.AutoEllipsis = True
        Me.TextBID.BackColor = System.Drawing.Color.Transparent
        Me.TextBID.Location = New System.Drawing.Point(229, 135)
        Me.TextBID.Name = "TextBID"
        Me.TextBID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBID.Size = New System.Drawing.Size(180, 13)
        Me.TextBID.TabIndex = 9
        Me.TextBID.Text = "Label1"
        '
        'TextBCN
        '
        Me.TextBCN.BackColor = System.Drawing.Color.Transparent
        Me.TextBCN.Location = New System.Drawing.Point(226, 167)
        Me.TextBCN.Name = "TextBCN"
        Me.TextBCN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBCN.Size = New System.Drawing.Size(183, 13)
        Me.TextBCN.TabIndex = 8
        Me.TextBCN.Text = "Label1"
        Me.TextBCN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBAddress
        '
        Me.TextBAddress.BackColor = System.Drawing.Color.Transparent
        Me.TextBAddress.Location = New System.Drawing.Point(223, 194)
        Me.TextBAddress.Name = "TextBAddress"
        Me.TextBAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBAddress.Size = New System.Drawing.Size(186, 13)
        Me.TextBAddress.TabIndex = 7
        Me.TextBAddress.Text = "Label1"
        Me.TextBAddress.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(41, 291)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 30)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(350, 291)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 27)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Choose printer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Libcard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 341)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Libcard"
        Me.Text = "Libcard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBID As Label
    Friend WithEvents TextBCN As Label
    Friend WithEvents TextBAddress As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TextBFN As ToolStripStatusLabel
    Friend WithEvents TextBLN As ToolStripStatusLabel
End Class
