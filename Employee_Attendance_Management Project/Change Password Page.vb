Public Class Change_Password_Page
    Dim varAdminId2 As String
    Private Sub Change_Password_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varAdminId2 = Admin_Login_Page.varAdminIdd1
    End Sub

    Private Sub btnSavePassword_Click(sender As Object, e As EventArgs) Handles btnSavePassword.Click
        Dim VarnewPswd As String = txtNewPassword.Text
        Dim varConfirmPswd As String = txtConfirmPassword.Text
        Dim query9 As String
        If VarnewPswd = varConfirmPswd Then
            query9 = "Update employeePersonaldetails set [Password] = '" & VarnewPswd & "' where [Employee Id] = '" & varAdminId2 & "'"
            clsdbConn.UpdateEmployeeData(query9)
            MessageBox.Show("password Change Successfully")
        Else
            MessageBox.Show(" Password is not matched ")
        End If

    End Sub

    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged

    End Sub
End Class