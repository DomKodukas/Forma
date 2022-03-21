namespace forma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pirmas = new System.Windows.Forms.TextBox();
            this.antras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rez = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.TextBox();
            this.lb_nespausk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daugybos skaičiavimas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pirmas
            // 
            this.pirmas.Location = new System.Drawing.Point(23, 27);
            this.pirmas.Name = "pirmas";
            this.pirmas.Size = new System.Drawing.Size(100, 23);
            this.pirmas.TabIndex = 1;
            this.pirmas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // antras
            // 
            this.antras.Location = new System.Drawing.Point(147, 27);
            this.antras.Name = "antras";
            this.antras.Size = new System.Drawing.Size(100, 23);
            this.antras.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "*";
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(86, 56);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(100, 23);
            this.rez.TabIndex = 4;
            this.rez.Text = "Suskaičiuoti";
            this.rez.UseVisualStyleBackColor = true;
            this.rez.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Atsakymas :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(320, 56);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(224, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pradėti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 269);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Klaida !";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(604, 209);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 22);
            this.button3.TabIndex = 12;
            this.button3.Text = "Nespausk !";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(86, 88);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(100, 23);
            this.suma.TabIndex = 14;
            // 
            // lb_nespausk
            // 
            this.lb_nespausk.AutoSize = true;
            this.lb_nespausk.Location = new System.Drawing.Point(80, 180);
            this.lb_nespausk.Name = "lb_nespausk";
            this.lb_nespausk.Size = new System.Drawing.Size(0, 15);
            this.lb_nespausk.TabIndex = 15;
            this.lb_nespausk.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_nespausk);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.antras);
            this.Controls.Add(this.pirmas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Paprasta forma";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox pirmas;
        private TextBox antras;
        private Label label2;
        private Button rez;
        private Label label3;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private MonthCalendar monthCalendar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button3;
        private TextBox suma;
        private Label lb_nespausk;
    }
}