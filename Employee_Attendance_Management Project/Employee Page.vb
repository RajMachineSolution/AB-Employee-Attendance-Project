Public Class Employee_Page
    Dim frm5MarkAttendancePage As New Mark_Attendace_Page



    Private Sub Employee_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEmployeeMarkAttendance_Click(sender As Object, e As EventArgs) Handles btnEmployeeMarkAttendance.Click
        EmpmrkAttendancePg.ShowDialog()
    End Sub

    Private Sub btnEmployeeShowAttendance_Click(sender As Object, e As EventArgs) Handles btnEmployeeShowAttendance.Click
        EmpShwAttendancePg.ShowDialog()
    End Sub
End Class