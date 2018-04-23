Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Registrator

Namespace DXSample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For i As Integer = 0 To imageCollection1.Images.Count - 1
				Dim item As New DropDownItem()
				item.ImageIndex = i
				item.Description = imageCollection1.Images.Keys(i)
				dropDownItemBindingSource.Add(item)
			Next i
			dataSourceClassBindingSource.AddNew()
			dataSourceClassBindingSource.AddNew()
			dataSourceClassBindingSource.AddNew()
		End Sub
	End Class
	Public Class DataSourceClass
		Private _Name As String
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				_Name = value
			End Set
		End Property
		Private _ImageName As String
		Public Property ImageName() As String
			Get
				Return _ImageName
			End Get
			Set(ByVal value As String)
				_ImageName = value
			End Set
		End Property

	End Class
	Public Class DropDownItem
		Private _Description As String
		Public Property Description() As String
			Get
				Return _Description
			End Get
			Set(ByVal value As String)
				_Description = value
			End Set
		End Property
		Private _ImageIndex As Integer
		Public Property ImageIndex() As Integer
			Get
				Return _ImageIndex
			End Get
			Set(ByVal value As Integer)
				_ImageIndex = value
			End Set
		End Property

	End Class
End Namespace