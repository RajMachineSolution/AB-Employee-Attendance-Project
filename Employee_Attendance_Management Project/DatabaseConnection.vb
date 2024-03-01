Imports System.Data.SqlClient
Public Class DatabaseConnection
    Public myConn As New SqlConnection("Data Source=Desktop-Asus;Initial Catalog=admin1;Integrated Security=True")
    Public myCmd As SqlCommand
    Public myReader As SqlDataReader
    Public da As New SqlDataAdapter()
    Public ds As New DataSet
    Public dt, dt1 As New DataTable()
    Public count1, count2 As Integer
    Public strcountInTime2, strcountOutTime2 As String
    Public notduplicate As Boolean
    Public results2 As String
    Public dcgetresults1 As String
    Public Sub connectionSql1()
        myCmd = myConn.CreateCommand
        da = New SqlDataAdapter(myCmd)
    End Sub
    Public Sub InsertEmployeData(query1 As String, query2 As String)

        Dim count1 As Integer
        myConn.Open()

        myCmd.CommandText = query1
        count1 = myCmd.ExecuteScalar()
        If count1 = 0 Then
            myCmd.CommandText = query2
            myCmd.ExecuteNonQuery()
        End If

        MessageBox.Show("Add New Employee Data Successfully")
        myConn.Close()

    End Sub
    Public Sub UpdateEmployeeData(updatequery1 As String)
        myCmd.CommandText = updatequery1
        myConn.Open()
        count1 = myCmd.ExecuteScalar()

        myConn.Close()

    End Sub
    Public Sub LoginEmployeeOrAdminFrm(query As String, frmName As String)
        myCmd = myConn.CreateCommand()
        myCmd.CommandText = query
        myConn.Open()

        Select Case frmName

            Case "AdminLoginbtn"
                myReader = myCmd.ExecuteReader
                Do While myReader.Read()
                    dcgetresults1 = myReader.GetValue(0)
                Loop
                myReader.Close()

            Case "EmployeeLoginbtn"
                myReader = myCmd.ExecuteReader
                Do While myReader.Read()
                    dcgetresults1 = myReader.GetValue(0)
                Loop
                myReader.Close()

        End Select
            myConn.Close()
    End Sub
    Public Sub SearchEmployeeData(VarEmpId As String)
        Dim Searchquery1 As String = "select count([serial no]) from employeePersonalDetails where [Employee Id] = '" & VarEmpId & "'"
        myCmd.CommandText = Searchquery1
        myConn.Open()
        count1 = myCmd.ExecuteScalar()
        If count1 = 0 Then
            MessageBox.Show("enter correct Id")
        Else
            myConn.Close()
            myCmd.CommandText = "select * from EmployeePersonalDetails where [Employee Id] = '" & VarEmpId & "' "
            myConn.Open()
            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                Dim EmpId As String = myReader.GetString(1)
                Dim srNo As String = myReader.GetValue(0).ToString()

                Dim EmpName As String = myReader.GetString(2)
                Dim dob As String = myReader.GetDateTime(3).ToString("yyyy-MM-dd")
                Dim phnnum As String = myReader.GetValue(4).ToString()
                Dim fathrName As String = If(myReader.IsDBNull(5), String.Empty, myReader.GetString(5))
                Dim Adrs As String = If(myReader.IsDBNull(6), String.Empty, myReader.GetString(6))
                Dim EmlId As String = If(myReader.IsDBNull(7), String.Empty, myReader.GetString(7))
                Dim usrname As String = If(myReader.IsDBNull(8), String.Empty, myReader.GetString(8))
                Dim pswd As String = myReader.GetString(9)
                Dim EmpOrAdmin As String = If(myReader.IsDBNull(10), String.Empty, myReader.GetString(10))

                results2 = srNo & "," & EmpId & "," & EmpName & "," & dob & "," & phnnum & "," & fathrName & "," & Adrs & "," & EmlId & "," & usrname & "," & pswd & "," & EmpOrAdmin
            Loop
            myReader.Close()

        End If
        myConn.Close()
    End Sub

    Public Sub DeleteEmployeeData(varEmpId As String)
        myCmd.CommandText = "delete from employeepersonaldetails where [employee id] = '" & varEmpId & "' "
        myConn.Open()
        count1 = myCmd.ExecuteScalar()
        If count1 = 0 Then
            MessageBox.Show("delete data successfully")
        Else
            MessageBox.Show("no deletion")
        End If
        myConn.Close()

    End Sub
    Public Sub showEmpDatafromtoDate(query As String, btnClick As String)
        count1 = 0
        myCmd = myConn.CreateCommand
        da = New SqlDataAdapter(myCmd)
        myCmd.CommandText = query

        myConn.Open()
        da.Fill(dt)
        myReader = myCmd.ExecuteReader

        myReader.Close()
        myConn.Close()

    End Sub

    Public Sub checkEmpData(varEmpId As String)
        myCmd.CommandText = "select [serial no] from employeePersonaldetails where [employee Id] = '" & varEmpId & "'"
        myConn.Open()
        count1 = myCmd.ExecuteScalar()
        myConn.Close()
    End Sub

    Public Sub checkEmpData1(query As String)
        myCmd.CommandText = query
        myConn.Open()
        count2 = myCmd.ExecuteScalar()
        myConn.Close()
    End Sub
    Public Sub ShowEmployeeData1(query As String)
        myCmd = myConn.CreateCommand()
        da = New SqlDataAdapter(myCmd)
        myCmd.CommandText = query
        myConn.Open()
        da.Fill(dt1)
        myReader = myCmd.ExecuteReader()
        myReader.Close()
        myConn.Close()
    End Sub

    Public Sub setInTimeInDb(query As String)

        myCmd.CommandText = query
        myConn.Open()
        count1 = myCmd.ExecuteScalar()
        myConn.Close()
        MessageBox.Show("Arriving Time Set")
    End Sub
    Public Sub setOutTimeInDb(Id1 As String, varTime1 As String, varDate1 As String)
        Dim query5, query6, query7 As String

        query5 = "Select [In time] from EmployeeAttendance where [Employee Id] = '" & Id1 & "' and [Date] = '" & varDate1 & "'"
        If Not IsNothing(Id1) Then
            myCmd.CommandText = query5
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            myReader.Read()
            strcountInTime2 = If(myReader.IsDBNull(0), String.Empty, myReader.GetValue(0).ToString())
            myReader.Close()
            myConn.Close()

            If Not IsNothing(strcountInTime2) Then

                query6 = "update EmployeeAttendance set [out time] = '" & varTime1 & "' where [Employee Id] = '" & Id1 & "' and [Date] = '" & varDate1 & "'"
                UpdateEmployeeData(query6)

                query7 = "Select [out time] from EmployeeAttendance where [Employee Id] = '" & Id1 & "' and [Date] = '" & varDate1 & "'"
                myCmd.CommandText = query7
                myConn.Open()
                myReader = myCmd.ExecuteReader()
                myReader.Read()
                strcountOutTime2 = If(myReader.IsDBNull(0), String.Empty, myReader.GetValue(0).ToString())
                myReader.Close()
                myConn.Close()

            Else
                MessageBox.Show("Arriving Time is not set")
                Exit Sub
            End If
        Else
            MessageBox.Show("id is not set")
        End If

    End Sub


End Class
