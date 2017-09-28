Imports BLL
Imports Entidades

Public Class RegistroArticulos
    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click

        If Validar() Then

            Dim codigo As Integer = 0
            Dim costo As Double = 0
            Dim precio As Double = 0
            Dim ganancia As Double = 0
            Dim itbis As Double = 0
            Dim existencia As Integer = 0

            Integer.TryParse(CodigoMaskedTextBox.Text, codigo)
            Integer.TryParse(CostoMaskedTextBox.Text, costo)
            Integer.TryParse(PrecioMaskedTextBox.Text, precio)
            Integer.TryParse(ITBISMaskedTextBox.Text, itbis)
            Integer.TryParse(ExistenciaMaskedTextBox.Text, existencia)

            ganancia = ((precio - costo) / costo) * 100

            Dim articulo As Articulo = New Articulo(codigo, DescripcionTextBox.Text, costo, precio, ganancia, itbis, existencia)

            codigo = ArticuloBLL.Guardar(articulo)
            If codigo > 0 Then

                CodigoMaskedTextBox.Text = codigo.ToString()

            End If

        End If

    End Sub

    Private Function Validar() As Boolean

        Dim validate = 0

        If String.IsNullOrWhiteSpace(DescripcionTextBox.Text) Then
            validate += 1
            ErrorProvider.SetError(DescripcionTextBox, "Este campo no puede estar vacio.")

        End If

        If String.IsNullOrWhiteSpace(CostoMaskedTextBox.Text) Then
            validate += 1
            ErrorProvider.SetError(CostoMaskedTextBox, "Este campo no puede estar vacio.")

        End If

        If String.IsNullOrWhiteSpace(PrecioMaskedTextBox.Text) Then
            validate += 1
            ErrorProvider.SetError(PrecioMaskedTextBox, "Este campo no puede estar vacio.")
        End If

        If String.IsNullOrWhiteSpace(ExistenciaMaskedTextBox.Text) Then
            validate += 1
            ErrorProvider.SetError(ExistenciaMaskedTextBox, "Este campo no puede estar vacio.")

        End If

        If String.IsNullOrWhiteSpace(ITBISMaskedTextBox.Text) Then
            validate += 1
            ErrorProvider.SetError(ExistenciaMaskedTextBox, "Este campo no puede estar vacio.")

        End If

        Return If(validate = 0, True, False)

    End Function

    Private Sub Limpiar()

        CodigoMaskedTextBox.Clear()
        DescripcionTextBox.Clear()
        CostoMaskedTextBox.Clear()
        PrecioMaskedTextBox.Clear()
        ITBISMaskedTextBox.Clear()
        ExistenciaMaskedTextBox.Clear()

    End Sub

    Private Sub NuevoButton_Click(sender As Object, e As EventArgs) Handles NuevoButton.Click

        Limpiar()

    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click

        If Not String.IsNullOrWhiteSpace(CodigoMaskedTextBox.Text) Then

            Dim codigo As Integer = Integer.Parse(CodigoMaskedTextBox.Text)
            If codigo > 0 Then

                If ArticuloBLL.Eliminar(codigo) = 1 Then

                    MessageBox.Show("Articulo eliminado!")
                    Limpiar()
                Else
                    MessageBox.Show("No se puedo eliminar este articulo o no existe!")

                End If
            Else
                ErrorProvider.SetError(CodigoMaskedTextBox, "Codigo debe ser mayor que 0")
            End If
        Else
            ErrorProvider.SetError(CodigoMaskedTextBox, "Codigo no puede estar vacio!")
        End If

    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

        If Not String.IsNullOrWhiteSpace(CodigoMaskedTextBox.Text) Then

            Dim codigo As Integer = Integer.Parse(CodigoMaskedTextBox.Text)

            If codigo > 0 Then

                Dim articulo As Articulo = ArticuloBLL.Buscar(codigo)

                If articulo IsNot Nothing Then

                    DescripcionTextBox.Text = articulo.Descripcion
                    CostoMaskedTextBox.Text = articulo.Costo.ToString()
                    PrecioMaskedTextBox.Text = articulo.Precio.ToString()
                    ITBISMaskedTextBox.Text = articulo.Itebis.ToString()

                Else

                    MessageBox.Show("Este articulo no existe!")

                End If
            Else

                ErrorProvider.SetError(CodigoMaskedTextBox, "Codigo tiene que ser mayor que 0!")

            End If

        Else
            ErrorProvider.SetError(CodigoMaskedTextBox, "Codigo no puede estar vacio!")
        End If
    End Sub
End Class