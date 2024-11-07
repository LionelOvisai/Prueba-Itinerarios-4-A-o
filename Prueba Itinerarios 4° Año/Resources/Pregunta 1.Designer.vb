<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pregunta_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pregunta_1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Rbop1 = New System.Windows.Forms.RadioButton()
        Me.Rbop3 = New System.Windows.Forms.RadioButton()
        Me.Rbop2 = New System.Windows.Forms.RadioButton()
        Me.Btnsip1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la respuesta Correcta "
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Segun lo trabajado en la Materia, ¿Cual es la definicion de HARDWARE?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rbop1
        '
        Me.Rbop1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rbop1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbop1.Location = New System.Drawing.Point(71, 132)
        Me.Rbop1.Name = "Rbop1"
        Me.Rbop1.Size = New System.Drawing.Size(364, 47)
        Me.Rbop1.TabIndex = 2
        Me.Rbop1.TabStop = True
        Me.Rbop1.Text = "Se refiere a todas las partes físicas de un sistema Informatico.  Todo lo que se " &
    "puede tocar"
        Me.Rbop1.UseVisualStyleBackColor = False
        '
        'Rbop3
        '
        Me.Rbop3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rbop3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbop3.Location = New System.Drawing.Point(71, 238)
        Me.Rbop3.Name = "Rbop3"
        Me.Rbop3.Size = New System.Drawing.Size(364, 47)
        Me.Rbop3.TabIndex = 3
        Me.Rbop3.TabStop = True
        Me.Rbop3.Text = "Se refiere a todas las parte lógica de un sistema Informatico.  Todo lo que no se" &
    " puede tocar"
        Me.Rbop3.UseVisualStyleBackColor = False
        '
        'Rbop2
        '
        Me.Rbop2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rbop2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbop2.Location = New System.Drawing.Point(71, 185)
        Me.Rbop2.Name = "Rbop2"
        Me.Rbop2.Size = New System.Drawing.Size(364, 47)
        Me.Rbop2.TabIndex = 4
        Me.Rbop2.TabStop = True
        Me.Rbop2.Text = "Se refiere a los procesos necesarios para realizar un programa informático"
        Me.Rbop2.UseVisualStyleBackColor = False
        '
        'Btnsip1
        '
        Me.Btnsip1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsip1.Location = New System.Drawing.Point(319, 313)
        Me.Btnsip1.Name = "Btnsip1"
        Me.Btnsip1.Size = New System.Drawing.Size(153, 36)
        Me.Btnsip1.TabIndex = 5
        Me.Btnsip1.Text = "Siguiente"
        Me.Btnsip1.UseVisualStyleBackColor = True
        '
        'Pregunta_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prueba_Itinerarios_4__Año.My.Resources.Resources.Fondo_Examen4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(504, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btnsip1)
        Me.Controls.Add(Me.Rbop2)
        Me.Controls.Add(Me.Rbop3)
        Me.Controls.Add(Me.Rbop1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Pregunta_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregunta_1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Rbop1 As RadioButton
    Friend WithEvents Rbop3 As RadioButton
    Friend WithEvents Rbop2 As RadioButton
    Friend WithEvents Btnsip1 As Button
End Class
