Public Class Forget_Password_Pagevb
    Public clsdbconn As New DatabaseConnection
    Public clscnntmails As New connect_Mails
    Public frmChngPswd As New Change_Password_Page
    Dim varId As String

    Dim vargenOtp As Integer
    Private Sub btnSendOTP_Click(sender As Object, e As EventArgs) Handles btnSendOTP.Click
        varId = txtUserNameOrId.Text
        Dim varEmailId As String = txtEmailId.Text
        Dim upperbound As Integer = 9998
        Dim lowerbound As Integer = 1000
        Dim dquery1 As String
        dquery1 = "select [Email Id] from EmployeePersonalDetails where [Employee Id] = '" & varId & "'"
        mdDbExecuteQuery(dquery1, "frgtPswdPgSndBtnOtp")
        If varEmailId = mdgetresults Then
            Randomize()
            vargenOtp = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            clscnntmails.SendOTP(vargenOtp, varEmailId)
        Else
            MessageBox.Show("enter correct Admin Id and Email Id ")
        End If

    End Sub

    Private Sub txtUserNameOrId_TextChanged(sender As Object, e As EventArgs) Handles txtUserNameOrId.TextChanged

    End Sub

    Private Sub txtEmailId_TextChanged(sender As Object, e As EventArgs) Handles txtEmailId.TextChanged

    End Sub

    Private Sub txtEnterOtp_TextChanged(sender As Object, e As EventArgs) Handles txtEnterOtp.TextChanged

    End Sub

    Private Sub btnEnterOTP_Click(sender As Object, e As EventArgs) Handles btnEnterOTP.Click
        Dim query12 As String = "select [Employee/Admin] from EmployeePersonaldetails where [Employee Id] ='" & varId & "'"
        If txtEnterOtp.Text = "" Then
            MessageBox.Show("enter otp")

        ElseIf vargenOtp = txtEnterOtp.Text Then
            mdDbExecuteQuery(query12, "frgtPswdPgSndBtnOtp")
            If mdgetresults = "Employee" Then
                frm3EmpfrgtPswdPg.ShowDialog()

            ElseIf mdgetresults = "Admin" Then
                frmChngPswd.ShowDialog()

            End If


        Else
                MessageBox.Show("incorrect otp")
        End If
    End Sub

    Private Sub Forget_Password_Pagevb_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class