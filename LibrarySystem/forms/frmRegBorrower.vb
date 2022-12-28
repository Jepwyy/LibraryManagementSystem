Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmRegBorrower
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txt_fname.Text = "" Or txt_lname.Text = "" _
            Or txt_mname.Text = "" Or txtCourse.Text = "" Then
                emptymessage()
            Else
                ''conditionin the gender of a borrower
                Dim gender As String
                If rdio_female.Checked = True Then
                    gender = "Female"
                Else
                    gender = "Male"
                End If

                If txt_fname.Text = "" Or txt_lname.Text = "" Then

                Else
                    reloadtext("SELECT * FROM `tblborrower` WHERE Firstname='" & txt_fname.Text & "' and Lastname= '" & txt_lname.Text & "'")
                    If dt.Rows.Count > 0 Then
                        MessageBox.Show("Student Name is already exist!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else


                        create("INSERT INTO `tblborrower`(`Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear`, `BorrowerPhoto`, `BorrowerType`, `Stats`, `Application`) values ('" & txt_fname.Text & "','" & txt_lname.Text _
                               & "','" & txt_mname.Text & "','" & rch_address.Text _
                               & "','" & gender & "','" & txtContact.Text & "','" & txtCourse.Text _
                               & "','" & Path.GetFileName(PictureBox1.ImageLocation) & "','Student','Active', 'Reviewing')")
                        If result = True Then

                            MessageBox.Show("New borrower has been added in the Borrower Request.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MessageBox.Show("Please notify the Librarian/Assistant to approved your request.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            UserPortalBooks.Show()
                            Me.Close()
                        Else
                            MsgBox("Error")
                        End If

                        If txtPhoto.Text <> "" Then
                            File.Copy(txtPhoto.Text, Application.StartupPath & "\BorrowerPhoto\" & Path.GetFileName(PictureBox1.ImageLocation), True)
                        End If

                    End If
                End If


                '''''''''''''''''''''''''''''''''''''''''''

                'Call frmBorrower_Load(sender, e)
                'txt_bid.Clear()

            End If
            Me.Close()

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try



    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
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
    Private Sub txtPhoto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhoto.TextChanged
        PictureBox1.ImageLocation = txtPhoto.Text
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click
        Me.Close()

    End Sub
End Class