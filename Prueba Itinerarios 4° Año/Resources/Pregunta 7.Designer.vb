<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pregunta_7
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
        Me.Btnat7 = New System.Windows.Forms.Button()
        Me.Btnsig7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cbproy = New System.Windows.Forms.CheckBox()
        Me.Cbparl = New System.Windows.Forms.CheckBox()
        Me.Cbtecl = New System.Windows.Forms.CheckBox()
        Me.Cbmonit = New System.Windows.Forms.CheckBox()
        Me.Cbmouse = New System.Windows.Forms.CheckBox()
        Me.Cbcamar = New System.Windows.Forms.CheckBox()
        Me.Cbpen = New System.Windows.Forms.CheckBox()
        Me.Cbmic = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Btnat7
        '
        Me.Btnat7.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnat7.Location = New System.Drawing.Point(12, 313)
        Me.Btnat7.Name = "Btnat7"
        Me.Btnat7.Size = New System.Drawing.Size(136, 36)
        Me.Btnat7.TabIndex = 20
        Me.Btnat7.Text = "Atras"
        Me.Btnat7.UseVisualStyleBackColor = True
        '
        'Btnsig7
        '
        Me.Btnsig7.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsig7.Location = New System.Drawing.Point(336, 313)
        Me.Btnsig7.Name = "Btnsig7"
        Me.Btnsig7.Size = New System.Drawing.Size(136, 36)
        Me.Btnsig7.TabIndex = 19
        Me.Btnsig7.Text = "Siguiente"
        Me.Btnsig7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Seleccionar las opciones correctas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(398, 51)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Seleccione cuales de los siguientes son periféricos de Entrada"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cbproy
        '
        Me.Cbproy.AutoSize = True
        Me.Cbproy.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cbproy.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbproy.Location = New System.Drawing.Point(63, 132)
        Me.Cbproy.Margin = New System.Windows.Forms.Padding(5)
        Me.Cbproy.Name = "Cbproy"
        Me.Cbproy.Size = New System.Drawing.Size(85, 22)
        Me.Cbproy.TabIndex = 29
        Me.Cbproy.Text = "Proyector"
        Me.Cbproy.UseVisualStyleBackColor = False
        '
        'Cbparl
        '
        Me.Cbparl.AutoSize = True
        Me.Cbparl.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cbparl.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbparl.Location = New System.Drawing.Point(63, 164)
        Me.Cbparl.Margin = New System.Windows.Forms.Padding(5)
        Me.Cbparl.Name = "Cbparl"
        Me.Cbparl.Size = New System.Drawing.Size(82, 22)
        Me.Cbparl.TabIndex = 30
        Me.Cbparl.Text = "Parlantes"
        Me.Cbparl.UseVisualStyleBackColor = False
        '
        'Cbtecl
        '
        Me.Cbtecl.AutoSize = True
        Me.Cbtecl.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cbtecl.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbtecl.Location = New System.Drawing.Point(63, 196)
        Me.Cbtecl.Margin = New System.Windows.Forms.Padding(5)
        Me.Cbtecl.Name = "Cbtecl"
        Me.Cbtecl.Size = New System.Drawing.Size(73, 22)
        Me.Cbtecl.TabIndex = 31
        Me.Cbtecl.Text = "Teclado"
        Me.Cbtecl.UseVisualStyleBackColor = False
        '
        'Cbmonit
        '
        Me.Cbmonit.AutoSize = True
        Me.Cbmonit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cbmonit.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbmonit.Location = New System.Drawing.Point(319, 164)
        Me.Cbmonit.Margin = New System.Windows.Forms.Padding(5)
        Me.Cbmonit.Name = "Cbmonit"
        Me.Cbmonit.Size = New System.Drawing.Size(73, 22)
        Me.Cbmonit.TabIndex = 32
        Me.Cbmonit.Text = "Monitor"
        Me.Cbmonit.UseVisualStyleBackColor = False
        '
        'Cbmouse
        '
        Me.Cbmouse.AutoSize = True
        Me.Cbmouse.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cbmouse.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbmouse.Location = New System.Drawing.Point(319, 132)
        Me.Cbmouse.Margin = New System.Windows.Forms.Padding(5)
        Me.Cbmouse.Name = "Cbmouse"
        Me.Cbmouse.Size = New System.Drawing.Size(67, 22)
        Me.Cbmouse.TabIndex = 33
        Me.Cbmouse.Text = "Mouse"
        Me.Cbmouse.UseVisualStyleBackColor = False
        '
        'Cbcamar
        '
        Me.Cbcamar.AutoSize = True
        Me.Cbcamar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cbcamar.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbcamar.Location = New System.Drawing.Point(63, 228)
        Me.Cbcamar.Margin = New System.Windows.Forms.Padding(5)
        Me.Cbcamar.Name = "Cbcamar"
        Me.Cbcamar.Size = New System.Drawing.Size(73, 22)
        Me.Cbcamar.TabIndex = 34
        Me.Cbcamar.Text = "Cámara"
        Me.Cbcamar.UseVisualStyleBackColor = False
        '
        'Cbpen
        '
        Me.Cbpen.AutoSize = True
        Me.Cbpen.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cbpen.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbpen.Location = New System.Drawing.Point(319, 196)
        Me.Cbpen.Margin = New System.Windows.Forms.Padding(5)
        Me.Cbpen.Name = "Cbpen"
        Me.Cbpen.Size = New System.Drawing.Size(77, 22)
        Me.Cbpen.TabIndex = 35
        Me.Cbpen.Text = "Pendrive"
        Me.Cbpen.UseVisualStyleBackColor = False
        '
        'Cbmic
        '
        Me.Cbmic.AutoSize = True
        Me.Cbmic.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cbmic.Font = New System.Drawing.Font("Roboto Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbmic.Location = New System.Drawing.Point(319, 228)
        Me.Cbmic.Margin = New System.Windows.Forms.Padding(5)
        Me.Cbmic.Name = "Cbmic"
        Me.Cbmic.Size = New System.Drawing.Size(89, 22)
        Me.Cbmic.TabIndex = 36
        Me.Cbmic.Text = "Microfono"
        Me.Cbmic.UseVisualStyleBackColor = False
        '
        'Pregunta_7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prueba_Itinerarios_4__Año.My.Resources.Resources.Fondo_Examen4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cbmic)
        Me.Controls.Add(Me.Cbpen)
        Me.Controls.Add(Me.Cbcamar)
        Me.Controls.Add(Me.Cbmouse)
        Me.Controls.Add(Me.Cbmonit)
        Me.Controls.Add(Me.Cbtecl)
        Me.Controls.Add(Me.Cbparl)
        Me.Controls.Add(Me.Cbproy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnat7)
        Me.Controls.Add(Me.Btnsig7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Pregunta_7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregunta_7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnat7 As Button
    Friend WithEvents Btnsig7 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Cbproy As CheckBox
    Friend WithEvents Cbparl As CheckBox
    Friend WithEvents Cbtecl As CheckBox
    Friend WithEvents Cbmonit As CheckBox
    Friend WithEvents Cbmouse As CheckBox
    Friend WithEvents Cbcamar As CheckBox
    Friend WithEvents Cbpen As CheckBox
    Friend WithEvents Cbmic As CheckBox
End Class
