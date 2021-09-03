using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3
{
    public partial class NonModalWindow : Form
    {
        public Label PropCounter
        {
            get => Counter;
            set => Counter = value;
        }

        public NonModalWindow()
        {
            InitializeComponent();
        }

        public void CloseForm()
        {
            Close();
        }
    }
}
