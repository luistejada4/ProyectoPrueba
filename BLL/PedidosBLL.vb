Imports DAL
Imports Entidades

Public Class PedidosBLL

    Public Shared Function Guardar(ByRef pedido As Pedido) As Integer

        Dim context As Context = New Context()
        Dim lastIdentity As Integer = 0
        If pedido.Codigo = 0 Then

            Dim sql As String = "insert into Pedidos(ClienteCodigo, Fecha) values(" & pedido.Cliente.Codigo & ", '" & pedido.Fecha.Date & "'); select SCOPE_IDENTITY();"
            lastIdentity = context.Ejecutar(sql, True)
            pedido.Codigo = lastIdentity

            For Each item As Item In pedido.Items
                Dim codigoItem As Integer
                sql = "Insert into Items(CodigoPedido, CodigoArticulo, Precio, Cantidad, Itbis) values(" & lastIdentity & ", " & item.CodigoArticulo & ", " & item.Precio & ", " & item.Cantidad & ", " & item.Itbis & "); select SCOPE_IDENTITY();"
                codigoItem = context.Ejecutar(sql, True)
                item.Codigo = codigoItem
            Next
        Else
            For Each item As Item In pedido.Items
                Dim codigoItem As Integer
                Dim sql As String
                If item.Codigo = 0 Then

                    sql = "Insert into Items(CodigoPedido, CodigoArticulo, Precio, Cantidad, Itbis) values(" & pedido.Codigo & ", " & item.CodigoArticulo & ", " & item.Precio & ", " & item.Cantidad & ", " & item.Itbis & "); select SCOPE_IDENTITY();"
                    codigoItem = context.Ejecutar(sql, True)
                    item.Codigo = codigoItem
                Else
                    sql = "update Items set Cantidad = " & item.Cantidad & ", Precio = " & item.Precio & ", Itbis = " & item.Itbis & " where Codigo = " & item.Codigo & ""
                    context.Ejecutar(sql, False)
                End If

            Next

        End If
        Return pedido.Codigo
    End Function

    Public Shared Function Buscar(ByVal id As Integer) As Pedido

        Dim pedido As Pedido = Nothing
        Dim context = New Context()
        Dim sql As String = "Select * from Pedidos where Codigo = " & id & ";"
        Dim dt As DataTable = context.SelectData(sql)
        If dt.Rows.Count > 0 Then
            pedido = New Pedido()
            pedido.Codigo = dt.Rows(0)("Codigo")
            pedido.Fecha = dt.Rows(0)("Fecha")
            pedido.Cliente = ClientesBLL.Buscar(dt.Rows(0)("ClienteCodigo"))

            sql = "select * from Items where CodigoPedido = " & pedido.Codigo & ""
            dt = context.SelectData(sql)
            For Each item As DataRow In dt.Rows

                pedido.Items.Add(New Item(item("Codigo"), item("CodigoArticulo"), item("Cantidad"), item("Precio"), item("Itbis")))

            Next
        Else
        End If
        Return pedido
    End Function

End Class
