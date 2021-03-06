'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Diagram. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Diagram

Namespace CreateNewDiagram
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim visioStencil As String = dataDir & "Basic Shapes.vss"
			' Create a new diagram
			Dim diagram As New Diagram(visioStencil)

			'Add a new rectangle shape
			Dim shapeId As Long = diagram.AddShape(4.25, 5.5, 2, 1, "Rectangle", 0)
			Dim shape As Shape = diagram.Pages(0).Shapes.GetShape(shapeId)
			shape.Text.Value.Add(New Txt("Rectangle text."))

			'Add a new star shape
			shapeId = diagram.AddShape(2.0, 5.5, 2, 2, "Star 7", 0)
			shape = diagram.Pages(0).Shapes.GetShape(shapeId)
			shape.Text.Value.Add(New Txt("Star text."))

			'Add a new hexagon shape
			shapeId = diagram.AddShape(7.0, 5.5, 2, 2, "Hexagon", 0)
			shape = diagram.Pages(0).Shapes.GetShape(shapeId)
			shape.Text.Value.Add(New Txt("Hexagon text."))

			'Save the new diagram
			diagram.Save(dataDir & "Drawing1.vdx", SaveFileFormat.VDX)

			' Display Status.
			System.Console.WriteLine("Diagram created and saved successfully.")
		End Sub
	End Class
End Namespace