<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAllotment
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
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmboxCategory = New System.Windows.Forms.ComboBox()
        Me.lblRice = New System.Windows.Forms.Label()
        Me.txtbxRice = New System.Windows.Forms.TextBox()
        Me.lblRiceUnit = New System.Windows.Forms.Label()
        Me.lblWheatUnit = New System.Windows.Forms.Label()
        Me.txtbxWheat = New System.Windows.Forms.TextBox()
        Me.lblWheat = New System.Windows.Forms.Label()
        Me.lblSugarUnit = New System.Windows.Forms.Label()
        Me.txtbxSugar = New System.Windows.Forms.TextBox()
        Me.lblSugar = New System.Windows.Forms.Label()
        Me.bttnUpdate = New System.Windows.Forms.Button()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.lblAttaUnit = New System.Windows.Forms.Label()
        Me.txtbxAtta = New System.Windows.Forms.TextBox()
        Me.lblAtta = New System.Windows.Forms.Label()
        Me.cmboxUnitRice = New System.Windows.Forms.ComboBox()
        Me.cmboxUnitWheat = New System.Windows.Forms.ComboBox()
        Me.cmboxUnitAtta = New System.Windows.Forms.ComboBox()
        Me.cmboxUnitSugar = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(82, 21)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(72, 18)
        Me.lblCategory.TabIndex = 0
        Me.lblCategory.Text = "Category:"
        '
        'cmboxCategory
        '
        Me.cmboxCategory.FormattingEnabled = True
        Me.cmboxCategory.Items.AddRange(New Object() {"AAY", "PHH", "SPHH", "RKSY-I", "RKSY-II"})
        Me.cmboxCategory.Location = New System.Drawing.Point(165, 17)
        Me.cmboxCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxCategory.Name = "cmboxCategory"
        Me.cmboxCategory.Size = New System.Drawing.Size(180, 26)
        Me.cmboxCategory.TabIndex = 1
        Me.cmboxCategory.Text = "Select One"
        '
        'lblRice
        '
        Me.lblRice.AutoSize = True
        Me.lblRice.Location = New System.Drawing.Point(34, 94)
        Me.lblRice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRice.Name = "lblRice"
        Me.lblRice.Size = New System.Drawing.Size(42, 18)
        Me.lblRice.TabIndex = 2
        Me.lblRice.Text = "Rice:"
        '
        'txtbxRice
        '
        Me.txtbxRice.Location = New System.Drawing.Point(84, 91)
        Me.txtbxRice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxRice.Name = "txtbxRice"
        Me.txtbxRice.Size = New System.Drawing.Size(148, 24)
        Me.txtbxRice.TabIndex = 3
        '
        'lblRiceUnit
        '
        Me.lblRiceUnit.AutoSize = True
        Me.lblRiceUnit.Location = New System.Drawing.Point(240, 94)
        Me.lblRiceUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRiceUnit.Name = "lblRiceUnit"
        Me.lblRiceUnit.Size = New System.Drawing.Size(38, 18)
        Me.lblRiceUnit.TabIndex = 4
        Me.lblRiceUnit.Text = "KG /"
        '
        'lblWheatUnit
        '
        Me.lblWheatUnit.AutoSize = True
        Me.lblWheatUnit.Location = New System.Drawing.Point(243, 132)
        Me.lblWheatUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWheatUnit.Name = "lblWheatUnit"
        Me.lblWheatUnit.Size = New System.Drawing.Size(38, 18)
        Me.lblWheatUnit.TabIndex = 7
        Me.lblWheatUnit.Text = "KG /"
        '
        'txtbxWheat
        '
        Me.txtbxWheat.Location = New System.Drawing.Point(84, 127)
        Me.txtbxWheat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxWheat.Name = "txtbxWheat"
        Me.txtbxWheat.Size = New System.Drawing.Size(148, 24)
        Me.txtbxWheat.TabIndex = 6
        '
        'lblWheat
        '
        Me.lblWheat.AutoSize = True
        Me.lblWheat.Location = New System.Drawing.Point(21, 132)
        Me.lblWheat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWheat.Name = "lblWheat"
        Me.lblWheat.Size = New System.Drawing.Size(55, 18)
        Me.lblWheat.TabIndex = 5
        Me.lblWheat.Text = "Wheat:"
        '
        'lblSugarUnit
        '
        Me.lblSugarUnit.AutoSize = True
        Me.lblSugarUnit.Location = New System.Drawing.Point(243, 196)
        Me.lblSugarUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSugarUnit.Name = "lblSugarUnit"
        Me.lblSugarUnit.Size = New System.Drawing.Size(38, 18)
        Me.lblSugarUnit.TabIndex = 13
        Me.lblSugarUnit.Text = "KG /"
        '
        'txtbxSugar
        '
        Me.txtbxSugar.Location = New System.Drawing.Point(84, 191)
        Me.txtbxSugar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxSugar.Name = "txtbxSugar"
        Me.txtbxSugar.Size = New System.Drawing.Size(148, 24)
        Me.txtbxSugar.TabIndex = 12
        '
        'lblSugar
        '
        Me.lblSugar.AutoSize = True
        Me.lblSugar.Location = New System.Drawing.Point(25, 194)
        Me.lblSugar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSugar.Name = "lblSugar"
        Me.lblSugar.Size = New System.Drawing.Size(51, 18)
        Me.lblSugar.TabIndex = 11
        Me.lblSugar.Text = "Sugar:"
        '
        'bttnUpdate
        '
        Me.bttnUpdate.Location = New System.Drawing.Point(100, 314)
        Me.bttnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnUpdate.Name = "bttnUpdate"
        Me.bttnUpdate.Size = New System.Drawing.Size(112, 32)
        Me.bttnUpdate.TabIndex = 14
        Me.bttnUpdate.Text = "Update"
        Me.bttnUpdate.UseVisualStyleBackColor = True
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(224, 314)
        Me.bttnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(112, 32)
        Me.bttnCancel.TabIndex = 15
        Me.bttnCancel.Text = "Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'lblAttaUnit
        '
        Me.lblAttaUnit.AutoSize = True
        Me.lblAttaUnit.Location = New System.Drawing.Point(243, 162)
        Me.lblAttaUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAttaUnit.Name = "lblAttaUnit"
        Me.lblAttaUnit.Size = New System.Drawing.Size(38, 18)
        Me.lblAttaUnit.TabIndex = 10
        Me.lblAttaUnit.Text = "KG /"
        '
        'txtbxAtta
        '
        Me.txtbxAtta.Location = New System.Drawing.Point(84, 159)
        Me.txtbxAtta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxAtta.Name = "txtbxAtta"
        Me.txtbxAtta.Size = New System.Drawing.Size(148, 24)
        Me.txtbxAtta.TabIndex = 9
        '
        'lblAtta
        '
        Me.lblAtta.AutoSize = True
        Me.lblAtta.Location = New System.Drawing.Point(39, 162)
        Me.lblAtta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAtta.Name = "lblAtta"
        Me.lblAtta.Size = New System.Drawing.Size(37, 18)
        Me.lblAtta.TabIndex = 8
        Me.lblAtta.Text = "Atta:"
        '
        'cmboxUnitRice
        '
        Me.cmboxUnitRice.FormattingEnabled = True
        Me.cmboxUnitRice.Items.AddRange(New Object() {"Head", "Family"})
        Me.cmboxUnitRice.Location = New System.Drawing.Point(288, 91)
        Me.cmboxUnitRice.Name = "cmboxUnitRice"
        Me.cmboxUnitRice.Size = New System.Drawing.Size(121, 26)
        Me.cmboxUnitRice.TabIndex = 16
        '
        'cmboxUnitWheat
        '
        Me.cmboxUnitWheat.FormattingEnabled = True
        Me.cmboxUnitWheat.Items.AddRange(New Object() {"Head", "Family"})
        Me.cmboxUnitWheat.Location = New System.Drawing.Point(288, 127)
        Me.cmboxUnitWheat.Name = "cmboxUnitWheat"
        Me.cmboxUnitWheat.Size = New System.Drawing.Size(121, 26)
        Me.cmboxUnitWheat.TabIndex = 17
        '
        'cmboxUnitAtta
        '
        Me.cmboxUnitAtta.FormattingEnabled = True
        Me.cmboxUnitAtta.Items.AddRange(New Object() {"Head", "Family"})
        Me.cmboxUnitAtta.Location = New System.Drawing.Point(288, 159)
        Me.cmboxUnitAtta.Name = "cmboxUnitAtta"
        Me.cmboxUnitAtta.Size = New System.Drawing.Size(121, 26)
        Me.cmboxUnitAtta.TabIndex = 18
        '
        'cmboxUnitSugar
        '
        Me.cmboxUnitSugar.FormattingEnabled = True
        Me.cmboxUnitSugar.Items.AddRange(New Object() {"Head", "Family"})
        Me.cmboxUnitSugar.Location = New System.Drawing.Point(288, 191)
        Me.cmboxUnitSugar.Name = "cmboxUnitSugar"
        Me.cmboxUnitSugar.Size = New System.Drawing.Size(121, 26)
        Me.cmboxUnitSugar.TabIndex = 19
        '
        'frmAllotment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 361)
        Me.Controls.Add(Me.cmboxUnitSugar)
        Me.Controls.Add(Me.cmboxUnitAtta)
        Me.Controls.Add(Me.cmboxUnitWheat)
        Me.Controls.Add(Me.cmboxUnitRice)
        Me.Controls.Add(Me.lblAttaUnit)
        Me.Controls.Add(Me.txtbxAtta)
        Me.Controls.Add(Me.lblAtta)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnUpdate)
        Me.Controls.Add(Me.lblSugarUnit)
        Me.Controls.Add(Me.txtbxSugar)
        Me.Controls.Add(Me.lblSugar)
        Me.Controls.Add(Me.lblWheatUnit)
        Me.Controls.Add(Me.txtbxWheat)
        Me.Controls.Add(Me.lblWheat)
        Me.Controls.Add(Me.lblRiceUnit)
        Me.Controls.Add(Me.txtbxRice)
        Me.Controls.Add(Me.lblRice)
        Me.Controls.Add(Me.cmboxCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAllotment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allotment Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCategory As Label
    Friend WithEvents cmboxCategory As ComboBox
    Friend WithEvents lblRice As Label
    Friend WithEvents txtbxRice As TextBox
    Friend WithEvents lblRiceUnit As Label
    Friend WithEvents lblWheatUnit As Label
    Friend WithEvents txtbxWheat As TextBox
    Friend WithEvents lblWheat As Label
    Friend WithEvents lblSugarUnit As Label
    Friend WithEvents txtbxSugar As TextBox
    Friend WithEvents lblSugar As Label
    Friend WithEvents bttnUpdate As Button
    Friend WithEvents bttnCancel As Button
    Friend WithEvents lblAttaUnit As Label
    Friend WithEvents txtbxAtta As TextBox
    Friend WithEvents lblAtta As Label
    Friend WithEvents cmboxUnitRice As ComboBox
    Friend WithEvents cmboxUnitWheat As ComboBox
    Friend WithEvents cmboxUnitAtta As ComboBox
    Friend WithEvents cmboxUnitSugar As ComboBox
End Class
