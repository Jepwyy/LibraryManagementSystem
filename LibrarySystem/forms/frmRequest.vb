Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmRequest
    Dim conn As New MySqlConnection("server=localhost;user id=root;Password=admin;Persist Security Info=True;database=test;Convert Zero Datetime=True;database=dblibrary")
    Public Sub frmRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT `VisitorsId`, `Name`, `Office`, `AccessionNo`, `BookTitle`, `Description`, `TimeRequested`, `Status` FROM `tblreader` WHERE Status='Requested'"
        reloadDtg(sql, dtgReadReq)

        sql = "SELECT br.`BorrowerId`, `Firstname`, `Lastname`, `BookTitle`, `DateBorrowed`, `Purpose`, `DueDate` , BorrowId,br.AccessionNo " &
        " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " &
        " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Reviewing' AND Due=0 ORDER BY BorrowId Desc"
        reloadDtg(sql, dtgBookReq)

        sql = "SELECT BorrowerId,`Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear`  as 'Course/Year' FROM `tblborrower`  WHERE Stats='Active' AND Application='Reviewing'"
        reloadDtg(sql, dtgBorrowerReq)

        notifReq()
        Home.notif1()


    End Sub
    Sub notifReq()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM `tblborrower`  WHERE Stats='Active' AND Application='Reviewing'", conn)
            Guna2NotificationPaint2.Text = cmd.ExecuteScalar.ToString
            If cmd.ExecuteScalar.ToString = 0 Then
                Guna2NotificationPaint2.Visible = False
            Else
                Guna2NotificationPaint2.Visible = True
            End If

            Dim cma As New MySqlCommand("SELECT COUNT(*) FROM `tblreader` WHERE Status='Requested'", conn)
            Guna2NotificationPaint3.Text = cma.ExecuteScalar.ToString
            If cma.ExecuteScalar.ToString = 0 Then
                Guna2NotificationPaint3.Visible = False
            Else
                Guna2NotificationPaint3.Visible = True
            End If

            Dim cmb As New MySqlCommand("SELECT COUNT(*) FROM `tblborrow` WHERE Status='Reviewing' AND Due=0", conn)
            Guna2NotificationPaint1.Text = cmb.ExecuteScalar.ToString
            If cmb.ExecuteScalar.ToString = 0 Then
                Guna2NotificationPaint1.Visible = False
            Else
                Guna2NotificationPaint1.Visible = True
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub


    Private Sub btn_readReq_Click(sender As Object, e As EventArgs) Handles btn_readReq.Click
        updates("UPDATE `tblreader` SET `TimeBorrowed`=Now(),`Status`='Borrowed' WHERE `VisitorsId`='" & dtgReadReq.CurrentRow.Cells(0).Value & "'")
        If result = True Then
            MsgBox("Read Request Accepted.")
            updates("UPDATE tblbooks set Status = 'Not Available' Where AccessionNo='" & dtgReadReq.CurrentRow.Cells(3).Value & "'")
        Else
            MsgBox("Error")
        End If
        Call frmRequest_Load(sender, e)
    End Sub

    Private Sub btnBorrowerReq_Click(sender As Object, e As EventArgs) Handles btnBorrowerReq.Click
        updates("Update `tblborrower` Set   `Application`='Approved' WHERE `BorrowerId` ='" & dtgBorrowerReq.CurrentRow.Cells(0).Value & "'")
        If result = True Then
            MsgBox("Register Request Accepted.")

        Else
            MsgBox("Error")
        End If
        Call frmRequest_Load(sender, e)
    End Sub

    Private Sub btn_bbook_Click(sender As Object, e As EventArgs) Handles btn_bbook.Click
        updates("UPDATE `tblborrow` SET  `Status` =  'Borrowed',`Remarks`='On Time' WHERE `BorrowId` = '" & dtgBookReq.CurrentRow.Cells(7).Value & "'")
        If result = True Then
            MsgBox("Book has been borrowed in the library")
            updates("UPDATE tblbooks set Status = 'Not Available' Where AccessionNo='" & dtgBookReq.CurrentRow.Cells(8).Value & "'")

        Else
            MsgBox("Error")
        End If
        Call frmRequest_Load(sender, e)
    End Sub

    Private Sub btn_DeleteBorrower_Click(sender As Object, e As EventArgs) Handles btn_DeleteBorrower.Click
        sql = "DELETE FROM `tblborrower`  WHERE Stats='Active' AND Application='Reviewing' AND `BorrowerId`='" & dtgBorrowerReq.CurrentRow.Cells(0).Value & "'"

        deletes(sql)

        MsgBox("Record has been deleted!", MsgBoxStyle.Information)
        Call frmRequest_Load(sender, e)
    End Sub

    Private Sub btn_delBookReq_Click(sender As Object, e As EventArgs) Handles btn_delBookReq.Click
        sql = "DELETE FROM `tblreader` WHERE Status='Requested' AND `VisitorsId`='" & dtgReadReq.CurrentRow.Cells(0).Value & "'"

        deletes(sql)

        MsgBox("Record has been deleted!", MsgBoxStyle.Information)
        Call frmRequest_Load(sender, e)
    End Sub

    Private Sub btn_DelBook_Click(sender As Object, e As EventArgs) Handles btn_DelBook.Click
        sql = "UPDATE  `tblbooks` SET  `Status` =  'Available' WHERE  `AccessionNo` = '" & dtgBookReq.CurrentRow.Cells(8).Value & "'"
        updates(sql)
        sql = "DELETE FROM `tblborrow` WHERE Status='Reviewing' AND Due=0  AND `BorrowerId` ='" & dtgBookReq.CurrentRow.Cells(0).Value & "'"
        deletes(sql)

        MsgBox("Record has been deleted!", MsgBoxStyle.Information)
        Call frmRequest_Load(sender, e)
    End Sub
End Class