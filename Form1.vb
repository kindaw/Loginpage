﻿Public Class Form1
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

    Private Sub txt_Username_TextChanged(sender As Object, e As EventArgs) Handles txt_Username.GotFocus

    End Sub

    Private Sub txt_Password_Enter(sender As Object, e As EventArgs) Handles txt_Password.GotFocus

    End Sub

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
