Imports MySql.Data.MySqlClient


Module Module1
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader

    Sub connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server=localhost;user id =root;password=Codered368;database=xepharma"

        End With
    End Sub

    Public Function IS_EMPTY(ByVal sText As Object) As Boolean
        On Error Resume Next
        If sText.Text = "" Then
            IS_EMPTY = True
            MsgBox("Warning:Required Missing Field", vbCritical)
            sText.BackColor = Color.White
            sText.Foxus()
        Else
            IS_EMPTY = False
            sText.BackColor = Color.White
        End If
    End Function
    Public Function IS_EMPTY(ByVal sText As Object, stext1 As Object) As Boolean
        On Error Resume Next
        If sText.Text = "" Then
            IS_EMPTY = True
            MsgBox("Warning:Required Missing Field", vbCritical)
            stext1.BackColor = Color.White
            stext1.Foxus()
        Else
            IS_EMPTY = False
            stext1.BackColor = Color.White
        End If
    End Function
    Public Function ValidateDuplicateEntry(ByVal sql As String) As Boolean
        cn.Open()
        cm = New MySqlCommand(sql, cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            ValidateDuplicateEntry = True
            MsgBox("Warning: Duplicate Entry.", vbExclamation)

        Else
            ValidateDuplicateEntry = False
        End If
        dr.Close()
        cn.Close()
    End Function




End Module
