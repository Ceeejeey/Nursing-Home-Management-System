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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOther = New System.Windows.Forms.RadioButton()
        Me.LabelFullName = New System.Windows.Forms.Label()
        Me.TextBoxFullName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(574, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(711, 261)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(245, 22)
        Me.TextBoxEmail.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(574, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(711, 301)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(245, 22)
        Me.TextBoxPassword.TabIndex = 5
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'ButtonRegister
        '
        Me.ButtonRegister.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonRegister.FlatAppearance.BorderSize = 0
        Me.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegister.ForeColor = System.Drawing.Color.White
        Me.ButtonRegister.Location = New System.Drawing.Point(711, 381)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(200, 40)
        Me.ButtonRegister.TabIndex = 6
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(574, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gender"
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Location = New System.Drawing.Point(711, 341)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(58, 20)
        Me.RadioButtonMale.TabIndex = 8
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        '
        'RadioButtonFemale
        '
        Me.RadioButtonFemale.AutoSize = True
        Me.RadioButtonFemale.Location = New System.Drawing.Point(790, 341)
        Me.RadioButtonFemale.Name = "RadioButtonFemale"
        Me.RadioButtonFemale.Size = New System.Drawing.Size(74, 20)
        Me.RadioButtonFemale.TabIndex = 9
        Me.RadioButtonFemale.TabStop = True
        Me.RadioButtonFemale.Text = "Female"
        Me.RadioButtonFemale.UseVisualStyleBackColor = True
        '
        'RadioButtonOther
        '
        Me.RadioButtonOther.AutoSize = True
        Me.RadioButtonOther.Location = New System.Drawing.Point(896, 341)
        Me.RadioButtonOther.Name = "RadioButtonOther"
        Me.RadioButtonOther.Size = New System.Drawing.Size(60, 20)
        Me.RadioButtonOther.TabIndex = 10
        Me.RadioButtonOther.TabStop = True
        Me.RadioButtonOther.Text = "Other"
        Me.RadioButtonOther.UseVisualStyleBackColor = True
        '
        'LabelFullName
        '
        Me.LabelFullName.AutoSize = True
        Me.LabelFullName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelFullName.Location = New System.Drawing.Point(574, 221)
        Me.LabelFullName.Name = "LabelFullName"
        Me.LabelFullName.Size = New System.Drawing.Size(111, 24)
        Me.LabelFullName.TabIndex = 11
        Me.LabelFullName.Text = "Full Name"
        '
        'TextBoxFullName
        '
        Me.TextBoxFullName.Location = New System.Drawing.Point(711, 221)
        Me.TextBoxFullName.Name = "TextBoxFullName"
        Me.TextBoxFullName.Size = New System.Drawing.Size(245, 22)
        Me.TextBoxFullName.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 509)
        Me.Panel1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1012, 50)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Register An Admin Account"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(684, 438)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(247, 20)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Already have an account? Login"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1020, 564)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadioButtonOther)
        Me.Controls.Add(Me.RadioButtonFemale)
        Me.Controls.Add(Me.RadioButtonMale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxFullName)
        Me.Controls.Add(Me.LabelFullName)
        Me.Name = "RegisterForm"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
