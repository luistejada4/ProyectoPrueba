Public Class Pedido

    Private _Codigo As Integer
    Public Property Codigo() As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property

    Private _Fecha As Date
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    Private _Cliente As Cliente
    Public Property Cliente() As Cliente
        Get
            Return _Cliente
        End Get
        Set(ByVal value As Cliente)
            _Cliente = value
        End Set
    End Property

    Private _Items As List(Of Item)
    Public Property Items() As List(Of Item)
        Get
            Return _Items
        End Get
        Set(ByVal value As List(Of Item))
            _Items = value
        End Set
    End Property

    Public Sub New(ByVal codigo As Integer, ByVal fecha As Date, ByVal cliente As Cliente, ByVal items As List(Of Item))
        Me._Codigo = codigo
        Me._Fecha = fecha
        Me._Cliente = cliente
        Me._Items = items
    End Sub

    Public Sub New()

        _Items = New List(Of Item)

    End Sub

End Class
