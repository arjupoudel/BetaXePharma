Imports MySql.Data.MySqlClient


Public Class frmGeneric
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtGeneric.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim found As Boolean = False
                cn.Open()
                'cm = New MySqlCommand("insert into tblgeneric (generic)values('" & txtClassification.Text & "')", cn)
                'cm.ExecuteNonQuery()
                cm = New MySqlCommand("select * from tblgeneric where generic like '" & txtGeneric.Text & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then found = True
                dr.Close()
                cn.Close()

                If found = False Then
                    cn.Open()
                    cm = Nothing
                    cm = New MySqlCommand("insert into tblgeneric (generic)values(@generic)", cn)
                    cm.Parameters.AddWithValue("@generic", txtGeneric.Text)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record has been sucessfully saved", vbInformation)
                Else
                    MsgBox("Error: Duplicate Entry.", vbCritical)
                End If

                With frmGenericList
                    .LoadRecord()
                End With
                Me.Dispose()
                txtGeneric.Clear()
                txtGeneric.Focus()

            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub

    Private Sub Clear()
        Throw New NotImplementedException()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If (MsgBox("Are you sure you want to update this record ? ", vbYesNo + vbQuestion) = vbYes) Then
                cn.Open()
                cm = Nothing
                cm = New MySqlCommand("update tblgeneric set generic ='" & txtGeneric.Text & "'where genericid like '" & lblID.Text & "'", cn)
                cm.Parameters.AddWithValue("@generic", txtGeneric.Text)
                cm.Parameters.AddWithValue("@genericid", lblID.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been sucessfully updated", vbInformation)


                With frmGenericList
                    .LoadRecord()
                End With
                Me.Dispose()
                txtGeneric.Clear()
                txtGeneric.Focus()

            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)


        End Try
    End Sub

    Private Sub frmGeneric_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class