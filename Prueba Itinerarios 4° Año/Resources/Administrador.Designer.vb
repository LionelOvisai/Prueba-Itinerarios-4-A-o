<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cbaleva = New System.Windows.Forms.ComboBox()
        Me.Bteva = New System.Windows.Forms.Button()
        Me.Btvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alumnos Evaluados"
        '
        'Cbaleva
        '
        Me.Cbaleva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbaleva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbaleva.FormattingEnabled = True
        Me.Cbaleva.Location = New System.Drawing.Point(12, 45)
        Me.Cbaleva.MaxDropDownItems = 10
        Me.Cbaleva.Name = "Cbaleva"
        Me.Cbaleva.Size = New System.Drawing.Size(291, 26)
        Me.Cbaleva.TabIndex = 1
        '
        'Bteva
        '
        Me.Bteva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bteva.Location = New System.Drawing.Point(337, 41)
        Me.Bteva.Name = "Bteva"
        Me.Bteva.Size = New System.Drawing.Size(138, 33)
        Me.Bteva.TabIndex = 2
        Me.Bteva.Text = "Ver Examen"
        Me.Bteva.UseVisualStyleBackColor = True
        '
        'Btvolver
        '
        Me.Btvolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btvolver.Location = New System.Drawing.Point(12, 85)
        Me.Btvolver.Name = "Btvolver"
        Me.Btvolver.Size = New System.Drawing.Size(185, 33)
        Me.Btvolver.TabIndex = 3
        Me.Btvolver.Text = "Volver evaluacion"
        Me.Btvolver.UseVisualStyleBackColor = True
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 130)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btvolver)
        Me.Controls.Add(Me.Bteva)
        Me.Controls.Add(Me.Cbaleva)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Administrador"
        Me.Text = "Administrador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Bteva As Button
    Friend WithEvents Btvolver As Button
    Protected WithEvents Cbaleva As ComboBox
End Class
