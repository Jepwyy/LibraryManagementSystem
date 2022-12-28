Public Class frmPayments



    Public Sub frmPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT br.`BorrowerId`,Concat(`Firstname`,' ', `Lastname`) as 'Borrower', `BookTitle`,`DateBorrowed`, `Purpose`, `DueDate` , BorrowId,br.AccessionNo FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=1 "
        reloadDtg(sql, dtgPenalties)
        dtgPenalties.Columns(5).Visible = False
        dtgPenalties.Columns(6).Visible = False

        cleartext(GroupBox7)
        cleartext(GroupBox10)
        sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate`,  br.status, br.remarks FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.status='Returned' AND Remarks='Overdue' ORDER BY DueDate Desc;"
        reloadDtg(sql, dtg_Penalties)
        dtg_Penalties.Columns(4).Visible = False
        dtg_Penalties.Columns(6).Visible = False
    End Sub

    Private Sub txtSearchPborrower_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchPborrower.TextChanged
        sql = "SELECT br.`BorrowerId`, `BookTitle`,`DateBorrowed`, `Purpose`, `DueDate` , BorrowId,br.AccessionNo " &
             " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " &
             " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=1 AND   br.`BorrowerId` Like '%" & txtSearchPborrower.Text & "%'"
        reloadDtg(sql, dtgPenalties)
        dtgPenalties.Columns(6).Visible = False
        dtgPenalties.Columns(7).Visible = False
    End Sub


    Private Sub dtgPenalties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgPenalties.Click

        Try
            sql = "SELECT  TIMEDIFF( NOW( ) ,  `DueDate` ),`AccessionNo` " _
              & "FROM  `tblborrow` WHERE `BorrowId` = '" & dtgPenalties.CurrentRow.Cells(6).Value.ToString & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then

                Dim ts As TimeSpan = dt.Rows(0).Item(0)
                Dim tsdays As Integer
                Dim hourperday As Integer
                Dim tshours As Integer
                Dim totalhours As Integer

                tsdays = ts.Days

                hourperday = tsdays * 24
                tshours = ts.Hours

                totalhours = hourperday + tshours



                txtOverdueTime.Text = ts.ToString
                txttothours.Text = totalhours
                'MsgBox(dt.Rows(0).Item(0).ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamount.TextChanged
        Try
            If txtamount.Text = "" Then
                txtTotPay.Text = ""
            Else
                If IsNumeric(txtamount.Text) Then
                    formulaofpayments()
                Else
                    txtamount.Clear()
                End If

            End If
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txthours_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthours.TextChanged
        Try
            If txthours.Text = "" Then
                txtTotPay.Text = ""
            Else
                If IsNumeric(txthours.Text) Then
                    formulaofpayments()
                Else
                    txthours.Clear()
                End If

            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txttenderedAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttenderedAmount.TextChanged
        Try

            If txttenderedAmount.Text = "" Then
                txtChange.Text = ""
            Else
                If IsNumeric(txttenderedAmount.Text) Then
                    txtChange.Text = Val(txttenderedAmount.Text) - Val(txtTotPay.Text)
                Else
                    txttenderedAmount.Clear()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & " txttenderedAmount_TextChanged")
        End Try
    End Sub

    Private Sub btnPSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPSave.Click
        Try
            If txtamount.Text = "" Or txthours.Text = "" Or txttenderedAmount.Text = "" Or txtOverdueTime.Text = "" Then
                MsgBox("You must fill all the fields inorder to save.", MsgBoxStyle.Exclamation)
            ElseIf Val(txtChange.Text) < 0 Then
                MsgBox("The tendered amount is less than the total payments. Its not valid.", MsgBoxStyle.Exclamation)
            Else
                'save to penalties
                sql = "INSERT INTO `tblpayment` (`BorrowId`, `Payment`, `Change`, `DatePayed`, `BorrowerId`, `Remarks`) " _
                & " VALUES (" & dtgPenalties.CurrentRow.Cells(7).Value & ",'" & txtTotPay.Text & "','" & txtChange.Text &
                "',Now(),'" & dtgPenalties.CurrentRow.Cells(0).Value & "','Settled')"
                result = create(sql)

                If result = True Then
                    ''''''
                    'save to return
                    sql = "INSERT INTO `tblreturn` (`BorrowId`, `NoCopies`, `DateReturned`, `Remarks`)" &
                      " VALUES (" & dtgPenalties.CurrentRow.Cells(7).Value & ",1,NOW(),'Returned')"
                    create(sql)

                    'for the items

                    sql = "UPDATE  `tblbooks` SET  `Status` =  'Available' WHERE  `AccessionNo` = '" & dtgPenalties.CurrentRow.Cells(7).Value & "'"
                    updates(sql)

                    'for the borrow
                    sql = "UPDATE `tblborrow` SET  `Status` =  'Returned', Due = 0 WHERE `BorrowId` = " & dtgPenalties.CurrentRow.Cells(6).Value
                    updates(sql)
                    'call the first load 

                    MsgBox("Book has been returned and settled in the library")
                    'call fisr load to refresh the record
                    Call frmPayments_Load(sender, e)
                    Call Home.notif1()

                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message & " btnPSave_Click")
        End Try
    End Sub

    Private Sub btnPenNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenNew.Click
        cleartext(GroupBox7)
        cleartext(GroupBox10)
        Call frmPayments_Load(sender, e)
    End Sub


#Region "numbers only"
    Private Sub txtSearchPborrower_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchPborrower.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtamount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamount.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not e.KeyChar = "." Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtminutes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthours.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txttenderedAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttenderedAmount.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not e.KeyChar = "." Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
#End Region

    Private Sub txtOverdueTime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOverdueTime.TextChanged





    End Sub




    Private Sub txtrbooksSearch_TextChanged(sender As Object, e As EventArgs) Handles txtrbooksSearch.TextChanged
        sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate`, br.remarks FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND Remarks='Overdue' or Concat(`Firstname`,' ', `Lastname`) LIKE '%" & txtrbooksSearch.Text & "%'  ORDER BY DueDate Desc"
        reloadDtg(sql, dtg_Penalties)
        dtg_Penalties.Columns(4).Visible = False
        dtg_Penalties.Columns(6).Visible = False
    End Sub
End Class