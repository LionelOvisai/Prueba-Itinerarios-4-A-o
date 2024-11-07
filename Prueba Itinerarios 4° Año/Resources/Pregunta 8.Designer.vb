<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pregunta_8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pregunta_8))
        Me.Btnat8 = New System.Windows.Forms.Button()
        Me.Btnsig8 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Rbop1 = New System.Windows.Forms.RadioButton()
        Me.Rbop2 = New System.Windows.Forms.RadioButton()
        Me.Rbop4 = New System.Windows.Forms.RadioButton()
        Me.Rbop3 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Btnat8
        '
        Me.Btnat8.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnat8.Location = New System.Drawing.Point(12, 313)
        Me.Btnat8.Name = "Btnat8"
        Me.Btnat8.Size = New System.Drawing.Size(136, 36)
        Me.Btnat8.TabIndex = 20
        Me.Btnat8.Text = "Atras"
        Me.Btnat8.UseVisualStyleBackColor = True
        '
        'Btnsig8
        '
        Me.Btnsig8.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsig8.Location = New System.Drawing.Point(336, 313)
        Me.Btnsig8.Name = "Btnsig8"
        Me.Btnsig8.Size = New System.Drawing.Size(136, 36)
        Me.Btnsig8.TabIndex = 19
        Me.Btnsig8.Text = "Siguiente"
        Me.Btnsig8.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Roboto Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(425, 28)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Dispositivos de Almacenamiento de la Información"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Seleccionar la respuesta correcta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(460, 106)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rbop1
        '
        Me.Rbop1.AutoSize = True
        Me.Rbop1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rbop1.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbop1.Location = New System.Drawing.Point(23, 193)
        Me.Rbop1.Name = "Rbop1"
        Me.Rbop1.Size = New System.Drawing.Size(281, 22)
        Me.Rbop1.TabIndex = 32
        Me.Rbop1.TabStop = True
        Me.Rbop1.Text = "ELECTRICIDAD – TENSIÓN – RESISTENCIA"
        Me.Rbop1.UseVisualStyleBackColor = False
        '
        'Rbop2
        '
        Me.Rbop2.AutoSize = True
        Me.Rbop2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rbop2.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbop2.Location = New System.Drawing.Point(23, 221)
        Me.Rbop2.Name = "Rbop2"
        Me.Rbop2.Size = New System.Drawing.Size(264, 22)
        Me.Rbop2.TabIndex = 33
        Me.Rbop2.TabStop = True
        Me.Rbop2.Text = "MAGNÉTICO – ÓPTICO – ELECTRÓNICO"
        Me.Rbop2.UseVisualStyleBackColor = False
        '
        'Rbop4
        '
        Me.Rbop4.AutoSize = True
        Me.Rbop4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rbop4.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbop4.Location = New System.Drawing.Point(23, 277)
        Me.Rbop4.Name = "Rbop4"
        Me.Rbop4.Size = New System.Drawing.Size(219, 22)
        Me.Rbop4.TabIndex = 34
        Me.Rbop4.TabStop = True
        Me.Rbop4.Text = "ENTRADA – PROCESO – SALIDA"
        Me.Rbop4.UseVisualStyleBackColor = False
        '
        'Rbop3
        '
        Me.Rbop3.AutoSize = True
        Me.Rbop3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rbop3.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbop3.Location = New System.Drawing.Point(23, 249)
        Me.Rbop3.Name = "Rbop3"
        Me.Rbop3.Size = New System.Drawing.Size(277, 22)
        Me.Rbop3.TabIndex = 35
        Me.Rbop3.TabStop = True
        Me.Rbop3.Text = "ESTRUCTURA – GABINETE - PROCESADOR"
        Me.Rbop3.UseVisualStyleBackColor = False
        '
        'Pregunta_8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prueba_Itinerarios_4__Año.My.Resources.Resources.Fondo_Examen4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.Rbop3)
        Me.Controls.Add(Me.Rbop4)
        Me.Controls.Add(Me.Rbop2)
        Me.Controls.Add(Me.Rbop1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnat8)
        Me.Controls.Add(Me.Btnsig8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Pregunta_8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregunta_8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnat8 As Button
    Friend WithEvents Btnsig8 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Rbop1 As RadioButton
    Friend WithEvents Rbop2 As RadioButton
    Friend WithEvents Rbop4 As RadioButton
    Friend WithEvents Rbop3 As RadioButton
End Class
