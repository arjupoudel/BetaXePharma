Imports MySql.Data.MySqlClient
Public Class frmProduct


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub txtFormulation_TextChanged_1(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBrand()
        LoadGeneric()
        LoadClassification()
        LoadFormulation()
        LoadType()
    End Sub

    Sub LoadBrand()
        cn.Open()
        cm = New MySqlCommand("select * from tblbrand order by brand", cn)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "brand")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("brand").ToString)
        Next
        txtBrand.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBrand.AutoCompleteCustomSource = col
        txtBrand.AutoCompleteMode = AutoCompleteMode.Suggest
        cm = Nothing
        cn.Close()
    End Sub


    Sub LoadGeneric()
        cn.Open()
        cm = New MySqlCommand("select * from tblgeneric order by generic", cn)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "generic")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("generic").ToString)
        Next
        txtGeneric.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtGeneric.AutoCompleteCustomSource = col
        txtGeneric.AutoCompleteMode = AutoCompleteMode.Suggest
        cm = Nothing
        cn.Close()
    End Sub
    Sub LoadClassification()
        cn.Open()
        cm = New MySqlCommand("select * from tblclassification order by classification", cn)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "classification")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("classification").ToString)
        Next
        txtClassification.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtClassification.AutoCompleteCustomSource = col
        txtClassification.AutoCompleteMode = AutoCompleteMode.Suggest
        cm = Nothing
        cn.Close()
    End Sub
    Sub LoadFormulation()
        cn.Open()
        cm = New MySqlCommand("select * from tblformulation order by formulation", cn)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "formulation")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("formulation").ToString)
        Next
        txtFormulation.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtFormulation.AutoCompleteCustomSource = col
        txtFormulation.AutoCompleteMode = AutoCompleteMode.Suggest
        cm = Nothing
        cn.Close()
    End Sub
    Sub LoadType()
        cn.Open()
        cm = New MySqlCommand("select * from tbltype order by type", cn)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "type")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("type").ToString)
        Next
        txtType.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtType.AutoCompleteCustomSource = col
        txtType.AutoCompleteMode = AutoCompleteMode.Suggest
        cm = Nothing
        cn.Close()
    End Sub

    Sub Clear()
        txtGeneric.Clear()
        txtFormulation.Clear()
        txtClassification.Clear()
        txtBrand.Clear()
        txtPrice.Clear()
        txtType.Clear()
        txtQty.Clear()
        txtPrice.Clear()
        txtReorder.Clear()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtBarcode.Focus()


    End Sub

    Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If IS_EMPTY(txtBarcode) = True Then Return
            If IS_EMPTY(lblBrand, txtBrand) = True Then Return
            If IS_EMPTY(lblGeneric, txtGeneric) = True Then Return
            If IS_EMPTY(lblFormulation, txtFormulation) = True Then Return
            If IS_EMPTY(lblClassification, txtClassification) = True Then Return
            If IS_EMPTY(lblType, txtType) = True Then Return
            If IS_EMPTY(txtReorder) = True Then Return
            If IS_EMPTY(txtQty) = True Then Return
            If IS_EMPTY(txtPrice) = True Then Return

            If ValidateDuplicateEntry("select * from tblproduct where barcode like '" & txtBarcode.Text & "'") = True Then Return

            cn.Open()

            cm = New MySqlCommand("insert into tblproduct(barcode, Bid, gid, cid, tid, fid, reorder, qty, price)VALUES(@barcode,@bid,@gid,@cid,@tid,@fid,@reorder,@qty,@price)", cn)
            'cm = New MySqlCommand("insert into tblproduct(barcode,bid,gid,cid,tid,fid,reorder,qty,price)VALUES('" & txtBarcode.Text & "',
            '    '" & CInt(lblBrand.Text) & "','" & CInt(lblGeneric.Text) & "','" & CInt(lblClassification.Text) & "', '" & CInt(lblType.Text) & "','" & CInt(lblFormulation.Text) & "',
            '    '" & CInt(txtReorder.Text) & "','" & CInt(txtQty.Text) & "', '" & CDbl(txtPrice.Text) & "'", cn)
            With cm
                .Parameters.AddWithValue("@barcode", txtBarcode.Text)
                .Parameters.AddWithValue("@bid", CInt(lblBrand.Text))
                .Parameters.AddWithValue("@gid", CInt(lblGeneric.Text))
                .Parameters.AddWithValue("@cid", CInt(lblClassification.Text))
                .Parameters.AddWithValue("@tid", CInt(lblType.Text))
                .Parameters.AddWithValue("@fid", CInt(lblFormulation.Text))
                .Parameters.AddWithValue("@reorder", CInt(txtReorder.Text))
                .Parameters.AddWithValue("@qty", CInt(txtQty.Text))
                .Parameters.AddWithValue("@price", CDbl(txtPrice.Text))
                .ExecuteNonQuery()

            End With


            'If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then

            '    cn.Open()
            '    cm = New MySqlCommand("insert into tblproduct(barcode,bid,gid,cid,tid,fid,reorder,qty,price)VALUES('" & txtBarcode.Text & "',
            '" & CInt(lblBrand.Text) & "','" & CInt(lblGeneric.Text) & "','" & CInt(lblClassification.Text) & "', '" & CInt(lblType.Text) & "','" & CInt(lblFormulation.Text) & "',
            '" & CInt(txtReorder.Text) & "','" & CInt(txtQty.Text) & "', '" & CDbl(txtPrice.Text) & "'", cn)
            '    MsgBox("Record has been sucessfully saved", vbInformation)
            'End If
            MsgBox("Record has been sucessfully saved", vbInformation)
            cn.Close()

            With frmProductList
                .LoadRecord()
            End With
            Me.Dispose()
        Catch ex As Exception
            cn.Close()
        MsgBox(ex.Message, vbCritical)

        End Try
    End Sub






    Private Sub txtBrand_TextChanged(sender As Object, e As EventArgs) Handles txtBrand.TextChanged
        cn.Open()
        'cm = New MySqlCommand("Select * from tblbrand where brand like@brand", cn)
        'cm.Parameters.AddWithValue("@brand", txtBrand.Text)
        cm = New MySqlCommand("Select * from tblbrand where brand Like '" & txtBrand.Text & "'", cn)
            cm.ExecuteNonQuery()
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then lblBrand.Text = dr.Item(0).ToString Else lblBrand.Text = String.Empty
        cm = Nothing
        dr.Close()
        cn.Close()
    End Sub

    Private Sub txtGeneric_TextChanged(sender As Object, e As EventArgs) Handles txtGeneric.TextChanged
        cn.Open()

        cm = New MySqlCommand("select * from tblgeneric where generic like '" & txtGeneric.Text & "'", cn)
        cm.ExecuteNonQuery()
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then lblGeneric.Text = dr.Item(0).ToString Else lblGeneric.Text = String.Empty
        cm = Nothing
        dr.Close()
        cn.Close()
    End Sub

    Private Sub txtClassification_TextChanged(sender As Object, e As EventArgs) Handles txtClassification.TextChanged
        cn.Open()
        'cm = New MySqlCommand("select * from tblclassification where classification like@classification", cn)
        'cm.Parameters.AddWithValue("@classification", txtClassification.Text)
        cm = New MySqlCommand("select * from tblclassification where classification like '" & txtClassification.Text & "'", cn)
        cm.ExecuteNonQuery()
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then lblClassification.Text = dr.Item(0).ToString Else lblClassification.Text = String.Empty
        cm = Nothing
        dr.Close()
        cn.Close()
    End Sub

    Private Sub txtFormulation_TextChanged(sender As Object, e As EventArgs) Handles txtFormulation.TextChanged
        cn.Open()
        'cm = New MySqlCommand("select * from tblformulation where formulation like@formulation", cn)
        'cm.Parameters.AddWithValue("@formulation", txtFormulation.Text)
        cm = New MySqlCommand("select * from tblformulation where formulation like '" & txtFormulation.Text & "'", cn)

        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then lblFormulation.Text = dr.Item(0).ToString Else lblFormulation.Text = String.Empty
        cm = Nothing
        dr.Close()
        cn.Close()
    End Sub

    Private Sub txtType_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged
        cn.Open()
        'cm = New MySqlCommand("select * from tbltype where type like@type", cn)
        'cm.Parameters.AddWithValue("@type", txtType.Text)
        cm = New MySqlCommand("select * from tbltype where type like '" & txtType.Text & "'", cn)
        cm.ExecuteNonQuery()
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then lblType.Text = dr.Item(0).ToString Else lblType.Text = String.Empty
        cm = Nothing
        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If IS_EMPTY(txtBarcode) = True Then Return
            If IS_EMPTY(lblBrand, txtBrand) = True Then Return
            If IS_EMPTY(lblGeneric, txtGeneric) = True Then Return
            If IS_EMPTY(lblFormulation, txtFormulation) = True Then Return
            If IS_EMPTY(lblClassification, txtClassification) = True Then Return
            If IS_EMPTY(lblType, txtType) = True Then Return
            If IS_EMPTY(txtReorder) = True Then Return
            If IS_EMPTY(txtQty) = True Then Return
            If IS_EMPTY(txtPrice) = True Then Return

            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                cn.Open()
                cm = Nothing
                cm = New MySqlCommand("update tblproduct set barcode=@barcode, bid=@bid, gid=@gid, cid=@cid, tid=@tid, fid=@fid, reorder=@reorder, qty=@qty, price=@price where id like @id", cn)

                With cm
                    .Parameters.AddWithValue("@barcode", txtBarcode.Text)
                    .Parameters.AddWithValue("@bid", CInt(lblBrand.Text))
                    .Parameters.AddWithValue("@gid", CInt(lblGeneric.Text))
                    .Parameters.AddWithValue("@cid", CInt(lblClassification.Text))
                    .Parameters.AddWithValue("@tid", CInt(lblType.Text))
                    .Parameters.AddWithValue("@fid", CInt(lblFormulation.Text))
                    .Parameters.AddWithValue("@reorder", CInt(txtReorder.Text))
                    .Parameters.AddWithValue("@qty", CInt(txtQty.Text))
                    .Parameters.AddWithValue("@price", CDbl(txtPrice.Text))
                    .Parameters.AddWithValue("@id", CInt(lblID.Text))
                    .ExecuteNonQuery()
                End With

                MsgBox("Record has been sucessfully updated", vbInformation)
                cn.Close()
            End If
            With frmProductList
                .LoadRecord()
            End With
            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub
End Class