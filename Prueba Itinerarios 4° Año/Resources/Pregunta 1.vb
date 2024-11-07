Public Class Pregunta_1
    Private Sub Btnsip1_Click(sender As Object, e As EventArgs) Handles Btnsip1.Click
        pre = 1
        control()


        Me.Hide()
        Pregunta_2.Show()

    End Sub
    Sub control()
        res = 0
        If Rbop1.Checked Then
            res = 1
        End If
        If Rbop2.Checked Then
            res = 2
        End If
        If Rbop3.Checked Then
            res = 3
        End If
        yatieneres()
        cargares()

    End Sub


End Class