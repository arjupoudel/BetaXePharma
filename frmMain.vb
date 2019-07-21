Public Class frmMain


    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        With frmMaintenance
            .TopLevel = False
            Panel3.Controls.Add(frmMaintenance)
            .txtVat.Text = GetVAT()
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub btnMaintenance_ClientSizeChanged(sender As Object, e As EventArgs) Handles btnMaintenance.ClientSizeChanged

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        connection()
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        With frmProductList
            .TopLevel = False
            Panel3.Controls.Add(frmProductList)
            .LoadRecord()
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        With frmStockIn
            .LoadProduct()
            .TopLevel = False
            Panel3.Controls.Add(frmStockIn)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        With frmSales
            ''.TopLevel = False
            ''Panel3.Controls.Add(frmSales)
            ''.BringToFront()
            .ShowDialog()

        End With
    End Sub
End Class
