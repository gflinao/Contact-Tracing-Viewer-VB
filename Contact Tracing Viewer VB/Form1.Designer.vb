﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RTBox = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'RTBox
        '
        Me.RTBox.Location = New System.Drawing.Point(12, 96)
        Me.RTBox.Name = "RTBox"
        Me.RTBox.Size = New System.Drawing.Size(367, 319)
        Me.RTBox.TabIndex = 0
        Me.RTBox.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 427)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RTBox)
        Me.Name = "Form1"
        Me.Text = "Trace Viewer 2.0"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RTBox As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OFD As OpenFileDialog
End Class
