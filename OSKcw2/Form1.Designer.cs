using System.Collections.Generic;
using System.Diagnostics;

namespace OSKcw2
{
    partial class Form1
    {
        Form2 okno2;
        Form3 okno3;
        Form4 okno4;
        // public bool canClick = true;
        Stopwatch czas = new Stopwatch();
        Stopwatch czas1 = new Stopwatch();

        public double[] czasReakcji1 = new double[3];
        public double[] czasReakcji2 = new double[3];
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(291, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dostępne testy:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 88);
            this.button1.TabIndex = 1;
            this.button1.Text = "Test reakcji na bodźce optyczne";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 88);
            this.button2.TabIndex = 2;
            this.button2.Text = "Test reakcji na bodźce akustyczne";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 88);
            this.button3.TabIndex = 3;
            this.button3.Text = "Test reakcji na ...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 88);
            this.button4.TabIndex = 4;
            this.button4.Text = "Wyświetl wyniki";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 575);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
    }
}

