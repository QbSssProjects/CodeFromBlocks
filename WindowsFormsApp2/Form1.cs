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
        ComboBox listBox = new ComboBox();
        private int newVarIterator = 0;
        private String name;
        private int vart;
        List<Form1> vars = new List<Form1>();
        private string[] varsTable = new String[500];
        
        


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
            varsTable[newVarIterator] = vars[newVarIterator].name + ": " + vars[newVarIterator].vart;
            
            Console.Out.WriteLine("[ID: " + newVarIterator + "]" + " nazwa: " + vars[newVarIterator].name + " o wartości: " + vars[newVarIterator].vart);
            
            newVarIterator++;

            //throw new System.NotImplementedException();
           
        }

//TODO: OGARNIJ TO ABY W listBox wszystkie elemeny  z listy zadelklarowanej dawał //*
//TODO: Jak wpiszesz w googla "listbox c# documentation" to powiniwenes wszystko wiedziec SIEMA //*
        void setvar_Click(object sender, EventArgs e)
        {

            
            listBox.Location = new Point(400, 20);
            listBox.Width = 200;
            panel1.Controls.Add(listBox);
            listBox.DataSource = varsTable;
            
            listBox.Click += new System.EventHandler(listBox_Click);
            
            //throw new System.NotImplementedException();

        }

        private void listBox_Click(object sender, EventArgs e)
        {
            listBox.DroppedDown = true;
            listBox.DataSource = null;
            listBox.DataSource = varsTable;

        }
        

        
    }
    public class Variable
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public Variable(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}