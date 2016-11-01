Imports System.Security.Cryptography
Imports System.Management
Imports System.Text
Imports System.IO
Public Class HWID

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub FlowButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton2.Click
        End
    End Sub

    Private Sub FlowButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton1.Click
        FlowButton1.Enabled = False
        'put you hwid here
        If TextBox1.Text = "" Then
            MsgBox("Enter HF username!")
            FlowButton1.Enabled = True
        Else
            Form1.Show()
            Me.Hide()
        End If

    End Sub
 
    Private Sub HWID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'CheckForUpdates()

    End Sub
    Public Sub CheckForUpdates()

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://mehbawts.com/Version.txt")

        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            MsgBox("You have the latest version.")
        Else : MsgBox("There is a new version, Downloading now.")
            System.Diagnostics.Process.Start("http://mehbawts.com/InfamousDDoS.rar")
            End
        End If
    End Sub


End Class