Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.ComponentModel

Public Class frm_sale_inv_add
    Dim dbhpr As New db_helper
    Public saveTyp As String
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtClinm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClinm.KeyDown
        If act_typ = "EDIT" Then
            Exit Sub
        End If
        If (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 65 And e.KeyValue <= 90) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then
            ItemList()
        ElseIf e.KeyCode = Keys.Enter Then
            'MsgBox(txtCode.Text.Length)
            If txtcli_num.Text.Trim.Length = 0 Then
                SelectNextControl(sender, True, True, True, True)
            Else
                ItemList()
            End If
            If dgvFilter.Visible = True Then
                dgvFilter.Focus()
                dgvFilter.Rows(0).Selected = True
            End If
        ElseIf e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            resetClientFields()
        ElseIf e.KeyCode = Keys.Escape Then
            resetClientFields()
            txtClinm.FindForm()
        ElseIf e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If dgvFilter.Visible = True Then
                dgvFilter.Focus()
            End If
        End If
    End Sub
    Private Sub txtphoneNum_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVAT.KeyDown, txtphoneNum.KeyDown, txtNetAmt.KeyDown, txtMobilNum.KeyDown, txtMail.KeyDown, txtGrosamt.KeyDown, txtDiscntAmt.KeyDown, txtAddress.KeyDown, dtpInvDt.KeyDown, cboSexcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtClinm.Text.Trim.Length = 0 Then
            MsgBox("Please input client name to create invoice!!", MsgBoxStyle.Critical, "Invoice")
            txtClinm.Focus()
            Exit Sub
        End If

        With frmBill002AddItem
            'Dim sqlStr As String = "Select crcy_code, concat(crcy_code,': ', crcy_desc_en ) crcy_desc from tcurrency_masters where stat_cd='A'"
            'Dim tbl As DataTable = dbhpr.SelectData(sqlStr, "client type")
            '.cboType.DataSource = tbl
            '.cboType.DisplayMember = "crcy_desc"
            '.cboType.ValueMember = "crcy_code"

            .ShowDialog()
            If .DialogResult = System.Windows.Forms.DialogResult.Cancel Then
                .Close()
                .Dispose()

            End If

        End With
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvItem.SelectedRows.Count > 0 Then
            If MsgBox("Are you sure you want to remove item?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                dgvItem.Rows.RemoveAt(dgvItem.SelectedRows(0).Index)
            End If
        End If
    End Sub
    Sub ItemList()
        Dim str As String = "select top 10 cli_num,cli_nm,sex_code,phone_num,mobil_num,mail_addr,addr_l1 from tdhh_client_details  where  dbo.UncodeConvert(lower(cli_nm)) Like '%'+ dbo.UncodeConvert(N'" & txtClinm.Text.ToLower & "') +'%'  "
        Dim tbl As DataTable = dbhpr.SelectData(str, "ItemList")
        If tbl.Rows.Count > 0 Then
            'CLEAR COL ROWS
            dgvFilter.Rows.Clear()
            dgvFilter.Height = 20
            'SET NEW ROWS
            For Each r As DataRow In tbl.Rows
                dgvFilter.Rows.Add(r(0), r(1), r(2), r(3), r(4), r(5), r(6))
                dgvFilter.Height = dgvFilter.Height + 20
            Next
            dgvFilter.Visible = True
            'SET LOCATION
            dgvFilter.Left = txtClinm.Left
            dgvFilter.Top = txtClinm.Bottom
            dgvFilter.Width = txtNetAmt.Width * 2.5
        Else
            dgvFilter.Visible = False
        End If
    End Sub
    Sub Get_Val_item()
        If dgvFilter.SelectedRows.Count > 0 Then
            resetClientFields()
            txtcli_num.Text = dgvFilter.SelectedCells(0).Value
            txtClinm.Text = dgvFilter.SelectedCells(1).Value
            cboSexcode.SelectedValue = dgvFilter.SelectedCells(2).Value
            txtphoneNum.Text = dgvFilter.SelectedCells(3).Value
            txtMobilNum.Text = dgvFilter.SelectedCells(4).Value
            txtMail.Text = dgvFilter.SelectedCells(5).Value
            txtAddress.Text = dgvFilter.SelectedCells(6).Value
            dtpInvDt.Focus()
        Else
            dgvFilter.Visible = False
        End If
    End Sub
    Private Sub resetClientFields()
        txtcli_num.Text = ""
        txtphoneNum.Text = ""
        txtMobilNum.Text = ""
        txtMail.Text = ""
        txtAddress.Text = ""
    End Sub

    Private Sub txtClinm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClinm.KeyPress
        If act_typ = "EDIT" Then
            Exit Sub
        End If
        If e.KeyChar = Chr(8) Then
            ItemList()
        End If
    End Sub

    Private Sub dgvFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            Get_Val_item()
            dgvFilter.Visible = False
        ElseIf e.KeyCode = Keys.Escape Then
            dgvFilter.Visible = False
        End If
    End Sub

    Private Sub dgvFilter_LostFocus(sender As Object, e As EventArgs) Handles dgvFilter.LostFocus
        dgvFilter.Visible = False
    End Sub

    Private Sub dgvFilter_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Get_Val_item()
        dgvFilter.Visible = False
    End Sub
    Dim old_netAmt As Double
    Dim old_cli_length As Integer
    Dim new_netAmt As Double
    Dim new_cli_length As Integer
    Dim act_typ As String
    Private Sub frm_sale_inv_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvItem.Columns("qty").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvItem.Columns("unitprice").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvItem.Columns("total").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        act_typ = frm_sale_inv.Act_typ
        'store old values
        old_netAmt = IIf(IsNumeric(txtNetAmt.Text) = False, 0, txtNetAmt.Text)
        old_cli_length = txtcli_num.Text.Trim.Length + txtphoneNum.Text.Trim.Length + txtMobilNum.Text.Trim.Length + txtAddress.Text.Trim.Length + txtMail.Text.Length
    End Sub

    Private Sub dgvItem_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvItem.RowStateChanged
        CalAmt()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVAT.KeyPress, txtNetAmt.KeyPress, txtGrosamt.KeyPress, txtDiscntAmt.KeyPress
        NumericInput(e, ".", False)
    End Sub

    Private Sub txtGrosamt_TextChanged(sender As Object, e As EventArgs) Handles txtGrosamt.TextChanged, txtVAT.TextChanged, txtNetAmt.TextChanged, txtDiscntAmt.TextChanged
        If sender.text.trim = "" Then
            Exit Sub
        End If
        If IsNumeric(sender.text) = False Then
            MsgBox("Incorrect number format!!!", MsgBoxStyle.Exclamation, "Add Item")
            Exit Sub
        End If
        CalAmt()
    End Sub
    Private Sub CalAmt()
        On Error Resume Next
        txtGrosamt.Text = SumGrid(dgvItem, 4)
        Dim gross_amt As Double = IIf(IsNumeric(txtGrosamt.Text) = False, 0, CDbl(txtGrosamt.Text))
        Dim dscnt_amt As Double = IIf(IsNumeric(txtDiscntAmt.Text) = False, 0, CDbl(txtDiscntAmt.Text))
        Dim vat As Double = IIf(IsNumeric(txtVAT.Text) = False, 0, CDbl(txtVAT.Text))
        'Net
        Dim net_amt As Double = Math.Round((gross_amt - dscnt_amt) + (((gross_amt - dscnt_amt) * vat) / 100), 2)
        txtNetAmt.Text = net_amt
    End Sub

    Private Sub dgvFilter_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFilter.CellDoubleClick
        Get_Val_item()
        dgvFilter.Visible = False
    End Sub

    Private Sub InvoiceSave(inv_status As String)
        'remove old
        dbhpr.ExecProc("tdhh_invoice_details_del", "inv_num", txtInvNum.Text)
        'start new record
        Dim Objcn As DBSingle
        Dim cn As SqlConnection
        Objcn = DBSingle.GetInstance
        cn = Objcn.GetConnection

        Dim Trans1 As SqlClient.SqlTransaction = cn.BeginTransaction
        Dim cmd As New SqlClient.SqlCommand("", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Transaction = Trans1
        Try
            '-->> Save Master
            cmd.CommandText = "tdhh_invoice_masters_ins"
            CreatePar(cmd, "inv_num", txtInvNum.Text, "cli_num", txtcli_num.Text,
                      "inv_issu_dt", dtpInvDt.Value.Date,
                      "gros_amt", txtGrosamt.Text, "dscnt_amt", txtDiscntAmt.Text, "vat_amt", txtVAT.Text,
                      "net_amt", txtNetAmt.Text, "remarks", "",
                      "inv_status", inv_status,
                      "crcy_code", cboCurrency.SelectedValue,
                      "deposit_amt", 0, "pening_amt", txtNetAmt.Text,
                      "rec_status", "A",
                      "created_dt", Now.Date, "created_by", MasterFRM.loginName)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            '--<< save master
            '==> Save detail
            cmd.CommandText = "tdhh_invoice_details_ins"
            For i As Int16 = 0 To dgvItem.RowCount - 1
                CreatePar(cmd, "inv_num", txtInvNum.Text,
                          "itm_num", dgvItem.Rows(i).Cells(0).Value,
                          "itm_qty", CDbl(dgvItem.Rows(i).Cells(2).Value),
                          "unit_price", CDbl(dgvItem.Rows(i).Cells(3).Value),
                          "tot_amt", CDbl(dgvItem.Rows(i).Cells(4).Value),
                          "remarks", dgvItem.Rows(i).Cells(1).Value)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            Next
            '==<< Save detail
            Trans1.Commit()
        Catch ex As Exception
            Trans1.Rollback()
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Private Sub InvoiceEdit()
        'remove old
        dbhpr.ExecProc("tdhh_invoice_details_del", "inv_num", txtInvNum.Text)
        'start new record
        Dim Objcn As DBSingle
        Dim cn As SqlConnection
        Objcn = DBSingle.GetInstance
        cn = Objcn.GetConnection

        Dim Trans1 As SqlClient.SqlTransaction = cn.BeginTransaction
        Dim cmd As New SqlClient.SqlCommand("", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Transaction = Trans1
        Try
            '-->> Save Master
            cmd.CommandText = "tdhh_invoice_masters_upd"
            CreatePar(cmd, "inv_num", txtInvNum.Text,
                      "inv_issu_dt", dtpInvDt.Value.Date,
                      "gros_amt", txtGrosamt.Text,
                      "dscnt_amt", txtDiscntAmt.Text,
                      "vat_amt", txtVAT.Text,
                      "net_amt", txtNetAmt.Text,
                      "remarks", "",
                      "crcy_code", cboCurrency.SelectedValue,
                      "pening_amt", txtNetAmt.Text,
                      "updated_dt", Now.Date,
                      "updated_by", MasterFRM.loginName)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            '--<< save master
            '==> Save detail
            cmd.CommandText = "tdhh_invoice_details_ins"
            For i As Int16 = 0 To dgvItem.RowCount - 1
                CreatePar(cmd, "inv_num", txtInvNum.Text,
                          "itm_num", dgvItem.Rows(i).Cells(0).Value,
                          "itm_qty", CDbl(dgvItem.Rows(i).Cells(2).Value),
                          "unit_price", CDbl(dgvItem.Rows(i).Cells(3).Value),
                          "tot_amt", CDbl(dgvItem.Rows(i).Cells(4).Value),
                          "remarks", dgvItem.Rows(i).Cells(1).Value)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            Next
            '==<< Save detail
            Trans1.Commit()
        Catch ex As Exception
            Trans1.Rollback()
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub InvoiceValidat(ByRef err_msg As String)
        If txtClinm.Text.Trim.Length = 0 Then
            MsgBox("Please intput client!", MsgBoxStyle.Critical, "Invoice")
            err_msg = "01" 'client is require
            Exit Sub
        End If
        If dgvItem.RowCount = 0 Then
            MsgBox("No Item to print invoice!", MsgBoxStyle.Critical, "Invoice")
            err_msg = "02" 'not item to print 
            Exit Sub
        End If
        If CDbl(txtNetAmt.Text) <= 0 Then
            MsgBox("There is no amount to print invoice!", MsgBoxStyle.Critical, "Invoice")
            err_msg = "04" 'Net amount can't <=0
            Exit Sub
        End If

        err_msg = "00" ' no error
    End Sub
    Private Sub btnPrintInvoice_Click(sender As Object, e As EventArgs) Handles btnPrintInvoice.Click
        Dim errSms As String = ""
        InvoiceValidat(errSms)
        If errSms <> "00" Then
            Exit Sub
        End If
        Dim inv_status As String = "A"
        If act_typ = "ADD" Then
            InvoiceSave(inv_status)
        Else
            InvoiceEdit()
        End If
        'add to Dg master
        addGridMaster(txtInvNum.Text)
        'Assing new value to old record
        old_netAmt = IIf(IsNumeric(txtNetAmt.Text) = False, 0, txtNetAmt.Text)
        old_cli_length = txtcli_num.Text.Trim.Length + txtphoneNum.Text.Trim.Length + txtMobilNum.Text.Trim.Length + txtAddress.Text.Trim.Length + txtMail.Text.Length
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Dim errSms As String = ""
        InvoiceValidat(errSms)
        If errSms <> "00" Then
            Exit Sub
        End If
        Dim inv_status As String = "A"
        If frm_sale_inv.Act_typ = "ADD" Then
            InvoiceSave(inv_status)
        Else
            InvoiceEdit()
        End If
        'add to master Dg
        addGridMaster(txtInvNum.Text)
        'Assing new value to old record
        old_netAmt = IIf(IsNumeric(txtNetAmt.Text) = False, 0, txtNetAmt.Text)
        old_cli_length = txtcli_num.Text.Trim.Length + txtphoneNum.Text.Trim.Length + txtMobilNum.Text.Trim.Length + txtAddress.Text.Trim.Length + txtMail.Text.Length
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cboCurrency_KeyDown(sender As Object, e As KeyEventArgs) Handles cboCurrency.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAdd.Focus()
        End If
    End Sub
    Private Sub addGridMaster(inv_num As String)
        Try
            With frm_sale_inv

                'disable button 
                Dim sqlStr As String = ""
                Dim tbl As DataTable = Nothing

                sqlStr = "select v.inv_num,v.cli_num,v.cli_nm,v.phone_num,v.mobil_num,v.inv_issu_dt,v.gros_amt,v.dscnt_amt,v.vat_amt,v.net_amt,v.crcy_code,v.deposit_amt,v.pening_amt,v.inv_status from vw_invoice_clients v where v.inv_num='" & inv_num & "'"
                tbl = dbhpr.SelectData(sqlStr, "Booking")
                If frm_sale_inv.Act_typ = "ADD" Then

                    For Each r As DataRow In tbl.Rows
                        .dgInvMster.Rows.Add(r("inv_num"),
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
                Else
                    For Each r As DataRow In tbl.Rows
                        .dgInvMster.SelectedRows(0).Cells(1).Value = r("cli_num")
                        .dgInvMster.SelectedRows(0).Cells(2).Value = r("cli_nm")
                        .dgInvMster.SelectedRows(0).Cells(3).Value = r("phone_num")
                        .dgInvMster.SelectedRows(0).Cells(4).Value = r("mobil_num")
                        .dgInvMster.SelectedRows(0).Cells(5).Value = r("inv_issu_dt")
                        .dgInvMster.SelectedRows(0).Cells(6).Value = r("gros_amt")
                        .dgInvMster.SelectedRows(0).Cells(7).Value = r("dscnt_amt")
                        .dgInvMster.SelectedRows(0).Cells(8).Value = r("vat_amt")
                        .dgInvMster.SelectedRows(0).Cells(9).Value = r("net_amt")
                        .dgInvMster.SelectedRows(0).Cells(10).Value = r("deposit_amt")
                        .dgInvMster.SelectedRows(0).Cells(11).Value = r("pening_amt")
                        .dgInvMster.SelectedRows(0).Cells(12).Value = r("crcy_code")
                    Next
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub txtClinm_TextChanged(sender As Object, e As EventArgs) Handles txtClinm.TextChanged
        On Error Resume Next
        Dim str As String = "select top 10 cli_num,cli_nm,sex_code,phone_num,mobil_num,mail_addr,addr_l1 from tdhh_client_details  where  dbo.UncodeConvert(lower(cli_nm)) Like '%'+ dbo.UncodeConvert(N'" & txtClinm.Text.ToLower & "') +'%'  "
        Dim tbl As DataTable = dbhpr.SelectData(str, "ItemList")
        If tbl.Rows.Count <= 0 Then
            dgvFilter.Visible = False
        End If
    End Sub

    Private Sub frm_sale_inv_add_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        With frm_sale_inv
            If .Act_typ = "EDIT" Then
                new_netAmt = IIf(IsNumeric(txtNetAmt.Text) = False, 0, txtNetAmt.Text)
                new_cli_length = txtcli_num.Text.Trim.Length + txtphoneNum.Text.Trim.Length + txtMobilNum.Text.Trim.Length + txtAddress.Text.Trim.Length + txtMail.Text.Length
                If (old_netAmt + old_cli_length) <> (new_netAmt + new_cli_length) Then
                    If MsgBox("There are some change in form!!!, Do you want to close form without save?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        e.Cancel = True
                    End If
                End If
            End If
        End With
        'create client
        If txtcli_num.Text.Length = 0 Then
            Dim cli_num_hdr As String = "C" & Format(Now, "yyyyMM")
            Dim cli_num As String = dbhpr.GenerateID("select max(cli_num) from tdhh_client_details where substring(cli_num,1,7)= '" & cli_num_hdr & "' ", 4, cli_num_hdr)
            txtcli_num.Text = cli_num
        End If
        dbhpr.ExecProc("tdhh_client_details_ins_upd", "cli_num", txtcli_num.Text, "cli_nm", txtClinm.Text, "sex_code", cboSexcode.SelectedValue, "birth_dt", DBNull.Value, "id_num", "", "id_typ", "", "addr_l1", txtAddress.Text, "phone_num", txtphoneNum.Text, "mobil_num", txtMobilNum.Text, "mail_addr", txtMail.Text, "cli_typ", "C", "rec_status", "A")
    End Sub

    Private Sub cboSexcode_GotFocus(sender As Object, e As EventArgs) Handles cboSexcode.GotFocus, txtphoneNum.GotFocus, txtMobilNum.GotFocus, txtAddress.GotFocus, txtMail.GotFocus, dtpInvDt.GotFocus, txtDiscntAmt.GotFocus, txtVAT.GotFocus, btnAdd.GotFocus
        dgvFilter.Visible = False
    End Sub

End Class
