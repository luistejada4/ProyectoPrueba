Imports BLL

Public Class ConsultarClientes

    Private Sub ConsultarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClientesDataGridView.AutoGenerateColumns = False

    End Sub
    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

        Dim dt As DataTable = Nothing

        Dim text As String = BuscarTextBox.Text

        If String.IsNullOrWhiteSpace(text) Then
            dt = ClientesBLL.Listar()
        Else

            Select Case FiltrarComboBox.SelectedIndex
                Case 0
                    Dim codigo As Integer = 0
                    Integer.TryParse(text, codigo)

                    dt = ClientesBLL.Listar("SELECT * from Clientes where Codigo = " & codigo & ";")

                Case 1

                    dt = ClientesBLL.Listar("Select * from Clientes where Upper(Nombre) like upper('%" & text & "%');")

                Case 2

                    dt = ClientesBLL.Listar("Select * from Clientes where Upper(Direccion) like upper('%" & text & "%');")

            End Select

        End If

        ClientesDataGridView.DataSource = dt

    End Sub


End Class