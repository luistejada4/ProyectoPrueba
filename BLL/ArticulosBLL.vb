Imports DAL
Imports Entidades

Public Class ArticuloBLL

    Public Shared Function Guardar(ByVal articulo As Articulo) As Integer

        If articulo.Codigo = 0 Then

            Dim context As Context = New Context()
            Dim sql As String = "Insert into Articulos (Descripcion, Costo, Precio, Ganancia, Itbis, Existencia) values ('" & articulo.Descripcion & "', " & Utils.ConvertirDouble(articulo.Costo) & ", " & Utils.ConvertirDouble(articulo.Precio) & ", " & Utils.ConvertirDouble(articulo.Ganancia) & ", " & Utils.ConvertirDouble(articulo.Itebis) & ", " & Utils.ConvertirDouble(articulo.Existencia) & ");  SELECT SCOPE_IDENTITY();"
            Dim lastIdentity As Integer = context.Ejecutar(sql, True)
            Return lastIdentity
        Else
            Modificar(articulo)
            Return articulo.Codigo
        End If
    End Function

    Public Shared Function Eliminar(ByVal codigo As Integer) As Integer

        Dim context As Context = New Context()
        Dim sql As String = "Delete from Articulos where Codigo = " & codigo & ""
        Dim lastIdentity As Integer = context.Ejecutar(sql, False)
        Return lastIdentity

    End Function

    Public Shared Function Modificar(ByVal articulo As Articulo) As Integer

        Dim context As Context = New Context()
        Dim sql As String = "Update from Articulos set Descripcion = '" & articulo.Descripcion & "', Costo = " & Utils.ConvertirDouble(articulo.Costo) & ", Precio = " & Utils.ConvertirDouble(articulo.Precio) & ", Ganancia = " & Utils.ConvertirDouble(articulo.Ganancia) & ", Itbis = " & Utils.ConvertirDouble(articulo.Itebis) & ", Exstencia = " & articulo.Existencia & ""
        Dim result As Integer = context.Ejecutar(sql, False)
        Return result
    End Function

    Public Shared Function Buscar(ByVal id As Integer) As Articulo

        Dim articulo As Articulo = Nothing
        Dim context As Context = New Context()
        Dim sql = "Select * from Articulos where Codigo = " & id & "; "
        Dim dt = context.SelectData(sql)
        If dt.Rows.Count > 0 Then
            articulo = New Articulo(dt.Rows(0)("Codigo"), dt.Rows(0)("Descripcion"), dt.Rows(0)("Costo"), dt.Rows(0)("Precio"), dt.Rows(0)("Ganancia"), dt.Rows(0)("Itbis"), dt.Rows(0)("Existencia"))
        End If
        Return articulo
    End Function

    Public Shared Function Listar() As DataTable
        Dim dt As DataTable = Nothing
        Dim context As Context = New Context()
        Dim sql = "Select * from Articulos"
        dt = context.SelectData(sql)
        Return dt
    End Function

    Public Shared Function Listar(ByVal query As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim context As Context = New Context()
        dt = context.SelectData(query)
        Return dt
    End Function

End Class
