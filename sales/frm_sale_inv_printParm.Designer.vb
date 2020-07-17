<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sale_inv_printParm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtStartBal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbFullPay = New System.Windows.Forms.RadioButton()
        Me.rbSplPay = New System.Windows.Forms.RadioButton()
        Me.txtPayAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEndBal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbPOS = New System.Windows.Forms.RadioButton()
        Me.rbA4 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpPmtDt = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.09402!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.90598!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(232, 182)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(234, 40)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(150, 30)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Print Preview"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(159, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(72, 30)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'txtStartBal
        '
        Me.txtStartBal.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartBal.Location = New System.Drawing.Point(336, 11)
        Me.txtStartBal.Name = "txtStartBal"
        Me.txtStartBal.ReadOnly = True
        Me.txtStartBal.Size = New System.Drawing.Size(125, 30)
        Me.txtStartBal.TabIndex = 3
        Me.txtStartBal.Text = "0"
        Me.txtStartBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Start Balance"
        '
        'rbFullPay
        '
        Me.rbFullPay.AutoSize = True
        Me.rbFullPay.Checked = True
        Me.rbFullPay.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFullPay.Location = New System.Drawing.Point(119, 15)
        Me.rbFullPay.Name = "rbFullPay"
        Me.rbFullPay.Size = New System.Drawing.Size(108, 26)
        Me.rbFullPay.TabIndex = 0
        Me.rbFullPay.TabStop = True
        Me.rbFullPay.Text = "Full payment"
        Me.rbFullPay.UseVisualStyleBackColor = True
        '
        'rbSplPay
        '
        Me.rbSplPay.AutoSize = True
        Me.rbSplPay.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSplPay.Location = New System.Drawing.Point(271, 15)
        Me.rbSplPay.Name = "rbSplPay"
        Me.rbSplPay.Size = New System.Drawing.Size(114, 26)
        Me.rbSplPay.TabIndex = 1
        Me.rbSplPay.Text = "Split Payment"
        Me.rbSplPay.UseVisualStyleBackColor = True
        '
        'txtPayAmount
        '
        Me.txtPayAmount.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayAmount.Location = New System.Drawing.Point(115, 96)
        Me.txtPayAmount.Name = "txtPayAmount"
        Me.txtPayAmount.Size = New System.Drawing.Size(128, 30)
        Me.txtPayAmount.TabIndex = 6
        Me.txtPayAmount.Text = "0"
        Me.txtPayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Payment Amount"
        '
        'txtEndBal
        '
        Me.txtEndBal.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndBal.Location = New System.Drawing.Point(333, 96)
        Me.txtEndBal.Name = "txtEndBal"
        Me.txtEndBal.ReadOnly = True
        Me.txtEndBal.Size = New System.Drawing.Size(128, 30)
        Me.txtEndBal.TabIndex = 8
        Me.txtEndBal.Text = "0"
        Me.txtEndBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "End Balance"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbFullPay)
        Me.GroupBox1.Controls.Add(Me.rbSplPay)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 48)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbPOS)
        Me.GroupBox2.Controls.Add(Me.rbA4)
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 47)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Print Type"
        '
        'rbPOS
        '
        Me.rbPOS.AutoSize = True
        Me.rbPOS.Checked = True
        Me.rbPOS.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPOS.Location = New System.Drawing.Point(116, 15)
        Me.rbPOS.Name = "rbPOS"
        Me.rbPOS.Size = New System.Drawing.Size(88, 26)
        Me.rbPOS.TabIndex = 0
        Me.rbPOS.TabStop = True
        Me.rbPOS.Text = "POS Size"
        Me.rbPOS.UseVisualStyleBackColor = True
        '
        'rbA4
        '
        Me.rbA4.AutoSize = True
        Me.rbA4.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbA4.Location = New System.Drawing.Point(268, 15)
        Me.rbA4.Name = "rbA4"
        Me.rbA4.Size = New System.Drawing.Size(75, 26)
        Me.rbA4.TabIndex = 1
        Me.rbA4.Text = "A4 size"
        Me.rbA4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Paid Date"
        '
        'dtpPmtDt
        '
        Me.dtpPmtDt.CustomFormat = "dd/MMM/yyyy"
        Me.dtpPmtDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPmtDt.Location = New System.Drawing.Point(115, 11)
        Me.dtpPmtDt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpPmtDt.Name = "dtpPmtDt"
        Me.dtpPmtDt.Size = New System.Drawing.Size(128, 30)
        Me.dtpPmtDt.TabIndex = 1
        '
        'frm_sale_inv_printParm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(478, 236)
        Me.Controls.Add(Me.dtpPmtDt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEndBal)
        Me.Controls.Add(Me.txtPayAmount)
        Me.Controls.Add(Me.txtStartBal)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_sale_inv_printParm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Invoice Print and Histories"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtStartBal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbFullPay As RadioButton
    Friend WithEvents rbSplPay As RadioButton
    Friend WithEvents txtPayAmount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEndBal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbPOS As RadioButton
    Friend WithEvents rbA4 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpPmtDt As DateTimePicker
End Class
