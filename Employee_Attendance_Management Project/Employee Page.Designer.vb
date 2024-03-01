<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Page
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
        Me.btnEmployeeMarkAttendance = New System.Windows.Forms.Button()
        Me.btnEmployeeShowAttendance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEmployeeMarkAttendance
        '
        Me.btnEmployeeMarkAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeMarkAttendance.Location = New System.Drawing.Point(98, 83)
        Me.btnEmployeeMarkAttendance.Name = "btnEmployeeMarkAttendance"
        Me.btnEmployeeMarkAttendance.Size = New System.Drawing.Size(250, 60)
        Me.btnEmployeeMarkAttendance.TabIndex = 0
        Me.btnEmployeeMarkAttendance.Text = "Mark Attendence"
        Me.btnEmployeeMarkAttendance.UseVisualStyleBackColor = True
        '
        'btnEmployeeShowAttendance
        '
        Me.btnEmployeeShowAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeShowAttendance.Location = New System.Drawing.Point(98, 178)
        Me.btnEmployeeShowAttendance.Name = "btnEmployeeShowAttendance"
        Me.btnEmployeeShowAttendance.Size = New System.Drawing.Size(250, 60)
        Me.btnEmployeeShowAttendance.TabIndex = 1
        Me.btnEmployeeShowAttendance.Text = "Show Attendance"
        Me.btnEmployeeShowAttendance.UseVisualStyleBackColor = True
        '
        'Employee_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.btnEmployeeShowAttendance)
        Me.Controls.Add(Me.btnEmployeeMarkAttendance)
        Me.Name = "Employee_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee_Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEmployeeMarkAttendance As Button
    Friend WithEvents btnEmployeeShowAttendance As Button
End Class
