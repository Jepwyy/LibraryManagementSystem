Public Class frmLogs
    Private Sub frmLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With UserLogs1
            .TopLevel = False
            Panel1.Controls.Add(UserLogs1)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnVlogs_Click(sender As Object, e As EventArgs) Handles btnVlogs.Click
        With frmLogsuser
            .TopLevel = False
            Panel1.Controls.Add(frmLogsuser)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        With UserLogs1
            .TopLevel = False
            Panel1.Controls.Add(UserLogs1)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class