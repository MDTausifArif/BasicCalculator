Public Class Form1


    Dim value1, value2 As Integer
    Dim sign As String


    Private Sub BtnOne_Click(sender As Object, e As EventArgs) Handles BtnOne.Click
        TextBox1.Text = TextBox1.Text & 1


    End Sub

    Private Sub BtnTwo_Click(sender As Object, e As EventArgs) Handles BtnTwo.Click
        TextBox1.Text = TextBox1.Text & 2

    End Sub

    Private Sub BtnThree_Click(sender As Object, e As EventArgs) Handles BtnThree.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub BtnFour_Click(sender As Object, e As EventArgs) Handles BtnFour.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub BtnFive_Click(sender As Object, e As EventArgs) Handles BtnFive.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub BtnSix_Click(sender As Object, e As EventArgs) Handles BtnSix.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub BtnSeven_Click(sender As Object, e As EventArgs) Handles BtnSeven.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub BtnEight_Click(sender As Object, e As EventArgs) Handles BtnEight.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub BtnNine_Click(sender As Object, e As EventArgs) Handles BtnNine.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub

    Private Sub BtnZero_Click(sender As Object, e As EventArgs) Handles BtnZero.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        value1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "+"

    End Sub

    Private Sub BtnSubstract_Click(sender As Object, e As EventArgs) Handles BtnSubstract.Click
        value1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "-"
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click
        value1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "*"
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        value1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "/"
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click
        value2 = TextBox1.Text
        If sign = "+" Then
            TextBox1.Text = value1 + value2
        ElseIf sign = "-" Then
            TextBox1.Text = value1 - value2

        ElseIf sign = "*" Then
            TextBox1.Text = value1 * value2

        Else sign = "/"
            TextBox1.Text = value1 / value2
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TextBox1.Clear()
        TextBox1.Focus()

    End Sub
End Class
