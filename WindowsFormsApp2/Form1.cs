using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows;
using Microsoft.VisualBasic.ApplicationServices;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int newVarIterator = 0;
        private string name;
        private int vart;
        List<Form1> vars = new List<Form1>();
        
        public Form1(string name, int vart) 
        { 
            this.name = name;
            this.vart = vart;
        } 
        

        public Form1()
        {
            
           
            //this.txtBox.Location = new System.Drawing.Point(40, 25);

            InitializeComponent();
        }
        
        private void newVar_Click(object sender, EventArgs e)
        {

            
            string varName = Microsoft.VisualBasic.Interaction.InputBox("Podaj nazwę zmiennej ", "Tworzenie zmiennej" );
            int varVar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Podaj wartość zmiennej", "Tworzenie zmiennej" ));
            
            MessageBox.Show("Utworzono zmienną o nazwie: " + varName + ", o wartości: " + varVar );
            
            vars.Add(new Form1(varName, varVar));
            
            Console.Out.WriteLine("nazwa: " + vars[newVarIterator].name + " o wartości: " + vars[newVarIterator].vart);
            newVarIterator++;
            
            
            

            //throw new System.NotImplementedException();
            
        }
    }
}