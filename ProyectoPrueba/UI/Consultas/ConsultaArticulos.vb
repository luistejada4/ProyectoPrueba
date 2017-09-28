Imports BLL

Public Class ConsultaArticulos

    Private Sub ConsultaArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ArticulosDataGridView.AutoGenerateColumns = False
    End Sub
    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

        Dim dt As DataTable = Nothing

        Dim text As String = BuscarTextBox.Text

        If Not String.IsNullOrWhiteSpace(text) Then

            Select Case FiltrarComboBox.SelectedIndex
                Case 0

                    Dim codigo As Integer = Integer.Parse(text)
                    dt = ArticuloBLL.Listar("Select * From Articulos where Codigo = " & codigo & "")
                Case 1
                    dt = ArticuloBLL.Listar("Select * From Articulos where upper(Descripcion) like upper('% " & text & " %') ")
                Case 2
                    Dim costo As Double = Double.Parse(text)
                    dt = ArticuloBLL.Listar("Select * From Articulos where Codigo = " & costo & "")
                Case 3
                    Dim precio As Double = Double.Parse(text)
                    dt = ArticuloBLL.Listar("Select * From Articulos where Codigo = " & Precio & "")
                Case 4

                    Dim ganancia As Double = Double.Parse(text)
                    dt = ArticuloBLL.Listar("Select * From Articulos where Codigo = " & ganancia & "")
                Case 5
                    Dim itbis As Double = Double.Parse(text)
                    dt = ArticuloBLL.Listar("Select * From Articulos where Codigo = " & itbis & "")
            End Select
        Else
            dt = ArticuloBLL.Listar("Select * From Articulos")
        End If

        ArticulosDataGridView.DataSource = dt
    End Sub


End Class