
Imports System.Text.RegularExpressions

Public Class RegisterStaff
    Public SQL As New SQLControl
    Public un As String
    Public Sub insert()
        Try
            Dim par As String
            par = "^([0-9a-zA-z]([-\.\w}*[0-9a-zA-z])*@([[0-9a-zA-z][-\w]*[0-9a-zA-z]\.)+[a-zA-Z]{2,9})$"
            If Regex.IsMatch(txtEmail.Text, par) = False Then
                MsgBox("Not Valid Email", MsgBoxStyle.Information, "Parking System")
            ElseIf lblEmail.Text = "Email Already Exist!" Then
                MsgBox("Email is already exist!", MsgBoxStyle.Information, "Parking System")
            ElseIf lblUsername.Text = "Username Already Exist!" Then
                MsgBox("Username is already exist!", MsgBoxStyle.Information, "Parking System")
            ElseIf lblConfirm.Text = "Password not match!" Or txtConPass.Text = "" Then
                MsgBox("Password not match!", MsgBoxStyle.Information, "Parking System")
            ElseIf txtFN.Text = "" Or txtLN.Text = "" Or txtEmail.Text = "" Or txtUsername.Text = "" Or txtPass.Text = "" Or txtMN.Text = "" Or txtContact.Text = "" Or txtConPass.Text = "" Then
                MsgBox("Please Fill all your important information", MsgBoxStyle.Information, "Parking System")
            Else


                SQL.AddParam("@first_name", txtFN.Text)
                SQL.AddParam("@last_name", txtLN.Text)
                SQL.AddParam("@email", txtEmail.Text)
                SQL.AddParam("@user_name", txtUsername.Text)
                SQL.AddParam("@password", MD5(txtPass.Text))
                SQL.AddParam("@middle_name", txtMN.Text)
                SQL.AddParam("@contact", txtContact.Text)
                SQL.AddParam("@address", txtAdd.Text)
                SQL.AddParam("@status", "Active")
                SQL.AddParam("@role", "Staff")
                SQL.AddParam("@register", txtDate.Text)


                txtFN.Text = ""
                txtConPass.Text = ""
                txtLN.Text = ""
                txtEmail.Text = ""
                txtUsername.Text = ""
                txtPass.Text = ""
                txtContact.Text = ""
                txtMN.Text = ""
                txtAdd.Text = ""
                lblConfirm.Text = ""
                lblEmail.Text = ""
                lblUsername.Text = ""



                SQL.ExecQuery("INSERT INTO AccountTbl(Firstname,Middlename,Lastname,Username,Password,Email,Address,Contactno,Role,Status,DateRegister) VALUES(@first_name,@middle_name,@last_name,@user_name,@password,@email,@address,@contact,@role,@status,@register);")
                MsgBox("Registered Successfully", MsgBoxStyle.Information, "Parking System")
                '   REPORT & ABOURT ON ERRORS

            End If
            If SQL.HasException(True) Then Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dt As Date = Date.Today
        dt.ToString("MM/dd/yyyy")
        Dim tm As Date = Date.Now.ToLongTimeString.ToString()
        txtDate.Text = dt
        txtTime.Text = tm
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.TextChanged
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub txtConPass_TextChanged(sender As Object, e As EventArgs) Handles txtConPass.TextChanged
        If txtPass.Text <> txtConPass.Text Then
            lblConfirm.Text = "Password not match!"
            lblConfirm.ForeColor = Color.Red
        Else
            lblConfirm.Text = ""
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        sqlquery("SELECT * From  AccountTbl WHERE Email='" & txtEmail.Text & "'")
        If dr.Read Then
            txtEmail.Text = dr.Item("Email")
            lblEmail.Text = "Email Already Exist!"
            lblEmail.ForeColor = Color.Red
        Else
            lblEmail.Text = ""

        End If
    End Sub

    Private Sub txtSN_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        sqlquery("SELECT * From AccountTbl WHERE Username='" & txtUsername.Text & "'")
        If dr.Read Then
            un = txtUsername.Text = dr.Item("Username")
            lblUsername.Text = "Username Already Exist!"
            lblUsername.ForeColor = Color.Red
        Else
            lblUsername.Text = ""

        End If
    End Sub

    Private Sub cmdBack_Click_1(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub cmdReg_Click(sender As Object, e As EventArgs) Handles cmdReg.Click
        insert()
    End Sub
End Class