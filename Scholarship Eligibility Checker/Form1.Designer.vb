<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpa = New System.Windows.Forms.Label()
        Me.income = New System.Windows.Forms.Label()
        Me.communityHours = New System.Windows.Forms.Label()
        Me.letterGrade = New System.Windows.Forms.Label()
        Me.tier = New System.Windows.Forms.Label()
        Me.gpaTbx = New System.Windows.Forms.TextBox()
        Me.incomeTbx = New System.Windows.Forms.TextBox()
        Me.communityHoursTbx = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnChecker = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(589, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Scholarship Eligibility Checker"
        '
        'gpa
        '
        Me.gpa.AutoSize = True
        Me.gpa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpa.Location = New System.Drawing.Point(609, 155)
        Me.gpa.Name = "gpa"
        Me.gpa.Size = New System.Drawing.Size(39, 18)
        Me.gpa.TabIndex = 1
        Me.gpa.Text = "GPA"
        '
        'income
        '
        Me.income.AutoSize = True
        Me.income.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.income.Location = New System.Drawing.Point(609, 203)
        Me.income.Name = "income"
        Me.income.Size = New System.Drawing.Size(113, 18)
        Me.income.TabIndex = 2
        Me.income.Text = "Monthly Income"
        '
        'communityHours
        '
        Me.communityHours.AutoSize = True
        Me.communityHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.communityHours.Location = New System.Drawing.Point(609, 240)
        Me.communityHours.Name = "communityHours"
        Me.communityHours.Size = New System.Drawing.Size(129, 18)
        Me.communityHours.TabIndex = 3
        Me.communityHours.Text = "Community Hours"
        '
        'letterGrade
        '
        Me.letterGrade.AutoSize = True
        Me.letterGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letterGrade.Location = New System.Drawing.Point(609, 361)
        Me.letterGrade.Name = "letterGrade"
        Me.letterGrade.Size = New System.Drawing.Size(53, 18)
        Me.letterGrade.TabIndex = 4
        Me.letterGrade.Text = "Grade:"
        '
        'tier
        '
        Me.tier.AutoSize = True
        Me.tier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tier.Location = New System.Drawing.Point(609, 399)
        Me.tier.Name = "tier"
        Me.tier.Size = New System.Drawing.Size(119, 18)
        Me.tier.TabIndex = 5
        Me.tier.Text = "Scholarship Tier:"
        '
        'gpaTbx
        '
        Me.gpaTbx.Location = New System.Drawing.Point(789, 152)
        Me.gpaTbx.Name = "gpaTbx"
        Me.gpaTbx.Size = New System.Drawing.Size(206, 24)
        Me.gpaTbx.TabIndex = 6
        '
        'incomeTbx
        '
        Me.incomeTbx.Location = New System.Drawing.Point(789, 194)
        Me.incomeTbx.Name = "incomeTbx"
        Me.incomeTbx.Size = New System.Drawing.Size(206, 24)
        Me.incomeTbx.TabIndex = 7
        '
        'communityHoursTbx
        '
        Me.communityHoursTbx.Location = New System.Drawing.Point(789, 234)
        Me.communityHoursTbx.Name = "communityHoursTbx"
        Me.communityHoursTbx.Size = New System.Drawing.Size(206, 24)
        Me.communityHoursTbx.TabIndex = 8
        '
        'btnChecker
        '
        Me.btnChecker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChecker.Location = New System.Drawing.Point(829, 270)
        Me.btnChecker.Name = "btnChecker"
        Me.btnChecker.Size = New System.Drawing.Size(127, 50)
        Me.btnChecker.TabIndex = 9
        Me.btnChecker.Text = "Checker"
        Me.btnChecker.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2582, 1107)
        Me.Controls.Add(Me.btnChecker)
        Me.Controls.Add(Me.communityHoursTbx)
        Me.Controls.Add(Me.incomeTbx)
        Me.Controls.Add(Me.gpaTbx)
        Me.Controls.Add(Me.tier)
        Me.Controls.Add(Me.letterGrade)
        Me.Controls.Add(Me.communityHours)
        Me.Controls.Add(Me.income)
        Me.Controls.Add(Me.gpa)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gpa As Label
    Friend WithEvents income As Label
    Friend WithEvents communityHours As Label
    Friend WithEvents letterGrade As Label
    Friend WithEvents tier As Label
    Friend WithEvents gpaTbx As TextBox
    Friend WithEvents incomeTbx As TextBox
    Friend WithEvents communityHoursTbx As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btnChecker As Button
End Class
