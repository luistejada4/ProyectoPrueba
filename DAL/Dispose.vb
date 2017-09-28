Public Class Dispose
    Implements IDisposable

    ' Keep track of when the object is disposed. 
    Protected disposed As Boolean = False

    ' This method disposes the base object's resources. 
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposed Then
            If disposing Then
                ' Insert code to free managed resources. 
            End If
            ' Insert code to free unmanaged resources. 
        End If
        Me.disposed = True
    End Sub

#Region " IDisposable Support "
    ' Do not change or add Overridable to these methods. 
    ' Put cleanup code in Dispose(ByVal disposing As Boolean). 
    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
    Protected Overrides Sub Finalize()
        Dispose(False)
        MyBase.Finalize()
    End Sub
#End Region

End Class
