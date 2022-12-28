Public Class UserPortalBooks
    Private Sub UserPortalBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`,BookType as 'typeOfBooks',  DeweyDecimal " &
      ", Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` "
        reloadDtg(sql, dtgList)
        cbo_fill(cboCategories, "Category", "CategoryId", "tblcategory  ORDER BY CATEGORY ASC")

    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If cboCategories.Text = "ALL" Then
                sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`,BookType as 'typeOfBooks',  DeweyDecimal " &
                   ", Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND (`BookTitle` Like '%" & txtSearch.Text & "%' OR `Author` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
            Else
                sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`,BookType as 'typeOfBooks',  DeweyDecimal " &
                   ", Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND c.`CategoryId` ='" & cboCategories.SelectedValue & "' AND (`BookTitle` Like '%" & txtSearch.Text & "%' OR `Author` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
            End If
            reloadDtg(sql, dtgList)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategories.SelectedIndexChanged
        Try
            If cboCategories.Text = "ALL" Then
                sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`,BookType as 'typeOfBooks',  DeweyDecimal " &
                   ", Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND (`BookTitle` Like '%" & txtSearch.Text & "%' OR `Author` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
            Else
                sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`,BookType as 'typeOfBooks',  DeweyDecimal " &
                   ", Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND c.`CategoryId` ='" & cboCategories.SelectedValue & "' AND (`BookTitle` Like '%" & txtSearch.Text & "%' OR `Author` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
            End If
            reloadDtg(sql, dtgList)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboCategories_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCategories.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If cboCategories.Text = "ALL" Then
                sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`,BookType as 'typeOfBooks',  DeweyDecimal " &
                   ", Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND (`BookTitle` Like '%" & txtSearch.Text & "%' OR `Author` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
            Else
                sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`,BookType as 'typeOfBooks',  DeweyDecimal " &
                   ", Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND c.`CategoryId` ='" & cboCategories.SelectedValue & "' AND (`BookTitle` Like '%" & txtSearch.Text & "%' OR `Author` Like '%" & txtSearch.Text & "%' OR `AccessionNo` Like '%" & txtSearch.Text & "%')"
            End If
            reloadDtg(sql, dtgList)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Hide()
        UserPortalLog.Show()

    End Sub

    Private Sub btb_reqr_Click(sender As Object, e As EventArgs) Handles btb_reqr.Click
        Try
            If dtgList.CurrentRow.Cells(9).Value = "Available" Then
                frmReqRead.txtAccesionNumBorrow.Text = dtgList.CurrentRow.Cells(0).Value

                With frmReqRead
                    .Show()
                    .Focus()

                End With
                frmReqRead.txtVisitorId.Text = txbId.Text
            Else
                MsgBox("The book is already borrowed.", MsgBoxStyle.Exclamation)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Borrow_Click(sender As Object, e As EventArgs) Handles Borrow.Click
        Try
            reloadtext("SELECT * FROM `tblborrower` WHERE Firstname='" & txbFname.Text & "' and Lastname= '" & txbLname.Text & "'")

            If dt.Rows.Count > 0 Then
                With frmReqBorrow
                    .Show()
                    .Focus()

                End With
                txbBid.Text = dt.Rows(0).Item("BorrowerId")
                frmReqBorrow.txtAccesionNumBorrow.Text = dtgList.CurrentRow.Cells(0).Value
                frmReqBorrow.txtBorrowerId.Text = txbBid.Text

            Else
                If MessageBox.Show("It seems like you are not registered as a Borrower. Do you want to register?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    With frmRegBorrower
                        .Show()
                        .Focus()

                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btn_browser_Click_1(sender As Object, e As EventArgs) Handles btn_browser.Click
        FrmBrowser.Show()
        FrmBrowser.Focus()

    End Sub

    Private Sub txbFname_TextChanged(sender As Object, e As EventArgs) Handles txbFname.TextChanged
        reloadtxt("SELECT * FROM `tblcustomer` WHERE Date(`timedate`) = CURDATE() AND `fname` = '" & UserPortalLog.txbfname.Text & "' AND `lname` = '" & UserPortalLog.txblname.Text & "'")


        If dt.Rows.Count > 0 Then

            txbId.Text = dt.Rows(0).Item("id")
            'txbFname = dt.Rows(0).Item("fname")

        End If
    End Sub


End Class