<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_Employee_Data_Page
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
        Me.btnshowEmpdataFromToDate = New System.Windows.Forms.Button()
        Me.btnEmpPersonalDetail = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnshowEmpdataFromToDate
        '
        Me.btnshowEmpdataFromToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshowEmpdataFromToDate.Location = New System.Drawing.Point(74, 79)
        Me.btnshowEmpdataFromToDate.Name = "btnshowEmpdataFromToDate"
        Me.btnshowEmpdataFromToDate.Size = New System.Drawing.Size(250, 60)
        Me.btnshowEmpdataFromToDate.TabIndex = 0
        Me.btnshowEmpdataFromToDate.Text = "To Date"
        Me.btnshowEmpdataFromToDate.UseVisualStyleBackColor = True
        '
        'btnEmpPersonalDetail
        '
        Me.btnEmpPersonalDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpPersonalDetail.Location = New System.Drawing.Point(74, 189)
        Me.btnEmpPersonalDetail.Name = "btnEmpPersonalDetail"
        Me.btnEmpPersonalDetail.Size = New System.Drawing.Size(250, 60)
        Me.btnEmpPersonalDetail.TabIndex = 1
        Me.btnEmpPersonalDetail.Text = "Personal Detail"
        Me.btnEmpPersonalDetail.UseVisualStyleBackColor = True
        '
        'Show_Employee_Data_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.btnEmpPersonalDetail)
        Me.Controls.Add(Me.btnshowEmpdataFromToDate)
        Me.Name = "Show_Employee_Data_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show_Employee_Data_Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnshowEmpdataFromToDate As Button
    Friend WithEvents btnEmpPersonalDetail As Button
End Class
