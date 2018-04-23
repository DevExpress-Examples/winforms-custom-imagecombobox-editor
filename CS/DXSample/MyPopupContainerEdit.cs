using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace DXSample {
    [UserRepositoryItem("Register")]
    public class RepositoryItemMyPopupContainerEdit : RepositoryItemPopupContainerEdit {
        static RepositoryItemMyPopupContainerEdit() {
            Register();
        }
        ImageListBoxControl imageListBox;
        public RepositoryItemMyPopupContainerEdit() {
            PopupContainerControl popupControl = new PopupContainerControl();
            imageListBox = new ImageListBoxControl();
            imageListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            imageListBox.HotTrackItems = true;
            imageListBox.HotTrackSelectMode = HotTrackSelectMode.SelectItemOnClick;
            popupControl.Controls.Add(imageListBox);
            PopupControl = popupControl;
            TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }
        [AttributeProvider(typeof(IListSource)), DefaultValue(null), RefreshProperties(RefreshProperties.Repaint), Category("Data")]
        public object DataSource {
            get {
                return imageListBox.DataSource;
            }
            set {
                imageListBox.DataSource = value;
            }
        }
        protected internal ImageListBoxControl ListBox {
            get {
                return imageListBox;
            }
        }
        [Category(CategoryName.Appearance), DefaultValue(null),
        TypeConverter(typeof(DevExpress.Utils.Design.ImageCollectionImagesConverter))]
        public object ImageList {
            get {
                return imageListBox.ImageList;
            }
            set {
                imageListBox.ImageList = value;
            }
        }
        [Category(CategoryName.Data), DefaultValue(""),
        TypeConverter("DevExpress.XtraEditors.Design.DataMemberTypeConverter, " + AssemblyInfo.SRAssemblyEditorsDesign)]
        public string ImageIndexMember {
            get { return imageListBox.ImageIndexMember; }
            set {
                imageListBox.ImageIndexMember = value;
            }
        }
        [Category(CategoryName.Data), DefaultValue(""),
TypeConverter("DevExpress.XtraEditors.Design.DataMemberTypeConverter, " + AssemblyInfo.SRAssemblyEditorsDesign)]
        public string DisplayMember {
            get { return imageListBox.DisplayMember; }
            set {
                imageListBox.DisplayMember = value;
            }
        }
        [Category(CategoryName.Data), DefaultValue(""),
TypeConverter("DevExpress.XtraEditors.Design.DataMemberTypeConverter, " + AssemblyInfo.SRAssemblyEditorsDesign)]
        public string ValueMember {
            get { return imageListBox.ValueMember; }
            set {
                imageListBox.ValueMember = value;
            }
        }
        internal const string EditorName = "MyPopupContainerEdit";

        public static void Register() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyPopupContainerEdit),
                typeof(RepositoryItemMyPopupContainerEdit), typeof(DevExpress.XtraEditors.ViewInfo.PopupContainerEditViewInfo),
                new DevExpress.XtraEditors.Drawing.ButtonEditPainter(), true, null, typeof(DevExpress.Accessibility.PopupEditAccessible)));
        }
        public override string EditorTypeName {
            get { return EditorName; }
        }
        public override void Assign(RepositoryItem item) {
            base.Assign(item);
            if (item is RepositoryItemMyPopupContainerEdit) {
                imageListBox = ((RepositoryItemMyPopupContainerEdit)item).ListBox;
            }
        }
    }

    public class MyPopupContainerEdit : PopupContainerEdit {
        static MyPopupContainerEdit() {
            RepositoryItemMyPopupContainerEdit.Register();
        }

        public MyPopupContainerEdit() {}

        public override string EditorTypeName {
            get { return RepositoryItemMyPopupContainerEdit.EditorName; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyPopupContainerEdit Properties {
            get { return base.Properties as RepositoryItemMyPopupContainerEdit; }
        }
        public override void ShowPopup() {
            Properties.ListBox.SelectedValue = EditValue;
            base.ShowPopup();
        }
        void ListBox_SelectedIndexChanged(object sender, EventArgs e) {
            EditValue = Properties.ListBox.SelectedValue;
        }
        protected override void OnPopupShown() {
            base.OnPopupShown();
            Properties.ListBox.SelectedIndexChanged += new EventHandler(ListBox_SelectedIndexChanged);
            Properties.ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(ListBox_MouseDown);
        }

        void ListBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            ClosePopup();
            EditValue = Properties.ListBox.SelectedValue;
        }
        public override void ClosePopup() {
            base.ClosePopup();
            Properties.ListBox.SelectedIndexChanged -= new EventHandler(ListBox_SelectedIndexChanged);
            Properties.ListBox.MouseDown -= new System.Windows.Forms.MouseEventHandler(ListBox_MouseDown);
        }
    }
}
