Public Class frmBooks

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            Dim datePublish As String = Format(dtpDatePublish.Value, "yyyy-MM-dd")
            Dim remarks As String = ""



            If txtAccessionNo.Text = "" Or txtAuthor.Text = "" Or txtTitle.Text = "" Or txtDesc.Text = "" Or txtPublisher.Text = "" Then
                MsgBox("All fields are required to be filled up.", MsgBoxStyle.Exclamation)
            Else

                If rdoDonate.Checked = True Then
                    remarks = "Donated Book"
                ElseIf rdoPurchased.Checked = True Then
                    remarks = "Purchased Book"
                End If

                sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = " & txtAccessionNo.Text
                reloadtxt(sql)

                If dt.Rows.Count > 0 Then
                    MsgBox("Accession number is already in used.", MsgBoxStyle.Exclamation)
                    Return
                End If

                sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = '" & txtAccessionNo.Text & "'"

                'adding books
                sqladd = "Insert Into `tblbooks` " &
                " (`AccessionNo`,`ISBN`, `CallNumber`, `BookTitle`, `BookDesc`, `Author`, `PublishDate`, `BookPublisher`, `CategoryId`, `BookPrice`, `BookQuantity`,Status,DeweyDecimal,OverAllQty,Remark,BookType) " &
                " VALUES ('" & txtAccessionNo.Text & "','" & txtISBN.Text & "','" & txtCallNo.Text & "','" & txtTitle.Text & "','" & txtDesc.Text & "','" & txtAuthor.Text & "','" & datePublish & "','" & txtPublisher.Text & "','" & cboCategory.SelectedValue & "','" & TxbPrice.Text & "',1, 'Available' ,'" & txtDeweyDecimal.Text & "',1,'" & remarks & "','" & cboType.Text & "')"
                'updating books

                sqledit = "Update `tblbooks` Set `ISBN`='" & txtISBN.Text & "', `CallNumber`='" & txtCallNo.Text & "', `BookTitle`,`BookTitle`='" & txtTitle.Text &
                "', `BookDesc`='" & txtDesc.Text & "', `Author`='" & txtAuthor.Text & "', `PublishDate`='" & datePublish &
                "', `BookPublisher`='" & txtPublisher.Text & "', `CategoryId`='" & cboCategory.SelectedValue &
                "',`BookPrice`='" & TxbPrice.Text & "',`DeweyDecimal`='" & txtDeweyDecimal.Text & "',Remark='" & remarks & "',BookType='" & cboType.Text & "'  WHERE `AccessionNo`='" & txtAccessionNo.Text & "'"


                save_or_update(sql, sqladd, sqledit, "Books has been updated in the database.", "New books has been saved in the database.")


                'sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = '" & txtAccessionNo.Text & "'"
                'reloadtxt(sql)
                'If dt.Rows.Count > 0 Then

                '    ''put a codes here  
                '    sql = "UPDATE `tblbooknumber` SET `QTY`=`QTY`+ 1 WHERE `BOOKTITLE`='" & txtTitle.Text & "'"
                '    updates(sql)

                'Else
                sql = "SELECT * FROM `tblbooknumber` WHERE `BOOKTITLE` = '" & txtTitle.Text &
                "'"
                reloadtxt(sql)
                If dt.Rows.Count > 0 Then

                    ''put a codes here  
                    sql = "UPDATE `tblbooknumber` SET `QTY`=`QTY`+ 1 WHERE `BOOKTITLE`='" & txtTitle.Text & "'"
                    updates(sql)

                Else
                    sql = "INSERT INTO  `tblbooknumber` (`BOOKTITLE`,`QTY`,`Desc`, `Author`, `PublishDate`, `Publisher`) " &
                    " VALUES ('" & txtTitle.Text & "',1,'" & txtDesc.Text & "','" & txtAuthor.Text & "','" & datePublish & "','" & txtPublisher.Text & "')"
                    create(sql)
                End If

                Call frmBooks_Load(sender, e)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub frmBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType as 'TypeOfBooks', `BookPrice` as 'Price', DeweyDecimal,Remark,Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` "
        'reloadDtg(sql, dtgList) 
        'cbo_fill(cboCategory, "Category", "CategoryId", "tblcategory")



        Call btnNew_Click(sender, e)

        sql = "SELECT * FROM `tblcategory` WHERE  `CategoryId`=" & cboCategory.SelectedValue
        reloadtxt(sql)
        txtDeweyDecimal.Text = dt.Rows(0).Item(2)





    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtAccessionNo.Clear()
        txtISBN.Clear()
        txtCallNo.Clear()
        txtTitle.Clear()
        txtDesc.Clear()
        txtAuthor.Clear()
        txtPublisher.Clear()
        sql = "SELECT `AccessionNo`,`ISBN`, `CallNumber`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType as 'TypeOfBooks', `BookPrice` as 'Price', DeweyDecimal,Remark,Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` "
        reloadDtg(sql, dtgList)
        cbo_fill(cboCategory, "Category", "CategoryId", "tblcategory WHERE Category !='ALL'  ORDER BY CATEGORY ASC")



        btnUpdate.Enabled = False

        btnSave.Enabled = True

        btnDelete.Enabled = False
        TxbPrice.Visible = False
        Label13.Visible = False


    End Sub




    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT `AccessionNo`,`ISBN`, `CallNumber`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType as 'TypeOfBooks', `BookPrice` as 'Price', DeweyDecimal,Remark,Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` AND (`BookTitle` Like '%" & txtSearch.Text & "%' OR `Author` Like '%" & txtSearch.Text & "%' OR `AccessionNo`  Like '%" & txtSearch.Text & "%')"
        reloadDtg(sql, dtgList)
    End Sub



    Private Sub dtgList_Click(sender As Object, e As EventArgs) Handles dtgList.Click
        Try
            With dtgList
                txtAccessionNo.Text = .CurrentRow.Cells(0).Value
                txtISBN.Text = .CurrentRow.Cells(1).Value
                txtCallNo.Text = .CurrentRow.Cells(2).Value
                txtTitle.Text = .CurrentRow.Cells(3).Value
                txtDesc.Text = .CurrentRow.Cells(4).Value
                txtAuthor.Text = .CurrentRow.Cells(5).Value
                dtpDatePublish.Value = Format(.CurrentRow.Cells(6).Value, "MM/dd/yyyy")
                txtPublisher.Text = .CurrentRow.Cells(7).Value
                cboCategory.Text = .CurrentRow.Cells(8).Value
                cboType.Text = .CurrentRow.Cells(9).Value
                TxbPrice.Text = .CurrentRow.Cells(10).Value
                txtDeweyDecimal.Text = .CurrentRow.Cells(11).Value

                If .CurrentRow.Cells(12).Value = "Purchased Book" Then
                    rdoPurchased.Checked = True
                Else
                    rdoDonate.Checked = True
                End If
                btnUpdate.Enabled = True
                btnSave.Enabled = False
                TxbPrice.Visible = True
                Label13.Visible = True
            End With
        Catch ex As Exception

        End Try
    End Sub



    Private Sub dtgList_DoubleClick(sender As Object, e As EventArgs) Handles dtgList.DoubleClick
        Try

            sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = " & txtAccessionNo.Text
            reloadtxt(sql)

            If dt.Rows.Count > 0 Then
                If MessageBox.Show("Accession number is already in used. Are you sure you want to proceed and update this book?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    With dtgList
                        txtAccessionNo.Text = .CurrentRow.Cells(0).Value
                        txtISBN.Text = .CurrentRow.Cells(1).Value
                        txtCallNo.Text = .CurrentRow.Cells(2).Value
                        txtTitle.Text = .CurrentRow.Cells(3).Value
                        txtDesc.Text = .CurrentRow.Cells(4).Value
                        txtAuthor.Text = .CurrentRow.Cells(5).Value
                        dtpDatePublish.Value = Format(.CurrentRow.Cells(4).Value, "MM/dd/yyyy")
                        txtPublisher.Text = .CurrentRow.Cells(6).Value
                        cboCategory.Text = .CurrentRow.Cells(7).Value
                        'txtPrice.Text = .CurrentRow.Cells(7).Value

                    End With
                Else
                    txtAccessionNo.Clear()
                    txtAccessionNo.Clear()
                    txtISBN.Clear()
                    txtCallNo.Clear()
                    txtTitle.Clear()
                    txtDesc.Clear()
                    txtAuthor.Clear()
                    txtPublisher.Clear()
                    'txtPrice.Clear()
                    cbo_fill(cboCategory, "Category", "CategoryId", "tblcategory")

                    'rdoDonate.Checked = True
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
#Region "Numbers only"


    Private Sub txtAccessionNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccessionNo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxbPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 AndAlso Not e.KeyChar = "." Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
#End Region

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        Try
            sql = "SELECT * FROM `tblcategory` WHERE  `CategoryId`=" & cboCategory.SelectedValue
            reloadtxt(sql)
            txtDeweyDecimal.Text = dt.Rows(0).Item(2)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAccessionNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccessionNo.TextChanged


        Try
            sql = "SELECT `AccessionNo`, `ISBN`, `CallNumber`, `BookTitle`, `BookDesc` , `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType ,`BookPrice`,DeweyDecimal,Remark  FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` AND  `AccessionNo`= '" & txtAccessionNo.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    txtISBN.Text = .Item(1)
                    txtCallNo.Text = .Item(2)
                    txtTitle.Text = .Item(3)
                    txtDesc.Text = .Item(4)
                    txtAuthor.Text = .Item(5)
                    dtpDatePublish.Value = Format(.Item(6), "MM/dd/yyyy")
                    txtPublisher.Text = .Item(7)
                    cboCategory.Text = .Item(8)
                    cboType.Text = .Item(9)
                    txtDeweyDecimal.Text = .Item(11)


                    btnUpdate.Enabled = True
                    btnSave.Enabled = False
                    btnDelete.Enabled = True
                End With
            Else
                txtISBN.Clear()
                txtCallNo.Clear()
                txtTitle.Clear()
                txtDesc.Clear()
                txtAuthor.Clear()
                txtPublisher.Clear()
                cboType.Text = "Unknown"

                cbo_fill(cboCategory, "Category", "CategoryId", "tblcategory")


                dtpDatePublish.Value = Format(Now(), "MM/dd/yyyy")

                btnUpdate.Enabled = False
                btnSave.Enabled = True
                btnDelete.Enabled = False
            End If

        Catch ex As Exception
            Me.Text = ex.Message
        End Try


        'Try

        '    'If txtAccessionNo.Text = "" Then
        '    'Else

        '    '    sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = " & txtAccessionNo.Text
        '    '    reloadtxt(sql)

        '    '    If dt.Rows.Count > 0 Then
        '    '        If MessageBox.Show("Accession number is already in used. Are you sure you want to proceed and update this book?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

        '    '        Else
        '    '            txtAccessionNo.Clear()
        '    '            cleartext(Me)

        '    '        End If
        '    '    End If

        '    'End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cboType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboType.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboCategory_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            Dim datePublish As String = Format(dtpDatePublish.Value, "yyyy-MM-dd")
            Dim remarks As String = ""



            If txtAccessionNo.Text = "" Or txtAuthor.Text = "" Or txtTitle.Text = "" Or txtDesc.Text = "" Or txtPublisher.Text = "" Then
                MsgBox("All fields are required to filled up.", MsgBoxStyle.Exclamation)
            Else
                If rdoDonate.Checked = True Then
                    remarks = "Donated Book"
                ElseIf rdoPurchased.Checked = True Then
                    remarks = "Purchased Book"
                End If


                sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = '" & txtAccessionNo.Text & "'"
                reloadtxt(sql)

                If dt.Rows.Count > 0 Then

                    sqledit = "Update `tblbooks` Set `ISBN`='" & txtISBN.Text & "', `CallNumber`='" & txtCallNo.Text & "', `BookTitle`='" & txtTitle.Text &
                    "', `BookDesc`='" & txtDesc.Text & "', `Author`='" & txtAuthor.Text & "', `PublishDate`='" & datePublish &
                    "', `BookPublisher`='" & txtPublisher.Text & "', `CategoryId`='" & cboCategory.SelectedValue & "',`BookPrice`='" & TxbPrice.Text & "', `DeweyDecimal`='" & txtDeweyDecimal.Text &
                    "',Remark='" & remarks & "',BookType='" & cboType.Text & "'  WHERE `AccessionNo`='" & txtAccessionNo.Text & "'"


                    save_or_update(sql, sqladd, sqledit, "Books has been updated in the database.", "New books has been saved in the database.")

                    Call frmBooks_Load(sender, e)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        sql = "DELETE FROM `tblbooks` WHERE `AccessionNo` = '" & txtAccessionNo.Text & "'"

        deletes(sql)

        MsgBox("Book has been deleted!", MsgBoxStyle.Information)
        Call btnNew_Click(sender, e)

    End Sub

    Private Sub rdoPurchased_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPurchased.CheckedChanged
        If rdoPurchased.Checked = True Then
            TxbPrice.Visible = True
            Label13.Visible = True
        Else
            TxbPrice.Visible = False
            Label13.Visible = False
        End If
    End Sub


End Class
