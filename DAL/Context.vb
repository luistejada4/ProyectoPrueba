Imports System.Data.SqlClient
Public Class Context
    Inherits Dispose


    Public ConString As String = My.Settings.ConnectionString

    Private Connection As SqlConnection
    Private Cmd As SqlCommand

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposed Then
            If disposing Then


            End If

            Connection.Dispose()
            Cmd.Dispose()

        End If
        MyBase.Dispose(disposing)
    End Sub

    Public Sub New()

        Me.Connection = New SqlConnection(ConString)
        Me.Cmd = New SqlCommand()


    End Sub

    Public Function Ejecutar(ByVal sql As String, ByVal identity As Boolean) As Integer

        Dim i = 0

        Try
            Me.Connection.Open()
            Me.Cmd.Connection = Me.Connection
            Me.Cmd.CommandText = sql
            If identity Then
                i = Me.Cmd.ExecuteScalar()
            Else
                i = Me.Cmd.ExecuteNonQuery()
            End If
            Me.Connection.Close()
        Catch ex As Exception

            Throw ex

        End Try

        Return i

    End Function

    Public Function SelectData(ByVal sql As String) As DataTable

        Dim dt As DataTable = Nothing
        Try
            Me.Connection.Open()
            Dim sqlAdapter = New SqlDataAdapter(sql, Me.Connection)
            dt = New DataTable("DataTable")
            sqlAdapter.Fill(dt)
            Me.Connection.Close()
        Catch ex As Exception

        End Try

        Return dt
    End Function


End Class
