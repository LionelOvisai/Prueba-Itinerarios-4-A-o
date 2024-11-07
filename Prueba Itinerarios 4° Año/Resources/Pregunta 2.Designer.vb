<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pregunta_2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Rbop2 = New System.Windows.Forms.RadioButton()
        Me.Rbop3 = New System.Windows.Forms.RadioButton()
        Me.Rbop1 = New System.Windows.Forms.RadioButton()
        Me.Btnsig2 = New System.Windows.Forms.Button()
        Me.Btnat2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 50)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "¿Cuales de los siguientes elementos pertenecen al HARDWARE BÄSICO?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione la respuesta Correcta "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rbop2
        '
        Me.Rbop2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rbop2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbop2.Location = New System.Drawing.Point(68, 183)
        Me.Rbop2.Name = "Rbop2"
        Me.Rbop2.Size = New System.Drawing.Size(350, 47)
        Me.Rbop2.TabIndex = 7
        Me.Rbop2.TabStop = True
        Me.Rbop2.Text = "PLACA MADRE - PROCESADOR - MEMORIA RAM - MEMORIA ROM - FUENTE DE ALIMENTACIÓN"
        Me.Rbop2.UseVisualStyleBackColor = False
        '
        'Rbop3
        '
        Me.Rbop3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rbop3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbop3.Location = New System.Drawing.Point(68, 236)
        Me.Rbop3.Name = "Rbop3"
        Me.Rbop3.Size = New System.Drawing.Size(350, 47)
        Me.Rbop3.TabIndex = 6
        Me.Rbop3.TabStop = True
        Me.Rbop3.Text = "WINDOWS - ANDROID - IOS - MACOS - LINUX"
        Me.Rbop3.UseVisualStyleBackColor = False
        '
        'Rbop1
        '
        Me.Rbop1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rbop1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbop1.Location = New System.Drawing.Point(68, 130)
        Me.Rbop1.Name = "Rbop1"
        Me.Rbop1.Size = New System.Drawing.Size(350, 47)
        Me.Rbop1.TabIndex = 5
        Me.Rbop1.TabStop = True
        Me.Rbop1.Text = "TECLADO - MOUSE - MONITOR - CÁMARA - PARLANTES - IMPRESORA"
        Me.Rbop1.UseVisualStyleBackColor = False
        '
        'Btnsig2
        '
        Me.Btnsig2.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsig2.Location = New System.Drawing.Point(336, 313)
        Me.Btnsig2.Name = "Btnsig2"
        Me.Btnsig2.Size = New System.Drawing.Size(136, 36)
        Me.Btnsig2.TabIndex = 8
        Me.Btnsig2.Text = "Siguiente"
        Me.Btnsig2.UseVisualStyleBackColor = True
        '
        'Btnat2
        '
        Me.Btnat2.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnat2.Location = New System.Drawing.Point(12, 313)
        Me.Btnat2.Name = "Btnat2"
        Me.Btnat2.Size = New System.Drawing.Size(136, 36)
        Me.Btnat2.TabIndex = 19
        Me.Btnat2.Text = "Atras"
        Me.Btnat2.UseVisualStyleBackColor = True
        '
        'Pregunta_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prueba_Itinerarios_4__Año.My.Resources.Resources.Fondo_Examen4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btnat2)
        Me.Controls.Add(Me.Btnsig2)
        Me.Controls.Add(Me.Rbop2)
        Me.Controls.Add(Me.Rbop3)
        Me.Controls.Add(Me.Rbop1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Pregunta_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregunta_2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Rbop2 As RadioButton
    Friend WithEvents Rbop3 As RadioButton
    Friend WithEvents Rbop1 As RadioButton
    Friend WithEvents Btnsig2 As Button
    Friend WithEvents Btnat2 As Button
End Class
