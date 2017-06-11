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
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblRiceStock = New System.Windows.Forms.Label()
        Me.lblRiceAllotment = New System.Windows.Forms.Label()
        Me.lblRicePrice = New System.Windows.Forms.Label()
        Me.lblAAY = New System.Windows.Forms.Label()
        Me.txtbxAAYRiceStock = New System.Windows.Forms.TextBox()
        Me.txtbxRiceAllot = New System.Windows.Forms.TextBox()
        Me.txtbxRicePrice = New System.Windows.Forms.TextBox()
        Me.cmbxRiceUnit = New System.Windows.Forms.ComboBox()
        Me.lblRiceUnit = New System.Windows.Forms.Label()
        Me.txtbxWhtStock = New System.Windows.Forms.TextBox()
        Me.txtbxWhtAllot = New System.Windows.Forms.TextBox()
        Me.txtbxWhtPrice = New System.Windows.Forms.TextBox()
        Me.cmbxWhtUnit = New System.Windows.Forms.ComboBox()
        Me.txtbxAttaStock = New System.Windows.Forms.TextBox()
        Me.chkbxRice = New System.Windows.Forms.CheckBox()
        Me.chkbxWheat = New System.Windows.Forms.CheckBox()
        Me.chkbxAtta = New System.Windows.Forms.CheckBox()
        Me.txtbxAttaAllot = New System.Windows.Forms.TextBox()
        Me.txtbxAttaPrice = New System.Windows.Forms.TextBox()
        Me.cmbxAttaUnit = New System.Windows.Forms.ComboBox()
        Me.chkbxSugar = New System.Windows.Forms.CheckBox()
        Me.txtbxSugarStock = New System.Windows.Forms.TextBox()
        Me.txtbxSugarAllot = New System.Windows.Forms.TextBox()
        Me.txtbxAAYSugarPrice = New System.Windows.Forms.TextBox()
        Me.cmbxAAYSugarUnit = New System.Windows.Forms.ComboBox()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.lnklblAAYUpdate = New System.Windows.Forms.LinkLabel()
        Me.lnklblAAYClear = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox2, 5, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox6, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox5, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox2, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel1, 6, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lnklblAAYClear, 6, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAction, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbxAAYSugarUnit, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxAAYSugarPrice, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxSugarAllot, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxSugarStock, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.chkbxSugar, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbxAttaUnit, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxAttaPrice, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxAttaAllot, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkbxAtta, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkbxWheat, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxAttaStock, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbxWhtUnit, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxWhtPrice, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxWhtAllot, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxWhtStock, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblProducts, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCategory, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRiceStock, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRiceAllotment, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRicePrice, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRiceUnit, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAAY, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxAAYRiceStock, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxRiceAllot, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxRicePrice, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbxRiceUnit, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkbxRice, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lnklblAAYUpdate, 6, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(679, 522)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProducts.Location = New System.Drawing.Point(78, 6)
        Me.lblProducts.Margin = New System.Windows.Forms.Padding(3)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(66, 16)
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
        Me.lblCategory.Size = New System.Drawing.Size(63, 16)
        Me.lblCategory.TabIndex = 0
        Me.lblCategory.Text = "Category"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRiceStock
        '
        Me.lblRiceStock.AutoSize = True
        Me.lblRiceStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRiceStock.Location = New System.Drawing.Point(153, 6)
        Me.lblRiceStock.Margin = New System.Windows.Forms.Padding(3)
        Me.lblRiceStock.Name = "lblRiceStock"
        Me.lblRiceStock.Size = New System.Drawing.Size(94, 16)
        Me.lblRiceStock.TabIndex = 2
        Me.lblRiceStock.Text = "Stock"
        Me.lblRiceStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRiceAllotment
        '
        Me.lblRiceAllotment.AutoSize = True
        Me.lblRiceAllotment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRiceAllotment.Location = New System.Drawing.Point(256, 6)
        Me.lblRiceAllotment.Margin = New System.Windows.Forms.Padding(3)
        Me.lblRiceAllotment.Name = "lblRiceAllotment"
        Me.lblRiceAllotment.Size = New System.Drawing.Size(94, 16)
        Me.lblRiceAllotment.TabIndex = 3
        Me.lblRiceAllotment.Text = "Allotment"
        Me.lblRiceAllotment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRicePrice
        '
        Me.lblRicePrice.AutoSize = True
        Me.lblRicePrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRicePrice.Location = New System.Drawing.Point(359, 6)
        Me.lblRicePrice.Margin = New System.Windows.Forms.Padding(3)
        Me.lblRicePrice.Name = "lblRicePrice"
        Me.lblRicePrice.Size = New System.Drawing.Size(94, 16)
        Me.lblRicePrice.TabIndex = 4
        Me.lblRicePrice.Text = "Price"
        Me.lblRicePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAAY
        '
        Me.lblAAY.AutoSize = True
        Me.lblAAY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAAY.Location = New System.Drawing.Point(3, 28)
        Me.lblAAY.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAAY.Name = "lblAAY"
        Me.TableLayoutPanel1.SetRowSpan(Me.lblAAY, 4)
        Me.lblAAY.Size = New System.Drawing.Size(69, 113)
        Me.lblAAY.TabIndex = 6
        Me.lblAAY.Text = "AAY"
        Me.lblAAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbxAAYRiceStock
        '
        Me.txtbxAAYRiceStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbxAAYRiceStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAAYRiceStock.Location = New System.Drawing.Point(150, 28)
        Me.txtbxAAYRiceStock.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxAAYRiceStock.Name = "txtbxAAYRiceStock"
        Me.txtbxAAYRiceStock.Size = New System.Drawing.Size(100, 24)
        Me.txtbxAAYRiceStock.TabIndex = 7
        '
        'txtbxRiceAllot
        '
        Me.txtbxRiceAllot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxRiceAllot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRiceAllot.Location = New System.Drawing.Point(253, 28)
        Me.txtbxRiceAllot.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxRiceAllot.Name = "txtbxRiceAllot"
        Me.txtbxRiceAllot.Size = New System.Drawing.Size(100, 24)
        Me.txtbxRiceAllot.TabIndex = 8
        '
        'txtbxRicePrice
        '
        Me.txtbxRicePrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxRicePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRicePrice.Location = New System.Drawing.Point(356, 28)
        Me.txtbxRicePrice.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxRicePrice.Name = "txtbxRicePrice"
        Me.txtbxRicePrice.Size = New System.Drawing.Size(100, 24)
        Me.txtbxRicePrice.TabIndex = 9
        '
        'cmbxRiceUnit
        '
        Me.cmbxRiceUnit.FormattingEnabled = True
        Me.cmbxRiceUnit.Items.AddRange(New Object() {"Head", "Family"})
        Me.cmbxRiceUnit.Location = New System.Drawing.Point(459, 28)
        Me.cmbxRiceUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.cmbxRiceUnit.Name = "cmbxRiceUnit"
        Me.cmbxRiceUnit.Size = New System.Drawing.Size(117, 24)
        Me.cmbxRiceUnit.TabIndex = 10
        '
        'lblRiceUnit
        '
        Me.lblRiceUnit.AutoSize = True
        Me.lblRiceUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRiceUnit.Location = New System.Drawing.Point(462, 6)
        Me.lblRiceUnit.Margin = New System.Windows.Forms.Padding(3)
        Me.lblRiceUnit.Name = "lblRiceUnit"
        Me.lblRiceUnit.Size = New System.Drawing.Size(111, 16)
        Me.lblRiceUnit.TabIndex = 5
        Me.lblRiceUnit.Text = "Unit"
        Me.lblRiceUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbxWhtStock
        '
        Me.txtbxWhtStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxWhtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxWhtStock.Location = New System.Drawing.Point(150, 57)
        Me.txtbxWhtStock.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxWhtStock.Name = "txtbxWhtStock"
        Me.txtbxWhtStock.Size = New System.Drawing.Size(100, 24)
        Me.txtbxWhtStock.TabIndex = 21
        '
        'txtbxWhtAllot
        '
        Me.txtbxWhtAllot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxWhtAllot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxWhtAllot.Location = New System.Drawing.Point(253, 57)
        Me.txtbxWhtAllot.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxWhtAllot.Name = "txtbxWhtAllot"
        Me.txtbxWhtAllot.Size = New System.Drawing.Size(100, 24)
        Me.txtbxWhtAllot.TabIndex = 22
        '
        'txtbxWhtPrice
        '
        Me.txtbxWhtPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxWhtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxWhtPrice.Location = New System.Drawing.Point(356, 57)
        Me.txtbxWhtPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxWhtPrice.Name = "txtbxWhtPrice"
        Me.txtbxWhtPrice.Size = New System.Drawing.Size(100, 24)
        Me.txtbxWhtPrice.TabIndex = 23
        '
        'cmbxWhtUnit
        '
        Me.cmbxWhtUnit.FormattingEnabled = True
        Me.cmbxWhtUnit.Items.AddRange(New Object() {"Head", "Family"})
        Me.cmbxWhtUnit.Location = New System.Drawing.Point(459, 57)
        Me.cmbxWhtUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.cmbxWhtUnit.Name = "cmbxWhtUnit"
        Me.cmbxWhtUnit.Size = New System.Drawing.Size(117, 24)
        Me.cmbxWhtUnit.TabIndex = 24
        '
        'txtbxAttaStock
        '
        Me.txtbxAttaStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxAttaStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAttaStock.Location = New System.Drawing.Point(150, 86)
        Me.txtbxAttaStock.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxAttaStock.Name = "txtbxAttaStock"
        Me.txtbxAttaStock.Size = New System.Drawing.Size(100, 24)
        Me.txtbxAttaStock.TabIndex = 27
        '
        'chkbxRice
        '
        Me.chkbxRice.AutoSize = True
        Me.chkbxRice.Checked = True
        Me.chkbxRice.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxRice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbxRice.Location = New System.Drawing.Point(78, 31)
        Me.chkbxRice.Name = "chkbxRice"
        Me.chkbxRice.Size = New System.Drawing.Size(66, 20)
        Me.chkbxRice.TabIndex = 28
        Me.chkbxRice.Text = "Rice"
        Me.chkbxRice.UseVisualStyleBackColor = True
        '
        'chkbxWheat
        '
        Me.chkbxWheat.AutoSize = True
        Me.chkbxWheat.Checked = True
        Me.chkbxWheat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxWheat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbxWheat.Location = New System.Drawing.Point(78, 60)
        Me.chkbxWheat.Name = "chkbxWheat"
        Me.chkbxWheat.Size = New System.Drawing.Size(66, 20)
        Me.chkbxWheat.TabIndex = 29
        Me.chkbxWheat.Text = "Wheat"
        Me.chkbxWheat.UseVisualStyleBackColor = True
        '
        'chkbxAtta
        '
        Me.chkbxAtta.AutoSize = True
        Me.chkbxAtta.Checked = True
        Me.chkbxAtta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxAtta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbxAtta.Location = New System.Drawing.Point(78, 89)
        Me.chkbxAtta.Name = "chkbxAtta"
        Me.chkbxAtta.Size = New System.Drawing.Size(66, 20)
        Me.chkbxAtta.TabIndex = 30
        Me.chkbxAtta.Text = "Atta"
        Me.chkbxAtta.UseVisualStyleBackColor = True
        '
        'txtbxAttaAllot
        '
        Me.txtbxAttaAllot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxAttaAllot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAttaAllot.Location = New System.Drawing.Point(253, 86)
        Me.txtbxAttaAllot.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxAttaAllot.Name = "txtbxAttaAllot"
        Me.txtbxAttaAllot.Size = New System.Drawing.Size(100, 24)
        Me.txtbxAttaAllot.TabIndex = 31
        '
        'txtbxAttaPrice
        '
        Me.txtbxAttaPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxAttaPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAttaPrice.Location = New System.Drawing.Point(356, 86)
        Me.txtbxAttaPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxAttaPrice.Name = "txtbxAttaPrice"
        Me.txtbxAttaPrice.Size = New System.Drawing.Size(100, 24)
        Me.txtbxAttaPrice.TabIndex = 32
        '
        'cmbxAttaUnit
        '
        Me.cmbxAttaUnit.FormattingEnabled = True
        Me.cmbxAttaUnit.Items.AddRange(New Object() {"Head", "Family"})
        Me.cmbxAttaUnit.Location = New System.Drawing.Point(459, 86)
        Me.cmbxAttaUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.cmbxAttaUnit.Name = "cmbxAttaUnit"
        Me.cmbxAttaUnit.Size = New System.Drawing.Size(117, 24)
        Me.cmbxAttaUnit.TabIndex = 33
        '
        'chkbxSugar
        '
        Me.chkbxSugar.AutoSize = True
        Me.chkbxSugar.Checked = True
        Me.chkbxSugar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxSugar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkbxSugar.Location = New System.Drawing.Point(78, 118)
        Me.chkbxSugar.Name = "chkbxSugar"
        Me.chkbxSugar.Size = New System.Drawing.Size(66, 20)
        Me.chkbxSugar.TabIndex = 34
        Me.chkbxSugar.Text = "Sugar"
        Me.chkbxSugar.UseVisualStyleBackColor = True
        '
        'txtbxSugarStock
        '
        Me.txtbxSugarStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxSugarStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSugarStock.Location = New System.Drawing.Point(150, 115)
        Me.txtbxSugarStock.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxSugarStock.Name = "txtbxSugarStock"
        Me.txtbxSugarStock.Size = New System.Drawing.Size(100, 24)
        Me.txtbxSugarStock.TabIndex = 35
        '
        'txtbxSugarAllot
        '
        Me.txtbxSugarAllot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxSugarAllot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSugarAllot.Location = New System.Drawing.Point(253, 115)
        Me.txtbxSugarAllot.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxSugarAllot.Name = "txtbxSugarAllot"
        Me.txtbxSugarAllot.Size = New System.Drawing.Size(100, 24)
        Me.txtbxSugarAllot.TabIndex = 36
        '
        'txtbxAAYSugarPrice
        '
        Me.txtbxAAYSugarPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxAAYSugarPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAAYSugarPrice.Location = New System.Drawing.Point(356, 115)
        Me.txtbxAAYSugarPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxAAYSugarPrice.Name = "txtbxAAYSugarPrice"
        Me.txtbxAAYSugarPrice.Size = New System.Drawing.Size(100, 24)
        Me.txtbxAAYSugarPrice.TabIndex = 37
        '
        'cmbxAAYSugarUnit
        '
        Me.cmbxAAYSugarUnit.FormattingEnabled = True
        Me.cmbxAAYSugarUnit.Items.AddRange(New Object() {"Head", "Family"})
        Me.cmbxAAYSugarUnit.Location = New System.Drawing.Point(459, 115)
        Me.cmbxAAYSugarUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.cmbxAAYSugarUnit.Name = "cmbxAAYSugarUnit"
        Me.cmbxAAYSugarUnit.Size = New System.Drawing.Size(117, 24)
        Me.cmbxAAYSugarUnit.TabIndex = 38
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAction.Location = New System.Drawing.Point(582, 6)
        Me.lblAction.Margin = New System.Windows.Forms.Padding(3)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(91, 16)
        Me.lblAction.TabIndex = 39
        Me.lblAction.Text = "Action"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnklblAAYUpdate
        '
        Me.lnklblAAYUpdate.AutoSize = True
        Me.lnklblAAYUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnklblAAYUpdate.Location = New System.Drawing.Point(579, 28)
        Me.lnklblAAYUpdate.Margin = New System.Windows.Forms.Padding(0)
        Me.lnklblAAYUpdate.Name = "lnklblAAYUpdate"
        Me.TableLayoutPanel1.SetRowSpan(Me.lnklblAAYUpdate, 2)
        Me.lnklblAAYUpdate.Size = New System.Drawing.Size(97, 55)
        Me.lnklblAAYUpdate.TabIndex = 40
        Me.lnklblAAYUpdate.TabStop = True
        Me.lnklblAAYUpdate.Text = "Update"
        Me.lnklblAAYUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnklblAAYClear
        '
        Me.lnklblAAYClear.AutoSize = True
        Me.lnklblAAYClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnklblAAYClear.Location = New System.Drawing.Point(579, 86)
        Me.lnklblAAYClear.Margin = New System.Windows.Forms.Padding(0)
        Me.lnklblAAYClear.Name = "lnklblAAYClear"
        Me.TableLayoutPanel1.SetRowSpan(Me.lnklblAAYClear, 2)
        Me.lnklblAAYClear.Size = New System.Drawing.Size(97, 55)
        Me.lnklblAAYClear.TabIndex = 41
        Me.lnklblAAYClear.TabStop = True
        Me.lnklblAAYClear.Text = "Clear"
        Me.lnklblAAYClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label1, 4)
        Me.Label1.Size = New System.Drawing.Size(69, 375)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "AAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox1.Location = New System.Drawing.Point(78, 147)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(66, 20)
        Me.CheckBox1.TabIndex = 43
        Me.CheckBox1.Text = "Rice"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(150, 144)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 24)
        Me.TextBox1.TabIndex = 44
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(253, 144)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 24)
        Me.TextBox2.TabIndex = 45
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(356, 144)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 24)
        Me.TextBox3.TabIndex = 46
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Head", "Family"})
        Me.ComboBox1.Location = New System.Drawing.Point(459, 144)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(117, 24)
        Me.ComboBox1.TabIndex = 47
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel1.Location = New System.Drawing.Point(579, 144)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.TableLayoutPanel1.SetRowSpan(Me.LinkLabel1, 2)
        Me.LinkLabel1.Size = New System.Drawing.Size(97, 55)
        Me.LinkLabel1.TabIndex = 48
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Update"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox2.Location = New System.Drawing.Point(78, 176)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(66, 20)
        Me.CheckBox2.TabIndex = 49
        Me.CheckBox2.Text = "Wheat"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(150, 173)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 24)
        Me.TextBox4.TabIndex = 50
        '
        'TextBox5
        '
        Me.TextBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(253, 173)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 24)
        Me.TextBox5.TabIndex = 51
        '
        'TextBox6
        '
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(356, 173)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 24)
        Me.TextBox6.TabIndex = 52
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Head", "Family"})
        Me.ComboBox2.Location = New System.Drawing.Point(459, 173)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(117, 24)
        Me.ComboBox2.TabIndex = 53
        '
        'frmUpdateAllotment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 522)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUpdateAllotment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stocks and Allotment"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblRiceStock As Label
    Friend WithEvents lblRiceAllotment As Label
    Friend WithEvents lblRicePrice As Label
    Friend WithEvents lblAAY As Label
    Friend WithEvents txtbxAAYRiceStock As TextBox
    Friend WithEvents txtbxRiceAllot As TextBox
    Friend WithEvents txtbxRicePrice As TextBox
    Friend WithEvents lblProducts As Label
    Friend WithEvents lblRiceUnit As Label
    Friend WithEvents cmbxRiceUnit As ComboBox
    Friend WithEvents cmbxWhtUnit As ComboBox
    Friend WithEvents txtbxWhtPrice As TextBox
    Friend WithEvents txtbxWhtAllot As TextBox
    Friend WithEvents txtbxWhtStock As TextBox
    Friend WithEvents txtbxAttaStock As TextBox
    Friend WithEvents chkbxRice As CheckBox
    Friend WithEvents cmbxAttaUnit As ComboBox
    Friend WithEvents txtbxAttaPrice As TextBox
    Friend WithEvents txtbxAttaAllot As TextBox
    Friend WithEvents chkbxAtta As CheckBox
    Friend WithEvents chkbxWheat As CheckBox
    Friend WithEvents chkbxSugar As CheckBox
    Friend WithEvents cmbxAAYSugarUnit As ComboBox
    Friend WithEvents txtbxAAYSugarPrice As TextBox
    Friend WithEvents txtbxSugarAllot As TextBox
    Friend WithEvents txtbxSugarStock As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lnklblAAYClear As LinkLabel
    Friend WithEvents lblAction As Label
    Friend WithEvents lnklblAAYUpdate As LinkLabel
End Class
