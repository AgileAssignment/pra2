Public Class Q2

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        picLight.Image = My.Resources.Chrysanthemum
    End Sub

    Private Sub btnCaution_Click(sender As Object, e As EventArgs) Handles btnCaution.Click
        picLight.Image = My.Resources.Desert

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        picLight.Image = My.Resources.Hydrangeas
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class