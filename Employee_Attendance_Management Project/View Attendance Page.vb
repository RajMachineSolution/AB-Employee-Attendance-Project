Public Class View_Attendance_Page
    Dim countcheck1 As Integer
    Dim query10 As String = "select * from EmployeeAttendance where [Marked Attendance] is null and [out time] is not null  "
    Private Sub View_Attendance_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DataGridView1.Rows.Count <> 0 Then
            clsdbConn.dt1.Clear()
        End If
        clsdbConn.ShowEmployeeData1(query10)

        DataGridView1.DataSource = clsdbConn.dt1
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim checkboxcolumn As New DataGridViewCheckBoxColumn()
        checkboxcolumn.Name = 'Mark Attendance'
         checkboxcolumn.ReadOnly = False

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim value1 As Boolean = TypeOf DataGridView1.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn AndAlso e.ColumnIndex = 0
            If value1 Then
                DataGridView1.EndEdit()

                Dim isChecked As Boolean = CBool(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Dim varId3, vardate As String
                If isChecked Then
                    countcheck1 = countcheck1 + 1
                    varId3 = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                    vardate = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
                    Dim query13 As String = "Update EmployeeAttendance set [Marked Attendance] = 'Approved' where [Employee id] = '" & varId3 & "' and Date = '" & vardate & "' "

                    MessageBox.Show("Approved" & countcheck1 & "  " & varId3)
                    clsdbConn.UpdateEmployeeData(query13)
                Else
                    countcheck1 = countcheck1 - 1

                    varId3 = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                    vardate = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
                    Dim query14 As String = "Update EmployeeAttendance set [Marked Attendance] = 'Not Approved' where [Employee id] = '" & varId3 & "' and Date = '" & vardate & "' "

                    MessageBox.Show("unApproved" & countcheck1)
                    clsdbConn.UpdateEmployeeData(query14)
                End If
            End If
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If DataGridView1.Rows.Count <> 0 Then
            clsdbConn.dt1.Clear()
        End If
        clsdbConn.ShowEmployeeData1(query10)
        DataGridView1.DataSource = clsdbConn.dt1
    End Sub
End Class