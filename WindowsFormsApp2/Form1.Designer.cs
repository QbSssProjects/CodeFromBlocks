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
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.startBlocks = new System.Windows.Forms.Button();
            this.endBlocks = new System.Windows.Forms.Button();
            this.ifElse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newVar
            // 
            this.newVar.Location = new System.Drawing.Point(12, 30);
            this.newVar.Name = "newVar";
            this.newVar.Size = new System.Drawing.Size(161, 23);
            this.newVar.TabIndex = 0;
            this.newVar.Text = "Nowa zmienna";
            this.newVar.UseVisualStyleBackColor = true;
            this.newVar.Click += new System.EventHandler(this.newVar_Click);
            // 
            // setvar
            // 
            this.setvar.Location = new System.Drawing.Point(12, 59);
            this.setvar.Name = "setvar";
            this.setvar.Size = new System.Drawing.Size(161, 23);
            this.setvar.TabIndex = 1;
            this.setvar.Text = "Ustaw zmienna";
            this.setvar.UseVisualStyleBackColor = true;
            this.setvar.Click += new System.EventHandler(this.setvar_Click);
            // 
            // delVar
            // 
            this.delVar.Location = new System.Drawing.Point(12, 88);
            this.delVar.Name = "delVar";
            this.delVar.Size = new System.Drawing.Size(161, 23);
            this.delVar.TabIndex = 2;
            this.delVar.Text = "Usun zmienna";
            this.delVar.UseVisualStyleBackColor = true;
            // 
            // AddTo
            // 
            this.AddTo.Location = new System.Drawing.Point(12, 136);
            this.AddTo.Name = "AddTo";
            this.AddTo.Size = new System.Drawing.Size(161, 23);
            this.AddTo.TabIndex = 3;
            this.AddTo.Text = "Dodaj";
            this.AddTo.UseVisualStyleBackColor = true;
            // 
            // SubstractFrom
            // 
            this.SubstractFrom.Location = new System.Drawing.Point(12, 165);
            this.SubstractFrom.Name = "SubstractFrom";
            this.SubstractFrom.Size = new System.Drawing.Size(161, 23);
            this.SubstractFrom.TabIndex = 4;
            this.SubstractFrom.Text = "Odejmij";
            this.SubstractFrom.UseVisualStyleBackColor = true;
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(12, 194);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(161, 23);
            this.Multiply.TabIndex = 5;
            this.Multiply.Text = "Razy";
            this.Multiply.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(12, 223);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(161, 23);
            this.divide.TabIndex = 6;
            this.divide.Text = "Podzielic";
            this.divide.UseVisualStyleBackColor = true;
            // 
            // modulo
            // 
            this.modulo.Location = new System.Drawing.Point(12, 252);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(161, 23);
            this.modulo.TabIndex = 7;
            this.modulo.Text = "Reszta z dzielenia";
            this.modulo.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.AllowPromptAsInput = false;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 11);
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
            this.maskedTextBox2.Location = new System.Drawing.Point(12, 117);
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
            this.maskedTextBox3.Location = new System.Drawing.Point(12, 281);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.ReadOnly = true;
            this.maskedTextBox3.Size = new System.Drawing.Size(161, 13);
            this.maskedTextBox3.TabIndex = 10;
            this.maskedTextBox3.Text = "Warunki";
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // If
            // 
            this.If.Location = new System.Drawing.Point(12, 300);
            this.If.Name = "If";
            this.If.Size = new System.Drawing.Size(161, 23);
            this.If.TabIndex = 11;
            this.If.Text = "Jeśli";
            this.If.UseVisualStyleBackColor = true;
            // 
            // For
            // 
            this.For.Location = new System.Drawing.Point(12, 358);
            this.For.Name = "For";
            this.For.Size = new System.Drawing.Size(161, 23);
            this.For.TabIndex = 12;
            this.For.Text = "Wykonaj x razy";
            this.For.UseVisualStyleBackColor = true;
            // 
            // xGreaterThan
            // 
            this.xGreaterThan.Location = new System.Drawing.Point(12, 387);
            this.xGreaterThan.Name = "xGreaterThan";
            this.xGreaterThan.Size = new System.Drawing.Size(161, 23);
            this.xGreaterThan.TabIndex = 13;
            this.xGreaterThan.Text = "x > y";
            this.xGreaterThan.UseVisualStyleBackColor = true;
            // 
            // xSmallerThan
            // 
            this.xSmallerThan.Location = new System.Drawing.Point(12, 416);
            this.xSmallerThan.Name = "xSmallerThan";
            this.xSmallerThan.Size = new System.Drawing.Size(161, 23);
            this.xSmallerThan.TabIndex = 14;
            this.xSmallerThan.Text = "x < y";
            this.xSmallerThan.UseVisualStyleBackColor = true;
            // 
            // xEqualsTo
            // 
            this.xEqualsTo.Location = new System.Drawing.Point(12, 445);
            this.xEqualsTo.Name = "xEqualsTo";
            this.xEqualsTo.Size = new System.Drawing.Size(161, 23);
            this.xEqualsTo.TabIndex = 15;
            this.xEqualsTo.Text = "x = y";
            this.xEqualsTo.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.AllowPromptAsInput = false;
            this.maskedTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox4.Location = new System.Drawing.Point(12, 474);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.ReadOnly = true;
            this.maskedTextBox4.Size = new System.Drawing.Size(161, 13);
            this.maskedTextBox4.TabIndex = 16;
            this.maskedTextBox4.Text = "Wejścia / Wyjścia";
            this.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(12, 493);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(161, 23);
            this.print.TabIndex = 17;
            this.print.Text = "Wypisz na ekranie";
            this.print.UseVisualStyleBackColor = true;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 522);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(161, 23);
            this.input.TabIndex = 18;
            this.input.Text = "Wprowadź z ekranu";
            this.input.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.AllowPromptAsInput = false;
            this.maskedTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox5.Location = new System.Drawing.Point(12, 551);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.ReadOnly = true;
            this.maskedTextBox5.Size = new System.Drawing.Size(161, 13);
            this.maskedTextBox5.TabIndex = 19;
            this.maskedTextBox5.Text = "Start / Stop";
            this.maskedTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startBlocks
            // 
            this.startBlocks.Location = new System.Drawing.Point(12, 570);
            this.startBlocks.Name = "startBlocks";
            this.startBlocks.Size = new System.Drawing.Size(161, 23);
            this.startBlocks.TabIndex = 20;
            this.startBlocks.Text = "Rozpocznij";
            this.startBlocks.UseVisualStyleBackColor = true;
            // 
            // endBlocks
            // 
            this.endBlocks.Location = new System.Drawing.Point(12, 599);
            this.endBlocks.Name = "endBlocks";
            this.endBlocks.Size = new System.Drawing.Size(161, 23);
            this.endBlocks.TabIndex = 21;
            this.endBlocks.Text = "Zakończ";
            this.endBlocks.UseVisualStyleBackColor = true;
            // 
            // ifElse
            // 
            this.ifElse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ifElse.Location = new System.Drawing.Point(12, 329);
            this.ifElse.Name = "ifElse";
            this.ifElse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ifElse.Size = new System.Drawing.Size(161, 23);
            this.ifElse.TabIndex = 22;
            this.ifElse.Text = "Jeśli / W przeciwnym wypadku";
            this.ifElse.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.ifElse);
            this.panel1.Controls.Add(this.endBlocks);
            this.panel1.Controls.Add(this.startBlocks);
            this.panel1.Controls.Add(this.maskedTextBox5);
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

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button ifElse;

        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Button endBlocks;
        private System.Windows.Forms.Button startBlocks;

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