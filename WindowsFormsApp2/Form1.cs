﻿//IGNACY:
// * zrób listę Stringów wyjściowych 
// * kazda delkarke wartosci dodawaj na sam przód listy
// * ogarnij forma do wybierania wartosci na przypiasnie 2 ChoosevarOn
// * zaimplementuj reszte przyciskow 
// * dodaj generacje kodu
// * jesli starczy czasu dodaj scrolla zeby przesowac gora / dol panel z kodem 
//jakby cos to dzwon UwU


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    
    public partial class Form1 : Form
    {
        // Pola klasy Form1

        // Licznik do śledzenia nowo utworzonych zmiennych
        private int newVarIterator = 0;
        
        // Nazwa zmiennej
        private string name;
        
        // Wartość zmiennej
        private int vart;
        
        // Tablica do przechowywania informacji o zmiennych jako ciągów znaków
        public static string[] varsTable = new string[500];
        
        // Flaga wskazująca, czy przycisk jest przesuwany
        private bool isButtonMoving = false;
        
        // Pozycja myszy
        private int mouseX;
        private int mouseY;
        
        // Flaga wskazująca, czy przycisk "start" został kliknięty
        private bool isButtonStartClicked = false;

        // Listy kontrolki GUI
        private List<Button> buttons = new List<Button>();
        private List<ComboBox> comboBoxes = new List<ComboBox>();
        private List<TextBox> textBoxesSet = new List<TextBox>();
        private List<TextBox> textBoxesOn = new List<TextBox>();
        private List<Button> varSettedButtons = new List<Button>();
        internal static  List<Button> buttonsSetOn = new List<Button>();
        
        // Pozycja dla kolejnego przycisku
        private int iteratorButtonY = 60;

        // Kontrolki GUI

        public static int index;

        private bool flagVarAccepted = true;
        
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
            var varVarStr = Microsoft.VisualBasic.Interaction.InputBox("Podaj wartość zmiennej", "Tworzenie zmiennej", "0");


            int varVar;
            if (int.TryParse(varVarStr, out varVar))
             {
                 flagVarAccepted = true;
                Console.Out.WriteLine(varVar);
             }
             else
            {
                flagVarAccepted = false;
                MessageBox.Show("BŁĄD! PODAJ WARTOŚĆ LICZBOWĄ");
            }

            if (flagVarAccepted)
            {
                MessageBox.Show("Utworzono zmienną o nazwie: " + varName + ", o wartości: " + varVar);
            
                Console.Out.WriteLine("[ID: " + newVarIterator + "] " + varName + " o wartosci: " + varVar);

                // Dodawanie informacji o zmiennej do tablicy
                varsTable[newVarIterator] = varName + ": " + varVar;
                newVarIterator++;


                /*Button varSetted = new Button();
                varSetted.Text = "Ustawiono wartość " + varName + " na: " + varVar;
                varSetted.Width = 283;
                varSetted.Height = 30;
                varSetted.BackColor = Color.FromArgb(255, 255, 255);
                varSetted.Location = new Point(488, iteratorButtonY);

                iteratorButtonY += 30;
                varSettedButtons.Add(varSetted);
                
                panel1.Controls.Add(varSetted);*/
            }
            
        }

        // Obsługa kliknięcia przycisku "setvar"
        private void setvar_Click_1(object sender, EventArgs e)
        {
            // Tworzenie nowego przycisku
            Button newButton = new Button();
            ComboBox listBox = new ComboBox();
            TextBox textBoxSet = new TextBox();
            TextBox textBoxOn = new TextBox();
            Button buttonSetOn = new Button();
            
            
            newButton.Text = "";
            newButton.Width = 283;
            newButton.Height = 30;
            newButton.BackColor = Color.FromArgb(255, 255, 255);
            newButton.Location = new Point(488, iteratorButtonY);
            
            listBox.Location = new Point(40, 5);

            textBoxSet.Text = "Ustaw";
            textBoxSet.Location = new Point(3, 8);
            textBoxSet.Width = 37;
            textBoxSet.ReadOnly = true;
            textBoxSet.BorderStyle = BorderStyle.None;
            textBoxSet.BackColor = Color.FromArgb(255, 255, 255);

            textBoxOn.Text = "Na";
            textBoxOn.Location = new Point(144, 8);
            textBoxOn.Width = 20;
            textBoxOn.ReadOnly = true;
            textBoxOn.BorderStyle = BorderStyle.None;
            textBoxOn.BackColor = Color.FromArgb(255, 255, 255);

            buttonSetOn.Text = "Wybierz";
            buttonSetOn.Location = new Point(167, 5);
            
            // Obsługa kliknięcia na nowym przycisku
            listBox.Click += new EventHandler(listBox_Click);
            buttonSetOn.Click += new EventHandler(buttonSetOn_Click);
            buttonsSetOn.Add(buttonSetOn);

            // Dodanie przycisku do listy przycisków
            buttons.Add(newButton);
            comboBoxes.Add(listBox);
            textBoxesOn.Add(textBoxOn);
            textBoxesSet.Add(textBoxSet);
            

            // Dodanie przycisku do formularza
            listBox.Width = 100;
            
            panel1.Controls.Add(newButton);
            newButton.Controls.Add(textBoxSet);
            newButton.Controls.Add(listBox);
            newButton.Controls.Add(textBoxOn);
            newButton.Controls.Add(buttonSetOn);
            
            newButton.SendToBack();
            listBox.BringToFront();
            textBoxSet.BringToFront();
            textBoxOn.BringToFront();
            buttonSetOn.BringToFront();
            
            listBox.DataSource = null;
            listBox.DataSource = varsTable;

            iteratorButtonY += 30;

            //buttonSetOn.Tag = buttonsSetOn.IndexOf(buttonSetOn);
        }

        // Obsługa kliknięcia przycisku "button1"
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
        }

        // Obsługa kliknięcia na ComboBox "listBox"
        private void listBox_Click(object sender, EventArgs e)
        {
            ComboBox listBox = sender as ComboBox;
            
            // Wymuszenie rozwinięcia "listBox" i aktualizacja źródła danych
            listBox.DroppedDown = true;
            listBox.DataSource = null;
            listBox.DataSource = varsTable;
        }

        // Obsługa kliknięcia na nowym przycisku
        private void buttonSetOn_Click(object sender, EventArgs e)
        {
            index = buttonsSetOn.IndexOf(sender as Button);
            Console.Out.WriteLine(index);
            
            var ChooseForm = new ChoosseVarOn();
            ChooseForm.Show();
        }
    }
}