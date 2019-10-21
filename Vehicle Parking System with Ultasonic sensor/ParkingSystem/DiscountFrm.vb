Imports System.Data.SqlClient

Public Class DiscountFrm
    Dim Sql As String
    Dim conn As SqlConnection = New SqlConnection("Server=ASUS\SQLEXPRESS; Database=Parking; Integrated Security=true")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private Sub loadtype()
        conn.Open()
        Sql = "select * from DiscountTbl"
        cmd = New SqlCommand(Sql, conn)
        dr = cmd.ExecuteReader

        type.Items.Clear()

        Do While dr.Read = True
            type.Items.Add(dr.GetString(2))
        Loop
        conn.Close()
    End Sub
    Public Sub loaddiscount()
        conn.Open()
        Sql = "select * from DiscountTbl where DisType='" & type.SelectedItem & "'"
        cmd = New SqlCommand(Sql, conn)
        dr = cmd.ExecuteReader

        type.Items.Clear()

        Do While dr.Read = True
            Dim diss = (dr.GetString(1))
            Module1.discount = Integer.Parse(diss)
            MainMenu.txtdiscount.Text = Module1.discount.ToString + "%"
            MainMenu.txtdiscount.Visible = True
            MainMenu.Label8.Visible = True
        Loop
        conn.Close()
    End Sub
    Private Sub DiscountFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtype()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loaddiscount()
        Me.Close()
    End Sub
End Class