Imports Tulpep.NotificationWindow
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports System.IO


Public Class frmDashboard
    Dim conn As New MySqlConnection("server=localhost;user id=root;Password=admin;Persist Security Info=True;database=test;Convert Zero Datetime=True;database=dblibrary")


    Public Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        totalbooks()
        totalborrower1()
        totaluser1()
        totalvisit()
        chartss1()
        genderc()






        'reloadtxt("SELECT `DueDate` FROM `tblborrow`")

        ''If TextBox1.Text = Now() Then
        'Dim popup = New PopupNotifier
        'popup.TitleText = "tangina mo"
        'popup.ContentText = "gggggggg"
        'popup.Popup()
        'End If
    End Sub

    Sub chartss1()
        Chart1.ChartAreas(0).AxisX.LabelStyle.Interval = 1
        Chart1.ChartAreas(0).AxisX.MajorGrid.LineWidth = 0
        Chart1.ChartAreas(0).AxisY.MajorGrid.LineWidth = 0
        Chart1.ChartAreas(0).BackColor = Color.Transparent
        chart2.ChartAreas(0).BackColor = Color.Transparent

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 01", conn)
            lbl1.Text = cmd.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Jan", lbl1.Text)
            Dim cme As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 02", conn)
            lbl2.Text = cme.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Feb", lbl2.Text)
            Dim cmf As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 03", conn)
            lbl3.Text = cmf.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Mar", lbl3.Text)
            Dim cmg As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 04", conn)
            lbl4.Text = cmg.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Apr", lbl4.Text)
            Dim cmh As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 05", conn)
            lbl5.Text = cmh.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("May", lbl5.Text)
            Dim cmj As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 06", conn)
            lbl6.Text = cmj.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Jun", lbl6.Text)
            Dim cmk As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 07", conn)
            lbl7.Text = cmk.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Jul", lbl7.Text)
            Dim cml As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 08", conn)
            lbl8.Text = cml.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Aug", lbl8.Text)
            Dim cmz As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 09", conn)
            lbl9.Text = cmz.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Sept", lbl9.Text)
            Dim cmx As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 10", conn)
            lbl10.Text = cmx.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Oct", lbl10.Text)
            Dim cmv As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 11", conn)
            lbl11.Text = cmv.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Nov", lbl11.Text)
            Dim cmb As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 12", conn)
            lbl12.Text = cmb.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Dec", lbl12.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()


    End Sub
    Sub genderc()
        chart2.BackColor = Color.Transparent
        chart2.ChartAreas(0).BackColor = Color.Orange
        chart2.Legends(0).BackColor = Color.Transparent
        With Me.chart2
            .Legends.Clear()
            .Series.Clear()
            .ChartAreas.Clear()
        End With

        Dim areas1 As ChartArea = Me.chart2.ChartAreas.Add("Areas1")

        With areas1
        End With

        Dim series1 As Series = Me.chart2.Series.Add("Series1")
        conn.Open()

        With series1
            .ChartArea = areas1.Name
            .ChartType = SeriesChartType.Pie
            Dim cmp As New MySqlCommand("select count(`sex`) from tblcustomer WHERE sex = 'Female' AND Year(timedate) = '" & tbyr.Text & "' ", conn)
            lblm.Text = cmp.ExecuteScalar.ToString
            .Points.AddXY("Female", lblm.Text)
            Dim cmo As New MySqlCommand("select count(`sex`) from tblcustomer WHERE sex = 'Male' AND Year(timedate) = '" & tbyr.Text & "'", conn)
            lblf.Text = cmo.ExecuteScalar.ToString
            .Points.AddXY("Male", lblf.Text)
        End With
        conn.Close()

        Dim legends1 As Legend = Me.chart2.Legends.Add("Legends1")

    End Sub
    Sub totalbooks()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select count(`BookTitle`) from tblbooks ", conn)
            Label9.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub totalborrower1()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select count(`Firstname`) from tblborrower WHERE Stats='Active'", conn)
            Label10.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub totalvisit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select count(`fname`) from tblcustomer ", conn)
            Label11.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub totaluser1()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select count(`Fullname`) from tbluser ", conn)
            Label12.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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

    Private Sub btnbooks1_Click(sender As Object, e As EventArgs) Handles btnbooks1.Click
        With frmBooks
            .TopLevel = False
            Home.Guna2Panel4.Controls.Add(frmBooks)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnbooks2_Click(sender As Object, e As EventArgs) Handles btnbooks2.Click
        With frmBooks
            .TopLevel = False
            Home.Guna2Panel4.Controls.Add(frmBooks)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnborrowers1_Click(sender As Object, e As EventArgs) Handles btnborrowers1.Click
        With frmBorrower
            .TopLevel = False
            Home.Guna2Panel4.Controls.Add(frmBorrower)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnborrowers2_Click(sender As Object, e As EventArgs) Handles btnborrowers2.Click
        With frmBorrower
            .TopLevel = False
            Home.Guna2Panel4.Controls.Add(frmBorrower)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnv1_Click(sender As Object, e As EventArgs) Handles btnv1.Click
        With frmLogsuser
            .TopLevel = False
            Home.Guna2Panel4.Controls.Add(frmLogsuser)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnv2_Click(sender As Object, e As EventArgs) Handles btnv2.Click
        With frmLogsuser
            .TopLevel = False
            Home.Guna2Panel4.Controls.Add(frmLogsuser)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnu1_Click(sender As Object, e As EventArgs) Handles btnu1.Click
        With frmUser
            .TopLevel = False
            Home.Guna2Panel4.Controls.Add(frmUser)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnu2_Click(sender As Object, e As EventArgs) Handles btnu2.Click
        With frmUser
            .TopLevel = False
            Home.Guna2Panel4.Controls.Add(frmUser)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub yrs_Click(sender As Object, e As EventArgs) Handles yrs.Click
        Me.Chart1.Series("Visitors").Points.Clear()


        Try
            conn.Open()

            Dim cmd As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 01", conn)
            lbl1.Text = cmd.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Jan", lbl1.Text)
            Dim cme As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 02", conn)
            lbl2.Text = cme.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Feb", lbl2.Text)
            Dim cmf As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 03", conn)
            lbl3.Text = cmf.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Mar", lbl3.Text)
            Dim cmg As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 04", conn)
            lbl4.Text = cmg.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Apr", lbl4.Text)
            Dim cmh As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 05", conn)
            lbl5.Text = cmh.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("MAy", lbl5.Text)
            Dim cmj As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 06", conn)
            lbl6.Text = cmj.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Jun", lbl6.Text)
            Dim cmk As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 07", conn)
            lbl7.Text = cmk.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Jul", lbl7.Text)
            Dim cml As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 08", conn)
            lbl8.Text = cml.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Aug", lbl8.Text)
            Dim cmz As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 09", conn)
            lbl9.Text = cmz.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Sept", lbl9.Text)
            Dim cmx As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 10", conn)
            lbl10.Text = cmx.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Oct", lbl10.Text)
            Dim cmv As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 11", conn)
            lbl11.Text = cmv.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Nov", lbl11.Text)
            Dim cmb As New MySqlCommand("select count(`fname`) from tblcustomer WHERE Year(timedate) = '" & tbyr.Text & "'AND Month(timedate) = 12", conn)
            lbl12.Text = cmb.ExecuteScalar.ToString
            Me.Chart1.Series("Visitors").Points.AddXY("Dec", lbl12.Text)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub tbyr_TextChanged(sender As Object, e As EventArgs) Handles tbyr.TextChanged


    End Sub
End Class