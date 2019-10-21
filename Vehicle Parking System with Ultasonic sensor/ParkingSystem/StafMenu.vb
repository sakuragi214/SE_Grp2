Imports System.Data.SqlClient
Public Class MainMenu
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

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtype()
        getcount()
        getsum()
        Timer1.Enabled = True
        Main.loadtogridOUT(dgvOut)
        Main.loadCategory(dgvCategory)
        Main.loadDisc(dgvDisc)
        Main.loadPen(dgvPen)
        dgvCategory.DefaultCellStyle.ForeColor = Color.Black
        dgvOut.DefaultCellStyle.ForeColor = Color.Black
        dgvPen.DefaultCellStyle.ForeColor = Color.Black
        dgvDisc.DefaultCellStyle.ForeColor = Color.Black
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

    Private Sub txtTypeIN_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtTypeIN.SelectedValueChanged
        loadprice()
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

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Main.Search(dgvOut, Search.Text)
    End Sub

    Private Sub dgvCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) 
        Dim index As Integer
        index = e.RowIndex
        Dim SelectedRow As DataGridViewRow
        SelectedRow = dgvCategory.Rows(index)

        vehicle.Text = SelectedRow.Cells(1).Value.ToString()
        price.Text = SelectedRow.Cells(2).Value.ToString()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) 
        If vehicle.Text = "" Or price.Text = "" Or price.Text = 0 Then
            MsgBox("All Fields Must Have Value!", MsgBoxStyle.Information, "Parking System")
        Else
            Main.Checker(dgvCategory, vehicle.Text, price.Text)
            Main.loadCategory(dgvCategory)
        End If
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) 
        'need no duplication data
        If (dgvCategory.SelectedRows.Count > 0) Then
            Main.UpdateDataCat(dgvCategory, vehicle.Text, price.Text, dgvCategory.CurrentRow.Cells(0).Value.ToString())
            Main.loadCategory(dgvCategory)
        Else
            MsgBox("Select A Column 1st", MsgBoxStyle.Information, "Parking System")
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) 
        Main.DeleteDataCat(dgvCategory, dgvCategory.CurrentRow.Cells(0).Value.ToString())
        Main.loadCategory(dgvCategory)
    End Sub



    Private Sub price_KeyPress(sender As Object, e As KeyPressEventArgs) 
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("You Can only Input number!", MsgBoxStyle.Exclamation, "Parking System")
            e.Handled = True
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) 
        vehicle.Text = ""
        price.Text = ""
    End Sub

    Private Sub cSave_Click(sender As Object, e As EventArgs) Handles cSave.Click
        If txtKdisc.Text = "" Or txtDisc.Text = "" Or txtDisc.Text = 0 Then
            MsgBox("All Fields Must Have Value!", MsgBoxStyle.Information, "Parking System")
        Else
            Main.CheckerDisc(dgvDisc, txtKdisc.Text, txtDisc.Text)
            Main.loadDisc(dgvDisc)
        End If
    End Sub

    Private Sub cUpdate_Click(sender As Object, e As EventArgs) Handles cUpdate.Click
        'need no duplication data
        If (dgvDisc.SelectedRows.Count > 0) Then
            Main.UpdateDataDisc(dgvDisc, txtKdisc.Text, txtDisc.Text, dgvDisc.CurrentRow.Cells(0).Value.ToString())
            Main.loadDisc(dgvDisc)
        Else
            MsgBox("Select A Column 1st", MsgBoxStyle.Information, "Parking System")
        End If
    End Sub

    Private Sub cDelete_Click(sender As Object, e As EventArgs) Handles cDelete.Click
        Main.DeleteDataDisc(dgvDisc, dgvDisc.CurrentRow.Cells(0).Value.ToString())
        Main.loadDisc(dgvDisc)
    End Sub

    Private Sub cClear_Click(sender As Object, e As EventArgs) Handles cClear.Click
        txtDisc.Text = ""
        txtKdisc.Text = ""
    End Sub

    Private Sub ccSave_Click(sender As Object, e As EventArgs) Handles ccSave.Click
        If txtPenT.Text = "" Or txtPenF.Text = "" Or txtPenF.Text = 0 Then
            MsgBox("All Fields Must Have Value!", MsgBoxStyle.Information, "Parking System")
        Else
            Main.CheckerPen(dgvPen, txtPenT.Text, txtPenF.Text)
            Main.loadPen(dgvPen)
        End If
    End Sub

    Private Sub ccUpdate_Click(sender As Object, e As EventArgs) Handles ccUpdate.Click
        'need no duplication data
        If (dgvPen.SelectedRows.Count > 0) Then
            Main.UpdateDataPen(dgvPen, txtPenT.Text, txtPenF.Text, dgvPen.CurrentRow.Cells(0).Value.ToString())
            Main.loadPen(dgvPen)
        Else
            MsgBox("Select A Column 1st", MsgBoxStyle.Information, "Parking System")
        End If
    End Sub

    Private Sub ccDelete_Click(sender As Object, e As EventArgs) Handles ccDelete.Click
        Main.DeleteDataPen(dgvPen, dgvPen.CurrentRow.Cells(0).Value.ToString())
        Main.loadPen(dgvPen)
    End Sub

    Private Sub ccClear_Click(sender As Object, e As EventArgs) Handles ccClear.Click
        txtPenF.Text = ""
        txtPenT.Text = ""
    End Sub
    Private Sub txtDisc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDisc.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("You Can only Input number!", MsgBoxStyle.Exclamation, "Parking System")
            e.Handled = True
        End If
    End Sub

    Private Sub txtPenF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPenF.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("You Can only Input number!", MsgBoxStyle.Exclamation, "Parking System")
            e.Handled = True
        End If
    End Sub


    Private Sub dgvDisc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisc.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectedRow As DataGridViewRow
        SelectedRow = dgvDisc.Rows(index)

        txtDisc.Text = SelectedRow.Cells(1).Value.ToString()
        txtKdisc.Text = SelectedRow.Cells(2).Value.ToString()
    End Sub


    Private Sub dgvPen_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPen.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectedRow As DataGridViewRow
        SelectedRow = dgvPen.Rows(index)

        txtPenT.Text = SelectedRow.Cells(1).Value.ToString()
        txtPenF.Text = SelectedRow.Cells(2).Value.ToString()
    End Sub

    Private Sub TabPage6_Click(sender As Object, e As EventArgs) Handles TabPage6.Click

    End Sub

    Private Sub OutDiscount_Click(sender As Object, e As EventArgs) Handles OutDiscount.Click
        DiscountFrm.Show()
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        PenaltyForm.Show()
    End Sub
End Class
