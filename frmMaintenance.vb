Imports MySql.Data.MySqlClient
Public Class frmMaintenance
    Private Sub frmMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        TabControl1.SelectedIndex = 0
        With frmBrandList
            .TopLevel = False
            TabPage1.Controls.Add(frmBrandList)
            .LoadRecord()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedIndex = 3 Then
            With frmClassificationlist
                .TopLevel = False
                TabPage4.Controls.Add(frmClassificationlist)
                .LoadRecord()
                .BringToFront()
                .Show()
            End With
        ElseIf TabControl1.SelectedIndex = 0 Then
            With frmBrandList
                .TopLevel = False
                TabPage1.Controls.Add(frmBrandList)
                .LoadRecord()
                .BringToFront()
                .Show()
            End With
        ElseIf TabControl1.SelectedIndex = 1 Then
            With frmGenericList
                .TopLevel = False
                TabPage2.Controls.Add(frmGenericList)
                .LoadRecord()
                .BringToFront()
                .Show()
            End With
        ElseIf TabControl1.SelectedIndex = 4 Then
            With frmTypeList
                .TopLevel = False
                TabPage5.Controls.Add(frmTypeList)
                .LoadRecord()
                .BringToFront()
                .Show()
            End With
        ElseIf TabControl1.SelectedIndex = 2 Then
            With frmFormulationList
                .TopLevel = False
                TabPage3.Controls.Add(frmFormulationList)
                .LoadRecord()
                .BringToFront()
                .Show()
            End With
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            cn.Open()
            cm = New MySqlCommand("select count(*) from tblvat", cn)
            Dim icount As Integer = CInt(cm.ExecuteScalar)
            cn.Close()
            If icount > 0 Then
                cn.Open()
                cm = New MySqlCommand("update tblvat set vat = '" & CDbl(txtVat.Text) & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
            Else
                cn.Open()
                cm = New MySqlCommand("insert into tblvat(vat)VALUES('" & CDbl(txtVat.Text) & "')", cn)
                cm.ExecuteNonQuery()
                cn.Close()
            End If
            MsgBox("Vat has been sucesfully saved.", vbInformation)
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub



    Private Sub txtVat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVat.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True

        End Select
    End Sub
End Class