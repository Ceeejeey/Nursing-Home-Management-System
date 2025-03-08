<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOther = New System.Windows.Forms.RadioButton()
        
        ' New Label and TextBox for Full Name
        Me.LabelFullName = New System.Windows.Forms.Label()
        Me.TextBoxFullName = New System.Windows.Forms.TextBox()

        Me.SuspendLayout()
        
        
        ' New Label for Full Name
        Me.LabelFullName.AutoSize = True
        Me.LabelFullName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelFullName.Location = New System.Drawing.Point(50, 90)  ' Position below Name field
        Me.LabelFullName.Name = "LabelFullName"
        Me.LabelFullName.Size = New System.Drawing.Size(120, 29)
        Me.LabelFullName.TabIndex = 11
        Me.LabelFullName.Text = "Full Name"
        
        ' New TextBox for Full Name
        Me.TextBoxFullName.Location = New System.Drawing.Point(150, 90)  ' Position below Name field
        Me.TextBoxFullName.Name = "TextBoxFullName"
        Me.TextBoxFullName.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxFullName.TabIndex = 12

        ' Label2 (Email)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(50, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email"
        
        ' TextBoxEmail (Email)
        Me.TextBoxEmail.Location = New System.Drawing.Point(150, 130)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxEmail.TabIndex = 3
        
        ' Label3 (Password)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(50, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        
        ' TextBoxPassword (Password)
        Me.TextBoxPassword.Location = New System.Drawing.Point(150, 170)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxPassword.TabIndex = 5
        Me.TextBoxPassword.UseSystemPasswordChar = True
        
        ' ButtonRegister (Register)
        Me.ButtonRegister.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonRegister.FlatAppearance.BorderSize = 0
        Me.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegister.ForeColor = System.Drawing.Color.White
        Me.ButtonRegister.Location = New System.Drawing.Point(150, 250)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(200, 40)
        Me.ButtonRegister.TabIndex = 6
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = False
        
        ' Label4 (Gender)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(50, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gender"
        
        ' RadioButtonMale (Male)
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Location = New System.Drawing.Point(150, 210)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(64, 27)
        Me.RadioButtonMale.TabIndex = 8
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        
        ' RadioButtonFemale (Female)
        Me.RadioButtonFemale.AutoSize = True
        Me.RadioButtonFemale.Location = New System.Drawing.Point(220, 210)
        Me.RadioButtonFemale.Name = "RadioButtonFemale"
        Me.RadioButtonFemale.Size = New System.Drawing.Size(86, 27)
        Me.RadioButtonFemale.TabIndex = 9
        Me.RadioButtonFemale.TabStop = True
        Me.RadioButtonFemale.Text = "Female"
        Me.RadioButtonFemale.UseVisualStyleBackColor = True
        
        ' RadioButtonOther (Other)
        Me.RadioButtonOther.AutoSize = True
        Me.RadioButtonOther.Location = New System.Drawing.Point(310, 210)
        Me.RadioButtonOther.Name = "RadioButtonOther"
        Me.RadioButtonOther.Size = New System.Drawing.Size(72, 27)
        Me.RadioButtonOther.TabIndex = 10
        Me.RadioButtonOther.TabStop = True
        Me.RadioButtonOther.Text = "Other"
        Me.RadioButtonOther.UseVisualStyleBackColor = True
        
        ' RegisterForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClientSize = New System.Drawing.Size(1020, 564) ' Same size as login form
        Me.Controls.Add(Me.RadioButtonOther)
        Me.Controls.Add(Me.RadioButtonFemale)
        Me.Controls.Add(Me.RadioButtonMale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxFullName) ' Add the Full Name textbox
        Me.Controls.Add(Me.LabelFullName) ' Add the Full Name label
        Me.Name = "RegisterForm"
        Me.Text = "User Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' New fields for Full Name
    Friend WithEvents LabelFullName As System.Windows.Forms.Label
    Friend WithEvents TextBoxFullName As System.Windows.Forms.TextBox

    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRegister As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonMale As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonOther As System.Windows.Forms.RadioButton
End Class
