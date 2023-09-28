Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace ToolTipController

    Public Partial Class Form1
        Inherits Form

        Private toolTipControlsField As List(Of Control)

        Private activeButtonField As Button

        Public Sub New()
            InitializeComponent()
            Me.toolTipControlsField = New List(Of Control)()
            ToolTipControls.Add(button1)
            ToolTipControls.Add(button2)
            ToolTipControls.Add(button3)
            ToolTipControls.Add(button4)
            ToolTipControls.Add(button5)
        End Sub

        Protected ReadOnly Property ToolTipControls As List(Of Control)
            Get
                Return toolTipControlsField
            End Get
        End Property

        Protected Property ActiveButton As Button
            Get
                Return activeButtonField
            End Get

            Set(ByVal value As Button)
                If value Is ActiveButton Then Return
                If ActiveButton IsNot Nothing Then
                    HideHint()
                End If

                activeButtonField = value
                If ActiveButton IsNot Nothing Then
                    ShowHint()
                End If
            End Set
        End Property

        Protected Function FindToolTipControl(ByVal pt As Point) As Control
            For Each control As Control In ToolTipControls
                If control.Bounds.Contains(pt) Then Return control
            Next

            Return Nothing
        End Function

        Protected ReadOnly Property ToolTipController As DevExpress.Utils.ToolTipController
            Get
                Return DevExpress.Utils.ToolTipController.DefaultController
            End Get
        End Property

        Protected Sub HideHint()
            ToolTipController.HideHint()
        End Sub

        Protected Sub ShowHint()
            If ActiveButton Is Nothing Then Return
            Dim showArgs As DevExpress.Utils.ToolTipControllerShowEventArgs = ToolTipController.CreateShowArgs()
            showArgs.SelectedControl = ActiveButton
            showArgs.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
            showArgs.ToolTip = String.Format("Here is the super tool tip for button: {0}", ActiveButton.Text)
            ToolTipController.ShowHint(showArgs)
        End Sub

        Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            ActiveButton = TryCast(FindToolTipControl(e.Location), Button)
        End Sub

        Private Sub Form1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            ActiveButton = Nothing
        End Sub
    End Class
End Namespace
