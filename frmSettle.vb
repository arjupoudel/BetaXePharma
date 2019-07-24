Imports MySql.Data.MySqlClient
Public Class frmSettle
    Private Sub frmSettle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case Keys.KeyCode
            Case Keys.Escape
                Me.Dispose()
        End Select

    End Sub

    Private Sub frmSettle_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
    End Sub

    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                SettlePayment()
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True

        End Select
    End Sub

    Sub SettlePayment()
        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")

            cn.Close()
            If CDbl(lblDue.Text) > CDbl(txtCash.Text) Then
                MsgBox("Insufficient cash.Please input correct amount.", vbExclamation)
                Return
            End If
            If MsgBox("Are you sure you want to settle this payment ?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()

                cm = New MySqlCommand("insert into tblpayment(invoice,subtotal,vat,discount,amountdue,sdate,user)VALUES(@invoice,@subtotal,@vat,@discount,@amountdue,@sdate,@user)", cn)
                With frmSales
                    cm.Parameters.AddWithValue("@invoice", .lblInvoice.Text)
                    cm.Parameters.AddWithValue("@subtotal", CDbl(.lblSub.Text))
                    cm.Parameters.AddWithValue("@vat", CDbl(.lblVat.Text))
                    cm.Parameters.AddWithValue("@discount", CDbl(.lblDiscount.Text))
                    cm.Parameters.AddWithValue("@amountdue", CDbl(.lblDue.Text))
                    cm.Parameters.AddWithValue("@sdate", sdate)
                    cm.Parameters.AddWithValue("@user", strUser)
                    cm.ExecuteNonQuery()

                    cn.Close()
                    MinusStockQty()
                    MsgBox("Payemnet has been sucessfully saved", vbInformation)
                    .lblInvoice.Text = .GetInvoiceNo
                    .LoadCart()
                End With
                Me.Dispose()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub MinusStockQty()
        With frmSales
            For i = 0 To .DataGridView1.Rows.Count - 1
                cn.Open()
                cm = New MySqlCommand("Update tblproduct set qty = qty - " & CInt(.DataGridView1.Rows(i).Cells(10).Value.ToString) & " where id like '" & .DataGridView1.Rows(i).Cells(2).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()


            Next
            cn.Open()
            cm = New MySqlCommand("update tblcart set status='sold' where invoice like '" & .lblInvoice.Text & "'", cn)
            cm.ExecuteNonQuery()
            cn.Close()
        End With
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Try
            Dim change As Double = CDbl(txtCash.Text) - CDbl(lblDue.Text)

            If change < 0 Then
                lblChange.Text = 0.00
            Else
                lblChange.Text = Format(change, "#,#00.0")
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class