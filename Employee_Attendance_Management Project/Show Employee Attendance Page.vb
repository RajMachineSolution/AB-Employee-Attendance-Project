Public Class Show_Employee_Attendance_Page
    Public varStartDate1, varEndDate1 As String

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        varStartDate1 = txtStartDate.Text
        varEndDate1 = txtEndDate.Text
        ShwEmpAttendanceInDgv.ShowDialog()
        Me.Close()
    End Sub

    Private Sub txtEndDate_Click(sender As Object, e As EventArgs) Handles txtEndDate.Click
        txtEndDate.Text = MonthCalendar1.SelectionEnd.ToString("yyyy-MM-dd")
    End Sub

    Private Sub txtStartDate_Click(sender As Object, e As EventArgs) Handles txtStartDate.Click
        txtStartDate.Text = MonthCalendar1.SelectionStart.ToString("yyyy-MM-dd")
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub
End Class