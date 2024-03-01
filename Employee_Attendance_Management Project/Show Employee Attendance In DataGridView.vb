Public Class Show_Employee_Attendance_In_DataGridView
    Dim varEmpId1 As String



    Private Sub Show_Employee_Attendance_In_DataGridView_Load(sender As Object, e As EventArgs) Handles Me.Load
        varEmpId1 = frm3EmpLgnPg.varEmpIdd1
        Dim varStartDate2 As String = EmpShwAttendancePg.varStartDate1
        Dim varEndDate2 As String = EmpShwAttendancePg.varEndDate1
        Dim query8 As String
        query8 = "select * from EmployeeAttendance where [Employee Id] = '" & varEmpId1 & "' "
        clsdbConn.dt1.Clear()
        clsdbConn.ShowEmployeeData1(query8)
        DataGridView1.DataSource = clsdbConn.dt1

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class