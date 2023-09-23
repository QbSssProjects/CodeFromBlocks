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
        private List<Variable> vars = new List<Variable>();
        private int newVarIterator = 0;
        private String name;
        private int vart;
        private string[] varsTable = new String[500];
        
        
        public Form1(string name, int vart) 
        { 
            this.name = name;
            this.vart = vart;
            InitializeComponent();
        } 
        public Form1()
        {
            //this.txtBox.Location = new System.Drawing.Point(40, 25);
            InitializeComponent();
        }
        
        private void newVar_Click(object sender, EventArgs e)
        {
            string varName = Microsoft.VisualBasic.Interaction.InputBox("Podaj nazwę zmiennej", "Tworzenie zmiennej");
            int varVar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Podaj wartość zmiennej", "Tworzenie zmiennej"));

            MessageBox.Show("Utworzono zmienną o nazwie: " + varName + ", o wartości: " + varVar);

            vars.Add(new Variable(varName, varVar));
            varsTable[newVarIterator] = vars[newVarIterator].Name + ": " + vars[newVarIterator].Value;

            Console.Out.WriteLine("[ID: " + newVarIterator + "]" + " nazwa: " + vars[newVarIterator].Name + " o wartości: " + vars[newVarIterator].Value);

            newVarIterator++;
        }
        private void setVar_Click(object sender, EventArgs e)
        {
            var newButton = new Button();
            newButton.Text = "Ustaw Zmienną";
            var listBox = new ComboBox();
            newButton.Location = new Point(400, 20);
            newButton.Width = 400;
            listBox.Width = 200;
            //listBox.Items.AddRange(varsTable);
            foreach (var nItems in varsTable)
            {
                listBox.Items.Add(nItems);
            }
            //newButton.Controls.Add(listBox);
            //panel1.Controls.Add(newButton);
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