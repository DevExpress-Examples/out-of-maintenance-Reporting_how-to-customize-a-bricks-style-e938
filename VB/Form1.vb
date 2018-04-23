Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
' ...

Namespace ChangeBrickStyle
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim s As String = "XtraPrinting Library"
			Dim brickGraph As BrickGraphics = printingSystem1.Graph
			Dim visBrick As New VisualBrick()

			' Specify the style
			Dim bStyle As New BrickStyle(BorderSide.Bottom, 2, Color.Gold, Color.Navy, Color.DodgerBlue, New Font("Arial", 14, FontStyle.Bold Or FontStyle.Italic), New BrickStringFormat(StringAlignment.Far, StringAlignment.Near))

			' Start the report generation.
			printingSystem1.Begin()

			' Create bricks.
			brickGraph.Modifier = BrickModifier.Detail
			visBrick = brickGraph.DrawString(s, New RectangleF(0, 0, 250, 40))
			visBrick = brickGraph.DrawString(s, New RectangleF(0, 40, 250, 40))

			' Apply the style to the current brick.
			visBrick.Style = bStyle

			' Finish the report generation.
			printingSystem1.End()
		End Sub


	End Class
End Namespace
