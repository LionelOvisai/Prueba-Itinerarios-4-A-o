Imports Microsoft.VisualBasic.Devices

Public Class Pregunta_3

    Private blnBotonPresionado As Boolean
    Dim ima As String


    Private Sub Pregunta_3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Habilitamos el arrastre para el control PictureBox2 (No lo tiene permitido en tiempo de diseño)
        PRO.AllowDrop = True
        PM.AllowDrop = True
        FAL.AllowDrop = True
        RAM.AllowDrop = True

        'Cargamos la imagen en el primer control que se encuentra dentro de la carpeta del programa

    End Sub

    Private Sub PbPRO_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PbPRO.MouseDown
        'Verificamos si se presionó el botón izquierdo del mouse.
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'Si existe o hay una imagen en el control
            '  If Not PbPRO.Image Is Nothing Then
            'Determinamos que el botón se encuentra presionado.
            blnBotonPresionado = True
            'End If
        End If
    End Sub

    Private Sub PbPRO_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PbPRO.MouseMove
        If blnBotonPresionado Then
            'Iniciamos el arrastre y permitimos que se pueda copiar o mover la imagen.
            ima = "PRO"
            PbPRO.DoDragDrop(PbPRO.Image, DragDropEffects.Move Or DragDropEffects.Copy)

        End If
        blnBotonPresionado = False
    End Sub

    Private Sub PRO_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PRO.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then

            e.Effect = DragDropEffects.Copy

        End If

    End Sub

    Private Sub PRO_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PRO.DragDrop
        'Asignamos la imagen al control PictureBoxPRO.
        PRO.Image = e.Data.GetData(DataFormats.Bitmap)
        recep3(1) = ima
        controlimarepet(1)
    End Sub

    Private Sub PbPM_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PbPM.MouseDown
        'Verificamos si se presionó el botón izquierdo del mouse.
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'Si existe o hay una imagen en el control
            '  If Not PbPRO.Image Is Nothing Then
            'Determinamos que el botón se encuentra presionado.
            blnBotonPresionado = True

        End If
    End Sub

    Private Sub PbPM_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PbPM.MouseMove
        If blnBotonPresionado Then
            'Iniciamos el arrastre y permitimos que se pueda copiar o mover la imagen.
            ima = "PM"
            PbPRO.DoDragDrop(PbPM.Image, DragDropEffects.Move Or DragDropEffects.Copy)

        End If
        blnBotonPresionado = False
    End Sub

    Private Sub PbFAL_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PbFAL.MouseDown
        'Verificamos si se presionó el botón izquierdo del mouse.
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'Si existe o hay una imagen en el control
            '  If Not PbPRO.Image Is Nothing Then
            'Determinamos que el botón se encuentra presionado.
            blnBotonPresionado = True

        End If
    End Sub

    Private Sub PbFAL_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PbFAL.MouseMove
        If blnBotonPresionado Then
            'Iniciamos el arrastre y permitimos que se pueda copiar o mover la imagen.
            ima = "FAL"
            PbFAL.DoDragDrop(PbFAL.Image, DragDropEffects.Move Or DragDropEffects.Copy)

        End If
        blnBotonPresionado = False
    End Sub

    Private Sub PbRAM_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PbRAM.MouseMove
        If blnBotonPresionado Then
            'Iniciamos el arrastre y permitimos que se pueda copiar o mover la imagen.
            ima = "RAM"
            PbRAM.DoDragDrop(PbRAM.Image, DragDropEffects.Move Or DragDropEffects.Copy)

        End If
        blnBotonPresionado = False
    End Sub

    Private Sub PbRAM_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PbRAM.MouseDown
        'Verificamos si se presionó el botón izquierdo del mouse.
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'Si existe o hay una imagen en el control
            '  If Not PbPRO.Image Is Nothing Then
            'Determinamos que el botón se encuentra presionado.
            blnBotonPresionado = True

        End If
    End Sub

    Private Sub PM_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PM.DragDrop
        'Asignamos la imagen al control PictureBoxPRO.
        PM.Image = e.Data.GetData(DataFormats.Bitmap)
        recep3(0) = ima
        controlimarepet(0)

    End Sub

    Private Sub PM_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PM.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy


        End If
    End Sub

    Private Sub RAM_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles RAM.DragDrop
        'Asignamos la imagen al control PictureBoxPRO.
        RAM.Image = e.Data.GetData(DataFormats.Bitmap)
        recep3(2) = ima
        controlimarepet(2)
    End Sub

    Private Sub RAM_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles RAM.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then

            e.Effect = DragDropEffects.Copy

        End If
    End Sub

    Private Sub FAL_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles FAL.DragDrop
        'Asignamos la imagen al control PictureBoxPRO.
        FAL.Image = e.Data.GetData(DataFormats.Bitmap)
        recep3(3) = ima
        controlimarepet(3)
    End Sub

    Private Sub FAL_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles FAL.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then

            e.Effect = DragDropEffects.Copy

        End If
    End Sub
    Sub controlimarepet(bloque As Integer)
        For i As Integer = 0 To 3
            If i <> bloque Then
                If recep3(i) = recep3(bloque) Then
                    Select Case i
                        Case 0
                            PM.Image = Nothing
                            recep3(0) = ""
                        Case 1
                            PRO.Image = Nothing
                            recep3(1) = ""
                        Case 2
                            RAM.Image = Nothing
                            recep3(2) = ""
                        Case 3
                            FAL.Image = Nothing
                            recep3(3) = ""
                    End Select
                End If
            End If
        Next
    End Sub

    Private Sub Btnsig3_Click(sender As Object, e As EventArgs) Handles Btnsig3.Click


        For i As Integer = 0 To 3
            If recep3(i) = "" Then
                MessageBox.Show("No deben quedar casilleros vacios. Por Favor Ingrese los objetos faltantes", "Faltan Objetos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next


        Me.Hide()
        Pregunta_4.Show()

    End Sub

    Private Sub Btnat3_Click(sender As Object, e As EventArgs) Handles Btnat3.Click
        Me.Hide()
        Pregunta_2.Show()

    End Sub
End Class