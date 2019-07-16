Imports MySql.Data.MySqlClient


Public Class frmbrand
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBrand.TextChanged

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
                cm = New MySqlCommand("select * from tblbrand where brand like '" & txtBrand.Text & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then found = True
                dr.Close()
                cn.Close()

                If found = False Then
                    cn.Open()
                    cm = Nothing
                    cm = New MySqlCommand("insert into tblbrand (brand)values(@brand)", cn)
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record has been sucessfully saved", vbInformation)
                Else
                    MsgBox("Error: Duplicate Entry.", vbCritical)
                End If

                With frmBrandList
                    .LoadRecord()
                End With

                Me.Dispose()
                txtBrand.Clear()
                txtBrand.Focus()

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
                cm = New MySqlCommand("update tblbrand set brand ='" & txtBrand.Text & "'where brandid like '" & lblID.Text & "'", cn)
                cm.Parameters.AddWithValue("@brand", txtBrand.Text)
                cm.Parameters.AddWithValue("@brandid", lblID.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been sucessfully updated", vbInformation)


                With frmBrandList
                    .LoadRecord()
                End With
                Me.Dispose()
                txtBrand.Clear()
                txtBrand.Focus()

            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)


        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class