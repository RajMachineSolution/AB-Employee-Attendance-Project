Public Class form1
    Dim frm2AdminLoginPage As New Admin_Login_Page
    Dim frm3EmployeeLoginPage As New Employee_Login_Page

    Public clsDC1 As New DatabaseConnection
    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        frm2AdminLoginPage.ShowDialog()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        frm3EmployeeLoginPage.ShowDialog()
    End Sub
End Class
