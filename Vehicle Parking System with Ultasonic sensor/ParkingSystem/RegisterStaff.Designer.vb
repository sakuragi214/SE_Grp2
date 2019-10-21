<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterStaff
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ParkingSystem.FormSkin()
        Me.FlatGroupBox2 = New ParkingSystem.FlatGroupBox()
        Me.txtTime = New ParkingSystem.FlatLabel()
        Me.FlatLabel14 = New ParkingSystem.FlatLabel()
        Me.txtDate = New ParkingSystem.FlatLabel()
        Me.FlatLabel10 = New ParkingSystem.FlatLabel()
        Me.FlatGroupBox1 = New ParkingSystem.FlatGroupBox()
        Me.lblUsername = New ParkingSystem.FlatLabel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.FlatLabel9 = New ParkingSystem.FlatLabel()
        Me.lblConfirm = New ParkingSystem.FlatLabel()
        Me.lblEmail = New ParkingSystem.FlatLabel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.FlatLabel8 = New ParkingSystem.FlatLabel()
        Me.cmdBack = New ParkingSystem.FlatButton()
        Me.cmdReg = New ParkingSystem.FlatButton()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.FlatLabel6 = New ParkingSystem.FlatLabel()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.FlatLabel5 = New ParkingSystem.FlatLabel()
        Me.txtConPass = New System.Windows.Forms.TextBox()
        Me.FlatLabel4 = New ParkingSystem.FlatLabel()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.FlatLabel3 = New ParkingSystem.FlatLabel()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.FlatLabel2 = New ParkingSystem.FlatLabel()
        Me.txtMN = New System.Windows.Forms.TextBox()
        Me.FlatLabel1 = New ParkingSystem.FlatLabel()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.FlatLabel7 = New ParkingSystem.FlatLabel()
        Me.FormSkin1.SuspendLayout()
        Me.FlatGroupBox2.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox2)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(466, 604)
        Me.FormSkin1.TabIndex = 6
        Me.FormSkin1.Text = "Parking System"
        '
        'FlatGroupBox2
        '
        Me.FlatGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FlatGroupBox2.BaseColor = System.Drawing.Color.White
        Me.FlatGroupBox2.Controls.Add(Me.txtTime)
        Me.FlatGroupBox2.Controls.Add(Me.FlatLabel14)
        Me.FlatGroupBox2.Controls.Add(Me.txtDate)
        Me.FlatGroupBox2.Controls.Add(Me.FlatLabel10)
        Me.FlatGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox2.Location = New System.Drawing.Point(211, 0)
        Me.FlatGroupBox2.Name = "FlatGroupBox2"
        Me.FlatGroupBox2.ShowText = True
        Me.FlatGroupBox2.Size = New System.Drawing.Size(247, 45)
        Me.FlatGroupBox2.TabIndex = 17
        '
        'txtTime
        '
        Me.txtTime.AutoSize = True
        Me.txtTime.BackColor = System.Drawing.Color.Transparent
        Me.txtTime.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtTime.ForeColor = System.Drawing.Color.Black
        Me.txtTime.Location = New System.Drawing.Point(156, 17)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(0, 13)
        Me.txtTime.TabIndex = 3
        '
        'FlatLabel14
        '
        Me.FlatLabel14.AutoSize = True
        Me.FlatLabel14.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel14.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel14.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel14.Location = New System.Drawing.Point(121, 17)
        Me.FlatLabel14.Name = "FlatLabel14"
        Me.FlatLabel14.Size = New System.Drawing.Size(33, 13)
        Me.FlatLabel14.TabIndex = 2
        Me.FlatLabel14.Text = "Time:"
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.BackColor = System.Drawing.Color.Transparent
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtDate.ForeColor = System.Drawing.Color.Black
        Me.txtDate.Location = New System.Drawing.Point(46, 17)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(0, 13)
        Me.txtDate.TabIndex = 1
        '
        'FlatLabel10
        '
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel10.ForeColor = System.Drawing.Color.Black
        Me.FlatLabel10.Location = New System.Drawing.Point(11, 17)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(37, 13)
        Me.FlatLabel10.TabIndex = 0
        Me.FlatLabel10.Text = " Date:"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.lblUsername)
        Me.FlatGroupBox1.Controls.Add(Me.txtUsername)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel9)
        Me.FlatGroupBox1.Controls.Add(Me.lblConfirm)
        Me.FlatGroupBox1.Controls.Add(Me.lblEmail)
        Me.FlatGroupBox1.Controls.Add(Me.txtEmail)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel8)
        Me.FlatGroupBox1.Controls.Add(Me.cmdBack)
        Me.FlatGroupBox1.Controls.Add(Me.cmdReg)
        Me.FlatGroupBox1.Controls.Add(Me.txtContact)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel6)
        Me.FlatGroupBox1.Controls.Add(Me.txtAdd)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel5)
        Me.FlatGroupBox1.Controls.Add(Me.txtConPass)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel4)
        Me.FlatGroupBox1.Controls.Add(Me.txtPass)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel3)
        Me.FlatGroupBox1.Controls.Add(Me.txtLN)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel2)
        Me.FlatGroupBox1.Controls.Add(Me.txtMN)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel1)
        Me.FlatGroupBox1.Controls.Add(Me.txtFN)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel7)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(442, 546)
        Me.FlatGroupBox1.TabIndex = 0
        Me.FlatGroupBox1.Text = "Register"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(101, 201)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(0, 13)
        Me.lblUsername.TabIndex = 26
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtUsername.Location = New System.Drawing.Point(39, 218)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(228, 27)
        Me.txtUsername.TabIndex = 5
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.FlatLabel9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlatLabel9.Location = New System.Drawing.Point(36, 200)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(60, 15)
        Me.FlatLabel9.TabIndex = 24
        Me.FlatLabel9.Text = "Username"
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirm.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblConfirm.ForeColor = System.Drawing.Color.White
        Me.lblConfirm.Location = New System.Drawing.Point(142, 297)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(0, 13)
        Me.lblConfirm.TabIndex = 23
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(80, 439)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(0, 13)
        Me.lblEmail.TabIndex = 22
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtEmail.Location = New System.Drawing.Point(39, 455)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(228, 27)
        Me.txtEmail.TabIndex = 10
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.FlatLabel8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlatLabel8.Location = New System.Drawing.Point(36, 437)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(36, 15)
        Me.FlatLabel8.TabIndex = 20
        Me.FlatLabel8.Text = "Email"
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.Color.Transparent
        Me.cmdBack.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.cmdBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBack.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdBack.Location = New System.Drawing.Point(199, 491)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Rounded = False
        Me.cmdBack.Size = New System.Drawing.Size(106, 32)
        Me.cmdBack.TabIndex = 19
        Me.cmdBack.Text = "Back"
        Me.cmdBack.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmdReg
        '
        Me.cmdReg.BackColor = System.Drawing.Color.Transparent
        Me.cmdReg.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.cmdReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdReg.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdReg.Location = New System.Drawing.Point(311, 491)
        Me.cmdReg.Name = "cmdReg"
        Me.cmdReg.Rounded = False
        Me.cmdReg.Size = New System.Drawing.Size(106, 32)
        Me.cmdReg.TabIndex = 18
        Me.cmdReg.Text = "Register"
        Me.cmdReg.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtContact.Location = New System.Drawing.Point(39, 408)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(228, 27)
        Me.txtContact.TabIndex = 9
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.FlatLabel6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlatLabel6.Location = New System.Drawing.Point(36, 390)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(68, 15)
        Me.FlatLabel6.TabIndex = 16
        Me.FlatLabel6.Text = "Contact no."
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAdd.Location = New System.Drawing.Point(39, 360)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(364, 27)
        Me.txtAdd.TabIndex = 8
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlatLabel5.Location = New System.Drawing.Point(36, 342)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(49, 15)
        Me.FlatLabel5.TabIndex = 14
        Me.FlatLabel5.Text = "Address"
        '
        'txtConPass
        '
        Me.txtConPass.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtConPass.Location = New System.Drawing.Point(39, 313)
        Me.txtConPass.Name = "txtConPass"
        Me.txtConPass.Size = New System.Drawing.Size(228, 27)
        Me.txtConPass.TabIndex = 7
        Me.txtConPass.UseSystemPasswordChar = True
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlatLabel4.Location = New System.Drawing.Point(36, 295)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(103, 15)
        Me.FlatLabel4.TabIndex = 12
        Me.FlatLabel4.Text = "Confirm Password"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtPass.Location = New System.Drawing.Point(39, 266)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(228, 27)
        Me.txtPass.TabIndex = 6
        Me.txtPass.UseSystemPasswordChar = True
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlatLabel3.Location = New System.Drawing.Point(36, 248)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(57, 15)
        Me.FlatLabel3.TabIndex = 12
        Me.FlatLabel3.Text = "Password"
        '
        'txtLN
        '
        Me.txtLN.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtLN.Location = New System.Drawing.Point(37, 170)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(228, 27)
        Me.txtLN.TabIndex = 3
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlatLabel2.Location = New System.Drawing.Point(34, 152)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(58, 15)
        Me.FlatLabel2.TabIndex = 10
        Me.FlatLabel2.Text = "Lastname"
        '
        'txtMN
        '
        Me.txtMN.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtMN.Location = New System.Drawing.Point(37, 122)
        Me.txtMN.Name = "txtMN"
        Me.txtMN.Size = New System.Drawing.Size(228, 27)
        Me.txtMN.TabIndex = 2
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlatLabel1.Location = New System.Drawing.Point(34, 104)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(74, 15)
        Me.FlatLabel1.TabIndex = 8
        Me.FlatLabel1.Text = "Middlename"
        '
        'txtFN
        '
        Me.txtFN.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtFN.Location = New System.Drawing.Point(37, 71)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(228, 27)
        Me.txtFN.TabIndex = 1
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.FlatLabel7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlatLabel7.Location = New System.Drawing.Point(34, 53)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(59, 15)
        Me.FlatLabel7.TabIndex = 6
        Me.FlatLabel7.Text = "Firstname"
        '
        'RegisterStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 604)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterStaff"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatGroupBox2.ResumeLayout(False)
        Me.FlatGroupBox2.PerformLayout()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Friend WithEvents lblUsername As FlatLabel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents FlatLabel9 As FlatLabel
    Friend WithEvents lblConfirm As FlatLabel
    Friend WithEvents lblEmail As FlatLabel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents FlatLabel8 As FlatLabel
    Friend WithEvents cmdBack As FlatButton
    Friend WithEvents cmdReg As FlatButton
    Friend WithEvents txtContact As TextBox
    Friend WithEvents FlatLabel6 As FlatLabel
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents FlatLabel5 As FlatLabel
    Friend WithEvents txtConPass As TextBox
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents txtPass As TextBox
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents txtLN As TextBox
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents txtMN As TextBox
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents txtFN As TextBox
    Friend WithEvents FlatLabel7 As FlatLabel
    Friend WithEvents FlatGroupBox2 As FlatGroupBox
    Friend WithEvents txtTime As FlatLabel
    Friend WithEvents FlatLabel14 As FlatLabel
    Friend WithEvents txtDate As FlatLabel
    Friend WithEvents FlatLabel10 As FlatLabel
    Friend WithEvents Timer1 As Timer
End Class
