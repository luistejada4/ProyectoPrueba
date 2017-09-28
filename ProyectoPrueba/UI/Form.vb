Public Class Form
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Application.Exit()

    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem2.Click

        Dim form As RegistroClientes = New RegistroClientes()
        form.ShowDialog(Me)

    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim form As ConsultarClientes = New ConsultarClientes()
        form.ShowDialog(Me)
    End Sub

    Private Sub ArticulosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem2.Click

        Dim form As RegistroArticulos = New RegistroArticulos()
        form.ShowDialog(Me)
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem.Click

        Dim form As ConsultaArticulos = New ConsultaArticulos()
        form.ShowDialog(Me)

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim form As Pedidos = New Pedidos()
        form.ShowDialog(Me)
    End Sub
End Class
