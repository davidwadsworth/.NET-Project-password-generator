Imports System.Text

Public NotInheritable Class MainPage
    Inherits Page

    Dim multipliers = New Double() {Math.Cos(18), 1 / Math.PI, Math.Sqrt(2), 9, 27 / 5, 1 / 3, 21, Math.E, Math.Log10(14), Math.Pow(2, -6), 1, Math.Pow(Math.E, Math.PI), Math.Sinh(1 / 13), 1 / 2, 3, 4 / 5, 17, 0.2351, 90, 1 / 14}

    Private Function getCharFromNumber(ByVal num As Int32) As Char
        If num > 0 And num < 95 Then
            Return ChrW(num + 32)
        End If
        Return "?"
    End Function

    Private Function getNumberFromString(ByVal str As String) As Int32
        Dim value As Int32 = 0

        For Each c As Char In str
            value += Convert.ToByte(c)
        Next

        Return value
    End Function

    Private Sub submit_Btn_Click(sender As Object, e As RoutedEventArgs) Handles submit_Btn.Click
        Dim keywordNum As Int32 = getNumberFromString(keyword_TxtBox.Text)
        Dim passwordChar As Char
        Dim password As StringBuilder = New StringBuilder

        For Each multiple As Double In multipliers
            passwordChar = getCharFromNumber(Math.Round(keywordNum * multiple) Mod 95)
            password.Append(passwordChar)
        Next

        keywordPassword_TxtBox.Text = password.ToString
    End Sub

End Class
