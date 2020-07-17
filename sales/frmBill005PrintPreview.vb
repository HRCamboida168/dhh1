Public Class frmBill005PrintPreview

    Dim dbHpr As New db_helper

    Private Sub frmBill005PrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_PrintingBegin(sender As Object, e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer1.PrintingBegin
        With frm_sale_inv
            Dim inv_num As String
            inv_num = .dgInvMster.SelectedRows(0).Cells(0).Value

            'save history
            dbHpr.ExecProc("ins_tswa_trxn_histories", "pi_trxn_dt", Now.Date, "pi_trnx_cd", "INVPMT", "pi_fnc_nm", "Generate Payment detail", "pi_user_id", MasterFRM.loginName, "pi_act_cd", "GENPMT", "pi_act_desc", "Generate and print payment details for client", "pi_remarks", "frmBill005PrintPreview")

        End With
    End Sub

End Class