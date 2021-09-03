using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class FormInfo : Form
    {
        public string Path { get; set; }
        public Label LCountFiles { get => LabelCountFiles; set => LabelCountFiles = value; }
        public Label LScope { get => LabelScopeFiles; set => LabelScopeFiles = value; }

        public FormInfo(string path)
        {
            InitializeComponent();
            Path = path;
        }

        public void FormInfoClose()
        {
            Close();
        }
    }
}
