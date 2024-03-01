Public Class Show_Employee_Data_Page


    Private Sub btnEmpPersonalDetail_Click(sender As Object, e As EventArgs) Handles btnEmpPersonalDetail.Click
        frm10shwEmpPersnlDetailPg.ShowDialog()
    End Sub

    Private Sub btnshowEmpdataFromToDate_Click(sender As Object, e As EventArgs) Handles btnshowEmpdataFromToDate.Click
        frm10shwEmpToDtPg.ShowDialog()
    End Sub
End Class