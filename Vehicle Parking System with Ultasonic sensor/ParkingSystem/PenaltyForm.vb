Imports System.Data.SqlClient

Public Class PenaltyForm
    Dim Sql As String
    Dim conn As SqlConnection = New SqlConnection("Server=ASUS\SQLEXPRESS; Database=Parking; Integrated Security=true")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private Sub loadtype()
        conn.Open()
        Sql = "select * from PenaltyTbl"
        cmd = New SqlCommand(Sql, conn)
        dr = cmd.ExecuteReader

        type.Items.Clear()

        Do While dr.Read = True
            type.Items.Add(dr.GetString(1))
        Loop
        conn.Close()
    End Sub
    Public Sub loadpenalty()
        conn.Open()
        Sql = "select * from PenaltyTbl where PenaltyType='" & type.SelectedItem & "'"
        cmd = New SqlCommand(Sql, conn)
        dr = cmd.ExecuteReader

        type.Items.Clear()

        Do While dr.Read = True
            Dim diss = (dr.GetString(2))
            Module1.penalty = Integer.Parse(diss)
            MainMenu.txtpenalty.Text = Module1.penalty.ToString
            MainMenu.txtpenalty.Visible = True
            MainMenu.Label9.Visible = True
        Loop
        conn.Close()
    End Sub
    Private Sub PenaltyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtype()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadpenalty()
        Me.Close()
    End Sub
End Class