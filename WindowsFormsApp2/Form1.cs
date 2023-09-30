using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // Pola klasy Form1
        private int newVarIterator = 0; // Licznik do śledzenia nowo utworzonych zmiennych
        private string name; // Nazwa zmiennej
        private int vart; // Wartość zmiennej
        private string[] varsTable = new string[500]; // Tablica do przechowywania informacji o zmiennych jako ciągów znaków
        private bool isButtonMoving = false;
        private int mouseX;
        private int mouseY;
        private bool isButtonStartClicked = false;
        
        private List<Button> buttons = new List<Button>();
        private List<ComboBox> comboBoxes = new List<ComboBox>();
        
        private int iteratorButtonY = 60;

        // Kontrolki GUI
        private Button buttonToMove = new Button();

        // Konstruktor z argumentami name i vart (nie wydaje się być używany)
        public Form1(string name, int vart)
        {
            this.name = name;
            this.vart = vart;
        }

        // Konstruktor domyślny
        public Form1()
        {
            InitializeComponent();
        }

        // Obsługa kliknięcia przycisku "newVar"
        private void newVar_Click(object sender, EventArgs e)
        {
            // Wyświetlanie okna dialogowego do wprowadzenia nazwy i wartości zmiennej
            string varName = Microsoft.VisualBasic.Interaction.InputBox("Podaj nazwę zmiennej ", "Tworzenie zmiennej");
            int varVar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Podaj wartość zmiennej", "Tworzenie zmiennej"));

            // Wyświetlanie informacji o utworzonej zmiennej
            MessageBox.Show("Utworzono zmienną o nazwie: " + varName + ", o wartości: " + varVar);
            
            Console.Out.WriteLine("[ID: " + newVarIterator + "] " + varName + " o wartosci: " + varVar);

            // Dodawanie informacji o zmiennej do tablicy
            varsTable[newVarIterator] = varName + ": " + varVar;
            newVarIterator++;
        }

        // Obsługa kliknięcia przycisku "setvar"
        

        // Obsługa kliknięcia na "listBox"
        private void listBox_Click(object sender, EventArgs e)
        {
            ComboBox listBox = sender as ComboBox;
            Console.Out.WriteLine("TEST 1");
            Console.Out.WriteLine(varsTable[0]);
            // Wymuszenie rozwinięcia "listBox" i aktualizacja źródła danych
            listBox.DroppedDown = true;
            listBox.DataSource = null;
            listBox.DataSource = varsTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button buttonStart = sender as Button;

            if (!isButtonStartClicked)
            {
                
                buttonStart.BackColor = Color.Yellow;
                isButtonStartClicked = true;
                
            }
            else
            {
                
                buttonStart.BackColor = Color.FromArgb(255, 255, 255);
                isButtonStartClicked = false;
                
            }

            //throw new System.NotImplementedException();
        }

        private void setvar_Click_1(object sender, EventArgs e)
        {
            // Tworzenie nowego przycisku
            Button newButton = new Button();
            ComboBox listBox = new ComboBox();

            newButton.Text = "Nowy Przycisk";
            newButton.Width = 221;
            newButton.Height = 30;
            newButton.BackColor = Color.FromArgb(255, 255, 255);
            newButton.Location = new Point(488, iteratorButtonY);

            // Obsługa kliknięcia na nowym przycisku
            newButton.Click += new EventHandler(NewButtonClick);
            listBox.Click += new EventHandler(listBox_Click);

            // Dodanie przycisku do listy przycisków
            buttons.Add(newButton);
            comboBoxes.Add(listBox);

            // Dodanie przycisku do formularza
            listBox.Width = 200;
            panel1.Controls.Add(newButton);
            
            newButton.Controls.Add(listBox);
            newButton.SendToBack();
            listBox.BringToFront();
            listBox.DataSource = null;
            listBox.DataSource = varsTable;

            iteratorButtonY += 60;
        }

// Obsługa kliknięcia na nowym przycisku
        private void NewButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show("Kliknięto przycisk: " + clickedButton.Text);
        }
    }
}
