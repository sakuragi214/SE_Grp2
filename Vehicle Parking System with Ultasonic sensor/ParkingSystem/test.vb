Imports System.IO
Imports System.IO.Ports

Public Class test
    Dim value1 As Integer
    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Close()
        SerialPort1.PortName = "COM4"
        SerialPort1.BaudRate = "9600"
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default
        SerialPort1.Open()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim s As String
        s = TextBox2.Text
        Dim somestring() As String
        somestring = s.Split(New Char() {","c})
        TextBox1.Text = somestring(0)
        TextBox2.Text = ""
    End Sub
    Private Sub DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim mydata As String = ""
            mydata = SerialPort1.ReadExisting()
            If TextBox1.InvokeRequired Then
                TextBox2.Invoke(DirectCast(Sub() TextBox2.Text &= mydata, MethodInvoker))
            Else
                TextBox2.Text &= mydata
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If InStr(TextBox1.Text, "on") Then
            CheckBox1.Checked = True
        End If
        If InStr(TextBox1.Text, "off") Then
            CheckBox1.Checked = False
        End If
    End Sub
End Class