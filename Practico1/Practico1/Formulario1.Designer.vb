<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario1
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
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.txtUno = New System.Windows.Forms.TextBox()
        Me.TxtComentarios = New System.Windows.Forms.TextBox()
        Me.txtDos = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(45, 186)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BGuardar.TabIndex = 0
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(137, 186)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BEliminar.TabIndex = 1
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'txtUno
        '
        Me.txtUno.Location = New System.Drawing.Point(92, 62)
        Me.txtUno.Name = "txtUno"
        Me.txtUno.Size = New System.Drawing.Size(100, 20)
        Me.txtUno.TabIndex = 2
        '
        'TxtComentarios
        '
        Me.TxtComentarios.Location = New System.Drawing.Point(280, 58)
        Me.TxtComentarios.Multiline = True
        Me.TxtComentarios.Name = "TxtComentarios"
        Me.TxtComentarios.Size = New System.Drawing.Size(192, 108)
        Me.TxtComentarios.TabIndex = 3
        '
        'txtDos
        '
        Me.txtDos.Location = New System.Drawing.Point(92, 125)
        Me.txtDos.Name = "txtDos"
        Me.txtDos.Size = New System.Drawing.Size(100, 20)
        Me.txtDos.TabIndex = 4
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(42, 65)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(44, 13)
        Me.LApellido.TabIndex = 5
        Me.LApellido.Text = "Apellido"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(42, 128)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 6
        Me.LNombre.Text = "Nombre"
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(397, 29)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 7
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'Formulario1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.txtDos)
        Me.Controls.Add(Me.TxtComentarios)
        Me.Controls.Add(Me.txtUno)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BGuardar)
        Me.Name = "Formulario1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi Primer Forms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents txtUno As TextBox
    Friend WithEvents TxtComentarios As TextBox
    Friend WithEvents txtDos As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Public WithEvents BSalir As Button
End Class
