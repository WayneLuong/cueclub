Public Class Edit

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'Close a file
        FileClose(1)
        Dim Edit As New AccMenu
        Edit.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        InputBox("Please enter old password")
        InputBox("Enter new password")
        InputBox("Confirm new password")
        MsgBox("Your password has been changed!")
    End Sub

    Private Sub Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok.Click

        'Edit record
        index = Me.TxtID.Text
        OnePerson.title = Me.txttitle.Text
        OnePerson.name = Me.txtname.Text
        OnePerson.surname = Me.txtsurname.Text
        OnePerson.DOB = Me.txtDOB.text
        OnePerson.Address = Me.txtaddress.Text
        OnePerson.City = Me.txtcity.Text
        OnePerson.Postcode = Me.txtpostcode.Text
        OnePerson.Contactnumber = Me.txtcontactno.Text
        OnePerson.Email = Me.txtemail.Text


        'Close a file
        FileClose(1)
        MsgBox("Your details has been updated")
        Dim Edit As New AccMenu
        Edit.ShowDialog()
    End Sub

    Private Sub Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class