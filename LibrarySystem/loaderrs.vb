Public Class loaderrs
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progress.Increment(1)
        If progress.Value = 100 Then
            Me.Hide()
            UserPortalLog.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub load_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.CenterToScreen()


    End Sub



End Class