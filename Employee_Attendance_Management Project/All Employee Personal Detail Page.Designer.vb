<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class All_Employee_Personal_Detail_Page
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
        Me.dgvShowAllEmployeeData = New System.Windows.Forms.DataGridView()
        CType(Me.dgvShowAllEmployeeData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvShowAllEmployeeData
        '
        Me.dgvShowAllEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowAllEmployeeData.Location = New System.Drawing.Point(0, 0)
        Me.dgvShowAllEmployeeData.Name = "dgvShowAllEmployeeData"
        Me.dgvShowAllEmployeeData.Size = New System.Drawing.Size(789, 427)
        Me.dgvShowAllEmployeeData.TabIndex = 0
        '
        'All_Employee_Personal_Detail_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 428)
        Me.Controls.Add(Me.dgvShowAllEmployeeData)
        Me.Name = "All_Employee_Personal_Detail_Page"
        Me.Text = "All_Employee_Personal_Detail_Page"
        CType(Me.dgvShowAllEmployeeData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvShowAllEmployeeData As DataGridView
End Class
