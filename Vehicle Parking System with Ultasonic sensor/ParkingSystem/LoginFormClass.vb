

Public Class LoginFormClass

    Public uname As String
    Public upass As String
    Public fname As String
    Public lname As String
    Public usertype As String
    Public status As String
    Public id As Integer
    Public time As String

    Public Sub New(ByVal uname As String, ByVal upass As String)
        Me.uname = uname
        Me.upass = upass

    End Sub


    Public Sub userverify()
        Try
            sqlquery("SELECT * from AccountTbl where Username='" & uname & "' and Password='" & MD5(upass) & "' AND Status = 'Active'")

            If dr.Read Then
                fname = dr.Item("Firstname")
                lname = dr.Item("Lastname")
                usertype = dr.Item("Role")
                status = dr.Item("Status")

                id = dr.Item(0)
                verified()
            Else

                Login.FlatAlertBox1.Show()
                Login.FlatAlertBox1.Text = "Wrong Username or Password"
                Login.Timer1.Start()
                Login.Timer1.Interval = 2000

            End If
            dr.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub verified()
        With Login
            .txtuser.ResetText()
            .txtpass.ResetText()
        End With
        If usertype.Equals("Staff") And status.Equals("Active") Then
            Login.Hide()
            StaffMenu.Show()
            MsgBox("Welcome " & fname & " " & lname & " !", MsgBoxStyle.Information, "Parking System")
            retriveprivilegedoctor(id)
        ElseIf usertype.Equals("Staff") And status.Equals("Deactivated") Then

            Login.FlatAlertBox2.Show()
            Login.FlatAlertBox2.Text = "Your Account is not Active Yet!"
            Login.Timer1.Start()
            Login.Timer1.Interval = 2000
        Else
        End If
        If usertype.Equals("Admin") And status.Equals("Active") Then
            Login.Hide()
            MainMenu.Show()

            MsgBox("Welcome Admin " & fname & " " & lname & " !", MsgBoxStyle.Information, "Parking System")
            retriveprivilegeadmin(id)
        End If


    End Sub
    Public Sub retriveprivilegedoctor(ByVal userid As Integer)
        Try
            uname = "Staff: " & fname & " " & lname
            sqlquery("SELECT * FROM AccountTbl WHERE UserID =" & userid & "")
            While dr.Read
                'StaffMenu.fgtInfo.Text = "• " & uname & " "
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub retriveprivilegeadmin(ByVal userid As Integer)
        Try
            uname = "Admin: " & fname & " " & lname
            sqlquery("SELECT * FROM AccountTbl WHERE UserID =" & userid & "")
            While dr.Read
                'MainMenu.fgtInfo.Text = "• " & uname & " "
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class

