Public Class tos

    Private Sub FlowButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton2.Click
        End
    End Sub

    Private Sub FlowButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowButton1.Click
        If CheckBox1.Checked = True Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("You must agree if you would like to use our tool.")
        End If
    End Sub
End Class