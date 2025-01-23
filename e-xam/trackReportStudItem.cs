using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_xam
{
    [Serializable]
    public partial class trackReportStudItem : UserControl
    {
        private string _studNum;
        private string _studName;
        private string _studGPA;

        public trackReportStudItem()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string StudNum
        {
            get { return _studNum; }
            set { _studNum = value; studNumLbl.Text = value; }
        }
        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string StudName
        {
            get { return _studName; }
            set { _studName = value; studNameLbl.Text = value; }
        }

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string StudGPA
        {
            get { return _studGPA; }
            set { _studGPA = value; gpaLbl.Text = value; }
        }
    }
}

