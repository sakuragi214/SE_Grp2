<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FormSkin1 = New ParkingSystem.FormSkin()
        Me.FlatTabControl1 = New ParkingSystem.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtPriceIN = New System.Windows.Forms.TextBox()
        Me.InSave = New ParkingSystem.FlatButton()
        Me.txtTimeIN = New System.Windows.Forms.TextBox()
        Me.txtDateIN = New System.Windows.Forms.TextBox()
        Me.FlatLabel12 = New ParkingSystem.FlatLabel()
        Me.FlatLabel11 = New ParkingSystem.FlatLabel()
        Me.FlatLabel9 = New ParkingSystem.FlatLabel()
        Me.txtTypeIN = New System.Windows.Forms.ComboBox()
        Me.FlatLabel8 = New ParkingSystem.FlatLabel()
        Me.txtPlateIN = New System.Windows.Forms.TextBox()
        Me.FlatLabel7 = New ParkingSystem.FlatLabel()
        Me.FlatGroupBox1 = New ParkingSystem.FlatGroupBox()
        Me.lblTotal = New ParkingSystem.FlatLabel()
        Me.lblSlot = New ParkingSystem.FlatLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtpenalty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FlatButton1 = New ParkingSystem.FlatButton()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvOut = New System.Windows.Forms.DataGridView()
        Me.txtTout = New System.Windows.Forms.TextBox()
        Me.txtDout = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.aa = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.txtTHours = New System.Windows.Forms.TextBox()
        Me.txtTin = New System.Windows.Forms.TextBox()
        Me.txtDin = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtPlate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OutDiscount = New ParkingSystem.FlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FlatButton2 = New ParkingSystem.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(1023, 507)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Parking System"
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.White
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(4, 48)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(1019, 459)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.txtPriceIN)
        Me.TabPage1.Controls.Add(Me.InSave)
        Me.TabPage1.Controls.Add(Me.txtTimeIN)
        Me.TabPage1.Controls.Add(Me.txtDateIN)
        Me.TabPage1.Controls.Add(Me.FlatLabel12)
        Me.TabPage1.Controls.Add(Me.FlatLabel11)
        Me.TabPage1.Controls.Add(Me.FlatLabel9)
        Me.TabPage1.Controls.Add(Me.txtTypeIN)
        Me.TabPage1.Controls.Add(Me.FlatLabel8)
        Me.TabPage1.Controls.Add(Me.txtPlateIN)
        Me.TabPage1.Controls.Add(Me.FlatLabel7)
        Me.TabPage1.Controls.Add(Me.FlatGroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1011, 411)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Vehicle Entry"
        '
        'txtPriceIN
        '
        Me.txtPriceIN.Enabled = False
        Me.txtPriceIN.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtPriceIN.Location = New System.Drawing.Point(611, 135)
        Me.txtPriceIN.Name = "txtPriceIN"
        Me.txtPriceIN.ReadOnly = True
        Me.txtPriceIN.Size = New System.Drawing.Size(169, 27)
        Me.txtPriceIN.TabIndex = 26
        '
        'InSave
        '
        Me.InSave.BackColor = System.Drawing.Color.Transparent
        Me.InSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.InSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.InSave.Location = New System.Drawing.Point(674, 328)
        Me.InSave.Name = "InSave"
        Me.InSave.Rounded = False
        Me.InSave.Size = New System.Drawing.Size(106, 32)
        Me.InSave.TabIndex = 25
        Me.InSave.Text = "Save"
        Me.InSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtTimeIN
        '
        Me.txtTimeIN.Enabled = False
        Me.txtTimeIN.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTimeIN.Location = New System.Drawing.Point(310, 240)
        Me.txtTimeIN.Name = "txtTimeIN"
        Me.txtTimeIN.ReadOnly = True
        Me.txtTimeIN.Size = New System.Drawing.Size(169, 27)
        Me.txtTimeIN.TabIndex = 24
        '
        'txtDateIN
        '
        Me.txtDateIN.Enabled = False
        Me.txtDateIN.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtDateIN.Location = New System.Drawing.Point(310, 188)
        Me.txtDateIN.Name = "txtDateIN"
        Me.txtDateIN.ReadOnly = True
        Me.txtDateIN.Size = New System.Drawing.Size(169, 27)
        Me.txtDateIN.TabIndex = 23
        '
        'FlatLabel12
        '
        Me.FlatLabel12.AutoSize = True
        Me.FlatLabel12.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel12.ForeColor = System.Drawing.Color.White
        Me.FlatLabel12.Location = New System.Drawing.Point(306, 218)
        Me.FlatLabel12.Name = "FlatLabel12"
        Me.FlatLabel12.Size = New System.Drawing.Size(56, 19)
        Me.FlatLabel12.TabIndex = 22
        Me.FlatLabel12.Text = "Time IN"
        '
        'FlatLabel11
        '
        Me.FlatLabel11.AutoSize = True
        Me.FlatLabel11.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel11.ForeColor = System.Drawing.Color.White
        Me.FlatLabel11.Location = New System.Drawing.Point(306, 166)
        Me.FlatLabel11.Name = "FlatLabel11"
        Me.FlatLabel11.Size = New System.Drawing.Size(56, 19)
        Me.FlatLabel11.TabIndex = 21
        Me.FlatLabel11.Text = "Date IN"
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel9.ForeColor = System.Drawing.Color.White
        Me.FlatLabel9.Location = New System.Drawing.Point(564, 140)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(41, 19)
        Me.FlatLabel9.TabIndex = 20
        Me.FlatLabel9.Text = "Price:"
        '
        'txtTypeIN
        '
        Me.txtTypeIN.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeIN.FormattingEnabled = True
        Me.txtTypeIN.Location = New System.Drawing.Point(309, 135)
        Me.txtTypeIN.Name = "txtTypeIN"
        Me.txtTypeIN.Size = New System.Drawing.Size(169, 28)
        Me.txtTypeIN.TabIndex = 19
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.FlatLabel8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlatLabel8.Location = New System.Drawing.Point(306, 117)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(73, 15)
        Me.FlatLabel8.TabIndex = 18
        Me.FlatLabel8.Text = "Vehicle Type"
        '
        'txtPlateIN
        '
        Me.txtPlateIN.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtPlateIN.Location = New System.Drawing.Point(309, 83)
        Me.txtPlateIN.Name = "txtPlateIN"
        Me.txtPlateIN.Size = New System.Drawing.Size(169, 27)
        Me.txtPlateIN.TabIndex = 17
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.FlatLabel7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlatLabel7.Location = New System.Drawing.Point(306, 65)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(139, 15)
        Me.FlatLabel7.TabIndex = 16
        Me.FlatLabel7.Text = "Plate/Conduction Sticker"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.lblTotal)
        Me.FlatGroupBox1.Controls.Add(Me.lblSlot)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.ForeColor = System.Drawing.Color.White
        Me.FlatGroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(229, 180)
        Me.FlatGroupBox1.TabIndex = 5
        Me.FlatGroupBox1.Text = "ParkingSystem Status"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.lblTotal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTotal.Location = New System.Drawing.Point(22, 51)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(162, 13)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Total number of Vehicle inside:"
        '
        'lblSlot
        '
        Me.lblSlot.AutoSize = True
        Me.lblSlot.BackColor = System.Drawing.Color.Transparent
        Me.lblSlot.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.lblSlot.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblSlot.Location = New System.Drawing.Point(22, 99)
        Me.lblSlot.Name = "lblSlot"
        Me.lblSlot.Size = New System.Drawing.Size(57, 13)
        Me.lblSlot.TabIndex = 6
        Me.lblSlot.Text = "FlatLabel1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.txtpenalty)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.FlatButton1)
        Me.TabPage2.Controls.Add(Me.txtdiscount)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.dgvOut)
        Me.TabPage2.Controls.Add(Me.txtTout)
        Me.TabPage2.Controls.Add(Me.txtDout)
        Me.TabPage2.Controls.Add(Me.txtAmount)
        Me.TabPage2.Controls.Add(Me.txtChange)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.aa)
        Me.TabPage2.Controls.Add(Me.txtPayment)
        Me.TabPage2.Controls.Add(Me.txtTHours)
        Me.TabPage2.Controls.Add(Me.txtTin)
        Me.TabPage2.Controls.Add(Me.txtDin)
        Me.TabPage2.Controls.Add(Me.txtPrice)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtType)
        Me.TabPage2.Controls.Add(Me.txtPlate)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.OutDiscount)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Search)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1011, 411)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Vehicle Exit"
        '
        'txtpenalty
        '
        Me.txtpenalty.Enabled = False
        Me.txtpenalty.ForeColor = System.Drawing.Color.Black
        Me.txtpenalty.Location = New System.Drawing.Point(180, 370)
        Me.txtpenalty.Name = "txtpenalty"
        Me.txtpenalty.ReadOnly = True
        Me.txtpenalty.Size = New System.Drawing.Size(100, 25)
        Me.txtpenalty.TabIndex = 91
        Me.txtpenalty.Text = "0"
        Me.txtpenalty.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(75, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 19)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Penalty:"
        Me.Label9.Visible = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(733, 230)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(105, 28)
        Me.FlatButton1.TabIndex = 89
        Me.FlatButton1.Text = "Add Penalty"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtdiscount
        '
        Me.txtdiscount.Enabled = False
        Me.txtdiscount.ForeColor = System.Drawing.Color.Black
        Me.txtdiscount.Location = New System.Drawing.Point(180, 332)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.ReadOnly = True
        Me.txtdiscount.Size = New System.Drawing.Size(100, 25)
        Me.txtdiscount.TabIndex = 88
        Me.txtdiscount.Text = "0"
        Me.txtdiscount.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(75, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 19)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Discount:"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 19)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Search:"
        '
        'dgvOut
        '
        Me.dgvOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOut.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.dgvOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOut.GridColor = System.Drawing.Color.Black
        Me.dgvOut.Location = New System.Drawing.Point(67, 56)
        Me.dgvOut.Name = "dgvOut"
        Me.dgvOut.ReadOnly = True
        Me.dgvOut.Size = New System.Drawing.Size(771, 160)
        Me.dgvOut.TabIndex = 85
        '
        'txtTout
        '
        Me.txtTout.Enabled = False
        Me.txtTout.ForeColor = System.Drawing.Color.Black
        Me.txtTout.Location = New System.Drawing.Point(388, 297)
        Me.txtTout.Name = "txtTout"
        Me.txtTout.ReadOnly = True
        Me.txtTout.Size = New System.Drawing.Size(100, 25)
        Me.txtTout.TabIndex = 84
        '
        'txtDout
        '
        Me.txtDout.Enabled = False
        Me.txtDout.ForeColor = System.Drawing.Color.Black
        Me.txtDout.Location = New System.Drawing.Point(388, 264)
        Me.txtDout.Name = "txtDout"
        Me.txtDout.ReadOnly = True
        Me.txtDout.Size = New System.Drawing.Size(100, 25)
        Me.txtDout.TabIndex = 83
        '
        'txtAmount
        '
        Me.txtAmount.Enabled = False
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(608, 297)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(100, 25)
        Me.txtAmount.TabIndex = 82
        '
        'txtChange
        '
        Me.txtChange.Enabled = False
        Me.txtChange.ForeColor = System.Drawing.Color.Black
        Me.txtChange.Location = New System.Drawing.Point(608, 335)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(100, 25)
        Me.txtChange.TabIndex = 81
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(517, 338)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 19)
        Me.Label19.TabIndex = 80
        Me.Label19.Text = "Change:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(294, 300)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 19)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "Time Out:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(294, 267)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 19)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "Date Out:"
        '
        'aa
        '
        Me.aa.AutoSize = True
        Me.aa.Location = New System.Drawing.Point(510, 303)
        Me.aa.Name = "aa"
        Me.aa.Size = New System.Drawing.Size(96, 19)
        Me.aa.TabIndex = 77
        Me.aa.Text = "Total Amount:"
        '
        'txtPayment
        '
        Me.txtPayment.ForeColor = System.Drawing.Color.Black
        Me.txtPayment.Location = New System.Drawing.Point(388, 335)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(123, 25)
        Me.txtPayment.TabIndex = 76
        '
        'txtTHours
        '
        Me.txtTHours.Enabled = False
        Me.txtTHours.ForeColor = System.Drawing.Color.Black
        Me.txtTHours.Location = New System.Drawing.Point(608, 264)
        Me.txtTHours.Name = "txtTHours"
        Me.txtTHours.ReadOnly = True
        Me.txtTHours.Size = New System.Drawing.Size(100, 25)
        Me.txtTHours.TabIndex = 75
        '
        'txtTin
        '
        Me.txtTin.Enabled = False
        Me.txtTin.ForeColor = System.Drawing.Color.Black
        Me.txtTin.Location = New System.Drawing.Point(180, 297)
        Me.txtTin.Name = "txtTin"
        Me.txtTin.ReadOnly = True
        Me.txtTin.Size = New System.Drawing.Size(100, 25)
        Me.txtTin.TabIndex = 74
        '
        'txtDin
        '
        Me.txtDin.Enabled = False
        Me.txtDin.ForeColor = System.Drawing.Color.Black
        Me.txtDin.Location = New System.Drawing.Point(180, 264)
        Me.txtDin.Name = "txtDin"
        Me.txtDin.ReadOnly = True
        Me.txtDin.Size = New System.Drawing.Size(100, 25)
        Me.txtDin.TabIndex = 73
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.Location = New System.Drawing.Point(608, 230)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(100, 25)
        Me.txtPrice.TabIndex = 72
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(297, 338)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 19)
        Me.Label18.TabIndex = 71
        Me.Label18.Text = "Payment:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(510, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 19)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Total Hours:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Time IN:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Date IN:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(510, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 19)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Price:"
        '
        'txtType
        '
        Me.txtType.Enabled = False
        Me.txtType.ForeColor = System.Drawing.Color.Black
        Me.txtType.Location = New System.Drawing.Point(388, 230)
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.Size = New System.Drawing.Size(100, 25)
        Me.txtType.TabIndex = 66
        '
        'txtPlate
        '
        Me.txtPlate.Enabled = False
        Me.txtPlate.ForeColor = System.Drawing.Color.Black
        Me.txtPlate.Location = New System.Drawing.Point(180, 230)
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.ReadOnly = True
        Me.txtPlate.Size = New System.Drawing.Size(100, 25)
        Me.txtPlate.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Vehicle Type:"
        '
        'OutDiscount
        '
        Me.OutDiscount.BackColor = System.Drawing.Color.Transparent
        Me.OutDiscount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.OutDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OutDiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.OutDiscount.Location = New System.Drawing.Point(733, 267)
        Me.OutDiscount.Name = "OutDiscount"
        Me.OutDiscount.Rounded = False
        Me.OutDiscount.Size = New System.Drawing.Size(105, 28)
        Me.OutDiscount.TabIndex = 63
        Me.OutDiscount.Text = "Add Discount"
        Me.OutDiscount.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Plate Number:"
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Search.Location = New System.Drawing.Point(121, 12)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(289, 27)
        Me.Search.TabIndex = 61
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1011, 411)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Profile"
        '
        'Timer1
        '
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.Red
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(877, 10)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton2.TabIndex = 27
        Me.FlatButton2.Text = "Log Out"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'StaffMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 507)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffMenu"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatTabControl1 As FlatTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Friend WithEvents lblTotal As FlatLabel
    Friend WithEvents lblSlot As FlatLabel
    Friend WithEvents txtPriceIN As TextBox
    Friend WithEvents InSave As FlatButton
    Friend WithEvents txtTimeIN As TextBox
    Friend WithEvents txtDateIN As TextBox
    Friend WithEvents FlatLabel12 As FlatLabel
    Friend WithEvents FlatLabel11 As FlatLabel
    Friend WithEvents FlatLabel9 As FlatLabel
    Friend WithEvents txtTypeIN As ComboBox
    Friend WithEvents FlatLabel8 As FlatLabel
    Friend WithEvents txtPlateIN As TextBox
    Friend WithEvents FlatLabel7 As FlatLabel
    Friend WithEvents txtpenalty As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvOut As DataGridView
    Friend WithEvents txtTout As TextBox
    Friend WithEvents txtDout As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtChange As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents aa As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents txtTHours As TextBox
    Friend WithEvents txtTin As TextBox
    Friend WithEvents txtDin As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtPlate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents OutDiscount As FlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Search As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FlatButton2 As FlatButton
End Class
