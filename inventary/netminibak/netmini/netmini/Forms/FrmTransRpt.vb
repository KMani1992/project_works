Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmTransRpt
    Private Sub FrmTransRpt_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        DTP_TransDtFrom.Value = Now
        DTP_TransDtTo.Value = Now
        DTP_TransDtFrom.Focus()
    End Sub

    Private Sub FrmTransRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conopen()
            strsql = "SELECT PRO_NAME + '@' + pro_code as pro_name FROM Product order by PRO_NAME"
            datareader = readrecordset(strsql)
            With CmbProName
                .Items.Clear()
                .Items.Add("All")
                Do While datareader.Read
                    .Items.Add(datareader.Item("pro_name"))
                Loop
                If .Items.Count > 0 Then .Text = .Items(0)
            End With
            datareader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Gsmt.dialogcapt)
        Finally
            conclose()
            datareader.Close()
        End Try
        Me.ReportViewer.RefreshReport()
    End Sub

    Private Sub FrmTransRpt_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With TabTransRpt
            .Location = New Point(5, 5)
            .Size = New Size(Me.Width - 15, Me.Height)
        End With
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub ReportViewer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ReportViewer.KeyDown
        If e.KeyCode = Keys.Escape Then
            TabTransRpt.TabIndex = 0
            BtnClose.Focus()
        End If
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        Try
            'Dim crrpt As New ReportDocument
            'crrpt.Load(Application.StartupPath & "\TransRpt.rpt")
            
            ReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Gsmt.dialogcapt)
        End Try
    End Sub
End Class