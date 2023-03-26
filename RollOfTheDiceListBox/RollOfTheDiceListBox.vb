'Christopher Pickens
'RCET0265
'Spring 2023
'Roll of the Dice List Box
'https://github.com/Pickchr2/RollOfTheDiceListBox

Option Explicit On
Option Strict On

Public Class RollOfTheDiceListBox
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        RollResultListBox.Items.Clear()
        RollButton.Select()
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click, RollToolStripMenuItem.Click
        Dim randomNumber As New Random()
        Dim resultCounter(11) As Integer
        Dim headerRow As String = ""
        Dim dataRow As String = ""

        RollResultListBox.Items.Clear()
        For i As Integer = 1 To 1000

            resultCounter(CInt(randomNumber.Next(0, 11))) += 1

        Next

        For j As Integer = 2 To 12
            headerRow &= (CStr(j).PadLeft(7) & "|")
        Next

        For k As Integer = 0 To 10
            dataRow &= (CStr(resultCounter(k)).PadLeft(6) & "|")
        Next

        RollResultListBox.Items.Add("-----------------------------------------------------------------------------")
        RollResultListBox.Items.Add(headerRow)
        RollResultListBox.Items.Add(dataRow)
        RollResultListBox.Items.Add("-----------------------------------------------------------------------------")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This application will roll two 6-sided dice 1000 times and print the results in the box.", "About", MessageBoxButtons.OK)
    End Sub
End Class
