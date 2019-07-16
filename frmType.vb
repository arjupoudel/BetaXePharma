Imports MySql.Data.MySqlClient


Public Class frmType
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged

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
                cm = New MySqlCommand("select * from tbltype where type like '" & txtType.Text & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then found = True
                dr.Close()
                cn.Close()

                If found = False Then
                    cn.Open()
                    cm = Nothing
                    cm = New MySqlCommand("insert into tbltype (type)values(@type)", cn)
                    cm.Parameters.AddWithValue("@type", txtType.Text)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record has been sucessfully saved", vbInformation)
                Else
                    MsgBox("Error: Duplicate Entry.", vbCritical)
                End If

                With frmTypeList
                    .LoadRecord()
                End With
                Me.Dispose()
                txtType.Clear()
                txtType.Focus()

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
                cm = New MySqlCommand("update tbltype set type ='" & txtType.Text & "'where typeid like '" & lblID.Text & "'", cn)
                cm.Parameters.AddWithValue("@type", txtType.Text)
                cm.Parameters.AddWithValue("@typeid", lblID.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been sucessfully updated", vbInformation)


                With frmTypeList
                    .LoadRecord()
                End With
                Me.Dispose()
                txtType.Clear()
                txtType.Focus()

            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)


        End Try
    End Sub

    Private Sub frmType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class