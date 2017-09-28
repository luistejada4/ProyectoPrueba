Imports BLL

Public Class SeleccionarCliente
    Private Sub SeleccionarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClientesDataGridView.AutoGenerateColumns = False
        Dim dt As DataTable
        dt = ClientesBLL.Listar()
        ClientesDataGridView.DataSource = dt
    End Sub

    Private Sub ClientesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientesDataGridView.CellContentClick

        Pedidos.Pedido.Cliente = ClientesBLL.Buscar(ClientesDataGridView.Rows(e.RowIndex).Cells(0).Value)
        Dim parent As Pedidos = Me.ParentForm
        Dim form As Pedidos = Me.Owner
        form.ClienteTextBox.Text = Pedidos.Pedido.Cliente.Nombre
        Me.Close()

    End Sub

    Private Sub BuscarTextBox_TextChanged(sender As Object, e As EventArgs) Handles BuscarTextBox.TextChanged

        Dim text As String = BuscarTextBox.Text
        Dim dt As DataTable = ClientesBLL.Listar("Select * from Clientes where upper(Nombre) like '%" & text & "%';")
        ClientesDataGridView.DataSource = dt
    End Sub
End Class