﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoDelivery
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
        Me.bttnDeliver = New System.Windows.Forms.Button()
        Me.bttnStop = New System.Windows.Forms.Button()
        Me.dttmDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDelvDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'prgbrStatus
        '
        Me.prgbrStatus.Location = New System.Drawing.Point(13, 41)
        Me.prgbrStatus.Name = "prgbrStatus"
        Me.prgbrStatus.Size = New System.Drawing.Size(487, 23)
        Me.prgbrStatus.Step = 0
        Me.prgbrStatus.TabIndex = 0
        '
        'txtbxStatus
        '
        Me.txtbxStatus.Location = New System.Drawing.Point(13, 70)
        Me.txtbxStatus.Multiline = True
        Me.txtbxStatus.Name = "txtbxStatus"
        Me.txtbxStatus.ReadOnly = True
        Me.txtbxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtbxStatus.Size = New System.Drawing.Size(487, 211)
        Me.txtbxStatus.TabIndex = 1
        '
        'bttnDeliver
        '
        Me.bttnDeliver.Location = New System.Drawing.Point(178, 287)
        Me.bttnDeliver.Name = "bttnDeliver"
        Me.bttnDeliver.Size = New System.Drawing.Size(75, 23)
        Me.bttnDeliver.TabIndex = 2
        Me.bttnDeliver.Text = "Deliver"
        Me.bttnDeliver.UseVisualStyleBackColor = True
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
        'dttmDeliveryDate
        '
        Me.dttmDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttmDeliveryDate.Location = New System.Drawing.Point(259, 12)
        Me.dttmDeliveryDate.Name = "dttmDeliveryDate"
        Me.dttmDeliveryDate.Size = New System.Drawing.Size(97, 22)
        Me.dttmDeliveryDate.TabIndex = 4
        '
        'lblDelvDate
        '
        Me.lblDelvDate.AutoSize = True
        Me.lblDelvDate.Location = New System.Drawing.Point(160, 15)
        Me.lblDelvDate.Name = "lblDelvDate"
        Me.lblDelvDate.Size = New System.Drawing.Size(93, 16)
        Me.lblDelvDate.TabIndex = 5
        Me.lblDelvDate.Text = "Delivery Date:"
        '
        'frmAutoDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 322)
        Me.Controls.Add(Me.lblDelvDate)
        Me.Controls.Add(Me.dttmDeliveryDate)
        Me.Controls.Add(Me.bttnStop)
        Me.Controls.Add(Me.bttnDeliver)
        Me.Controls.Add(Me.txtbxStatus)
        Me.Controls.Add(Me.prgbrStatus)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAutoDelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make Auto Delivery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents prgbrStatus As ProgressBar
    Friend WithEvents txtbxStatus As TextBox
    Friend WithEvents bttnDeliver As Button
    Friend WithEvents bttnStop As Button
    Friend WithEvents dttmDeliveryDate As DateTimePicker
    Friend WithEvents lblDelvDate As Label
End Class
