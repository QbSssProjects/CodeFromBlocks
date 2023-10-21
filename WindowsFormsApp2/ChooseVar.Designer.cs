using System.ComponentModel;

namespace WindowsFormsApp2
{
    partial class ChooseVar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.listBoxChooseVar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxChooseVar
            // 
            this.listBoxChooseVar.FormattingEnabled = true;
            this.listBoxChooseVar.Location = new System.Drawing.Point(67, 30);
            this.listBoxChooseVar.Name = "listBoxChooseVar";
            this.listBoxChooseVar.Size = new System.Drawing.Size(100, 30);
            this.listBoxChooseVar.TabIndex = 0;
            // 
            // ChooseVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 81);
            this.Controls.Add(this.listBoxChooseVar);
            this.Name = "ChooseVar";
            this.Text = "Wybierz Zmienną";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBoxChooseVar;

        #endregion
    }
}