Public Class Q1

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Dim fore As Color = Color.Black

        If radRed.Checked Then
            fore = Color.Red
        ElseIf radGreen.Checked Then
            fore = Color.Green
        ElseIf radBlue.Checked Then
            fore = Color.Blue
        End If

        lblResult.ForeColor = fore
        lblResult.Text = "Hello, " & txtName.Text

        txtName.Text = ""
        txtName.Focus()

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        radRed.Checked = True
        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
