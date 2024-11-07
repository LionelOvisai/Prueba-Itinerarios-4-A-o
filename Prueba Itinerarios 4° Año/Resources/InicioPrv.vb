

Public Class InicioPrv

    Private Sub BtnCom_Click(sender As Object, e As EventArgs) Handles BtnCom.Click
        If TbApeNom.Text = "" Then
            MessageBox.Show("Debe Ingresar Apellido y Nombre antes de continuar", "Error, Ingrese datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If

        nombre = TbApeNom.Text

        controldupli(nombre)

        If ds.Tables("dupli").Rows.Count < 1 Then
            cmd.CommandText = "INSERT INTO Alumnos (Apenom) values ( '" & nombre & "')"
        Else
            MessageBox.Show("No puede Continuar, Ya exite un Alumno con ese Nombre", "Apellido y Nombre Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TbApeNom.Text = ""
            Exit Sub

        End If



        conectar()
        cmd.ExecuteNonQuery()
        desconectar()
        actual(TbApeNom.Text)

        Me.Hide()
        Pregunta_1.Show()



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        admin += 1
        If admin = 7 Then
            Gbadmin.Visible = True
        End If


    End Sub

    Private Sub Btadmin_Click(sender As Object, e As EventArgs) Handles Btadmin.Click
        If TbPassw.Text = "Ovisai24" Then
            Gbadmin.Visible = False
            TbPassw.Text = ""
            Me.Hide()
            Administrador.Show()
            admin = 0

        Else
            MessageBox.Show("Contraseña erronea", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Gbadmin.Visible = False
            TbPassw.Text = ""
            admin = 0
        End If
    End Sub

    Private Sub Btnfin_Click(sender As Object, e As EventArgs) Handles Btnfin.Click
        End

    End Sub
End Class