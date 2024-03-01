Public Class Show_Employee_Personal_Detail_Page
    Private Sub btnOneEmployeePersonalDetail_Click(sender As Object, e As EventArgs) Handles btnOneEmployeePersonalDetail.Click

        Dim varEmpId As String
        Dim i As Integer = 0

        varEmpId = InputBox("Enter Employee Id ")

        clsdbConn.SearchEmployeeData(varEmpId)

        If varEmpId = "" Then
            MessageBox.Show("enter Id")

        ElseIf clsdbConn.count1 <> 0 Then
            frmOneEmpPrsnlDetailPg.ShowDialog()
        End If
    End Sub

    Private Sub btnAllEmployeePersonalDetails_Click(sender As Object, e As EventArgs) Handles btnAllEmployeePersonalDetails.Click
        frmAllEmpPrsnlDetailPg.ShowDialog()
    End Sub
End Class