Public Class Register

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass1.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))
        'Add a person to the file

        NumberOfRecords = LOF(1) / Len(OnePerson)
        OnePerson.name = Trim(Me.TxtName.Text)
        OnePerson.DOB = Trim(Me.txtDOB.Text)
        OnePerson.title = Trim(Me.TxtTitle.Text)
        OnePerson.username = Trim(Me.txtusername.Text)
        OnePerson.Password = Trim(Me.TxtPass.Text)
        OnePerson.Password2 = Trim(Me.txtpass1.Text)
        OnePerson.question = Trim(Me.TxtQuestion.Text)
        OnePerson.answer = Trim(Me.txtAnswer.Text)
        OnePerson.surname = Trim(Me.TxtSurname.Text)
        OnePerson.Address = Trim(Me.txtaddress.Text)
        OnePerson.City = Trim(Me.Txtcity.Text)
        OnePerson.Postcode = Trim(Me.Txtpostcode.Text)
        OnePerson.Contactnumber = Trim(Me.txtcontactno.Text)
        OnePerson.Email = Trim(Me.txtemail.Text)
        OnePerson.Deleted = False
        FilePut(1, OnePerson, NumberOfRecords + 1)
        Me.TxtID.Text = NumberOfRecords + 1
        OnePerson.ID = NumberOfRecords


        MsgBox("Your Membership has been accepted!")
        MsgBox("Take a note of your ID number")
        'Close a file
        FileClose(1)
    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click

    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Dim register As New Login
        register.ShowDialog()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcity.TextChanged

    End Sub

    Private Sub TxtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPass.TextChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub TxtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtID.TextChanged
    End Sub
End Class