﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid

Namespace MyXtraGrid
	Public Class MyAdvBandedGridView
		Inherits AdvBandedGridView
		Public Sub New(ByVal ownerGrid As DevExpress.XtraGrid.GridControl)
			MyBase.New(ownerGrid)

		End Sub
		Public Sub New()

		End Sub
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyAdvBandedGridView"
			End Get
		End Property
	End Class
End Namespace
