Public Class Pregunta_4
    Private Sub Btnsig4_Click(sender As Object, e As EventArgs) Handles Btnsig4.Click
        pre = 4
        yatieneres()
        controlysig()




    End Sub
    Sub controlysig()
        res = 0

        If Rbverda.Checked Then
            res = 23
        End If
        If Rbfalso.Checked Then
            res = 24
        End If
        If res = 0 Then
            MessageBox.Show("Debe Seleccionar una opcion antes de continuar", "Error en No Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        yatieneres()
        cargares()
        Me.Hide()
        Pregunta_5.Show()
    End Sub
    Private Sub Btnat4_Click(sender As Object, e As EventArgs) Handles Btnat4.Click
        Me.Hide()
        Pregunta_3.Show()

    End Sub


End Class