Public Class Articulo

    Private _Codigo As Integer
    Public Property Codigo() As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property

    Private _Descripcion As String
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Private _Costo As Double
    Public Property Costo() As Double
        Get
            Return _Costo
        End Get
        Set(ByVal value As Double)
            _Costo = value
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
    Public Property Itebis() As Double
        Get
            Return _Itbis
        End Get
        Set(ByVal value As Double)
            _Itbis = value
        End Set
    End Property

    Private _Ganancia As Double
    Public Property Ganancia() As Double
        Get
            Return _Ganancia
        End Get
        Set(ByVal value As Double)
            _Ganancia = value
        End Set
    End Property

    Private _Existencia As Integer
    Public Property Existencia() As Integer
        Get
            Return _Existencia
        End Get
        Set(ByVal value As Integer)
            _Existencia = value
        End Set
    End Property

    Public Sub New(ByVal codigo As Integer, ByVal descripcion As String, ByVal costo As Double, ByVal precio As Double, ByVal ganancia As Double, ByVal itbis As Double, ByVal existencia As Integer)

        Me._Codigo = codigo
        Me._Costo = costo
        Me._Descripcion = descripcion
        Me._Existencia = existencia
        Me._Itbis = itbis
        Me._Precio = precio
        Me._Ganancia = ganancia


    End Sub
End Class
