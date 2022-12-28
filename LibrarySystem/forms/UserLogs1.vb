Public Class UserLogs1

    Private Sub UserLogs1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT `Fullname`, `User_name`, `UserRole`,`LogDate`, `LogMode`, `LogId` FROM `tbllogs` l, `tbluser` u WHERE l.`UserId`=u.`UserId`"
        reloadDtg(sql, dtg_logs)
        dtg_logs.Columns(5).Visible = False
    End Sub

    Private Sub dtg_logs_Click(sender As Object, e As EventArgs) Handles dtg_logs.Click
        With dtg_logs
            txtf.Text = .CurrentRow.Cells(0).Value
            txtu.Text = .CurrentRow.Cells(1).Value
            txtur.Text = .CurrentRow.Cells(2).Value
            txtdl.Text = .CurrentRow.Cells(3).Value
            Textlm.Text = .CurrentRow.Cells(4).Value
            cid.Text = .CurrentRow.Cells(5).Value
        End With
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        sql = "DELETE FROM `tbllogs` WHERE LogId= '" & cid.Text & "'"

        deletes(sql)

        MsgBox("Record has been deleted!", MsgBoxStyle.Information)

        Call UserLogs1_Load(sender, e)

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
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
                For i = 0 To dtg_logs.RowCount - 2
                    For j = 0 To dtg_logs.ColumnCount - 1
                        For k As Integer = 1 To dtg_logs.Columns.Count
                            xlWorkSheet.Cells(1, k) = dtg_logs.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = dtg_logs(j, i).Value.ToString()
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
End Class