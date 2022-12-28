Public Class frmListVisitor
    Private Sub frmListVisitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "Select `id`, `fname`, `lname`, `address`, `cnumber`, `timedate`, `office`, `category`, `sex` FROM `tblcustomer` WHERE Date(`timedate`) = CURDATE()"
        reloadDtg(sql, dtgList)
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        sql = "Select `id`, `fname`, `lname`, `address`, `cnumber`, `timedate`, `office`, `category`, `sex` FROM `tblcustomer` WHERE id Like '%" & txtSearch.Text & "%' OR `fname` Like '%" & txtSearch.Text & "%'  OR  `lname` Like '%" & txtSearch.Text & "%' "
        reloadDtg(sql, dtgList)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            frmReqRead.txtVisitorId.Text = dtgList.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnadd2_Click(sender As Object, e As EventArgs) Handles btnadd2.Click
        Try
            frmRead.txtVisitorId.Text = dtgList.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class