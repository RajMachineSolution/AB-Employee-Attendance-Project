Public Class All_Employee_Personal_Detail_Page
    Private Sub All_Employee_Personal_Detail_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dgvShowAllEmployeeData.Rows.Count <> 0 Then
            clsdbConn.dt1.Clear()
        End If
        Dim query4 As String = "select * from employeePersonalDetails"
        clsdbConn.ShowEmployeeData1(query4)
        dgvShowAllEmployeeData.DataSource = clsdbConn.dt1

    End Sub

    Private Sub dgvShowAllEmployeeData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowAllEmployeeData.CellContentClick

    End Sub
End Class