Public Class Employee_Forget_Password_Page
    Dim varEmpId2 As String
    Private Sub btnEmpSavePassword_Click(sender As Object, e As EventArgs) Handles btnEmpSavePassword.Click
        varEmpId2 = frm3EmpLgnPg.varEmpIdd1
    End Sub

    Private Sub Employee_Forget_Password_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim varNewPassword As String = txtEmpNewPswd.Text
        Dim varConfirmPassword As String = txtEmpConfirmPassword.Text
        Dim query11 As String
        If varNewPassword = varConfirmPassword Then
            query11 = "Update employeePersonaldetails set [Password] = '" & varNewPassword & "' where [Employee Id] = '" & varEmpId2 & "' "
            clsdbConn.UpdateEmployeeData(query11)
            MessageBox.Show("password changed Successfully")
        Else
            MessageBox.Show("password unmatched")
        End If

    End Sub
End Class