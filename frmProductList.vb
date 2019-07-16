Imports MySql.Data.MySqlClient
Public Class frmProductList

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        With frmProduct
            .btnSave.Show()
            .btnUpdate.Hide()
            .btnUpdate.Enabled = False
            .btnSave.Enabled = True
            .ShowDialog()

        End With
    End Sub
    Sub LoadRecord()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()

        cn.Open()
        cm = New MySqlCommand("select *from tblproduct as p  inner join tblbrand as b on p.bid=b.brandid inner join tblclassification as c on p.cid=c.classificationid 
    inner join tblformulation as f on p.fid = f.formulationid inner join tblgeneric as g on p.gid =g.genericid inner join tbltype as t on p.tid =t.typeid", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("barcode").ToString, dr.Item("brand").ToString, dr.Item("classification").ToString, dr.Item("formulation").ToString,
           dr.Item("generic").ToString, dr.Item("type").ToString, dr.Item("reorder").ToString,
                                   dr.Item("price").ToString, dr.Item("qty").ToString, "EDIT", "DEL")

        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colEdit" Then
            If MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes Then

                With frmProduct
                    .lblID.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtBarcode.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtBrand.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                    .txtGeneric.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                    .txtClassification.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txtType.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                    .txtFormulation.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtReorder.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                    .txtPrice.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
                    .txtQty.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    .txtQty.Enabled = False
                    .ShowDialog()
                End With
            End If
        ElseIf colName = "colDel" Then
                If MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("delete from tblproduct where id like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been sucessfully deleted", vbInformation)
                LoadRecord()

            End If
        End If
    End Sub
End Class