<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportProductForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportProductForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.totalPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AllInvoice_View = New System.Windows.Forms.Button()
        Me.btreprtinstck = New System.Windows.Forms.Button()
        Me.btrecieve = New System.Windows.Forms.Button()
        Me.btexit = New System.Windows.Forms.Button()
        Me.btclear = New System.Windows.Forms.Button()
        Me.Bdelete = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewBill = New System.Windows.Forms.DataGridView()
        Me.DataGridViewList = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ProductList = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.btadd = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComSupp = New System.Windows.Forms.ComboBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmout = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btinvoiceOrderadd = New System.Windows.Forms.Button()
        Me.txtInv_OrdID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridViewBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.totalPrice)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1184, 571)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ສ່ວນລວມ"
        '
        'totalPrice
        '
        Me.totalPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalPrice.Font = New System.Drawing.Font("Saysettha OT", 9.75!)
        Me.totalPrice.Location = New System.Drawing.Point(961, 499)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(176, 30)
        Me.totalPrice.TabIndex = 89
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Saysettha OT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(822, 505)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 24)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "ລວມມູນຄ່າທັ່ງໝົດ:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.AllInvoice_View)
        Me.GroupBox2.Controls.Add(Me.btreprtinstck)
        Me.GroupBox2.Controls.Add(Me.btrecieve)
        Me.GroupBox2.Controls.Add(Me.btexit)
        Me.GroupBox2.Controls.Add(Me.btclear)
        Me.GroupBox2.Controls.Add(Me.Bdelete)
        Me.GroupBox2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 484)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(729, 79)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ຈັດການຂໍ້ມູນ"
        '
        'AllInvoice_View
        '
        Me.AllInvoice_View.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AllInvoice_View.AutoSize = True
        Me.AllInvoice_View.BackColor = System.Drawing.Color.Transparent
        Me.AllInvoice_View.Font = New System.Drawing.Font("Saysettha OT", 9.75!)
        Me.AllInvoice_View.Location = New System.Drawing.Point(493, 30)
        Me.AllInvoice_View.Name = "AllInvoice_View"
        Me.AllInvoice_View.Size = New System.Drawing.Size(126, 36)
        Me.AllInvoice_View.TabIndex = 86
        Me.AllInvoice_View.Text = "ເບີງໃບນຳສົ່ງທັ່ງໝົດ"
        Me.AllInvoice_View.UseVisualStyleBackColor = False
        '
        'btreprtinstck
        '
        Me.btreprtinstck.Location = New System.Drawing.Point(323, 30)
        Me.btreprtinstck.Name = "btreprtinstck"
        Me.btreprtinstck.Size = New System.Drawing.Size(153, 35)
        Me.btreprtinstck.TabIndex = 13
        Me.btreprtinstck.Text = "ລາຍງານສິນຄ້າເຂົ້າຮ້ານ"
        Me.btreprtinstck.UseVisualStyleBackColor = True
        '
        'btrecieve
        '
        Me.btrecieve.Location = New System.Drawing.Point(198, 29)
        Me.btrecieve.Name = "btrecieve"
        Me.btrecieve.Size = New System.Drawing.Size(119, 35)
        Me.btrecieve.TabIndex = 12
        Me.btrecieve.Text = "ຮັບສິນຄ້າເຂົ້າສາງ"
        Me.btrecieve.UseVisualStyleBackColor = True
        '
        'btexit
        '
        Me.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btexit.Location = New System.Drawing.Point(637, 30)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(73, 36)
        Me.btexit.TabIndex = 11
        Me.btexit.Text = "ອອກ"
        Me.btexit.UseVisualStyleBackColor = True
        '
        'btclear
        '
        Me.btclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btclear.Location = New System.Drawing.Point(96, 29)
        Me.btclear.Name = "btclear"
        Me.btclear.Size = New System.Drawing.Size(73, 36)
        Me.btclear.TabIndex = 10
        Me.btclear.Text = "ຍົກເລີກ"
        Me.btclear.UseVisualStyleBackColor = True
        '
        'Bdelete
        '
        Me.Bdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bdelete.Location = New System.Drawing.Point(20, 29)
        Me.Bdelete.Name = "Bdelete"
        Me.Bdelete.Size = New System.Drawing.Size(69, 36)
        Me.Bdelete.TabIndex = 9
        Me.Bdelete.Text = "ລົບ"
        Me.Bdelete.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DataGridViewBill)
        Me.GroupBox4.Controls.Add(Me.DataGridViewList)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 240)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1168, 238)
        Me.GroupBox4.TabIndex = 86
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ສ່ວນສະແດງ"
        '
        'DataGridViewBill
        '
        Me.DataGridViewBill.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBill.Location = New System.Drawing.Point(18, 21)
        Me.DataGridViewBill.Name = "DataGridViewBill"
        Me.DataGridViewBill.Size = New System.Drawing.Size(271, 211)
        Me.DataGridViewBill.TabIndex = 4
        '
        'DataGridViewList
        '
        Me.DataGridViewList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewList.Location = New System.Drawing.Point(305, 21)
        Me.DataGridViewList.Name = "DataGridViewList"
        Me.DataGridViewList.Size = New System.Drawing.Size(857, 211)
        Me.DataGridViewList.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.ProductList)
        Me.Panel2.Controls.Add(Me.btedit)
        Me.Panel2.Controls.Add(Me.btadd)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.ComSupp)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtAmout)
        Me.Panel2.Controls.Add(Me.txtProductID)
        Me.Panel2.Controls.Add(Me.txtProductName)
        Me.Panel2.Controls.Add(Me.txtprice)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtquantity)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(8, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1163, 113)
        Me.Panel2.TabIndex = 85
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(866, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 25)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "ວັນທີ່ໜົດອາຍຸ :"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(875, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 25)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "ວັນທີ່ຜະລິດ :"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(520, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 21)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "ຫົວໜ່ວຍ"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(967, 43)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(162, 35)
        Me.DateTimePicker2.TabIndex = 28
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(967, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(162, 35)
        Me.DateTimePicker1.TabIndex = 28
        '
        'ProductList
        '
        Me.ProductList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ProductList.Image = CType(resources.GetObject("ProductList.Image"), System.Drawing.Image)
        Me.ProductList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductList.Location = New System.Drawing.Point(535, 6)
        Me.ProductList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(33, 33)
        Me.ProductList.TabIndex = 109
        Me.ProductList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ProductList.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btedit.Location = New System.Drawing.Point(761, 62)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(80, 42)
        Me.btedit.TabIndex = 108
        Me.btedit.Text = "ແກ້ໄຂ"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'btadd
        '
        Me.btadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btadd.Location = New System.Drawing.Point(648, 61)
        Me.btadd.Name = "btadd"
        Me.btadd.Size = New System.Drawing.Size(80, 42)
        Me.btadd.TabIndex = 107
        Me.btadd.Text = "ເພີ່ມ"
        Me.btadd.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(578, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 26)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "ລະຫັດບາໂຄດ :"
        '
        'ComSupp
        '
        Me.ComSupp.DisplayMember = "Prov_Name"
        Me.ComSupp.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComSupp.FormattingEnabled = True
        Me.ComSupp.Location = New System.Drawing.Point(94, 5)
        Me.ComSupp.Name = "ComSupp"
        Me.ComSupp.Size = New System.Drawing.Size(169, 32)
        Me.ComSupp.TabIndex = 17
        Me.ComSupp.ValueMember = "Prov_Name"
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Font = New System.Drawing.Font("Saysettha OT", 12.0!)
        Me.txtUsername.Location = New System.Drawing.Point(668, 6)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(190, 35)
        Me.txtUsername.TabIndex = 105
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(269, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 26)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "ລະຫັດສິນຄ້າ :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ຊື່ຜູ້ສະໜອງ :"
        '
        'txtAmout
        '
        Me.txtAmout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmout.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmout.Location = New System.Drawing.Point(513, 68)
        Me.txtAmout.Name = "txtAmout"
        Me.txtAmout.Size = New System.Drawing.Size(77, 35)
        Me.txtAmout.TabIndex = 13
        '
        'txtProductID
        '
        Me.txtProductID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductID.Location = New System.Drawing.Point(263, 68)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.ReadOnly = True
        Me.txtProductID.Size = New System.Drawing.Size(162, 35)
        Me.txtProductID.TabIndex = 26
        '
        'txtProductName
        '
        Me.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProductName.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(14, 68)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(230, 35)
        Me.txtProductName.TabIndex = 22
        '
        'txtprice
        '
        Me.txtprice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtprice.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(366, 5)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(162, 35)
        Me.txtprice.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 26)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ຊື່ສິນຄ້າ"
        '
        'txtquantity
        '
        Me.txtquantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtquantity.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(430, 68)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(77, 35)
        Me.txtquantity.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(317, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ລາຄາ"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(437, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ຈຳນວນ"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.btinvoiceOrderadd)
        Me.GroupBox3.Controls.Add(Me.txtInv_OrdID)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DTP1)
        Me.GroupBox3.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 25)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(1164, 90)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ນຳເຂົ້າສິນຄ້າ"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(399, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(162, 35)
        Me.TextBox1.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(296, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 26)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "ລະຫັດຮັບສິນຄ້າ :"
        '
        'btinvoiceOrderadd
        '
        Me.btinvoiceOrderadd.Font = New System.Drawing.Font("Saysettha OT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btinvoiceOrderadd.Location = New System.Drawing.Point(567, 26)
        Me.btinvoiceOrderadd.Name = "btinvoiceOrderadd"
        Me.btinvoiceOrderadd.Size = New System.Drawing.Size(38, 37)
        Me.btinvoiceOrderadd.TabIndex = 25
        Me.btinvoiceOrderadd.Text = "+"
        Me.btinvoiceOrderadd.UseVisualStyleBackColor = True
        '
        'txtInv_OrdID
        '
        Me.txtInv_OrdID.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInv_OrdID.Location = New System.Drawing.Point(128, 26)
        Me.txtInv_OrdID.Name = "txtInv_OrdID"
        Me.txtInv_OrdID.ReadOnly = True
        Me.txtInv_OrdID.Size = New System.Drawing.Size(162, 35)
        Me.txtInv_OrdID.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ເລກທີ່ໃບຮັບສິນຄ້າ :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Saysettha OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(619, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "ວັນທີຮັບສິນຄ້າ :"
        '
        'DTP1
        '
        Me.DTP1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTP1.CustomFormat = "yyyy-MM-dd"
        Me.DTP1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(720, 28)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(162, 35)
        Me.DTP1.TabIndex = 21
        '
        'ImportProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 587)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ImportProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ຟອມນຳເຂົ້າສິນຄ້າ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridViewBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btinvoiceOrderadd As Button
    Friend WithEvents txtInv_OrdID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridViewBill As DataGridView
    Friend WithEvents DataGridViewList As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProductList As Button
    Friend WithEvents btedit As Button
    Friend WithEvents btadd As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents ComSupp As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmout As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents totalPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AllInvoice_View As Button
    Friend WithEvents btreprtinstck As Button
    Friend WithEvents btrecieve As Button
    Friend WithEvents btexit As Button
    Friend WithEvents btclear As Button
    Friend WithEvents Bdelete As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
