<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtyear = New System.Windows.Forms.TextBox
        Me.txtmonth = New System.Windows.Forms.ComboBox
        Me.txtday = New System.Windows.Forms.ComboBox
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtcontactno = New System.Windows.Forms.TextBox
        Me.txtpostcode = New System.Windows.Forms.TextBox
        Me.txtcity = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtsurname = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Ok = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.txttitle = New System.Windows.Forms.GroupBox
        Me.txtDOB = New System.Windows.Forms.GroupBox
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txttitle.SuspendLayout()
        Me.txtDOB.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-62, -4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(599, 139)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(50, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(12, 13)
        Me.Label19.TabIndex = 116
        Me.Label19.Text = "/"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(101, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(12, 13)
        Me.Label20.TabIndex = 115
        Me.Label20.Text = "/"
        '
        'txtyear
        '
        Me.txtyear.Location = New System.Drawing.Point(116, 10)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(67, 20)
        Me.txtyear.TabIndex = 114
        '
        'txtmonth
        '
        Me.txtmonth.FormattingEnabled = True
        Me.txtmonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.txtmonth.Location = New System.Drawing.Point(62, 9)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.Size = New System.Drawing.Size(33, 21)
        Me.txtmonth.TabIndex = 113
        '
        'txtday
        '
        Me.txtday.FormattingEnabled = True
        Me.txtday.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.txtday.Location = New System.Drawing.Point(11, 9)
        Me.txtday.Name = "txtday"
        Me.txtday.Size = New System.Drawing.Size(36, 21)
        Me.txtday.TabIndex = 112
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(144, 11)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(36, 17)
        Me.RadioButton4.TabIndex = 103
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Dr"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(93, 10)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton3.TabIndex = 102
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Miss"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(51, 11)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton2.TabIndex = 101
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Mrs"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(8, 10)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton1.TabIndex = 100
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Mr"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(185, 410)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(92, 20)
        Me.txtemail.TabIndex = 99
        '
        'txtcontactno
        '
        Me.txtcontactno.Location = New System.Drawing.Point(185, 384)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(92, 20)
        Me.txtcontactno.TabIndex = 98
        '
        'txtpostcode
        '
        Me.txtpostcode.Location = New System.Drawing.Point(185, 358)
        Me.txtpostcode.Name = "txtpostcode"
        Me.txtpostcode.Size = New System.Drawing.Size(92, 20)
        Me.txtpostcode.TabIndex = 97
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(185, 332)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(92, 20)
        Me.txtcity.TabIndex = 96
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(185, 306)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(92, 20)
        Me.txtaddress.TabIndex = 95
        '
        'txtsurname
        '
        Me.txtsurname.Location = New System.Drawing.Point(185, 228)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(92, 20)
        Me.txtsurname.TabIndex = 94
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(185, 199)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(92, 20)
        Me.txtname.TabIndex = 93
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(146, 417)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(95, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Contact Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Postcode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(155, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(134, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Date of Birth"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Title"
        '
        'Ok
        '
        Me.Ok.Location = New System.Drawing.Point(115, 478)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(104, 27)
        Me.Ok.TabIndex = 117
        Me.Ok.Text = "Ok"
        Me.Ok.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(252, 478)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(104, 27)
        Me.Cancel.TabIndex = 118
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(184, 446)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(93, 13)
        Me.LinkLabel1.TabIndex = 119
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Change Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(159, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(185, 144)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(21, 20)
        Me.TxtID.TabIndex = 121
        '
        'txttitle
        '
        Me.txttitle.Controls.Add(Me.RadioButton4)
        Me.txttitle.Controls.Add(Me.RadioButton3)
        Me.txttitle.Controls.Add(Me.RadioButton2)
        Me.txttitle.Controls.Add(Me.RadioButton1)
        Me.txttitle.Location = New System.Drawing.Point(183, 164)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(196, 32)
        Me.txttitle.TabIndex = 122
        Me.txttitle.TabStop = False
        '
        'txtDOB
        '
        Me.txtDOB.Controls.Add(Me.Label19)
        Me.txtDOB.Controls.Add(Me.Label20)
        Me.txtDOB.Controls.Add(Me.txtyear)
        Me.txtDOB.Controls.Add(Me.txtmonth)
        Me.txtDOB.Controls.Add(Me.txtday)
        Me.txtDOB.Location = New System.Drawing.Point(183, 254)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(195, 40)
        Me.txtDOB.TabIndex = 123
        Me.txtDOB.TabStop = False
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(536, 494)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtcontactno)
        Me.Controls.Add(Me.txtpostcode)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtsurname)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Edit"
        Me.Text = "Edit Details"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txttitle.ResumeLayout(False)
        Me.txttitle.PerformLayout()
        Me.txtDOB.ResumeLayout(False)
        Me.txtDOB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents txtmonth As System.Windows.Forms.ComboBox
    Friend WithEvents txtday As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents txtpostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ok As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents txttitle As System.Windows.Forms.GroupBox
    Friend WithEvents txtDOB As System.Windows.Forms.GroupBox
End Class
