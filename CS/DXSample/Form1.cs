using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Registrator;

namespace DXSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            for (int i = 0; i < imageCollection1.Images.Count; i++) {
                DropDownItem item = new DropDownItem();
                item.ImageIndex = i;
                item.Description = imageCollection1.Images.Keys[i];
                dropDownItemBindingSource.Add(item);
            }
            dataSourceClassBindingSource.AddNew();
            dataSourceClassBindingSource.AddNew();
            dataSourceClassBindingSource.AddNew();
        }
    }
    public class DataSourceClass {
        private string _Name;
        public string Name {
            get { return _Name; }
            set {
                _Name = value;
            }
        }
        private string _ImageName;
        public string ImageName {
            get { return _ImageName; }
            set {
                _ImageName = value;
            }
        }
        
    }
    public class DropDownItem {
        private string _Description;
        public string Description {
            get { return _Description; }
            set {
                _Description = value;
            }
        }
        private int _ImageIndex;
        public int ImageIndex {
            get { return _ImageIndex; }
            set {
                _ImageIndex = value;
            }
        }
        
    }
}