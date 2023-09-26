using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// TODO: 1. Otwieranie manuala przy uruchomieniu :)

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        ComboBox listBox = new ComboBox(); // Kontrolka ComboBox do wyświetlania zmiennych
        private int newVarIterator = 0; // Licznik do śledzenia nowo utworzonych zmiennych
        private String name; // Nazwa zmiennej
        private int vart; // Wartość zmiennej
        List<Form1> vars = new List<Form1>(); // Lista do przechowywania utworzonych zmiennych jako instancji Form1
        private string[] varsTable = new String[500]; // Tablica do przechowywania informacji o zmiennych jako ciągów znaków

        // Konstruktor z parametrami do inicjowania nazwy i wartości zmiennej
        public Form1(string name, int vart) 
        { 
            this.name = name;
            this.vart = vart;
        } 

        // Konstruktor domyślny do inicjowania formularza Windows
        public Form1()
        {
            // this.txtBox.Location = new System.Drawing.Point(40, 25);
            InitializeComponent();
        }
        
        // Obsługa zdarzenia tworzenia nowej zmiennej po kliknięciu przycisku "newVar"
        private void newVar_Click(object sender, EventArgs e)
        {
            string varName = Microsoft.VisualBasic.Interaction.InputBox("Podaj nazwę zmiennej ", "Tworzenie zmiennej" );
            int varVar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Podaj wartość zmiennej", "Tworzenie zmiennej" ));
            
            MessageBox.Show("Utworzono zmienną o nazwie: " + varName + ", o wartości: " + varVar );
            
            // Dodaj nową zmienną do listy
            vars.Add(new Form1(varName, varVar));
            varsTable[newVarIterator] = vars[newVarIterator].name + ": " + vars[newVarIterator].vart;
            
            Console.Out.WriteLine("[ID: " + newVarIterator + "]" + " nazwa: " + vars[newVarIterator].name + " o wartości: " + vars[newVarIterator].vart);
            
            newVarIterator++;

            // throw new System.NotImplementedException();
        }

        void setvar_Click(object sender, EventArgs e)
        {
            Button buttonToMove = new Button();
            buttonToMove.Width = 500;
            buttonToMove.Location = new Point(400, 20);
            
            listBox.Width = 200;
            panel1.Controls.Add(buttonToMove);
            buttonToMove.Controls.Add(listBox);
            buttonToMove.SendToBack();
            listBox.BringToFront();
            
            // Ustaw źródło danych ComboBoxa do wyświetlania listy zmiennych
            listBox.DataSource = varsTable;
            
            listBox.Click += new System.EventHandler(listBox_Click);
            
            // throw new System.NotImplementedException();
        }

        private void listBox_Click(object sender, EventArgs e)
        {
            // Odśwież ComboBox z listą zmiennych
            listBox.DroppedDown = true;
            listBox.DataSource = null;
            listBox.DataSource = varsTable;
        }
    }
    
    // IDK WHY BUT WITHOUT IT IT DOSNT WORK 
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