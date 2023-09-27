namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newVar = new System.Windows.Forms.Button();
            this.setvar = new System.Windows.Forms.Button();
            this.delVar = new System.Windows.Forms.Button();
            this.AddTo = new System.Windows.Forms.Button();
            this.SubstractFrom = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.modulo = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.If = new System.Windows.Forms.Button();
            this.For = new System.Windows.Forms.Button();
            this.xGreaterThan = new System.Windows.Forms.Button();
            this.xSmallerThan = new System.Windows.Forms.Button();
            this.xEqualsTo = new System.Windows.Forms.Button();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.print = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Button();
            this.ifElse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newVar
            // 
            this.newVar.Location = new System.Drawing.Point(12, 56);
            this.newVar.Name = "newVar";
            this.newVar.Size = new System.Drawing.Size(161, 25);
            this.newVar.TabIndex = 0;
            this.newVar.Text = "Nowa zmienna";
            this.newVar.UseVisualStyleBackColor = true;
            this.newVar.Click += new System.EventHandler(this.newVar_Click);
            // 
            // setvar
            // 
            this.setvar.Location = new System.Drawing.Point(12, 85);
            this.setvar.Name = "setvar";
            this.setvar.Size = new System.Drawing.Size(161, 25);
            this.setvar.TabIndex = 1;
            this.setvar.Text = "Ustaw zmienna";
            this.setvar.UseVisualStyleBackColor = true;
            this.setvar.Click += new System.EventHandler(this.setvar_Click);
            // 
            // delVar
            // 
            this.delVar.Location = new System.Drawing.Point(12, 114);
            this.delVar.Name = "delVar";
            this.delVar.Size = new System.Drawing.Size(161, 25);
            this.delVar.TabIndex = 2;
            this.delVar.Text = "Usun zmienna";
            this.delVar.UseVisualStyleBackColor = true;
            // 
            // AddTo
            // 
            this.AddTo.Location = new System.Drawing.Point(12, 162);
            this.AddTo.Name = "AddTo";
            this.AddTo.Size = new System.Drawing.Size(161, 25);
            this.AddTo.TabIndex = 3;
            this.AddTo.Text = "Dodaj";
            this.AddTo.UseVisualStyleBackColor = true;
            // 
            // SubstractFrom
            // 
            this.SubstractFrom.Location = new System.Drawing.Point(12, 191);
            this.SubstractFrom.Name = "SubstractFrom";
            this.SubstractFrom.Size = new System.Drawing.Size(161, 25);
            this.SubstractFrom.TabIndex = 4;
            this.SubstractFrom.Text = "Odejmij";
            this.SubstractFrom.UseVisualStyleBackColor = true;
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(12, 220);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(161, 25);
            this.Multiply.TabIndex = 5;
            this.Multiply.Text = "Razy";
            this.Multiply.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(12, 249);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(161, 25);
            this.divide.TabIndex = 6;
            this.divide.Text = "Podzielic";
            this.divide.UseVisualStyleBackColor = true;
            // 
            // modulo
            // 
            this.modulo.Location = new System.Drawing.Point(12, 278);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(161, 25);
            this.modulo.TabIndex = 7;
            this.modulo.Text = "Reszta z dzielenia";
            this.modulo.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.AllowPromptAsInput = false;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 39);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(161, 13);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.Text = "Zmienne";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.AllowPromptAsInput = false;
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Location = new System.Drawing.Point(12, 145);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(161, 13);
            this.maskedTextBox2.TabIndex = 9;
            this.maskedTextBox2.Text = "Operacje";
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.AllowPromptAsInput = false;
            this.maskedTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox3.Location = new System.Drawing.Point(12, 309);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.ReadOnly = true;
            this.maskedTextBox3.Size = new System.Drawing.Size(161, 13);
            this.maskedTextBox3.TabIndex = 10;
            this.maskedTextBox3.Text = "Warunki";
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // If
            // 
            this.If.Location = new System.Drawing.Point(12, 326);
            this.If.Name = "If";
            this.If.Size = new System.Drawing.Size(161, 25);
            this.If.TabIndex = 11;
            this.If.Text = "Jeśli";
            this.If.UseVisualStyleBackColor = true;
            // 
            // For
            // 
            this.For.Location = new System.Drawing.Point(12, 384);
            this.For.Name = "For";
            this.For.Size = new System.Drawing.Size(161, 25);
            this.For.TabIndex = 12;
            this.For.Text = "Wykonaj x razy";
            this.For.UseVisualStyleBackColor = true;
            // 
            // xGreaterThan
            // 
            this.xGreaterThan.Location = new System.Drawing.Point(12, 413);
            this.xGreaterThan.Name = "xGreaterThan";
            this.xGreaterThan.Size = new System.Drawing.Size(161, 25);
            this.xGreaterThan.TabIndex = 13;
            this.xGreaterThan.Text = "x > y";
            this.xGreaterThan.UseVisualStyleBackColor = true;
            // 
            // xSmallerThan
            // 
            this.xSmallerThan.Location = new System.Drawing.Point(12, 442);
            this.xSmallerThan.Name = "xSmallerThan";
            this.xSmallerThan.Size = new System.Drawing.Size(161, 25);
            this.xSmallerThan.TabIndex = 14;
            this.xSmallerThan.Text = "x < y";
            this.xSmallerThan.UseVisualStyleBackColor = true;
            // 
            // xEqualsTo
            // 
            this.xEqualsTo.Location = new System.Drawing.Point(12, 471);
            this.xEqualsTo.Name = "xEqualsTo";
            this.xEqualsTo.Size = new System.Drawing.Size(161, 25);
            this.xEqualsTo.TabIndex = 15;
            this.xEqualsTo.Text = "x = y";
            this.xEqualsTo.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.AllowPromptAsInput = false;
            this.maskedTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox4.Location = new System.Drawing.Point(12, 502);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.ReadOnly = true;
            this.maskedTextBox4.Size = new System.Drawing.Size(161, 13);
            this.maskedTextBox4.TabIndex = 16;
            this.maskedTextBox4.Text = "Wejścia / Wyjścia";
            this.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(12, 519);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(161, 25);
            this.print.TabIndex = 17;
            this.print.Text = "Wypisz na ekranie";
            this.print.UseVisualStyleBackColor = true;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 548);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(161, 25);
            this.input.TabIndex = 18;
            this.input.Text = "Wprowadź z ekranu";
            this.input.UseVisualStyleBackColor = true;
            // 
            // ifElse
            // 
            this.ifElse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ifElse.Location = new System.Drawing.Point(12, 355);
            this.ifElse.Name = "ifElse";
            this.ifElse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ifElse.Size = new System.Drawing.Size(161, 25);
            this.ifElse.TabIndex = 22;
            this.ifElse.Text = "Jeśli / W przeciwnym wypadku";
            this.ifElse.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.ifElse);
            this.panel1.Controls.Add(this.input);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.maskedTextBox4);
            this.panel1.Controls.Add(this.xEqualsTo);
            this.panel1.Controls.Add(this.xSmallerThan);
            this.panel1.Controls.Add(this.xGreaterThan);
            this.panel1.Controls.Add(this.For);
            this.panel1.Controls.Add(this.If);
            this.panel1.Controls.Add(this.maskedTextBox3);
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.modulo);
            this.panel1.Controls.Add(this.divide);
            this.panel1.Controls.Add(this.Multiply);
            this.panel1.Controls.Add(this.SubstractFrom);
            this.panel1.Controls.Add(this.AddTo);
            this.panel1.Controls.Add(this.delVar);
            this.panel1.Controls.Add(this.setvar);
            this.panel1.Controls.Add(this.newVar);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 632);
            this.panel1.TabIndex = 24;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(488, 30);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(221, 30);
            this.Start.TabIndex = 23;
            this.Start.Text = "POCZATEK ";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 671);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 710);
            this.MinimumSize = new System.Drawing.Size(1080, 710);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Start;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button ifElse;

        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button print;

        private System.Windows.Forms.Button xEqualsTo;
        private System.Windows.Forms.Button xSmallerThan;
        private System.Windows.Forms.Button xGreaterThan;
        private System.Windows.Forms.Button For;
        private System.Windows.Forms.Button If;

        private System.Windows.Forms.MaskedTextBox maskedTextBox3;

        private System.Windows.Forms.MaskedTextBox maskedTextBox2;

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;

        private System.Windows.Forms.Button newVar;
        private System.Windows.Forms.Button setvar;
        private System.Windows.Forms.Button delVar;
        private System.Windows.Forms.Button AddTo;
        private System.Windows.Forms.Button modulo;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button SubstractFrom;

        #endregion
    }
}