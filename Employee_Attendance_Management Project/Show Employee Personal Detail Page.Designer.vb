<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_Employee_Personal_Detail_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOneEmployeePersonalDetail = New System.Windows.Forms.Button()
        Me.btnAllEmployeePersonalDetails = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOneEmployeePersonalDetail
        '
        Me.btnOneEmployeePersonalDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOneEmployeePersonalDetail.Location = New System.Drawing.Point(99, 78)
        Me.btnOneEmployeePersonalDetail.Name = "btnOneEmployeePersonalDetail"
        Me.btnOneEmployeePersonalDetail.Size = New System.Drawing.Size(250, 60)
        Me.btnOneEmployeePersonalDetail.TabIndex = 0
        Me.btnOneEmployeePersonalDetail.Text = "Particular Employee Personal Detail"
        Me.btnOneEmployeePersonalDetail.UseVisualStyleBackColor = True
        '
        'btnAllEmployeePersonalDetails
        '
        Me.btnAllEmployeePersonalDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllEmployeePersonalDetails.Location = New System.Drawing.Point(99, 155)
        Me.btnAllEmployeePersonalDetails.Name = "btnAllEmployeePersonalDetails"
        Me.btnAllEmployeePersonalDetails.Size = New System.Drawing.Size(250, 60)
        Me.btnAllEmployeePersonalDetails.TabIndex = 1
        Me.btnAllEmployeePersonalDetails.Text = "All Employee Personal Details"
        Me.btnAllEmployeePersonalDetails.UseVisualStyleBackColor = True
        '
        'Show_Employee_Personal_Detail_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.btnAllEmployeePersonalDetails)
        Me.Controls.Add(Me.btnOneEmployeePersonalDetail)
        Me.Name = "Show_Employee_Personal_Detail_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show_Employee_Personal_Detail_Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOneEmployeePersonalDetail As Button
    Friend WithEvents btnAllEmployeePersonalDetails As Button
End Class
