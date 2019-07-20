Imports MySql.Data.MySqlClient
Public Class frmSales

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        lblInvoice.Text = GetInvoiceNo()
        cbofilter.Enabled = True
        txtSearch.Enabled = True
        txtSearch.Focus()

    End Sub
    Function GetInvoiceNo() As String

        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")
            cn.Open()
            cm = New MySqlCommand("select invoice from tblcart where invoice like '" & sdate & "%'", cn)
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
End Class