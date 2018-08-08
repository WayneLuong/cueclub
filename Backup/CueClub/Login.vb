Public Class Login

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Log.Click
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))
        index = Me.txtid.Text
        NumberOfRecords = LOF(1) / Len(OnePerson)
        FileGet(1, OnePerson, index)
        If OnePerson.Password = txtpassword.Text Then
            'Close a file
            FileClose(1)
            Dim Login As New AccMenu
            Login.ShowDialog()
        Else
            MsgBox("Password does not match")
            'Close a file
            FileClose(1)
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

 
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Register_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Register.LinkClicked
       
        Dim Login As New Register
        Login.ShowDialog()
    End Sub

    Private Sub Forgotpwd_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Forgotpwd.LinkClicked
        Dim Login As New Forgotpwd
        Login.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtenteruser.TextChanged
      
    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub llbladmin_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbladmin.LinkClicked
        Dim login As New admin
        login.ShowDialog()

    End Sub
End Class
