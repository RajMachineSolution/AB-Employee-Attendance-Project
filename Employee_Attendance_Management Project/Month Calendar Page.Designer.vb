<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Month_Calendar_Page
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
        Me.SelectYearMonthDate = New System.Windows.Forms.MonthCalendar()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.LblEndDate = New System.Windows.Forms.Label()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.btnSetDate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SelectYearMonthDate
        '
        Me.SelectYearMonthDate.Location = New System.Drawing.Point(103, 45)
        Me.SelectYearMonthDate.Name = "SelectYearMonthDate"
        Me.SelectYearMonthDate.TabIndex = 0
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(170, 244)
        Me.txtStartDate.Multiline = True
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(160, 30)
        Me.txtStartDate.TabIndex = 1
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.Location = New System.Drawing.Point(100, 254)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(57, 20)
        Me.lblStartDate.TabIndex = 2
        Me.lblStartDate.Text = "Start :-"
        '
        'LblEndDate
        '
        Me.LblEndDate.AutoSize = True
        Me.LblEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEndDate.Location = New System.Drawing.Point(100, 309)
        Me.LblEndDate.Name = "LblEndDate"
        Me.LblEndDate.Size = New System.Drawing.Size(51, 20)
        Me.LblEndDate.TabIndex = 3
        Me.LblEndDate.Text = "End :-"
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(170, 299)
        Me.txtEndDate.Multiline = True
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(160, 30)
        Me.txtEndDate.TabIndex = 4
        '
        'btnSetDate
        '
        Me.btnSetDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetDate.Location = New System.Drawing.Point(155, 349)
        Me.btnSetDate.Name = "btnSetDate"
        Me.btnSetDate.Size = New System.Drawing.Size(91, 32)
        Me.btnSetDate.TabIndex = 5
        Me.btnSetDate.Text = "SET"
        Me.btnSetDate.UseVisualStyleBackColor = True
        '
        'Month_Calendar_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.btnSetDate)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.LblEndDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.SelectYearMonthDate)
        Me.Name = "Month_Calendar_Page"
        Me.Text = "Month_Calendar_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SelectYearMonthDate As MonthCalendar
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents lblStartDate As Label
    Friend WithEvents LblEndDate As Label
    Friend WithEvents txtEndDate As TextBox
    Friend WithEvents btnSetDate As Button
End Class
