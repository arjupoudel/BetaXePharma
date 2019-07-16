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
            With frmClassificationList
                .TopLevel = False
                TabPage4.Controls.Add(frmClassificationList)
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

End Class