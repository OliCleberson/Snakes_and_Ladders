Public Class dice
    Private Shared random As New Random()

    Public Shared Function roll() As Integer
        Return random.Next(1, 7)
    End Function

End Class
