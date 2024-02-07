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

        If intScore = 17 Then
            intScore = 4
            playerOne4.Visible = True
            playerOne17.Visible = False
        ElseIf intScore = 19 Then
            intScore = 7
            playerOne7.Visible = True
            playerOne19.Visible = False
        ElseIf intScore = 21 Then
            intScore = 9
            playerOne9.Visible = True
            playerOne21.Visible = False
        ElseIf intScore = 27 Then
            intScore = 1
            playerOne1.Visible = True
            playerOne27.Visible = False
        ElseIf intScore = 5 Then
            intScore = 8
            playerOne8.Visible = True
            playerOne5.Visible = False
        ElseIf intScore = 3 Then
            intScore = 22
            playerOne22.Visible = True
            playerOne3.Visible = False
        ElseIf intScore = 11 Then
            intScore = 26
            playerOne26.Visible = True
            playerOne11.Visible = False
        ElseIf intScore = 20 Then
            intScore = 29
            playerOne29.Visible = True
            playerOne20.Visible = False
        ElseIf intScore = 30 Then
            lblWinner.Text = "Player 1 Is the Winner!"
            lblWinner.Visible = True
        End If








        If intScore2 = 17 Then
            intScore2 = 4
            playerTwo4.Visible = True
            playerTwo17.Visible = False
        ElseIf intScore2 = 19 Then
            intScore2 = 7
            playerTwo7.Visible = True
            playerTwo19.Visible = False
        ElseIf intScore2 = 21 Then
            intScore2 = 9
            playerTwo9.Visible = True
            playerTwo21.Visible = False
        ElseIf intScore2 = 27 Then
            intScore2 = 1
            playerTwo1.Visible = True
            playerTwo27.Visible = False
        ElseIf intScore2 = 5 Then
            intScore2 = 8
            playerTwo8.Visible = True
            playerTwo5.Visible = False
        ElseIf intScore2 = 3 Then
            intScore2 = 22
            playerTwo22.Visible = True
            playerTwo3.Visible = False
        ElseIf intScore2 = 11 Then
            intScore2 = 26
            playerTwo26.Visible = True
            playerTwo11.Visible = False
        ElseIf intScore2 = 20 Then
            intScore2 = 29
            playerTwo29.Visible = True
            playerTwo20.Visible = False
        ElseIf intScore2 = 30 Then
            lblWinner.Text = "Player 2 Is the Winner!"
            lblWinner.Visible = True
        End If


















    End Sub
End Class
