Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports System.Windows.Forms

Public Class frm_sale_inv

    Dim dbHpr As New db_helper
    Private Sub frmSnackDrinkList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainer2.Panel2Collapsed = True
        Try
            'disable button 
            dgInvMster.Rows.Clear()
            Dim sqlStr As String = ""
            Dim tbl As DataTable = Nothing
            sqlStr = "select v.inv_num,v.cli_num,v.cli_nm,v.phone_num,v.mobil_num,v.inv_issu_dt,v.gros_amt,v.dscnt_amt,v.vat_amt,v.net_amt,v.crcy_code,v.deposit_amt,v.pening_amt,v.inv_status from vw_invoice_clients v where inv_status in('A','P')" 'year(inv_issu_dt)='" & Now.Year & "' and MONTH(inv_issu_dt)='" & Now.Month & "'"
            tbl = dbHpr.SelectData(sqlStr, "Invioce")
            For Each r As DataRow In tbl.Rows
                dgInvMster.Rows.Add(r("inv_num"),
                              r("cli_num"),
                              r("cli_nm"),
                              r("phone_num"),
                              r("mobil_num"),
                              r("inv_issu_dt"),
                              r("gros_amt"),
                              r("dscnt_amt"),
                              r("vat_amt"),
                              r("net_amt"),
                              r("deposit_amt"),
                              r("pening_amt"),
                              r("crcy_code"),
                              r("inv_status"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub tsbtnClose_Click(sender As Object, e As EventArgs) Handles tsbtnClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public nodeT As TreeNode

    Public Act_typ As String
    Private Sub tbtnAdd_Click(sender As Object, e As EventArgs) Handles tbtnAdd.Click
        With frm_sale_inv_add
            Act_typ = "ADD"
            Dim inv_yyyymm As String = "B" & Format(Now.Date, "yyyyMM")
            Dim inv_num As String = dbHpr.GenerateID("select max(inv_num) from tdhh_invoice_masters v where substring(inv_num,1,7)='" & inv_yyyymm & "'", 4, inv_yyyymm)
            .txtInvNum.Text = inv_num

            Dim sqlStr As String = "select fld_valu,concat(fld_valu, ' - ', fld_valu_desc_en) val_desc from tswa_field_values f where f.fld_nm='SEX_CODE' and status='A'"
            Dim tbl As DataTable = dbHpr.SelectData(sqlStr, "client type")
            .cboSexcode.DataSource = tbl
            .cboSexcode.DisplayMember = "val_desc"
            .cboSexcode.ValueMember = "fld_valu"

            sqlStr = "select crcy_code,CONCAT(crcy_code,' - ', crcy_desc_en,' - ', crcy_amt) crcy_desc from tcurrency_masters where stat_cd='A'"
            tbl = dbHpr.SelectData(sqlStr, "Currency")
            .cboCurrency.DataSource = tbl
            .cboCurrency.DisplayMember = "crcy_desc"
            .cboCurrency.ValueMember = "crcy_code"

            .ShowDialog()
            'refresh detail and payment details
            refreshGrid()
            .Close()
            .Dispose()
            'print
            If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                'print invoice
                Dim err_sms As String = ""
                PrintPayment(.txtInvNum.Text, err_sms)
                If err_sms <> "0" Then
                    Exit Sub
                End If
            End If
        End With
    End Sub

    Private Sub tbtnEdi_Click(sender As Object, e As EventArgs) Handles tbtnEdi.Click
        SDEdit()
    End Sub

    Private Sub SDEdit()
        If dgInvMster.SelectedRows.Count = 0 Then
            MsgBox("No data to Edit!", MsgBoxStyle.Information)
            Exit Sub
        End If
        If dgInvMster.SelectedRows(0).Cells(13).Value <> "A" And dgInvMster.SelectedRows(0).Cells(13).Value <> "P" Then
            MsgBox("Invoice can not change with status 'C', 'R' and 'X'!!!", MsgBoxStyle.Information, "Edit Invoice")
            Exit Sub
        End If
        If dgPmtDtls.SelectedRows.Count > 0 Then
            MsgBox("Exist payment history with this invoice!, Please reverse payment before editing!", MsgBoxStyle.Exclamation, "Edit Invoice")
            Exit Sub
        End If
        Act_typ = "EDIT"
        If MsgBox("Are you sure you want to make change invoice?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            With frm_sale_inv_add
                Dim sqlStr As String = "select fld_valu,concat(fld_valu, ' - ', fld_valu_desc_en) val_desc from tswa_field_values f where f.fld_nm='SEX_CODE' and status='A'"
                Dim tbl As DataTable = dbHpr.SelectData(sqlStr, "client type")
                .cboSexcode.DataSource = tbl
                .cboSexcode.DisplayMember = "val_desc"
                .cboSexcode.ValueMember = "fld_valu"

                sqlStr = "select crcy_code,CONCAT(crcy_code,' - ', crcy_desc_en,' - ', crcy_amt) crcy_desc from tcurrency_masters where stat_cd='A'"
                tbl = dbHpr.SelectData(sqlStr, "Currency")
                .cboCurrency.DataSource = tbl
                .cboCurrency.DisplayMember = "crcy_desc"
                .cboCurrency.ValueMember = "crcy_code"

                'invoice master
                sqlStr = "select v.inv_num,v.cli_num,v.cli_nm,sex_code,v.phone_num,v.mobil_num,addr_l1,mail_addr,v.inv_issu_dt,v.gros_amt,v.dscnt_amt,v.vat_amt,v.net_amt,v.crcy_code,v.deposit_amt,v.pening_amt,v.inv_status from vw_invoice_clients v where v.inv_num='" & dgInvMster.SelectedRows(0).Cells(0).Value & "'"
                tbl = dbHpr.SelectData(sqlStr)
                If tbl.Rows.Count > 0 Then
                    'client
                    .txtcli_num.Text = tbl.Rows(0)("cli_num")
                    .txtClinm.Text = tbl.Rows(0)("cli_nm")
                    .cboSexcode.SelectedValue = tbl.Rows(0)("sex_code")
                    .txtphoneNum.Text = tbl.Rows(0)("phone_num")
                    .txtMobilNum.Text = tbl.Rows(0)("mobil_num")
                    .txtAddress.Text = tbl.Rows(0)("addr_l1")
                    .txtMail.Text = tbl.Rows(0)("mail_addr")
                    'invoice
                    .txtInvNum.Text = tbl.Rows(0)("inv_num")
                    .dtpInvDt.Value = tbl.Rows(0)("inv_issu_dt")
                    .cboCurrency.SelectedValue = tbl.Rows(0)("crcy_code")
                    .txtDiscntAmt.Text = tbl.Rows(0)("dscnt_amt")
                    .txtVAT.Text = tbl.Rows(0)("vat_amt")
                End If

                'itme details
                sqlStr = "select bd.itm_num,f.menu_nm,bd.itm_qty,bd.unit_price,bd.tot_amt,bd.remarks from tgh_food_menus f,tdhh_invoice_details bd where f.menu_num=bd.itm_num and bd.inv_num = '" & dgInvMster.SelectedRows(0).Cells(0).Value & "' ;"
                tbl = dbHpr.SelectData(sqlStr)
                For Each r As DataRow In tbl.Rows
                    .dgvItem.Rows.Add(r("itm_num"), r("menu_nm"), r("itm_qty"), r("unit_price"), r("tot_amt"))
                Next

                'disable object
                '.txtClinm.Enabled = False

                .ShowDialog()
                'master
                sqlStr = "select v.inv_num,v.cli_num,v.cli_nm,sex_code,v.phone_num,v.mobil_num,addr_l1,mail_addr,v.inv_issu_dt,v.gros_amt,v.dscnt_amt,v.vat_amt,v.net_amt,v.crcy_code,v.deposit_amt,v.pening_amt,v.inv_status from vw_invoice_clients v where v.inv_num='" & dgInvMster.SelectedRows(0).Cells(0).Value & "'"
                tbl = dbHpr.SelectData(sqlStr)
                If tbl.Rows.Count > 0 Then
                    dgInvMster.SelectedRows(0).Cells(2).Value = tbl(0)("cli_nm")
                    dgInvMster.SelectedRows(0).Cells(3).Value = tbl(0)("phone_num")
                    dgInvMster.SelectedRows(0).Cells(4).Value = tbl(0)("mobil_num")
                    dgInvMster.SelectedRows(0).Cells(5).Value = tbl(0)("inv_issu_dt")
                    dgInvMster.SelectedRows(0).Cells(6).Value = tbl(0)("gros_amt")
                    dgInvMster.SelectedRows(0).Cells(7).Value = tbl(0)("dscnt_amt")
                    dgInvMster.SelectedRows(0).Cells(8).Value = tbl(0)("vat_amt")
                    dgInvMster.SelectedRows(0).Cells(9).Value = tbl(0)("net_amt")
                    dgInvMster.SelectedRows(0).Cells(10).Value = tbl(0)("deposit_amt")
                    dgInvMster.SelectedRows(0).Cells(11).Value = tbl(0)("pening_amt")
                    dgInvMster.SelectedRows(0).Cells(12).Value = tbl(0)("crcy_code")
                End If
                'detail
                refreshGrid()
                .Close()
                .Dispose()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    'print invoice
                    Dim err_sms As String = ""
                    PrintPayment(.txtInvNum.Text, err_sms)
                    If err_sms <> "0" Then
                        Exit Sub
                    End If
                End If
            End With
        End If
    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgInvMster.CellDoubleClick
        SDEdit()
    End Sub

    Private Sub tbtnDel_Click(sender As Object, e As EventArgs) Handles tbtnDel.Click
        If dgPmtDtls.SelectedRows.Count > 0 Then
            MsgBox("Exist payment history with this invoice!, Please reverse payment before cancelation!", MsgBoxStyle.Exclamation, "Cancel Invoice")
            Exit Sub
        End If
        If dgInvMster.SelectedRows.Count = 0 Then
            MsgBox("There is no invoice selected!", MsgBoxStyle.Exclamation, "Cancel Invoice")
            Exit Sub
        End If
        If dgInvMster.SelectedRows(0).Cells(13).Value <> "A" And dgInvMster.SelectedRows(0).Cells(13).Value <> "P" Then
            MsgBox("Invoice can be cancel with status 'A' and 'P' only!", MsgBoxStyle.Exclamation, "Cancel Invoice")
            Exit Sub
        End If
        If MsgBox("Are you sure you want to cancel Invoice?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Cancel Invoice") = MsgBoxResult.Yes Then
            dbHpr.ExecProc("tdhh_invoice_masters_del", "inv_num", dgInvMster.SelectedRows(0).Cells(0).Value, "user_id", MasterFRM.loginName)
            dgInvMster.SelectedRows(0).Cells(13).Value = "X"
            MsgBox("Invoice is cancelled!", MsgBoxStyle.Information, "Cancel Invoice")
        End If
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsbtnSearch.Click
        tsbtnSearch.Checked = Not tsbtnSearch.Checked
        Me.SplitContainer2.Panel2Collapsed = Not Me.SplitContainer2.Panel2Collapsed
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            'disable button 
            dgInvMster.Rows.Clear()
            Dim sqlStr As String = ""
            Dim tbl As DataTable = Nothing
            sqlStr = "select v.inv_num,v.cli_num,v.cli_nm,v.phone_num,v.mobil_num,v.inv_issu_dt,v.gros_amt,v.dscnt_amt,v.vat_amt,v.net_amt,v.crcy_code,v.deposit_amt,v.pening_amt,v.inv_status from vw_invoice_clients v where inv_status like '%" & txtInvStatus.Text & "%'  and cli_nm like '%" & txtClientName.Text & "%'" 'year(inv_issu_dt)='" & Now.Year & "' and MONTH(inv_issu_dt)='" & Now.Month & "'"
            tbl = dbHpr.SelectData(sqlStr, "Invioce")
            For Each r As DataRow In tbl.Rows
                dgInvMster.Rows.Add(r("inv_num"),
                              r("cli_num"),
                              r("cli_nm"),
                              r("phone_num"),
                              r("mobil_num"),
                              r("inv_issu_dt"),
                              r("gros_amt"),
                              r("dscnt_amt"),
                              r("vat_amt"),
                              r("net_amt"),
                              r("deposit_amt"),
                              r("pening_amt"),
                              r("crcy_code"),
                              r("inv_status"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub dgv1_SelectionChanged(sender As Object, e As EventArgs) Handles dgInvMster.SelectionChanged
        On Error Resume Next
        refreshGrid()
    End Sub
    Private Sub refreshGrid()
        Dim sqlStr As String = ""
        Dim tbl As DataTable = Nothing
        'item Details
        dgItem.Rows.Clear()
        sqlStr = "select * from tdhh_invoice_details where inv_num='" & dgInvMster.SelectedRows(0).Cells(0).Value & "'"
        tbl = dbHpr.SelectData(sqlStr, "Item")
        For Each r As DataRow In tbl.Rows
            dgItem.Rows.Add(r("itm_num"), r("remarks"), r("itm_qty"), r("unit_price"), r("tot_amt"))
        Next

        'payment details
        dgPmtDtls.Rows.Clear()
        sqlStr = "select * from tdhh_invoice_payments where inv_num='" & dgInvMster.SelectedRows(0).Cells(0).Value & "' and rec_status ='A' "
        tbl = dbHpr.SelectData(sqlStr, "Item")
        For Each r As DataRow In tbl.Rows
            dgPmtDtls.Rows.Add(r("pmt_num"), r("pmt_dt"), r("strt_bal"), r("pmt_amt"), r("end_bal"))
        Next
        If dgPmtDtls.RowCount = 0 Then
            tsbRevert.Enabled = False
            tsbReprint.Enabled = False
        Else
            tsbRevert.Enabled = True
            tsbReprint.Enabled = True
        End If
    End Sub

    Public Shared print_typ As String = "POS"
    Public Shared pmt_type As String = "FULL"
    Public Shared pmt_dt As Date
    Public Shared bginBal As Double
    Public Shared payment_amt As Double
    Public Shared endBal As Double

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles tsbPrintInvoice.Click
        If dgInvMster.SelectedRows.Count = 0 Then
            MsgBox("there is no invoice to print!!!", MsgBoxStyle.Exclamation, "Print Invoice")
            Exit Sub
        End If

        'print and save
        Dim err_smg As String = ""
        PrintPayment(dgInvMster.SelectedRows(0).Cells(0).Value, err_smg)
        If err_smg <> "0" Then
            Exit Sub
        End If
    End Sub

    Private Sub PrintPayment(inv_num As String, ByRef err_smg As String)
        'get begin balance and invoice status
        Dim begin_bal As Double = 0
        Dim inv_status As String = "X"
        Dim sqlStr As String = "select i.pening_amt,inv_status from tdhh_invoice_masters i where i.inv_num='" & inv_num & "'; "
        Dim tbl As DataTable = dbHpr.SelectData(sqlStr, "Invoice Balance")
        If tbl.Rows.Count > 0 Then
            begin_bal = CDbl(tbl.Rows(0)("pening_amt"))
            inv_status = tbl.Rows(0)("inv_status").ToString
        End If

        If begin_bal <= 0 Then
            MsgBox("select invoice is already paid off!", MsgBoxStyle.Information, "Print Invoice")
            err_smg = "88"
            Exit Sub
        End If

        If inv_status <> "A" And inv_status <> "P" Then
            MsgBox("Invoice is not in printing status!, Print status are:'A' and 'P'.", MsgBoxStyle.Information, "Print Invoice")
            err_smg = "99"
            Exit Sub
        End If
        'Call print preview form
        Dim is_print As Boolean = False
        With frm_sale_inv_printParm
            .txtStartBal.Text = begin_bal
            .rbFullPay.Checked = True
            .txtPayAmount.Text = .txtStartBal.Text
            .txtEndBal.Text = 0
            .ShowDialog()
            If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                is_print = True
                print_typ = IIf(.rbPOS.Checked = True, "POS", "A4")
                pmt_type = IIf(.rbFullPay.Checked = True, "FUL", "SPL")
                pmt_dt = .dtpPmtDt.Value.Date
                bginBal = CDbl(.txtStartBal.Text)
                payment_amt = CDbl(.txtPayAmount.Text)
                endBal = CDbl(.txtEndBal.Text)
            End If
            .Close()
            .Dispose()
        End With

        If is_print = True Then
            Try
                'Save Payment Details
                Dim pmt_seq As String = "1"
                GenPayment(dgInvMster.SelectedRows(0).Cells(0).Value, dgInvMster.SelectedRows(0).Cells(1).Value, pmt_dt, bginBal, payment_amt, endBal, pmt_seq)

                sqlStr = "select deposit_amt,pening_amt,inv_status from tdhh_invoice_masters where inv_num='" & dgInvMster.SelectedRows(0).Cells(0).Value & "' "
                tbl = dbHpr.SelectData(sqlStr)
                If tbl.Rows.Count > 0 Then
                    dgInvMster.SelectedRows(0).Cells(10).Value = tbl(0)("deposit_amt")
                    dgInvMster.SelectedRows(0).Cells(11).Value = tbl(0)("pening_amt")
                    dgInvMster.SelectedRows(0).Cells(13).Value = tbl(0)("inv_status")
                End If
                dgPmtDtls.Rows.Add(pmt_seq, pmt_dt, bginBal, payment_amt, endBal)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            'show print perview
            Dim seq_num As Int16 = 1
            PrintPreview(seq_num, inv_num)
        End If
    End Sub

    Private Sub GenPayment(inv_num As String, cli_num As String, pmt_dt As Date, str_bal As Double, pay_amt As Double, end_bal As Double, ByRef pmt_seq As String)
        Try
            '==>> Save Payment details
            Dim pmt_num As String = dbHpr.GenerateID("Select max(pmt_num) from tdhh_invoice_payments where inv_num='" & inv_num & "'")
            dbHpr.ExecProc("tdhh_invoice_payments_ins", "pmt_num", pmt_num, "inv_num", inv_num, "cli_num", cli_num,
                   "pmt_dt", pmt_dt, "strt_bal", str_bal, "pmt_amt", pay_amt, "end_bal", end_bal, "rec_status", "A",
                   "created_dt", Now.Date, "created_by", MasterFRM.loginName)
            '==<< Save Payment details
            pmt_seq = pmt_num
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub PrintPreview(seq_num As String, bill_num As String)
        With frmBill005PrintPreview
            'View Report
            'reset
            .ReportViewer1.Reset()
            'data source
            Dim sqlStr As String = "select v.* from vw_invoice_print_headers v where  v.inv_num='" & bill_num & "' and v.pmt_num='" & seq_num & "'"
            Dim dt As DataTable = dbHpr.SelectData(sqlStr, "Bill master")
            Dim rds1 As New ReportDataSource("DataSet1", dt)
            .ReportViewer1.LocalReport.DataSources.Add(rds1)

            sqlStr = "select itm_num,remarks itm_nm,itm_qty,unit_price,tot_amt from tdhh_invoice_details  where inv_num='" & bill_num & "' "
            dt = dbHpr.SelectData(sqlStr, "Bill details")
            Dim rds2 As New ReportDataSource("DataSet2", dt)
            .ReportViewer1.LocalReport.DataSources.Add(rds2)
            'Path
            .ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\rpt\rptBill002A4.rdlc"
            .ReportViewer1.ZoomMode = ZoomMode.FullPage
            'refresh
            .ReportViewer1.RefreshReport()

            .ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)

            .Width = 680
            .Height = MasterFRM.Height
            .ShowDialog()
            .Close()
            .Dispose()
        End With

    End Sub

    Private Sub ToolStripButton1_Click_2(sender As Object, e As EventArgs) Handles tsbRevert.Click
        If dgPmtDtls.SelectedRows.Count = 0 Then
            MsgBox("No Payment to revers!", MsgBoxStyle.Information, "Revers Payment")
            Exit Sub
        End If
        If MsgBox("Are you sure you want to revers payment history?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            With frm_sale_pmt_revers
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    dbHpr.ExecProc("tdhh_invoice_payments_revers", "pmt_num", dgPmtDtls.SelectedRows(0).Cells(0).Value, "inv_num", dgInvMster.SelectedRows(0).Cells(0).Value, "pmt_amt", dgPmtDtls.SelectedRows(0).Cells(3).Value, "user_id", MasterFRM.loginName)

                    Dim act_reasn As String = .TextBox1.Text
                    'save history
                    dbHpr.ExecProc("ins_tswa_trxn_histories", "pi_trxn_dt", Now.Date, "pi_trnx_cd", "INVREVRT", "pi_fnc_nm", "Reversion Invoice", "pi_user_id", MasterFRM.loginName, "pi_act_cd", "Reversion Invoice", "pi_act_desc", "Revers amount: " & dgPmtDtls.SelectedRows(0).Cells(3).Value & " from invoie: " & dgInvMster.SelectedRows(0).Cells(0).Value, "pi_remarks", act_reasn)

                    Dim sqlStr As String = "select deposit_amt,pening_amt,inv_status from tdhh_invoice_masters where inv_num='" & dgInvMster.SelectedRows(0).Cells(0).Value & "' "
                    Dim tbl As DataTable = dbHpr.SelectData(sqlStr)
                    If tbl.Rows.Count > 0 Then
                        dgInvMster.SelectedRows(0).Cells(10).Value = tbl(0)("deposit_amt")
                        dgInvMster.SelectedRows(0).Cells(11).Value = tbl(0)("pening_amt")
                        dgInvMster.SelectedRows(0).Cells(13).Value = tbl(0)("inv_status")
                    End If
                    'remove record
                    dgPmtDtls.Rows.RemoveAt(dgPmtDtls.SelectedRows(0).Index)
                End If
                .Close()
                .Dispose()
            End With
        End If
    End Sub

    Private Sub dgPmtDtls_SelectionChanged(sender As Object, e As EventArgs) Handles dgPmtDtls.SelectionChanged

    End Sub

    Private Sub ToolStripButton1_Click_3(sender As Object, e As EventArgs) Handles tsbReprint.Click
        If dgPmtDtls.SelectedRows.Count = 0 Then
            MsgBox("No Payment history to reprint!", MsgBoxStyle.Exclamation, "Reprint Invoice")
            Exit Sub
        End If
        If MsgBox("Do you want to re-print selected payment?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'save history
            dbHpr.ExecProc("tgh_bill_print_histories_ins", "bill_num", dgInvMster.SelectedRows(0).Cells(0).Value & dgPmtDtls.SelectedRows(0).Cells(0).Value, "print_dt", Now.Date, "print_by", MasterFRM.loginName, "reasn", "reprint invoice for client")
            PrintPreview(dgPmtDtls.SelectedRows(0).Cells(0).Value, dgInvMster.SelectedRows(0).Cells(0).Value)
        End If

    End Sub
End Class