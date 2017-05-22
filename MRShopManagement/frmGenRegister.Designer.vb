<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGenRegister
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.cmboxRegisterType = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmboxCategory = New System.Windows.Forms.ComboBox()
        Me.bttnGenerate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.datagridRegister = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.datagridRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Location = New System.Drawing.Point(270, 15)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(62, 16)
        Me.lblRegister.TabIndex = 7
        Me.lblRegister.Text = "Register:"
        '
        'cmboxRegisterType
        '
        Me.cmboxRegisterType.FormattingEnabled = True
        Me.cmboxRegisterType.Items.AddRange(New Object() {"Stock", "Sale"})
        Me.cmboxRegisterType.Location = New System.Drawing.Point(338, 12)
        Me.cmboxRegisterType.Name = "cmboxRegisterType"
        Me.cmboxRegisterType.Size = New System.Drawing.Size(121, 24)
        Me.cmboxRegisterType.TabIndex = 8
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Enabled = False
        Me.lblCategory.Location = New System.Drawing.Point(465, 15)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(66, 16)
        Me.lblCategory.TabIndex = 9
        Me.lblCategory.Text = "Category:"
        '
        'cmboxCategory
        '
        Me.cmboxCategory.Enabled = False
        Me.cmboxCategory.FormattingEnabled = True
        Me.cmboxCategory.Items.AddRange(New Object() {"AAY", "PHH", "SPHH", "RKSY-I", "RKSY-II"})
        Me.cmboxCategory.Location = New System.Drawing.Point(537, 12)
        Me.cmboxCategory.Name = "cmboxCategory"
        Me.cmboxCategory.Size = New System.Drawing.Size(121, 24)
        Me.cmboxCategory.TabIndex = 10
        '
        'bttnGenerate
        '
        Me.bttnGenerate.Location = New System.Drawing.Point(664, 12)
        Me.bttnGenerate.Name = "bttnGenerate"
        Me.bttnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.bttnGenerate.TabIndex = 11
        Me.bttnGenerate.Text = "Generate"
        Me.bttnGenerate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.datagridRegister)
        Me.Panel1.Location = New System.Drawing.Point(12, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 468)
        Me.Panel1.TabIndex = 12
        '
        'datagridRegister
        '
        Me.datagridRegister.AllowUserToAddRows = False
        Me.datagridRegister.AllowUserToDeleteRows = False
        Me.datagridRegister.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridRegister.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridRegister.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridRegister.Location = New System.Drawing.Point(0, 0)
        Me.datagridRegister.Name = "datagridRegister"
        Me.datagridRegister.ReadOnly = True
        Me.datagridRegister.Size = New System.Drawing.Size(984, 468)
        Me.datagridRegister.TabIndex = 0
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGenRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Generate"
        Me.Panel1.ResumeLayout(False)
        CType(Me.datagridRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRegister As Label
    Friend WithEvents cmboxRegisterType As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmboxCategory As ComboBox
    Friend WithEvents bttnGenerate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents datagridRegister As DataGridView
End Class
