Public Class Form1
    ' Validación para TDni (solo números)
    Private Sub TDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDni.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Validación para TApellido (solo letras)
    Private Sub TApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Validación para TNombre (solo letras)
    Private Sub TNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TGuardar_Click(sender As Object, e As EventArgs) Handles TGuardar.Click
        ' 8) Crea la variable para el resultado del MsgBox.
        Dim ask As MsgBoxResult
        ' 7) Valida que todos los campos estén completos.
        If TDni.Text <> "" AndAlso TApellido.Text <> "" AndAlso TNombre.Text <> "" Then
            LModificar.Text = TNombre.Text & " " & TApellido.Text
            ' 9) Muestra el mensaje de consulta y asigna el resultado a la variable "ask".
            ' El MsgBox tiene botones Si y No, un ícono de pregunta y el foco en el botón "Si".
            ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            ' Usa la sentencia if para verificar si el usuario presionó "Si".
            If ask = MsgBoxResult.Yes Then
                ' 10) Muestra un mensaje de información con el nombre completo del cliente.
                Dim nombreCompleto As String = TApellido.Text & " " & TNombre.Text
                MessageBox.Show("El Cliente: " & nombreCompleto & " se insertó Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ' Si algún campo está incompleto, muestra un mensaje de error crítico.
            MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TEliminar_Click(sender As Object, e As EventArgs) Handles TEliminar.Click
        ' Declara la variable para el resultado del MsgBox
        Dim resultado As MsgBoxResult
        Dim nombreCompleto As String = TApellido.Text & " " & TNombre.Text

        ' 11) Muestra el mensaje de advertencia con el foco en "No"
        resultado = MessageBox.Show("Está apunto de eliminar el Cliente: " & nombreCompleto, "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)

        ' 12) Verifica la respuesta del usuario
        If resultado = MsgBoxResult.Yes Then
            ' Si la respuesta es "Sí", muestra el mensaje de confirmación
            MessageBox.Show("El Cliente: " & nombreCompleto & " se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpia todos los campos de texto
            TDni.Clear()
            TApellido.Clear()
            TNombre.Clear()
            LModificar.Text = "" ' Limpia el label LModificar
        End If
        ' Si la respuesta es "No", no sucede nada (el código simplemente termina)
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub
    Private Sub RBVaron_CheckedChanged(sender As Object, e As EventArgs) Handles RBVaron.CheckedChanged
        If RBVaron.Checked Then
            PictureBoxVacio.Image = My.Resources.IconoVaron
        End If
    End Sub

    Private Sub RBMujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        If RBMujer.Checked Then
            PictureBoxVacio.Image = My.Resources.IconoMujer
        End If
    End Sub

End Class
