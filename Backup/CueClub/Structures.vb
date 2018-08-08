Module Structures
    Structure Person
        Public ID As Integer
        <VBFixedString(30)> Public name As String
        Public title As String
        <VBFixedString(30)> Public username As String
        Public adminpassword As String
        <VBFixedString(30)> Public Password As String
        <VBFixedString(30)> Public Password2 As String
        <VBFixedString(30)> Public question As String
        <VBFixedString(30)> Public answer As String
        <VBFixedString(30)> Public surname As String
        <VBFixedString(30)> Public DOB As String
        <VBFixedString(30)> Public Address As String
        <VBFixedString(30)> Public City As String
        <VBFixedString(30)> Public Postcode As String
        <VBFixedString(30)> Public Contactnumber As String
        <VBFixedString(30)> Public Email As String
        Public Deleted As Boolean
        Public Time As String
        <VBFixedString(30)> Public Deletepass As String

    End Structure
    Public OnePerson As Person
    Public FileName As String
    Public NumberOfRecords As Integer
    Public index As Integer

    Structure Table
        <VBFixedString(10)> Public Tablenumber As String
        <VBFixedString(10)> Public Booked As String
    End Structure
    Structure Game
        <VBFixedString(10)> Public Snooker As String
        <VBFixedString(10)> Public Pool As String
    End Structure
    Structure Time
        <VBFixedString(10)> Public Timestart As String
    End Structure
 
End Module
