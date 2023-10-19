﻿using System;
using System.Windows.Forms;
using static WindowsFormsApp2.Form1;

namespace WindowsFormsApp2
{
    public partial class ChoosseVarOn : Form
    {
        public static int varSeted; 
        
        public ChoosseVarOn()
        {
            var classForm = new Form1();
            
            InitializeComponent();
        }


        private void radioButton1_Checked(object sender, EventArgs e)
        {
            Console.Out.WriteLine("AAAA");
            //throw new System.NotImplementedException();
        }

        private void AddRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (Add1.Enabled == false && Add2.Enabled == false)
            {
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

                Add1.Enabled = true;
                Add2.Enabled = true;
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

                Multipy1.Enabled = false;
                Multipy2.Enabled = false;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = false;
                Mod2.Enabled = false;

                OnVar.Enabled = false;
                OnNumer.Enabled = false;
  
                Sub1.Enabled = true;
                Sub2.Enabled = true;
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

                Mod1.Enabled = false;
                Mod2.Enabled = false;

                OnVar.Enabled = false;
                OnNumer.Enabled = false;

                Div1.Enabled = true;
                Div2.Enabled = true;
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

                OnVar.Enabled = false;
                OnNumer.Enabled = false;

                Mod1.Enabled = true;
                Mod2.Enabled = true;
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
                
                OnNumer.Enabled = false;

                OnVar.Enabled = true;
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
    }
}