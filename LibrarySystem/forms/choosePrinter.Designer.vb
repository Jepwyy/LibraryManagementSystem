<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class choosePrinter
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btn_okay = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_choose = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 18)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(376, 20)
        Me.TextBox1.TabIndex = 0
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btn_okay
        '
        Me.btn_okay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_okay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_okay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_okay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_okay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_okay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_okay.ForeColor = System.Drawing.Color.White
        Me.btn_okay.Location = New System.Drawing.Point(261, 41)
        Me.btn_okay.Name = "btn_okay"
        Me.btn_okay.Size = New System.Drawing.Size(66, 27)
        Me.btn_okay.TabIndex = 2
        Me.btn_okay.Text = "Okay"
        '
        'btn_choose
        '
        Me.btn_choose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_choose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_choose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_choose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_choose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_choose.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btn_choose.ForeColor = System.Drawing.Color.White
        Me.btn_choose.Location = New System.Drawing.Point(333, 41)
        Me.btn_choose.Name = "btn_choose"
        Me.btn_choose.Size = New System.Drawing.Size(66, 27)
        Me.btn_choose.TabIndex = 3
        Me.btn_choose.Text = "Choose"
        '
        'choosePrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 84)
        Me.Controls.Add(Me.btn_choose)
        Me.Controls.Add(Me.btn_okay)
        Me.Controls.Add(Me.TextBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "choosePrinter"
        Me.Text = "choosePrinter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btn_okay As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_choose As Guna.UI2.WinForms.Guna2GradientButton
End Class
