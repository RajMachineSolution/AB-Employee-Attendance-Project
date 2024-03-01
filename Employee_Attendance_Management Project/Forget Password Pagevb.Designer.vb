<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forget_Password_Pagevb
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
        Me.lblUserNameOrId = New System.Windows.Forms.Label()
        Me.lblEmailId = New System.Windows.Forms.Label()
        Me.txtUserNameOrId = New System.Windows.Forms.TextBox()
        Me.txtEmailId = New System.Windows.Forms.TextBox()
        Me.btnSendOTP = New System.Windows.Forms.Button()
        Me.txtEnterOtp = New System.Windows.Forms.TextBox()
        Me.btnEnterOTP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUserNameOrId
        '
        Me.lblUserNameOrId.AutoSize = True
        Me.lblUserNameOrId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserNameOrId.Location = New System.Drawing.Point(100, 42)
        Me.lblUserNameOrId.Name = "lblUserNameOrId"
        Me.lblUserNameOrId.Size = New System.Drawing.Size(106, 20)
        Me.lblUserNameOrId.TabIndex = 0
        Me.lblUserNameOrId.Text = "UserName/ID"
        '
        'lblEmailId
        '
        Me.lblEmailId.AutoSize = True
        Me.lblEmailId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailId.Location = New System.Drawing.Point(101, 107)
        Me.lblEmailId.Name = "lblEmailId"
        Me.lblEmailId.Size = New System.Drawing.Size(60, 18)
        Me.lblEmailId.TabIndex = 1
        Me.lblEmailId.Text = "Email Id"
        '
        'txtUserNameOrId
        '
        Me.txtUserNameOrId.Location = New System.Drawing.Point(103, 65)
        Me.txtUserNameOrId.Multiline = True
        Me.txtUserNameOrId.Name = "txtUserNameOrId"
        Me.txtUserNameOrId.Size = New System.Drawing.Size(160, 30)
        Me.txtUserNameOrId.TabIndex = 2
        '
        'txtEmailId
        '
        Me.txtEmailId.Location = New System.Drawing.Point(103, 141)
        Me.txtEmailId.Multiline = True
        Me.txtEmailId.Name = "txtEmailId"
        Me.txtEmailId.Size = New System.Drawing.Size(160, 30)
        Me.txtEmailId.TabIndex = 3
        '
        'btnSendOTP
        '
        Me.btnSendOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendOTP.Location = New System.Drawing.Point(141, 188)
        Me.btnSendOTP.Name = "btnSendOTP"
        Me.btnSendOTP.Size = New System.Drawing.Size(87, 30)
        Me.btnSendOTP.TabIndex = 4
        Me.btnSendOTP.Text = "Send OTP"
        Me.btnSendOTP.UseVisualStyleBackColor = True
        '
        'txtEnterOtp
        '
        Me.txtEnterOtp.Location = New System.Drawing.Point(103, 242)
        Me.txtEnterOtp.Multiline = True
        Me.txtEnterOtp.Name = "txtEnterOtp"
        Me.txtEnterOtp.Size = New System.Drawing.Size(125, 33)
        Me.txtEnterOtp.TabIndex = 5
        '
        'btnEnterOTP
        '
        Me.btnEnterOTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterOTP.Location = New System.Drawing.Point(234, 242)
        Me.btnEnterOTP.Name = "btnEnterOTP"
        Me.btnEnterOTP.Size = New System.Drawing.Size(75, 33)
        Me.btnEnterOTP.TabIndex = 6
        Me.btnEnterOTP.Text = "Enter OTP"
        Me.btnEnterOTP.UseVisualStyleBackColor = True
        '
        'Forget_Password_Pagevb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.btnEnterOTP)
        Me.Controls.Add(Me.txtEnterOtp)
        Me.Controls.Add(Me.btnSendOTP)
        Me.Controls.Add(Me.txtEmailId)
        Me.Controls.Add(Me.txtUserNameOrId)
        Me.Controls.Add(Me.lblEmailId)
        Me.Controls.Add(Me.lblUserNameOrId)
        Me.Name = "Forget_Password_Pagevb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forget_Password_Pagevb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserNameOrId As Label
    Friend WithEvents lblEmailId As Label
    Friend WithEvents txtUserNameOrId As TextBox
    Friend WithEvents txtEmailId As TextBox
    Friend WithEvents btnSendOTP As Button
    Friend WithEvents txtEnterOtp As TextBox
    Friend WithEvents btnEnterOTP As Button
End Class
