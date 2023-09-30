namespace WinFormsApp1
{
    partial class NewHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewHome));
            panel1 = new Panel();
            SİPARİSLER = new Button();
            MUSTERİLER = new Button();
            URUNLER = new Button();
            KATEGORİLER = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(SİPARİSLER);
            panel1.Controls.Add(MUSTERİLER);
            panel1.Controls.Add(URUNLER);
            panel1.Controls.Add(KATEGORİLER);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 487);
            panel1.TabIndex = 0;
            // 
            // SİPARİSLER
            // 
            SİPARİSLER.FlatAppearance.BorderSize = 0;
            SİPARİSLER.FlatStyle = FlatStyle.Flat;
            SİPARİSLER.ForeColor = Color.FromArgb(255, 128, 0);
            SİPARİSLER.Image = (Image)resources.GetObject("SİPARİSLER.Image");
            SİPARİSLER.ImageAlign = ContentAlignment.TopCenter;
            SİPARİSLER.Location = new Point(4, 355);
            SİPARİSLER.Name = "SİPARİSLER";
            SİPARİSLER.Size = new Size(176, 80);
            SİPARİSLER.TabIndex = 0;
            SİPARİSLER.Text = "button1";
            SİPARİSLER.TextAlign = ContentAlignment.BottomCenter;
            SİPARİSLER.UseVisualStyleBackColor = true;
            SİPARİSLER.Click += SİPARİSLER_Click;
            // 
            // MUSTERİLER
            // 
            MUSTERİLER.FlatAppearance.BorderSize = 0;
            MUSTERİLER.FlatStyle = FlatStyle.Flat;
            MUSTERİLER.ForeColor = Color.FromArgb(255, 128, 0);
            MUSTERİLER.Image = (Image)resources.GetObject("MUSTERİLER.Image");
            MUSTERİLER.ImageAlign = ContentAlignment.TopCenter;
            MUSTERİLER.Location = new Point(7, 269);
            MUSTERİLER.Name = "MUSTERİLER";
            MUSTERİLER.Size = new Size(176, 80);
            MUSTERİLER.TabIndex = 0;
            MUSTERİLER.Text = "button1";
            MUSTERİLER.TextAlign = ContentAlignment.BottomCenter;
            MUSTERİLER.UseVisualStyleBackColor = true;
            MUSTERİLER.Click += MUSTERİLER_Click;
            // 
            // URUNLER
            // 
            URUNLER.FlatAppearance.BorderSize = 0;
            URUNLER.FlatStyle = FlatStyle.Flat;
            URUNLER.ForeColor = Color.FromArgb(255, 128, 0);
            URUNLER.Image = (Image)resources.GetObject("URUNLER.Image");
            URUNLER.ImageAlign = ContentAlignment.TopCenter;
            URUNLER.Location = new Point(4, 183);
            URUNLER.Name = "URUNLER";
            URUNLER.Size = new Size(176, 80);
            URUNLER.TabIndex = 0;
            URUNLER.Text = "button1";
            URUNLER.TextAlign = ContentAlignment.BottomCenter;
            URUNLER.UseVisualStyleBackColor = true;
            URUNLER.Click += URUNLER_Click;
            // 
            // KATEGORİLER
            // 
            KATEGORİLER.FlatAppearance.BorderSize = 0;
            KATEGORİLER.FlatStyle = FlatStyle.Flat;
            KATEGORİLER.ForeColor = Color.FromArgb(255, 128, 0);
            KATEGORİLER.Image = (Image)resources.GetObject("KATEGORİLER.Image");
            KATEGORİLER.ImageAlign = ContentAlignment.TopCenter;
            KATEGORİLER.Location = new Point(4, 97);
            KATEGORİLER.Name = "KATEGORİLER";
            KATEGORİLER.Size = new Size(176, 80);
            KATEGORİLER.TabIndex = 0;
            KATEGORİLER.Text = "button1";
            KATEGORİLER.TextAlign = ContentAlignment.BottomCenter;
            KATEGORİLER.UseVisualStyleBackColor = true;
            KATEGORİLER.Click += KATEGORİLER_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(186, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(624, 487);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.Location = new Point(0, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 81);
            panel4.TabIndex = 0;
            panel4.Paint += panel4_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 192, 0);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(2, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(186, 80);
            panel3.TabIndex = 2;
            panel3.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Engravers MT", 31.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(2, 4);
            label1.Name = "label1";
            label1.Size = new Size(184, 63);
            label1.TabIndex = 0;
            label1.Text = "LCW";
            label1.UseWaitCursor = true;
            // 
            // NewHome
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(810, 487);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewHome";
            Text = "NewHome";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button KATEGORİLER;
        private Button SİPARİSLER;
        private Button MUSTERİLER;
        private Button URUNLER;
        private Panel panel4;
    }
}