<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductInfoForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttelno = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.PRO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BARCODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_PRODUCT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_EXPIRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1119, 615)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ສ່ວນລວມ"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 330)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(1090, 276)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ສ່ວນສະແດງ"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRO_ID, Me.BARCODE, Me.PRODUCT_NAME, Me.PRODUCT_TYPE, Me.DATE_PRODUCT, Me.DATE_EXPIRE})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(8, 23)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1074, 245)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnExit)
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.btnEdit)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Controls.Add(Me.btnShow)
        Me.GroupBox3.Location = New System.Drawing.Point(93, 216)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(939, 106)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ຈັດການຂໍ້ມູນ"
        '
        'btnExit
        '
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(765, 27)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 54)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "ອອກ"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(620, 27)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(136, 54)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "ລົບ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(476, 27)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(136, 54)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "ບັນທຶກ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(332, 27)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(136, 54)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "ແກ້ໄຂ"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(188, 27)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(136, 54)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "ເພີ່ມ"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(44, 27)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(136, 54)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "ສະແດງ"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txttelno)
        Me.GroupBox2.Controls.Add(Me.txtlastname)
        Me.GroupBox2.Controls.Add(Me.txtfirstname)
        Me.GroupBox2.Controls.Add(Me.txtcustid)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 30)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1089, 178)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ຂໍ້ມູນສິນຄ້າ"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(689, 124)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(312, 35)
        Me.DateTimePicker2.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yyyy"
        Me.DateTimePicker1.Location = New System.Drawing.Point(162, 117)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(312, 35)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(530, 124)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ວັນທີເດືອນປີໝົດອາຍຸ :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(577, 86)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ປະເພດສິນຄ້າ :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(572, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ລະຫັດບາໂຄດ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ວັນທີເດືອນປີຜະລິດ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ຊື່ສິນຄ້າ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ລະຫັດສິນຄ້າ :"
        '
        'txttelno
        '
        Me.txttelno.Enabled = False
        Me.txttelno.Location = New System.Drawing.Point(690, 31)
        Me.txttelno.Margin = New System.Windows.Forms.Padding(4)
        Me.txttelno.Name = "txttelno"
        Me.txttelno.Size = New System.Drawing.Size(311, 35)
        Me.txttelno.TabIndex = 4
        Me.txttelno.Text = "1234567890"
        '
        'txtlastname
        '
        Me.txtlastname.Enabled = False
        Me.txtlastname.Location = New System.Drawing.Point(690, 78)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(311, 35)
        Me.txtlastname.TabIndex = 3
        Me.txtlastname.Text = "ເມັດ"
        '
        'txtfirstname
        '
        Me.txtfirstname.Enabled = False
        Me.txtfirstname.Location = New System.Drawing.Point(163, 75)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(311, 35)
        Me.txtfirstname.TabIndex = 1
        Me.txtfirstname.Text = "Paracetamal 500mg"
        '
        'txtcustid
        '
        Me.txtcustid.BackColor = System.Drawing.Color.LightGray
        Me.txtcustid.Enabled = False
        Me.txtcustid.Location = New System.Drawing.Point(163, 31)
        Me.txtcustid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcustid.Multiline = True
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.Size = New System.Drawing.Size(187, 36)
        Me.txtcustid.TabIndex = 0
        Me.txtcustid.Text = "P000001"
        Me.txtcustid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PRO_ID
        '
        Me.PRO_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PRO_ID.HeaderText = "ລະຫັດສິນຄ້າ"
        Me.PRO_ID.Name = "PRO_ID"
        Me.PRO_ID.Width = 114
        '
        'BARCODE
        '
        Me.BARCODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.BARCODE.HeaderText = "ລະຫັດບາຣ໌ໂຄ້ດ"
        Me.BARCODE.Name = "BARCODE"
        Me.BARCODE.Width = 133
        '
        'PRODUCT_NAME
        '
        Me.PRODUCT_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PRODUCT_NAME.HeaderText = "ຊື່ສິນຄ້າ"
        Me.PRODUCT_NAME.Name = "PRODUCT_NAME"
        Me.PRODUCT_NAME.Width = 83
        '
        'PRODUCT_TYPE
        '
        Me.PRODUCT_TYPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PRODUCT_TYPE.HeaderText = "ປະເພດສິນຄ້າ"
        Me.PRODUCT_TYPE.Name = "PRODUCT_TYPE"
        Me.PRODUCT_TYPE.Width = 118
        '
        'DATE_PRODUCT
        '
        Me.DATE_PRODUCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DATE_PRODUCT.HeaderText = "ວັນທີ່ເດືອນປີທີ່ຜະລິດ"
        Me.DATE_PRODUCT.Name = "DATE_PRODUCT"
        Me.DATE_PRODUCT.Width = 162
        '
        'DATE_EXPIRE
        '
        Me.DATE_EXPIRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DATE_EXPIRE.HeaderText = "ວັນໝົດອາຍຸ"
        Me.DATE_EXPIRE.Name = "DATE_EXPIRE"
        Me.DATE_EXPIRE.Width = 108
        '
        'ProductInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 617)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ProductInfoForm"
        Me.Text = "ProductInfoForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttelno As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtcustid As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents PRO_ID As DataGridViewTextBoxColumn
    Friend WithEvents BARCODE As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCT_NAME As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCT_TYPE As DataGridViewTextBoxColumn
    Friend WithEvents DATE_PRODUCT As DataGridViewTextBoxColumn
    Friend WithEvents DATE_EXPIRE As DataGridViewTextBoxColumn
End Class
