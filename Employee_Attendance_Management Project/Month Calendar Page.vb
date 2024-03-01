Public Class Month_Calendar_Page
    Public varStartDate As String
    Public varEndDate As String
    Private Sub SelectYearMonthDate_DateChanged(sender As Object, e As DateRangeEventArgs) Handles SelectYearMonthDate.DateChanged

    End Sub


    Private Sub btnSetDate_Click(sender As Object, e As EventArgs) Handles btnSetDate.Click
        varStartDate = txtStartDate.Text
        varEndDate = txtEndDate.Text
        Me.Close()
    End Sub

    Private Sub txtEndDate_Click(sender As Object, e As EventArgs) Handles txtEndDate.Click
        txtEndDate.Text = SelectYearMonthDate.SelectionEnd.ToString("yyyy-MM-dd")
    End Sub

    Private Sub txtStartDate_Click(sender As Object, e As EventArgs) Handles txtStartDate.Click
        txtStartDate.Text = SelectYearMonthDate.SelectionStart.ToString("yyyy-MM-dd")
    End Sub
End Class