Public Class Pregunta_10
    Private Sub Btnat10_Click(sender As Object, e As EventArgs) Handles Btnat10.Click
        Me.Hide()
        Pregunta_9.Show()

    End Sub

    Private Sub Btnfinal_Click(sender As Object, e As EventArgs) Handles Btnfinal.Click
        If MessageBox.Show("Esta Seguro/a que desea finalizar el Examen?", "Finalizacion Examen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Tbpre10.Text = "" Then
                restext(1) = "Vacio"
            Else
                restext(1) = Tbpre10.Text
            End If
            cargares3gra()
            cargarestext(0)
            cargarestext(1)
            cargares7()

            origin = 1
            Me.Hide()
            Respuestas.Show()
        End If
    End Sub

    Private Sub Pregunta_10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tbpre10.Select()
    End Sub


End Class