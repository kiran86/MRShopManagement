<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPricing
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
        Me.lblKG = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxWheat = New System.Windows.Forms.TextBox()
        Me.lblWheat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxSugar = New System.Windows.Forms.TextBox()
        Me.lblSugar = New System.Windows.Forms.Label()
        Me.bttnUpdate = New System.Windows.Forms.Button()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxAtta = New System.Windows.Forms.TextBox()
        Me.lblAtta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(76, 21)
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
        Me.cmboxCategory.Location = New System.Drawing.Point(159, 17)
        Me.cmboxCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.cmboxCategory.Name = "cmboxCategory"
        Me.cmboxCategory.Size = New System.Drawing.Size(180, 26)
        Me.cmboxCategory.TabIndex = 1
        Me.cmboxCategory.Text = "Select One"
        '
        'lblRice
        '
        Me.lblRice.AutoSize = True
        Me.lblRice.Location = New System.Drawing.Point(79, 94)
        Me.lblRice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRice.Name = "lblRice"
        Me.lblRice.Size = New System.Drawing.Size(69, 18)
        Me.lblRice.TabIndex = 2
        Me.lblRice.Text = "Rice: Rs."
        '
        'txtbxRice
        '
        Me.txtbxRice.Location = New System.Drawing.Point(159, 91)
        Me.txtbxRice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxRice.Name = "txtbxRice"
        Me.txtbxRice.Size = New System.Drawing.Size(148, 24)
        Me.txtbxRice.TabIndex = 3
        '
        'lblKG
        '
        Me.lblKG.AutoSize = True
        Me.lblKG.Location = New System.Drawing.Point(318, 96)
        Me.lblKG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKG.Name = "lblKG"
        Me.lblKG.Size = New System.Drawing.Size(38, 18)
        Me.lblKG.TabIndex = 4
        Me.lblKG.Text = "/ KG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(318, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "/ KG"
        '
        'txtbxWheat
        '
        Me.txtbxWheat.Location = New System.Drawing.Point(159, 127)
        Me.txtbxWheat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxWheat.Name = "txtbxWheat"
        Me.txtbxWheat.Size = New System.Drawing.Size(148, 24)
        Me.txtbxWheat.TabIndex = 6
        '
        'lblWheat
        '
        Me.lblWheat.AutoSize = True
        Me.lblWheat.Location = New System.Drawing.Point(66, 132)
        Me.lblWheat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWheat.Name = "lblWheat"
        Me.lblWheat.Size = New System.Drawing.Size(82, 18)
        Me.lblWheat.TabIndex = 5
        Me.lblWheat.Text = "Wheat: Rs."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 196)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "/ KG"
        '
        'txtbxSugar
        '
        Me.txtbxSugar.Location = New System.Drawing.Point(159, 191)
        Me.txtbxSugar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxSugar.Name = "txtbxSugar"
        Me.txtbxSugar.Size = New System.Drawing.Size(148, 24)
        Me.txtbxSugar.TabIndex = 12
        '
        'lblSugar
        '
        Me.lblSugar.AutoSize = True
        Me.lblSugar.Location = New System.Drawing.Point(70, 196)
        Me.lblSugar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSugar.Name = "lblSugar"
        Me.lblSugar.Size = New System.Drawing.Size(78, 18)
        Me.lblSugar.TabIndex = 11
        Me.lblSugar.Text = "Sugar: Rs."
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 164)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "/ KG"
        '
        'txtbxAtta
        '
        Me.txtbxAtta.Location = New System.Drawing.Point(159, 159)
        Me.txtbxAtta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxAtta.Name = "txtbxAtta"
        Me.txtbxAtta.Size = New System.Drawing.Size(148, 24)
        Me.txtbxAtta.TabIndex = 9
        '
        'lblAtta
        '
        Me.lblAtta.AutoSize = True
        Me.lblAtta.Location = New System.Drawing.Point(84, 162)
        Me.lblAtta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAtta.Name = "lblAtta"
        Me.lblAtta.Size = New System.Drawing.Size(64, 18)
        Me.lblAtta.TabIndex = 8
        Me.lblAtta.Text = "Atta: Rs."
        '
        'frmPricing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 361)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbxAtta)
        Me.Controls.Add(Me.lblAtta)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbxSugar)
        Me.Controls.Add(Me.lblSugar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbxWheat)
        Me.Controls.Add(Me.lblWheat)
        Me.Controls.Add(Me.lblKG)
        Me.Controls.Add(Me.txtbxRice)
        Me.Controls.Add(Me.lblRice)
        Me.Controls.Add(Me.cmboxCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPricing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Price Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCategory As Label
    Friend WithEvents cmboxCategory As ComboBox
    Friend WithEvents lblRice As Label
    Friend WithEvents txtbxRice As TextBox
    Friend WithEvents lblKG As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxWheat As TextBox
    Friend WithEvents lblWheat As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxSugar As TextBox
    Friend WithEvents lblSugar As Label
    Friend WithEvents bttnUpdate As Button
    Friend WithEvents bttnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxAtta As TextBox
    Friend WithEvents lblAtta As Label
End Class
