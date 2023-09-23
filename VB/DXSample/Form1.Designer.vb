Namespace DXSample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DXSample.Form1))
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.myPopupContainerEdit1 = New DXSample.MyPopupContainerEdit()
            Me.dropDownItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dataSourceClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colImageName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMyPopupContainerEdit1 = New DXSample.RepositoryItemMyPopupContainerEdit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.myPopupContainerEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dropDownItemBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataSourceClassBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMyPopupContainerEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.NullText = " "
            ' 
            ' colDescription
            ' 
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 0
            ' 
            ' colImage
            ' 
            Me.colImage.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colImage.FieldName = "Image"
            Me.colImage.Name = "colImage"
            Me.colImage.Visible = True
            Me.colImage.VisibleIndex = 1
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "1.bmp")
            Me.imageCollection1.Images.SetKeyName(1, "2.bmp")
            Me.imageCollection1.Images.SetKeyName(2, "3.bmp")
            Me.imageCollection1.Images.SetKeyName(3, "4.bmp")
            Me.imageCollection1.Images.SetKeyName(4, "5.bmp")
            ' 
            ' myPopupContainerEdit1
            ' 
            Me.myPopupContainerEdit1.Location = New System.Drawing.Point(116, 12)
            Me.myPopupContainerEdit1.Name = "myPopupContainerEdit1"
            Me.myPopupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.myPopupContainerEdit1.Properties.DataSource = Me.dropDownItemBindingSource
            Me.myPopupContainerEdit1.Properties.DisplayMember = "Description"
            Me.myPopupContainerEdit1.Properties.ImageIndexMember = "ImageIndex"
            Me.myPopupContainerEdit1.Properties.ImageList = Me.imageCollection1
            Me.myPopupContainerEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.myPopupContainerEdit1.Properties.ValueMember = "Description"
            Me.myPopupContainerEdit1.Size = New System.Drawing.Size(200, 20)
            Me.myPopupContainerEdit1.TabIndex = 3
            ' 
            ' dropDownItemBindingSource
            ' 
            Me.dropDownItemBindingSource.DataSource = GetType(DXSample.DropDownItem)
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.dataSourceClassBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gridControl1.Location = New System.Drawing.Point(0, 38)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMyPopupContainerEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(422, 212)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' dataSourceClassBindingSource
            ' 
            Me.dataSourceClassBindingSource.DataSource = GetType(DXSample.DataSourceClass)
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName, Me.colImageName})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 0
            Me.colName.Width = 193
            ' 
            ' colImageName
            ' 
            Me.colImageName.ColumnEdit = Me.repositoryItemMyPopupContainerEdit1
            Me.colImageName.FieldName = "ImageName"
            Me.colImageName.Name = "colImageName"
            Me.colImageName.Visible = True
            Me.colImageName.VisibleIndex = 1
            Me.colImageName.Width = 208
            ' 
            ' repositoryItemMyPopupContainerEdit1
            ' 
            Me.repositoryItemMyPopupContainerEdit1.AutoHeight = False
            Me.repositoryItemMyPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMyPopupContainerEdit1.DataSource = Me.dropDownItemBindingSource
            Me.repositoryItemMyPopupContainerEdit1.DisplayMember = "Description"
            Me.repositoryItemMyPopupContainerEdit1.ImageIndexMember = "ImageIndex"
            Me.repositoryItemMyPopupContainerEdit1.ImageList = Me.imageCollection1
            Me.repositoryItemMyPopupContainerEdit1.Name = "repositoryItemMyPopupContainerEdit1"
            Me.repositoryItemMyPopupContainerEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.repositoryItemMyPopupContainerEdit1.ValueMember = "Description"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(422, 250)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.myPopupContainerEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.myPopupContainerEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dropDownItemBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataSourceClassBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMyPopupContainerEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dropDownItemBindingSource As System.Windows.Forms.BindingSource

        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn

        Private colImage As DevExpress.XtraGrid.Columns.GridColumn

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private myPopupContainerEdit1 As DXSample.MyPopupContainerEdit

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private dataSourceClassBindingSource As System.Windows.Forms.BindingSource

        Private colName As DevExpress.XtraGrid.Columns.GridColumn

        Private colImageName As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemMyPopupContainerEdit1 As DXSample.RepositoryItemMyPopupContainerEdit
    End Class
End Namespace
