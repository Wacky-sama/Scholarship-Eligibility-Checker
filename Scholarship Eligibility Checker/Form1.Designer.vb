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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(427, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Scholarship Eligibility Checker"
        '
        'gpa
        '
        Me.gpa.AutoSize = True
        Me.gpa.Location = New System.Drawing.Point(430, 147)
        Me.gpa.Name = "gpa"
        Me.gpa.Size = New System.Drawing.Size(35, 16)
        Me.gpa.TabIndex = 1
        Me.gpa.Text = "GPA"
        '
        'income
        '
        Me.income.AutoSize = True
        Me.income.Location = New System.Drawing.Point(430, 175)
        Me.income.Name = "income"
        Me.income.Size = New System.Drawing.Size(100, 16)
        Me.income.TabIndex = 2
        Me.income.Text = "Monthly Income"
        '
        'communityHours
        '
        Me.communityHours.AutoSize = True
        Me.communityHours.Location = New System.Drawing.Point(430, 203)
        Me.communityHours.Name = "communityHours"
        Me.communityHours.Size = New System.Drawing.Size(112, 16)
        Me.communityHours.TabIndex = 3
        Me.communityHours.Text = "Community Hours"
        '
        'letterGrade
        '
        Me.letterGrade.AutoSize = True
        Me.letterGrade.Location = New System.Drawing.Point(430, 298)
        Me.letterGrade.Name = "letterGrade"
        Me.letterGrade.Size = New System.Drawing.Size(48, 16)
        Me.letterGrade.TabIndex = 4
        Me.letterGrade.Text = "Grade:"
        '
        'tier
        '
        Me.tier.AutoSize = True
        Me.tier.Location = New System.Drawing.Point(430, 324)
        Me.tier.Name = "tier"
        Me.tier.Size = New System.Drawing.Size(108, 16)
        Me.tier.TabIndex = 5
        Me.tier.Text = "Scholarship Tier:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(558, 141)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 22)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(558, 169)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(206, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(558, 197)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(206, 22)
        Me.TextBox3.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(586, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 26)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Checker"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1767, 779)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tier)
        Me.Controls.Add(Me.letterGrade)
        Me.Controls.Add(Me.communityHours)
        Me.Controls.Add(Me.income)
        Me.Controls.Add(Me.gpa)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
End Class
