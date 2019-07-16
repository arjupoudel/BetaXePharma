Imports MySql.Data.MySqlClient


Public Class frmClassification
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtClassification.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim found As Boolean = False
                cn.Open()
                'cm = New MySqlCommand("insert into tblclassification (classification)values('" & txtClassification.Text & "')", cn)
                'cm.ExecuteNonQuery()
                cm = New MySqlCommand("select * from tblclassification where classification like '" & txtClassification.Text & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then found = True
                dr.Close()
                cn.Close()

                If found = False Then
                    cn.Open()
                    cm = Nothing
                    cm = New MySqlCommand("insert into tblclassification (classification)values(@classification)", cn)
                    cm.Parameters.AddWithValue("@classification", txtClassification.Text)
                    cm.ExecuteNonQuery()
                    cn.Close()
                Else
                    MsgBox("Error: Duplicate Entry.", vbCritical)
                End If
                MsgBox("Record has been sucessfully saved", vbInformation)
                With frmClassificationList
                    .LoadRecord()
                End With
                Me.Dispose()
                txtClassification.Clear()
                txtClassification.Focus()

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
                cm = New MySqlCommand("update tblclassification set classification ='" & txtClassification.Text & "'where classificationid like '" & lblID.Text & "'", cn)
                cm.Parameters.AddWithValue("@classification", txtClassification.Text)
                cm.Parameters.AddWithValue("@classificationid", lblID.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been sucessfully updated", vbInformation)


                With frmClassificationlist
                    .LoadRecord()
                End With
                Me.Dispose()
                txtClassification.Clear()
                txtClassification.Focus()

            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)


        End Try
    End Sub

    Private Sub frmClassification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class