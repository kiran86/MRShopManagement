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
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblRiceStock = New System.Windows.Forms.Label()
        Me.lblRiceAllotment = New System.Windows.Forms.Label()
        Me.lblRicePrice = New System.Windows.Forms.Label()
        Me.lblRiceUnit = New System.Windows.Forms.Label()
        Me.lblRice = New System.Windows.Forms.Label()
        Me.lblAAY = New System.Windows.Forms.Label()
        Me.txtbxRiceStock = New System.Windows.Forms.TextBox()
        Me.txtbxRiceAllot = New System.Windows.Forms.TextBox()
        Me.txtbxRicePrice = New System.Windows.Forms.TextBox()
        Me.cmbxRiceUnit = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel1.ColumnCount = 12
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblProducts, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCategory, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRiceStock, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRiceAllotment, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRicePrice, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRiceUnit, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRice, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAAY, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxRiceStock, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxRiceAllot, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxRicePrice, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbxRiceUnit, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 522)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.lblRiceStock.Location = New System.Drawing.Point(148, 6)
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
        Me.lblRiceAllotment.Location = New System.Drawing.Point(251, 6)
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
        Me.lblRicePrice.Location = New System.Drawing.Point(354, 6)
        Me.lblRicePrice.Margin = New System.Windows.Forms.Padding(3)
        Me.lblRicePrice.Name = "lblRicePrice"
        Me.lblRicePrice.Size = New System.Drawing.Size(94, 16)
        Me.lblRicePrice.TabIndex = 4
        Me.lblRicePrice.Text = "Price"
        Me.lblRicePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRiceUnit
        '
        Me.lblRiceUnit.AutoSize = True
        Me.lblRiceUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRiceUnit.Location = New System.Drawing.Point(457, 6)
        Me.lblRiceUnit.Margin = New System.Windows.Forms.Padding(3)
        Me.lblRiceUnit.Name = "lblRiceUnit"
        Me.lblRiceUnit.Size = New System.Drawing.Size(115, 16)
        Me.lblRiceUnit.TabIndex = 5
        Me.lblRiceUnit.Text = "Unit"
        Me.lblRiceUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRice
        '
        Me.lblRice.AutoSize = True
        Me.lblRice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRice.Location = New System.Drawing.Point(75, 28)
        Me.lblRice.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRice.Name = "lblRice"
        Me.TableLayoutPanel1.SetRowSpan(Me.lblRice, 2)
        Me.lblRice.Size = New System.Drawing.Size(67, 27)
        Me.lblRice.TabIndex = 1
        Me.lblRice.Text = "Rice"
        Me.lblRice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAAY
        '
        Me.lblAAY.AutoSize = True
        Me.lblAAY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAAY.Location = New System.Drawing.Point(3, 31)
        Me.lblAAY.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAAY.Name = "lblAAY"
        Me.lblAAY.Size = New System.Drawing.Size(69, 24)
        Me.lblAAY.TabIndex = 6
        Me.lblAAY.Text = "AAY"
        Me.lblAAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbxRiceStock
        '
        Me.txtbxRiceStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbxRiceStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRiceStock.Location = New System.Drawing.Point(145, 31)
        Me.txtbxRiceStock.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxRiceStock.Name = "txtbxRiceStock"
        Me.txtbxRiceStock.Size = New System.Drawing.Size(100, 24)
        Me.txtbxRiceStock.TabIndex = 7
        '
        'txtbxRiceAllot
        '
        Me.txtbxRiceAllot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxRiceAllot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRiceAllot.Location = New System.Drawing.Point(248, 31)
        Me.txtbxRiceAllot.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxRiceAllot.Name = "txtbxRiceAllot"
        Me.txtbxRiceAllot.Size = New System.Drawing.Size(100, 24)
        Me.txtbxRiceAllot.TabIndex = 8
        '
        'txtbxRicePrice
        '
        Me.txtbxRicePrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxRicePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRicePrice.Location = New System.Drawing.Point(351, 31)
        Me.txtbxRicePrice.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxRicePrice.Name = "txtbxRicePrice"
        Me.txtbxRicePrice.Size = New System.Drawing.Size(100, 24)
        Me.txtbxRicePrice.TabIndex = 9
        '
        'cmbxRiceUnit
        '
        Me.cmbxRiceUnit.FormattingEnabled = True
        Me.cmbxRiceUnit.Location = New System.Drawing.Point(454, 31)
        Me.cmbxRiceUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.cmbxRiceUnit.Name = "cmbxRiceUnit"
        Me.cmbxRiceUnit.Size = New System.Drawing.Size(121, 24)
        Me.cmbxRiceUnit.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(75, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label1, 2)
        Me.Label1.Size = New System.Drawing.Size(67, 43)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Wheat"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProducts.Location = New System.Drawing.Point(78, 6)
        Me.lblProducts.Margin = New System.Windows.Forms.Padding(3)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(61, 16)
        Me.lblProducts.TabIndex = 20
        Me.lblProducts.Text = "Products"
        Me.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmUpdateAllotment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 522)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUpdateAllotment"
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
    Friend WithEvents lblRiceUnit As Label
    Friend WithEvents lblRice As Label
    Friend WithEvents lblAAY As Label
    Friend WithEvents txtbxRiceStock As TextBox
    Friend WithEvents txtbxRiceAllot As TextBox
    Friend WithEvents txtbxRicePrice As TextBox
    Friend WithEvents cmbxRiceUnit As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblProducts As Label
End Class
