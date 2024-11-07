Public Class Administrador
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ds.Tables.Contains("evaluados") Then
            ds.Tables.Remove("evaluados")
        End If

        cmd.CommandText = "SELECT * FROM Alumnos"
        conectar()
        da.Fill(ds, "evaluados")
        desconectar()
        Cbaleva.DataSource = ds.Tables("evaluados")
        Cbaleva.DisplayMember = "Apenom"
        Cbaleva.ValueMember = "Idal"
    End Sub

    Private Sub Btvolver_Click(sender As Object, e As EventArgs) Handles Btvolver.Click
        Me.Close()
        InicioPrv.Show()
    End Sub

    Private Sub Bteva_Click(sender As Object, e As EventArgs) Handles Bteva.Click

        If Cbaleva.SelectedValue <> Nothing Then
            verexa = Cbaleva.SelectedValue
            nombre = Cbaleva.Text
            origin = 2
            Me.Hide()
            Respuestas.Show()
        Else
            MessageBox.Show("No ha seleccionado Ningun Alumno, o bien aun no existen cargas existenes de Evaluaciones, verificar", "Error en la carda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If

    End Sub
End Class