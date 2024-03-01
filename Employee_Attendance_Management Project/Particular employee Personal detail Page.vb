Public Class Particular_employee_Personal_detail_Page
    Private Sub Particular_employee_Personal_detail_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setnothingdata1()
        Dim results3() As String
        results3 = clsdbConn.results2.Split(",")

        txtEmployeeName.Text = results3(2)
        txtDateOfBirth.Text = results3(3)
        txtPhoneNumber.Text = results3(4)
        txtFatherName.Text = results3(5)
        txtAddress.Text = results3(6)
        txtEmailId.Text = results3(7)
        txtUserName.Text = results3(8)
        txtPassword.Text = results3(9)
        txtEmployeeOrAdmin.Text = results3(10)
    End Sub

    Public Sub setnothingdata1()

        Dim varSetNothing As String = Nothing
        txtEmployeeName.Text = varSetNothing
        txtDateOfBirth.Text = varSetNothing
        txtPhoneNumber.Text = varSetNothing
        txtFatherName.Text = varSetNothing
        txtAddress.Text = varSetNothing
        txtEmailId.Text = varSetNothing
        txtUserName.Text = varSetNothing
        txtPassword.Text = varSetNothing
        txtEmployeeOrAdmin.Text = varSetNothing

    End Sub
End Class