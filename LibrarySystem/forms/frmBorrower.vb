Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmBorrower
    Dim connection As New MySqlConnection("server=localhost;user id=root;Password=admin;Persist Security Info=True;database=test;Convert Zero Datetime=True;database=dblibrary")
    Private dm As Bitmap
    Private getQuery As String = Nothing

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
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


                        create("INSERT INTO `tblborrower`( `Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear`, `BorrowerPhoto`, `BorrowerType`, `Stats`, `Application`) values ('" & txt_fname.Text & "','" & txt_lname.Text _
                               & "','" & txt_mname.Text & "','" & rch_address.Text _
                               & "','" & gender & "','" & txtContact.Text & "','" & txtCourse.Text _
                               & "','" & Path.GetFileName(PictureBox1.ImageLocation) & "','Student','Active', 'Approved')")
                        If result = True Then
                            MsgBox("New borrower has been added in the database.")
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
                Call btn_New_Click(sender, e)
            End If

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
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

                updates("update  tblborrower set  `Firstname`='" & txt_fname.Text _
                                  & "', `Lastname`='" & txt_lname.Text & "', `MiddleName`='" & txt_mname.Text _
                                  & "', `Address`='" & rch_address.Text & "', `Sex`='" & gender _
                                  & "', `ContactNo` ='" & txtContact.Text & "', `CourseYear`='" & txtCourse.Text.ToUpper() _
                                  & "', `BorrowerPhoto`='" & Path.GetFileName(PictureBox1.ImageLocation) & "', `BorrowerType`='Student' where `BorrowerId`='" & txt_bid.Text & "'")
                If result = True Then
                    MsgBox("Borrower has been updated in the database.")
                Else
                    MsgBox("Error")
                End If
                If txtPhoto.Text <> "" Then
                    File.Copy(txtPhoto.Text, Application.StartupPath & "\BorrowerPhoto\" & Path.GetFileName(PictureBox1.ImageLocation), True)
                End If
                Call btn_New_Click(sender, e)
            End If
        Catch ex As Exception





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

    Private Sub txt_bid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bid.TextChanged
        reloadtxt("SELECT * FROM `tblborrower` WHERE `BorrowerId` = '" & txt_bid.Text & "'")

        If dt.Rows.Count > 0 Then
            txt_fname.Text = dt.Rows(0).Item("Firstname")
            txt_lname.Text = dt.Rows(0).Item("Lastname")
            txt_mname.Text = dt.Rows(0).Item("MiddleName")
            rch_address.Text = dt.Rows(0).Item("Address")
            txtContact.Text = dt.Rows(0).Item("ContactNo")
            txtCourse.Text = dt.Rows(0).Item("CourseYear")
            PictureBox1.ImageLocation = Application.StartupPath & "\BorrowerPhoto\" & dt.Rows(0).Item("BorrowerPhoto")


            If dt.Rows(0).Item("Sex") = "Female" Then
                rdio_female.Checked = True
            Else
                rdio_male.Checked = True
            End If
            btnupdate.Enabled = True
            btn_delete.Enabled = True
            'btn_save.Enabled = False
        Else

            clearme()
            'btn_edit.Enabled = False
            btn_delete.Enabled = False
            'btn_save.Enabled = True 
            ''cleartext(grp_addBorrower)
        End If
    End Sub
    Public Sub clearme()
        txt_fname.Clear()
        txt_lname.Clear()
        txt_mname.Clear()
        rch_address.Clear()
        txtContact.Clear()
        txtCourse.Clear()
        txtPhoto.Clear()
    End Sub

    Private Sub frmBorrower_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT BorrowerId,`Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear` as 'Course/Year' FROM `tblborrower` WHERE Stats='Active' AND Application='Approved'"
        reloadDtg(sql, dtg_ABorrowLists)

        select_navigation("select BorrowerId from tblborrower")
        btn_delete.Enabled = False
        btnupdate.Enabled = False
    End Sub



    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        cleartext(Me)
        sql = "SELECT BorrowerId,`Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear`  as 'Course/Year' FROM `tblborrower`  WHERE Stats='Active' AND Application='Approved'"
        reloadDtg(sql, dtg_ABorrowLists)
        PictureBox1.ImageLocation = ""
        btn_delete.Enabled = False
    End Sub



    Private Sub txtPhoto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhoto.TextChanged
        PictureBox1.ImageLocation = txtPhoto.Text
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        If MessageBox.Show("Are you sure you want to delete this borrower?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            sql = "UPDATE `tblborrower` SET  `Stats` =  'NotActive', `Application`='NotActive' WHERE `BorrowerId` ='" & dtg_ABorrowLists.CurrentRow.Cells(0).Value & "'"
            result = deletes(sql)
            If result = True Then
                MessageBox.Show("Borrower has been deleted in the database.", "Success", MessageBoxButtons.OK)
            End If
            'Call frm_adduser_Load(sender, e)
            'cleartext(Me)
            Call btn_New_Click(sender, e)
        End If
    End Sub
    Dim bBtnClicked As Boolean = False
    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click


        If dtg_ABorrowLists.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 Then
            Libcard.TextBID.Text = dtg_ABorrowLists.CurrentRow.Cells(0).Value.ToString
            Libcard.TextBFN.Text = dtg_ABorrowLists.CurrentRow.Cells(1).Value.ToString
            Libcard.TextBLN.Text = dtg_ABorrowLists.CurrentRow.Cells(2).Value.ToString
            Libcard.TextBCN.Text = dtg_ABorrowLists.CurrentRow.Cells(6).Value.ToString
            Libcard.TextBAddress.Text = dtg_ABorrowLists.CurrentRow.Cells(4).Value.ToString



        End If
        reloadtxt("SELECT * FROM `tblborrower` WHERE `BorrowerId` = '" & txt_bid.Text & "'")

        If dt.Rows.Count > 0 Then
            Libcard.PictureBox1.ImageLocation = Application.StartupPath & "\BorrowerPhoto\" & dt.Rows(0).Item("BorrowerPhoto")
        End If
        With Libcard

            .Show()
            .Focus()
        End With


    End Sub


    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim font As New Font("Arial", 16, FontStyle.Regular)

    End Sub

    Private Sub dtg_ABorrowLists_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_ABorrowLists.CellContentClick
        Try
            txt_bid.Text = dtg_ABorrowLists.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtg_ABorrowLists_Click(sender As Object, e As EventArgs) Handles dtg_ABorrowLists.Click
        Try
            txt_bid.Text = dtg_ABorrowLists.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub
End Class