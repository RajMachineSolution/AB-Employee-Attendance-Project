<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Login_Page
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
        Me.lblEmployeeId = New System.Windows.Forms.Label()
        Me.lblEmployeePassword = New System.Windows.Forms.Label()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.txtEmployeePassword = New System.Windows.Forms.TextBox()
        Me.btnEmployeeLogin = New System.Windows.Forms.Button()
        Me.lklblForgetPassword = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblEmployeeId
        '
        Me.lblEmployeeId.AutoSize = True
        Me.lblEmployeeId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeId.Location = New System.Drawing.Point(161, 53)
        Me.lblEmployeeId.Name = "lblEmployeeId"
        Me.lblEmployeeId.Size = New System.Drawing.Size(97, 20)
        Me.lblEmployeeId.TabIndex = 0
        Me.lblEmployeeId.Text = "Employee Id"
        '
        'lblEmployeePassword
        '
        Me.lblEmployeePassword.AutoSize = True
        Me.lblEmployeePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeePassword.Location = New System.Drawing.Point(139, 134)
        Me.lblEmployeePassword.Name = "lblEmployeePassword"
        Me.lblEmployeePassword.Size = New System.Drawing.Size(152, 20)
        Me.lblEmployeePassword.TabIndex = 1
        Me.lblEmployeePassword.Text = "Employee Password"
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.Location = New System.Drawing.Point(131, 87)
        Me.txtEmployeeId.Multiline = True
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(160, 30)
        Me.txtEmployeeId.TabIndex = 2
        '
        'txtEmployeePassword
        '
        Me.txtEmployeePassword.Location = New System.Drawing.Point(131, 169)
        Me.txtEmployeePassword.Multiline = True
        Me.txtEmployeePassword.Name = "txtEmployeePassword"
        Me.txtEmployeePassword.Size = New System.Drawing.Size(160, 30)
        Me.txtEmployeePassword.TabIndex = 3
        '
        'btnEmployeeLogin
        '
        Me.btnEmployeeLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeLogin.Location = New System.Drawing.Point(167, 238)
        Me.btnEmployeeLogin.Name = "btnEmployeeLogin"
        Me.btnEmployeeLogin.Size = New System.Drawing.Size(91, 32)
        Me.btnEmployeeLogin.TabIndex = 5
        Me.btnEmployeeLogin.Text = "Login"
        Me.btnEmployeeLogin.UseVisualStyleBackColor = True
        '
        'lklblForgetPassword
        '
        Me.lklblForgetPassword.AutoSize = True
        Me.lklblForgetPassword.Location = New System.Drawing.Point(229, 202)
        Me.lklblForgetPassword.Name = "lklblForgetPassword"
        Me.lklblForgetPassword.Size = New System.Drawing.Size(86, 13)
        Me.lklblForgetPassword.TabIndex = 6
        Me.lklblForgetPassword.TabStop = True
        Me.lklblForgetPassword.Text = "Forget Password"
        '
        'Employee_Login_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.lklblForgetPassword)
        Me.Controls.Add(Me.btnEmployeeLogin)
        Me.Controls.Add(Me.txtEmployeePassword)
        Me.Controls.Add(Me.txtEmployeeId)
        Me.Controls.Add(Me.lblEmployeePassword)
        Me.Controls.Add(Me.lblEmployeeId)
        Me.Name = "Employee_Login_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee_Login_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmployeeId As Label
    Friend WithEvents lblEmployeePassword As Label
    Friend WithEvents txtEmployeeId As TextBox
    Friend WithEvents txtEmployeePassword As TextBox
    Friend WithEvents btnEmployeeLogin As Button
    Friend WithEvents lklblForgetPassword As LinkLabel
End Class
