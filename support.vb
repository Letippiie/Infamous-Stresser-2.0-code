Imports System.Net.Mail

Public Class support

    Private Sub FlowButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton1.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Email!")
        Else

            Dim mail As New MailMessage()

            Dim SmtpServer As New SmtpClient
            SmtpServer.Credentials = New Net.NetworkCredential("youemail@gmail.com", "pass")
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.EnableSsl = True
            mail.To.Add("youemail@gmail.com")
            mail.From = New MailAddress("youemail@gmail.com")
            mail.Subject = "Issue"
            mail.Body = TextBox1.Text + "-------------------------" + RichTextBox1.Text
            SmtpServer.Send(mail)
            MsgBox("Sent", MsgBoxStyle.Information, "Sent")
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub FlowButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton2.Click
        Me.Hide()
    End Sub
End Class