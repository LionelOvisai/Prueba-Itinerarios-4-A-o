Public Class Pregunta_2
    Private Sub Btnsip1_Click(sender As Object, e As EventArgs) Handles Btnsig2.Click

        pre = 2

        control()
        Me.Hide()
        Pregunta_3.Show()

    End Sub
    Sub control()
        res = 0
        If Rbop1.Checked Then
            res = 4
        End If
        If Rbop2.Checked Then
            res = 5
        End If
        If Rbop3.Checked Then
            res = 6
        End If
        yatieneres()
        cargares()

    End Sub

    Private Sub Btnat2_Click(sender As Object, e As EventArgs) Handles Btnat2.Click
        Me.Hide()
        Pregunta_1.Show()

    End Sub
End Class