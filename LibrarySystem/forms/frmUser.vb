Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmUser

    Private cm As Bitmap
    Private gettQuery As String = Nothing

    
    Private Sub frm_adduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cbo_type.Text = "Administrator"
            reloadDtg("Select UserId as 'ID' ,Fullname as 'Name',User_name as 'UserName',UserRole as 'Type' From tbluser WHERE Status='Active'", dtg_listUser)
            dtg_listUser.Columns(0).Visible = False
            If lbl_id.Text = "id" Then

                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True

            Else
                btn_saveuser.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If


        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            With OpenFileDialog1

                'CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckFileExists = True


                'CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckPathExists = True


                'GET AND SET THE DEFAULT EXTENSION
                .DefaultExt = "jpg"


                'RETURN THE FILE LINKED TO THE LNK FILE
                .DereferenceLinks = True

                'SET THE FILE NAME TO EMPTY 
                .FileName = ""

                'FILTERING THE FILES
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"

                'SET THIS FOR ONE FILE SELECTION ONLY.
                .Multiselect = False



                'SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
                .RestoreDirectory = True

                'SET THE TITLE OF THE DIALOG BOX.
                .Title = "Select a file to open"

                'ACCEPT ONLY THE VALID WIN32 FILE NAMES.
                .ValidateNames = True

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Try
                        txtPhoto.Text = .FileName
                        'PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                        PictureBox1.ImageLocation = .FileName
                        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub txtPhoto_TextChanged(sender As Object, e As EventArgs) Handles txtPhoto.TextChanged

        PictureBox1.ImageLocation = txtPhoto.Text
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btn_saveuser_Click(sender As Object, e As EventArgs) Handles btn_saveuser.Click
        If txt_name.Text = "" Or txt_pass.Text = "" Or txt_username.Text = "" Then
            emptymessage()
        Else
            result = create("insert into tbluser (`Fullname`, `User_name`, `Pass`, `UserRole`, `UserPhoto`,`Status`) " _
             & "values('" & txt_name.Text & "','" & txt_username.Text _
             & "',sha1('" & txt_pass.Text & "'),'" & cbo_type.Text _
             & "','" & Path.GetFileName(PictureBox1.ImageLocation) & "','Active')")
            If txtPhoto.Text <> "" Then
                File.Copy(txtPhoto.Text, Application.StartupPath & "\BorrowerPhoto\" & Path.GetFileName(PictureBox1.ImageLocation), True)
            End If
            If result = True Then
                MsgBox("User has been saved in the database.")
            End If
            Call btn_close_Click(sender, e)
            txt_name.Clear()
            txt_pass.Clear()
            txt_username.Clear()
            txtPhoto.Clear()

        End If


    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            If txt_name.Text = "" Or txt_pass.Text = "" Or txt_username.Text = "" Then
                emptymessage()
            Else
                result = updates("update tbluser set Fullname = '" & txt_name.Text & "',User_name= '" & txt_username.Text _
                            & "',Pass= sha1('" & txt_pass.Text & "'),UserRole= '" & cbo_type.Text _
                            & "', `UserPhoto`='" & Path.GetFileName(PictureBox1.ImageLocation) & "' where UserId = " & lbl_id.Text)
                If result = True Then
                    MsgBox("User has been updated in the database.")
                End If
                If txtPhoto.Text <> "" Then
                    File.Copy(txtPhoto.Text, Application.StartupPath & "\BorrowerPhoto\" & Path.GetFileName(PictureBox1.ImageLocation), True)
                End If
                Call btn_close_Click(sender, e)
                txt_name.Clear()
                txt_pass.Clear()
                txt_username.Clear()
                txtPhoto.Clear()

            End If
            ref()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try

            If MessageBox.Show("Are you sure you want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                'result = deletes("delete from tbluser where UserId = '" & lbl_id.Text & "'")
                result = updates("update tbluser set Status='NotActive' where UserId = " & lbl_id.Text)
                If result = True Then
                    MessageBox.Show("User has been deleted in the database.", "Success", MessageBoxButtons.OK)
                End If
                'Call frm_adduser_Load(sender, e)
                txt_name.Clear()
                txt_pass.Clear()
                txt_username.Clear()
                txtPhoto.Clear()
                Call btn_close_Click(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        lbl_id.Text = "id"
        Call frm_adduser_Load(sender, e)
        txt_name.Clear()
        txt_pass.Clear()
        txt_username.Clear()
        txtPhoto.Clear()
    End Sub

    Private Sub lbl_id_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_id.TextChanged
        Try

            reloadtxt("SELECT * FROM `tbluser` WHERE `UserId` = '" & lbl_id.Text & "'")

            If dt.Rows.Count > 0 Then
                txt_name.Text = dt.Rows(0).Item("Fullname")
                txt_username.Text = dt.Rows(0).Item("User_name")
                cbo_type.Text = dt.Rows(0).Item("UserRole")
                PictureBox1.ImageLocation = Application.StartupPath & "\BorrowerPhoto\" & dt.Rows(0).Item("UserPhoto")
            End If

            
            If lbl_id.Text = "id" Then

                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True

            Else
                btn_saveuser.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtg_listUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_listUser.CellContentClick
        
    End Sub

    Private Sub dtg_listUser_Click(sender As Object, e As EventArgs) Handles dtg_listUser.Click
        Try
            lbl_id.Text = dtg_listUser.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub
   
End Class