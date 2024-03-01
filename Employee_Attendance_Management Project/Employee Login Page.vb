Public Class Employee_Login_Page
    Dim frm4EmployeePage As New Employee_Page
    Public Shared varEmpIdd1 As String
    Dim i As Integer
    Private Sub btnEmployeeLogin_Click(sender As Object, e As EventArgs) Handles btnEmployeeLogin.Click
        Dim EmployeeLoginPage2 As String = "EmployeeLoginbtn"
        Dim varEmpId As String = txtEmployeeId.Text
        varEmpIdd1 = varEmpId

        Dim varEmpPassword As String = txtEmployeePassword.Text
        Dim Query1 As String = "select Password from EmployeePersonalDetails where [Employee Id] = '" & varEmpId & "' and [Employee/Admin] = 'Employee' "
        clsdbConn.LoginEmployeeOrAdminFrm(Query1, EmployeeLoginPage2)
        If varEmpId = Nothing Or varEmpPassword = Nothing Then
            MessageBox.Show("filled information")
        ElseIf i >= 3 Then
            MessageBox.Show("go to Forget Password")
        Else

            If varEmpPassword = Trim(clsdbConn.dcgetresults1) Then
                MessageBox.Show("done")
                frm4EmployeePage.ShowDialog()
                setnothing()
                i = 0
            Else
                MessageBox.Show("incorrect password")
                i = i + 1
            End If

        End If

    End Sub

    Private Sub lklblForgetPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblForgetPassword.LinkClicked
        lklblForgetPassword.LinkVisited = True
        frm2frgtPswdPg.ShowDialog()
    End Sub
    Public Sub setnothing()
        Dim varsetnothing As String = Nothing
        txtEmployeePassword.Text = varsetnothing
        txtEmployeeId.Text = varsetnothing
    End Sub

End Class