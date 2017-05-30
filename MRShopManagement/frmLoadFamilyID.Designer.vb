<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoadFamilyID
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
        Me.prgbrStatus = New System.Windows.Forms.ProgressBar()
        Me.txtbxStatus = New System.Windows.Forms.TextBox()
        Me.bttnLoad = New System.Windows.Forms.Button()
        Me.bttnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'prgbrStatus
        '
        Me.prgbrStatus.Location = New System.Drawing.Point(13, 13)
        Me.prgbrStatus.Name = "prgbrStatus"
        Me.prgbrStatus.Size = New System.Drawing.Size(487, 23)
        Me.prgbrStatus.Step = 0
        Me.prgbrStatus.TabIndex = 0
        '
        'txtbxStatus
        '
        Me.txtbxStatus.Location = New System.Drawing.Point(13, 43)
        Me.txtbxStatus.Multiline = True
        Me.txtbxStatus.Name = "txtbxStatus"
        Me.txtbxStatus.ReadOnly = True
        Me.txtbxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtbxStatus.Size = New System.Drawing.Size(487, 238)
        Me.txtbxStatus.TabIndex = 1
        '
        'bttnLoad
        '
        Me.bttnLoad.Location = New System.Drawing.Point(178, 287)
        Me.bttnLoad.Name = "bttnLoad"
        Me.bttnLoad.Size = New System.Drawing.Size(75, 23)
        Me.bttnLoad.TabIndex = 2
        Me.bttnLoad.Text = "Load"
        Me.bttnLoad.UseVisualStyleBackColor = True
        '
        'bttnStop
        '
        Me.bttnStop.Location = New System.Drawing.Point(259, 287)
        Me.bttnStop.Name = "bttnStop"
        Me.bttnStop.Size = New System.Drawing.Size(75, 23)
        Me.bttnStop.TabIndex = 3
        Me.bttnStop.Text = "Stop"
        Me.bttnStop.UseVisualStyleBackColor = True
        '
        'frmLoadFamilyID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 322)
        Me.Controls.Add(Me.bttnStop)
        Me.Controls.Add(Me.bttnLoad)
        Me.Controls.Add(Me.txtbxStatus)
        Me.Controls.Add(Me.prgbrStatus)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLoadFamilyID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Load Family IDs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents prgbrStatus As ProgressBar
    Friend WithEvents txtbxStatus As TextBox
    Friend WithEvents bttnLoad As Button
    Friend WithEvents bttnStop As Button
End Class
