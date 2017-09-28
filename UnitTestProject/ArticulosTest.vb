Imports System.Text
Imports BLL
Imports Entidades
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class ArticulosTest

    <TestMethod()> Public Sub Guardar()

        'Arrange o planeamiento

        Dim articulo As Articulo = New Articulo(0, "Platano", 10, 15, 50, 12, 10)

        'Act o prueba

        Dim resultado As Integer = ArticuloBLL.Guardar(articulo)

        'Assert o afirmacion

        Assert.AreNotEqual(0, resultado)


    End Sub

End Class