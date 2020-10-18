namespace Advanced_calculator
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
            this.components = new System.ComponentModel.Container();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.textBox_wynik = new System.Windows.Forms.TextBox();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_c = new System.Windows.Forms.Label();
            this.button_suma = new System.Windows.Forms.Button();
            this.button_różnica = new System.Windows.Forms.Button();
            this.button_iloczyn = new System.Windows.Forms.Button();
            this.button_iloraz = new System.Windows.Forms.Button();
            this.button_potęga = new System.Windows.Forms.Button();
            this.button_silnia = new System.Windows.Forms.Button();
            this.button_procent = new System.Windows.Forms.Button();
            this.button_pierwiastek = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label_wynik = new System.Windows.Forms.Label();
            this.button_ans = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_sinus = new System.Windows.Forms.Button();
            this.button_cosinus = new System.Windows.Forms.Button();
            this.button_tangens = new System.Windows.Forms.Button();
            this.button_kotangens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(281, 104);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 20);
            this.textBox_a.TabIndex = 0;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(451, 104);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 20);
            this.textBox_b.TabIndex = 1;
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(632, 104);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(100, 20);
            this.textBox_c.TabIndex = 2;
            // 
            // textBox_wynik
            // 
            this.textBox_wynik.Location = new System.Drawing.Point(844, 204);
            this.textBox_wynik.Name = "textBox_wynik";
            this.textBox_wynik.Size = new System.Drawing.Size(100, 20);
            this.textBox_wynik.TabIndex = 3;
            this.textBox_wynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(230, 107);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(46, 13);
            this.label_a.TabIndex = 4;
            this.label_a.Text = "Podaj a:";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(399, 107);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(46, 13);
            this.label_b.TabIndex = 5;
            this.label_b.Text = "Podaj b:";
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new System.Drawing.Point(580, 107);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(46, 13);
            this.label_c.TabIndex = 6;
            this.label_c.Text = "Podaj c:";
            // 
            // button_suma
            // 
            this.button_suma.Location = new System.Drawing.Point(281, 204);
            this.button_suma.Name = "button_suma";
            this.button_suma.Size = new System.Drawing.Size(56, 54);
            this.button_suma.TabIndex = 8;
            this.button_suma.Text = "+";
            this.button_suma.UseVisualStyleBackColor = true;
            this.button_suma.Click += new System.EventHandler(this.suma_Click);
            this.button_suma.MouseHover += new System.EventHandler(this.suma_MouseHover);
            // 
            // button_różnica
            // 
            this.button_różnica.Location = new System.Drawing.Point(343, 204);
            this.button_różnica.Name = "button_różnica";
            this.button_różnica.Size = new System.Drawing.Size(56, 54);
            this.button_różnica.TabIndex = 9;
            this.button_różnica.Text = "-";
            this.button_różnica.UseVisualStyleBackColor = true;
            this.button_różnica.Click += new System.EventHandler(this.różnica_Click);
            this.button_różnica.MouseHover += new System.EventHandler(this.różnica_MouseHover);
            // 
            // button_iloczyn
            // 
            this.button_iloczyn.Location = new System.Drawing.Point(405, 204);
            this.button_iloczyn.Name = "button_iloczyn";
            this.button_iloczyn.Size = new System.Drawing.Size(56, 54);
            this.button_iloczyn.TabIndex = 10;
            this.button_iloczyn.Text = "x";
            this.button_iloczyn.UseVisualStyleBackColor = true;
            this.button_iloczyn.Click += new System.EventHandler(this.iloczyn_Click);
            this.button_iloczyn.MouseHover += new System.EventHandler(this.iloczyn_MouseHover);
            // 
            // button_iloraz
            // 
            this.button_iloraz.Location = new System.Drawing.Point(467, 204);
            this.button_iloraz.Name = "button_iloraz";
            this.button_iloraz.Size = new System.Drawing.Size(56, 54);
            this.button_iloraz.TabIndex = 11;
            this.button_iloraz.Text = "/";
            this.button_iloraz.UseVisualStyleBackColor = true;
            this.button_iloraz.Click += new System.EventHandler(this.iloraz_Click);
            this.button_iloraz.MouseHover += new System.EventHandler(this.iloraz_MouseHover);
            // 
            // button_potęga
            // 
            this.button_potęga.Location = new System.Drawing.Point(405, 264);
            this.button_potęga.Name = "button_potęga";
            this.button_potęga.Size = new System.Drawing.Size(56, 54);
            this.button_potęga.TabIndex = 12;
            this.button_potęga.Text = "^";
            this.button_potęga.UseVisualStyleBackColor = true;
            this.button_potęga.Click += new System.EventHandler(this.button_potęga_Click);
            // 
            // button_silnia
            // 
            this.button_silnia.Location = new System.Drawing.Point(343, 264);
            this.button_silnia.Name = "button_silnia";
            this.button_silnia.Size = new System.Drawing.Size(56, 54);
            this.button_silnia.TabIndex = 13;
            this.button_silnia.Text = "!";
            this.button_silnia.UseVisualStyleBackColor = true;
            this.button_silnia.Click += new System.EventHandler(this.silnia_Click);
            this.button_silnia.MouseHover += new System.EventHandler(this.silnia_MouseHover);
            // 
            // button_procent
            // 
            this.button_procent.Location = new System.Drawing.Point(281, 264);
            this.button_procent.Name = "button_procent";
            this.button_procent.Size = new System.Drawing.Size(56, 54);
            this.button_procent.TabIndex = 15;
            this.button_procent.Text = "%";
            this.button_procent.UseVisualStyleBackColor = true;
            this.button_procent.Click += new System.EventHandler(this.procent_Click);
            this.button_procent.MouseHover += new System.EventHandler(this.procent_MouseHover);
            // 
            // button_pierwiastek
            // 
            this.button_pierwiastek.Location = new System.Drawing.Point(467, 264);
            this.button_pierwiastek.Name = "button_pierwiastek";
            this.button_pierwiastek.Size = new System.Drawing.Size(56, 54);
            this.button_pierwiastek.TabIndex = 16;
            this.button_pierwiastek.Text = "pier";
            this.button_pierwiastek.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 513);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label_wynik
            // 
            this.label_wynik.AutoSize = true;
            this.label_wynik.Location = new System.Drawing.Point(798, 207);
            this.label_wynik.Name = "label_wynik";
            this.label_wynik.Size = new System.Drawing.Size(40, 13);
            this.label_wynik.TabIndex = 18;
            this.label_wynik.Text = "Wynik:";
            // 
            // button_ans
            // 
            this.button_ans.Location = new System.Drawing.Point(869, 235);
            this.button_ans.Name = "button_ans";
            this.button_ans.Size = new System.Drawing.Size(75, 23);
            this.button_ans.TabIndex = 19;
            this.button_ans.Text = "Ans";
            this.button_ans.UseVisualStyleBackColor = true;
            this.button_ans.Click += new System.EventHandler(this.button_ans_Click);
            this.button_ans.MouseHover += new System.EventHandler(this.button_ans_MouseHover);
            // 
            // button_sinus
            // 
            this.button_sinus.Location = new System.Drawing.Point(281, 324);
            this.button_sinus.Name = "button_sinus";
            this.button_sinus.Size = new System.Drawing.Size(56, 54);
            this.button_sinus.TabIndex = 20;
            this.button_sinus.Text = "sin";
            this.button_sinus.UseVisualStyleBackColor = true;
            // 
            // button_cosinus
            // 
            this.button_cosinus.Location = new System.Drawing.Point(343, 324);
            this.button_cosinus.Name = "button_cosinus";
            this.button_cosinus.Size = new System.Drawing.Size(56, 54);
            this.button_cosinus.TabIndex = 21;
            this.button_cosinus.Text = "cos";
            this.button_cosinus.UseVisualStyleBackColor = true;
            // 
            // button_tangens
            // 
            this.button_tangens.Location = new System.Drawing.Point(405, 324);
            this.button_tangens.Name = "button_tangens";
            this.button_tangens.Size = new System.Drawing.Size(56, 54);
            this.button_tangens.TabIndex = 22;
            this.button_tangens.Text = "tg";
            this.button_tangens.UseVisualStyleBackColor = true;
            // 
            // button_kotangens
            // 
            this.button_kotangens.Location = new System.Drawing.Point(467, 324);
            this.button_kotangens.Name = "button_kotangens";
            this.button_kotangens.Size = new System.Drawing.Size(56, 54);
            this.button_kotangens.TabIndex = 23;
            this.button_kotangens.Text = "ctg";
            this.button_kotangens.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.button_kotangens);
            this.Controls.Add(this.button_tangens);
            this.Controls.Add(this.button_cosinus);
            this.Controls.Add(this.button_sinus);
            this.Controls.Add(this.button_ans);
            this.Controls.Add(this.label_wynik);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_pierwiastek);
            this.Controls.Add(this.button_procent);
            this.Controls.Add(this.button_silnia);
            this.Controls.Add(this.button_potęga);
            this.Controls.Add(this.button_iloraz);
            this.Controls.Add(this.button_iloczyn);
            this.Controls.Add(this.button_różnica);
            this.Controls.Add(this.button_suma);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.textBox_wynik);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.TextBox textBox_wynik;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.Button button_suma;
        private System.Windows.Forms.Button button_różnica;
        private System.Windows.Forms.Button button_iloczyn;
        private System.Windows.Forms.Button button_iloraz;
        private System.Windows.Forms.Button button_potęga;
        private System.Windows.Forms.Button button_silnia;
        private System.Windows.Forms.Button button_procent;
        private System.Windows.Forms.Button button_pierwiastek;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label_wynik;
        private System.Windows.Forms.Button button_ans;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_sinus;
        private System.Windows.Forms.Button button_cosinus;
        private System.Windows.Forms.Button button_tangens;
        private System.Windows.Forms.Button button_kotangens;
    }
}

