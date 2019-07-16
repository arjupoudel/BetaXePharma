﻿Imports MySql.Data.MySqlClient
Public Class frmGenericList
    Dim _genericid, _generic, tmpid As String


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        With frmGeneric
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
        cm = New MySqlCommand("select * from tblgeneric order by generic", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("genericid").ToString, dr.Item("generic").ToString, "EDIT", "DELETE")
        End While
        dr.Close()
        cn.Close()
        lblCount.Text = "(" & DataGridView1.RowCount & ")record(s) found."
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "Column4" Then
            With frmbrand
                .lblID.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .txtBrand.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .btnSave.Hide()
                .btnUpdate.Show()
                .ShowDialog()
            End With

        ElseIf colname = "Column5" Then
            If (MsgBox("Are you sure you want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
                cn.Open()
                cm = New MySqlCommand("delete from tblgeneric where genericid like'" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()

                cn.Close()
                MsgBox("Record has been sucessfully deleted.", vbInformation)
                LoadRecord()
            End If
        End If
    End Sub



    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim i As Integer = DataGridView1.CurrentRow.Index
        _genericid = DataGridView1.Item(1, i).Value
        _generic = DataGridView1.Item(2, i).Value
    End Sub
End Class