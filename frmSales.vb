﻿Imports MySql.Data.MySqlClient
Public Class frmSales

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        lblInvoice.Text = GetInvoiceNo()
        'cbofilter.Enabled = True
        txtSearch.Enabled = True
        txtSearch.Focus()

    End Sub
    Function GetInvoiceNo() As String

        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")
            cn.Open()
            cm = New MySqlCommand("select invoice from tblcart where invoice like '%" & sdate & "%' order by id desc limit 0,30", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then GetInvoiceNo = dr.Item("invoice").ToString Else GetInvoiceNo = String.Empty
            dr.Close()
            cn.Close()
            If GetInvoiceNo = String.Empty Then
                GetInvoiceNo = sdate & "0001"
                Return GetInvoiceNo
            Else
                GetInvoiceNo = CLng(GetInvoiceNo) + 1
                Return GetInvoiceNo
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
            Return GetInvoiceNo()
        End Try

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    'Sub SearchProduct(ByVal pfilter As String, ByVal psearch As String)
    Sub SearchProduct(ByVal psearch As String)
        Try
            cn.Open()

            If psearch = String.Empty Then Return
            cm = New MySqlCommand("select * from tblproduct where barcode like '" & psearch & "'", cn)

            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                With frmQty
                    .lblPrice.Text = dr.Item("price").ToString
                    .lblPID.Text = dr.Item("id").ToString
                    dr.Close()
                    cn.Close()
                    .ShowDialog()
                    Return
                End With
            Else MsgBox("Couldnot find record in database please retry", vbInformation)

            End If
            dr.Close()
            cn.Close()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub





    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchProduct(txtSearch.Text)
    End Sub

    Sub LoadCart()
        Try
            Dim i As Integer = 0
            Dim _total As Double = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("Select * from  tblcart as ca inner join tblproduct as p on ca.pid=p.id inner join tblbrand as b on p.bid=b.brandid inner join tblclassification as c on p.cid=c.classificationid 
    inner join tblformulation as f on p.fid = f.formulationid inner join tblgeneric as g on p.gid =g.genericid inner join tbltype as t on p.tid =t.typeid where invoice like '" & lblInvoice.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("invoice").ToString, dr.Item("brand").ToString, dr.Item("classification").ToString, dr.Item("formulation").ToString, dr.Item("generic").ToString,
               dr.Item("type").ToString, dr.Item("price").ToString, dr.Item("qty").ToString,
                                       dr.Item("total").ToString)
                _total += CDbl(dr.Item("total").ToString)

            End While
            dr.Close()
            cn.Close()
            lblDispTotal.Text = Format(_total, "#,##0.00")

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class