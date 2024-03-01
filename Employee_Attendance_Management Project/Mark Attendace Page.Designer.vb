<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mark_Attendace_Page
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
        Me.btnEmployeeArrivingTime = New System.Windows.Forms.Button()
        Me.btnEmployeeLeavingTime = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEmployeeArrivingTime
        '
        Me.btnEmployeeArrivingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeArrivingTime.Location = New System.Drawing.Point(115, 94)
        Me.btnEmployeeArrivingTime.Name = "btnEmployeeArrivingTime"
        Me.btnEmployeeArrivingTime.Size = New System.Drawing.Size(250, 60)
        Me.btnEmployeeArrivingTime.TabIndex = 0
        Me.btnEmployeeArrivingTime.Text = "Arriving Time"
        Me.btnEmployeeArrivingTime.UseVisualStyleBackColor = True
        '
        'btnEmployeeLeavingTime
        '
        Me.btnEmployeeLeavingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeLeavingTime.Location = New System.Drawing.Point(115, 177)
        Me.btnEmployeeLeavingTime.Name = "btnEmployeeLeavingTime"
        Me.btnEmployeeLeavingTime.Size = New System.Drawing.Size(250, 60)
        Me.btnEmployeeLeavingTime.TabIndex = 1
        Me.btnEmployeeLeavingTime.Text = "Leaving Time"
        Me.btnEmployeeLeavingTime.UseVisualStyleBackColor = True
        '
        'Mark_Attendace_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.btnEmployeeLeavingTime)
        Me.Controls.Add(Me.btnEmployeeArrivingTime)
        Me.Name = "Mark_Attendace_Page"
        Me.Text = "Mark_Attendace_Page"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEmployeeArrivingTime As Button
    Friend WithEvents btnEmployeeLeavingTime As Button
End Class
