Public Class adminmenu

    Private Sub adminmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub viewall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewall.Click
        Me.lstrecords.Items.Clear()
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'output all records method 1
        NumberOfRecords = LOF(1) / Len(OnePerson)
        For index = 1 To NumberOfRecords
            FileGet(1, OnePerson, index)
            If OnePerson.Deleted = False Then
                Me.lstrecords.Items.Add("Id:" & index & " Username:" & Trim(OnePerson.username) & "  Password:" & Trim(OnePerson.Password) & "  Title:  " & (OnePerson.title) & "  Name: " & Trim(OnePerson.name) & " Surname: " & Trim(OnePerson.surname) & " DOB:  " & Trim(OnePerson.DOB) & " Address:  " & Trim(OnePerson.Address) & " City:  " & Trim(OnePerson.City) & "  Postcode:  " & Trim(OnePerson.Postcode) & "  Contact Number:  " & Trim(OnePerson.Contactnumber) & "  Email:  " & Trim(OnePerson.Email))
            End If
        Next index
        'Close file
        FileClose()
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        index = InputBox("Enter ID number")
        FileGet(1, OnePerson, index)
        'delete record
        NumberOfRecords = LOF(1) / Len(OnePerson)
        OnePerson.Deleted = True
        MsgBox("Account deleted")
        'Close a file
        FileClose(1)
    End Sub

    Private Sub lstrecords_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstrecords.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'output all records method 1

        index = Me.txtsearch.Text
        FileGet(1, OnePerson, index)
        Me.txtusername.Text = Trim(OnePerson.username)
        Me.txtpassword.Text = Trim(OnePerson.Password)
        Me.txttitle.Text = Trim(OnePerson.title)
        Me.txtname.Text = Trim(OnePerson.name)
        Me.txtsurname.Text = Trim(OnePerson.surname)
        Me.txtDOB.Text = Trim(OnePerson.DOB)
        Me.txtaddress.Text = Trim(OnePerson.Address)
        Me.txtcity.Text = Trim(OnePerson.City)
        Me.txtpostcode.Text = Trim(OnePerson.Postcode)
        Me.txtcontactno.Text = Trim(OnePerson.Contactnumber)
        Me.txtEmail.Text = Trim(OnePerson.Email)
        Me.txtdeleted.Text = Trim(OnePerson.Deleted)
     
        'Close a file
        FileClose(1)
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'Edit record
        OnePerson.username = Me.txtusername.Text
        OnePerson.Password = Me.txtpassword.Text
        OnePerson.title = Me.txttitle.Text
        OnePerson.name = Me.txtname.Text
        OnePerson.surname = Me.txtsurname.Text
        OnePerson.DOB = Me.txtDOB.Text
        OnePerson.Address = Me.txtaddress.Text
        OnePerson.City = Me.txtcity.Text
        OnePerson.Postcode = Me.txtpostcode.Text
        OnePerson.Contactnumber = Me.txtcontactno.Text
        OnePerson.Email = Me.txtEmail.Text
        OnePerson.Deleted = Me.txtdeleted.Text
        FilePut(1, OnePerson, index)
        MsgBox("Your details have been saved")

        'Close a file
        FileClose(1)
    End Sub
End Class