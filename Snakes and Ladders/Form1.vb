Public Class Form1
    Dim turn As Integer = 1
    Dim intScore As Integer = 0
    Dim intScore2 As Integer = 0
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim strPlayerOne As String
        Dim strPlayerTwo As String
        Dim rolled As Integer = dice.roll()
        Dim rolled2 As Integer = dice2.roll2()

        turn = turn + 1

        If turn Mod 2 <> 0 = 0 Then

            lblRoll.Text = "Player 1"

            If (intScore + rolled) <= 30 Then

                If intScore > 0 Then
                    strPlayerOne = "playerOne" & intScore
                    Me.Controls(strPlayerOne).Visible = False
                End If

                intScore = intScore + rolled
                strPlayerOne = "playerOne" & intScore.ToString
                Me.Controls(strPlayerOne).Visible = True
            Else
                intScore = intScore
            End If


        Else

            lblRoll.Text = "Player 2"

            If (intScore2 + rolled2) <= 30 Then

                If intScore2 > 0 Then
                    strPlayerTwo = "playerTwo" & intScore2
                    Me.Controls(strPlayerTwo).Visible = False
                End If

                intScore2 = intScore2 + rolled2
                strPlayerTwo = "playerTwo" & intScore2.ToString
                Me.Controls(strPlayerTwo).Visible = True
            Else
                intScore2 = intScore2
            End If


        End If

        If 


















    End Sub
End Class
