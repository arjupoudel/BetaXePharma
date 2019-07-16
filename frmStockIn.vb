Imports MySql.Data.MySqlClient
Public Class frmStockIn

    Sub LoadProduct()
        Dim i As Integer = 0
        DataGridView2.Rows.Clear()

        cn.Open()
        cm = New MySqlCommand("select *from tblproduct as p  inner join tblbrand as b on p.bid=b.brandid inner join tblclassification as c on p.cid=c.classificationid 
    inner join tblformulation as f on p.fid = f.formulationid inner join tblgeneric as g on p.gid =g.genericid inner join tbltype as t on p.tid =t.typeid", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView2.Rows.Add(i, dr.Item("id").ToString, dr.Item("brand").ToString & Space(2) & dr.Item("classification").ToString & Space(2) & dr.Item("formulation").ToString & Space(2) &
          dr.Item("generic").ToString & Space(2) & dr.Item("type").ToString & Space(2), "EDIT")

        End While

    End Sub


End Class