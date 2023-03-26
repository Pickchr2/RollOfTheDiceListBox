'Christopher Pickens
'RCET0265
'Spring 2023
'Roll of the Dice List Box
'https://github.com/Pickchr2/RollOfTheDiceListBox

Option Explicit On
Option Strict On

Public Class RollOfTheDiceListBox
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RollResultListBox.Items.Clear()
        RollButton.Select()
    End Sub
End Class
