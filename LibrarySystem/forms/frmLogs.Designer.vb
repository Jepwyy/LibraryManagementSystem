<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogs))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVlogs = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogs = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1138, 634)
        Me.Panel1.TabIndex = 0
        '
        'btnVlogs
        '
        Me.btnVlogs.Animated = True
        Me.btnVlogs.BorderRadius = 10
        Me.btnVlogs.BorderThickness = 1
        Me.btnVlogs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnVlogs.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnVlogs.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnVlogs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnVlogs.ForeColor = System.Drawing.Color.Black
        Me.btnVlogs.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnVlogs.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnVlogs.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnVlogs.Image = CType(resources.GetObject("btnVlogs.Image"), System.Drawing.Image)
        Me.btnVlogs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnVlogs.ImageOffset = New System.Drawing.Point(8, 0)
        Me.btnVlogs.ImageSize = New System.Drawing.Size(21, 21)
        Me.btnVlogs.Location = New System.Drawing.Point(183, 5)
        Me.btnVlogs.Name = "btnVlogs"
        Me.btnVlogs.Size = New System.Drawing.Size(172, 38)
        Me.btnVlogs.TabIndex = 37
        Me.btnVlogs.Text = "Visitor Logs"
        Me.btnVlogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnVlogs.TextOffset = New System.Drawing.Point(8, 0)
        '
        'btnLogs
        '
        Me.btnLogs.Animated = True
        Me.btnLogs.BorderRadius = 10
        Me.btnLogs.BorderThickness = 1
        Me.btnLogs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnLogs.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogs.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogs.ForeColor = System.Drawing.Color.Black
        Me.btnLogs.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnLogs.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogs.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnLogs.Image = CType(resources.GetObject("btnLogs.Image"), System.Drawing.Image)
        Me.btnLogs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogs.ImageOffset = New System.Drawing.Point(8, 0)
        Me.btnLogs.ImageSize = New System.Drawing.Size(21, 21)
        Me.btnLogs.Location = New System.Drawing.Point(5, 5)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(172, 38)
        Me.btnLogs.TabIndex = 36
        Me.btnLogs.Text = "User Logs"
        Me.btnLogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogs.TextOffset = New System.Drawing.Point(8, 0)
        '
        'frmLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVlogs)
        Me.Controls.Add(Me.btnLogs)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogs"
        Me.Text = "frmLogs"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVlogs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogs As Guna.UI2.WinForms.Guna2Button
End Class
