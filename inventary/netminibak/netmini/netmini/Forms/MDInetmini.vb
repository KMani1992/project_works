Imports System.Windows.Forms

Public Class MDInetmini
    Private Sub ProductMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductMasterToolStripMenuItem.Click
        Dim frm As New Frmproduct
        With frm
            .Owner = Me
            .MdiParent = Me
            .Size = Screen.PrimaryScreen.WorkingArea.Size
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub HeadAccToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeadAccToolStripMenuItem.Click
        Dim frm As New FrmHeadAcc
        With frm
            .Owner = Me
            .MdiParent = Me
            .Size = Screen.PrimaryScreen.WorkingArea.Size
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub MDInetmini_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModGen.main()
        LoginForm.ShowDialog(Me)
    End Sub

    Private Sub PurcheseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurcheseToolStripMenuItem.Click
        Dim frm As New FrmPurchese
        With frm
            .Owner = Me
            .MdiParent = Me
            .Size = Screen.PrimaryScreen.WorkingArea.Size
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        Dim frm As New FrmSales
        With frm
            .Owner = Me
            .MdiParent = Me
            .Size = Screen.PrimaryScreen.WorkingArea.Size
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub OperatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperatorToolStripMenuItem.Click
        Dim frm As New FrmOperator
        With frm
            .Owner = Me
            .MdiParent = Me
            .Size = Screen.PrimaryScreen.WorkingArea.Size
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

   
    Private Sub ExitToolStripMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenu.Click
        If MsgBox("Are You Sure Want To Exit", vbQuestion + vbYesNo, Me.Text) = vbYes Then
            End
        End If
    End Sub

    Private Sub TransactionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionReportToolStripMenuItem.Click
        Dim frm As New FrmTransRpt
        With frm
            .Owner = Me
            .MdiParent = Me
            .Size = Screen.PrimaryScreen.WorkingArea.Size
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
End Class
