Public Class formsin
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        If input.Text = "" Or input.Text >= 181 Or input.Text <= -1 Then
            MsgBox("Tolong isi value input ! / input tidak sesuai kriteria!")
        Else
            Dim input1 As Integer
            Dim output1 As Integer
            input1 = input.Text
            output1 = 4 * input1 * (180 - input1) / 40500 - input1 * (180 - input1)
            result.Text = output1
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        input.Text = ""
        result.Text = ""
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class