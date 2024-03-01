<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Page
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
        Me.btnAdminViewAttendance = New System.Windows.Forms.Button()
        Me.btnAdminShowEmployeeData = New System.Windows.Forms.Button()
        Me.btnAdminModifyEmployeeData = New System.Windows.Forms.Button()
        Me.btnAdminAttendance = New System.Windows.Forms.Button()
        Me.btnAdminChangePassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdminViewAttendance
        '
        Me.btnAdminViewAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminViewAttendance.Location = New System.Drawing.Point(101, 12)
        Me.btnAdminViewAttendance.Name = "btnAdminViewAttendance"
        Me.btnAdminViewAttendance.Size = New System.Drawing.Size(250, 60)
        Me.btnAdminViewAttendance.TabIndex = 0
        Me.btnAdminViewAttendance.Text = "View Attendance"
        Me.btnAdminViewAttendance.UseVisualStyleBackColor = True
        '
        'btnAdminShowEmployeeData
        '
        Me.btnAdminShowEmployeeData.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminShowEmployeeData.Location = New System.Drawing.Point(101, 88)
        Me.btnAdminShowEmployeeData.Name = "btnAdminShowEmployeeData"
        Me.btnAdminShowEmployeeData.Size = New System.Drawing.Size(250, 60)
        Me.btnAdminShowEmployeeData.TabIndex = 1
        Me.btnAdminShowEmployeeData.Text = "Show Employee Data"
        Me.btnAdminShowEmployeeData.UseVisualStyleBackColor = True
        '
        'btnAdminModifyEmployeeData
        '
        Me.btnAdminModifyEmployeeData.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminModifyEmployeeData.Location = New System.Drawing.Point(101, 167)
        Me.btnAdminModifyEmployeeData.Name = "btnAdminModifyEmployeeData"
        Me.btnAdminModifyEmployeeData.Size = New System.Drawing.Size(250, 60)
        Me.btnAdminModifyEmployeeData.TabIndex = 2
        Me.btnAdminModifyEmployeeData.Text = "Add and Modify Employee Data"
        Me.btnAdminModifyEmployeeData.UseVisualStyleBackColor = True
        '
        'btnAdminAttendance
        '
        Me.btnAdminAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminAttendance.Location = New System.Drawing.Point(101, 243)
        Me.btnAdminAttendance.Name = "btnAdminAttendance"
        Me.btnAdminAttendance.Size = New System.Drawing.Size(250, 60)
        Me.btnAdminAttendance.TabIndex = 3
        Me.btnAdminAttendance.Text = "Mark Attendance"
        Me.btnAdminAttendance.UseVisualStyleBackColor = True
        '
        'btnAdminChangePassword
        '
        Me.btnAdminChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminChangePassword.Location = New System.Drawing.Point(101, 320)
        Me.btnAdminChangePassword.Name = "btnAdminChangePassword"
        Me.btnAdminChangePassword.Size = New System.Drawing.Size(250, 60)
        Me.btnAdminChangePassword.TabIndex = 4
        Me.btnAdminChangePassword.Text = "Change Password"
        Me.btnAdminChangePassword.UseVisualStyleBackColor = True
        '
        'Admin_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.btnAdminChangePassword)
        Me.Controls.Add(Me.btnAdminAttendance)
        Me.Controls.Add(Me.btnAdminModifyEmployeeData)
        Me.Controls.Add(Me.btnAdminShowEmployeeData)
        Me.Controls.Add(Me.btnAdminViewAttendance)
        Me.Name = "Admin_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdminViewAttendance As Button
    Friend WithEvents btnAdminShowEmployeeData As Button
    Friend WithEvents btnAdminModifyEmployeeData As Button
    Friend WithEvents btnAdminAttendance As Button
    Friend WithEvents btnAdminChangePassword As Button
End Class
