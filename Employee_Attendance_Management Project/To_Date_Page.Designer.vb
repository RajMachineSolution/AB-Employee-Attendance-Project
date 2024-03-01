<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class To_Date_Page
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
        Me.dgvShowEmployeeData = New System.Windows.Forms.DataGridView()
        Me.btnShowOneEmpdata = New System.Windows.Forms.Button()
        Me.btnShowAllEmpData = New System.Windows.Forms.Button()
        CType(Me.dgvShowEmployeeData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvShowEmployeeData
        '
        Me.dgvShowEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowEmployeeData.Location = New System.Drawing.Point(0, 60)
        Me.dgvShowEmployeeData.Name = "dgvShowEmployeeData"
        Me.dgvShowEmployeeData.Size = New System.Drawing.Size(799, 399)
        Me.dgvShowEmployeeData.TabIndex = 0
        '
        'btnShowOneEmpdata
        '
        Me.btnShowOneEmpdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowOneEmpdata.Location = New System.Drawing.Point(269, 12)
        Me.btnShowOneEmpdata.Name = "btnShowOneEmpdata"
        Me.btnShowOneEmpdata.Size = New System.Drawing.Size(91, 32)
        Me.btnShowOneEmpdata.TabIndex = 7
        Me.btnShowOneEmpdata.Text = "ONE"
        Me.btnShowOneEmpdata.UseVisualStyleBackColor = True
        '
        'btnShowAllEmpData
        '
        Me.btnShowAllEmpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllEmpData.Location = New System.Drawing.Point(411, 12)
        Me.btnShowAllEmpData.Name = "btnShowAllEmpData"
        Me.btnShowAllEmpData.Size = New System.Drawing.Size(91, 32)
        Me.btnShowAllEmpData.TabIndex = 8
        Me.btnShowAllEmpData.Text = "ALL"
        Me.btnShowAllEmpData.UseVisualStyleBackColor = True
        '
        'To_Date_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnShowAllEmpData)
        Me.Controls.Add(Me.btnShowOneEmpdata)
        Me.Controls.Add(Me.dgvShowEmployeeData)
        Me.Name = "To_Date_Page"
        Me.Text = "Form2"
        CType(Me.dgvShowEmployeeData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvShowEmployeeData As DataGridView
    Friend WithEvents btnShowOneEmpdata As Button
    Friend WithEvents btnShowAllEmpData As Button
End Class
