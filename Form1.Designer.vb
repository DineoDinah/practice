﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		Button1 = New Button()
		Button2 = New Button()
		PictureBox1 = New PictureBox()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Button1
		' 
		Button1.Location = New Point(424, 394)
		Button1.Name = "Button1"
		Button1.Size = New Size(112, 34)
		Button1.TabIndex = 0
		Button1.Text = "Close"
		Button1.UseVisualStyleBackColor = True
		' 
		' Button2
		' 
		Button2.Location = New Point(41, 394)
		Button2.Name = "Button2"
		Button2.Size = New Size(112, 34)
		Button2.TabIndex = 0
		Button2.Text = "View"
		Button2.UseVisualStyleBackColor = True
		' 
		' PictureBox1
		' 
		PictureBox1.BackColor = SystemColors.ButtonHighlight
		PictureBox1.Location = New Point(126, 92)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(330, 146)
		PictureBox1.TabIndex = 1
		PictureBox1.TabStop = False
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.ActiveCaption
		ClientSize = New Size(800, 450)
		Controls.Add(PictureBox1)
		Controls.Add(Button2)
		Controls.Add(Button1)
		Name = "Form1"
		Text = "Form1"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents PictureBox1 As PictureBox
End Class
