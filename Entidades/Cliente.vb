Public Class Cliente

    Private _Codigo As Integer
    Public Property Codigo() As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property

    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Private _Direccion As String
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property

    Public Sub New(ByVal codigo As Integer, ByVal nombre As String, ByVal direccion As String)

        Me._Codigo = codigo
        Me._Nombre = nombre
        Me._Direccion = direccion

    End Sub
End Class
