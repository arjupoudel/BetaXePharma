<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduct))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtFormulation = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtClassification = New System.Windows.Forms.TextBox()
        Me.txtGeneric = New System.Windows.Forms.TextBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblGeneric = New System.Windows.Forms.Label()
        Me.lblFormulation = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblClassification = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtReorder = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 71)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(451, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 32)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Entry"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(12, 111)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(442, 21)
        Me.txtBarcode.TabIndex = 17
        Me.txtBarcode.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "BARCODE"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(12, 282)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(442, 21)
        Me.txtType.TabIndex = 19
        Me.txtType.WordWrap = False
        '
        'txtFormulation
        '
        Me.txtFormulation.Location = New System.Drawing.Point(12, 324)
        Me.txtFormulation.Name = "txtFormulation"
        Me.txtFormulation.Size = New System.Drawing.Size(442, 21)
        Me.txtFormulation.TabIndex = 20
        Me.txtFormulation.WordWrap = False
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(16, 410)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(439, 21)
        Me.txtPrice.TabIndex = 21
        Me.txtPrice.WordWrap = False
        '
        'txtClassification
        '
        Me.txtClassification.Location = New System.Drawing.Point(12, 237)
        Me.txtClassification.Name = "txtClassification"
        Me.txtClassification.Size = New System.Drawing.Size(442, 21)
        Me.txtClassification.TabIndex = 22
        Me.txtClassification.WordWrap = False
        '
        'txtGeneric
        '
        Me.txtGeneric.Location = New System.Drawing.Point(12, 195)
        Me.txtGeneric.Name = "txtGeneric"
        Me.txtGeneric.Size = New System.Drawing.Size(442, 21)
        Me.txtGeneric.TabIndex = 23
        Me.txtGeneric.WordWrap = False
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(12, 153)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(442, 21)
        Me.txtBrand.TabIndex = 24
        Me.txtBrand.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "CLASSIFICATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "TYPE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "FORMULATION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "PRICE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 15)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "GENERIC NAME"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 15)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "BRAND NAME"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(368, 491)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 32)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(282, 491)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 32)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(196, 491)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 32)
        Me.btnUpdate.TabIndex = 33
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblBrand
        '
        Me.lblBrand.BackColor = System.Drawing.SystemColors.Control
        Me.lblBrand.Location = New System.Drawing.Point(460, 153)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(15, 15)
        Me.lblBrand.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 434)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 15)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "INITIAL QTY"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(15, 452)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(439, 21)
        Me.txtQty.TabIndex = 36
        Me.txtQty.WordWrap = False
        '
        'lblGeneric
        '
        Me.lblGeneric.BackColor = System.Drawing.SystemColors.Control
        Me.lblGeneric.Location = New System.Drawing.Point(460, 198)
        Me.lblGeneric.Name = "lblGeneric"
        Me.lblGeneric.Size = New System.Drawing.Size(15, 15)
        Me.lblGeneric.TabIndex = 37
        '
        'lblFormulation
        '
        Me.lblFormulation.BackColor = System.Drawing.SystemColors.Control
        Me.lblFormulation.Location = New System.Drawing.Point(460, 327)
        Me.lblFormulation.Name = "lblFormulation"
        Me.lblFormulation.Size = New System.Drawing.Size(15, 15)
        Me.lblFormulation.TabIndex = 42
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.SystemColors.Control
        Me.lblType.Location = New System.Drawing.Point(460, 282)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(15, 15)
        Me.lblType.TabIndex = 43
        '
        'lblClassification
        '
        Me.lblClassification.BackColor = System.Drawing.SystemColors.Control
        Me.lblClassification.Location = New System.Drawing.Point(460, 240)
        Me.lblClassification.Name = "lblClassification"
        Me.lblClassification.Size = New System.Drawing.Size(15, 15)
        Me.lblClassification.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 15)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "REORDER LEVEL"
        '
        'txtReorder
        '
        Me.txtReorder.Location = New System.Drawing.Point(13, 368)
        Me.txtReorder.Name = "txtReorder"
        Me.txtReorder.Size = New System.Drawing.Size(442, 21)
        Me.txtReorder.TabIndex = 46
        Me.txtReorder.WordWrap = False
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.SystemColors.Control
        Me.lblID.Location = New System.Drawing.Point(34, 508)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(15, 15)
        Me.lblID.TabIndex = 47
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 554)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtReorder)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblClassification)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblFormulation)
        Me.Controls.Add(Me.lblGeneric)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.txtGeneric)
        Me.Controls.Add(Me.txtClassification)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtFormulation)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProduct"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtFormulation As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtClassification As TextBox
    Friend WithEvents txtGeneric As TextBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblBrand As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblGeneric As Label
    Friend WithEvents lblFormulation As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblClassification As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtReorder As TextBox
    Friend WithEvents lblID As Label
End Class
