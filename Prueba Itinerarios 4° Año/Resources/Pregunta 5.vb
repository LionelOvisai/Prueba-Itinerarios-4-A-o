Public Class Pregunta_5
    Private Sub Btnsig5_Click(sender As Object, e As EventArgs) Handles Btnsig5.Click
        pre = 5
        controlysig()



    End Sub
    Sub controlysig()
        res = 0
        If Rbop1.Checked Then
            res = 25
        End If
        If Rbop2.Checked Then
            res = 26
        End If
        If Rbop3.Checked Then
            res = 27
        End If
        If Rbop4.Checked Then
            res = 28
        End If
        If res = 0 Then
            MessageBox.Show("Debe Seleccionar una opcion antes de continuar", "Error en No Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        yatieneres()
        cargares()
        Me.Hide()
        Pregunta_6.Show()
    End Sub

    Private Sub Btnat5_Click(sender As Object, e As EventArgs) Handles Btnat5.Click
        Me.Hide()
        Pregunta_4.Show()

    End Sub


End Class