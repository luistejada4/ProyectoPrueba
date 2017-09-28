Public Class Item


    Private _Codigo As String
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Private _CodigoPedido As Integer
    Public Property CodigoPedido() As Integer
        Get
            Return _CodigoPedido
        End Get
        Set(ByVal value As Integer)
            _CodigoPedido = value
        End Set
    End Property

    Private _CodigoArticulo As Integer
    Public Property CodigoArticulo() As Integer
        Get
            Return _CodigoArticulo
        End Get
        Set(ByVal value As Integer)
            _CodigoArticulo = value
        End Set
    End Property

    Private _Cantidad As Integer
    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Private _Precio As Double
    Public Property Precio() As Double
        Get
            Return _Precio
        End Get
        Set(ByVal value As Double)
            _Precio = value
        End Set
    End Property

    Private _Itbis As Double
    Public Property Itbis() As Double
        Get
            Return _Itbis
        End Get
        Set(ByVal value As Double)
            _Itbis = value
        End Set
    End Property

    Public Sub New(ByVal codigo As Integer, ByVal codigoArticulo As Integer, ByVal cantidad As Integer, ByVal precio As Double, ByVal itbis As Integer)

        Me._Codigo = codigo
        Me._CodigoArticulo = codigoArticulo
        Me._Cantidad = cantidad
        Me._Precio = precio
        Me._Itbis = itbis


    End Sub

End Class
