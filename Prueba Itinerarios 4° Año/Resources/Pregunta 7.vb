Public Class Pregunta_7
    Private Sub Btnsig7_Click(sender As Object, e As EventArgs) Handles Btnsig7.Click
        checkok()
        Me.Hide()
        Pregunta_8.Show()

    End Sub

    Private Sub Btnat7_Click(sender As Object, e As EventArgs) Handles Btnat7.Click


        Me.Hide()
        Pregunta_6.Show()

    End Sub

    Sub checkok()
        If Cbproy.Checked Then
            res7(0) = 33
        End If
        If Cbparl.Checked Then
            res7(1) = 34
        End If
        If Cbtecl.Checked Then
            res7(2) = 35
        End If
        If Cbcamar.Checked Then
            res7(3) = 36
        End If
        If Cbmouse.Checked Then
            res7(4) = 37
        End If
        If Cbmonit.Checked Then
            res7(5) = 38
        End If
        If Cbpen.Checked Then
            res7(6) = 39
        End If
        If Cbmic.Checked Then
            res7(7) = 40
        End If

    End Sub
End Class