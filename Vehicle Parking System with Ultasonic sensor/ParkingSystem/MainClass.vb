Imports System.Data.SqlClient
Public Class MainClass

    Public Sub loadtogridOUT(ByVal dgv As DataGridView)
        connect(database)
        Dim dt As New DataTable
        ' Dim nowdate As String

        'tamang format ng date string cap M!
        ' nowdate = Format(Date.Now, "yyyy/MM/dd")

        Try
            dt.Clear()

            Dim sqladapter As New SqlDataAdapter("SELECT TransID AS 'Transaction ID', PlateNumber AS 'Plate Number',VehicleType AS 'Vehicle Type',DateIN AS 'Date IN',TimeIN AS 'Time IN' FROM TransactionTbl", conn)

            sqladapter.Fill(dt)

            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        conn.Close()
    End Sub
    Public Sub loadDisc(ByVal dgv As DataGridView)
        connect(database)
        Dim dt As New DataTable
        ' Dim nowdate As String

        'tamang format ng date string cap M!
        ' nowdate = Format(Date.Now, "yyyy/MM/dd")

        Try
            dt.Clear()

            Dim sqladapter As New SqlDataAdapter("select DisID AS 'ID', Discount 'Discount per %', DisType AS 'Kind of discount' from DiscountTbl", conn)

            sqladapter.Fill(dt)

            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        conn.Close()
    End Sub
    Public Sub loadPen(ByVal dgv As DataGridView)
        connect(database)
        Dim dt As New DataTable
        ' Dim nowdate As String

        'tamang format ng date string cap M!
        ' nowdate = Format(Date.Now, "yyyy/MM/dd")

        Try
            dt.Clear()

            Dim sqladapter As New SqlDataAdapter("select PenaltyID As 'ID', PenaltyType As 'Penalty Type', PenaltyFee As 'Penalty Fee' from PenaltyTbl", conn)

            sqladapter.Fill(dt)

            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        conn.Close()
    End Sub
    Public Sub loadCategory(ByVal dgv As DataGridView)
        connect(database)
        Dim dt As New DataTable
        ' Dim nowdate As String

        'tamang format ng date string cap M!
        ' nowdate = Format(Date.Now, "yyyy/MM/dd")

        Try
            dt.Clear()

            Dim sqladapter As New SqlDataAdapter("SELECT CategoryID AS 'Category ID', VehicleType AS 'Vehicle Type', Price AS 'Price per hour' FROM CategoryTbl", conn)

            sqladapter.Fill(dt)

            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        conn.Close()
    End Sub
    Public Sub Search(ByVal dgv As DataGridView, ByVal search As String)
        connect(database)
        Dim dt As New DataTable

        Try
            dt.Clear()
            Dim sqladapter As New SqlDataAdapter("SELECT TransID AS 'Transaction ID', PlateNumber AS 'Plate Number',VehicleType AS 'Vehicle Type',DateIN AS 'Date IN',TimeIN AS 'Time IN' FROM TransactionTbl WHERE TransID LIKE '%" & search & "%' OR PlateNumber LIKE '%" & search & "%' ", conn)
            sqladapter.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        conn.Close()

    End Sub
    Public Sub Checker(ByVal dgv As DataGridView, ByVal vehicle As String, ByVal Price As String)
        Try


            sqlquery("SELECT * FROM CategoryTbl WHERE VehicleType = '" & vehicle & "' ")
            If dr.Read Then
                MsgBox("No Duplication!", MsgBoxStyle.Exclamation, "Parking System")
            Else

                SaveDataCat(dgv, vehicle, Price)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SaveDataCat(ByVal dgv As DataGridView, ByVal vehicle As String, ByVal Price As String)
        Try


            If Mode = "New" Then
                sqlquery("insert into CategoryTbl(VehicleType,Price) values('" & vehicle & "','" & Price & "')")

                MsgBox("Save Successfully!", MsgBoxStyle.Information, "Parking System")
                loadCategory(dgv)
                MainMenu.vehicle.Clear()
                MainMenu.price.Text = 0
                MainMenu.vehicle.Focus()
            Else
                MsgBox("This Record has already been saved", MsgBoxStyle.Exclamation, "Parking System")
                Mode = "New"
                MainMenu.vehicle.Clear()
                MainMenu.price.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CheckerUpdate(ByVal dgv As DataGridView, ByVal vehicle As String, ByVal Price As String, ByVal id As Integer)
        Try

            sqlquery("SELECT * FROM CategoryTbl WHERE VehicleType = '" & vehicle & "' ")
            If dr.Read Then
                MsgBox("This Record cannot be saved(NO DUPLICATION!)", MsgBoxStyle.Exclamation, "Parking System")
            Else
                UpdateDataCat(dgv, vehicle, Price, id)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub UpdateDataCat(ByVal dgv As DataGridView, ByVal vehicle As String, ByVal Price As String, ByVal id As Integer)
        Try
            '  If Mode = "New" Then
            'MessageBox.Show("This Record was not been Saved", "Error", MessageBoxButtons.OK)
            '  Else
            sqlquery("update CategoryTbl set VehicleType='" & vehicle & "',Price='" & Price & "' where CategoryID='" & id & "'")
            MsgBox("Update Successfully!", MsgBoxStyle.Information, "Parking System")
            loadCategory(dgv)
            MainMenu.vehicle.Clear()
            MainMenu.price.Text = 0
            MainMenu.vehicle.Focus()
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub DeleteDataCat(ByVal dgv As DataGridView, ByVal id As Integer)
        Try

            If MsgBox("Do you want to delete this record ?", MsgBoxStyle.OkCancel) = vbCancel Then

            ElseIf vbYes Then
                sqlquery("delete from CategoryTbl where CategoryID='" & id & "'")
                MsgBox("Delete Successfully!", MsgBoxStyle.Critical, "Parking System")
                loadCategory(dgv)
                MainMenu.vehicle.Clear()
                MainMenu.price.Text = 0
                MainMenu.vehicle.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CheckerPen(ByVal dgv As DataGridView, ByVal type As String, ByVal penalty As String)
        Try


            sqlquery("SELECT * FROM PenaltyTbl WHERE PenaltyType = '" & type & "' ")
            If dr.Read Then
                MsgBox("No Duplication!", MsgBoxStyle.Exclamation, "Parking System")
            Else

                SaveDataPen(dgv, type, penalty)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SaveDataPen(ByVal dgv As DataGridView, ByVal type As String, ByVal penalty As String)
        Try


            If Mode = "New" Then
                sqlquery("insert into PenaltyTbl(PenaltyType,PenaltyFee) values('" & type & "','" & penalty & "')")

                MsgBox("Save Successfully!", MsgBoxStyle.Information, "Parking System")
                loadPen(dgv)
                MainMenu.txtPenT.Clear()
                MainMenu.txtPenF.Text = 0
                MainMenu.txtPenT.Focus()
            Else
                MsgBox("This Record has already been saved", MsgBoxStyle.Exclamation, "Parking System")
                Mode = "New"
                MainMenu.txtDisc.Clear()
                MainMenu.txtKdisc.Text = 0

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CheckerUpdatePen(ByVal dgv As DataGridView, ByVal type As String, ByVal penalty As String, ByVal id As Integer)
        Try

            sqlquery("SELECT * FROM PenaltyTbl WHERE PenaltyType = '" & type & "' ")
            If dr.Read Then
                MsgBox("This Record cannot be saved(NO DUPLICATION!)", MsgBoxStyle.Exclamation, "Parking System")
            Else
                UpdateDataDisc(dgv, type, penalty, id)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub UpdateDataPen(ByVal dgv As DataGridView, ByVal type As String, ByVal penalty As String, ByVal id As Integer)
        Try
            '  If Mode = "New" Then
            'MessageBox.Show("This Record was not been Saved", "Error", MessageBoxButtons.OK)
            '  Else
            sqlquery("update PenaltyTbl set PenaltyType='" & type & "',PenaltyFee='" & penalty & "' where PenaltyID='" & id & "'")
            MsgBox("Update Successfully!", MsgBoxStyle.Information, "Parking System")
            loadPen(dgv)
            MainMenu.vehicle.Clear()
            MainMenu.price.Text = 0
            MainMenu.Focus()
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub DeleteDataPen(ByVal dgv As DataGridView, ByVal id As Integer)
        Try

            If MsgBox("Do you want to delete this record ?", MsgBoxStyle.OkCancel) = vbCancel Then

            ElseIf vbYes Then
                sqlquery("delete from PenaltyTbl where PenaltyID='" & id & "'")
                MsgBox("Delete Successfully!", MsgBoxStyle.Critical, "Parking System")
                loadPen(dgv)
                MainMenu.vehicle.Clear()
                MainMenu.price.Text = 0
                MainMenu.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub CheckerDisc(ByVal dgv As DataGridView, ByVal type As String, ByVal discount As String)
        Try


            sqlquery("SELECT * FROM DiscountTbl WHERE DisType = '" & type & "' ")
            If dr.Read Then
                MsgBox("No Duplication!", MsgBoxStyle.Exclamation, "Parking System")
            Else

                SaveDataDisc(dgv, type, discount)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SaveDataDisc(ByVal dgv As DataGridView, ByVal type As String, ByVal discount As String)
        Try


            If Mode = "New" Then
                sqlquery("insert into DiscountTbl(Discount,DisType) values('" & type & "','" & discount & "')")

                MsgBox("Save Successfully!", MsgBoxStyle.Information, "Parking System")
                loadDisc(dgv)
                MainMenu.txtKdisc.Clear()
                MainMenu.txtDisc.Text = 0
                MainMenu.txtKdisc.Focus()
            Else
                MsgBox("This Record has already been saved", MsgBoxStyle.Exclamation, "Parking System")
                Mode = "New"
                MainMenu.txtKdisc.Clear()
                MainMenu.txtDisc.Text = 0


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CheckerUpdateDisc(ByVal dgv As DataGridView, ByVal type As String, ByVal discount As String, ByVal id As Integer)
        Try

            sqlquery("SELECT * FROM DiscountTbl WHERE DisType = '" & type & "' ")
            If dr.Read Then
                MsgBox("This Record cannot be saved(NO DUPLICATION!)", MsgBoxStyle.Exclamation, "Parking System")
            Else
                UpdateDataDisc(dgv, type, discount, id)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub UpdateDataDisc(ByVal dgv As DataGridView, ByVal type As String, ByVal discount As String, ByVal id As Integer)
        Try
            '  If Mode = "New" Then
            'MessageBox.Show("This Record was not been Saved", "Error", MessageBoxButtons.OK)
            '  Else
            sqlquery("update DiscountTbl set Discount='" & discount & "',Distype='" & type & "' where DisID='" & id & "'")
            MsgBox("Update Successfully!", MsgBoxStyle.Information, "Parking System")
            loadDisc(dgv)
            MainMenu.txtKdisc.Clear()
            MainMenu.txtDisc.Text = 0
            MainMenu.txtKdisc.Focus()
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub DeleteDataDisc(ByVal dgv As DataGridView, ByVal id As Integer)
        Try

            If MsgBox("Do you want to delete this record ?", MsgBoxStyle.OkCancel) = vbCancel Then

            ElseIf vbYes Then
                sqlquery("delete from DiscountTbl where DisID='" & id & "'")
                MsgBox("Delete Successfully!", MsgBoxStyle.Critical, "Parking System")
                loadDisc(dgv)
                MainMenu.txtKdisc.Clear()
                MainMenu.txtDisc.Text = 0
                MainMenu.txtKdisc.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
