<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewSales
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
        Me.datagridRegister = New System.Windows.Forms.DataGridView()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmboxCategory = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnReset = New System.Windows.Forms.Button()
        CType(Me.datagridRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridRegister
        '
        Me.datagridRegister.AllowUserToAddRows = False
        Me.datagridRegister.AllowUserToDeleteRows = False
        Me.datagridRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridRegister.Location = New System.Drawing.Point(0, 40)
        Me.datagridRegister.Name = "datagridRegister"
        Me.datagridRegister.ReadOnly = True
        Me.datagridRegister.Size = New System.Drawing.Size(1008, 482)
        Me.datagridRegister.TabIndex = 0
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(194, 13)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(66, 16)
        Me.lblCategory.TabIndex = 1
        Me.lblCategory.Text = "Category:"
        '
        'cmboxCategory
        '
        Me.cmboxCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboxCategory.FormattingEnabled = True
        Me.cmboxCategory.Items.AddRange(New Object() {"All", "AAY", "PHH", "SPHH", "RKSY-I", "RKSY-II"})
        Me.cmboxCategory.Location = New System.Drawing.Point(266, 10)
        Me.cmboxCategory.Name = "cmboxCategory"
        Me.cmboxCategory.Size = New System.Drawing.Size(121, 24)
        Me.cmboxCategory.TabIndex = 2
        Me.cmboxCategory.Text = "All"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(393, 13)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 16)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromDate.Location = New System.Drawing.Point(439, 13)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(47, 16)
        Me.lblFromDate.TabIndex = 4
        Me.lblFromDate.Text = "FROM"
        '
        'dateFrom
        '
        Me.dateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFrom.Location = New System.Drawing.Point(492, 10)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(101, 22)
        Me.dateFrom.TabIndex = 5
        '
        'dateTo
        '
        Me.dateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTo.Location = New System.Drawing.Point(632, 10)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(101, 22)
        Me.dateTo.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(599, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "TO"
        '
        'bttnReset
        '
        Me.bttnReset.Location = New System.Drawing.Point(739, 9)
        Me.bttnReset.Name = "bttnReset"
        Me.bttnReset.Size = New System.Drawing.Size(75, 23)
        Me.bttnReset.TabIndex = 8
        Me.bttnReset.Text = "Reset"
        Me.bttnReset.UseVisualStyleBackColor = True
        '
        'frmViewSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1008, 522)
        Me.Controls.Add(Me.bttnReset)
        Me.Controls.Add(Me.dateTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dateFrom)
        Me.Controls.Add(Me.lblFromDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cmboxCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.datagridRegister)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmViewSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.datagridRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datagridRegister As System.Windows.Forms.DataGridView
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmboxCategory As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblFromDate As Label
    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents bttnReset As Button
End Class
