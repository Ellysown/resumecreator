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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.convertbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'convertbtn
        '
        Me.convertbtn.BackgroundImage = Global.resumecreator.My.Resources.Resources.image_removebg_preview__14_
        Me.convertbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.convertbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.convertbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.convertbtn.Location = New System.Drawing.Point(65, 77)
        Me.convertbtn.Name = "convertbtn"
        Me.convertbtn.Size = New System.Drawing.Size(139, 57)
        Me.convertbtn.TabIndex = 0
        Me.convertbtn.Text = "Convert to PDF"
        Me.convertbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.resumecreator.My.Resources.Resources.image_removebg_preview
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(271, 213)
        Me.Controls.Add(Me.convertbtn)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Resume Creator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents convertbtn As Button
End Class
