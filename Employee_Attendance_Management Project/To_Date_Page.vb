Public Class To_Date_Page


    Private Sub btnShowAllEmpData_Click(sender As Object, e As EventArgs) Handles btnShowAllEmpData.Click
        frmMnthCalendar.ShowDialog()
        If dgvShowEmployeeData.Rows.Count <> 0 Then
            clsdbConn.dt.Clear()
        End If
        dgvShowEmployeeData.AutoSize = True
        Dim varstartDate1 As String = frmMnthCalendar.varStartDate
        Dim varEndDate1 As String = frmMnthCalendar.varEndDate
        Dim query1 As String = "Select * from EmployeeAttendance where [date] between '" & varstartDate1 & "' and '" & varEndDate1 & "'"
        clsdbConn.showEmpDataFromtoDate(query1, "All")
        dgvShowEmployeeData.DataSource = clsdbConn.dt
    End Sub

    Private Sub dgvShowEmployeeData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowEmployeeData.CellContentClick

    End Sub

    Private Sub btnShowOneEmpdata_Click(sender As Object, e As EventArgs) Handles btnShowOneEmpdata.Click
        Dim varEmpId As String
        Dim i As Integer
        If dgvShowEmployeeData.Rows.Count <> 0 Then
            clsdbConn.dt.Clear()
        End If
        Do While i < 3
            varEmpId = InputBox("Enter Employee data :- ")
            clsdbConn.checkEmpData(varEmpId)

            If varEmpId = "" Then
                Exit Sub
            ElseIf clsdbConn.count1 = 0 Then
                MessageBox.Show("enter correct employee Id")
                i = i + 1
            ElseIf clsdbConn.count1 <> 0 Then
                Exit Do
            End If
        Loop
        If i >= 3 Then
            Exit Sub
        End If


        frmMnthCalendar.ShowDialog()
        Dim varstartDate2 As String = frmMnthCalendar.varStartDate
        Dim varEndDate2 As String = frmMnthCalendar.varEndDate
        Dim query2 As String = "Select * from EmployeeAttendance where [Employee Id] = '" & varEmpId & "' and [date] between '" & varstartDate2 & "' and '" & varEndDate2 & "' "
        clsdbConn.showEmpDatafromtoDate(query2, "One")
        dgvShowEmployeeData.AutoSize = True
        dgvShowEmployeeData.DataSource = clsdbConn.dt

    End Sub

    Private Sub To_Date_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsdbConn.dt.Clear()
    End Sub
End Class