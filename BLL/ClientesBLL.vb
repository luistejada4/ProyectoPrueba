Imports System.Data.SqlClient
Imports Entidades
Imports DAL
Public Class ClientesBLL

    Public Shared Function Guardar(ByVal cliente As Cliente) As Integer

        If cliente.Codigo = 0 Then
            Dim context = New Context()
            Dim sql = "INSERT INTO Clientes(Nombre, Direccion) Values('" & cliente.Nombre & "', '" & cliente.Direccion & "'); SELECT SCOPE_IDENTITY();"
            Dim lastIdentity = context.Ejecutar(sql, True)
            Return lastIdentity
        Else

            Modificar(cliente)
            Return cliente.Codigo
        End If
    End Function

    Public Shared Function Eliminar(ByVal codigo As Integer) As Integer

        Dim context = New Context()
        Dim sql = "Delete from Clientes where Codigo = " & codigo & ""
        Dim lastIdentity = context.Ejecutar(sql, False)
        Return lastIdentity

    End Function

    Public Shared Function Modificar(ByVal cliente As Cliente) As Integer

        Dim context = New Context()
        Dim sql = "Update Clientes set Nombre = '" & cliente.Nombre & "', Direccion = '" & cliente.Direccion & "' where Codigo = " & cliente.Codigo & ""
        Dim result = context.Ejecutar(sql, False)
        Return result

    End Function

    Public Shared Function Buscar(ByVal id As Integer) As Cliente

        Dim cliente As Cliente = Nothing
        Dim context As Context = New Context()
        Dim sql = "Select * from Clientes where Codigo = " & id & "; "
        Dim dt = context.SelectData(sql)
        If dt.Rows.Count > 0 Then
            cliente = New Cliente(dt.Rows(0)("Codigo"), dt.Rows(0)("Nombre").ToString(), dt.Rows(0)("Direccion").ToString())
        End If
        Return cliente
    End Function

    Public Shared Function Listar() As DataTable
        Dim dt As DataTable = Nothing
        Dim context As Context = New Context()
        Dim sql = "Select * from Clientes"
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
