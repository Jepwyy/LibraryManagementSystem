Public Class frmLogsuser

    Private Sub frmLogsuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT `fname`, `lname`, `address`, `cnumber`, `timedate`, `office`, `category`, `sex`, `id` FROM `tblcustomer`"
        reloadDtg(sql, dtg_logs)
        dtg_logs.Columns(8).Visible = False
    End Sub


    Private Sub dtg_logs_Click(sender As Object, e As EventArgs) Handles dtg_logs.Click
        With dtg_logs
            txtfname.Text = .CurrentRow.Cells(0).Value
            txtlname.Text = .CurrentRow.Cells(1).Value
            txtadd.Text = .CurrentRow.Cells(2).Value
            txtcn.Text = .CurrentRow.Cells(3).Value
            txtos.Text = .CurrentRow.Cells(5).Value
            txtac.Text = .CurrentRow.Cells(6).Value
            Textge.Text = .CurrentRow.Cells(7).Value
            Texttd.Text = .CurrentRow.Cells(4).Value
            cid.text = .CurrentRow.Cells(8).Value
        End With
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        sql = "DELETE FROM `tblcustomer` WHERE `id` = '" & cid.Text & "'"

        deletes(sql)

        MsgBox("Record has been deleted!", MsgBoxStyle.Information)

        Call frmLogsuser_Load(sender, e)
    End Sub

    Private Sub btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Export.Click
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