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
        public static string[] ifOperators = { "==", "<=", ">=", "!=", "<", ">" };
        
        // Flaga wskazująca, czy przycisk jest przesuwany
        private bool isButtonMoving = false;
        
        // Pozycja myszy
        private int mouseX;
        private int mouseY;
        
        // Flaga wskazująca, czy przycisk "start" został kliknięty
        private bool isButtonStartClicked = false;
        private bool isIfButtonClicked = false;
        private bool isNewVarButtonClicked = false;

        public static int ButtonLocationX = 488;

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

        // Obsługa kliknięcia przycisku "button1" (POCZĄTEK)
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
            ComboBox comboBox = new ComboBox();
            TextBox textBoxSet = new TextBox();
            TextBox textBoxOn = new TextBox();
            Button buttonSetOn = new Button();
            
            
            newButton.Text = "";
            newButton.Width = 283;
            newButton.Height = 30;
            newButton.BackColor = Color.FromArgb(255, 255, 255);
            newButton.Location = new Point(ButtonLocationX, iteratorButtonY);
            
            comboBox.Location = new Point(40, 5);

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
            comboBox.Click += new EventHandler(comboBox_Click);
            buttonSetOn.Click += new EventHandler(buttonSetOn_Click);
            buttonsSetOn.Add(buttonSetOn);

            // Dodanie przycisku do listy przycisków
            buttons.Add(newButton);
            comboBoxes.Add(comboBox);
            textBoxesOn.Add(textBoxOn);
            textBoxesSet.Add(textBoxSet);
            

            // Dodanie przycisku do formularza
            comboBox.Width = 100;
            
            panel1.Controls.Add(newButton);
            newButton.Controls.Add(textBoxSet);
            newButton.Controls.Add(comboBox);
            newButton.Controls.Add(textBoxOn);
            newButton.Controls.Add(buttonSetOn);
            
            newButton.SendToBack();
            comboBox.BringToFront();
            textBoxSet.BringToFront();
            textBoxOn.BringToFront();
            buttonSetOn.BringToFront();
            
            comboBox.DataSource = null;
            comboBox.DataSource = varsTable;

            newButton.Click += new EventHandler(newVarButton_Click);
            
            iteratorButtonY += 30;

            //buttonSetOn.Tag = buttonsSetOn.IndexOf(buttonSetOn);
        }
        
        //Obsługa kliknięcia na przycisk newVarButton
        private void newVarButton_Click(object sender, EventArgs e)
        {
            Button newVarButton = sender as Button;

            if (!isNewVarButtonClicked)
            {
                newVarButton.BackColor = Color.Yellow;
                isNewVarButtonClicked = true;
            }
            else
            {
                newVarButton.BackColor = Color.FromArgb(255, 255, 255);
                isNewVarButtonClicked = false;
            }
        }
        
        //Obsługa przycisku If (Jeśli)
        private void If_Click(object sender, EventArgs e)
        {
            // Tworzenie nowego przycisku
            Button IfButton = new Button();
            ComboBox comboBoxVar = new ComboBox();
            ComboBox comboBoxVar1 = new ComboBox();
            ComboBox comboBoxIf = new ComboBox();
            TextBox textBoxIf = new TextBox();
            TextBox textBoxThen = new TextBox();
            
            
            IfButton.Text = "";
            IfButton.Width = 283;
            IfButton.Height = 30;
            IfButton.BackColor = Color.FromArgb(255, 255, 255);
            IfButton.Location = new Point(ButtonLocationX, iteratorButtonY);
            

            textBoxIf.Text = "Jezeli";
            textBoxIf.Location = new Point(3, 8);
            textBoxIf.Width = 33;
            textBoxIf.ReadOnly = true;
            textBoxIf.BorderStyle = BorderStyle.None;
            textBoxIf.BackColor = Color.FromArgb(255, 255, 255);
            
            textBoxThen.Text = "to:";
            textBoxThen.Location = new Point(263, 8);
            textBoxThen.Width = 15;
            textBoxThen.ReadOnly = true;
            textBoxThen.BorderStyle = BorderStyle.None;
            textBoxThen.BackColor = Color.FromArgb(255, 255, 255);
            
            comboBoxVar.Location = new Point(34, 5);
            comboBoxIf.Location = new Point(122, 5);
            comboBoxVar1.Location = new Point(175, 5);
            
            comboBoxVar.Click += new EventHandler(comboBox_Click);
            comboBoxVar1.Click += new EventHandler(comboBox_Click);
            
            // Dodanie przycisku do listy przycisków
            buttons.Add(IfButton);
            comboBoxes.Add(comboBoxVar);
            comboBoxes.Add(comboBoxVar1);
            comboBoxes.Add(comboBoxIf);
            textBoxesOn.Add(textBoxIf);
            textBoxesOn.Add(textBoxThen);
            
            // Dodanie przycisku do formularza
            comboBoxVar.Width = 85;
            comboBoxVar1.Width = 85;
            comboBoxIf.Width = 50;
            
            //Dodanie kontrolek do formularza
            panel1.Controls.Add(IfButton);
            IfButton.Controls.Add(textBoxIf); //Jeśli
            IfButton.Controls.Add(comboBoxVar); //Var1
            IfButton.Controls.Add(comboBoxIf);  //Warunek
            IfButton.Controls.Add(comboBoxVar1);//Var2
            IfButton.Controls.Add(textBoxThen); //To: 
            
            
            IfButton.SendToBack();
            textBoxIf.BringToFront();
            comboBoxVar.BringToFront();
            comboBoxIf.BringToFront();
            comboBoxVar1.BringToFront();
            textBoxThen.BringToFront();
            
            comboBoxVar.DataSource = null;
            comboBoxVar.DataSource = varsTable;
            comboBoxVar1.DataSource = null;
            comboBoxVar1.DataSource = varsTable;
            comboBoxIf.DataSource = ifOperators;
            
            IfButton.Click += new EventHandler(IfButton_Click);

            ButtonLocationX += 36;
            iteratorButtonY += 30;
        }
        
        // Obsługa kliknięcia na ComboBox "comboBox"
        private void comboBox_Click(object sender, EventArgs e) 
        {
            ComboBox comboBox = sender as ComboBox;
            
            // Wymuszenie rozwinięcia "comboBox" i aktualizacja źródła danych
            comboBox.DroppedDown = true;
            comboBox.DataSource = null;
            comboBox.DataSource = varsTable;
        }

        // Obsługa kliknięcia na nowym przycisku
        private void buttonSetOn_Click(object sender, EventArgs e)
        {
            index = buttonsSetOn.IndexOf(sender as Button);
            Console.Out.WriteLine(index);
            
            var ChooseForm = new ChoosseVarOn();
            ChooseForm.Show();
        }

        private void IfButton_Click(object sender, EventArgs e)
        {
            Button IfButton = sender as Button;

            if (!isIfButtonClicked)
            {
                IfButton.BackColor = Color.Yellow;
                isIfButtonClicked = true;
            }
            else
            {
                IfButton.BackColor = Color.FromArgb(255, 255, 255);
                isIfButtonClicked = false;
            }
        }

        private void endIf_Click(object sender, EventArgs e)
        {
            ButtonLocationX -= 36;
            MessageBox.Show("Wyszedłeś/aś z warunku");
        }

        private void ifElse_Click(object sender, EventArgs e)
        {
            //IF
            // Tworzenie nowego przycisku
            Button IfButton = new Button();
            ComboBox comboBoxVar = new ComboBox();
            ComboBox comboBoxVar1 = new ComboBox();
            ComboBox comboBoxIf = new ComboBox();
            TextBox textBoxIf = new TextBox();
            TextBox textBoxThen = new TextBox();
            
            
            IfButton.Text = "";
            IfButton.Width = 283;
            IfButton.Height = 30;
            IfButton.BackColor = Color.FromArgb(255, 255, 255);
            IfButton.Location = new Point(ButtonLocationX, iteratorButtonY);
            

            textBoxIf.Text = "Jezeli";
            textBoxIf.Location = new Point(3, 8);
            textBoxIf.Width = 33;
            textBoxIf.ReadOnly = true;
            textBoxIf.BorderStyle = BorderStyle.None;
            textBoxIf.BackColor = Color.FromArgb(255, 255, 255);
            
            textBoxThen.Text = "to:";
            textBoxThen.Location = new Point(263, 8);
            textBoxThen.Width = 15;
            textBoxThen.ReadOnly = true;
            textBoxThen.BorderStyle = BorderStyle.None;
            textBoxThen.BackColor = Color.FromArgb(255, 255, 255);
            
            comboBoxVar.Location = new Point(34, 5);
            comboBoxIf.Location = new Point(122, 5);
            comboBoxVar1.Location = new Point(175, 5);
            
            comboBoxVar.Click += new EventHandler(comboBox_Click);
            comboBoxVar1.Click += new EventHandler(comboBox_Click);
            
            // Dodanie przycisku do listy przycisków
            buttons.Add(IfButton);
            comboBoxes.Add(comboBoxVar);
            comboBoxes.Add(comboBoxVar1);
            comboBoxes.Add(comboBoxIf);
            textBoxesOn.Add(textBoxIf);
            textBoxesOn.Add(textBoxThen);
            
            // Dodanie przycisku do formularza
            comboBoxVar.Width = 85;
            comboBoxVar1.Width = 85;
            comboBoxIf.Width = 50;
            
            //Dodanie kontrolek do formularza
            panel1.Controls.Add(IfButton);
            IfButton.Controls.Add(textBoxIf); //Jeśli
            IfButton.Controls.Add(comboBoxVar); //Var1
            IfButton.Controls.Add(comboBoxIf);  //Warunek
            IfButton.Controls.Add(comboBoxVar1);//Var2
            IfButton.Controls.Add(textBoxThen); //To: 
            
            
            IfButton.SendToBack();
            textBoxIf.BringToFront();
            comboBoxVar.BringToFront();
            comboBoxIf.BringToFront();
            comboBoxVar1.BringToFront();
            textBoxThen.BringToFront();
            
            comboBoxVar.DataSource = null;
            comboBoxVar.DataSource = varsTable;
            comboBoxVar1.DataSource = null;
            comboBoxVar1.DataSource = varsTable;
            comboBoxIf.DataSource = ifOperators;
            
            IfButton.Click += new EventHandler(IfButton_Click);

            ButtonLocationX += 36;
            iteratorButtonY += 30;
            
            //ELSE
            
            Button ElseButton = new Button();
            TextBox textBoxElse = new TextBox();
            
            
            ElseButton.Text = "";
            ElseButton.Width = 283;
            ElseButton.Height = 30;
            ElseButton.BackColor = Color.FromArgb(255, 255, 255);
            ElseButton.Location = new Point(ButtonLocationX-36, iteratorButtonY);
            

            textBoxElse.Text = "W przeciwnym wypadku:";
            textBoxElse.Location = new Point(3, 8);
            textBoxElse.Width = 120;
            textBoxElse.ReadOnly = true;
            textBoxElse.BorderStyle = BorderStyle.None;
            textBoxElse.BackColor = Color.FromArgb(255, 255, 255);
            
            buttons.Add(ElseButton);
            textBoxesOn.Add(textBoxElse);
            
            panel1.Controls.Add(ElseButton);
            ElseButton.Controls.Add(textBoxElse); //Else
            
            ElseButton.SendToBack();
            textBoxElse.BringToFront();
        }
    }
}