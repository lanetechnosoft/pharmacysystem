Public Class MainForm
    Private Sub MainForm(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        e.Cancel = True
        LoginForm.Show()
    End Sub

    Private Sub SubMain1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubMain1ToolStripMenuItem.Click
        CustomerForm.MdiParent = Me
        CustomerForm.WindowState = FormWindowState.Maximized
        CustomerForm.Show()
    End Sub

    Private Sub SubMain2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubMain2ToolStripMenuItem.Click
        EmployeeForm.MdiParent = Me
        EmployeeForm.WindowState = FormWindowState.Maximized
        EmployeeForm.Show()
    End Sub

    Private Sub ຂມນຜສະໜອງToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຂມນຜສະໜອງToolStripMenuItem.Click
        SupplierForm.MdiParent = Me
        SupplierForm.WindowState = FormWindowState.Maximized
        SupplierForm.Show()
    End Sub

    Private Sub ຂມນສນຄາToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຂມນສນຄາToolStripMenuItem.Click
        ProductInfoForm.MdiParent = Me
        ProductInfoForm.WindowState = FormWindowState.Maximized
        ProductInfoForm.Show()
    End Sub

    Private Sub ມນປະເພດສນຄາToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ມນປະເພດສນຄາToolStripMenuItem.Click
        ProductCategoryForm.MdiParent = Me
        ProductCategoryForm.WindowState = FormWindowState.Maximized
        ProductCategoryForm.Show()
    End Sub

    Private Sub ມນຫວຫນວຍToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ມນຫວຫນວຍToolStripMenuItem.Click
        UnitForm.MdiParent = Me
        UnitForm.WindowState = FormWindowState.Maximized
        UnitForm.Show()
    End Sub

    Private Sub ການຂາຍToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ການຂາຍToolStripMenuItem.Click
        SaleForm.MdiParent = Me
        SaleForm.WindowState = FormWindowState.Maximized
        SaleForm.Show()
    End Sub

    Private Sub ການສງຊToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ການສງຊToolStripMenuItem.Click
        PurchaseForm.MdiParent = Me
        PurchaseForm.WindowState = FormWindowState.Maximized
        PurchaseForm.Show()
    End Sub

    Private Sub ການນາເຂາToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ການນາເຂາToolStripMenuItem.Click
        ImportProductForm.MdiParent = Me
        ImportProductForm.WindowState = FormWindowState.Maximized
        ImportProductForm.Show()
    End Sub

    Private Sub ຄນຫາToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຄນຫາToolStripMenuItem.Click
        SearchInfoForm.MdiParent = Me
        SearchInfoForm.Show()
    End Sub

    Private Sub ລາຍງານລາຍການຂາຍToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ລາຍງານລາຍການຂາຍToolStripMenuItem.Click
        SaleReportForm.MdiParent = Me
        SaleReportForm.Show()
    End Sub
End Class