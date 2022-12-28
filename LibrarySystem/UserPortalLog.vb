
Public Class UserPortalLog

    Private Sub Userlog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = "Time : " & Format(Now(), "hh:mm:ss tt")
        lblDate.Text = "Date : " & Format(Now(), "MM/dd/yyyy")


        Dim ampm As String = Format(Now, "tt")
        Dim checkdate As Integer
        Dim checkmin As String = DatePart("n", Now)
        Dim checkhour As String = DatePart("h", Now)

        If checkmin < 10 Then
            checkmin = 0 & checkmin
        End If

        checkdate = checkhour & checkmin


        Try


            'Select Case ampm
            '    Case "AM"
            '        If checkdate >= 830 And checkdate <= 1130 Then
            '            ToolStripButton1.Enabled = True
            '            ToolStripButton2.Enabled = True
            '            ToolStripButton3.Enabled = True
            '            'MenuToolStripMenuItem.Enabled = True
            '        Else
            '            ToolStripButton1.Enabled = False
            '            ToolStripButton2.Enabled = False
            '            ToolStripButton3.Enabled = False
            '            'MenuToolStripMenuItem.Enabled = False
            '        End If
            '    Case "PM"
            '        If checkdate >= 1330 And checkdate <= 1730 Then
            '            ToolStripButton1.Enabled = True
            '            ToolStripButton2.Enabled = True
            '            ToolStripButton3.Enabled = True
            '            'MenuToolStripMenuItem.Enabled = True
            '        Else
            '            ToolStripButton1.Enabled = False
            '            ToolStripButton2.Enabled = False
            '            ToolStripButton3.Enabled = False
            '            'MenuToolStripMenuItem.Enabled = False
            '        End If

            'End Select



        Catch ex As Exception

        End Try
    End Sub
    



    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        Try
            If txbfname.Text = "" Or txblname.Text = "" Or txbaddress.Text = "" Or txbcnumber.Text = "" Then
                emptymessage()
            End If
            reloadtext("SELECT * FROM `tblcustomer` WHERE Date(`timedate`) = CURDATE() AND fname='" & txbfname.Text & "' and lname= '" & txblname.Text & "'")
            If dt.Rows.Count > 0 Then

                If MessageBox.Show("You already logged in this day.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                    UserPortalBooks.Show()
                    UserPortalBooks.txbFname.Text = txbfname.Text
                    UserPortalBooks.txbLname.Text = txblname.Text

                    Me.Hide()
                End If
                txbfname.Clear()
                txblname.Clear()
                txbcnumber.Clear()
                txbaddress.Clear()
                txboffice.Clear()
                rdio_C.Checked = False
                rdio_E.Checked = False
                rdio_F.Checked = False
                rdio_J.Checked = False
                rdio_m.Checked = False
                rdio_O.Checked = False
                rdio_Pr.Checked = False
                rdio_Pw.Checked = False
                rdio_S.Checked = False
                rdio_Sc.Checked = False

            Else
                If MessageBox.Show("Are you sure you want to save this data?", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    If txbfname.Text = "" Or txblname.Text = "" Then
                        emptymessage()
                    Else


                        Dim Category As String
                        If rdio_E.Checked = True Then
                            Category = "ELEM"
                        ElseIf rdio_J.Checked = True Then
                            Category = "JHS"
                        ElseIf rdio_S.Checked = True Then
                            Category = "SHS"
                        ElseIf rdio_C.Checked = True Then
                            Category = "COLL"
                        ElseIf rdio_Pr.Checked = True Then
                            Category = "PROF"
                        ElseIf rdio_Pw.Checked = True Then
                            Category = "PWD"
                        ElseIf rdio_Sc.Checked = True Then
                            Category = "SENIOR CITIZEN"
                        ElseIf rdio_O.Checked = True Then
                            Category = "OUT OF SCHOOL"
                        End If

                        Dim Gender As String

                        If rdio_F.Checked = True Then
                            Gender = "Female"
                        Else
                            Gender = "Male"
                        End If

                        result = create("INSERT INTO `tblcustomer`(`fname`, `lname`, `address`, `cnumber`, `office`, `category`, `sex`, `timedate`) " _
                         & "values('" & txbfname.Text & "','" & txblname.Text _
                         & "',('" & txbaddress.Text & "'),'" & txbcnumber.Text _
                         & "',('" & txboffice.Text & "'),'" & Category _
                         & "',('" & Gender & "'),Now())")
                        If result = True Then
                            MsgBox("User has been saved in the database.")
                            UserPortalBooks.Show()
                            UserPortalBooks.txbFname.Text = txbfname.Text
                            UserPortalBooks.txbLname.Text = txblname.Text
                            Me.Hide()


                        Else
                            MsgBox("Error")
                        End If

                        txbfname.Clear()
                        txblname.Clear()
                        txbcnumber.Clear()
                        txbaddress.Clear()
                        txboffice.Clear()
                        rdio_C.Checked = False
                        rdio_E.Checked = False
                        rdio_F.Checked = False
                        rdio_J.Checked = False
                        rdio_m.Checked = False
                        rdio_O.Checked = False
                        rdio_Pr.Checked = False
                        rdio_Pw.Checked = False
                        rdio_S.Checked = False
                        rdio_Sc.Checked = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try


    End Sub




    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        With Home
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ToolStriplogin_Click_1(sender As Object, e As EventArgs) Handles ToolStriplogin.Click
        LoginForm1.Show()
        LoginForm1.Focus()
    End Sub




    Private Sub txbcnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbcnumber.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub UserPortalLog_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        loaderrs.Close()

    End Sub
End Class