Public Class ModifyEmployeeDataPage

    Dim Empdata1() As String
    Private Sub btnUpdateEmpData_Click(sender As Object, e As EventArgs) Handles btnUpdateEmpData.Click

        Dim srno As Integer = Val(txtSerialNo.Text)
        Dim pswd As String = txtPassword.Text
        Dim Address1 As String = txtAddress.Text
        Dim PhnNum As Integer = Val(txtPhoneNumber.Text)
        Dim UsrName As String = txtUserName.Text
        Dim emlId As String = txtEmailId.Text
        Dim fathrName As String = txtFatherName.Text
        Dim empName As String = txtEmployeeName.Text
        Dim dob As String = txtDateOfBirth.Text
        Dim EmpAdmin As String = txtEmployeeOrAdmin.Text
        Dim query As String = "update employeepersonaldetails set [serial no] = '" & srno & "', [Employee's Name] = '" & empName & "', [Date of Birth] = '" & dob & "', [Phone Number] = '" & PhnNum & "', [fathers's name] = '" & fathrName & "', [Address] = '" & Address1 & "', [Email id] = '" & emlId & "', [userName] = '" & UsrName & "', [Password] = '" & pswd & "', [Employee/Admin] = '" & EmpAdmin & "' where [employee id] = '" & txtEmployeeId.Text & "'"
        If clsdbConn.count1 <> 0 Then
            clsdbConn.UpdateEmployeeData(query)
            MessageBox.Show("Update data Successfully")
        Else
            MessageBox.Show("no data Update")
        End If
        setnothing()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim varEmpId As String = txtEmployeeId.Text
        clsdbConn.SearchEmployeeData(varEmpId)


        If IsNothing(clsdbConn.results2) Then
            Exit Sub
        Else
            Empdata1 = clsdbConn.results2.Split(",")
            MessageBox.Show("successfully fetchdata")
            txtSerialNo.Text = ToString(Val(Empdata1(0)) + 1)
            txtEmployeeId.Text = Empdata1(1)
            txtEmployeeName.Text = Empdata1(2)
            txtDateOfBirth.Text = Empdata1(3)
            txtPhoneNumber.Text = Empdata1(4)
            txtFatherName.Text = Empdata1(5)
            txtAddress.Text = Empdata1(6)
            txtEmailId.Text = Empdata1(7)
            txtUserName.Text = Empdata1(8)
            txtPassword.Text = Empdata1(9)
            txtEmployeeOrAdmin.Text = Empdata1(10)
        End If

    End Sub

    Private Sub ModifyEmployeeDataPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDeleteEmpData_Click(sender As Object, e As EventArgs) Handles btnDeleteEmpData.Click
        Dim varempId As String = txtEmployeeId.Text
        Dim opt As Integer = MsgBox(" delete employee " & varempId, MessageBoxButtons.YesNo)
        If opt = DialogResult.Yes Then
            clsdbConn.DeleteEmployeeData(varempId)
        End If
        setnothing()
    End Sub

    Public Sub setnothing()
        Dim varsetnothing As Integer = Nothing
        txtSerialNo.Text = varsetnothing
        txtEmployeeId.Text = varsetnothing
        txtEmployeeName.Text = varsetnothing
        txtDateOfBirth.Text = varsetnothing
        txtPhoneNumber.Text = varsetnothing
        txtFatherName.Text = varsetnothing
        txtAddress.Text = varsetnothing
        txtEmailId.Text = varsetnothing
        txtUserName.Text = varsetnothing
        txtPassword.Text = varsetnothing
        txtEmployeeOrAdmin.Text = varsetnothing
    End Sub

    Private Sub txtEmployeeOrAdmin_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeOrAdmin.TextChanged

    End Sub
End Class