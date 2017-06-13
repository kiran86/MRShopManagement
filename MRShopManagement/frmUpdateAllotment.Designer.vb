<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdateAllotment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lnklblAAYClear = New System.Windows.Forms.LinkLabel()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.cmbxSugarUnit = New System.Windows.Forms.ComboBox()
        Me.txtbxSugarPricing = New System.Windows.Forms.TextBox()
        Me.txtbxSugarAllotment = New System.Windows.Forms.TextBox()
        Me.txtbxSugarStock = New System.Windows.Forms.TextBox()
        Me.chkbxAAYSugar = New System.Windows.Forms.CheckBox()
        Me.cmbxAttaUnit = New System.Windows.Forms.ComboBox()
        Me.txtbxAttaPricing = New System.Windows.Forms.TextBox()
        Me.txtbxAttaAllotment = New System.Windows.Forms.TextBox()
        Me.chkbxAAYAtta = New System.Windows.Forms.CheckBox()
        Me.chkbxAAYWheat = New System.Windows.Forms.CheckBox()
        Me.txtbxAttaStock = New System.Windows.Forms.TextBox()
        Me.cmbxWhtUnit = New System.Windows.Forms.ComboBox()
        Me.txtbxWhtPricing = New System.Windows.Forms.TextBox()
        Me.txtbxWhtAllotment = New System.Windows.Forms.TextBox()
        Me.txtbxWhtStock = New System.Windows.Forms.TextBox()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblRiceStock = New System.Windows.Forms.Label()
        Me.lblRiceAllotment = New System.Windows.Forms.Label()
        Me.lblRicePrice = New System.Windows.Forms.Label()
        Me.lblRiceUnit = New System.Windows.Forms.Label()
        Me.txtbxRiceStock = New System.Windows.Forms.TextBox()
        Me.txtbxRiceAllotment = New System.Windows.Forms.TextBox()
        Me.txtbxRicePricing = New System.Windows.Forms.TextBox()
        Me.cmbxRiceUnit = New System.Windows.Forms.ComboBox()
        Me.chkbxAAYRice = New System.Windows.Forms.CheckBox()
        Me.lnklblAAYUpdate = New System.Windows.Forms.LinkLabel()
        Me.grpbxCategory = New System.Windows.Forms.GroupBox()
        Me.rdobtnRKSYII = New System.Windows.Forms.RadioButton()
        Me.rdobtnRKSYI = New System.Windows.Forms.RadioButton()
        Me.rdobtnSPHH = New System.Windows.Forms.RadioButton()
        Me.rdobtnPHH = New System.Windows.Forms.RadioButton()
        Me.rdobtnAAY = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpbxCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lnklblAAYClear, 6, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAction, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbxSugarUnit, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxSugarPricing, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxSugarAllotment, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxSugarStock, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.chkbxAAYSugar, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbxAttaUnit, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxAttaPricing, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxAttaAllotment, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkbxAAYAtta, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkbxAAYWheat, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxAttaStock, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbxWhtUnit, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxWhtPricing, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxWhtAllotment, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxWhtStock, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblProducts, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCategory, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRiceStock, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRiceAllotment, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRicePrice, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRiceUnit, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxRiceStock, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxRiceAllotment, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxRicePricing, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbxRiceUnit, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkbxAAYRice, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lnklblAAYUpdate, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.grpbxCategory, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(679, 175)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lnklblAAYClear
        '
        Me.lnklblAAYClear.AutoSize = True
        Me.lnklblAAYClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnklblAAYClear.Location = New System.Drawing.Point(612, 102)
        Me.lnklblAAYClear.Margin = New System.Windows.Forms.Padding(0)
        Me.lnklblAAYClear.Name = "lnklblAAYClear"
        Me.TableLayoutPanel1.SetRowSpan(Me.lnklblAAYClear, 2)
        Me.lnklblAAYClear.Size = New System.Drawing.Size(64, 70)
        Me.lnklblAAYClear.TabIndex = 41
        Me.lnklblAAYClear.TabStop = True
        Me.lnklblAAYClear.Text = "Clear"
        Me.lnklblAAYClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAction.Location = New System.Drawing.Point(615, 6)
        Me.lblAction.Margin = New System.Windows.Forms.Padding(3)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(58, 24)
        Me.lblAction.TabIndex = 39
        Me.lblAction.Text = "Action"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbxSugarUnit
        '
        Me.cmbxSugarUnit.FormattingEnabled = True
        Me.cmbxSugarUnit.Items.AddRange(New Object() {"Head", "Family"})
        Me.cmbxSugarUnit.Location = New System.Drawing.Point(489, 138)
        Me.cmbxSugarUnit.Name = "cmbxSugarUnit"
        Me.cmbxSugarUnit.Size = New System.Drawing.Size(117, 24)
        Me.cmbxSugarUnit.TabIndex = 38
        '
        'txtbxSugarPricing
        '
        Me.txtbxSugarPricing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxSugarPricing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSugarPricing.Location = New System.Drawing.Point(380, 138)
        Me.txtbxSugarPricing.Name = "txtbxSugarPricing"
        Me.txtbxSugarPricing.Size = New System.Drawing.Size(100, 24)
        Me.txtbxSugarPricing.TabIndex = 37
        '
        'txtbxSugarAllotment
        '
        Me.txtbxSugarAllotment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxSugarAllotment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSugarAllotment.Location = New System.Drawing.Point(271, 138)
        Me.txtbxSugarAllotment.Name = "txtbxSugarAllotment"
        Me.txtbxSugarAllotment.Size = New System.Drawing.Size(100, 24)
        Me.txtbxSugarAllotment.TabIndex = 36
        '
        'txtbxSugarStock
        '
        Me.txtbxSugarStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxSugarStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSugarStock.Location = New System.Drawing.Point(162, 138)
        Me.txtbxSugarStock.Name = "txtbxSugarStock"
        Me.txtbxSugarStock.Size = New System.Drawing.Size(100, 24)
        Me.txtbxSugarStock.TabIndex = 35
        '
        'chkbxAAYSugar
        '
        Me.chkbxAAYSugar.AutoSize = True
        Me.chkbxAAYSugar.Checked = True
        Me.chkbxAAYSugar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxAAYSugar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbxAAYSugar.Location = New System.Drawing.Point(87, 138)
        Me.chkbxAAYSugar.Name = "chkbxAAYSugar"
        Me.chkbxAAYSugar.Size = New System.Drawing.Size(66, 31)
        Me.chkbxAAYSugar.TabIndex = 34
        Me.chkbxAAYSugar.Text = "Sugar"
        Me.chkbxAAYSugar.UseVisualStyleBackColor = True
        '
        'cmbxAttaUnit
        '
        Me.cmbxAttaUnit.FormattingEnabled = True
        Me.cmbxAttaUnit.Items.AddRange(New Object() {"Head", "Family"})
        Me.cmbxAttaUnit.Location = New System.Drawing.Point(489, 105)
        Me.cmbxAttaUnit.Name = "cmbxAttaUnit"
        Me.cmbxAttaUnit.Size = New System.Drawing.Size(117, 24)
        Me.cmbxAttaUnit.TabIndex = 33
        '
        'txtbxAttaPricing
        '
        Me.txtbxAttaPricing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxAttaPricing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAttaPricing.Location = New System.Drawing.Point(380, 105)
        Me.txtbxAttaPricing.Name = "txtbxAttaPricing"
        Me.txtbxAttaPricing.Size = New System.Drawing.Size(100, 24)
        Me.txtbxAttaPricing.TabIndex = 32
        '
        'txtbxAttaAllotment
        '
        Me.txtbxAttaAllotment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxAttaAllotment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAttaAllotment.Location = New System.Drawing.Point(271, 105)
        Me.txtbxAttaAllotment.Name = "txtbxAttaAllotment"
        Me.txtbxAttaAllotment.Size = New System.Drawing.Size(100, 24)
        Me.txtbxAttaAllotment.TabIndex = 31
        '
        'chkbxAAYAtta
        '
        Me.chkbxAAYAtta.AutoSize = True
        Me.chkbxAAYAtta.Checked = True
        Me.chkbxAAYAtta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxAAYAtta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbxAAYAtta.Location = New System.Drawing.Point(87, 105)
        Me.chkbxAAYAtta.Name = "chkbxAAYAtta"
        Me.chkbxAAYAtta.Size = New System.Drawing.Size(66, 24)
        Me.chkbxAAYAtta.TabIndex = 30
        Me.chkbxAAYAtta.Text = "Atta"
        Me.chkbxAAYAtta.UseVisualStyleBackColor = True
        '
        'chkbxAAYWheat
        '
        Me.chkbxAAYWheat.AutoSize = True
        Me.chkbxAAYWheat.Checked = True
        Me.chkbxAAYWheat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxAAYWheat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbxAAYWheat.Location = New System.Drawing.Point(87, 72)
        Me.chkbxAAYWheat.Name = "chkbxAAYWheat"
        Me.chkbxAAYWheat.Size = New System.Drawing.Size(66, 24)
        Me.chkbxAAYWheat.TabIndex = 29
        Me.chkbxAAYWheat.Text = "Wheat"
        Me.chkbxAAYWheat.UseVisualStyleBackColor = True
        '
        'txtbxAttaStock
        '
        Me.txtbxAttaStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxAttaStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAttaStock.Location = New System.Drawing.Point(162, 105)
        Me.txtbxAttaStock.Name = "txtbxAttaStock"
        Me.txtbxAttaStock.Size = New System.Drawing.Size(100, 24)
        Me.txtbxAttaStock.TabIndex = 27
        '
        'cmbxWhtUnit
        '
        Me.cmbxWhtUnit.FormattingEnabled = True
        Me.cmbxWhtUnit.Items.AddRange(New Object() {"Head", "Family"})
        Me.cmbxWhtUnit.Location = New System.Drawing.Point(489, 72)
        Me.cmbxWhtUnit.Name = "cmbxWhtUnit"
        Me.cmbxWhtUnit.Size = New System.Drawing.Size(117, 24)
        Me.cmbxWhtUnit.TabIndex = 24
        '
        'txtbxWhtPricing
        '
        Me.txtbxWhtPricing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxWhtPricing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxWhtPricing.Location = New System.Drawing.Point(380, 72)
        Me.txtbxWhtPricing.Name = "txtbxWhtPricing"
        Me.txtbxWhtPricing.Size = New System.Drawing.Size(100, 24)
        Me.txtbxWhtPricing.TabIndex = 23
        '
        'txtbxWhtAllotment
        '
        Me.txtbxWhtAllotment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxWhtAllotment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxWhtAllotment.Location = New System.Drawing.Point(271, 72)
        Me.txtbxWhtAllotment.Name = "txtbxWhtAllotment"
        Me.txtbxWhtAllotment.Size = New System.Drawing.Size(100, 24)
        Me.txtbxWhtAllotment.TabIndex = 22
        '
        'txtbxWhtStock
        '
        Me.txtbxWhtStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxWhtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxWhtStock.Location = New System.Drawing.Point(162, 72)
        Me.txtbxWhtStock.Name = "txtbxWhtStock"
        Me.txtbxWhtStock.Size = New System.Drawing.Size(100, 24)
        Me.txtbxWhtStock.TabIndex = 21
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProducts.Location = New System.Drawing.Point(87, 6)
        Me.lblProducts.Margin = New System.Windows.Forms.Padding(3)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(66, 24)
        Me.lblProducts.TabIndex = 20
        Me.lblProducts.Text = "Products"
        Me.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCategory.Location = New System.Drawing.Point(6, 6)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(3)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(72, 24)
        Me.lblCategory.TabIndex = 0
        Me.lblCategory.Text = "Category"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRiceStock
        '
        Me.lblRiceStock.AutoSize = True
        Me.lblRiceStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRiceStock.Location = New System.Drawing.Point(162, 6)
        Me.lblRiceStock.Margin = New System.Windows.Forms.Padding(3)
        Me.lblRiceStock.Name = "lblRiceStock"
        Me.lblRiceStock.Size = New System.Drawing.Size(100, 24)
        Me.lblRiceStock.TabIndex = 2
        Me.lblRiceStock.Text = "Stock"
        Me.lblRiceStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRiceAllotment
        '
        Me.lblRiceAllotment.AutoSize = True
        Me.lblRiceAllotment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRiceAllotment.Location = New System.Drawing.Point(271, 6)
        Me.lblRiceAllotment.Margin = New System.Windows.Forms.Padding(3)
        Me.lblRiceAllotment.Name = "lblRiceAllotment"
        Me.lblRiceAllotment.Size = New System.Drawing.Size(100, 24)
        Me.lblRiceAllotment.TabIndex = 3
        Me.lblRiceAllotment.Text = "Allotment"
        Me.lblRiceAllotment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRicePrice
        '
        Me.lblRicePrice.AutoSize = True
        Me.lblRicePrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRicePrice.Location = New System.Drawing.Point(380, 6)
        Me.lblRicePrice.Margin = New System.Windows.Forms.Padding(3)
        Me.lblRicePrice.Name = "lblRicePrice"
        Me.lblRicePrice.Size = New System.Drawing.Size(100, 24)
        Me.lblRicePrice.TabIndex = 4
        Me.lblRicePrice.Text = "Price"
        Me.lblRicePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRiceUnit
        '
        Me.lblRiceUnit.AutoSize = True
        Me.lblRiceUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRiceUnit.Location = New System.Drawing.Point(489, 6)
        Me.lblRiceUnit.Margin = New System.Windows.Forms.Padding(3)
        Me.lblRiceUnit.Name = "lblRiceUnit"
        Me.lblRiceUnit.Size = New System.Drawing.Size(117, 24)
        Me.lblRiceUnit.TabIndex = 5
        Me.lblRiceUnit.Text = "Unit"
        Me.lblRiceUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbxRiceStock
        '
        Me.txtbxRiceStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbxRiceStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRiceStock.Location = New System.Drawing.Point(162, 39)
        Me.txtbxRiceStock.Name = "txtbxRiceStock"
        Me.txtbxRiceStock.Size = New System.Drawing.Size(100, 24)
        Me.txtbxRiceStock.TabIndex = 7
        '
        'txtbxRiceAllotment
        '
        Me.txtbxRiceAllotment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxRiceAllotment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRiceAllotment.Location = New System.Drawing.Point(271, 39)
        Me.txtbxRiceAllotment.Name = "txtbxRiceAllotment"
        Me.txtbxRiceAllotment.Size = New System.Drawing.Size(100, 24)
        Me.txtbxRiceAllotment.TabIndex = 8
        '
        'txtbxRicePricing
        '
        Me.txtbxRicePricing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxRicePricing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRicePricing.Location = New System.Drawing.Point(380, 39)
        Me.txtbxRicePricing.Name = "txtbxRicePricing"
        Me.txtbxRicePricing.Size = New System.Drawing.Size(100, 24)
        Me.txtbxRicePricing.TabIndex = 9
        '
        'cmbxRiceUnit
        '
        Me.cmbxRiceUnit.FormattingEnabled = True
        Me.cmbxRiceUnit.Items.AddRange(New Object() {"Head", "Family"})
        Me.cmbxRiceUnit.Location = New System.Drawing.Point(489, 39)
        Me.cmbxRiceUnit.Name = "cmbxRiceUnit"
        Me.cmbxRiceUnit.Size = New System.Drawing.Size(117, 24)
        Me.cmbxRiceUnit.TabIndex = 10
        '
        'chkbxAAYRice
        '
        Me.chkbxAAYRice.AutoSize = True
        Me.chkbxAAYRice.Checked = True
        Me.chkbxAAYRice.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxAAYRice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbxAAYRice.Location = New System.Drawing.Point(87, 39)
        Me.chkbxAAYRice.Name = "chkbxAAYRice"
        Me.chkbxAAYRice.Size = New System.Drawing.Size(66, 24)
        Me.chkbxAAYRice.TabIndex = 28
        Me.chkbxAAYRice.Text = "Rice"
        Me.chkbxAAYRice.UseVisualStyleBackColor = True
        '
        'lnklblAAYUpdate
        '
        Me.lnklblAAYUpdate.AutoSize = True
        Me.lnklblAAYUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnklblAAYUpdate.Location = New System.Drawing.Point(612, 36)
        Me.lnklblAAYUpdate.Margin = New System.Windows.Forms.Padding(0)
        Me.lnklblAAYUpdate.Name = "lnklblAAYUpdate"
        Me.TableLayoutPanel1.SetRowSpan(Me.lnklblAAYUpdate, 2)
        Me.lnklblAAYUpdate.Size = New System.Drawing.Size(64, 63)
        Me.lnklblAAYUpdate.TabIndex = 40
        Me.lnklblAAYUpdate.TabStop = True
        Me.lnklblAAYUpdate.Text = "Update"
        Me.lnklblAAYUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpbxCategory
        '
        Me.grpbxCategory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpbxCategory.AutoSize = True
        Me.grpbxCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpbxCategory.Controls.Add(Me.rdobtnRKSYII)
        Me.grpbxCategory.Controls.Add(Me.rdobtnRKSYI)
        Me.grpbxCategory.Controls.Add(Me.rdobtnSPHH)
        Me.grpbxCategory.Controls.Add(Me.rdobtnPHH)
        Me.grpbxCategory.Controls.Add(Me.rdobtnAAY)
        Me.grpbxCategory.Location = New System.Drawing.Point(3, 36)
        Me.grpbxCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.grpbxCategory.Name = "grpbxCategory"
        Me.grpbxCategory.Padding = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.SetRowSpan(Me.grpbxCategory, 4)
        Me.grpbxCategory.Size = New System.Drawing.Size(78, 136)
        Me.grpbxCategory.TabIndex = 42
        Me.grpbxCategory.TabStop = False
        '
        'rdobtnRKSYII
        '
        Me.rdobtnRKSYII.AutoSize = True
        Me.rdobtnRKSYII.Location = New System.Drawing.Point(3, 107)
        Me.rdobtnRKSYII.Name = "rdobtnRKSYII"
        Me.rdobtnRKSYII.Size = New System.Drawing.Size(72, 20)
        Me.rdobtnRKSYII.TabIndex = 4
        Me.rdobtnRKSYII.TabStop = True
        Me.rdobtnRKSYII.Text = "RKSY-II"
        Me.rdobtnRKSYII.UseVisualStyleBackColor = True
        '
        'rdobtnRKSYI
        '
        Me.rdobtnRKSYI.AutoSize = True
        Me.rdobtnRKSYI.Location = New System.Drawing.Point(3, 81)
        Me.rdobtnRKSYI.Name = "rdobtnRKSYI"
        Me.rdobtnRKSYI.Size = New System.Drawing.Size(69, 20)
        Me.rdobtnRKSYI.TabIndex = 3
        Me.rdobtnRKSYI.TabStop = True
        Me.rdobtnRKSYI.Text = "RKSY-I"
        Me.rdobtnRKSYI.UseVisualStyleBackColor = True
        '
        'rdobtnSPHH
        '
        Me.rdobtnSPHH.AutoSize = True
        Me.rdobtnSPHH.Location = New System.Drawing.Point(3, 55)
        Me.rdobtnSPHH.Name = "rdobtnSPHH"
        Me.rdobtnSPHH.Size = New System.Drawing.Size(64, 20)
        Me.rdobtnSPHH.TabIndex = 2
        Me.rdobtnSPHH.TabStop = True
        Me.rdobtnSPHH.Text = "SPHH"
        Me.rdobtnSPHH.UseVisualStyleBackColor = True
        '
        'rdobtnPHH
        '
        Me.rdobtnPHH.AutoSize = True
        Me.rdobtnPHH.Location = New System.Drawing.Point(3, 29)
        Me.rdobtnPHH.Name = "rdobtnPHH"
        Me.rdobtnPHH.Size = New System.Drawing.Size(55, 20)
        Me.rdobtnPHH.TabIndex = 1
        Me.rdobtnPHH.TabStop = True
        Me.rdobtnPHH.Text = "PHH"
        Me.rdobtnPHH.UseVisualStyleBackColor = True
        '
        'rdobtnAAY
        '
        Me.rdobtnAAY.AutoSize = True
        Me.rdobtnAAY.Location = New System.Drawing.Point(3, 3)
        Me.rdobtnAAY.Name = "rdobtnAAY"
        Me.rdobtnAAY.Size = New System.Drawing.Size(53, 20)
        Me.rdobtnAAY.TabIndex = 0
        Me.rdobtnAAY.TabStop = True
        Me.rdobtnAAY.Text = "AAY"
        Me.rdobtnAAY.UseVisualStyleBackColor = True
        '
        'frmUpdateAllotment
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(679, 175)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUpdateAllotment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stocks and Allotment"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grpbxCategory.ResumeLayout(False)
        Me.grpbxCategory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblRiceStock As Label
    Friend WithEvents lblRiceAllotment As Label
    Friend WithEvents lblRicePrice As Label
    Friend WithEvents txtbxRiceStock As TextBox
    Friend WithEvents txtbxRiceAllotment As TextBox
    Friend WithEvents txtbxRicePricing As TextBox
    Friend WithEvents lblProducts As Label
    Friend WithEvents lblRiceUnit As Label
    Friend WithEvents cmbxRiceUnit As ComboBox
    Friend WithEvents cmbxWhtUnit As ComboBox
    Friend WithEvents txtbxWhtPricing As TextBox
    Friend WithEvents txtbxWhtAllotment As TextBox
    Friend WithEvents txtbxWhtStock As TextBox
    Friend WithEvents txtbxAttaStock As TextBox
    Friend WithEvents chkbxAAYRice As CheckBox
    Friend WithEvents cmbxAttaUnit As ComboBox
    Friend WithEvents txtbxAttaPricing As TextBox
    Friend WithEvents txtbxAttaAllotment As TextBox
    Friend WithEvents chkbxAAYAtta As CheckBox
    Friend WithEvents chkbxAAYWheat As CheckBox
    Friend WithEvents chkbxAAYSugar As CheckBox
    Friend WithEvents cmbxSugarUnit As ComboBox
    Friend WithEvents txtbxSugarPricing As TextBox
    Friend WithEvents txtbxSugarAllotment As TextBox
    Friend WithEvents txtbxSugarStock As TextBox
    Friend WithEvents lnklblAAYClear As LinkLabel
    Friend WithEvents lblAction As Label
    Friend WithEvents lnklblAAYUpdate As LinkLabel
    Friend WithEvents grpbxCategory As GroupBox
    Friend WithEvents rdobtnRKSYII As RadioButton
    Friend WithEvents rdobtnRKSYI As RadioButton
    Friend WithEvents rdobtnSPHH As RadioButton
    Friend WithEvents rdobtnPHH As RadioButton
    Friend WithEvents rdobtnAAY As RadioButton
End Class
