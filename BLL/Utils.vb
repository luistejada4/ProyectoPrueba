Imports System.Globalization

Public Class Utils

    Public Shared Function ConvertirDouble(ByVal valor As Double) As String

        Dim customCurrencyInfo As CultureInfo = CultureInfo.CreateSpecificCulture("en-Us")

        customCurrencyInfo.NumberFormat.CurrencyNegativePattern = 8

        Dim formatString As String = valor.ToString("C", customCurrencyInfo)
        Return formatString
    End Function

End Class
