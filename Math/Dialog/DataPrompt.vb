Imports System.Windows.Forms

Public Class DataPrompt
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Check for errors
        If operation.Text = "Addition" Or _
        operation.Text = "Subtraction" Or _
        operation.Text = "Multiplication" Or _
        operation.Text = "Division" Or _
        operation.Text = "Addition and Subtraction" Or _
        operation.Text = "Multiplication and Division" Or _
        operation.Text = "All" And _
        maximum.Value > 0 Then
            'Check type
            Dim type As Short
            If rbtNone.Checked Then
                type = 0
            ElseIf rbtTimer.Checked Then
                type = 1
            ElseIf rbtSetProbs.Checked Then
                type = 2
            End If
            Me.Opacity = 0
            'New Game
            Main.NewGame(operation.Text, maximum.Value, type, _
            If(type = 0, Nothing, If(rbtTimer.Checked, timerInput.Value, numProbInput.Value)))
            Main.StatusLabel.Text = "Ready"
            Me.Close()
        Else
            MsgBox("Invalid Operation.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Main.NewGame("Addition", 10, 0)
        Me.Close()
    End Sub
    Private Sub rbtNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNone.CheckedChanged
        timerInput.Enabled = False
        numProbInput.Enabled = False
    End Sub
    Private Sub rbtTimer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtTimer.CheckedChanged
        timerInput.Enabled = True
        numProbInput.Enabled = False
    End Sub
    Private Sub rbtSetProbs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSetProbs.CheckedChanged
        timerInput.Enabled = False
        numProbInput.Enabled = True
    End Sub
    Private Sub DataPrompt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 100
    End Sub
End Class
