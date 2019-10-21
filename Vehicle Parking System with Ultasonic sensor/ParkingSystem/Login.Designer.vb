<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.FlatGroupBox1 = New ParkingSystem.FlatGroupBox()
        Me.cmdLogin = New ParkingSystem.FlatButton()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.FlatLabel3 = New ParkingSystem.FlatLabel()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.FlatLabel2 = New ParkingSystem.FlatLabel()
        Me.FlatLabel1 = New ParkingSystem.FlatLabel()
        Me.FlatAlertBox2 = New ParkingSystem.FlatAlertBox()
        Me.FlatAlertBox1 = New ParkingSystem.FlatAlertBox()
        Me.FlatClose1 = New ParkingSystem.FlatClose()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdRegister = New ParkingSystem.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Controls.Add(Me.FlatAlertBox2)
        Me.FormSkin1.Controls.Add(Me.FlatAlertBox1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(344, 362)
        Me.FormSkin1.TabIndex = 1
        Me.FormSkin1.Text = "Parking System"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.cmdRegister)
        Me.FlatGroupBox1.Controls.Add(Me.cmdLogin)
        Me.FlatGroupBox1.Controls.Add(Me.txtPass)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel3)
        Me.FlatGroupBox1.Controls.Add(Me.txtUser)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel2)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel1)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(320, 248)
        Me.FlatGroupBox1.TabIndex = 3
        '
        'cmdLogin
        '
        Me.cmdLogin.BackColor = System.Drawing.Color.Transparent
        Me.cmdLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdLogin.Location = New System.Drawing.Point(179, 182)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Rounded = False
        Me.cmdLogin.Size = New System.Drawing.Size(106, 41)
        Me.cmdLogin.TabIndex = 9
        Me.cmdLogin.Text = "Login"
        Me.cmdLogin.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtPass.Location = New System.Drawing.Point(36, 133)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(247, 27)
        Me.txtPass.TabIndex = 8
        Me.txtPass.UseSystemPasswordChar = True
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(33, 117)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(56, 13)
        Me.FlatLabel3.TabIndex = 7
        Me.FlatLabel3.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtUser.Location = New System.Drawing.Point(36, 75)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(247, 27)
        Me.txtUser.TabIndex = 6
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(33, 59)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(58, 13)
        Me.FlatLabel2.TabIndex = 1
        Me.FlatLabel2.Text = "Username"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.FlatLabel1.Location = New System.Drawing.Point(18, 19)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(51, 21)
        Me.FlatLabel1.TabIndex = 0
        Me.FlatLabel1.Text = "Login"
        '
        'FlatAlertBox2
        '
        Me.FlatAlertBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatAlertBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatAlertBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatAlertBox2.kind = ParkingSystem.FlatAlertBox._Kind.Info
        Me.FlatAlertBox2.Location = New System.Drawing.Point(0, 320)
        Me.FlatAlertBox2.Name = "FlatAlertBox2"
        Me.FlatAlertBox2.Size = New System.Drawing.Size(344, 42)
        Me.FlatAlertBox2.TabIndex = 2
        Me.FlatAlertBox2.Text = "FlatAlertBox2"
        Me.FlatAlertBox2.Visible = False
        '
        'FlatAlertBox1
        '
        Me.FlatAlertBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatAlertBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatAlertBox1.kind = ParkingSystem.FlatAlertBox._Kind.[Error]
        Me.FlatAlertBox1.Location = New System.Drawing.Point(0, 317)
        Me.FlatAlertBox1.Name = "FlatAlertBox1"
        Me.FlatAlertBox1.Size = New System.Drawing.Size(344, 42)
        Me.FlatAlertBox1.TabIndex = 1
        Me.FlatAlertBox1.Text = "FlatAlertBox1"
        Me.FlatAlertBox1.Visible = False
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(314, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'cmdRegister
        '
        Me.cmdRegister.BackColor = System.Drawing.Color.Transparent
        Me.cmdRegister.BaseColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.cmdRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdRegister.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmdRegister.Location = New System.Drawing.Point(22, 182)
        Me.cmdRegister.Name = "cmdRegister"
        Me.cmdRegister.Rounded = False
        Me.cmdRegister.Size = New System.Drawing.Size(106, 41)
        Me.cmdRegister.TabIndex = 10
        Me.cmdRegister.Text = " Register"
        Me.cmdRegister.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 362)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents FlatAlertBox2 As FlatAlertBox
    Friend WithEvents FlatAlertBox1 As FlatAlertBox
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents cmdLogin As FlatButton
    Friend WithEvents txtPass As TextBox
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmdRegister As FlatButton
End Class
