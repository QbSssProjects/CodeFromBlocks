using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using static WindowsFormsApp2.Form1;

namespace WindowsFormsApp2
{
    public partial class ChoosseVarOn : Form
    {
        public static int varSeted;

        public static int indexClickedButton;
        
        internal static List<Button> buttonsChooseVar = new List<Button>();
        
        public ChoosseVarOn()
        {
            var classForm = new Form1();

            InitializeComponent();
        }

        //dodawanie
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

            //throw new System.NotImplementedException();
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
            
            
            //throw new System.NotImplementedException();
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
            
            
            //throw new System.NotImplementedException();
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
            
            //throw new System.NotImplementedException();
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
            
            //throw new System.NotImplementedException();
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
            
            //throw new System.NotImplementedException();
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
            
            //throw new System.NotImplementedException();
        }

        private void OnVar_Clicked(object sender, EventArgs e)
        {
            OnVar.DataSource = null;
            OnVar.DataSource = varsTable;

            OnVar.DroppedDown = true;

            //throw new System.NotImplementedException();
        }

        private void OnNumer_ValueChanged(object sender, EventArgs e)
        {
            varSeted = (int)OnNumer.Value;
            //Console.Out.WriteLine(varSeted);
            buttonsSetOn[index].Text = varSeted.ToString();

            //throw new System.NotImplementedException();
        }
        
        /*private void Ok_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }*/

        private void Ok_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
        
        
        private void Add1_Click(object sender, EventArgs e)
        {
            Button buttonChooseVar = new Button();
            
            buttonChooseVar.Click += new EventHandler(buttonChooseVar_Click);
            buttonsChooseVar.Add(buttonChooseVar);
            
            //throw new System.NotImplementedException();
        }

        private void buttonChooseVar_Click(object sender, EventArgs e)
        {
            
            index = buttonsSetOn.IndexOf(sender as Button);
            //Console.Out.WriteLine(index + "|||");

            var ChooseForm = new ChoosseVarOn();
            ChooseForm.Show();
            
            //throw new System.NotImplementedException();
        }
    }
}