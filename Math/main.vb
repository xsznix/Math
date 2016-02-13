Public Class Main
    Friend operation As String
    Friend max As Integer
    Friend SetNumProb As Boolean
    Friend NumProbLeft As Integer
    Friend TimerOn As Boolean
    Friend TimeLeft As Integer
    Friend numRight As Integer
    Friend numWrong As Integer
    Friend score As Integer
    Dim inputAns As String
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        'Load default values
        Status.Text = "Loading..."
        Me.Text = "Math!"
        toolbarSeperatorTimer.Visible = False
        toolbarTime.Visible = False
        toolbarProbsLeft.Visible = False
        max = 10
        SetNumProb = False
        NumProbLeft = 0
        TimerOn = False
        TimeLeft = 0
        numRight = 0
        numWrong = 0
        Percent.Text = "0%"
        toolbarScore.Text = "0 pts."
        RightWrong.Text = "0 Wrong, 0 Right"
        toolbarOp.Text = ""
        prob1.Text = "poof"
        prob2.Text = "poof"
        prob3.Text = "poof"
        prob4.Text = "poof"
        prob5.Text = "poof"
        answer.Enabled = False
        check.Enabled = False
        operation = "Undef"
        toolbarOptions.Text = "Undef"
        StatusLabel.Text = "Waiting for data"
        '
        'Prompt Options
        '
        DataPrompt.ShowDialog()
    End Sub
    Private Sub Countdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Countdown.Tick
        TimeLeft -= 1
        If TimeLeft = 0 Then
            GameOver()
            Countdown.Enabled = False
        End If
        RefreshTime()
    End Sub
    Private Sub toolbarTime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbarTime.TextChanged
        If toolbarTime.Text = "00 secs" Then
            Countdown.Enabled = False
            GameOver()
        End If
    End Sub
    Private Sub menuNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuNewGame.Click
        AbortGame()
    End Sub
    Private Sub menuAddition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAddition.Click
        AbortGame("Addition", "Operation")
    End Sub
    Private Sub menuSubtraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSubtraction.Click
        AbortGame("Subtraction", "Operation")
    End Sub
    Private Sub menuMultiplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMultiplication.Click
        AbortGame("Multiplication", "Operation")
    End Sub
    Private Sub menuDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDivision.Click
        AbortGame("Division", "Operation")
    End Sub
    Private Sub menuOpAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuOpAS.Click
        AbortGame("Addition and Subtraction", "Operation")
    End Sub
    Private Sub menuOpMD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuOpMD.Click
        AbortGame("Multiplcation and Division", "Operation")
    End Sub
    Private Sub menuAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAll.Click
        AbortGame("All", "Operation")
    End Sub
    Private Sub range15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles range15.Click
        AbortGame(5, "Range")
    End Sub
    Private Sub range19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles range19.Click
        AbortGame(9, "Range")
    End Sub
    Private Sub range110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles range110.Click
        AbortGame(10, "Range")
    End Sub
    Private Sub range125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles range125.Click
        AbortGame(25, "Range")
    End Sub
    Private Sub range1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles range1000.Click
        AbortGame(100, "Range")
    End Sub
    Private Sub rangeCustom_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rangeCustom.KeyUp
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(rangeCustom.Text) Then
                AbortGame(rangeCustom.Text, "Range")
            End If
        End If
    End Sub
    Private Sub timerTimer_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles timerTimer.KeyUp
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(timerTimer.Text) Then
                AbortGame(timerTimer.Text, "Timer")
            End If
        End If
    End Sub
    Private Sub set5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set5.Click
        AbortGame(5, "Probs")
    End Sub
    Private Sub set10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set10.Click
        AbortGame(10, "Probs")
    End Sub
    Private Sub set25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set25.Click
        AbortGame(25, "Probs")
    End Sub
    Private Sub set100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set100.Click
        AbortGame(100, "Probs")
    End Sub
    Private Sub menuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuExit.Click
        Me.Close()
    End Sub
    Private Sub setCustom_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles setCustom.KeyUp
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(setCustom.Text) Then
                AbortGame(setCustom.Text, "Timer")
            End If
        End If
    End Sub
    Private Sub check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check.Click
        StatusLabel.Text = "Calculating..."
        Dim ans As Integer
        Dim oper As String
        Dim str As String
        Dim pos As Integer
        '
        'Check if numeric
        '
        If IsNumeric(answer.Text) Then
            '
            'Calculate operation
            '
            For i = 1 To prob1.Text.Length
                str = Mid(prob1.Text, i, 1)
                If str = "+" Or str = "-" Or str = "x" Or str = Chr(247) Then
                    oper = str
                    pos = i
                    Exit For
                End If
            Next i
            '
            'Calculate arguments
            '
            Dim arg1 As Integer
            Dim arg2 As Integer
            arg1 = CInt(Mid(prob1.Text, 1, pos - 2))
            arg2 = CInt(Mid(prob1.Text, pos + 2, prob1.Text.Length - (pos + 1)))
            Select Case oper
                Case "+"
                    ans = arg1 + arg2
                Case "-"
                    ans = arg1 - arg2
                Case "x"
                    ans = arg1 * arg2
                Case Chr(247)
                    ans = arg1 / arg2
            End Select
            '
            'Check if correct
            '
            If CInt(Int(answer.Text)) = ans Then
                numRight += 1
            Else
                numWrong += 1
            End If
        Else
            numWrong += 1
        End If
        '
        'Change score
        '
        If IsNumeric(answer.Text) Then
            score += ModScore(ans, answer.Text)
        Else
            score += ModScore(ans, -1)
        End If
        '
        'Check if game over
        '
        If prob2.Text = "" Or If(SetNumProb, NumProbLeft <= 0, False) Then
            GameOver()
        End If
        If SetNumProb Then
            NumProbLeft -= 1
        End If
        '
        'Refresh Statistics
        '
        RefreshStat()
        '
        'Generate Problems
        '
        prob1.Text = prob2.Text
        prob2.Text = prob3.Text
        prob3.Text = prob4.Text
        prob4.Text = prob5.Text
        If SetNumProb Then
            If NumProbLeft < 5 Then
                prob5.Text = ""
            Else
                prob5.Text = RndProb()
            End If
        Else
            prob5.Text = RndProb()
        End If
        answer.Text = ""
        StatusLabel.Text = "Ready"
    End Sub
    Private Sub reset()
        numRight = 0
        numWrong = 0
        Percent.Text = "%"
        toolbarScore.Text = "pts."
        toolbarOp.Text = "Undef."
        toolbarOptions.Text = "Undef"
        score = 0
        toolbarSeperatorTimer.Visible = False
        toolbarTime.Visible = False
        toolbarProbsLeft.Visible = False
    End Sub
    Private Sub aboutTerms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutTerms.Click
        MsgBox("Current action unavailable", MsgBoxStyle.Information)
    End Sub
    Private Sub aboutAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutAbout.Click
        About.ShowDialog()
    End Sub
    Private Sub RefreshTime()
        Dim x As Integer
        Dim mins As String
        Dim secs As String
        x = TimeLeft
        secs = CStr(x Mod 60)
        x -= CInt(secs)
        x = x / 60
        mins = CStr(x Mod 60)
        x -= CInt(mins)
        x = x / 60
        If CStr(mins).Length = 1 Then
            mins = "0" + mins
        End If
        If CStr(secs).Length = 1 Then
            secs = "0" + secs
        End If
        If x = 0 Then
            If mins = 0 Then
                toolbarTime.Text = secs + "secs"
            Else
                toolbarTime.Text = mins + ":" + secs
            End If
        Else
            toolbarTime.Text = CStr(x) + ":" + CStr(mins) + ":" + CStr(secs)
        End If
    End Sub
    Public Function RndInt(ByVal Limit As Integer)
        Randomize()
        Dim rnd1 As Integer = CInt(Int(Rnd() * Limit + 1))
        Return rnd1
    End Function
    Private Function RndProb() As String
        Dim oper As String
        Select Case operation
            Case "Addition"
                oper = "+"
            Case "Subtraction"
                oper = "-"
            Case "Multiplication"
                oper = "x"
            Case "Division"
                oper = Chr(247)
            Case "Addition and Subtraction"
                oper = If(RndInt(2) = 1, "+", "-")
            Case "Multiplication and Division"
                oper = If(RndInt(2) = 1, "x", Chr(247))
            Case "All"
                Select Case RndInt(4)
                    Case 1
                        oper = "+"
                    Case 2
                        oper = "-"
                    Case 3
                        oper = "x"
                    Case 4
                        oper = Chr(247)
                End Select
        End Select
        Dim arg1 As Integer = RndInt(max)
        Dim arg2 As Integer = RndInt(max)
        If oper = "+" Or oper = "x" Then
            Return CStr(arg1) + " " + oper + " " + CStr(arg2)
        ElseIf oper = "-" Then
            Return CStr(arg1 + arg2) + " " + oper + " " + CStr(arg2)
        ElseIf oper = Chr(247) Then
            Return CStr(arg1 * arg2) + " " + oper + " " + CStr(arg2)
        End If
    End Function
    Private Function Round(ByVal num As Double) As Double
        Dim num2 As Double
        If CStr(num).Length > 5 Then
            If Mid(CStr(num), 5) >= 5 Then
                num2 = CDbl(Mid(CStr(num), 1, 5)) + 0.01
            Else
                num2 = CDbl(Mid(CStr(num), 1, 5))
            End If
            Return num2
            Exit Function
        Else
            Return num
        End If
    End Function
    Private Sub RefreshStat()
        RightWrong.Text = CStr(numRight) + " Right, " + CStr(numWrong) + " Wrong"
        Percent.Text = CStr(Round(100 * numRight / (numRight + numWrong))) + "%"
        toolbarScore.Text = CStr(score) + " pts."
        toolbarProbsLeft.Text = "Problems Left: " + CStr(NumProbLeft)
    End Sub
    Friend Sub timerSet(ByVal mins As Integer)
        TimerOn = True
        TimeLeft = mins * 60
    End Sub
    Private Sub GameOver()
        RefreshStat()
        answer.Text = ""
        answer.Enabled = False
        check.Enabled = False
        toolbarSeperatorTimer.Visible = False
        toolbarTime.Visible = False
        toolbarProbsLeft.Visible = False
        MsgBox("Game Over. Your score is " + CStr(score), MsgBoxStyle.Information, "Happy Ending")
    End Sub
    Friend Sub NewGame(ByVal argOperation As String, ByVal argMax As Integer, ByVal options As Short, Optional ByVal optionVal As Integer = 0)
        reset()
        operation = argOperation
        toolbarOp.Text = argOperation
        max = argMax
        Select Case options
            Case 1
                toolbarOptions.Text = "Timer"
                timerSet(optionVal)
                toolbarSeperatorTimer.Visible = True
                toolbarTime.Visible = True
            Case 2
                toolbarOptions.Text = "Set # of Problems"
                SetNumProb = True
                NumProbLeft = optionVal
                toolbarSeperatorTimer.Visible = True
                toolbarProbsLeft.Visible = True
            Case Else
                toolbarOptions.Text = "None"
        End Select
        StartGame()
    End Sub
    Private Sub StartGame()
        If MsgBox("Start", MsgBoxStyle.OkOnly, "Wating for your signal") = MsgBoxResult.Ok Then
            If toolbarOptions.Text = "Timer" Then
                Countdown.Enabled = True
                RefreshTime()
            End If
            If SetNumProb Then
                If NumProbLeft < 5 Then
                    Select Case NumProbLeft
                        Case 4
                            prob1.Text = RndProb()
                            prob2.Text = RndProb()
                            prob3.Text = RndProb()
                            prob4.Text = RndProb()
                            prob5.Text = ""
                        Case 3
                            prob1.Text = RndProb()
                            prob2.Text = RndProb()
                            prob3.Text = RndProb()
                            prob4.Text = ""
                            prob5.Text = ""
                        Case 2
                            prob1.Text = RndProb()
                            prob2.Text = RndProb()
                            prob3.Text = ""
                            prob4.Text = ""
                            prob5.Text = ""
                        Case 1
                            prob1.Text = RndProb()
                            prob2.Text = ""
                            prob3.Text = ""
                            prob4.Text = ""
                            prob5.Text = ""
                    End Select
                End If
                toolbarProbsLeft.Text = NumProbLeft
            End If
            If Not prob5.Text = Nothing Then
                prob1.Text = RndProb()
                prob2.Text = RndProb()
                prob3.Text = RndProb()
                prob4.Text = RndProb()
                prob5.Text = RndProb()
            End If
            answer.Enabled = True
            check.Enabled = True
            RefreshStat()
        End If
    End Sub
    Friend Sub AbortGame(Optional ByVal Value As String = Nothing, Optional ByVal Type As String = "None")
        If MsgBox("You have a game going. Abort?", MsgBoxStyle.YesNo, "Confirm") Then
            DataPrompt.ShowDialog()
            Select Case Type
                Case "Time"
                    DataPrompt.rbtTimer.Checked = True
                    DataPrompt.timerInput.Value = Value
                Case "Probs"
                    DataPrompt.rbtSetProbs.Checked = True
                    DataPrompt.numProbInput.Value = Value
                Case "Range"
                    DataPrompt.maximum.Value = Value
                Case "Operation"
                    DataPrompt.operation.Text = Value
            End Select
            StatusLabel.Text = "Waiting for data..."
        End If
    End Sub
    Private Function ModScore(ByVal ans As Integer, ByVal input As Integer)
        If ans = input Then
            Select Case ans
                Case 0 To 10
                    Return 10
                Case 11 To 50
                    Return 15
                Case 51 To 100
                    Return 25
                Case 101 To 200
                    Return 30
                Case 201 To 500
                    Return 40
                Case 501 To 1000
                    Return 50
                Case 1001 To 5000
                    Return 60
                Case 5001 To 10000
                    Return 75
                Case Else
                    Return 100
            End Select
        Else
            Select Case ans
                Case 0 To 10
                    Return -10
                Case 11 To 50
                    Return -15
                Case 51 To 100
                    Return -25
                Case 101 To 200
                    Return -35
                Case 201 To 500
                    Return -40
                Case 501 To 1000
                    Return -45
                Case 1001 To 5000
                    Return -50
                Case 5001 To 10000
                    Return -70
                Case Else
                    Return -80
            End Select
        End If
    End Function
End Class
