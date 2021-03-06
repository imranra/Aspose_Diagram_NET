'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Diagram. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Diagram

Namespace RetrievingMasterInformation
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Call the diagram constructor to load diagram from a VDX file
			Dim vdxDiagram As New Diagram(dataDir & "drawing.vdx")

			For Each master As Aspose.Diagram.Master In vdxDiagram.Masters
				'Display information about the masters
				Console.WriteLine(vbLf & "Master ID : " & master.ID)
				Console.WriteLine("Master Name : " & master.Name)
			Next master

			Console.ReadLine()
		End Sub
	End Class
End Namespace