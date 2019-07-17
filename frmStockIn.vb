Imports MySql.Data.MySqlClient
Public Class frmStockIn

    Sub LoadProduct()
        If cboFilter.Text = String.Empty Then Return
        If txtSearch.Text = String.Empty Then Return
        Dim i As Integer = 0
        DataGridView2.Rows.Clear()

        cn.Open()
        cm = New MySqlCommand("select *from tblproduct as p  inner join tblbrand as b on p.bid=b.brandid inner join tblclassification as c on p.cid=c.classificationid 
    inner join tblformulation as f on p.fid = f.formulationid inner join tblgeneric as g on p.gid =g.genericid inner join tbltype as t on p.tid =t.typeid where " & cboFilter.Text & " like '" & txtSearch.Text & "%'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView2.Rows.Add(i, dr.Item("id").ToString, dr.Item("brand").ToString & Space(2) & "|" & Space(2) & dr.Item("classification").ToString & Space(2) & "|" & Space(2) & dr.Item("formulation").ToString & Space(2) & "|" & Space(2) &
          dr.Item("generic").ToString & Space(2) & "|" & Space(2) & dr.Item("type").ToString & Space(2))

        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub cboFilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboFilter.KeyPress
        e.Handled = True
    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadProduct()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Try
            If IS_EMPTY(txtRefNo) = True Then Return
            If IS_EMPTY(txtRecieved) = True Then Return
            Dim colName As String = DataGridView2.Columns(e.ColumnIndex).Name
            Dim data As String = DataGridView2.Rows(e.RowIndex).Cells(2).Value.ToString
            Dim arr() As String = data.Split("|")
            If colName = "colselect" Then
                If MsgBox("Brand: " & arr(0).ToString & vbCr &
                    "Classification: " & arr(1).ToString & vbCr &
                    "Formulation: " & arr(2).ToString & vbCr &
                      "Generic: " & arr(3).ToString & vbCr &
                      "Type: " & arr(4).ToString & vbCr & "Please confirm", vbYesNo + vbQuestion) = vbYes Then


                    DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, DataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString, arr(0).ToString, arr(1).ToString, arr(2).ToString, arr(3).ToString, arr(4).ToString)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)


        End Try
    End Sub
End Class
