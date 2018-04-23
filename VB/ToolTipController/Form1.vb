Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace ToolTipController
	Partial Public Class Form1
		Inherits Form
		Private toolTipControls_Renamed As List(Of Control)
		Private activeButton_Renamed As Button

		Public Sub New()
			InitializeComponent()
			Me.toolTipControls_Renamed = New List(Of Control)()
			ToolTipControls.Add(button1)
			ToolTipControls.Add(button2)
			ToolTipControls.Add(button3)
			ToolTipControls.Add(button4)
			ToolTipControls.Add(button5)
		End Sub
		Protected ReadOnly Property ToolTipControls() As List(Of Control)
			Get
				Return toolTipControls_Renamed
			End Get
		End Property

		Protected Property ActiveButton() As Button
			Get
				Return activeButton_Renamed
			End Get
			Set(ByVal value As Button)
				If value Is ActiveButton Then
					Return
				End If
				If ActiveButton IsNot Nothing Then
					HideHint()
				End If
				activeButton_Renamed = value
				If ActiveButton IsNot Nothing Then
					ShowHint()
				End If
			End Set
		End Property
		Protected Function FindToolTipControl(ByVal pt As Point) As Control
			For Each control As Control In ToolTipControls
				If control.Bounds.Contains(pt) Then
					Return control
				End If
			Next control
			Return Nothing
		End Function
		Protected ReadOnly Property ToolTipController() As DevExpress.Utils.ToolTipController
			Get
				Return DevExpress.Utils.ToolTipController.DefaultController
			End Get
		End Property
		Protected Sub HideHint()
			ToolTipController.HideHint()
		End Sub
		Protected Sub ShowHint()
			If ActiveButton Is Nothing Then
				Return
			End If
			Dim showArgs As DevExpress.Utils.ToolTipControllerShowEventArgs = ToolTipController.CreateShowArgs()
			showArgs.SelectedControl = ActiveButton
			showArgs.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
			showArgs.ToolTip = String.Format("Here is the super tool tip for button: {0}", ActiveButton.Text)
			ToolTipController.ShowHint(showArgs)
		End Sub
		Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
			ActiveButton = TryCast(FindToolTipControl(e.Location), Button)
		End Sub
		Private Sub Form1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseLeave
			ActiveButton = Nothing
		End Sub
	End Class
End Namespace