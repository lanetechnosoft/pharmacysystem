<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CUST_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUST_FIRST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUST_LAST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1105, 636)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ສ່ວນລວມ"
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
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(939, 106)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ຈັດການຂໍ້ມູນ"
        '
        'btnExit
        '
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(765, 27)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnShow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.GroupBox2.Controls.Add(Me.txtlastname)
        Me.GroupBox2.Controls.Add(Me.txtaddress)
        Me.GroupBox2.Controls.Add(Me.txtfirstname)
        Me.GroupBox2.Controls.Add(Me.txtcustid)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 30)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1089, 178)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ຂໍ້ມູນລູກຄ້າ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(598, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ນາມສະກຸນ :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(629, 121)
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
        Me.Label2.Location = New System.Drawing.Point(112, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ຊື່ລູກຄ້າ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ລະຫັດລູກຄ້າ :"
        '
        'txttelno
        '
        Me.txttelno.Enabled = False
        Me.txttelno.Location = New System.Drawing.Point(695, 121)
        Me.txttelno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttelno.Name = "txttelno"
        Me.txttelno.Size = New System.Drawing.Size(311, 35)
        Me.txttelno.TabIndex = 4
        Me.txttelno.Text = "20XXXXXXXX"
        '
        'txtlastname
        '
        Me.txtlastname.Enabled = False
        Me.txtlastname.Location = New System.Drawing.Point(695, 78)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(311, 35)
        Me.txtlastname.TabIndex = 3
        Me.txtlastname.Text = "DEMO"
        '
        'txtaddress
        '
        Me.txtaddress.Enabled = False
        Me.txtaddress.Location = New System.Drawing.Point(190, 118)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(311, 35)
        Me.txtaddress.TabIndex = 2
        Me.txtaddress.Text = "ນະຄອນຫຼວງ"
        '
        'txtfirstname
        '
        Me.txtfirstname.Enabled = False
        Me.txtfirstname.Location = New System.Drawing.Point(190, 75)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(311, 35)
        Me.txtfirstname.TabIndex = 1
        Me.txtfirstname.Text = "TEST"
        '
        'txtcustid
        '
        Me.txtcustid.BackColor = System.Drawing.Color.LightGray
        Me.txtcustid.Enabled = False
        Me.txtcustid.Location = New System.Drawing.Point(190, 31)
        Me.txtcustid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcustid.Multiline = True
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.Size = New System.Drawing.Size(187, 36)
        Me.txtcustid.TabIndex = 0
        Me.txtcustid.Text = "CM000001"
        Me.txtcustid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUST_NO, Me.CUST_FIRST_NAME, Me.CUST_LAST_NAME, Me.ADDRESS, Me.PHONE})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(8, 23)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1074, 245)
        Me.DataGridView1.TabIndex = 0
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
        'CUST_NO
        '
        Me.CUST_NO.HeaderText = "ລະຫັດລູກຄ້າ"
        Me.CUST_NO.Name = "CUST_NO"
        '
        'CUST_FIRST_NAME
        '
        Me.CUST_FIRST_NAME.HeaderText = "ຊື່ລູກຄ້າ"
        Me.CUST_FIRST_NAME.Name = "CUST_FIRST_NAME"
        '
        'CUST_LAST_NAME
        '
        Me.CUST_LAST_NAME.HeaderText = "ນາມສະກຸນ"
        Me.CUST_LAST_NAME.Name = "CUST_LAST_NAME"
        '
        'ADDRESS
        '
        Me.ADDRESS.HeaderText = "ທີ່ຢູ່"
        Me.ADDRESS.Name = "ADDRESS"
        '
        'PHONE
        '
        Me.PHONE.HeaderText = "ເບີໂທຕິດຕໍ່"
        Me.PHONE.Name = "PHONE"
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 632)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Phetsarath OT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CustomerForm"
        Me.Text = "ຟອມຂໍ້ມູນລູກຄ້າ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtcustid As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CUST_NO As DataGridViewTextBoxColumn
    Friend WithEvents CUST_FIRST_NAME As DataGridViewTextBoxColumn
    Friend WithEvents CUST_LAST_NAME As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESS As DataGridViewTextBoxColumn
    Friend WithEvents PHONE As DataGridViewTextBoxColumn
End Class
