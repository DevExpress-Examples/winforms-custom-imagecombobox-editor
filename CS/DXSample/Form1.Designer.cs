namespace DXSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.myPopupContainerEdit1 = new DXSample.MyPopupContainerEdit();
            this.dropDownItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSourceClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMyPopupContainerEdit1 = new DXSample.RepositoryItemMyPopupContainerEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPopupContainerEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyPopupContainerEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.NullText = " ";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            // 
            // colImage
            // 
            this.colImage.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 1;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "1.bmp");
            this.imageCollection1.Images.SetKeyName(1, "2.bmp");
            this.imageCollection1.Images.SetKeyName(2, "3.bmp");
            this.imageCollection1.Images.SetKeyName(3, "4.bmp");
            this.imageCollection1.Images.SetKeyName(4, "5.bmp");
            // 
            // myPopupContainerEdit1
            // 
            this.myPopupContainerEdit1.Location = new System.Drawing.Point(116, 12);
            this.myPopupContainerEdit1.Name = "myPopupContainerEdit1";
            this.myPopupContainerEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myPopupContainerEdit1.Properties.DataSource = this.dropDownItemBindingSource;
            this.myPopupContainerEdit1.Properties.DisplayMember = "Description";
            this.myPopupContainerEdit1.Properties.ImageIndexMember = "ImageIndex";
            this.myPopupContainerEdit1.Properties.ImageList = this.imageCollection1;
            this.myPopupContainerEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.myPopupContainerEdit1.Properties.ValueMember = "Description";
            this.myPopupContainerEdit1.Size = new System.Drawing.Size(200, 20);
            this.myPopupContainerEdit1.TabIndex = 3;
            // 
            // dropDownItemBindingSource
            // 
            this.dropDownItemBindingSource.DataSource = typeof(DXSample.DropDownItem);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dataSourceClassBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMyPopupContainerEdit1});
            this.gridControl1.Size = new System.Drawing.Size(422, 212);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataSourceClassBindingSource
            // 
            this.dataSourceClassBindingSource.DataSource = typeof(DXSample.DataSourceClass);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colImageName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 193;
            // 
            // colImageName
            // 
            this.colImageName.ColumnEdit = this.repositoryItemMyPopupContainerEdit1;
            this.colImageName.FieldName = "ImageName";
            this.colImageName.Name = "colImageName";
            this.colImageName.Visible = true;
            this.colImageName.VisibleIndex = 1;
            this.colImageName.Width = 208;
            // 
            // repositoryItemMyPopupContainerEdit1
            // 
            this.repositoryItemMyPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemMyPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMyPopupContainerEdit1.DataSource = this.dropDownItemBindingSource;
            this.repositoryItemMyPopupContainerEdit1.DisplayMember = "Description";
            this.repositoryItemMyPopupContainerEdit1.ImageIndexMember = "ImageIndex";
            this.repositoryItemMyPopupContainerEdit1.ImageList = this.imageCollection1;
            this.repositoryItemMyPopupContainerEdit1.Name = "repositoryItemMyPopupContainerEdit1";
            this.repositoryItemMyPopupContainerEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemMyPopupContainerEdit1.ValueMember = "Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 250);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.myPopupContainerEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPopupContainerEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMyPopupContainerEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dropDownItemBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private MyPopupContainerEdit myPopupContainerEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dataSourceClassBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colImageName;
        private RepositoryItemMyPopupContainerEdit repositoryItemMyPopupContainerEdit1;


    }
}

