Public Class AccMenu

    Private Sub Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout.Click
        'Close a file
        FileClose(1)
        Dim Accmenu As New Login
        Accmenu.ShowDialog()
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        'open a file
        FileName = CurDir() & "\Person.dat"
        index = InputBox("Enter ID number")
        FileGet(1, OnePerson, index)
        OnePerson.Deletepass = InputBox("Are you sure you want to delete your membership? If so please type your password below.")
        If OnePerson.Deletepass = OnePerson.Password Then
            'delete record
            index = Console.ReadLine()
            NumberOfRecords = LOF(1) / Len(OnePerson)
            OnePerson.Deleted = True
            MsgBox("Account deleted")
            'Close a file
            FileClose(1)
            Dim Accmenu As New Login
            Accmenu.ShowDialog()
        Else
            MsgBox("Wrong password")
            'Close a file
            FileClose(1)
            Dim Accmenu As New AccMenu
            Accmenu.ShowDialog()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Accmenu As New Edit
        Accmenu.ShowDialog()
    End Sub

    Private Sub AccMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class