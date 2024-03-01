Public Class Admin_Login_Page
    Public frm8AdminPage As New Admin_Page

    Public Shared varAdminIdd1 As String
    Dim i As Integer


    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Dim AdminLoginPage2 As String = "AdminLoginbtn"
        Dim varAdminId As String = TxtAdminUsernameOrId.Text
        varAdminIdd1 = varAdminId

        Dim varAdminPassword As String = txtAdminPassword.Text
        Dim Query1 As String = "select Password from EmployeePersonalDetails where [Employee Id] = '" & varAdminId & "' and [Employee/Admin] = 'Admin' "
        clsdbConn.LoginEmployeeOrAdminFrm(Query1, AdminLoginPage2)
        If varAdminId = Nothing Or varAdminPassword = Nothing Then
            MessageBox.Show("filled information")
        ElseIf i >= 3 Then
            MessageBox.Show("go to Forget Password")
        Else

            If varAdminPassword = Trim(clsdbConn.dcgetresults1) Then
                MessageBox.Show("done")
                frm8AdminPage.ShowDialog()
                i = 0
            Else
                MessageBox.Show("incorrect password")
                i = i + 1
            End If

        End If

    End Sub

    Private Sub TxtAdminUsernameOrId_TextChanged(sender As Object, e As EventArgs) Handles TxtAdminUsernameOrId.TextChanged

    End Sub

    Private Sub txtAdminPassword_TextChanged(sender As Object, e As EventArgs) Handles txtAdminPassword.TextChanged

    End Sub

    Private Sub Admin_Login_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lklblAdminForgetPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklblAdminForgetPassword.LinkClicked

        lklblAdminForgetPassword.LinkVisited = True
        frm2frgtPswdPg.ShowDialog()

    End Sub
End Class