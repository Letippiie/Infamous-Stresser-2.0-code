Public Class Music

    Private Sub FlowTheme1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowTheme1.Click

    End Sub
    Private Sub Music_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Hide()

    End Sub

    Private Sub FlowButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton1.Click
        WebBrowser1.Navigate("http://www.internet-radio.com/station/filth.fm/")
    End Sub

    Private Sub FlowButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton2.Click
        WebBrowser1.Navigate("http://google.com")
    End Sub

    Private Sub FlowButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton3.Click
        Me.Hide()
    End Sub
End Class