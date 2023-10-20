using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ChooseVar : Form
    {
        public ChooseVar()
        {
            InitializeComponent();
            
            listBoxChooseVar.DataSource = null;
            listBoxChooseVar.DataSource = varsTable;
        }
        private void listBoxChooseVar_Click(object sender, EventArgs e)
        {
            ComboBox listBoxChooseVar = sender as ComboBox;
            
            // Wymuszenie rozwinięcia "listBox" i aktualizacja źródła danych
            listBoxChooseVar.DroppedDown = true;
            listBoxChooseVar.DataSource = null;
            listBoxChooseVar.DataSource = varsTable;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //buttonsSetOn[indexClickedButton].Text = varSeted.ToString();
            //throw new System.NotImplementedException();
        }
    }
}