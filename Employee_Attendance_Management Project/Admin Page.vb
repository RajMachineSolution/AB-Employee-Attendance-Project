Public Class Admin_Page

    Private Sub btnAdminModifyEmployeeData_Click(sender As Object, e As EventArgs) Handles btnAdminModifyEmployeeData.Click
        frm8AdMdfyDtPg.ShowDialog()
    End Sub

    Private Sub btnAdminViewAttendance_Click(sender As Object, e As EventArgs) Handles btnAdminViewAttendance.Click
        frm8VwAtndncPg.ShowDialog()
    End Sub

    Private Sub btnAdminShowEmployeeData_Click(sender As Object, e As EventArgs) Handles btnAdminShowEmployeeData.Click
        frm8SwEmpDtPg.ShowDialog()
    End Sub

    Private Sub btnAdminAttendance_Click(sender As Object, e As EventArgs) Handles btnAdminAttendance.Click
        mrkAttendncePg.ShowDialog()
    End Sub

    Private Sub btnAdminChangePassword_Click(sender As Object, e As EventArgs) Handles btnAdminChangePassword.Click
        frm8ChngPswdPg.ShowDialog()
    End Sub
End Class