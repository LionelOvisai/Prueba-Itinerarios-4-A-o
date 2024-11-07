<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioPrv
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioPrv))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbApeNom = New System.Windows.Forms.TextBox()
        Me.BtnCom = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TbPassw = New System.Windows.Forms.TextBox()
        Me.Gbadmin = New System.Windows.Forms.GroupBox()
        Me.Btadmin = New System.Windows.Forms.Button()
        Me.Btnfin = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbadmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prueba Itinerarios 1° Año (Curso 4°)"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese Apellido Y Nombre"
        '
        'TbApeNom
        '
        Me.TbApeNom.Font = New System.Drawing.Font("Roboto Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbApeNom.Location = New System.Drawing.Point(18, 174)
        Me.TbApeNom.Name = "TbApeNom"
        Me.TbApeNom.Size = New System.Drawing.Size(429, 33)
        Me.TbApeNom.TabIndex = 2
        Me.TbApeNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCom
        '
        Me.BtnCom.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCom.Location = New System.Drawing.Point(75, 213)
        Me.BtnCom.Name = "BtnCom"
        Me.BtnCom.Size = New System.Drawing.Size(307, 54)
        Me.BtnCom.TabIndex = 3
        Me.BtnCom.Text = "Comenzar Prueba"
        Me.BtnCom.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Prueba_Itinerarios_4__Año.My.Resources.Resources.Ovisai_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(187, 273)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TbPassw
        '
        Me.TbPassw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPassw.Location = New System.Drawing.Point(6, 21)
        Me.TbPassw.MaxLength = 8
        Me.TbPassw.Name = "TbPassw"
        Me.TbPassw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPassw.Size = New System.Drawing.Size(202, 24)
        Me.TbPassw.TabIndex = 5
        '
        'Gbadmin
        '
        Me.Gbadmin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Gbadmin.Controls.Add(Me.Btnfin)
        Me.Gbadmin.Controls.Add(Me.Btadmin)
        Me.Gbadmin.Controls.Add(Me.TbPassw)
        Me.Gbadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbadmin.Location = New System.Drawing.Point(31, 21)
        Me.Gbadmin.Name = "Gbadmin"
        Me.Gbadmin.Size = New System.Drawing.Size(394, 61)
        Me.Gbadmin.TabIndex = 6
        Me.Gbadmin.TabStop = False
        Me.Gbadmin.Text = "Ingreso Administrador"
        Me.Gbadmin.Visible = False
        '
        'Btadmin
        '
        Me.Btadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btadmin.Location = New System.Drawing.Point(214, 12)
        Me.Btadmin.Name = "Btadmin"
        Me.Btadmin.Size = New System.Drawing.Size(88, 42)
        Me.Btadmin.TabIndex = 6
        Me.Btadmin.Text = "Ingresar"
        Me.Btadmin.UseVisualStyleBackColor = True
        '
        'Btnfin
        '
        Me.Btnfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfin.Location = New System.Drawing.Point(308, 12)
        Me.Btnfin.Name = "Btnfin"
        Me.Btnfin.Size = New System.Drawing.Size(80, 42)
        Me.Btnfin.TabIndex = 7
        Me.Btnfin.Text = "Finalizar"
        Me.Btnfin.UseVisualStyleBackColor = True
        '
        'InicioPrv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prueba_Itinerarios_4__Año.My.Resources.Resources.Fondo_Examen4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.Gbadmin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCom)
        Me.Controls.Add(Me.TbApeNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InicioPrv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prueba Itinerarios Formativos 4° Año"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbadmin.ResumeLayout(False)
        Me.Gbadmin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbApeNom As TextBox
    Friend WithEvents BtnCom As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TbPassw As TextBox
    Friend WithEvents Gbadmin As GroupBox
    Friend WithEvents Btadmin As Button
    Friend WithEvents Btnfin As Button
End Class
