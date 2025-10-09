Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim gpa As Double = Double.Parse(TextBox1.Text)
            Dim income As Double = Double.Parse(TextBox2.Text)
            Dim communityHours As Integer = Integer.Parse(TextBox3.Text)


            Dim letterGrade As String = MapGpaToLetterGrade(gpa)
            Dim tier As String = DetermineScholarshipTier(gpa, income, communityHours)

            Me.letterGrade.Text = "Grade: " & letterGrade
            Me.tier.Text = "Scholarship Tier: " & tier

        Catch ex As Exception
            MessageBox.Show("Please enter valid numeric values for GPA, Income, and Community Hours.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function MapGpaToLetterGrade(ByVal gpa As Double) As String

        Select Case gpa
            Case Is >= 4.5
                Return "A"
            Case 4.0 To 4.49
                Return "B"
            Case 3.0 To 3.99
                Return "C"
            Case 2.0 To 2.99
                Return "D"
            Case Else
                Return "F"
        End Select
    End Function

    Private Function DetermineScholarshipTier(ByVal gpa As Double, ByVal income As Double, ByVal communityHours As Integer) As String

        If gpa >= 4.5 AndAlso communityHours >= 20 Then
            Return "Merit Full"
        ElseIf gpa >= 4.0 AndAlso communityHours >= 10 Then
            Return "Merit Partial"
        ElseIf income <= 2000 Then
            Return "Needs-Based"
        Else
            Return "Ineligible"
        End If
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
