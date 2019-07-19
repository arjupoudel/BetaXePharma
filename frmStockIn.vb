Imports MySql.Data.MySqlClient
Public Class frmStockIn

    Sub LoadProduct()
        If cboFilter.Text = String.Empty Then Return
        If txtSearch.Text = String.Empty Then Return
        Dim i As Integer = 0
        DataGridView2.Rows.Clear()

        cn.Open()
        cm = New MySqlCommand("select * from tblproduct as p  inner join tblbrand as b on p.bid=b.brandid inner join tblclassification as c on p.cid=c.classificationid 
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(7).Value = String.Empty Then
                    MsgBox("Please input quantity.", vbExclamation)
                    Return
                End If
            Next
            Dim sdate As String = dtDate.Value.ToString("yyyy-MM-dd")
            For i As Integer = 0 To DataGridView1.Rows.Count - 1

                'this code avoid duplicate entry'
                Dim found As Boolean = False
                cn.Open()
                cm = New MySqlCommand("select * from tblstockin where refno like '" & txtRefNo.Text & "' and pid Like '" & DataGridView1.Rows(i).Cells(1).Value.ToString & "' and sdate like '" & sdate & "'", cn)
                'And pid Like '" & DataGridView1.Rows(i).Cells(1).Value.ToString & "'and sdate like '" & sdate & "'
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then found = True Else found = False
                dr.Close()
                cn.Close()

                If found = False Then
                    cn.Open()
                    cm = Nothing
                    cm = New MySqlCommand("insert into tblstockin(refno, recievedby, pid, qty, sdate)VALUES(@refno,@recievedby,@pid,@qty,@sdate)", cn)
                    With cm
                        .Parameters.AddWithValue("@refno", txtRefNo.Text)
                        .Parameters.AddWithValue("@recievedby", txtRecieved.Text)
                        .Parameters.AddWithValue("@pid", CInt(DataGridView1.Rows(i).Cells(1).Value.ToString))
                        .Parameters.AddWithValue("@qty", CInt(DataGridView1.Rows(i).Cells(7).Value.ToString))
                        .Parameters.AddWithValue("@sdate", sdate)

                        .ExecuteNonQuery()
                    End With
                    cn.Close()
                    cn.Open()
                    cm = Nothing
                    cm = New MySqlCommand("update tblproduct Set qty= qty + " & CInt(DataGridView1.Rows(i).Cells(7).Value.ToString) & " where id Like '" & DataGridView1.Rows(i).Cells(1).Value.ToString & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Stocks sucessfully saved.", vbInformation)
                    Me.Close()
                Else MsgBox("Sorry duplicate entry for stock  ,change your reference number and date ", vbExclamation)
                End If
            Next


        Catch ex As Exception
            Me.Close()
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        On Error Resume Next
        Dim stock As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(7).Value.ToString <> String.Empty Then stock += CDbl(DataGridView1.Rows(i).Cells(7).Value.ToString)

        Next
        txtstock.Text = stock
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtRecieved.Clear()
        txtRefNo.Clear()
        dtDate.Value = Now
        DataGridView1.Rows.Clear()
    End Sub

    Sub LoadStockInHistory()
        Dim sdate1 As String = dtDate1.Value.ToString("yyyy-MM-dd")
        Dim sdate2 As String = dtDate2.Value.ToString("yyyy-MM-dd")

        Dim i As Integer = 0
        DataGridView3.Rows.Clear()

        cn.Open()
        cm = New MySqlCommand("select * from tblstockin as s inner join tblproduct as p on s.pid=p.id  join tblbrand as b on p.bid=b.brandid inner join tblclassification as c on p.cid=c.classificationid 
    inner join tblformulation as f on p.fid = f.formulationid inner join tblgeneric as g on p.gid =g.genericid inner join tbltype as t on p.tid =t.typeid where sdate between '" & sdate1 & "'and'" & sdate2 & "' order by s.id", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView3.Rows.Add(i, dr.Item("id").ToString, dr.Item("refno").ToString, dr.Item("recievedby").ToString, dr.Item("brand").ToString, dr.Item("classification").ToString, dr.Item("formulation").ToString,
           dr.Item("generic").ToString, dr.Item("type").ToString, dr.Item("qty").ToString,
                      Format(CDate(dr.Item("sdate").ToString), "MM/dd/yyyy"))


        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click
        LoadStockInHistory()
    End Sub
End Class
