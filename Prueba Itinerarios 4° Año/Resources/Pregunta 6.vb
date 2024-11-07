Public Class Pregunta_6
    Private Sub Btnsig6_Click(sender As Object, e As EventArgs) Handles Btnsig6.Click
        pre = 6
        control()


    End Sub
    Sub control()
        res = 0
        If Rbop1.Checked Then
            res = 29
        End If
        If Rbop2.Checked Then
            res = 30
        End If
        If Rbop3.Checked Then
            res = 31
        End If
        If Rbop4.Checked Then
            res = 32
        End If
        If res = 0 Then
            MessageBox.Show("Debe Seleccionar una opcion antes de continuar", "Error en No Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        yatieneres()
        cargares()
        Me.Hide()
        Pregunta_7.Show()

    End Sub

    Private Sub Btnat6_Click(sender As Object, e As EventArgs) Handles Btnat6.Click
        Me.Hide()
        Pregunta_5.Show()

    End Sub


End Class