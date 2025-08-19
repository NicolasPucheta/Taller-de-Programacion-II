<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LNya = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TGuardar = New System.Windows.Forms.Button()
        Me.TEliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LTarjeta = New System.Windows.Forms.Label()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.RBVaron = New System.Windows.Forms.RadioButton()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.PictureBoxVacio = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxVacio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LNya
        '
        Me.LNya.AutoSize = True
        Me.LNya.Location = New System.Drawing.Point(16, 17)
        Me.LNya.Name = "LNya"
        Me.LNya.Size = New System.Drawing.Size(92, 13)
        Me.LNya.TabIndex = 0
        Me.LNya.Text = "Nombre y Apellido"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(16, 71)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(26, 13)
        Me.LDni.TabIndex = 1
        Me.LDni.Text = "DNI"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(16, 106)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(44, 13)
        Me.LApellido.TabIndex = 2
        Me.LApellido.Text = "Apellido"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(16, 144)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 3
        Me.LNombre.Text = "Nombre"
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.ForeColor = System.Drawing.Color.Red
        Me.LModificar.Location = New System.Drawing.Point(156, 17)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(49, 13)
        Me.LModificar.TabIndex = 4
        Me.LModificar.Text = "modificar"
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(125, 103)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(100, 20)
        Me.TApellido.TabIndex = 5
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(125, 141)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(100, 20)
        Me.TNombre.TabIndex = 6
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(125, 68)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(100, 20)
        Me.TDni.TabIndex = 7
        '
        'TGuardar
        '
        Me.TGuardar.Image = CType(resources.GetObject("TGuardar.Image"), System.Drawing.Image)
        Me.TGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.TGuardar.Location = New System.Drawing.Point(40, 482)
        Me.TGuardar.Name = "TGuardar"
        Me.TGuardar.Size = New System.Drawing.Size(106, 50)
        Me.TGuardar.TabIndex = 8
        Me.TGuardar.Text = "Guardar"
        Me.TGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TGuardar.UseVisualStyleBackColor = True
        '
        'TEliminar
        '
        Me.TEliminar.Image = CType(resources.GetObject("TEliminar.Image"), System.Drawing.Image)
        Me.TEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TEliminar.Location = New System.Drawing.Point(164, 479)
        Me.TEliminar.Name = "TEliminar"
        Me.TEliminar.Size = New System.Drawing.Size(114, 56)
        Me.TEliminar.TabIndex = 9
        Me.TEliminar.Text = "Eliminar"
        Me.TEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TEliminar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.LTarjeta)
        Me.Panel1.Controls.Add(Me.TTelefono)
        Me.Panel1.Controls.Add(Me.LTelefono)
        Me.Panel1.Controls.Add(Me.TApellido)
        Me.Panel1.Controls.Add(Me.LNya)
        Me.Panel1.Controls.Add(Me.LDni)
        Me.Panel1.Controls.Add(Me.TDni)
        Me.Panel1.Controls.Add(Me.LApellido)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Controls.Add(Me.LModificar)
        Me.Panel1.Location = New System.Drawing.Point(40, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 354)
        Me.Panel1.TabIndex = 10
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(124, 276)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox3.TabIndex = 13
        Me.CheckBox3.Text = "Masterdcard"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(125, 248)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.Text = "Visa"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(125, 225)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Naranja"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LTarjeta
        '
        Me.LTarjeta.AutoSize = True
        Me.LTarjeta.Location = New System.Drawing.Point(16, 225)
        Me.LTarjeta.Name = "LTarjeta"
        Me.LTarjeta.Size = New System.Drawing.Size(90, 13)
        Me.LTarjeta.TabIndex = 10
        Me.LTarjeta.Text = "Tarjeta de credito"
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(125, 178)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TTelefono.TabIndex = 9
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(16, 181)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LTelefono.TabIndex = 8
        Me.LTelefono.Text = "Telefono"
        '
        'RBVaron
        '
        Me.RBVaron.AutoSize = True
        Me.RBVaron.Checked = True
        Me.RBVaron.Location = New System.Drawing.Point(333, 160)
        Me.RBVaron.Name = "RBVaron"
        Me.RBVaron.Size = New System.Drawing.Size(53, 17)
        Me.RBVaron.TabIndex = 11
        Me.RBVaron.TabStop = True
        Me.RBVaron.Text = "Varon"
        Me.RBVaron.UseVisualStyleBackColor = True
        '
        'RBMujer
        '
        Me.RBMujer.AutoSize = True
        Me.RBMujer.Location = New System.Drawing.Point(392, 160)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(51, 17)
        Me.RBMujer.TabIndex = 12
        Me.RBMujer.Text = "Mujer"
        Me.RBMujer.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.Location = New System.Drawing.Point(332, 479)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(94, 53)
        Me.BSalir.TabIndex = 14
        Me.BSalir.Text = "Salir"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'PictureBoxVacio
        '
        Me.PictureBoxVacio.Location = New System.Drawing.Point(332, 56)
        Me.PictureBoxVacio.Name = "PictureBoxVacio"
        Me.PictureBoxVacio.Size = New System.Drawing.Size(122, 98)
        Me.PictureBoxVacio.TabIndex = 15
        Me.PictureBoxVacio.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(172, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nuevo Cliente"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 616)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxVacio)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.RBMujer)
        Me.Controls.Add(Me.RBVaron)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TEliminar)
        Me.Controls.Add(Me.TGuardar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxVacio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LNya As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents TGuardar As Button
    Friend WithEvents TEliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents LTelefono As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LTarjeta As Label
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents BSalir As Button
    Friend WithEvents PictureBoxVacio As PictureBox
    Friend WithEvents Label1 As Label
End Class
