Public Class Mark_Attendace_Page

    Public varAdminId1 As String

    Private Sub btnEmployeeArrivingTime_Click(sender As Object, e As EventArgs) Handles btnEmployeeArrivingTime.Click
        Dim varDate As String = Date.Today
        Dim varTime As String = TimeOfDay
        Dim query4, query5 As String
        query5 = "select count(*) from EmployeeAttendance where [Date] = '" & varDate & "' and [Employee Id] = '" & varAdminId1 & "'"
        clsdbConn.checkEmpData1(query5)

        If clsdbConn.count2 <> 0 Then
            MessageBox.Show("Arriving time  is set already ")
        Else
            If Not IsNothing(varAdminId1) Then
                query4 = "insert into EmployeeAttendance([Employee Id],[Date],[In Time]) values('" & varAdminId1 & "','" & varDate & "','" & varTime & "')"
                clsdbConn.setInTimeInDb(query4)
            Else
                MessageBox.Show("Id is empty")
            End If
        End If

    End Sub

    Private Sub btnEmployeeLeavingTime_Click(sender As Object, e As EventArgs) Handles btnEmployeeLeavingTime.Click
        Dim query7 As String
        Dim varDate As String = Date.Today
        Dim varTime As String = TimeOfDay

        clsdbConn.setOutTimeInDb(varAdminId1, varTime, varDate)
        If Not IsNothing(clsdbConn.strcountInTime2) Then
            MessageBox.Show("Leaving Time set")
            Dim strDate1() As String = varDate.Split("/")
            Dim strStartTime1() As String = clsdbConn.strcountInTime2.Split(":")
            Dim strEndTime1() As String = clsdbConn.strcountOutTime2.Split(":")
            Dim strStartTime2 As New DateTime(strDate1(2), strDate1(0), strDate1(1), strStartTime1(0), strStartTime1(1), strStartTime1(2))
            Dim strEndTime2 As New DateTime(strDate1(2), strDate1(0), strDate1(1), strEndTime1(0), strEndTime1(1), strEndTime1(2))
            Dim timediff As TimeSpan = strEndTime2 - strStartTime2
            Dim workingtime1 As String = timediff.Hours & ":" & timediff.Minutes & ":" & timediff.Seconds
            query7 = "update EmployeeAttendance set [Working hour] = '" & workingtime1 & "' where [Date] = '" & varDate & "' and [Employee id] = '" & varAdminId1 & "'"
            clsdbConn.UpdateEmployeeData(query7)
        Else
            MessageBox.Show("Arriving time is not set")

        End If

    End Sub

    Private Sub Mark_Attendace_Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        varAdminId1 = Admin_Login_Page.varAdminIdd1

    End Sub
End Class