Public Class updates

    Private Sub FlowButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton1.Click
        Me.Hide()
    End Sub

    Private Sub FlowTheme1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowTheme1.Click

    End Sub
    Private Sub updates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        read()

    End Sub
    Sub read()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/Updates.txt")

        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim hi As String = sr.ReadToEnd()

        RichTextBox1.Text = hi
    End Sub
End Class