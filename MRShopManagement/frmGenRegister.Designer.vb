<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenRegister
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.cmboxRegisterType = New System.Windows.Forms.ComboBox()
        Me.dttmFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.cmboxCategory = New System.Windows.Forms.ComboBox()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.bttnGenerate = New System.Windows.Forms.Button()
        Me.dttmTo = New System.Windows.Forms.DateTimePicker()
        Me.SaveRegFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtgrdvwRegister = New System.Windows.Forms.DataGridView()
        Me.MrshopDataSet = New MRShopManagement.mrshopDataSet()
        Me.BeneficiariesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BeneficiariesTableAdapter = New MRShopManagement.mrshopDataSetTableAdapters.BeneficiariesTableAdapter()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgrdvwRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MrshopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeneficiariesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Location = New System.Drawing.Point(121, 15)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(62, 16)
        Me.lblRegister.TabIndex = 7
        Me.lblRegister.Text = "Register:"
        '
        'cmboxRegisterType
        '
        Me.cmboxRegisterType.FormattingEnabled = True
        Me.cmboxRegisterType.Items.AddRange(New Object() {"Stock", "Sale"})
        Me.cmboxRegisterType.Location = New System.Drawing.Point(189, 12)
        Me.cmboxRegisterType.Name = "cmboxRegisterType"
        Me.cmboxRegisterType.Size = New System.Drawing.Size(121, 24)
        Me.cmboxRegisterType.TabIndex = 8
        '
        'dttmFrom
        '
        Me.dttmFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttmFrom.Location = New System.Drawing.Point(563, 10)
        Me.dttmFrom.Name = "dttmFrom"
        Me.dttmFrom.Size = New System.Drawing.Size(102, 22)
        Me.dttmFrom.TabIndex = 3
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(316, 15)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(66, 16)
        Me.lblCategory.TabIndex = 9
        Me.lblCategory.Text = "Category:"
        Me.lblCategory.Visible = False
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(671, 15)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(28, 16)
        Me.lblTo.TabIndex = 1
        Me.lblTo.Text = "To:"
        '
        'cmboxCategory
        '
        Me.cmboxCategory.FormattingEnabled = True
        Me.cmboxCategory.Items.AddRange(New Object() {"All", "AAY", "PHH", "SPHH", "RKSY-I", "RKSY-II"})
        Me.cmboxCategory.Location = New System.Drawing.Point(388, 12)
        Me.cmboxCategory.Name = "cmboxCategory"
        Me.cmboxCategory.Size = New System.Drawing.Size(121, 24)
        Me.cmboxCategory.TabIndex = 10
        Me.cmboxCategory.Visible = False
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(515, 15)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(42, 16)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From:"
        '
        'bttnGenerate
        '
        Me.bttnGenerate.Location = New System.Drawing.Point(813, 12)
        Me.bttnGenerate.Name = "bttnGenerate"
        Me.bttnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.bttnGenerate.TabIndex = 11
        Me.bttnGenerate.Text = "Generate"
        Me.bttnGenerate.UseVisualStyleBackColor = True
        '
        'dttmTo
        '
        Me.dttmTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttmTo.Location = New System.Drawing.Point(705, 10)
        Me.dttmTo.Name = "dttmTo"
        Me.dttmTo.Size = New System.Drawing.Size(102, 22)
        Me.dttmTo.TabIndex = 2
        '
        'SaveRegFileDialog
        '
        Me.SaveRegFileDialog.Filter = "Microsoft Exel 95-2003 File (*.xls)|*.xls|All Files|*.*"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtgrdvwRegister)
        Me.Panel1.Location = New System.Drawing.Point(12, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 468)
        Me.Panel1.TabIndex = 12
        '
        'dtgrdvwRegister
        '
        Me.dtgrdvwRegister.AllowUserToAddRows = False
        Me.dtgrdvwRegister.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgrdvwRegister.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgrdvwRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrdvwRegister.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dtgrdvwRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgrdvwRegister.Location = New System.Drawing.Point(0, 0)
        Me.dtgrdvwRegister.Name = "dtgrdvwRegister"
        Me.dtgrdvwRegister.ReadOnly = True
        Me.dtgrdvwRegister.Size = New System.Drawing.Size(984, 468)
        Me.dtgrdvwRegister.TabIndex = 13
        '
        'MrshopDataSet
        '
        Me.MrshopDataSet.DataSetName = "mrshopDataSet"
        Me.MrshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BeneficiariesBindingSource
        '
        Me.BeneficiariesBindingSource.DataMember = "Beneficiaries"
        Me.BeneficiariesBindingSource.DataSource = Me.MrshopDataSet
        '
        'BeneficiariesTableAdapter
        '
        Me.BeneficiariesTableAdapter.ClearBeforeFill = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 66
        '
        'Column2
        '
        Me.Column2.HeaderText = "Category"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Comodity"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Opening Balance (in qt-kg-gms)"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Stock Received (in qt-kg-gms)"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total Stock (in qt-kg-gms)"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Stock Sold (in qt-kg-gms)"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Handling Loss (in qt-kg-gms)"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Closing Balance (in qt-kg-gms)"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'frmGenRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 522)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bttnGenerate)
        Me.Controls.Add(Me.cmboxCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmboxRegisterType)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.dttmFrom)
        Me.Controls.Add(Me.dttmTo)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGenRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Generate"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtgrdvwRegister, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MrshopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeneficiariesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRegister As Label
    Friend WithEvents cmboxRegisterType As ComboBox
    Friend WithEvents dttmFrom As DateTimePicker
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents cmboxCategory As ComboBox
    Friend WithEvents lblFrom As Label
    Friend WithEvents bttnGenerate As Button
    Friend WithEvents dttmTo As DateTimePicker
    Friend WithEvents SaveRegFileDialog As SaveFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtgrdvwRegister As DataGridView
    Friend WithEvents MrshopDataSet As mrshopDataSet
    Friend WithEvents BeneficiariesBindingSource As BindingSource
    Friend WithEvents BeneficiariesTableAdapter As mrshopDataSetTableAdapters.BeneficiariesTableAdapter
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
