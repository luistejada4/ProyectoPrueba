
Imports BLL
Imports Entidades

Public Class RegistroClientes
    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click

        If NameTextBox.TextLength > 3 And NameTextBox.TextLength < 60 And DireccionTextBox.TextLength > 0 And DireccionTextBox.TextLength < 120 Then
            Dim id = 0
            Dim text = CodigoMaskedTextBox.Text
            Integer.TryParse(text, id)
            Dim cliente As Cliente = New Cliente(id, NameTextBox.Text, DireccionTextBox.Text)

            Dim codigo = ClientesBLL.Guardar(cliente)

            If codigo > 0 Then

                CodigoMaskedTextBox.Text = codigo.ToString()

            End If
        Else
            MessageBox.Show(Me, "El nombre y la direccion no pueden estar vacios.")
        End If
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

        Dim id = 0
        Dim text = CodigoMaskedTextBox.Text
        If Not String.IsNullOrEmpty(text) Or String.IsNullOrWhiteSpace(text) Then

            Integer.TryParse(text, id)

            If id > 0 Then

                Dim cliente = ClientesBLL.Buscar(id)
                If cliente IsNot Nothing Then

                    NameTextBox.Text = cliente.Nombre
                    DireccionTextBox.Text = cliente.Direccion
                Else
                    MessageBox.Show(Me, "No existe un cliente con este id.")
                End If

            Else
                MessageBox.Show(Me, "El id debe ser mayor que 0.")
            End If
        Else
            MessageBox.Show(Me, "El id no puede estar vacio..")
        End If
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click

        Dim id = 0
        Dim text = CodigoMaskedTextBox.Text
        If Not String.IsNullOrEmpty(text) And Not String.IsNullOrWhiteSpace(text) Then

            Integer.TryParse(text, id)

            If id > 0 Then

                If ClientesBLL.Eliminar(id) Then
                    MessageBox.Show(Me, "Cliente eliminado.")
                    Limpiar()
                Else
                    MessageBox.Show(Me, "No se pudo eliminar el cliente.")
                End If
            Else
                MessageBox.Show(Me, "El id debe ser mayor que 0.")
            End If
        Else
            MessageBox.Show(Me, "El id no puede estar vacio.")
        End If
    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click
        Limpiar()
    End Sub

    Private Sub Limpiar()
        CodigoMaskedTextBox.Clear()
        NameTextBox.Clear()
        DireccionTextBox.Clear()
    End Sub
End Class