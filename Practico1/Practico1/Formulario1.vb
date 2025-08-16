Public Class Formulario1

    Private Sub Formulario1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        'punto 6.
        TxtComentarios.Text = txtUno.Text & " " & txtDos.Text
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        'punto 7.
        TxtComentarios.Clear()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        End
    End Sub
End Class