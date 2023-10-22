using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using static WindowsFormsApp2.Form1;

namespace WindowsFormsApp2
{
    public partial class ChoosseVarOn : Form
    {
        public static int varSeted;
        
        public static Button clickedButton;
        
        public ChoosseVarOn()
        {
            var classForm = new Form1();

            InitializeComponent();
        }

        //dodawaniexD
        private void AddRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (Add1.Enabled == false && Add2.Enabled == false)
            {
                Add1.Enabled = true;
                Add2.Enabled = true;
                
                Sub1.Enabled = false;
                Sub2.Enabled = false;

                Multipy1.Enabled = false;
                Multipy2.Enabled = false;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = false;
                Mod2.Enabled = false;

                OnVar.Enabled = false;
                OnNumer.Enabled = false;
                
            }
            else
            {
                Add1.Enabled = false;
                Add2.Enabled = false;
            }
        }

        private void SubRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (Sub1.Enabled == false && Sub2.Enabled == false)
            {
                Add1.Enabled = false;
                Add2.Enabled = false;

                Sub1.Enabled = true;
                Sub2.Enabled = true;
                
                Multipy1.Enabled = false;
                Multipy2.Enabled = false;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = false;
                Mod2.Enabled = false;

                OnVar.Enabled = false;
                OnNumer.Enabled = false;
            }
            else
            {
                Sub1.Enabled = false;
                Sub2.Enabled = false;
            }
        }

        private void MultipyRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (Multipy1.Enabled == false && Multipy2.Enabled == false)
            {
                Add1.Enabled = false;
                Add2.Enabled = false;

                Sub1.Enabled = false;
                Sub2.Enabled = false;
                
                Multipy1.Enabled = true;
                Multipy2.Enabled = true;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = false;
                Mod2.Enabled = false;

                OnVar.Enabled = false;
                OnNumer.Enabled = false;

                Multipy1.Enabled = true;
                Multipy2.Enabled = true;
            }
            else
            {
                Multipy1.Enabled = false;
                Multipy2.Enabled = false;
            }
        }

        private void DivRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (Div1.Enabled == false && Div2.Enabled == false)
            {
                Add1.Enabled = false;
                Add2.Enabled = false;

                Sub1.Enabled = false;
                Sub2.Enabled = false;

                Multipy1.Enabled = false;
                Multipy2.Enabled = false;
                
                Div1.Enabled = true;
                Div2.Enabled = true;

                Mod1.Enabled = false;
                Mod2.Enabled = false;

                OnVar.Enabled = false;
                OnNumer.Enabled = false;
            }
            else
            {
                Div1.Enabled = false;
                Div2.Enabled = false;
            }
        }

        private void ModRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (Mod1.Enabled == false && Mod2.Enabled == false)
            {
                Add1.Enabled = false;
                Add2.Enabled = false;

                Sub1.Enabled = false;
                Sub2.Enabled = false;

                Multipy1.Enabled = false;
                Multipy2.Enabled = false;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = true;
                Mod2.Enabled = true;
                
                OnVar.Enabled = false;
                OnNumer.Enabled = false;
            }
            else
            {
                Mod1.Enabled = false;
                Mod2.Enabled = false;
            }
        }

        private void OnVarRadio_CheckedChanged(object sender, EventArgs e)
        {
            
            if (OnVar.Enabled == false)
            {
                Add1.Enabled = false;
                Add2.Enabled = false;

                Sub1.Enabled = false;
                Sub2.Enabled = false;

                Multipy1.Enabled = false;
                Multipy2.Enabled = false;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = false;
                Mod1.Enabled = false; 
                
                OnVar.Enabled = true;
                OnNumer.Enabled = false;
            }
            else
            {
                OnVar.Enabled = false;
            }
        }
        
        private void OnVar_Clicked(object sender, EventArgs e)
        {
            OnVar.DataSource = null;
            OnVar.DataSource = varsTable;

            OnVar.DroppedDown = true;
        }
        
        private void OnNumberRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (OnNumer.Enabled == false)
            {
                Add1.Enabled = false;
                Add2.Enabled = false;

                Sub1.Enabled = false;
                Sub2.Enabled = false;

                Multipy1.Enabled = false;
                Multipy2.Enabled = false;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = false;
                Mod1.Enabled = false; 
                
                OnVar.Enabled = false;
                OnNumer.Enabled = true;
            }
            else
            {
                OnNumer.Enabled = false;
            }
        }
        
        private void OnNumer_ValueChanged(object sender, EventArgs e)
        {
            varSeted = (int)OnNumer.Value;
            //Console.Out.WriteLine(varSeted);
            buttonsSetOn[index].Text = varSeted.ToString();

            //throw new System.NotImplementedException();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            // TUTAJ MASZ OGARNIETE TTYLKO DLA LICZBY WBRAN EJ 9OSTATNIA OPCJA)
            codeLinesList.Add(tempVarNameDone + " = " + OnNumer.Value);
            
            this.Close();
        }
        
        //Wywoływanie okna ChooseVar
        private void Add1_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Add2_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Sub1_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Sub2_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Multipy1_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Multipy2_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Div1_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Div2_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Mod1_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Mod2_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }
    }
}