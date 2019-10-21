Imports System.Data.SqlClient
Public Class StaffMenu
    Public SQL As New SQLControl
    Public Main As New MainClass
    Private Sub SaveINData()

        SQL.ExecQuery("insert into TransactionTbl(PlateNumber,VehicleType,DateIn,TimeIn) values('" & txtPlateIN.Text & "','" & txtTypeIN.SelectedItem & "','" & txtDateIN.Text & "','" & txtTimeIN.Text & "') ")
        MsgBox("Added", MsgBoxStyle.Information, "Parking System")
        txtPlateIN.Clear()
        txtPlateIN.Focus()
        If SQL.HasException(True) Then Exit Sub

    End Sub
    Private Sub getcount()
        Try

            sqlquery("select count(TransID) from TransactionTbl where TimeOut is null")

            If dr.Read Then
                slot = dr(0).ToString()
                lblSlot.Text = "Total Vehicle Inside: " + slot.ToString
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub getsum()
        Try

            sqlquery("select NumberofSlot from SlotTbl")
            If dr.Read Then
                total = dr(0).ToString()
            End If
            Dim slott As Integer
            slott = Integer.Parse(slot)
            Dim totall As Integer
            totall = Integer.Parse(total)
            summ = totall - slott
            lblTotal.Text = "Total Free Slot: " + summ.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub InSave_Click(sender As Object, e As EventArgs) Handles InSave.Click
        Try
            If txtPlateIN.Text = "" Then
                MsgBox("Please input Plate Number or Conduction Sticker!", MsgBoxStyle.Information, "Parking System")
            Else
                SaveINData()
                Main.loadtogridOUT(dgvOut)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvOut_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOut.CellClick
        Try

            sqlquery("select * from TransactionTbl where TransID = '" & dgvOut.CurrentRow.Cells(0).Value.ToString() & "'")
            If dr.Read Then
                tid = dr(0).ToString
                txtPlate.Text = dr(3).ToString()
                txtType.Text = dr(2).ToString()
                txtDin.Text = dr(4).ToString()
                txtTin.Text = dr(6).ToString()
                gethours()
                getamount()
                gettotalpayment()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub loadtype()

        Try

            sqlquery("SELECT * FROM CategoryTbl")
            While dr.Read
                Dim type = dr.Item("VehicleType")
                txtTypeIN.Items.Add(type)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub price_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("You Can only Input number!", MsgBoxStyle.Exclamation, "Parking System")
            e.Handled = True
        End If
    End Sub
    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Main.Search(dgvOut, Search.Text)
    End Sub
    Private Sub loadprice()
        Dim dt As New DataTable

        Try
            sqlquery("select * from CategoryTbl where VehicleType='" & txtTypeIN.SelectedItem & "'")
            While dr.Read
                txtPriceIN.Text = dr.Item("Price")
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub getamount()
        Try
            sqlquery("select Price from CategoryTbl where VehicleType= '" & txtType.Text & "'")
            If dr.Read Then
                prices = dr(0).ToString()
                txtPrice.Text = prices
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub gettotalpayment()
        Dim pay = txtPrice.Text
        Dim hr = txtTHours.Text
        Dim bayad = pay * hr
        txtAmount.Text = bayad.ToString

    End Sub
    Private Sub getpayment()
        Dim amounts = txtAmount.Text
        Dim am As Integer
        am = Integer.Parse(amounts)
        Dim pay As Integer
        Dim pp = txtPayment.Text
        pay = Integer.Parse(pp)
        Dim ss As Integer
        ss = Integer.Parse(ss)
        ss = pay - am
        txtChange.Text = ss.ToString
    End Sub
    Private Sub gethours()
        Dim starttime As String
        Dim endtime As String
        Dim startdate As String
        Dim enddate As String
        startdate = txtDin.Text
        enddate = txtDout.Text
        Dim stdate As Date = Convert.ToDateTime(startdate)
        Dim edate As Date = Convert.ToDateTime(enddate)
        starttime = txtTin.Text
        endtime = txtTout.Text
        Dim sttime As DateTime = Convert.ToDateTime(starttime)
        Dim etime As DateTime = Convert.ToDateTime(endtime)
        Dim ttstime As DateTime = Convert.ToDateTime(startdate + " " + starttime)
        Dim ttetime As DateTime = Convert.ToDateTime(enddate + " " + endtime)
        Dim result As Integer
        result = DateDiff(DateInterval.Hour, ttstime, ttetime)
        txtTHours.Text = result.ToString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTimeIN.Text = TimeOfDay
        txtDateIN.Text = Date.Today
        txtDout.Text = Date.Today
        txtTout.Text = TimeOfDay

    End Sub
    Private Sub StaffMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtype()
        getcount()
        getsum()
        Timer1.Enabled = True
        Main.loadtogridOUT(dgvOut)
        dgvOut.DefaultCellStyle.ForeColor = Color.Black
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Me.Close()
        Login.Show()
    End Sub
End Class