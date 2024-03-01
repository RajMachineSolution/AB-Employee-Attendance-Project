Public Class Add_Modify_Data_Page
    Private Sub btnAddNewEmployeeData_Click(sender As Object, e As EventArgs) Handles btnAddNewEmployeeData.Click
        frm11AdNwEmpData.ShowDialog()
    End Sub

    Private Sub btnModifyEmployeeData_Click(sender As Object, e As EventArgs) Handles btnModifyEmployeeData.Click
        frm11MdfyEmpDataPg.ShowDialog()
    End Sub
End Class