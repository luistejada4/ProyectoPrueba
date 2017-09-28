Imports BLL
Imports Entidades

Public Class Pedidos
    Public Shared Pedido As Pedido = New Pedido()
    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As DataTable
        dt = ArticuloBLL.Listar()
        ArticulosComboBox.DataSource = dt
        ArticulosComboBox.DisplayMember = "Descripcion"
        ArticulosComboBox.ValueMember = "Codigo"
        ItemsDataGridView.AutoGenerateColumns = False

    End Sub

    Private Sub AgregarButton_Click(sender As Object, e As EventArgs) Handles AgregarButton.Click

        If ArticulosComboBox.SelectedIndex >= 0 Then
            If ItemsDataGridView.Rows.Count = 0 Then

                ItemsDataGridView.Rows.Add()
                Dim articulo As Articulo = ArticuloBLL.Buscar(ArticulosComboBox.SelectedValue)
                Dim row As DataGridViewRow = ItemsDataGridView.Rows(0)
                row.Cells(0).Value = articulo.Codigo
                row.Cells(1).Value = articulo.Descripcion
                row.Cells(2).Value = 1
                row.Cells(3).Value = articulo.Precio
                row.Cells(4).Value = articulo.Itebis
                Dim item As Item = New Item(0, row.Cells(0).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value)
                Pedido.Items.Add(item)
            Else

                Dim inRow As Boolean = False
                Dim articulo As Articulo = ArticuloBLL.Buscar(ArticulosComboBox.SelectedValue)
                For Each art As DataGridViewRow In ItemsDataGridView.Rows

                    Dim codigo As Integer = art.Cells(0).Value
                    If codigo = articulo.Codigo Then

                        art.Cells(2).Value += 1
                        inRow = True
                        Exit For
                    End If

                Next

                If Not inRow Then
                    Dim row As DataGridViewRow = ItemsDataGridView.Rows(0).Clone()
                    row.Cells(0).Value = articulo.Codigo
                    row.Cells(1).Value = articulo.Descripcion
                    row.Cells(2).Value = 1
                    row.Cells(3).Value = articulo.Precio
                    row.Cells(4).Value = articulo.Itebis
                    ItemsDataGridView.Rows.Add(row)
                    Dim item As Item = New Item(0, row.Cells(0).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value)
                    Pedido.Items.Add(item)

                End If
            End If
        End If
        TotalLabel.Text = CalcularFactura().ToString()
    End Sub

    Public Function CalcularFactura() As Double

        Dim total As Double = 0
        For Each row As DataGridViewRow In ItemsDataGridView.Rows

            total += (row.Cells(2).Value * row.Cells(3).Value) + (row.Cells(2).Value * (row.Cells(4).Value / 100))

        Next
        Return total
    End Function

    Private Sub ItemsDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsDataGridView.CellEndEdit

        TotalLabel.Text = CalcularFactura().ToString()
        Pedido.Items(e.RowIndex).Cantidad = ItemsDataGridView.Rows(e.RowIndex).Cells(2).Value
        Pedido.Items(e.RowIndex).Precio = ItemsDataGridView.Rows(e.RowIndex).Cells(3).Value
        Pedido.Items(e.RowIndex).Itbis = ItemsDataGridView.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub BuscarClienteButton_Click(sender As Object, e As EventArgs) Handles BuscarClienteButton.Click
        Dim form As SeleccionarCliente = New SeleccionarCliente()
        form.Owner = Me
        form.ShowDialog(Me)
    End Sub

    Private Sub GuardarButton_Click(sender As Object, e As EventArgs) Handles GuardarButton.Click

        If Pedido.Cliente IsNot Nothing And ItemsDataGridView.Rows.Count > 0 Then
            Dim codigo As Integer = 0
            Integer.TryParse(CodigoMaskedTextBox.Text, codigo)
            Pedido.Fecha = Date.Now
            Pedido.Codigo = codigo
            CodigoMaskedTextBox.Text = PedidosBLL.Guardar(Pedido).ToString()
        End If
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click

        If Not String.IsNullOrWhiteSpace(CodigoMaskedTextBox.Text) Then
            ItemsDataGridView.Rows.Clear()
            Dim codigo As Integer = Integer.Parse(CodigoMaskedTextBox.Text)
            Pedido = PedidosBLL.Buscar(codigo)
            If Pedido IsNot Nothing Then
                FechaDateTimePicker.Value = Pedido.Fecha
                ClienteTextBox.Text = Pedido.Cliente.Nombre

                For Each item As Item In Pedido.Items
                    If ItemsDataGridView.Rows.Count = 0 Then

                        Dim row As DataGridViewRow = New DataGridViewRow()
                        ItemsDataGridView.Rows.Add(row)
                        row.Cells(0).Value = item.CodigoArticulo
                        row.Cells(1).Value = ArticuloBLL.Buscar(item.CodigoArticulo).Descripcion
                        row.Cells(2).Value = item.Cantidad
                        row.Cells(3).Value = item.Precio
                        row.Cells(4).Value = item.Itbis

                    Else

                        Dim row As DataGridViewRow = ItemsDataGridView.Rows(0).Clone()
                        row.Cells(0).Value = item.CodigoArticulo
                        row.Cells(1).Value = ArticuloBLL.Buscar(item.CodigoArticulo).Descripcion
                        row.Cells(2).Value = item.Cantidad
                        row.Cells(3).Value = item.Precio
                        row.Cells(4).Value = item.Itbis
                        ItemsDataGridView.Rows.Add(row)

                    End If
                Next
            Else
                MessageBox.Show("Pedido no existe!")
            End If
        End If
    End Sub

    Private Sub Limpiar()

        CodigoMaskedTextBox.Clear()
        ClienteTextBox.Clear()
        ArticulosComboBox.SelectedIndex = -1
        ItemsDataGridView.Rows.Clear()

    End Sub
End Class