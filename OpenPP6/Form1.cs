using System.Diagnostics;

namespace OpenPP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close_And_Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_OpenPP6.Enabled = false;
        }

        private void Cbx_VideoOn_CheckedChanged(object sender, EventArgs e)
        {
            Check_All_Boxes();
        }

        private void Cbx_ProjectorsOn_CheckedChanged(object sender, EventArgs e)
        {
            Check_All_Boxes();
        }

        private void Cbx_AlterLigthsOn_CheckedChanged(object sender, EventArgs e)
        {
            Check_All_Boxes();
        }
        private void Check_All_Boxes()
        {
            if (Cbx_VideoOn.Checked && Cbx_ProjectorsOn.Checked && Cbx_AlterLigthsOn.Checked)
            {
                Btn_OpenPP6.Enabled = true;
            }
            else
            {
                Btn_OpenPP6.Enabled = false;
            }
        }
        private void Close_And_Exit()
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Btn_OpenPP6_Click(object sender, EventArgs e)
        {
            Process Runpp6 = new Process();
            Runpp6.StartInfo.FileName = "C:\\Program Files (x86)\\Renewed Vision\\ProPresenter 6\\ProPresenter.exe";
            Runpp6.Start();
            Close_And_Exit();
        }
    }
}