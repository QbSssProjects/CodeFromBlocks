using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ChooseVar : Form
    {
        public static int numberSeted;
        public ChooseVar()
        {
            InitializeComponent();
            
            comboBoxChooseVar.DataSource = null;
            comboBoxChooseVar.DataSource = Form1.varsTable;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxChooseVar.Enabled == false)
            {
                comboBoxChooseVar.Enabled = true;
                ChooseNumber.Enabled = false;
            }
            else
            {
                comboBoxChooseVar.Enabled = false;
            }
        }

        private void NumberRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxChooseVar.Enabled == false)
            {
                comboBoxChooseVar.Enabled = false;
                ChooseNumber.Enabled = true;
            }
            else
            {
                ChooseNumber.Enabled = false;
            }
        }
        
        


        private void ChooseNumber_ValueChanged(object sender, EventArgs e)
        {
            
            int numberSetedValue1 = (int)ChooseNumber.Value;
            
            ChoosseVarOn.clickedButton.Text = numberSetedValue1.ToString();
            
            //throw new System.NotImplementedException();
        }
    }
}