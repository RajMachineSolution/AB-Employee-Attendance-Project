Module mdDatabaseQuery
    Public clsdbConn As New DatabaseConnection
    Public mdgetresults As String
    Public mdgetresultsar As String()
    Public NotduplicateKey As Boolean

    Dim query3 As String = "select [serial no],[Employee Id] from employeePersonalDetails where [Employee Id] = '" & frm8AdNwEmpPg.empId & "' "

    Public Sub mdDbExecuteQuery(query As String, FrmName As String)

        clsdbConn.myCmd = clsdbConn.myConn.CreateCommand
        clsdbConn.da = New SqlClient.SqlDataAdapter(clsdbConn.myCmd)

        NotduplicateKey = True
        If FrmName = "AdNwEmPgbtn" Then
            clsdbConn.myCmd.CommandText = query
            clsdbConn.myConn.Open()
            clsdbConn.myReader = clsdbConn.myCmd.ExecuteReader()
            If clsdbConn.myReader.Read() Then
                clsdbConn.myConn.Close()
                MessageBox.Show("duplicate id")
                NotduplicateKey = False
                clsdbConn.myConn.Close()
            End If
            clsdbConn.myConn.Close()

        Else

            clsdbConn.myConn.Close()

            clsdbConn.myCmd.CommandText = query
            clsdbConn.myConn.Open()

            Select Case FrmName

                Case "AdNwEmpPgLd"
                    clsdbConn.myReader = clsdbConn.myCmd.ExecuteReader
                    Do While clsdbConn.myReader.Read()
                        mdgetresults = clsdbConn.myReader.GetValue(0)
                    Loop
                    clsdbConn.myReader.Close()

                Case "frgtPswdPgSndBtnOtp"
                    clsdbConn.myReader = clsdbConn.myCmd.ExecuteReader
                    Do While clsdbConn.myReader.Read()
                        mdgetresults = clsdbConn.myReader.GetValue(0)
                    Loop
                    clsdbConn.myReader.Close()
            End Select

            clsdbConn.myConn.Close()
        End If


    End Sub

End Module
