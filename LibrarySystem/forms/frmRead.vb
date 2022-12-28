Imports MySql.Data.MySqlClient
Public Class frmRead
    Dim conn As New MySqlConnection("server=localhost;user id=root;Password=admin;Persist Security Info=True;database=test;Convert Zero Datetime=True;database=dblibrary")
    Public Sub frmRead_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT `VisitorsId`, `Name`, `Office`, `AccessionNo`, `BookTitle`, `Description`, `TimeBorrowed`, `Status` FROM `tblreader` WHERE Status='Borrowed'"
        reloadDtg(sql, dtgReadReturn)

        sql = "SELECT `VisitorsId`, `Name`, `Office`, `AccessionNo`, `BookTitle`, `Description`, `TimeBorrowed`, `TimeReturned`, `Status` FROM `tblreader` WHERE Status='Returned'"
        reloadDtg(sql, dtg_ReadHistory)
        notifRead()

    End Sub
    Sub notifRead()
        Try
            conn.Open()
            Dim cmbbb As New MySqlCommand("SELECT COUNT(*) FROM `tblreader` WHERE Status='Borrowed'", conn)
            Guna2NotificationPaint1.Text = cmbbb.ExecuteScalar.ToString
            If cmbbb.ExecuteScalar.ToString = 0 Then
                Guna2NotificationPaint1.Visible = False
            Else
                Guna2NotificationPaint1.Visible = True
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub txtAccesionNumBorrow_TextChanged(sender As Object, e As EventArgs) Handles txtAccesionNumBorrow.TextChanged
        If txtAccesionNumBorrow.Text = "" Then
            txtTitle.Clear()
            txtAuthor.Clear()
            txtDatePublish.Clear()
            txtpublisher.Clear()
            txtDesc.Clear()
        Else
            sql = "Select * From tblbooks b, tblcategory c WHERE b.CategoryId=c.CategoryId AND AccessionNo='" & txtAccesionNumBorrow.Text & "'"
            reloadtxt(sql)
            '`AccessionNo`, `BookTitle`, `Author`, `PublishDate`, `BookPublisher`, `BookQuantity`
            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    txtTitle.Text = .Item("BookTitle")
                    txtAuthor.Text = .Item("Author")
                    txtDatePublish.Text = .Item("PublishDate")
                    txtpublisher.Text = .Item("BookPublisher")
                    txtDesc.Text = .Item("BookDesc")
                End With
            End If
        End If
    End Sub

    Private Sub txtReaderId_TextChanged(sender As Object, e As EventArgs) Handles txtVisitorId.TextChanged
        If txtVisitorId.Text = "" Then
            txtName.Clear()
            txtCourse.Clear()
        Else
            reloadtxt("SELECT * FROM `tblcustomer` WHERE `id` = '" & txtVisitorId.Text & "'")

            If dt.Rows.Count > 0 Then
                txtName.Text = dt.Rows(0).Item("fname") & " " & dt.Rows(0).Item("lname")
                txtCourse.Text = dt.Rows(0).Item("office")


            Else
                txtName.Clear()
                txtCourse.Clear()
            End If
        End If
    End Sub

    Private Sub btnSearchBorrower_Click(sender As Object, e As EventArgs) Handles btnSearchBorrower.Click
        With frmListVisitor
            .Show()
            .Focus()
            .btnadd2.Visible = True
        End With
    End Sub

    Private Sub btn_Bsave_Click(sender As Object, e As EventArgs) Handles btn_Bsave.Click
        Try
            If txtAccesionNumBorrow.Text = "" Or txtVisitorId.Text = "" Then
                MsgBox("All fields are required.", MsgBoxStyle.Exclamation)
            Else





                sql = "INSERT INTO `tblreader`( `VisitorsId`, `Name`, `Office`, `AccessionNo`, `BookTitle`, `Description`, `TimeBorrowed`, `Status`) VALUES ('" & txtVisitorId.Text & "', '" & txtName.Text & "', '" & txtCourse.Text & "', '" & txtAccesionNumBorrow.Text & "', '" & txtTitle.Text & "', '" & txtDesc.Text & "',NOW(), 'Borrowed' )"
                result = create(sql)

                If result = True Then
                    MsgBox("Book has been Borrowed.")
                    updates("UPDATE tblbooks set Status = 'Not Available' Where AccessionNo='" & txtAccesionNumBorrow.Text & "'")
                    txtAccesionNumBorrow.Clear()
                    txtVisitorId.Clear()
                    Call frmRead_Load(sender, e)
                End If



            End If
            Home.notif1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearchBooks_Click(sender As Object, e As EventArgs) Handles btnSearchBooks.Click
        With frmListBooks
            .Show()
            .Focus()
            .btnadd2.Visible = True
        End With
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        updates("UPDATE `tblreader` SET `TimeReturned`=Now(),`Status`='Returned',`Remarks`='Readed' WHERE `VisitorsId`='" & dtgReadReturn.CurrentRow.Cells(0).Value & "'")
        If result = True Then
            sql = "UPDATE  `tblbooks` SET  `Status` =  'Available' WHERE  `AccessionNo` = '" & dtgReadReturn.CurrentRow.Cells(3).Value & "'"
            updates(sql)


            MsgBox("Book has been returned in the library.")
        End If
        Call frmRead_Load(sender, e)
        Home.notif1()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtAccesionNumBorrow.Clear()
        txtVisitorId.Clear()
    End Sub


End Class