'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Diagram. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Diagram

Namespace ExportDiagramToXML
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")



			' 1.
			' Exporting VSD to VDX
			'Call the diagram constructor to load diagram from a VSD file
			Dim diagram As New Diagram(dataDir & "drawing.vsd")

			'Save input VSD as VDX
			diagram.Save(dataDir & "outputVSDtoVDX.vdx", SaveFileFormat.VDX)



			' 2.
			' Exporting from VSD to VSX
			' Call the diagram constructor to load diagram from a VSD file

			'Save input VSD as VSX
			diagram.Save(dataDir & "outputVSDtoVSX.vsx", SaveFileFormat.VSX)



			' 3.
			' Export VSD to VTX
			'Save input VSD as VTX
			diagram.Save(dataDir & "outputVSDtoVTX.vtx", SaveFileFormat.VTX)
		End Sub
	End Class
End Namespace