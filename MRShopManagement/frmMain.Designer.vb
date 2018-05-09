<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuMRShopManagement = New System.Windows.Forms.MenuStrip()
        Me.BenefiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditFamilyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoodSupplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAllotmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AutoDeliveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearDeliveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.lblHoF = New System.Windows.Forms.Label()
        Me.txtbxHoF = New System.Windows.Forms.TextBox()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtbxGender = New System.Windows.Forms.TextBox()
        Me.txtbxCardNo = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.lblRCNo = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAddAll = New System.Windows.Forms.Button()
        Me.lstvwRcNos = New System.Windows.Forms.ListView()
        Me.lstvwFamily = New System.Windows.Forms.ListView()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxRiceQty = New System.Windows.Forms.TextBox()
        Me.txtbxWhtQty = New System.Windows.Forms.TextBox()
        Me.lblWheat = New System.Windows.Forms.Label()
        Me.txtbxSugar = New System.Windows.Forms.TextBox()
        Me.lblSugar = New System.Windows.Forms.Label()
        Me.btnDeliver = New System.Windows.Forms.Button()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.txtbxHead = New System.Windows.Forms.TextBox()
        Me.lblFHName = New System.Windows.Forms.Label()
        Me.txtbxFHName = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtbxAge = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtbxCategory = New System.Windows.Forms.TextBox()
        Me.txtbxRicePrice = New System.Windows.Forms.TextBox()
        Me.txtbxWhtPrice = New System.Windows.Forms.TextBox()
        Me.txtbxSugarPrice = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtbxTotal = New System.Windows.Forms.TextBox()
        Me.txtbxAttaPrice = New System.Windows.Forms.TextBox()
        Me.txtbxAttaQty = New System.Windows.Forms.TextBox()
        Me.lblAtta = New System.Windows.Forms.Label()
        Me.lblSystemDateTime = New System.Windows.Forms.Label()
        Me.timerSystemDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblCashMemoNo = New System.Windows.Forms.Label()
        Me.txtbxCashMemoNo = New System.Windows.Forms.TextBox()
        Me.txtbxKOilPrice = New System.Windows.Forms.TextBox()
        Me.txtbxKOil = New System.Windows.Forms.TextBox()
        Me.lblKOil = New System.Windows.Forms.Label()
        Me.MenuMRShopManagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuMRShopManagement
        '
        Me.MenuMRShopManagement.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BenefiToolStripMenuItem, Me.FoodSupplyToolStripMenuItem, Me.menuRegister, Me.SystemToolStripMenuItem})
        Me.MenuMRShopManagement.Location = New System.Drawing.Point(0, 0)
        Me.MenuMRShopManagement.Name = "MenuMRShopManagement"
        Me.MenuMRShopManagement.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuMRShopManagement.Size = New System.Drawing.Size(1008, 24)
        Me.MenuMRShopManagement.TabIndex = 0
        Me.MenuMRShopManagement.Text = "MenuMRShopManagement"
        '
        'BenefiToolStripMenuItem
        '
        Me.BenefiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolStripSeparator1, Me.EditFamilyToolStripMenuItem, Me.LoadDataToolStripMenuItem})
        Me.BenefiToolStripMenuItem.Name = "BenefiToolStripMenuItem"
        Me.BenefiToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.BenefiToolStripMenuItem.Text = "Beneficiaries"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add "
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'EditFamilyToolStripMenuItem
        '
        Me.EditFamilyToolStripMenuItem.Name = "EditFamilyToolStripMenuItem"
        Me.EditFamilyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditFamilyToolStripMenuItem.Text = "Edit Family ID"
        '
        'LoadDataToolStripMenuItem
        '
        Me.LoadDataToolStripMenuItem.Name = "LoadDataToolStripMenuItem"
        Me.LoadDataToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadDataToolStripMenuItem.Text = "Load Family ID"
        '
        'FoodSupplyToolStripMenuItem
        '
        Me.FoodSupplyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateAllotmentToolStripMenuItem})
        Me.FoodSupplyToolStripMenuItem.Name = "FoodSupplyToolStripMenuItem"
        Me.FoodSupplyToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.FoodSupplyToolStripMenuItem.Text = "Food Supply"
        '
        'UpdateAllotmentToolStripMenuItem
        '
        Me.UpdateAllotmentToolStripMenuItem.Name = "UpdateAllotmentToolStripMenuItem"
        Me.UpdateAllotmentToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UpdateAllotmentToolStripMenuItem.Text = "Update Allotment"
        '
        'menuRegister
        '
        Me.menuRegister.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewSalesToolStripMenuItem, Me.StockRegisterToolStripMenuItem})
        Me.menuRegister.Name = "menuRegister"
        Me.menuRegister.Size = New System.Drawing.Size(61, 20)
        Me.menuRegister.Text = "Register"
        '
        'ViewSalesToolStripMenuItem
        '
        Me.ViewSalesToolStripMenuItem.Name = "ViewSalesToolStripMenuItem"
        Me.ViewSalesToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ViewSalesToolStripMenuItem.Text = "View Sales"
        '
        'StockRegisterToolStripMenuItem
        '
        Me.StockRegisterToolStripMenuItem.Name = "StockRegisterToolStripMenuItem"
        Me.StockRegisterToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.StockRegisterToolStripMenuItem.Text = "Generate Register"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupToolStripMenuItem, Me.RestoreToolStripMenuItem, Me.ToolStripSeparator3, Me.UpdateDatabaseToolStripMenuItem, Me.ToolStripSeparator2, Me.AutoDeliveryToolStripMenuItem, Me.ClearDeliveryToolStripMenuItem})
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(160, 6)
        '
        'UpdateDatabaseToolStripMenuItem
        '
        Me.UpdateDatabaseToolStripMenuItem.Name = "UpdateDatabaseToolStripMenuItem"
        Me.UpdateDatabaseToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.UpdateDatabaseToolStripMenuItem.Text = "Update Database"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(160, 6)
        '
        'AutoDeliveryToolStripMenuItem
        '
        Me.AutoDeliveryToolStripMenuItem.Name = "AutoDeliveryToolStripMenuItem"
        Me.AutoDeliveryToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AutoDeliveryToolStripMenuItem.Text = "Auto Delivery"
        '
        'ClearDeliveryToolStripMenuItem
        '
        Me.ClearDeliveryToolStripMenuItem.Name = "ClearDeliveryToolStripMenuItem"
        Me.ClearDeliveryToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ClearDeliveryToolStripMenuItem.Text = "Clear Delivery"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(146, 65)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 16)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name:"
        '
        'txtbxName
        '
        Me.txtbxName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxName.Location = New System.Drawing.Point(227, 61)
        Me.txtbxName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.ReadOnly = True
        Me.txtbxName.Size = New System.Drawing.Size(248, 22)
        Me.txtbxName.TabIndex = 4
        '
        'lblHoF
        '
        Me.lblHoF.AutoSize = True
        Me.lblHoF.Location = New System.Drawing.Point(483, 95)
        Me.lblHoF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoF.Name = "lblHoF"
        Me.lblHoF.Size = New System.Drawing.Size(123, 16)
        Me.lblHoF.TabIndex = 5
        Me.lblHoF.Text = "Head of the Family:"
        '
        'txtbxHoF
        '
        Me.txtbxHoF.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxHoF.Location = New System.Drawing.Point(614, 92)
        Me.txtbxHoF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxHoF.Name = "txtbxHoF"
        Me.txtbxHoF.ReadOnly = True
        Me.txtbxHoF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbxHoF.Size = New System.Drawing.Size(248, 22)
        Me.txtbxHoF.TabIndex = 6
        '
        'lblFamily
        '
        Me.lblFamily.AutoSize = True
        Me.lblFamily.Location = New System.Drawing.Point(21, 98)
        Me.lblFamily.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(51, 16)
        Me.lblFamily.TabIndex = 7
        Me.lblFamily.Text = "Family:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(731, 65)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(56, 16)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender:"
        '
        'txtbxGender
        '
        Me.txtbxGender.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxGender.Location = New System.Drawing.Point(795, 61)
        Me.txtbxGender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxGender.Name = "txtbxGender"
        Me.txtbxGender.ReadOnly = True
        Me.txtbxGender.Size = New System.Drawing.Size(67, 22)
        Me.txtbxGender.TabIndex = 10
        '
        'txtbxCardNo
        '
        Me.txtbxCardNo.Location = New System.Drawing.Point(80, 31)
        Me.txtbxCardNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxCardNo.Name = "txtbxCardNo"
        Me.txtbxCardNo.Size = New System.Drawing.Size(132, 22)
        Me.txtbxCardNo.TabIndex = 1
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(220, 28)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(100, 28)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'lblRCNo
        '
        Me.lblRCNo.AutoSize = True
        Me.lblRCNo.Location = New System.Drawing.Point(21, 34)
        Me.lblRCNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRCNo.Name = "lblRCNo"
        Me.lblRCNo.Size = New System.Drawing.Size(51, 16)
        Me.lblRCNo.TabIndex = 11
        Me.lblRCNo.Text = "RC No:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(268, 270)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 28)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add >"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAddAll
        '
        Me.btnAddAll.Location = New System.Drawing.Point(388, 270)
        Me.btnAddAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddAll.Name = "btnAddAll"
        Me.btnAddAll.Size = New System.Drawing.Size(112, 28)
        Me.btnAddAll.TabIndex = 18
        Me.btnAddAll.Text = "Add All >>"
        Me.btnAddAll.UseVisualStyleBackColor = True
        '
        'lstvwRcNos
        '
        Me.lstvwRcNos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstvwRcNos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwRcNos.GridLines = True
        Me.lstvwRcNos.Location = New System.Drawing.Point(16, 306)
        Me.lstvwRcNos.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvwRcNos.Name = "lstvwRcNos"
        Me.lstvwRcNos.Size = New System.Drawing.Size(979, 140)
        Me.lstvwRcNos.TabIndex = 19
        Me.lstvwRcNos.UseCompatibleStateImageBehavior = False
        Me.lstvwRcNos.View = System.Windows.Forms.View.Details
        '
        'lstvwFamily
        '
        Me.lstvwFamily.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstvwFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwFamily.GridLines = True
        Me.lstvwFamily.Location = New System.Drawing.Point(16, 122)
        Me.lstvwFamily.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvwFamily.Name = "lstvwFamily"
        Me.lstvwFamily.Size = New System.Drawing.Size(979, 140)
        Me.lstvwFamily.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstvwFamily.TabIndex = 20
        Me.lstvwFamily.UseCompatibleStateImageBehavior = False
        Me.lstvwFamily.View = System.Windows.Forms.View.Details
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(508, 270)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(112, 28)
        Me.btnRemove.TabIndex = 21
        Me.btnRemove.Text = "< Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(628, 270)
        Me.btnRemoveAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(112, 28)
        Me.btnRemoveAll.TabIndex = 22
        Me.btnRemoveAll.Text = "<< Remove All"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 457)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Rice:"
        '
        'txtbxRiceQty
        '
        Me.txtbxRiceQty.Location = New System.Drawing.Point(119, 454)
        Me.txtbxRiceQty.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxRiceQty.Name = "txtbxRiceQty"
        Me.txtbxRiceQty.ReadOnly = True
        Me.txtbxRiceQty.Size = New System.Drawing.Size(61, 22)
        Me.txtbxRiceQty.TabIndex = 25
        Me.txtbxRiceQty.Text = "00.000KG"
        '
        'txtbxWhtQty
        '
        Me.txtbxWhtQty.Location = New System.Drawing.Point(282, 454)
        Me.txtbxWhtQty.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxWhtQty.Name = "txtbxWhtQty"
        Me.txtbxWhtQty.ReadOnly = True
        Me.txtbxWhtQty.Size = New System.Drawing.Size(61, 22)
        Me.txtbxWhtQty.TabIndex = 28
        Me.txtbxWhtQty.Text = "00.000KG"
        '
        'lblWheat
        '
        Me.lblWheat.AutoSize = True
        Me.lblWheat.Location = New System.Drawing.Point(232, 457)
        Me.lblWheat.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lblWheat.Name = "lblWheat"
        Me.lblWheat.Size = New System.Drawing.Size(50, 16)
        Me.lblWheat.TabIndex = 27
        Me.lblWheat.Text = "Wheat:"
        '
        'txtbxSugar
        '
        Me.txtbxSugar.Location = New System.Drawing.Point(589, 454)
        Me.txtbxSugar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxSugar.Name = "txtbxSugar"
        Me.txtbxSugar.ReadOnly = True
        Me.txtbxSugar.Size = New System.Drawing.Size(61, 22)
        Me.txtbxSugar.TabIndex = 31
        Me.txtbxSugar.Text = "00.000KG"
        '
        'lblSugar
        '
        Me.lblSugar.AutoSize = True
        Me.lblSugar.Location = New System.Drawing.Point(542, 457)
        Me.lblSugar.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lblSugar.Name = "lblSugar"
        Me.lblSugar.Size = New System.Drawing.Size(47, 16)
        Me.lblSugar.TabIndex = 30
        Me.lblSugar.Text = "Sugar:"
        '
        'btnDeliver
        '
        Me.btnDeliver.Enabled = False
        Me.btnDeliver.Location = New System.Drawing.Point(456, 484)
        Me.btnDeliver.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeliver.Name = "btnDeliver"
        Me.btnDeliver.Size = New System.Drawing.Size(111, 28)
        Me.btnDeliver.TabIndex = 35
        Me.btnDeliver.Text = "Make Delivery"
        Me.btnDeliver.UseVisualStyleBackColor = True
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.Location = New System.Drawing.Point(9, 457)
        Me.lblHead.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(45, 16)
        Me.lblHead.TabIndex = 36
        Me.lblHead.Text = "Head:"
        '
        'txtbxHead
        '
        Me.txtbxHead.Location = New System.Drawing.Point(54, 454)
        Me.txtbxHead.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxHead.Name = "txtbxHead"
        Me.txtbxHead.ReadOnly = True
        Me.txtbxHead.Size = New System.Drawing.Size(22, 22)
        Me.txtbxHead.TabIndex = 37
        Me.txtbxHead.Text = "00"
        '
        'lblFHName
        '
        Me.lblFHName.AutoSize = True
        Me.lblFHName.Location = New System.Drawing.Point(146, 95)
        Me.lblFHName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFHName.Name = "lblFHName"
        Me.lblFHName.Size = New System.Drawing.Size(73, 16)
        Me.lblFHName.TabIndex = 41
        Me.lblFHName.Text = "F/H Name:"
        '
        'txtbxFHName
        '
        Me.txtbxFHName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxFHName.Location = New System.Drawing.Point(227, 92)
        Me.txtbxFHName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxFHName.Name = "txtbxFHName"
        Me.txtbxFHName.ReadOnly = True
        Me.txtbxFHName.Size = New System.Drawing.Size(248, 22)
        Me.txtbxFHName.TabIndex = 42
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(483, 64)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 16)
        Me.lblAge.TabIndex = 43
        Me.lblAge.Text = "Age:"
        '
        'txtbxAge
        '
        Me.txtbxAge.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxAge.Location = New System.Drawing.Point(527, 62)
        Me.txtbxAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxAge.Name = "txtbxAge"
        Me.txtbxAge.ReadOnly = True
        Me.txtbxAge.Size = New System.Drawing.Size(44, 22)
        Me.txtbxAge.TabIndex = 44
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(579, 65)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(66, 16)
        Me.lblCategory.TabIndex = 45
        Me.lblCategory.Text = "Category:"
        '
        'txtbxCategory
        '
        Me.txtbxCategory.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxCategory.Location = New System.Drawing.Point(645, 62)
        Me.txtbxCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxCategory.Name = "txtbxCategory"
        Me.txtbxCategory.ReadOnly = True
        Me.txtbxCategory.Size = New System.Drawing.Size(78, 22)
        Me.txtbxCategory.TabIndex = 46
        '
        'txtbxRicePrice
        '
        Me.txtbxRicePrice.Location = New System.Drawing.Point(180, 454)
        Me.txtbxRicePrice.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxRicePrice.Name = "txtbxRicePrice"
        Me.txtbxRicePrice.ReadOnly = True
        Me.txtbxRicePrice.Size = New System.Drawing.Size(48, 22)
        Me.txtbxRicePrice.TabIndex = 48
        Me.txtbxRicePrice.Text = "₹00.00"
        '
        'txtbxWhtPrice
        '
        Me.txtbxWhtPrice.Location = New System.Drawing.Point(343, 454)
        Me.txtbxWhtPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxWhtPrice.Name = "txtbxWhtPrice"
        Me.txtbxWhtPrice.ReadOnly = True
        Me.txtbxWhtPrice.Size = New System.Drawing.Size(48, 22)
        Me.txtbxWhtPrice.TabIndex = 49
        Me.txtbxWhtPrice.Text = "₹00.00"
        '
        'txtbxSugarPrice
        '
        Me.txtbxSugarPrice.Location = New System.Drawing.Point(650, 454)
        Me.txtbxSugarPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxSugarPrice.Name = "txtbxSugarPrice"
        Me.txtbxSugarPrice.ReadOnly = True
        Me.txtbxSugarPrice.Size = New System.Drawing.Size(48, 22)
        Me.txtbxSugarPrice.TabIndex = 50
        Me.txtbxSugarPrice.Text = "₹00.00"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(887, 457)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(48, 16)
        Me.lblTotal.TabIndex = 51
        Me.lblTotal.Text = "Total:"
        '
        'txtbxTotal
        '
        Me.txtbxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTotal.Location = New System.Drawing.Point(935, 454)
        Me.txtbxTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxTotal.Name = "txtbxTotal"
        Me.txtbxTotal.ReadOnly = True
        Me.txtbxTotal.Size = New System.Drawing.Size(61, 22)
        Me.txtbxTotal.TabIndex = 52
        Me.txtbxTotal.Text = "₹000.00"
        '
        'txtbxAttaPrice
        '
        Me.txtbxAttaPrice.Location = New System.Drawing.Point(490, 454)
        Me.txtbxAttaPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxAttaPrice.Name = "txtbxAttaPrice"
        Me.txtbxAttaPrice.ReadOnly = True
        Me.txtbxAttaPrice.Size = New System.Drawing.Size(48, 22)
        Me.txtbxAttaPrice.TabIndex = 56
        Me.txtbxAttaPrice.Text = "₹00.00"
        '
        'txtbxAttaQty
        '
        Me.txtbxAttaQty.Location = New System.Drawing.Point(429, 454)
        Me.txtbxAttaQty.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxAttaQty.Name = "txtbxAttaQty"
        Me.txtbxAttaQty.ReadOnly = True
        Me.txtbxAttaQty.Size = New System.Drawing.Size(61, 22)
        Me.txtbxAttaQty.TabIndex = 55
        Me.txtbxAttaQty.Text = "00.000KG"
        '
        'lblAtta
        '
        Me.lblAtta.AutoSize = True
        Me.lblAtta.Location = New System.Drawing.Point(395, 457)
        Me.lblAtta.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lblAtta.Name = "lblAtta"
        Me.lblAtta.Size = New System.Drawing.Size(34, 16)
        Me.lblAtta.TabIndex = 54
        Me.lblAtta.Text = "Atta:"
        '
        'lblSystemDateTime
        '
        Me.lblSystemDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSystemDateTime.AutoSize = True
        Me.lblSystemDateTime.Font = New System.Drawing.Font("Courier New", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemDateTime.ForeColor = System.Drawing.Color.Blue
        Me.lblSystemDateTime.Location = New System.Drawing.Point(797, 31)
        Me.lblSystemDateTime.Name = "lblSystemDateTime"
        Me.lblSystemDateTime.Size = New System.Drawing.Size(199, 19)
        Me.lblSystemDateTime.TabIndex = 57
        Me.lblSystemDateTime.Text = "dd-MM-yyyy hh:mm:ss"
        '
        'timerSystemDateTime
        '
        '
        'lblCashMemoNo
        '
        Me.lblCashMemoNo.AutoSize = True
        Me.lblCashMemoNo.Location = New System.Drawing.Point(328, 34)
        Me.lblCashMemoNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCashMemoNo.Name = "lblCashMemoNo"
        Me.lblCashMemoNo.Size = New System.Drawing.Size(104, 16)
        Me.lblCashMemoNo.TabIndex = 58
        Me.lblCashMemoNo.Text = "Cash Memo No:"
        '
        'txtbxCashMemoNo
        '
        Me.txtbxCashMemoNo.Location = New System.Drawing.Point(440, 31)
        Me.txtbxCashMemoNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxCashMemoNo.Name = "txtbxCashMemoNo"
        Me.txtbxCashMemoNo.ReadOnly = True
        Me.txtbxCashMemoNo.Size = New System.Drawing.Size(132, 22)
        Me.txtbxCashMemoNo.TabIndex = 59
        '
        'txtbxKOilPrice
        '
        Me.txtbxKOilPrice.Location = New System.Drawing.Point(804, 454)
        Me.txtbxKOilPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxKOilPrice.Name = "txtbxKOilPrice"
        Me.txtbxKOilPrice.ReadOnly = True
        Me.txtbxKOilPrice.Size = New System.Drawing.Size(48, 22)
        Me.txtbxKOilPrice.TabIndex = 62
        Me.txtbxKOilPrice.Text = "₹00.00"
        '
        'txtbxKOil
        '
        Me.txtbxKOil.Location = New System.Drawing.Point(743, 454)
        Me.txtbxKOil.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxKOil.Name = "txtbxKOil"
        Me.txtbxKOil.ReadOnly = True
        Me.txtbxKOil.Size = New System.Drawing.Size(61, 22)
        Me.txtbxKOil.TabIndex = 61
        Me.txtbxKOil.Text = "00.000KG"
        '
        'lblKOil
        '
        Me.lblKOil.AutoSize = True
        Me.lblKOil.Location = New System.Drawing.Point(702, 457)
        Me.lblKOil.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lblKOil.Name = "lblKOil"
        Me.lblKOil.Size = New System.Drawing.Size(41, 16)
        Me.lblKOil.TabIndex = 60
        Me.lblKOil.Text = "K. Oil:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1008, 522)
        Me.Controls.Add(Me.txtbxKOilPrice)
        Me.Controls.Add(Me.txtbxKOil)
        Me.Controls.Add(Me.lblKOil)
        Me.Controls.Add(Me.txtbxCashMemoNo)
        Me.Controls.Add(Me.lblCashMemoNo)
        Me.Controls.Add(Me.lblSystemDateTime)
        Me.Controls.Add(Me.txtbxAttaPrice)
        Me.Controls.Add(Me.txtbxAttaQty)
        Me.Controls.Add(Me.lblAtta)
        Me.Controls.Add(Me.txtbxTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtbxSugarPrice)
        Me.Controls.Add(Me.txtbxWhtPrice)
        Me.Controls.Add(Me.txtbxRicePrice)
        Me.Controls.Add(Me.txtbxCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.txtbxAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtbxFHName)
        Me.Controls.Add(Me.lblFHName)
        Me.Controls.Add(Me.txtbxHead)
        Me.Controls.Add(Me.lblHead)
        Me.Controls.Add(Me.btnDeliver)
        Me.Controls.Add(Me.txtbxSugar)
        Me.Controls.Add(Me.lblSugar)
        Me.Controls.Add(Me.txtbxWhtQty)
        Me.Controls.Add(Me.lblWheat)
        Me.Controls.Add(Me.txtbxRiceQty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemoveAll)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstvwFamily)
        Me.Controls.Add(Me.lstvwRcNos)
        Me.Controls.Add(Me.btnAddAll)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblRCNo)
        Me.Controls.Add(Me.txtbxGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblFamily)
        Me.Controls.Add(Me.txtbxHoF)
        Me.Controls.Add(Me.lblHoF)
        Me.Controls.Add(Me.txtbxName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtbxCardNo)
        Me.Controls.Add(Me.MenuMRShopManagement)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuMRShopManagement
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " FPS Management"
        Me.MenuMRShopManagement.ResumeLayout(False)
        Me.MenuMRShopManagement.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuMRShopManagement As System.Windows.Forms.MenuStrip
    Friend WithEvents menuRegister As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtbxName As System.Windows.Forms.TextBox
    Friend WithEvents lblHoF As System.Windows.Forms.Label
    Friend WithEvents txtbxHoF As System.Windows.Forms.TextBox
    Friend WithEvents lblFamily As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents txtbxGender As System.Windows.Forms.TextBox
    Friend WithEvents txtbxCardNo As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents lblRCNo As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnAddAll As System.Windows.Forms.Button
    Friend WithEvents lstvwRcNos As System.Windows.Forms.ListView
    Friend WithEvents lstvwFamily As System.Windows.Forms.ListView
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAll As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbxRiceQty As System.Windows.Forms.TextBox
    Friend WithEvents txtbxWhtQty As System.Windows.Forms.TextBox
    Friend WithEvents lblWheat As System.Windows.Forms.Label
    Friend WithEvents txtbxSugar As System.Windows.Forms.TextBox
    Friend WithEvents lblSugar As System.Windows.Forms.Label
    Friend WithEvents btnDeliver As System.Windows.Forms.Button
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents txtbxHead As System.Windows.Forms.TextBox
    Friend WithEvents lblFHName As System.Windows.Forms.Label
    Friend WithEvents txtbxFHName As System.Windows.Forms.TextBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtbxAge As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents txtbxCategory As System.Windows.Forms.TextBox
    Friend WithEvents BenefiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FoodSupplyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditFamilyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ViewSalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockRegisterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtbxRicePrice As TextBox
    Friend WithEvents txtbxWhtPrice As TextBox
    Friend WithEvents txtbxSugarPrice As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtbxTotal As TextBox
    Friend WithEvents txtbxAttaPrice As TextBox
    Friend WithEvents txtbxAttaQty As TextBox
    Friend WithEvents lblAtta As Label
    Friend WithEvents SystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSystemDateTime As Label
    Friend WithEvents timerSystemDateTime As Timer
    Friend WithEvents lblCashMemoNo As Label
    Friend WithEvents txtbxCashMemoNo As TextBox
    Friend WithEvents AutoDeliveryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearDeliveryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents UpdateDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtbxKOilPrice As TextBox
    Friend WithEvents txtbxKOil As TextBox
    Friend WithEvents lblKOil As Label
    Friend WithEvents UpdateAllotmentToolStripMenuItem As ToolStripMenuItem
End Class
