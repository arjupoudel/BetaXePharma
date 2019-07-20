<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDispTotal = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnDiscount = New System.Windows.Forms.Button()
        Me.btnSettle = New System.Windows.Forms.Button()
        Me.btnDailySales = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.label55 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblDue = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.lblInvoice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1089, 92)
        Me.Panel1.TabIndex = 4
        '
        'lblInvoice
        '
        Me.lblInvoice.AutoSize = True
        Me.lblInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice.Location = New System.Drawing.Point(6, 65)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(62, 18)
        Me.lblInvoice.TabIndex = 0
        Me.lblInvoice.Text = "000000"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblDispTotal)
        Me.Panel2.Location = New System.Drawing.Point(893, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(189, 65)
        Me.Panel2.TabIndex = 5
        '
        'lblDispTotal
        '
        Me.lblDispTotal.AutoSize = True
        Me.lblDispTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTotal.Location = New System.Drawing.Point(37, 14)
        Me.lblDispTotal.Name = "lblDispTotal"
        Me.lblDispTotal.Size = New System.Drawing.Size(62, 29)
        Me.lblDispTotal.TabIndex = 0
        Me.lblDispTotal.Text = "0.00"
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(893, 152)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(191, 47)
        Me.btnNew.TabIndex = 6
        Me.btnNew.Text = "New Transaction"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProduct.Enabled = False
        Me.btnProduct.ForeColor = System.Drawing.Color.Black
        Me.btnProduct.Location = New System.Drawing.Point(893, 199)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(191, 44)
        Me.btnProduct.TabIndex = 7
        Me.btnProduct.Text = "Product Inquiry"
        Me.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'btnDiscount
        '
        Me.btnDiscount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiscount.Enabled = False
        Me.btnDiscount.ForeColor = System.Drawing.Color.Black
        Me.btnDiscount.Location = New System.Drawing.Point(893, 236)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(191, 47)
        Me.btnDiscount.TabIndex = 8
        Me.btnDiscount.Text = "Add Discount"
        Me.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiscount.UseVisualStyleBackColor = False
        '
        'btnSettle
        '
        Me.btnSettle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSettle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettle.Enabled = False
        Me.btnSettle.ForeColor = System.Drawing.Color.Black
        Me.btnSettle.Location = New System.Drawing.Point(893, 274)
        Me.btnSettle.Name = "btnSettle"
        Me.btnSettle.Size = New System.Drawing.Size(191, 41)
        Me.btnSettle.TabIndex = 9
        Me.btnSettle.Text = "Settle"
        Me.btnSettle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettle.UseVisualStyleBackColor = False
        '
        'btnDailySales
        '
        Me.btnDailySales.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnDailySales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDailySales.Enabled = False
        Me.btnDailySales.ForeColor = System.Drawing.Color.Black
        Me.btnDailySales.Location = New System.Drawing.Point(893, 311)
        Me.btnDailySales.Name = "btnDailySales"
        Me.btnDailySales.Size = New System.Drawing.Size(191, 47)
        Me.btnDailySales.TabIndex = 10
        Me.btnDailySales.Text = "Daily Sales"
        Me.btnDailySales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDailySales.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.Panel11)
        Me.Panel3.Controls.Add(Me.label55)
        Me.Panel3.Location = New System.Drawing.Point(893, 364)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(191, 49)
        Me.Panel3.TabIndex = 6
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel11.Controls.Add(Me.lblSub)
        Me.Panel11.Location = New System.Drawing.Point(93, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(98, 49)
        Me.Panel11.TabIndex = 9
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSub.Location = New System.Drawing.Point(35, 9)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(58, 25)
        Me.lblSub.TabIndex = 0
        Me.lblSub.Text = "0.00"
        Me.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label55
        '
        Me.label55.AutoSize = True
        Me.label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label55.Location = New System.Drawing.Point(1, 9)
        Me.label55.Name = "label55"
        Me.label55.Size = New System.Drawing.Size(81, 18)
        Me.label55.TabIndex = 0
        Me.label55.Text = "Sub-Total"
        Me.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(893, 414)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(191, 49)
        Me.Panel4.TabIndex = 7
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel10.Controls.Add(Me.lblDiscount)
        Me.Panel10.Location = New System.Drawing.Point(93, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(98, 49)
        Me.Panel10.TabIndex = 9
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(35, 9)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(58, 25)
        Me.lblDiscount.TabIndex = 0
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Disc."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Location = New System.Drawing.Point(893, 464)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(191, 49)
        Me.Panel5.TabIndex = 7
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel9.Controls.Add(Me.lblVat)
        Me.Panel9.Location = New System.Drawing.Point(93, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(98, 49)
        Me.Panel9.TabIndex = 9
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.Location = New System.Drawing.Point(35, 9)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(58, 25)
        Me.lblVat.TabIndex = 0
        Me.lblVat.Text = "0.00"
        Me.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Vatable"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Location = New System.Drawing.Point(893, 515)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(191, 49)
        Me.Panel6.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Due"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel8.Controls.Add(Me.lblDue)
        Me.Panel8.Location = New System.Drawing.Point(93, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(98, 49)
        Me.Panel8.TabIndex = 8
        '
        'lblDue
        '
        Me.lblDue.AutoSize = True
        Me.lblDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDue.Location = New System.Drawing.Point(35, 9)
        Me.lblDue.Name = "lblDue"
        Me.lblDue.Size = New System.Drawing.Size(58, 25)
        Me.lblDue.TabIndex = 0
        Me.lblDue.Text = "0.00"
        Me.lblDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel7.Controls.Add(Me.lblDate)
        Me.Panel7.Controls.Add(Me.lblTime)
        Me.Panel7.Location = New System.Drawing.Point(893, 563)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(191, 89)
        Me.Panel7.TabIndex = 7
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(3, 20)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(72, 18)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Today is"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(20, 54)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(111, 29)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "00:00:00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(710, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.DisplayIcon = True
        Me.txtSearch.Enabled = False
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(9, 105)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "Scan Barcode Here"
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(736, 27)
        Me.txtSearch.TabIndex = 21
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Scan Barcode Here"
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column12, Me.Column6, Me.Column8, Me.Column10, Me.Column7, Me.Column9, Me.Column3, Me.Column4, Me.Column11, Me.Column5})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.Location = New System.Drawing.Point(9, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(881, 514)
        Me.DataGridView1.TabIndex = 22
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Column1
        '
        Me.Column1.FillWeight = 50.0!
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 25
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.FillWeight = 50.0!
        Me.Column2.HeaderText = "ID"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        Me.Column2.Width = 44
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column12.HeaderText = "Bill No                                              "
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 125
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.FillWeight = 50.0!
        Me.Column6.HeaderText = "BRAND NAME"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 103
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "CLASSIFICATION"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 126
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "FORMULATION"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 119
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "GENERIC NAME"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 114
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "TYPE"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 62
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "PRICE"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 68
        '
        'Column4
        '
        Me.Column4.FillWeight = 50.0!
        Me.Column4.HeaderText = "QTY"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 35
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "TOTAL"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 69
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = ""
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 5
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 672)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnDailySales)
        Me.Controls.Add(Me.btnSettle)
        Me.Controls.Add(Me.btnDiscount)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDispTotal As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnProduct As Button
    Friend WithEvents btnDiscount As Button
    Friend WithEvents btnSettle As Button
    Friend WithEvents btnDailySales As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents label55 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblDue As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblSub As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblVat As Label
    Friend WithEvents lblInvoice As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
End Class
