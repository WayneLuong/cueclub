<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminmenu))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.edit = New System.Windows.Forms.Button
        Me.delete = New System.Windows.Forms.Button
        Me.viewall = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.searchoption = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstrecords = New System.Windows.Forms.ListBox
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtsurname = New System.Windows.Forms.TextBox
        Me.txtDOB = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtcity = New System.Windows.Forms.TextBox
        Me.txtpostcode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtcontactno = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtdeleted = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-60, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(582, 127)
        Me.PictureBox2.TabIndex = 105
        Me.PictureBox2.TabStop = False
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(200, 454)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(98, 25)
        Me.edit.TabIndex = 106
        Me.edit.Text = "Save"
        Me.edit.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(322, 454)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(98, 25)
        Me.delete.TabIndex = 107
        Me.delete.Text = "Delete record"
        Me.delete.UseVisualStyleBackColor = True
        '
        'viewall
        '
        Me.viewall.Location = New System.Drawing.Point(80, 454)
        Me.viewall.Name = "viewall"
        Me.viewall.Size = New System.Drawing.Size(98, 25)
        Me.viewall.TabIndex = 108
        Me.viewall.Text = "View all"
        Me.viewall.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(392, 152)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 24)
        Me.Button4.TabIndex = 109
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'searchoption
        '
        Me.searchoption.FormattingEnabled = True
        Me.searchoption.Items.AddRange(New Object() {"ID", "Surname", "First name"})
        Me.searchoption.Location = New System.Drawing.Point(118, 154)
        Me.searchoption.Name = "searchoption"
        Me.searchoption.Size = New System.Drawing.Size(95, 21)
        Me.searchoption.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Search by"
        '
        'lstrecords
        '
        Me.lstrecords.FormattingEnabled = True
        Me.lstrecords.HorizontalScrollbar = True
        Me.lstrecords.Location = New System.Drawing.Point(229, 310)
        Me.lstrecords.Name = "lstrecords"
        Me.lstrecords.Size = New System.Drawing.Size(258, 134)
        Me.lstrecords.TabIndex = 112
        '
        'txtsearch
        '
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Location = New System.Drawing.Point(229, 155)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(141, 20)
        Me.txtsearch.TabIndex = 113
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Members"
        '
        'txtusername
        '
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusername.Location = New System.Drawing.Point(60, 214)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(97, 20)
        Me.txtusername.TabIndex = 115
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Location = New System.Drawing.Point(60, 242)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(97, 20)
        Me.txtpassword.TabIndex = 116
        '
        'txttitle
        '
        Me.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttitle.Location = New System.Drawing.Point(59, 268)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(33, 20)
        Me.txttitle.TabIndex = 117
        '
        'txtname
        '
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Location = New System.Drawing.Point(59, 294)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(107, 20)
        Me.txtname.TabIndex = 118
        '
        'txtsurname
        '
        Me.txtsurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsurname.Location = New System.Drawing.Point(59, 320)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(107, 20)
        Me.txtsurname.TabIndex = 119
        '
        'txtDOB
        '
        Me.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDOB.Location = New System.Drawing.Point(59, 346)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(81, 20)
        Me.txtDOB.TabIndex = 120
        '
        'txtaddress
        '
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaddress.Location = New System.Drawing.Point(60, 374)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(141, 20)
        Me.txtaddress.TabIndex = 121
        '
        'txtcity
        '
        Me.txtcity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcity.Location = New System.Drawing.Point(61, 398)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(96, 20)
        Me.txtcity.TabIndex = 122
        '
        'txtpostcode
        '
        Me.txtpostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpostcode.Location = New System.Drawing.Point(61, 424)
        Me.txtpostcode.Name = "txtpostcode"
        Me.txtpostcode.Size = New System.Drawing.Size(69, 20)
        Me.txtpostcode.TabIndex = 123
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Title"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Surname"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 353)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "DOB"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 381)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 405)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "City"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 431)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "Postcode"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(264, 242)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(141, 20)
        Me.txtEmail.TabIndex = 133
        '
        'txtcontactno
        '
        Me.txtcontactno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontactno.Location = New System.Drawing.Point(264, 216)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(141, 20)
        Me.txtcontactno.TabIndex = 134
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(226, 249)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 135
        Me.Label12.Text = "Email"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(177, 221)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 136
        Me.Label13.Text = "Contact number"
        '
        'txtdeleted
        '
        Me.txtdeleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdeleted.Location = New System.Drawing.Point(264, 268)
        Me.txtdeleted.Name = "txtdeleted"
        Me.txtdeleted.Size = New System.Drawing.Size(60, 20)
        Me.txtdeleted.TabIndex = 137
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(212, 275)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 138
        Me.Label14.Text = "Deleted "
        '
        'adminmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(516, 505)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtdeleted)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtcontactno)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpostcode)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtsurname)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.lstrecords)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchoption)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.viewall)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "adminmenu"
        Me.Text = "Admin"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents viewall As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents searchoption As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstrecords As System.Windows.Forms.ListBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtpostcode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtdeleted As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
