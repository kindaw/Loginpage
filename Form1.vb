Public Class Form1
    'dim correct username password
    Private corectUsername As String = "ratchavit"
    Private corectPassword As String = "10762"
    Private Function login(username As String, password As String) As Boolean
        If username = corectUsername AndAlso password = corectPassword Then
            Return True
        Else
            Return False
        End If
    End Function

#Region "Placeholder Text"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetPlaceholderText()
    End Sub

    Private Sub txt_Username_Enter(sender As Object, e As EventArgs) Handles txt_Username.Enter
        If txt_Username.Text = "Enter username" Then
            txt_Username.Text = ""
            txt_Username.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_Username_Leave(sender As Object, e As EventArgs) Handles txt_Username.Leave
        If String.IsNullOrWhiteSpace(txt_Username.Text) Then
            SetPlaceholderText()
        End If
    End Sub

    Private Sub txt_Password_Enter(sender As Object, e As EventArgs) Handles txt_Password.Enter
        If txt_Password.Text = "Enter password" Then
            txt_Password.Text = ""
            txt_Password.ForeColor = Color.Black
            txt_Password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txt_Password_Leave(sender As Object, e As EventArgs) Handles txt_Password.Leave
        If String.IsNullOrWhiteSpace(txt_Password.Text) Then
            txt_Password.Text = "Enter password"
            txt_Password.ForeColor = Color.Gray
            txt_Password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub SetPlaceholderText()
        txt_Username.Text = "Enter username"
        txt_Username.ForeColor = Color.Gray
        txt_Password.Text = "Enter password"
        txt_Password.ForeColor = Color.Gray
        txt_Password.UseSystemPasswordChar = False
    End Sub

#End Region

    Private Sub btb_Login_Click(sender As Object, e As EventArgs) Handles btb_Login.Click
        Dim username As String = txt_Username.Text
        Dim password As String = txt_Password.Text
        If login(username, password) Then
            MessageBox.Show("ล็อกอินสำเร็จ", "ผลลัพท์", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("ข้อมูลไม่ถูกต้อง", "ผลลัพท์", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub chk_Showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Showpassword.CheckedChanged
        txt_Password.UseSystemPasswordChar = Not chk_Showpassword.Checked
    End Sub
End Class
