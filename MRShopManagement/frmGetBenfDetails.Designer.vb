<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetBenfDetails
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
        Me.lblRCNo = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtbxCardNo = New System.Windows.Forms.TextBox()
        Me.lblFHName = New System.Windows.Forms.Label()
        Me.txtbxFHName = New System.Windows.Forms.TextBox()
        Me.txtbxHoF = New System.Windows.Forms.TextBox()
        Me.lblHoF = New System.Windows.Forms.Label()
        Me.txtbxGender = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtbxCategory = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtbxAge = New System.Windows.Forms.TextBox()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtbxFamilyID = New System.Windows.Forms.TextBox()
        Me.lblFamilyID = New System.Windows.Forms.Label()
        Me.txtbxFPS = New System.Windows.Forms.TextBox()
        Me.lblFPS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRCNo
        '
        Me.lblRCNo.AutoSize = True
        Me.lblRCNo.Location = New System.Drawing.Point(14, 16)
        Me.lblRCNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRCNo.Name = "lblRCNo"
        Me.lblRCNo.Size = New System.Drawing.Size(51, 16)
        Me.lblRCNo.TabIndex = 14
        Me.lblRCNo.Text = "RC No:"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(213, 10)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(100, 28)
        Me.btnFind.TabIndex = 13
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtbxCardNo
        '
        Me.txtbxCardNo.Location = New System.Drawing.Point(73, 13)
        Me.txtbxCardNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxCardNo.Name = "txtbxCardNo"
        Me.txtbxCardNo.Size = New System.Drawing.Size(132, 22)
        Me.txtbxCardNo.TabIndex = 12
        '
        'lblFHName
        '
        Me.lblFHName.AutoSize = True
        Me.lblFHName.Location = New System.Drawing.Point(146, 80)
        Me.lblFHName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFHName.Name = "lblFHName"
        Me.lblFHName.Size = New System.Drawing.Size(73, 16)
        Me.lblFHName.TabIndex = 53
        Me.lblFHName.Text = "F/H Name:"
        '
        'txtbxFHName
        '
        Me.txtbxFHName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxFHName.Location = New System.Drawing.Point(227, 77)
        Me.txtbxFHName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxFHName.Name = "txtbxFHName"
        Me.txtbxFHName.ReadOnly = True
        Me.txtbxFHName.Size = New System.Drawing.Size(248, 22)
        Me.txtbxFHName.TabIndex = 54
        '
        'txtbxHoF
        '
        Me.txtbxHoF.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxHoF.Location = New System.Drawing.Point(614, 77)
        Me.txtbxHoF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxHoF.Name = "txtbxHoF"
        Me.txtbxHoF.ReadOnly = True
        Me.txtbxHoF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbxHoF.Size = New System.Drawing.Size(248, 22)
        Me.txtbxHoF.TabIndex = 50
        '
        'lblHoF
        '
        Me.lblHoF.AutoSize = True
        Me.lblHoF.Location = New System.Drawing.Point(483, 80)
        Me.lblHoF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoF.Name = "lblHoF"
        Me.lblHoF.Size = New System.Drawing.Size(123, 16)
        Me.lblHoF.TabIndex = 49
        Me.lblHoF.Text = "Head of the Family:"
        '
        'txtbxGender
        '
        Me.txtbxGender.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxGender.Location = New System.Drawing.Point(795, 46)
        Me.txtbxGender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxGender.Name = "txtbxGender"
        Me.txtbxGender.ReadOnly = True
        Me.txtbxGender.Size = New System.Drawing.Size(67, 22)
        Me.txtbxGender.TabIndex = 52
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(731, 50)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(56, 16)
        Me.lblGender.TabIndex = 51
        Me.lblGender.Text = "Gender:"
        '
        'txtbxCategory
        '
        Me.txtbxCategory.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxCategory.Location = New System.Drawing.Point(645, 47)
        Me.txtbxCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxCategory.Name = "txtbxCategory"
        Me.txtbxCategory.ReadOnly = True
        Me.txtbxCategory.Size = New System.Drawing.Size(78, 22)
        Me.txtbxCategory.TabIndex = 58
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(579, 50)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(66, 16)
        Me.lblCategory.TabIndex = 57
        Me.lblCategory.Text = "Category:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(483, 49)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 16)
        Me.lblAge.TabIndex = 55
        Me.lblAge.Text = "Age:"
        '
        'txtbxAge
        '
        Me.txtbxAge.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxAge.Location = New System.Drawing.Point(527, 47)
        Me.txtbxAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxAge.Name = "txtbxAge"
        Me.txtbxAge.ReadOnly = True
        Me.txtbxAge.Size = New System.Drawing.Size(44, 22)
        Me.txtbxAge.TabIndex = 56
        '
        'txtbxName
        '
        Me.txtbxName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxName.Location = New System.Drawing.Point(227, 46)
        Me.txtbxName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.ReadOnly = True
        Me.txtbxName.Size = New System.Drawing.Size(248, 22)
        Me.txtbxName.TabIndex = 48
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(146, 50)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 16)
        Me.lblName.TabIndex = 47
        Me.lblName.Text = "Name:"
        '
        'txtbxFamilyID
        '
        Me.txtbxFamilyID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxFamilyID.Location = New System.Drawing.Point(227, 118)
        Me.txtbxFamilyID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxFamilyID.Name = "txtbxFamilyID"
        Me.txtbxFamilyID.ReadOnly = True
        Me.txtbxFamilyID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbxFamilyID.Size = New System.Drawing.Size(248, 22)
        Me.txtbxFamilyID.TabIndex = 60
        '
        'lblFamilyID
        '
        Me.lblFamilyID.AutoSize = True
        Me.lblFamilyID.Location = New System.Drawing.Point(146, 121)
        Me.lblFamilyID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFamilyID.Name = "lblFamilyID"
        Me.lblFamilyID.Size = New System.Drawing.Size(67, 16)
        Me.lblFamilyID.TabIndex = 59
        Me.lblFamilyID.Text = "Family ID:"
        '
        'txtbxFPS
        '
        Me.txtbxFPS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxFPS.Location = New System.Drawing.Point(227, 150)
        Me.txtbxFPS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbxFPS.Name = "txtbxFPS"
        Me.txtbxFPS.ReadOnly = True
        Me.txtbxFPS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbxFPS.Size = New System.Drawing.Size(248, 22)
        Me.txtbxFPS.TabIndex = 62
        '
        'lblFPS
        '
        Me.lblFPS.AutoSize = True
        Me.lblFPS.Location = New System.Drawing.Point(146, 153)
        Me.lblFPS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFPS.Name = "lblFPS"
        Me.lblFPS.Size = New System.Drawing.Size(37, 16)
        Me.lblFPS.TabIndex = 61
        Me.lblFPS.Text = "FPS:"
        '
        'frmGetBenfDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 522)
        Me.Controls.Add(Me.txtbxFPS)
        Me.Controls.Add(Me.lblFPS)
        Me.Controls.Add(Me.txtbxFamilyID)
        Me.Controls.Add(Me.lblFamilyID)
        Me.Controls.Add(Me.txtbxCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.txtbxAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtbxFHName)
        Me.Controls.Add(Me.lblFHName)
        Me.Controls.Add(Me.txtbxGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtbxHoF)
        Me.Controls.Add(Me.lblHoF)
        Me.Controls.Add(Me.txtbxName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblRCNo)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtbxCardNo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGetBenfDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Get Benificiary Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRCNo As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents txtbxCardNo As TextBox
    Friend WithEvents lblFHName As Label
    Friend WithEvents txtbxFHName As TextBox
    Friend WithEvents txtbxHoF As TextBox
    Friend WithEvents lblHoF As Label
    Friend WithEvents txtbxGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtbxCategory As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtbxAge As TextBox
    Friend WithEvents txtbxName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtbxFamilyID As TextBox
    Friend WithEvents lblFamilyID As Label
    Friend WithEvents txtbxFPS As TextBox
    Friend WithEvents lblFPS As Label
End Class
