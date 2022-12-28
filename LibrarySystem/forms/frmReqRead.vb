Public Class frmReqRead
    Private Sub frmReqRead_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            .btnAdd.Visible = True
        End With
    End Sub

    Private Sub btn_Bsave_Click(sender As Object, e As EventArgs) Handles btn_Bsave.Click
        Try
            If txtAccesionNumBorrow.Text = "" Or txtVisitorId.Text = "" Then
                MsgBox("All fields are required.", MsgBoxStyle.Exclamation)
            Else





                sql = "INSERT INTO `tblreader`( `VisitorsId`, `Name`, `Office`, `AccessionNo`, `BookTitle`, `Description`, `TimeRequested`, `Status`) VALUES ('" & txtVisitorId.Text & "', '" & txtName.Text & "', '" & txtCourse.Text & "', '" & txtAccesionNumBorrow.Text & "', '" & txtTitle.Text & "', '" & txtDesc.Text & "',NOW(), 'Requested' )"
                result = create(sql)

                If result = True Then
                    MsgBox("Book has been requested from the Librarian.", MsgBoxStyle.Information)

                    MessageBox.Show("Please Notify the librarian to accept your request", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                End If



            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtAccesionNumBorrow.Clear()
        txtVisitorId.Clear()

    End Sub

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click
        Me.Close()
    End Sub
End Class