Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DXSample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            For i As Integer = 0 To imageCollection1.Images.Count - 1
                Dim item As DropDownItem = New DropDownItem()
                item.ImageIndex = i
                item.Description = imageCollection1.Images.Keys(i)
                dropDownItemBindingSource.Add(item)
            Next

            dataSourceClassBindingSource.AddNew()
            dataSourceClassBindingSource.AddNew()
            dataSourceClassBindingSource.AddNew()
        End Sub
    End Class

    Public Class DataSourceClass

        Private _Name As String

        Public Property Name As String
            Get
                Return _Name
            End Get

            Set(ByVal value As String)
                _Name = value
            End Set
        End Property

        Private _ImageName As String

        Public Property ImageName As String
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

        Public Property Description As String
            Get
                Return _Description
            End Get

            Set(ByVal value As String)
                _Description = value
            End Set
        End Property

        Private _ImageIndex As Integer

        Public Property ImageIndex As Integer
            Get
                Return _ImageIndex
            End Get

            Set(ByVal value As Integer)
                _ImageIndex = value
            End Set
        End Property
    End Class
End Namespace
