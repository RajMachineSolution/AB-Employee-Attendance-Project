<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Login_Page
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
        Me.lblAdminUsernameOrId = New System.Windows.Forms.Label()
        Me.lblAdminPassword = New System.Windows.Forms.Label()
        Me.TxtAdminUsernameOrId = New System.Windows.Forms.TextBox()
        Me.txtAdminPassword = New System.Windows.Forms.TextBox()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.lklblAdminForgetPassword = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblAdminUsernameOrId
        '
        Me.lblAdminUsernameOrId.AutoSize = True
        Me.lblAdminUsernameOrId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminUsernameOrId.Location = New System.Drawing.Point(169, 61)
        Me.lblAdminUsernameOrId.Name = "lblAdminUsernameOrId"
        Me.lblAdminUsernameOrId.Size = New System.Drawing.Size(72, 20)
        Me.lblAdminUsernameOrId.TabIndex = 0
        Me.lblAdminUsernameOrId.Text = "Admin Id"
        '
        'lblAdminPassword
        '
        Me.lblAdminPassword.AutoSize = True
        Me.lblAdminPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminPassword.Location = New System.Drawing.Point(146, 131)
        Me.lblAdminPassword.Name = "lblAdminPassword"
        Me.lblAdminPassword.Size = New System.Drawing.Size(127, 20)
        Me.lblAdminPassword.TabIndex = 1
        Me.lblAdminPassword.Text = "Admin Password"
        '
        'TxtAdminUsernameOrId
        '
        Me.TxtAdminUsernameOrId.Location = New System.Drawing.Point(132, 84)
        Me.TxtAdminUsernameOrId.Multiline = True
        Me.TxtAdminUsernameOrId.Name = "TxtAdminUsernameOrId"
        Me.TxtAdminUsernameOrId.Size = New System.Drawing.Size(160, 30)
        Me.TxtAdminUsernameOrId.TabIndex = 2
        '
        'txtAdminPassword
        '
        Me.txtAdminPassword.Location = New System.Drawing.Point(132, 154)
        Me.txtAdminPassword.Multiline = True
        Me.txtAdminPassword.Name = "txtAdminPassword"
        Me.txtAdminPassword.Size = New System.Drawing.Size(160, 30)
        Me.txtAdminPassword.TabIndex = 3
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminLogin.Location = New System.Drawing.Point(173, 222)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(91, 32)
        Me.btnAdminLogin.TabIndex = 5
        Me.btnAdminLogin.Text = "Login"
        Me.btnAdminLogin.UseVisualStyleBackColor = True
        '
        'lklblAdminForgetPassword
        '
        Me.lklblAdminForgetPassword.AutoSize = True
        Me.lklblAdminForgetPassword.Location = New System.Drawing.Point(228, 187)
        Me.lklblAdminForgetPassword.Name = "lklblAdminForgetPassword"
        Me.lklblAdminForgetPassword.Size = New System.Drawing.Size(86, 13)
        Me.lklblAdminForgetPassword.TabIndex = 6
        Me.lklblAdminForgetPassword.TabStop = True
        Me.lklblAdminForgetPassword.Text = "Forget Password"
        '
        'Admin_Login_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.lklblAdminForgetPassword)
        Me.Controls.Add(Me.btnAdminLogin)
        Me.Controls.Add(Me.txtAdminPassword)
        Me.Controls.Add(Me.TxtAdminUsernameOrId)
        Me.Controls.Add(Me.lblAdminPassword)
        Me.Controls.Add(Me.lblAdminUsernameOrId)
        Me.Name = "Admin_Login_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Login_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdminUsernameOrId As Label
    Friend WithEvents lblAdminPassword As Label
    Friend WithEvents TxtAdminUsernameOrId As TextBox
    Friend WithEvents txtAdminPassword As TextBox
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents lklblAdminForgetPassword As LinkLabel
End Class
