using System;
using System.Drawing;
using System.Windows.Forms;

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

        // Kontrolki GUI
        private ComboBox listBox = new ComboBox(); // Kontrolka ComboBox do wyświetlania zmiennych
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
        void setvar_Click(object sender, EventArgs e)
        {
            // Konfiguracja i rozmieszczenie kontrolki "buttonToMove" oraz "listBox"
            buttonToMove.Width = 500;
            buttonToMove.Location = new System.Drawing.Point(400, 20);

            listBox.Width = 200;
            panel1.Controls.Add(buttonToMove);
            buttonToMove.Controls.Add(listBox);
            buttonToMove.SendToBack();
            listBox.BringToFront();

            // Ustawienie źródła danych dla "listBox"
            listBox.DataSource = varsTable;

            // Obsługa kliknięcia na "listBox"
            listBox.Click += new System.EventHandler(listBox_Click);
        }

        // Obsługa kliknięcia na "listBox"
        private void listBox_Click(object sender, EventArgs e)
        {
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

        private void For_Click(object sender, EventArgs e)
        {
           // throw new System.NotImplementedException();
           
        }
    }

    
    
    // Klasa Variable (wydaje się być nieużywana)
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
