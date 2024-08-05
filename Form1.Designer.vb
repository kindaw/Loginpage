<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.chk_Showpassword = New System.Windows.Forms.CheckBox()
        Me.btb_Login = New System.Windows.Forms.Button()
        Me.lbl_Usernam = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.lbl_Login = New System.Windows.Forms.Label()
        Me.lbl_WelcomeBack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chk_Showpassword
        '
        Me.chk_Showpassword.AutoSize = True
        Me.chk_Showpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Showpassword.Location = New System.Drawing.Point(85, 259)
        Me.chk_Showpassword.Name = "chk_Showpassword"
        Me.chk_Showpassword.Size = New System.Drawing.Size(136, 22)
        Me.chk_Showpassword.TabIndex = 0
        Me.chk_Showpassword.Text = "Show Password"
        Me.chk_Showpassword.UseVisualStyleBackColor = True
        '
        'btb_Login
        '
        Me.btb_Login.BackColor = System.Drawing.Color.BlueViolet
        Me.btb_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btb_Login.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btb_Login.Location = New System.Drawing.Point(85, 287)
        Me.btb_Login.Name = "btb_Login"
        Me.btb_Login.Size = New System.Drawing.Size(410, 53)
        Me.btb_Login.TabIndex = 1
        Me.btb_Login.Text = "Login"
        Me.btb_Login.UseVisualStyleBackColor = False
        '
        'lbl_Usernam
        '
        Me.lbl_Usernam.AutoSize = True
        Me.lbl_Usernam.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usernam.Location = New System.Drawing.Point(79, 170)
        Me.lbl_Usernam.Name = "lbl_Usernam"
        Me.lbl_Usernam.Size = New System.Drawing.Size(139, 31)
        Me.lbl_Usernam.TabIndex = 2
        Me.lbl_Usernam.Text = "Username"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.Location = New System.Drawing.Point(79, 218)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(134, 31)
        Me.lbl_Password.TabIndex = 3
        Me.lbl_Password.Text = "Password"
        '
        'txt_Username
        '
        Me.txt_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.ForeColor = System.Drawing.Color.Gray
        Me.txt_Username.Location = New System.Drawing.Point(216, 169)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(279, 35)
        Me.txt_Username.TabIndex = 4
        '
        'txt_Password
        '
        Me.txt_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.ForeColor = System.Drawing.Color.Gray
        Me.txt_Password.Location = New System.Drawing.Point(216, 218)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(279, 35)
        Me.txt_Password.TabIndex = 5
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'lbl_Login
        '
        Me.lbl_Login.AutoSize = True
        Me.lbl_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Login.Location = New System.Drawing.Point(79, 72)
        Me.lbl_Login.Name = "lbl_Login"
        Me.lbl_Login.Size = New System.Drawing.Size(142, 55)
        Me.lbl_Login.TabIndex = 6
        Me.lbl_Login.Text = "Login"
        '
        'lbl_WelcomeBack
        '
        Me.lbl_WelcomeBack.AutoSize = True
        Me.lbl_WelcomeBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_WelcomeBack.ForeColor = System.Drawing.Color.OliveDrab
        Me.lbl_WelcomeBack.Location = New System.Drawing.Point(111, 128)
        Me.lbl_WelcomeBack.Name = "lbl_WelcomeBack"
        Me.lbl_WelcomeBack.Size = New System.Drawing.Size(99, 16)
        Me.lbl_WelcomeBack.TabIndex = 7
        Me.lbl_WelcomeBack.Text = "Welcome Back"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 553)
        Me.Controls.Add(Me.lbl_WelcomeBack)
        Me.Controls.Add(Me.lbl_Login)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_Usernam)
        Me.Controls.Add(Me.btb_Login)
        Me.Controls.Add(Me.chk_Showpassword)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk_Showpassword As CheckBox
    Friend WithEvents btb_Login As Button
    Friend WithEvents lbl_Usernam As Label
    Friend WithEvents lbl_Password As Label
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents lbl_Login As Label
    Friend WithEvents lbl_WelcomeBack As Label
End Class
