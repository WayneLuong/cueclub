Public Class Forgotpwd
    Dim password As String
    Dim password2 As String
    Dim username As String
    Dim username2 As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Close a file
        FileClose(1)
        Dim Forgotpwd As New Login
        Forgotpwd.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = Structures.OnePerson.answer And (radiopass.Checked = True) Then
            password = InputBox("Please enter New Password")
            password2 = InputBox("Please confirm your password")
            If password = password2 Then
                OnePerson.Password = password
                OnePerson.Password2 = password2
                FilePut(1, OnePerson, index)
                MsgBox("Your password has been changed")
                'Close a file
                FileClose(1)
            Else
                MsgBox("Password does not match")
                'Close a file
                FileClose(1)
                Dim Forgotpwd As New Forgotpwd
                Forgotpwd.ShowDialog()
            End If
        ElseIf TextBox2.Text = OnePerson.answer And (radiousernam.Checked = True) Then
            username = InputBox("Please enter new Username")
            username2 = InputBox("Please confirm new username")
            If username = username2 Then
                OnePerson.username = username
                FilePut(1, OnePerson, index)
                MsgBox("Your username has been changed")
            Else
                MsgBox("Username does not match")
                'Close a file
                FileClose(1)
                Dim Forgotpwd As New Forgotpwd
                Forgotpwd.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Forgotpwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  
    End Sub

  


    Private Sub groupoption_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles groupoption.Enter

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If (radiousernam.Checked = True) Then
            Button3.Visible = False
            Button4.Visible = True
            TextBox1.Visible = True
            Label8.Visible = True
        ElseIf radiopass.Checked = True Then
            Button3.Visible = False
            Button4.Visible = True
            TextBox1.Visible = True
            Label8.Visible = True
        Else
            MsgBox("Please choose an option")
        End If
    End Sub

    Private Sub radiousernam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radiousernam.CheckedChanged

    End Sub

    Private Sub Txtenter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Id number")
        Else
            'open a file
            FileName = CurDir() & "\Person.dat"
            FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))
            index = Me.TextBox1.Text
            FileGet(1, OnePerson, index)
            TextBox1.ReadOnly = True
            Button4.Visible = False
            txtquestion.Text = OnePerson.question
        End If
    End Sub
End Class