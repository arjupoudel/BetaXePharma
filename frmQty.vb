Imports MySql.Data.MySqlClient
Public Class frmQty
    Private Sub frmQty_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'If (e.KeyCode = Keys.Escape) Then
        '    With frmSales
        '        .txtSearch.Focus()
        '        .txtSearch.SelectionStart = 0
        '        .txtSearch.SelectionLength = .txtSearch.Text.Length
        '    End With
        '    Me.Dispose()
        'End If
        Select Case e.KeyCode
            Case Keys.Escape   'when pressing esc key
                With frmSales
                    .txtSearch.Focus()
                    .txtSearch.SelectionStart = 0
                    .txtSearch.SelectionLength = .txtSearch.Text.Length
                End With
                Me.Dispose()
        End Select
    End Sub

    Private Sub frmQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        txtQty.Focus()
        txtQty.SelectionStart = 0
        txtQty.SelectionLength = txtQty.Text.Length
    End Sub

    Sub AddToCart()
        Try

            If txtQty.Text = String.Empty Or txtQty.Text = "0" Then Return
            Dim sdate As String = Now.ToString("yyyy-MM-dd")
            cn.Open()
            cm = New MySqlCommand("Insert into tblcart(invoice,pid,price,qty,sdate,user)VALUES(@invoice,@pid,@price,@qty,@sdate,@user)", cn)
            With frmSales
                cm.Parameters.AddWithValue("@invoice", .lblInvoice.Text)
                cm.Parameters.AddWithValue("@pid", lblPID.Text)
                cm.Parameters.AddWithValue("@price", CDbl(lblPrice.Text))
                cm.Parameters.AddWithValue("@qty", CInt(txtQty.Text))
                cm.Parameters.AddWithValue("@sdate", sdate)
                cm.Parameters.AddWithValue("@user", strUser)
                cm.ExecuteNonQuery()
                cn.Close()

                cn.Open()
                cm = New MySqlCommand("update tblcart set total = price * qty where invoice like '" & .lblInvoice.Text & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()


                .txtSearch.Focus()
                .txtSearch.SelectionStart = 0
                .txtSearch.SelectionLength = .txtSearch.Text.Length
                With frmSales
                    .LoadCart()
                End With
            End With
            Me.Dispose()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress

        Select Case Asc(e.KeyChar)
            'Asc(e.KeyChar) = 13 Is Enter key
            Case 13
                AddToCart()
            Case 48 To 57
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub


End Class