Public Class frmReport

    Private Sub btnListBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListBooks.Click
        sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, `Remark`, `BookPrice` as 'Price', `BookQuantity` as 'No.Copies', `Status`,`OverAllQty` FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`"
        reloadDtg(sql, dtg_report)
        rdoDaily.Checked = False
        rdoWeekly.Checked = False
        rdoMonthly.Checked = False
    End Sub

    Private Sub btn_preview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_preview.Click

        Select Case cboStatus.Text
            Case "Borrowed"

                sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND  DATE(DateBorrowed) BETWEEN '" & dtp_strtDate.Text & "' AND '" & dtp_endDate.Text & "'"
                reloadDtg(sql, dtg_report)
            Case "Returned"
                sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`,r.`NoCopies`, `DateReturned`  FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b  WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned' AND  DATE(DateReturned) BETWEEN '" & dtp_strtDate.Text & "' AND '" & dtp_endDate.Text & "' "
                reloadDtg(sql, dtg_report)
            Case "Overdue"
                sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND Remarks='Overdue'  AND DATE(DueDate) BETWEEN '" & dtp_strtDate.Text & "' AND '" & dtp_endDate.Text & "'"
                reloadDtg(sql, dtg_report)
            Case "Read"
                sql = "SELECT `VisitorsId`, `Name`, `Office`, `AccessionNo`, `BookTitle`, `Description`, `TimeBorrowed`, `TimeReturned`, `Status` FROM `tblreader` WHERE Status='Returned'  AND DATE(TimeReturned) BETWEEN '" & dtp_strtDate.Text & "' AND '" & dtp_endDate.Text & "'"
                reloadDtg(sql, dtg_report)

        End Select


        rdoDaily.Checked = False
        rdoWeekly.Checked = False
        rdoMonthly.Checked = False
    End Sub

    Private Sub rdoDaily_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDaily.Click
        Try

            Select Case cboStatus.Text
                Case "Borrowed"

                    sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND  Date(`DateBorrowed`) = CURDATE() "
                    reloadDtg(sql, dtg_report)
                Case "Returned"
                    sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`,r.`NoCopies`, `DateReturned`  FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b  WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned' AND Date(`DateReturned`) = CURDATE() "
                    reloadDtg(sql, dtg_report)
                Case "Overdue"
                    sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND Remarks='Overdue'  AND Date(`DueDate`) = CURDATE() "
                    reloadDtg(sql, dtg_report)
                Case "Read"
                    sql = "SELECT `VisitorsId`, `Name`, `Office`, `AccessionNo`, `BookTitle`, `Description`, `TimeBorrowed`, `TimeReturned`, `Status` FROM `tblreader` WHERE Status='Returned'  AND Date(`TimeReturned`) = CURDATE() "
                    reloadDtg(sql, dtg_report)

            End Select


        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdoWeekly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoWeekly.Click
        Try

            Select Case cboStatus.Text
                Case "Borrowed"

                    sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND  DAYOFWEEK(  `DateBorrowed` ) IN ( 2, 3, 4, 5, 6 ) AND MONTH(DateBorrowed) = MONTH(Now())"
                    reloadDtg(sql, dtg_report)
                Case "Returned"
                    sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`,r.`NoCopies`, `DateReturned`  FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b  WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned' AND DAYOFWEEK(  `DateReturned` ) IN ( 2, 3, 4, 5, 6 ) AND MONTH(DateReturned) = MONTH(Now())"
                    reloadDtg(sql, dtg_report)
                Case "Overdue"
                    sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND Remarks='Overdue' AND DAYOFWEEK(  `DueDate` ) IN ( 2, 3, 4, 5, 6 ) AND MONTH(DueDate) = MONTH(Now())"
                    reloadDtg(sql, dtg_report)
                Case "Read"
                    sql = "SELECT `VisitorsId`, `Name`, `Office`, `AccessionNo`, `BookTitle`, `Description`, `TimeBorrowed`, `TimeReturned`, `Status` FROM `tblreader` WHERE Status='Returned' AND DAYOFWEEK(  `TimeReturned` ) IN ( 2, 3, 4, 5, 6 ) AND MONTH(TimeReturned) = MONTH(Now())"
                    reloadDtg(sql, dtg_report)
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdoMonthly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoMonthly.Click
        Try

            Select Case cboStatus.Text
                Case "Borrowed"

                    sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND MONTH(DateBorrowed) = MONTH(Now())"
                    reloadDtg(sql, dtg_report)
                Case "Returned"
                    sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`,r.`NoCopies`, `DateReturned`  FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b  WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned' AND MONTH(DateReturned) = MONTH(Now())"
                    reloadDtg(sql, dtg_report)
                Case "Overdue"
                    sql = "SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND Remarks='Overdue' AND  MONTH(DueDate) = MONTH(Now())"
                    reloadDtg(sql, dtg_report)
                Case "Read"
                    sql = "SELECT `VisitorsId`, `Name`, `Office`, `AccessionNo`, `BookTitle`, `Description`, `TimeBorrowed`, `TimeReturned`, `Status` FROM `tblreader` WHERE Status='Returned' AND  MONTH(`TimeReturned`) = MONTH(Now())"
                    reloadDtg(sql, dtg_report)
            End Select

        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnTotalbooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalbooks.Click
        sql = "SELECT * FROM `tblbooknumber`"
        reloadDtg(sql, dtg_report)
    End Sub
    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, `Remark`, `BookPrice` as 'Price', `BookQuantity` as 'No.Copies', `Status`,`OverAllQty` FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`"
        reloadDtg(sql, dtg_report)
        rdoDaily.Checked = False
        rdoWeekly.Checked = False
        rdoMonthly.Checked = False
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click


        Try
            Dim fName As String = ""
            Using sfd As New SaveFileDialog
                sfd.Title = "Save As"
                sfd.OverwritePrompt = True
                sfd.FileName = fName
                sfd.DefaultExt = ".xlsx"
                sfd.Filter = "Excel Workbook(*.xlsx)|"
                sfd.AddExtension = True
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkSheet.Columns.AutoFit()
            For i = 0 To dtg_report.RowCount - 2
                For j = 0 To dtg_report.ColumnCount - 1
                    For k As Integer = 1 To dtg_report.Columns.Count
                        xlWorkSheet.Cells(1, k) = dtg_report.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = dtg_report(j, i).Value.ToString()
                    Next
                Next
            Next

            If sfd.ShowDialog() = DialogResult.OK Then
                xlWorkSheet.SaveAs(sfd.FileName)
                xlWorkBook.Close()
                xlApp.Quit()
                ReleaseObject(xlApp)
                ReleaseObject(xlWorkBook)
                ReleaseObject(xlWorkSheet)
                MsgBox("All data has been Exported Successfully", MsgBoxStyle.Information, "== Notice ==")
            End If
            End Using
        Catch ex As Exception


            MsgBox("An error occurred ! " & vbCrLf & "Error code: " & ex.Message)
        End Try
    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click
        sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, `Remark`, `BookPrice` as 'Price', `BookQuantity` as 'No.Copies', `Status`,`OverAllQty` FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` AND b.Remark='Donated Book'"
        reloadDtg(sql, dtg_report)
        rdoDaily.Checked = False
        rdoWeekly.Checked = False
        rdoMonthly.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, `Remark`, `BookPrice` as 'Price', `BookQuantity` as 'No.Copies', `Status`,`OverAllQty` FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` AND b.Remark='Purchased Book'"
        reloadDtg(sql, dtg_report)
        rdoDaily.Checked = False
        rdoWeekly.Checked = False
        rdoMonthly.Checked = False
    End Sub
End Class