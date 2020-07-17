Imports System.Windows.Forms

Public Class frm_sale_inv_printParm

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If CDbl(txtEndBal.Text) < 0 Then
            MsgBox("End Balance can not less than 0!!!", MsgBoxStyle.Critical, "Invoice Printing")
            txtPayAmount.Focus()
            Exit Sub
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtStartBal.TextChanged, txtEndBal.TextChanged, txtPayAmount.TextChanged
        On Error Resume Next
        If IsNumeric(sender.text) = False Then
            MsgBox("Invalid number format!!!", MsgBoxStyle.Exclamation, "Invoice Printing")
            Exit Sub
        End If

        Dim bgin_bal As Double = CDbl(IIf(IsNumeric(txtStartBal.Text) = False, 0, txtStartBal.Text))
        Dim pay_amt As Double = CDbl(IIf(IsNumeric(txtPayAmount.Text) = False, 0, txtPayAmount.Text))

        txtEndBal.Text = bgin_bal - pay_amt

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbFullPay.CheckedChanged
        On Error Resume Next
        If rbFullPay.Checked = True Then
            txtPayAmount.Text = txtStartBal.Text
            txtPayAmount.ReadOnly = True
        ElseIf rbSplPay.Checked = True Then
            txtPayAmount.ReadOnly = False
            txtPayAmount.Focus()
        End If

    End Sub

End Class
