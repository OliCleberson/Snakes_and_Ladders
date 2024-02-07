Public Class dice2
    Private Shared random2 As New Random()

    Public Shared Function roll2() As Integer
        Return random2.Next(1, 7)
    End Function
End Class
