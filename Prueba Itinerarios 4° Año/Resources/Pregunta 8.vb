Public Class Pregunta_8
    Private Sub Btnat8_Click(sender As Object, e As EventArgs) Handles Btnat8.Click
        Me.Hide()
        Pregunta_7.Show()

    End Sub

    Private Sub Btnsig8_Click(sender As Object, e As EventArgs) Handles Btnsig8.Click
        pre = 8
        control()




    End Sub
    Sub control()
        res = 0
        If Rbop1.Checked Then
            res = 41
        End If
        If Rbop2.Checked Then
            res = 42
        End If
        If Rbop3.Checked Then
            res = 43
        End If
        If Rbop4.Checked Then
            res = 44
        End If
        If res = 0 Then
            MessageBox.Show("Debe Seleccionar una opcion antes de continuar", "Error en No Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        yatieneres()
        cargares()
        Me.Hide()
        Pregunta_9.Show()
    End Sub
End Class