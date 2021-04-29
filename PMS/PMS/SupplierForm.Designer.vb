<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttelno = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtsupid = New System.Windows.Forms.TextBox()
        Me.CUST_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUST_FIRST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUST_LAST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1119, 623)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUST_NO, Me.CUST_FIRST_NAME, Me.PHONE, Me.ADDRESS, Me.CUST_LAST_NAME})
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
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txttelno)
        Me.GroupBox2.Controls.Add(Me.txtemail)
        Me.GroupBox2.Controls.Add(Me.txtaddress)
        Me.GroupBox2.Controls.Add(Me.txtfirstname)
        Me.GroupBox2.Controls.Add(Me.txtsupid)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 30)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1089, 178)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ຂໍ້ມູນຜູ້ສະໜອງ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(569, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ອີເມວ :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(600, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ເບີໂທ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ທີ່ຢູ່ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ຊື່ຜູ້ສະໜອງ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ລະຫັດຜູ້ສະໜອງ :"
        '
        'txttelno
        '
        Me.txttelno.Enabled = False
        Me.txttelno.Location = New System.Drawing.Point(666, 75)
        Me.txttelno.Margin = New System.Windows.Forms.Padding(4)
        Me.txttelno.Name = "txttelno"
        Me.txttelno.Size = New System.Drawing.Size(311, 35)
        Me.txttelno.TabIndex = 4
        Me.txttelno.Text = "20XXXXXXXX"
        '
        'txtemail
        '
        Me.txtemail.Enabled = False
        Me.txtemail.Location = New System.Drawing.Point(666, 121)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(311, 35)
        Me.txtemail.TabIndex = 3
        Me.txtemail.Text = "pharmacy@xxxx.com"
        '
        'txtaddress
        '
        Me.txtaddress.Enabled = False
        Me.txtaddress.Location = New System.Drawing.Point(190, 118)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(311, 35)
        Me.txtaddress.TabIndex = 2
        Me.txtaddress.Text = "ນະຄອນຫຼວງ"
        '
        'txtfirstname
        '
        Me.txtfirstname.Enabled = False
        Me.txtfirstname.Location = New System.Drawing.Point(190, 75)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(311, 35)
        Me.txtfirstname.TabIndex = 1
        Me.txtfirstname.Text = "ໂຮງງານຜະລິດຢາ"
        '
        'txtsupid
        '
        Me.txtsupid.BackColor = System.Drawing.Color.LightGray
        Me.txtsupid.Enabled = False
        Me.txtsupid.Location = New System.Drawing.Point(190, 31)
        Me.txtsupid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsupid.Multiline = True
        Me.txtsupid.Name = "txtsupid"
        Me.txtsupid.Size = New System.Drawing.Size(187, 36)
        Me.txtsupid.TabIndex = 0
        Me.txtsupid.Text = "SP000001"
        Me.txtsupid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CUST_NO
        '
        Me.CUST_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CUST_NO.HeaderText = "ລະຫັດຜູ້ສະໜອງ"
        Me.CUST_NO.Name = "CUST_NO"
        Me.CUST_NO.Width = 138
        '
        'CUST_FIRST_NAME
        '
        Me.CUST_FIRST_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CUST_FIRST_NAME.HeaderText = "ຊື່ຜູ້ສະໜອງ"
        Me.CUST_FIRST_NAME.Name = "CUST_FIRST_NAME"
        Me.CUST_FIRST_NAME.Width = 107
        '
        'PHONE
        '
        Me.PHONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PHONE.HeaderText = "ເບີໂທຕິດຕໍ່"
        Me.PHONE.Name = "PHONE"
        Me.PHONE.Width = 101
        '
        'ADDRESS
        '
        Me.ADDRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ADDRESS.HeaderText = "ທີ່ຢູ່"
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.Width = 56
        '
        'CUST_LAST_NAME
        '
        Me.CUST_LAST_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CUST_LAST_NAME.HeaderText = "ອີເມວ"
        Me.CUST_LAST_NAME.Name = "CUST_LAST_NAME"
        Me.CUST_LAST_NAME.Width = 71
        '
        'SupplierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 630)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SupplierForm"
        Me.Text = "SupplierForm"
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
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtsupid As TextBox
    Friend WithEvents CUST_NO As DataGridViewTextBoxColumn
    Friend WithEvents CUST_FIRST_NAME As DataGridViewTextBoxColumn
    Friend WithEvents PHONE As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESS As DataGridViewTextBoxColumn
    Friend WithEvents CUST_LAST_NAME As DataGridViewTextBoxColumn
End Class
