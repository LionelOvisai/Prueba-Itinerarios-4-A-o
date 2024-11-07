Public Class Respuestas
    Private Sub Btnfinal_Click(sender As Object, e As EventArgs) Handles Btnfinal.Click
        End


    End Sub

    Private Sub Respuestas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If origin = 1 Then
            Btnfinal.Visible = True
            Btvolvereva.Visible = False
            Lbresal.Text = "Respuestas Estudiante: " & nombre
        Else
            Btnfinal.Visible = False
            Btvolvereva.Visible = True
            Lbresal.Text = "Respuestas Estudiante: " & nombre
        End If

        origen()



        Dim tres As Integer = 1
        Dim siete As Integer = 1

        For i As Integer = 0 To ds.Tables("respuestas").Rows.Count - 1
            Select Case ds.Tables("respuestas").Rows(i).Item(1)
                Case 1
                    Tbr1.Text = ds.Tables("respuestas").Rows(i).Item(3)
                Case 2
                    Tbr2.Text = ds.Tables("respuestas").Rows(i).Item(3)
                Case 3
                    Select Case tres
                        Case 1
                            Tbr3a.Text = ds.Tables("respuestas").Rows(i).Item(3)
                            tres += 1
                        Case 2
                            Tbr3b.Text = ds.Tables("respuestas").Rows(i).Item(3)
                            tres += 1
                        Case 3
                            Tbr3c.Text = ds.Tables("respuestas").Rows(i).Item(3)
                            tres += 1
                        Case 4
                            Tbr3d.Text = ds.Tables("respuestas").Rows(i).Item(3)
                            tres = 1
                    End Select
                Case 4
                    Tbr4.Text = ds.Tables("respuestas").Rows(i).Item(3)
                Case 5
                    Tbr5.Text = ds.Tables("respuestas").Rows(3).Item(3)
                Case 6
                    Tbr6.Text = ds.Tables("respuestas").Rows(4).Item(3)
                Case 7
                    Select Case siete
                        Case 1
                            Tbr71.Text = ds.Tables("respuestas").Rows(i).Item(3)
                            siete += 1
                        Case 2
                            Tbr72.Text = ds.Tables("respuestas").Rows(i).Item(3)
                            siete += 1
                        Case 3
                            Tbr73.Text = ds.Tables("respuestas").Rows(i).Item(3)
                            siete += 1
                        Case 4
                            Tbr74.Text = ds.Tables("respuestas").Rows(i).Item(3)
                            siete += 1
                        Case 5
                            Tbr75.Text = ds.Tables("respuestas").Rows(i).Item(3)
                            siete += 1
                        Case 6
                            Tbr76.Text = ds.Tables("respuestas").Rows(i).Item(3)
                            siete += 1
                        Case 7
                            Tbr77.Text = ds.Tables("respuestas").Rows(i).Item(3)
                            siete += 1
                        Case 8
                            Tbr78.Text = ds.Tables("respuestas").Rows(i).Item(3)
                            siete = 1
                    End Select
                Case 8
                    Tbr8.Text = ds.Tables("respuestas").Rows(i).Item(3)
                Case 9
                    Tbr9.Text = ds.Tables("respuestas").Rows(i).Item(3)
                Case 10
                    Tbr10.Text = ds.Tables("respuestas").Rows(11).Item(3)
            End Select
        Next





    End Sub

    Sub origen()
        If ds.Tables.Contains("respuestas") Then
            ds.Tables.Remove("respuestas")
        End If
        If origin = 1 Then
            cmd.CommandText = "SELECT c.*, r.Detalle FROM Contest c INNER JOIN Respuestas r ON c.Idres = r.Idres WHERE c.Idal = " & ds.Tables("alumno").Rows(0).Item(0)
        Else
            cmd.CommandText = "SELECT c.*, r.Detalle FROM Contest c INNER JOIN Respuestas r ON c.Idres = r.Idres WHERE c.Idal = " & verexa
        End If
        conectar()
        da.Fill(ds, "respuestas")
        desconectar()

    End Sub

    Private Sub Btvolvereva_Click(sender As Object, e As EventArgs) Handles Btvolvereva.Click
        Me.Close()
        Administrador.Show()

    End Sub
End Class