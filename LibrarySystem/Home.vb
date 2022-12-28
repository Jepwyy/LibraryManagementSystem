Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Home
    Dim conn As New MySqlConnection("server=localhost;user id=root;Password=admin;Persist Security Info=True;database=test;Convert Zero Datetime=True;database=dblibrary")
    Public Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        visibleMenu()


        With frmDashboard
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmDashboard)
            .BringToFront()
            .Show()
        End With


        notif1()




    End Sub
    Sub notif1()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM `tblborrow` WHERE Status='Borrowed' AND Due=0", conn)
            Guna2NotificationPaint1.Text = cmd.ExecuteScalar.ToString
            If cmd.ExecuteScalar.ToString = 0 Then
                Guna2NotificationPaint1.Visible = False
            Else
                Guna2NotificationPaint1.Visible = True
            End If

            Dim cma As New MySqlCommand("SELECT COUNT(*) FROM `tblborrow` WHERE Status='Borrowed' AND Due=1", conn)
            Guna2NotificationPaint2.Text = cma.ExecuteScalar.ToString
            If cma.ExecuteScalar.ToString = 0 Then
                Guna2NotificationPaint2.Visible = False
            Else
                Guna2NotificationPaint2.Visible = True
            End If


            Dim cmdd As New MySqlCommand("SELECT (SELECT COUNT(*) FROM `tblborrower`  WHERE Stats='Active' AND Application='Reviewing') + (SELECT COUNT(*) FROM `tblreader` WHERE Status='Requested') + (SELECT COUNT(*) FROM `tblborrow` WHERE Status='Reviewing' AND Due=0)as count", conn)
            Guna2NotificationPaint3.Text = cmdd.ExecuteScalar.ToString
            If cmdd.ExecuteScalar.ToString = 0 Then
                Guna2NotificationPaint3.Visible = False
            Else
                Guna2NotificationPaint3.Visible = True
            End If

            Dim cmbbb As New MySqlCommand("SELECT COUNT(*) FROM `tblreader` WHERE Status='Borrowed'", conn)
            Guna2NotificationPaint4.Text = cmbbb.ExecuteScalar.ToString
            If cmbbb.ExecuteScalar.ToString = 0 Then
                Guna2NotificationPaint4.Visible = False
            Else
                Guna2NotificationPaint4.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub
    Private Sub btnDBoard_Click(sender As Object, e As EventArgs) Handles btnDBoard.Click

        With frmDashboard
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmDashboard)
            .BringToFront()
            .Show()
        End With
        notif1()


    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click

        With frmBooks
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmBooks)
            .BringToFront()
            .Show()
        End With
        notif1()
        Call frmBooks.frmBooks_Load(sender, e)
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click

        With frmCategory
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmCategory)
            .BringToFront()
            .Show()
        End With
        notif1()
    End Sub

    Private Sub btnBorrower_Click(sender As Object, e As EventArgs) Handles btnBorrower.Click

        With frmBorrower
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmBorrower)
            .BringToFront()
            .Show()
        End With
        notif1()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click

        With frmUser
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmUser)
            .BringToFront()
            .Show()
        End With
        notif1()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click

        With frmBorrow
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmBorrow)
            .BringToFront()
            .Show()
        End With
        notif1()

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        With frmReturn
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmReturn)
            .BringToFront()
            .Show()
        End With
        Call frmReturn.frmReturn_Load(sender, e)
        notif1()
    End Sub


    Private Sub btnOverdue_Click(sender As Object, e As EventArgs) Handles btnOverdue.Click

        With frmPayments
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmPayments)
            .BringToFront()
            .Show()
        End With
        Call frmPayments.frmPayments_Load(sender, e)
        notif1()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        With frmReport
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmReport)
            .BringToFront()
            .Show()
        End With
        notif1()
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles Logs.Click

        With frmLogs
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmLogs)
            .BringToFront()
            .Show()
        End With
        notif1()
    End Sub



    Private Sub tsLogin_Click(sender As Object, e As EventArgs) Handles tsLogin.Click
        If MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            UserPortalLog.Show()
            Me.Close()
            formClose()
            visibleMenu()
            sql = "INSERT INTO `tbllogs` (`UserId`, `LogDate`,LogMode) " &
                   " VALUES ('" & UserIdToolStripStatus.Text & "',Now(),'Logged out')"
            create(sql)

            UserIdToolStripStatus.Text = ""
            UserToolStripStatus.Text = ""
        End If
    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        MsgBox("Logout first before you close the form.", MsgBoxStyle.Information)
    End Sub

    Private Sub btnReq_Click(sender As Object, e As EventArgs) Handles btnReq.Click
        With frmRequest
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmRequest)
            .BringToFront()
            .Show()
        End With
        Call frmRequest.frmRequest_Load(sender, e)
        notif1()
        frmRequest.notifReq()
    End Sub

    Private Sub btn_Read_Click(sender As Object, e As EventArgs) Handles btn_Read.Click
        With frmRead
            .TopLevel = False
            Guna2Panel4.Controls.Add(frmRead)
            .BringToFront()
            .Show()
        End With
        Call frmRead.frmRead_Load(sender, e)
        notif1()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Notepad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskManagerToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("TaskMgr.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MSWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSWordToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Winword.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub SystemInfoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SystemInfoToolStripMenuItem1.Click
        frmSystemInfo.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()

    End Sub

    Private Sub SystemInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemInfoToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("powerpnt.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub WordpadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordpadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("excel.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class