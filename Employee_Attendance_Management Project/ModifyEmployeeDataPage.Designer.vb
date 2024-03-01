<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyEmployeeDataPage
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.lblSerialNo = New System.Windows.Forms.Label()
        Me.lblEmplyeeId = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblFatherName = New System.Windows.Forms.Label()
        Me.lblEmailId = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnUpdateEmpData = New System.Windows.Forms.Button()
        Me.btnDeleteEmpData = New System.Windows.Forms.Button()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.txtSerialNo = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtFatherName = New System.Windows.Forms.TextBox()
        Me.txtEmailId = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtEmployeeOrAdmin = New System.Windows.Forms.TextBox()
        Me.lblEmployeeOrAdmin = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(727, 448)
        Me.DataGridView1.TabIndex = 0
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(395, 232)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(115, 20)
        Me.lblPhoneNumber.TabIndex = 1
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(395, 309)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(68, 20)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfBirth.Location = New System.Drawing.Point(399, 176)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(102, 20)
        Me.lblDateOfBirth.TabIndex = 3
        Me.lblDateOfBirth.Text = "Date Of Birth"
        '
        'lblSerialNo
        '
        Me.lblSerialNo.AutoSize = True
        Me.lblSerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialNo.Location = New System.Drawing.Point(399, 115)
        Me.lblSerialNo.Name = "lblSerialNo"
        Me.lblSerialNo.Size = New System.Drawing.Size(73, 20)
        Me.lblSerialNo.TabIndex = 4
        Me.lblSerialNo.Text = "Serial No"
        '
        'lblEmplyeeId
        '
        Me.lblEmplyeeId.AutoSize = True
        Me.lblEmplyeeId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmplyeeId.Location = New System.Drawing.Point(78, 9)
        Me.lblEmplyeeId.Name = "lblEmplyeeId"
        Me.lblEmplyeeId.Size = New System.Drawing.Size(140, 20)
        Me.lblEmplyeeId.TabIndex = 5
        Me.lblEmplyeeId.Text = "Enter Employee Id"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.Location = New System.Drawing.Point(12, 54)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(125, 20)
        Me.lblEmployeeName.TabIndex = 6
        Me.lblEmployeeName.Text = "Employee Name"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(12, 115)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(85, 20)
        Me.lblUserName.TabIndex = 7
        Me.lblUserName.Text = "UserName"
        '
        'lblFatherName
        '
        Me.lblFatherName.AutoSize = True
        Me.lblFatherName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFatherName.Location = New System.Drawing.Point(12, 178)
        Me.lblFatherName.Name = "lblFatherName"
        Me.lblFatherName.Size = New System.Drawing.Size(113, 20)
        Me.lblFatherName.TabIndex = 8
        Me.lblFatherName.Text = "Father's Name"
        '
        'lblEmailId
        '
        Me.lblEmailId.AutoSize = True
        Me.lblEmailId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailId.Location = New System.Drawing.Point(12, 234)
        Me.lblEmailId.Name = "lblEmailId"
        Me.lblEmailId.Size = New System.Drawing.Size(66, 20)
        Me.lblEmailId.TabIndex = 9
        Me.lblEmailId.Text = "Email Id"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(12, 309)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 20)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password"
        '
        'btnUpdateEmpData
        '
        Me.btnUpdateEmpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateEmpData.Location = New System.Drawing.Point(162, 392)
        Me.btnUpdateEmpData.Name = "btnUpdateEmpData"
        Me.btnUpdateEmpData.Size = New System.Drawing.Size(102, 46)
        Me.btnUpdateEmpData.TabIndex = 11
        Me.btnUpdateEmpData.Text = "Update"
        Me.btnUpdateEmpData.UseVisualStyleBackColor = True
        '
        'btnDeleteEmpData
        '
        Me.btnDeleteEmpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteEmpData.Location = New System.Drawing.Point(399, 392)
        Me.btnDeleteEmpData.Name = "btnDeleteEmpData"
        Me.btnDeleteEmpData.Size = New System.Drawing.Size(102, 46)
        Me.btnDeleteEmpData.TabIndex = 12
        Me.btnDeleteEmpData.Text = "Delete"
        Me.btnDeleteEmpData.UseVisualStyleBackColor = True
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.Location = New System.Drawing.Point(266, 9)
        Me.txtEmployeeId.Multiline = True
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(160, 30)
        Me.txtEmployeeId.TabIndex = 13
        '
        'txtSerialNo
        '
        Me.txtSerialNo.Location = New System.Drawing.Point(541, 105)
        Me.txtSerialNo.Multiline = True
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.Size = New System.Drawing.Size(160, 30)
        Me.txtSerialNo.TabIndex = 15
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(541, 234)
        Me.txtPhoneNumber.Multiline = True
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(160, 30)
        Me.txtPhoneNumber.TabIndex = 16
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.Location = New System.Drawing.Point(541, 168)
        Me.txtDateOfBirth.Multiline = True
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.Size = New System.Drawing.Size(160, 30)
        Me.txtDateOfBirth.TabIndex = 17
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(164, 54)
        Me.txtEmployeeName.Multiline = True
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(160, 30)
        Me.txtEmployeeName.TabIndex = 18
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(164, 115)
        Me.txtUserName.Multiline = True
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(160, 30)
        Me.txtUserName.TabIndex = 19
        '
        'txtFatherName
        '
        Me.txtFatherName.Location = New System.Drawing.Point(164, 178)
        Me.txtFatherName.Multiline = True
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(160, 30)
        Me.txtFatherName.TabIndex = 20
        '
        'txtEmailId
        '
        Me.txtEmailId.Location = New System.Drawing.Point(164, 234)
        Me.txtEmailId.Multiline = True
        Me.txtEmailId.Name = "txtEmailId"
        Me.txtEmailId.Size = New System.Drawing.Size(160, 30)
        Me.txtEmailId.TabIndex = 21
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(164, 299)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(160, 30)
        Me.txtPassword.TabIndex = 22
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(512, 284)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(189, 63)
        Me.txtAddress.TabIndex = 23
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(454, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(95, 30)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtEmployeeOrAdmin
        '
        Me.txtEmployeeOrAdmin.Location = New System.Drawing.Point(541, 56)
        Me.txtEmployeeOrAdmin.Multiline = True
        Me.txtEmployeeOrAdmin.Name = "txtEmployeeOrAdmin"
        Me.txtEmployeeOrAdmin.Size = New System.Drawing.Size(160, 30)
        Me.txtEmployeeOrAdmin.TabIndex = 25
        '
        'lblEmployeeOrAdmin
        '
        Me.lblEmployeeOrAdmin.AutoSize = True
        Me.lblEmployeeOrAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeOrAdmin.Location = New System.Drawing.Point(399, 64)
        Me.lblEmployeeOrAdmin.Name = "lblEmployeeOrAdmin"
        Me.lblEmployeeOrAdmin.Size = New System.Drawing.Size(128, 20)
        Me.lblEmployeeOrAdmin.TabIndex = 26
        Me.lblEmployeeOrAdmin.Text = "Employee/Admin"
        '
        'ModifyEmployeeDataPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblEmployeeOrAdmin)
        Me.Controls.Add(Me.txtEmployeeOrAdmin)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmailId)
        Me.Controls.Add(Me.txtFatherName)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.txtDateOfBirth)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtSerialNo)
        Me.Controls.Add(Me.txtEmployeeId)
        Me.Controls.Add(Me.btnDeleteEmpData)
        Me.Controls.Add(Me.btnUpdateEmpData)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmailId)
        Me.Controls.Add(Me.lblFatherName)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblEmployeeName)
        Me.Controls.Add(Me.lblEmplyeeId)
        Me.Controls.Add(Me.lblSerialNo)
        Me.Controls.Add(Me.lblDateOfBirth)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ModifyEmployeeDataPage"
        Me.Text = "ModifyEmployeeDataPage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblSerialNo As Label
    Friend WithEvents lblEmplyeeId As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblFatherName As Label
    Friend WithEvents lblEmailId As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnUpdateEmpData As Button
    Friend WithEvents btnDeleteEmpData As Button
    Friend WithEvents txtEmployeeId As TextBox
    Friend WithEvents txtSerialNo As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtDateOfBirth As TextBox
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtFatherName As TextBox
    Friend WithEvents txtEmailId As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtEmployeeOrAdmin As TextBox
    Friend WithEvents lblEmployeeOrAdmin As Label
End Class
