<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Modify_Data_Page
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
        Me.btnAddNewEmployeeData = New System.Windows.Forms.Button()
        Me.btnModifyEmployeeData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddNewEmployeeData
        '
        Me.btnAddNewEmployeeData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewEmployeeData.Location = New System.Drawing.Point(70, 100)
        Me.btnAddNewEmployeeData.Name = "btnAddNewEmployeeData"
        Me.btnAddNewEmployeeData.Size = New System.Drawing.Size(250, 50)
        Me.btnAddNewEmployeeData.TabIndex = 0
        Me.btnAddNewEmployeeData.Text = "Add New Employee "
        Me.btnAddNewEmployeeData.UseVisualStyleBackColor = True
        '
        'btnModifyEmployeeData
        '
        Me.btnModifyEmployeeData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyEmployeeData.Location = New System.Drawing.Point(70, 179)
        Me.btnModifyEmployeeData.Name = "btnModifyEmployeeData"
        Me.btnModifyEmployeeData.Size = New System.Drawing.Size(250, 50)
        Me.btnModifyEmployeeData.TabIndex = 1
        Me.btnModifyEmployeeData.Text = "Modify Employee Data"
        Me.btnModifyEmployeeData.UseVisualStyleBackColor = True
        '
        'Add_Modify_Data_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.btnModifyEmployeeData)
        Me.Controls.Add(Me.btnAddNewEmployeeData)
        Me.Name = "Add_Modify_Data_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Modify_Data_Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddNewEmployeeData As Button
    Friend WithEvents btnModifyEmployeeData As Button
End Class
