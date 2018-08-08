<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccMenu))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Logout = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.cancel = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Buy = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-60, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(576, 139)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Logout
        '
        Me.Logout.ForeColor = System.Drawing.Color.Black
        Me.Logout.Location = New System.Drawing.Point(197, 317)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(103, 54)
        Me.Logout.TabIndex = 15
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(263, 197)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(103, 54)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "View Leaderboard"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.ForeColor = System.Drawing.Color.Black
        Me.cancel.Location = New System.Drawing.Point(263, 257)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(103, 54)
        Me.cancel.TabIndex = 13
        Me.cancel.Text = "Cancel Membership"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(123, 257)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 54)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Edit Details"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Buy
        '
        Me.Buy.ForeColor = System.Drawing.Color.Black
        Me.Buy.Location = New System.Drawing.Point(123, 197)
        Me.Buy.Name = "Buy"
        Me.Buy.Size = New System.Drawing.Size(108, 54)
        Me.Buy.TabIndex = 11
        Me.Buy.Text = "Buy Table"
        Me.Buy.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-132, 56)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(249, 271)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(263, 277)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 282)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'AccMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(509, 498)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Buy)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AccMenu"
        Me.Text = "Welcome"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Logout As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Buy As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
