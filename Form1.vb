'Name: Sean Fox
'Course: CIT-161-Z03B
'Date: 5-22-19
'Program Name: Miles per Gallon Calculator
'Description: Chapter 3, Programming Challenge 1 - Create an application that calculates the miles per gallon a car achieves

Public Class Form1
    Private Sub BtnCalcMPG_Click(sender As Object, e As EventArgs) Handles btnCalcMPG.Click
        Try
            Dim dblGallons As Double = CDbl(txtGallons.Text)
            Dim dblMiles As Double = CDbl(txtMiles.Text)
            Dim dblTotal As Double = dblMiles / dblGallons
            lblTotalMPG.Text = dblTotal.ToString("n2")
        Catch ex As Exception
            MessageBox.Show("Only numeric values may be entered")
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallons.Clear()
        txtMiles.Clear()
        lblTotalMPG.Text = String.Empty
        txtGallons.Focus()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
