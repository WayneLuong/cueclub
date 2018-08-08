Public Class admin
    Dim oldpass As String
    Dim pass As String
    Dim pass2 As String

    Private Sub admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim admin As New Login
        admin.ShowDialog()
    End Sub

    Private Sub Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Log.Click
        If txtpassword.Text = "password" Then

            Dim admin As New adminmenu
            admin.ShowDialog()
        Else
            MsgBox("wrong password")
            Dim admin As New admin
            admin.ShowDialog()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'open a file
        FileName = CurDir() & "\Person.dat"
        oldpass = InputBox(" Enter old password")
        If oldpass = OnePerson.adminpassword Then
            pass = (InputBox("Enter new password"))
            pass2 = InputBox("Confirm new password")
            If pass = pass2 Then
                pass = Trim(OnePerson.adminpassword)
            Else
                MsgBox("password does not match")
            End If
        End If
        'Close a file
        FileClose(1)
    End Sub
End Class