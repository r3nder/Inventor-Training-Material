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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBoxMacros = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Execute"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBoxMacros
        '
        Me.ComboBoxMacros.FormattingEnabled = True
        Me.ComboBoxMacros.Location = New System.Drawing.Point(43, 70)
        Me.ComboBoxMacros.Name = "ComboBoxMacros"
        Me.ComboBoxMacros.Size = New System.Drawing.Size(182, 21)
        Me.ComboBoxMacros.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ComboBoxMacros)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBoxMacros As System.Windows.Forms.ComboBox

End Class