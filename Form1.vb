Imports System.Data
Imports Npgsql



Public Class Form1
    Dim lv As ListViewItem
    Dim Selected As String

    Private Sub PopListView()
        ListView1.Clear()

        With ListView1
            .View = View.Details
            .GridLines = True
            .Columns.Add("ID", 40)
            .Columns.Add("Last Name", 110)
            .Columns.Add("First Name", 110)
            .Columns.Add("Course", 110)
        End With

        openCon()
        sql = "Select * from tblstudinfo"
        cmd = New NpgsqlCommand(sql, cn)
        dr = cmd.ExecuteReader

        Do While dr.Read() = True
            lv = New ListViewItem(dr("studno").ToString)
            lv.SubItems.Add(dr("studlast"))
            lv.SubItems.Add(dr("studfirst"))
            lv.SubItems.Add(dr("studcourse"))
            ListView1.Items.Add(lv)
        Loop
        cn.Close()

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopListView()
    End Sub


End Class
