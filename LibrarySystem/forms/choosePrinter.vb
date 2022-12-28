Public Class choosePrinter
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub choosePrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.printer
        btn_okay.Enabled = False
    End Sub

    Private Sub choosePrinter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.printer = TextBox1.Text
    End Sub

    
    Private Sub btn_choose_Click(sender As Object, e As EventArgs) Handles btn_choose.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then

        End If

        TextBox1.Text = PrintDialog1.PrinterSettings.PrinterName

        btn_okay.Enabled = True
    End Sub

    Private Sub btn_okay_Click(sender As Object, e As EventArgs) Handles btn_okay.Click
        Me.Close()
    End Sub
End Class