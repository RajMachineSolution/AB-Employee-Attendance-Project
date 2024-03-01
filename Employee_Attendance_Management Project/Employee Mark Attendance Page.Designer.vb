<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Mark_Attendance_Page
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
        Me.btnArrivingTime = New System.Windows.Forms.Button()
        Me.btnEmpLeavingTime = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnArrivingTime
        '
        Me.btnArrivingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArrivingTime.Location = New System.Drawing.Point(103, 95)
        Me.btnArrivingTime.Name = "btnArrivingTime"
        Me.btnArrivingTime.Size = New System.Drawing.Size(250, 60)
        Me.btnArrivingTime.TabIndex = 0
        Me.btnArrivingTime.Text = "Arriving Time"
        Me.btnArrivingTime.UseVisualStyleBackColor = True
        '
        'btnEmpLeavingTime
        '
        Me.btnEmpLeavingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpLeavingTime.Location = New System.Drawing.Point(103, 179)
        Me.btnEmpLeavingTime.Name = "btnEmpLeavingTime"
        Me.btnEmpLeavingTime.Size = New System.Drawing.Size(250, 60)
        Me.btnEmpLeavingTime.TabIndex = 1
        Me.btnEmpLeavingTime.Text = "Leaving Time"
        Me.btnEmpLeavingTime.UseVisualStyleBackColor = True
        '
        'Employee_Mark_Attendance_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.btnEmpLeavingTime)
        Me.Controls.Add(Me.btnArrivingTime)
        Me.Name = "Employee_Mark_Attendance_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee_Mark_Attendance_Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnArrivingTime As Button
    Friend WithEvents btnEmpLeavingTime As Button
End Class
