<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComSubp = New System.Windows.Forms.ComboBox()
        Me.pdlist = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtproid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtlPDname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtsuppl_nm = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnaddcode = New System.Windows.Forms.Button()
        Me.btbilladd = New System.Windows.Forms.Button()
        Me.txtorderdate = New System.Windows.Forms.DateTimePicker()
        Me.txtorderid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewBill = New System.Windows.Forms.DataGridView()
        Me.DataGridViewList = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStaffId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ORDER_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUPPLIER_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDER_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridViewBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.ToolStrip2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1048, 652)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ສ່ວນລວມ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Location = New System.Drawing.Point(216, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 92)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ຈັດການຂໍ້ມູນ"
        '
        'btnPrint
        '
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(429, 28)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(94, 47)
        Me.btnPrint.TabIndex = 43
        Me.btnPrint.Text = "ພິມ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(538, 29)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 47)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "ອອກ"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(326, 28)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 47)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "ຍົກເລີກ"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(225, 28)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 47)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "ລົບ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(13, 29)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 47)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "ບັນທຶກ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(119, 28)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(91, 47)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "ແກ້ໄຂ"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.ComSubp)
        Me.Panel2.Controls.Add(Me.pdlist)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtquantity)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtproid)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtlPDname)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(6, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(980, 91)
        Me.Panel2.TabIndex = 84
        '
        'ComSubp
        '
        Me.ComSubp.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComSubp.FormattingEnabled = True
        Me.ComSubp.Items.AddRange(New Object() {"ໂຮງານຜະລິດຢາເລກ 1", "ໂຮງານຜະລິດຢາເລກ 2", "ໂຮງານຜະລິດຢາເລກ 3", "ໂຮງານຜະລິດຢາເລກ 9"})
        Me.ComSubp.Location = New System.Drawing.Point(163, 4)
        Me.ComSubp.Name = "ComSubp"
        Me.ComSubp.Size = New System.Drawing.Size(177, 29)
        Me.ComSubp.TabIndex = 9
        Me.ComSubp.Text = "ໂຮງານຜະລິດຢາເລກ 1"
        '
        'pdlist
        '
        Me.pdlist.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdlist.Image = CType(resources.GetObject("pdlist.Image"), System.Drawing.Image)
        Me.pdlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pdlist.Location = New System.Drawing.Point(345, 39)
        Me.pdlist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pdlist.Name = "pdlist"
        Me.pdlist.Size = New System.Drawing.Size(35, 31)
        Me.pdlist.TabIndex = 48
        Me.pdlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.pdlist.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ລະຫັດສິນຄ້າ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtquantity
        '
        Me.txtquantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtquantity.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(869, 40)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(93, 30)
        Me.txtquantity.TabIndex = 5
        Me.txtquantity.Text = "10"
        Me.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(880, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ຈຳນວນ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtproid
        '
        Me.txtproid.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtproid.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproid.Location = New System.Drawing.Point(163, 40)
        Me.txtproid.Name = "txtproid"
        Me.txtproid.ReadOnly = True
        Me.txtproid.Size = New System.Drawing.Size(176, 30)
        Me.txtproid.TabIndex = 16
        Me.txtproid.Text = "PD00000001"
        Me.txtproid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ລະຫັດຜູ້ສະໜອງ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtlPDname
        '
        Me.txtlPDname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtlPDname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtlPDname.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlPDname.Location = New System.Drawing.Point(386, 41)
        Me.txtlPDname.Name = "txtlPDname"
        Me.txtlPDname.ReadOnly = True
        Me.txtlPDname.Size = New System.Drawing.Size(202, 30)
        Me.txtlPDname.TabIndex = 14
        Me.txtlPDname.Text = "Paracetamal 500mg"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(431, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "ຊື່ສິນຄ້າ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.ToolStripSeparator1, Me.txtsuppl_nm, Me.ToolStripSeparator3})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 624)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1042, 25)
        Me.ToolStrip2.TabIndex = 66
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'txtsuppl_nm
        '
        Me.txtsuppl_nm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtsuppl_nm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtsuppl_nm.Name = "txtsuppl_nm"
        Me.txtsuppl_nm.ReadOnly = True
        Me.txtsuppl_nm.Size = New System.Drawing.Size(50, 25)
        Me.txtsuppl_nm.Text = "S0001"
        Me.txtsuppl_nm.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox3.Controls.Add(Me.txtStaffId)
        Me.GroupBox3.Controls.Add(Me.btnaddcode)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.btbilladd)
        Me.GroupBox3.Controls.Add(Me.txtorderdate)
        Me.GroupBox3.Controls.Add(Me.txtorderid)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(980, 65)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ການສັ່ງຊື້"
        '
        'btnaddcode
        '
        Me.btnaddcode.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.btnaddcode.Location = New System.Drawing.Point(386, 25)
        Me.btnaddcode.Name = "btnaddcode"
        Me.btnaddcode.Size = New System.Drawing.Size(89, 29)
        Me.btnaddcode.TabIndex = 79
        Me.btnaddcode.Text = "ເພີ່ມລະຫັດ"
        Me.btnaddcode.UseVisualStyleBackColor = True
        '
        'btbilladd
        '
        Me.btbilladd.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbilladd.Location = New System.Drawing.Point(344, 26)
        Me.btbilladd.Name = "btbilladd"
        Me.btbilladd.Size = New System.Drawing.Size(36, 28)
        Me.btbilladd.TabIndex = 17
        Me.btbilladd.Text = "+"
        Me.btbilladd.UseVisualStyleBackColor = True
        '
        'txtorderdate
        '
        Me.txtorderdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtorderdate.CustomFormat = "yyyy-MM-dd"
        Me.txtorderdate.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorderdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtorderdate.Location = New System.Drawing.Point(628, 31)
        Me.txtorderdate.Name = "txtorderdate"
        Me.txtorderdate.Size = New System.Drawing.Size(120, 30)
        Me.txtorderdate.TabIndex = 13
        '
        'txtorderid
        '
        Me.txtorderid.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtorderid.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorderid.Location = New System.Drawing.Point(163, 26)
        Me.txtorderid.Name = "txtorderid"
        Me.txtorderid.ReadOnly = True
        Me.txtorderid.Size = New System.Drawing.Size(176, 30)
        Me.txtorderid.TabIndex = 12
        Me.txtorderid.Text = "ORDERXXXXXX"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(540, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ວັນທີສັ່ງຊື້ :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ເລກທີໃບສັ່ງຊື້  :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DataGridViewBill)
        Me.GroupBox4.Controls.Add(Me.DataGridViewList)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 275)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1048, 346)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ສ່ວນສະແດງ"
        '
        'DataGridViewBill
        '
        Me.DataGridViewBill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ORDER_DATE, Me.ORDER_ID})
        Me.DataGridViewBill.Location = New System.Drawing.Point(45, 32)
        Me.DataGridViewBill.Name = "DataGridViewBill"
        Me.DataGridViewBill.Size = New System.Drawing.Size(267, 290)
        Me.DataGridViewBill.TabIndex = 2
        '
        'DataGridViewList
        '
        Me.DataGridViewList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SUPPLIER_NAME, Me.PRODUCT_ID, Me.PRODUCT_NAME, Me.UNIT, Me.QUANTITY, Me.ORDER_BY})
        Me.DataGridViewList.Location = New System.Drawing.Point(355, 32)
        Me.DataGridViewList.Name = "DataGridViewList"
        Me.DataGridViewList.Size = New System.Drawing.Size(663, 291)
        Me.DataGridViewList.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(768, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 23)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "ຫົວໜ່ວຍ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtStaffId
        '
        Me.txtStaffId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStaffId.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffId.Location = New System.Drawing.Point(842, 31)
        Me.txtStaffId.Name = "txtStaffId"
        Me.txtStaffId.Size = New System.Drawing.Size(120, 30)
        Me.txtStaffId.TabIndex = 52
        Me.txtStaffId.Text = "ID00001"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(754, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 23)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "ສັ່ງຊື້ໂດຍ :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ເມັດ", "ແຜງ", "ຊອງ", "ແກ້ວ", "ກ່ອງ"})
        Me.ComboBox1.Location = New System.Drawing.Point(761, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(102, 29)
        Me.ComboBox1.TabIndex = 51
        Me.ComboBox1.Text = "ແຜງ"
        '
        'ORDER_DATE
        '
        Me.ORDER_DATE.HeaderText = "ວັນທີ່ສັ່ງຊື້"
        Me.ORDER_DATE.Name = "ORDER_DATE"
        '
        'ORDER_ID
        '
        Me.ORDER_ID.HeaderText = "ເລກບິນສັ່ງຊື້"
        Me.ORDER_ID.Name = "ORDER_ID"
        '
        'SUPPLIER_NAME
        '
        Me.SUPPLIER_NAME.HeaderText = "ຜູ້ສະໜອງ"
        Me.SUPPLIER_NAME.Name = "SUPPLIER_NAME"
        '
        'PRODUCT_ID
        '
        Me.PRODUCT_ID.HeaderText = "ລະຫັດສິນຄ້າ"
        Me.PRODUCT_ID.Name = "PRODUCT_ID"
        '
        'PRODUCT_NAME
        '
        Me.PRODUCT_NAME.HeaderText = "ຊື່ສິນຄ້າ"
        Me.PRODUCT_NAME.Name = "PRODUCT_NAME"
        '
        'UNIT
        '
        Me.UNIT.HeaderText = "ຫົວໜ່ວຍ"
        Me.UNIT.Name = "UNIT"
        '
        'QUANTITY
        '
        Me.QUANTITY.HeaderText = "ຈຳນວນ"
        Me.QUANTITY.Name = "QUANTITY"
        '
        'ORDER_BY
        '
        Me.ORDER_BY.HeaderText = "ຜູ້ສັ່ງ"
        Me.ORDER_BY.Name = "ORDER_BY"
        '
        'PurchaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 648)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PurchaseForm"
        Me.Text = "ຟອມສັ່ງຊື້"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridViewBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComSubp As ComboBox
    Friend WithEvents pdlist As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtproid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtlPDname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents txtsuppl_nm As ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnaddcode As Button
    Friend WithEvents btbilladd As Button
    Friend WithEvents txtorderdate As DateTimePicker
    Friend WithEvents txtorderid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridViewBill As DataGridView
    Friend WithEvents DataGridViewList As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStaffId As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ORDER_DATE As DataGridViewTextBoxColumn
    Friend WithEvents ORDER_ID As DataGridViewTextBoxColumn
    Friend WithEvents SUPPLIER_NAME As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCT_ID As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCT_NAME As DataGridViewTextBoxColumn
    Friend WithEvents UNIT As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITY As DataGridViewTextBoxColumn
    Friend WithEvents ORDER_BY As DataGridViewTextBoxColumn
End Class
