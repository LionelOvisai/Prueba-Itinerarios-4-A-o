<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pregunta_4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pregunta_4))
        Me.Btnat4 = New System.Windows.Forms.Button()
        Me.Btnsig4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Rbverda = New System.Windows.Forms.RadioButton()
        Me.Rbfalso = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Btnat4
        '
        Me.Btnat4.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnat4.Location = New System.Drawing.Point(12, 313)
        Me.Btnat4.Name = "Btnat4"
        Me.Btnat4.Size = New System.Drawing.Size(136, 36)
        Me.Btnat4.TabIndex = 20
        Me.Btnat4.Text = "Atras"
        Me.Btnat4.UseVisualStyleBackColor = True
        '
        'Btnsig4
        '
        Me.Btnsig4.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsig4.Location = New System.Drawing.Point(336, 313)
        Me.Btnsig4.Name = "Btnsig4"
        Me.Btnsig4.Size = New System.Drawing.Size(136, 36)
        Me.Btnsig4.TabIndex = 19
        Me.Btnsig4.Text = "Siguiente"
        Me.Btnsig4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Responder Verdadero o Falso"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(445, 130)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(311, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Unidad de Medida de la Información"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rbverda
        '
        Me.Rbverda.AutoSize = True
        Me.Rbverda.BackColor = System.Drawing.Color.Transparent
        Me.Rbverda.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbverda.Location = New System.Drawing.Point(120, 234)
        Me.Rbverda.Name = "Rbverda"
        Me.Rbverda.Size = New System.Drawing.Size(91, 24)
        Me.Rbverda.TabIndex = 24
        Me.Rbverda.TabStop = True
        Me.Rbverda.Text = "Verdadero"
        Me.Rbverda.UseVisualStyleBackColor = False
        '
        'Rbfalso
        '
        Me.Rbfalso.AutoSize = True
        Me.Rbfalso.BackColor = System.Drawing.Color.Transparent
        Me.Rbfalso.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbfalso.Location = New System.Drawing.Point(295, 234)
        Me.Rbfalso.Name = "Rbfalso"
        Me.Rbfalso.Size = New System.Drawing.Size(61, 24)
        Me.Rbfalso.TabIndex = 25
        Me.Rbfalso.TabStop = True
        Me.Rbfalso.Text = "Falso"
        Me.Rbfalso.UseVisualStyleBackColor = False
        '
        'Pregunta_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prueba_Itinerarios_4__Año.My.Resources.Resources.Fondo_Examen4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.Rbfalso)
        Me.Controls.Add(Me.Rbverda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnat4)
        Me.Controls.Add(Me.Btnsig4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Pregunta_4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregunta_4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnat4 As Button
    Friend WithEvents Btnsig4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Rbverda As RadioButton
    Friend WithEvents Rbfalso As RadioButton
End Class
