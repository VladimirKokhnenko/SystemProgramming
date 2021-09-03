using System.Windows.Forms;

namespace ExamAtWinForms
{
    public partial class FormTest : Form
    {
        public ListBox ForPrint
        {
            get => listBoxTest;
            set => listBoxTest = value;
        }

        public FormTest()
        {
            InitializeComponent();
        }
    }
}
