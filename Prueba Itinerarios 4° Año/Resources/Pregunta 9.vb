Public Class Pregunta_9
    Private Sub Btnat9_Click(sender As Object, e As EventArgs) Handles Btnat9.Click
        Me.Hide()
        Pregunta_8.Show()

    End Sub

    Private Sub Btnsig9_Click(sender As Object, e As EventArgs) Handles Btnsig9.Click
        If Tbpre9.Text = "" Then
            restext(0) = "Vacio"
        Else
            restext(0) = Tbpre9.Text
        End If

        Me.Hide()
        Pregunta_10.Show()

    End Sub

    Private Sub Pregunta_9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tbpre9.Select()
    End Sub
End Class