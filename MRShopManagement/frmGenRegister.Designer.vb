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
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dttmTo = New System.Windows.Forms.DateTimePicker()
        Me.dttmFrom = New System.Windows.Forms.DateTimePicker()
        Me.SaveRegFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtbxFileLoc = New System.Windows.Forms.TextBox()
        Me.bttnBrowse = New System.Windows.Forms.Button()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.cmboxRegisterType = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmboxCategory = New System.Windows.Forms.ComboBox()
        Me.bttnGenerate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(13, 46)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(42, 16)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(169, 46)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(28, 16)
        Me.lblTo.TabIndex = 1
        Me.lblTo.Text = "To:"
        '
        'dttmTo
        '
        Me.dttmTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttmTo.Location = New System.Drawing.Point(203, 42)
        Me.dttmTo.Name = "dttmTo"
        Me.dttmTo.Size = New System.Drawing.Size(102, 22)
        Me.dttmTo.TabIndex = 2
        '
        'dttmFrom
        '
        Me.dttmFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttmFrom.Location = New System.Drawing.Point(61, 42)
        Me.dttmFrom.Name = "dttmFrom"
        Me.dttmFrom.Size = New System.Drawing.Size(102, 22)
        Me.dttmFrom.TabIndex = 3
        '
        'SaveRegFileDialog
        '
        Me.SaveRegFileDialog.Filter = "Microsoft Exel 95-2003 File (*.xls)|*.xls|All Files|*.*"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(12, 73)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(62, 16)
        Me.lblLocation.TabIndex = 4
        Me.lblLocation.Text = "Location:"
        '
        'txtbxFileLoc
        '
        Me.txtbxFileLoc.Location = New System.Drawing.Point(80, 70)
        Me.txtbxFileLoc.Name = "txtbxFileLoc"
        Me.txtbxFileLoc.Size = New System.Drawing.Size(206, 22)
        Me.txtbxFileLoc.TabIndex = 5
        '
        'bttnBrowse
        '
        Me.bttnBrowse.Location = New System.Drawing.Point(292, 70)
        Me.bttnBrowse.Name = "bttnBrowse"
        Me.bttnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.bttnBrowse.TabIndex = 6
        Me.bttnBrowse.Text = "Browse"
        Me.bttnBrowse.UseVisualStyleBackColor = True
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Location = New System.Drawing.Point(12, 15)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(62, 16)
        Me.lblRegister.TabIndex = 7
        Me.lblRegister.Text = "Register:"
        '
        'cmboxRegisterType
        '
        Me.cmboxRegisterType.FormattingEnabled = True
        Me.cmboxRegisterType.Items.AddRange(New Object() {"Stock", "Sale"})
        Me.cmboxRegisterType.Location = New System.Drawing.Point(80, 12)
        Me.cmboxRegisterType.Name = "cmboxRegisterType"
        Me.cmboxRegisterType.Size = New System.Drawing.Size(121, 24)
        Me.cmboxRegisterType.TabIndex = 8
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(207, 15)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(66, 16)
        Me.lblCategory.TabIndex = 9
        Me.lblCategory.Text = "Category:"
        Me.lblCategory.Visible = False
        '
        'cmboxCategory
        '
        Me.cmboxCategory.FormattingEnabled = True
        Me.cmboxCategory.Items.AddRange(New Object() {"All", "AAY", "PHH", "SPHH", "RKSY-I", "RKSY-II"})
        Me.cmboxCategory.Location = New System.Drawing.Point(279, 12)
        Me.cmboxCategory.Name = "cmboxCategory"
        Me.cmboxCategory.Size = New System.Drawing.Size(121, 24)
        Me.cmboxCategory.TabIndex = 10
        Me.cmboxCategory.Visible = False
        '
        'bttnGenerate
        '
        Me.bttnGenerate.Location = New System.Drawing.Point(169, 98)
        Me.bttnGenerate.Name = "bttnGenerate"
        Me.bttnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.bttnGenerate.TabIndex = 11
        Me.bttnGenerate.Text = "Generate"
        Me.bttnGenerate.UseVisualStyleBackColor = True
        '
        'frmGenRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 130)
        Me.Controls.Add(Me.bttnGenerate)
        Me.Controls.Add(Me.cmboxCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmboxRegisterType)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.bttnBrowse)
        Me.Controls.Add(Me.txtbxFileLoc)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.dttmFrom)
        Me.Controls.Add(Me.dttmTo)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGenRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Generate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents dttmTo As DateTimePicker
    Friend WithEvents dttmFrom As DateTimePicker
    Friend WithEvents SaveRegFileDialog As SaveFileDialog
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtbxFileLoc As TextBox
    Friend WithEvents bttnBrowse As Button
    Friend WithEvents lblRegister As Label
    Friend WithEvents cmboxRegisterType As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmboxCategory As ComboBox
    Friend WithEvents bttnGenerate As Button
End Class
