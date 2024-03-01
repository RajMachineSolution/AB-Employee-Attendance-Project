<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Forget_Password_Page
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
        Me.btnEmpSavePassword = New System.Windows.Forms.Button()
        Me.txtEmpConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtEmpNewPswd = New System.Windows.Forms.TextBox()
        Me.lblEmpConfirmPswd = New System.Windows.Forms.Label()
        Me.lblEmpNewPswd = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEmpSavePassword
        '
        Me.btnEmpSavePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpSavePassword.Location = New System.Drawing.Point(174, 251)
        Me.btnEmpSavePassword.Name = "btnEmpSavePassword"
        Me.btnEmpSavePassword.Size = New System.Drawing.Size(87, 30)
        Me.btnEmpSavePassword.TabIndex = 0
        Me.btnEmpSavePassword.Text = "Save"
        Me.btnEmpSavePassword.UseVisualStyleBackColor = True
        '
        'txtEmpConfirmPassword
        '
        Me.txtEmpConfirmPassword.Location = New System.Drawing.Point(147, 193)
        Me.txtEmpConfirmPassword.Multiline = True
        Me.txtEmpConfirmPassword.Name = "txtEmpConfirmPassword"
        Me.txtEmpConfirmPassword.Size = New System.Drawing.Size(160, 30)
        Me.txtEmpConfirmPassword.TabIndex = 1
        '
        'txtEmpNewPswd
        '
        Me.txtEmpNewPswd.Location = New System.Drawing.Point(147, 111)
        Me.txtEmpNewPswd.Multiline = True
        Me.txtEmpNewPswd.Name = "txtEmpNewPswd"
        Me.txtEmpNewPswd.Size = New System.Drawing.Size(160, 30)
        Me.txtEmpNewPswd.TabIndex = 2
        '
        'lblEmpConfirmPswd
        '
        Me.lblEmpConfirmPswd.AutoSize = True
        Me.lblEmpConfirmPswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpConfirmPswd.Location = New System.Drawing.Point(153, 155)
        Me.lblEmpConfirmPswd.Name = "lblEmpConfirmPswd"
        Me.lblEmpConfirmPswd.Size = New System.Drawing.Size(137, 20)
        Me.lblEmpConfirmPswd.TabIndex = 3
        Me.lblEmpConfirmPswd.Text = "Confirm Password"
        '
        'lblEmpNewPswd
        '
        Me.lblEmpNewPswd.AutoSize = True
        Me.lblEmpNewPswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpNewPswd.Location = New System.Drawing.Point(170, 79)
        Me.lblEmpNewPswd.Name = "lblEmpNewPswd"
        Me.lblEmpNewPswd.Size = New System.Drawing.Size(113, 20)
        Me.lblEmpNewPswd.TabIndex = 4
        Me.lblEmpNewPswd.Text = "New Password"
        '
        'Employee_Forget_Password_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.lblEmpNewPswd)
        Me.Controls.Add(Me.lblEmpConfirmPswd)
        Me.Controls.Add(Me.txtEmpNewPswd)
        Me.Controls.Add(Me.txtEmpConfirmPassword)
        Me.Controls.Add(Me.btnEmpSavePassword)
        Me.Name = "Employee_Forget_Password_Page"
        Me.Text = "Employee_Forget_Password_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEmpSavePassword As Button
    Friend WithEvents txtEmpConfirmPassword As TextBox
    Friend WithEvents txtEmpNewPswd As TextBox
    Friend WithEvents lblEmpConfirmPswd As Label
    Friend WithEvents lblEmpNewPswd As Label
End Class
