Public Class Add_New_Employee_Page
    Public empId As String
    Dim pswd1 As String()
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim date1 As String = txtDateOfBirth.Text
        empId = txtEmployeeId.Text
        Dim serial As Integer = Val(txtSerialNo.Text)
        Dim pswd As String = txtPassword.Text
        Dim Address1 As String = txtAddress.Text
        Dim PhnNum As Integer = Val(txtPhoneNumber.Text)
        Dim UsrName As String = txtUserName.Text
        Dim emlId As String = txtEmailId.Text
        Dim fathrName As String = txtFatherName.Text
        Dim empName As String = txtEmployeeName.Text
        Dim EmpAdmin As String = txtEmployeeOrAdmin.Text

        Dim query1 As String = "insert into EmployeePersonalDetails([serial no],[Employee Id],[Employee's name],[Date Of Birth], [Phone Number],[fathers's Name],[Address],[Email id],[UserName],[Password],[Employee/Admin]) values('" & serial & "','" & empId & "','" & empName & "','" & date1 & "','" & PhnNum & "','" & fathrName & "','" & Address1 & "', '" & emlId & "','" & UsrName & "', '" & pswd & "','" & EmpAdmin & "')"
        Dim EmpIdQuery As String = "select [serial no],[Employee Id] from employeePersonalDetails where [Employee Id] = '" & empId & "' "
        mdDbExecuteQuery(EmpIdQuery, "AdNwEmPgbtn")

        If txtEmployeeId.Text = Nothing Or txtSerialNo.Text = Nothing Or txtEmployeeName.Text = Nothing Or txtEmailId.Text = Nothing Or txtPassword.Text = Nothing Or txtEmployeeOrAdmin.Text = Nothing Then
            MessageBox.Show("fill details")

        ElseIf NotduplicateKey = True Then
            clsdbConn.InsertEmployeData(EmpIdQuery, query1)
            MessageBox.Show("Add Successfully")
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Add_New_Employee_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CountQuery As String = "select count(*) from EmployeePersonalDetails"
        mdDbExecuteQuery(CountQuery, "AdNwEmpPgLd")
        txtSerialNo.Text = mdgetresults
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
End Class