Imports Microsoft.VisualBasic
Imports System
Namespace ToolTipController
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button5 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Enabled = False
			Me.button1.Location = New System.Drawing.Point(27, 23)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(233, 23)
			Me.button1.TabIndex = 0
			Me.button1.Text = "button1"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' button2
			' 
			Me.button2.Enabled = False
			Me.button2.Location = New System.Drawing.Point(27, 65)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(233, 23)
			Me.button2.TabIndex = 1
			Me.button2.Text = "button2"
			Me.button2.UseVisualStyleBackColor = True
			' 
			' button3
			' 
			Me.button3.Enabled = False
			Me.button3.Location = New System.Drawing.Point(27, 110)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(233, 23)
			Me.button3.TabIndex = 2
			Me.button3.Text = "button3"
			Me.button3.UseVisualStyleBackColor = True
			' 
			' button4
			' 
			Me.button4.Enabled = False
			Me.button4.Location = New System.Drawing.Point(27, 154)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(233, 23)
			Me.button4.TabIndex = 3
			Me.button4.Text = "button4"
			Me.button4.UseVisualStyleBackColor = True
			' 
			' button5
			' 
			Me.button5.Enabled = False
			Me.button5.Location = New System.Drawing.Point(27, 201)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(233, 23)
			Me.button5.TabIndex = 4
			Me.button5.Text = "button5"
			Me.button5.UseVisualStyleBackColor = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 264)
			Me.Controls.Add(Me.button5)
			Me.Controls.Add(Me.button4)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.MouseLeave += New System.EventHandler(Me.Form1_MouseLeave);
'			Me.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.Form1_MouseMove);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private button1 As System.Windows.Forms.Button
		Private button2 As System.Windows.Forms.Button
		Private button3 As System.Windows.Forms.Button
		Private button4 As System.Windows.Forms.Button
		Private button5 As System.Windows.Forms.Button
	End Class
End Namespace

