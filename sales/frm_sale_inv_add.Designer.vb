<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sale_inv_add
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSavePrint = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInvNum = New System.Windows.Forms.TextBox()
        Me.cboSexcode = New System.Windows.Forms.ComboBox()
        Me.dtpInvDt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClinm = New System.Windows.Forms.TextBox()
        Me.txtcli_num = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtphoneNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMobilNum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDiscntAmt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtGrosamt = New System.Windows.Forms.TextBox()
        Me.txtNetAmt = New System.Windows.Forms.TextBox()
        Me.cboCurrency = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgvFilter = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.85938!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.14063!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSavePrint, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(447, 450)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(333, 37)
        Me.TableLayoutPanel1.TabIndex = 34
        '
        'btnSavePrint
        '
        Me.btnSavePrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSavePrint.Location = New System.Drawing.Point(3, 4)
        Me.btnSavePrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSavePrint.Name = "btnSavePrint"
        Me.btnSavePrint.Size = New System.Drawing.Size(129, 29)
        Me.btnSavePrint.TabIndex = 0
        Me.btnSavePrint.Text = "Save Print Invoice"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(248, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(79, 29)
        Me.Cancel_Button.TabIndex = 2
        Me.Cancel_Button.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(138, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(101, 29)
        Me.OK_Button.TabIndex = 1
        Me.OK_Button.Text = "Save Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(522, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 22)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Invoice #"
        '
        'txtInvNum
        '
        Me.txtInvNum.Enabled = False
        Me.txtInvNum.Location = New System.Drawing.Point(606, 11)
        Me.txtInvNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInvNum.Name = "txtInvNum"
        Me.txtInvNum.ReadOnly = True
        Me.txtInvNum.Size = New System.Drawing.Size(168, 30)
        Me.txtInvNum.TabIndex = 15
        '
        'cboSexcode
        '
        Me.cboSexcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexcode.FormattingEnabled = True
        Me.cboSexcode.Location = New System.Drawing.Point(103, 77)
        Me.cboSexcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSexcode.Name = "cboSexcode"
        Me.cboSexcode.Size = New System.Drawing.Size(190, 30)
        Me.cboSexcode.TabIndex = 5
        '
        'dtpInvDt
        '
        Me.dtpInvDt.CustomFormat = "dd/MMM/yyyy"
        Me.dtpInvDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInvDt.Location = New System.Drawing.Point(606, 44)
        Me.dtpInvDt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpInvDt.Name = "dtpInvDt"
        Me.dtpInvDt.Size = New System.Drawing.Size(168, 30)
        Me.dtpInvDt.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Client Name*"
        '
        'txtClinm
        '
        Me.txtClinm.Location = New System.Drawing.Point(103, 44)
        Me.txtClinm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtClinm.Name = "txtClinm"
        Me.txtClinm.Size = New System.Drawing.Size(407, 30)
        Me.txtClinm.TabIndex = 3
        '
        'txtcli_num
        '
        Me.txtcli_num.Enabled = False
        Me.txtcli_num.Location = New System.Drawing.Point(103, 11)
        Me.txtcli_num.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcli_num.Name = "txtcli_num"
        Me.txtcli_num.ReadOnly = True
        Me.txtcli_num.Size = New System.Drawing.Size(190, 30)
        Me.txtcli_num.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Client Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(522, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Invoice Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gender"
        '
        'txtphoneNum
        '
        Me.txtphoneNum.Location = New System.Drawing.Point(103, 111)
        Me.txtphoneNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtphoneNum.Name = "txtphoneNum"
        Me.txtphoneNum.Size = New System.Drawing.Size(190, 30)
        Me.txtphoneNum.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Phone number"
        '
        'txtMobilNum
        '
        Me.txtMobilNum.Location = New System.Drawing.Point(103, 145)
        Me.txtMobilNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMobilNum.Name = "txtMobilNum"
        Me.txtMobilNum.Size = New System.Drawing.Size(190, 30)
        Me.txtMobilNum.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 22)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Mobile Number"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(103, 178)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(407, 30)
        Me.txtMail.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 22)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Email"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(103, 212)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(407, 30)
        Me.txtAddress.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 22)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Address"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvItem)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 250)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(762, 197)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoice Details"
        '
        'dgvItem
        '
        Me.dgvItem.AllowDrop = True
        Me.dgvItem.AllowUserToAddRows = False
        Me.dgvItem.AllowUserToDeleteRows = False
        Me.dgvItem.AllowUserToOrderColumns = True
        Me.dgvItem.AllowUserToResizeColumns = False
        Me.dgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.qty, Me.unitprice, Me.total})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItem.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItem.Location = New System.Drawing.Point(3, 27)
        Me.dgvItem.MultiSelect = False
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.RowHeadersVisible = False
        Me.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItem.Size = New System.Drawing.Size(756, 166)
        Me.dgvItem.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'qty
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.qty.DefaultCellStyle = DataGridViewCellStyle2
        Me.qty.HeaderText = "QTY"
        Me.qty.Name = "qty"
        '
        'unitprice
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.unitprice.DefaultCellStyle = DataGridViewCellStyle3
        Me.unitprice.HeaderText = "Unit Price"
        Me.unitprice.Name = "unitprice"
        '
        'total
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.total.DefaultCellStyle = DataGridViewCellStyle4
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.Width = 120
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(522, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 22)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Gross AMT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(522, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 22)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Discount AMT"
        '
        'txtDiscntAmt
        '
        Me.txtDiscntAmt.Location = New System.Drawing.Point(606, 145)
        Me.txtDiscntAmt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDiscntAmt.Name = "txtDiscntAmt"
        Me.txtDiscntAmt.Size = New System.Drawing.Size(168, 30)
        Me.txtDiscntAmt.TabIndex = 23
        Me.txtDiscntAmt.Text = "0"
        Me.txtDiscntAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(522, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 22)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "VAT(%)"
        '
        'txtVAT
        '
        Me.txtVAT.Location = New System.Drawing.Point(606, 178)
        Me.txtVAT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(168, 30)
        Me.txtVAT.TabIndex = 25
        Me.txtVAT.Text = "0"
        Me.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(522, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 22)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Net AMT"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdd.Location = New System.Drawing.Point(526, 245)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 29)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "Add Item"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Red
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemove.Location = New System.Drawing.Point(654, 245)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(120, 29)
        Me.btnRemove.TabIndex = 33
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'txtGrosamt
        '
        Me.txtGrosamt.Enabled = False
        Me.txtGrosamt.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrosamt.Location = New System.Drawing.Point(606, 111)
        Me.txtGrosamt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGrosamt.Name = "txtGrosamt"
        Me.txtGrosamt.Size = New System.Drawing.Size(168, 30)
        Me.txtGrosamt.TabIndex = 21
        Me.txtGrosamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetAmt
        '
        Me.txtNetAmt.Enabled = False
        Me.txtNetAmt.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetAmt.Location = New System.Drawing.Point(606, 212)
        Me.txtNetAmt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNetAmt.Name = "txtNetAmt"
        Me.txtNetAmt.Size = New System.Drawing.Size(168, 30)
        Me.txtNetAmt.TabIndex = 27
        Me.txtNetAmt.Text = "0"
        Me.txtNetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboCurrency
        '
        Me.cboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurrency.FormattingEnabled = True
        Me.cboCurrency.Location = New System.Drawing.Point(606, 77)
        Me.cboCurrency.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCurrency.Name = "cboCurrency"
        Me.cboCurrency.Size = New System.Drawing.Size(168, 30)
        Me.cboCurrency.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(522, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 22)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Curency"
        '
        'dgvFilter
        '
        Me.dgvFilter.AllowDrop = True
        Me.dgvFilter.AllowUserToAddRows = False
        Me.dgvFilter.AllowUserToDeleteRows = False
        Me.dgvFilter.AllowUserToResizeColumns = False
        Me.dgvFilter.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvFilter.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFilter.ColumnHeadersVisible = False
        Me.dgvFilter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.Column5, Me.Column6, Me.DataGridViewTextBoxColumn8, Me.Column3, Me.Column4, Me.Column7})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFilter.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvFilter.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvFilter.Location = New System.Drawing.Point(18, 451)
        Me.dgvFilter.MultiSelect = False
        Me.dgvFilter.Name = "dgvFilter"
        Me.dgvFilter.ReadOnly = True
        Me.dgvFilter.RowHeadersVisible = False
        Me.dgvFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFilter.Size = New System.Drawing.Size(308, 39)
        Me.dgvFilter.TabIndex = 32
        Me.dgvFilter.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "Name"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column6
        '
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column6.HeaderText = "Sex"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn8.HeaderText = "Phone#"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Mobile#"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "EMail"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column7
        '
        Me.Column7.HeaderText = "Address"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 200
        '
        'frm_sale_inv_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(798, 493)
        Me.Controls.Add(Me.dgvFilter)
        Me.Controls.Add(Me.cboCurrency)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNetAmt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtVAT)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDiscntAmt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtGrosamt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMobilNum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtphoneNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpInvDt)
        Me.Controls.Add(Me.cboSexcode)
        Me.Controls.Add(Me.txtcli_num)
        Me.Controls.Add(Me.txtClinm)
        Me.Controls.Add(Me.txtInvNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Khmer OS Content", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_sale_inv_add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInvNum As TextBox
    Friend WithEvents cboSexcode As ComboBox
    Friend WithEvents dtpInvDt As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClinm As TextBox
    Friend WithEvents txtcli_num As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtphoneNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMobilNum As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvItem As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDiscntAmt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents txtGrosamt As TextBox
    Friend WithEvents txtNetAmt As TextBox
    Friend WithEvents cboCurrency As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dgvFilter As DataGridView
    Friend WithEvents btnSavePrint As Button
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents unitprice As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
