Imports System.Windows.Forms

Public Class frmBill002AddItem
    Dim dbHpr As New db_helper
    Dim is_cost_chng As Boolean = False
    Dim old_cost As Double
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            If txtName.Text.Trim = "" Then
                MsgBox("Please input Item name!!!", MsgBoxStyle.Critical, "ItemAdd")
                txtName.Focus()
                Exit Sub
            End If

            With frm_sale_inv_add
                If txtPrice.Text.Trim = "" Or txtPrice.Text = "0" Then
                    MsgBox("Please in put price of item!!!", MsgBoxStyle.Critical, "ItemAdd")
                    txtPrice.Focus()
                    Exit Sub
                End If
                If txtQty.Text.Trim = "" Or txtQty.Text = "0" Then
                    MsgBox("Please input Item QTY!!!", MsgBoxStyle.Critical, "ItemAdd")
                    txtQty.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtQty.Text) = False Then
                    MsgBox("Quatity is not the correct number format!!!", MsgBoxStyle.Exclamation, "Add Item")
                    txtQty.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtPrice.Text) = False Then
                    MsgBox("Price is not the correct number format!!!", MsgBoxStyle.Exclamation, "Add Item")
                    txtPrice.Focus()
                    Exit Sub
                End If

                'add menu item if not exist in menu
                Dim code_hdr As String = Format(Now, "yyyyMM")
                Dim menuNum As String = ""

                If txtCode.Text.Trim = "" Then
                    menuNum = dbHpr.GenerateID("select max(menu_num) from tgh_food_menus where substring(menu_num,1,6)='" & code_hdr & "' ", 4, code_hdr)
                    txtCode.Text = menuNum
                    Dim errMsg As String = ""
                    errMsg = dbHpr.ExecStored("tgh_food_menus_ins_no_img", "po_retrn", "menu_num", menuNum, "menu_nm", txtName.Text, "menu_nm_kh", "", "menu_desc", "", "menu_price", txtPrice.Text, "menu_cat", "01")
                ElseIf txtCode.Text.Trim <> "" And chkPrice.Checked = True Then
                    menuNum = dbHpr.GenerateID("select max(menu_num) from tgh_food_menus where substring(menu_num,1,6)='" & code_hdr & "' ", 4, code_hdr)
                    dbHpr.ExecProc("tgh_food_menus_del", "menu_num", txtCode.Text)
                    Dim errMsg As String = ""
                    errMsg = dbHpr.ExecStored("tgh_food_menus_ins_no_img", "po_retrn", "menu_num", menuNum, "menu_nm", txtName.Text, "menu_nm_kh", "", "menu_desc", "", "menu_price", txtPrice.Text, "menu_cat", "01")
                    txtCode.Text = menuNum
                End If
                'check duplicated row
                For Each r As DataGridViewRow In .dgvItem.Rows
                    If r.Cells(0).Value.ToString.ToLower = txtCode.Text Then
                        MsgBox("Item is already added!!!", MsgBoxStyle.Exclamation, "Add Item")
                        txtName.Focus()
                        Exit Sub
                    End If
                Next
                'add row
                .dgvItem.Rows.Add(txtCode.Text, txtName.Text, txtPrice.Text, txtQty.Text, txtAmt.Text)
                menuNum = ""
                txtCode.Text = ""
                txtName.Text = ""
                txtPrice.Text = "0"
                txtQty.Text = "0"
                txtAmt.Text = "0"
                chkPrice.CheckState = False
                chkPrice.Enabled = False
                txtName.Focus()
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Sub ItemList()
        Dim str As String = "select top 5 m.menu_num,m.menu_nm,m.menu_price from tgh_food_menus m where m.stat_cd='A'  and dbo.UncodeConvert(lower(menu_nm)) Like '%'+ dbo.UncodeConvert(N'" & txtName.Text.ToLower & "') +'%'  "
        Dim tbl As DataTable = dbHpr.SelectData(str, "ItemList")
        If tbl.Rows.Count > 0 Then
            'CLEAR COL ROWS
            dgfilter.Rows.Clear()
            dgfilter.Height = 20
            'SET NEW ROWS
            For Each r As DataRow In tbl.Rows
                dgfilter.Rows.Add(r(0), r(1), r(2))
                dgfilter.Height = dgfilter.Height + 20
            Next
            dgfilter.Visible = True

            'SET LOCATION
            dgfilter.Left = txtName.Left
            dgfilter.Top = txtName.Bottom
            dgfilter.Width = txtName.Width

        Else
            dgfilter.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ItemList()
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = Chr(8) Then
            ItemList()
        End If
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown
        If (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 65 And e.KeyValue <= 90) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then
            ItemList()
        ElseIf e.KeyCode = Keys.Enter Then
            'MsgBox(txtCode.Text.Length)
            If txtCode.Text.Trim.Length = 0 Then
                SelectNextControl(sender, True, True, True, True)
            Else
                ItemList()
            End If
            If dgfilter.Visible = True Then
                dgfilter.Focus()
                dgfilter.Rows(0).Selected = True
            End If
        ElseIf e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            txtCode.Text = ""
            txtPrice.Text = "0"
        ElseIf e.KeyCode = Keys.Escape Then
            dgfilter.Visible = False
            txtName.Focus()
        ElseIf e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If dgfilter.Visible = True Then
                dgfilter.Focus()
            End If
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        On Error Resume Next
        Dim str As String = "select top 5 m.menu_num,m.menu_nm,m.menu_price from tgh_food_menus m where m.stat_cd='A'  and dbo.UncodeConvert(lower(menu_nm)) Like '%'+ dbo.UncodeConvert(N'" & txtName.Text.ToLower & "') +'%'  "
        Dim tbl As DataTable = dbHpr.SelectData(str, "ItemList")
        If tbl.Rows.Count <= 0 Then
            txtCode.Text = ""
            txtPrice.Enabled = True
            dgfilter.Visible = False
        End If
    End Sub

    Private Sub dgvOthers_KeyDown(sender As Object, e As KeyEventArgs) Handles dgfilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            Get_Val_item()
            dgfilter.Visible = False
        ElseIf e.KeyCode = Keys.Escape Then
            dgfilter.Visible = False
        End If
    End Sub
    Sub Get_Val_item()
        If dgfilter.SelectedRows.Count > 0 Then
            txtCode.Text = ""
            txtName.Text = ""
            txtPrice.Text = ""
            txtCode.Text = dgfilter.SelectedCells(0).Value
            txtName.Text = dgfilter.SelectedCells(1).Value
            txtPrice.Text = dgfilter.SelectedCells(2).Value
            txtPrice.Enabled = False
            chkPrice.Enabled = True
            chkPrice.CheckState = False
            txtQty.Focus()
        Else
            dgfilter.Visible = False
        End If
    End Sub

    Private Sub txtName_LostFocus(sender As Object, e As EventArgs) Handles txtName.LostFocus
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress, txtPrice.KeyPress
        NumericInput(e, ".", False)
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged, txtPrice.TextChanged
        If sender.text.trim = "" Then
            Exit Sub
        End If
        If IsNumeric(sender.text) = False Then
            MsgBox("Incorrect number format!!!", MsgBoxStyle.Exclamation, "Add Item")
            Exit Sub
        End If
        txtAmt.Text = IIf(IsNumeric(txtPrice.Text) = True, txtPrice.Text, 0) * IIf(IsNumeric(txtQty.Text) = True, txtQty.Text, 0)
    End Sub

    Private Sub dgvOthers_LostFocus(sender As Object, e As EventArgs) Handles dgfilter.LostFocus
        dgfilter.Visible = False
    End Sub

    Private Sub dgvOthers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgfilter.CellDoubleClick
        Get_Val_item()
        dgfilter.Visible = False
    End Sub

    Private Sub txtPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown, txtPrice.KeyDown, txtAmt.KeyDown
        If e.KeyCode = Keys.Enter Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrice.CheckedChanged
        If chkPrice.Checked = True Then
            txtPrice.Enabled = True
        Else
            txtPrice.Enabled = False
        End If
    End Sub

    Private Sub frmBill002AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
