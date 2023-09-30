namespace WinFormsApp1
{
    partial class Musteri
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
            components = new System.ComponentModel.Container();
            Button update;
            mussteriekle = new Button();
            ad = new TextBox();
            soyad = new TextBox();
            telefon = new TextBox();
            deletebutton = new Button();
            eposta = new TextBox();
            dataGridView3 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox1 = new TextBox();
            label5 = new Label();
            update = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(6, 178, 161);
            update.FlatStyle = FlatStyle.Popup;
            update.Location = new Point(400, 427);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Size = new Size(110, 61);
            update.TabIndex = 5;
            update.Text = "Güncelle";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // mussteriekle
            // 
            mussteriekle.BackColor = Color.FromArgb(47, 137, 188);
            mussteriekle.FlatStyle = FlatStyle.Popup;
            mussteriekle.Location = new Point(110, 345);
            mussteriekle.Margin = new Padding(3, 4, 3, 4);
            mussteriekle.Name = "mussteriekle";
            mussteriekle.Size = new Size(127, 49);
            mussteriekle.TabIndex = 0;
            mussteriekle.Text = "Müşteri Ekle";
            mussteriekle.UseVisualStyleBackColor = false;
            mussteriekle.Click += mussteriekle_Click;
            // 
            // ad
            // 
            ad.Location = new Point(101, 178);
            ad.Margin = new Padding(3, 4, 3, 4);
            ad.Name = "ad";
            ad.Size = new Size(149, 27);
            ad.TabIndex = 1;
            // 
            // soyad
            // 
            soyad.Location = new Point(101, 213);
            soyad.Margin = new Padding(3, 4, 3, 4);
            soyad.Name = "soyad";
            soyad.Size = new Size(149, 27);
            soyad.TabIndex = 2;
            // 
            // telefon
            // 
            telefon.Location = new Point(101, 248);
            telefon.Margin = new Padding(3, 4, 3, 4);
            telefon.Name = "telefon";
            telefon.Size = new Size(149, 27);
            telefon.TabIndex = 3;
            // 
            // deletebutton
            // 
            deletebutton.BackColor = Color.FromArgb(188, 56, 88);
            deletebutton.FlatStyle = FlatStyle.Popup;
            deletebutton.Location = new Point(692, 427);
            deletebutton.Margin = new Padding(3, 4, 3, 4);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(113, 61);
            deletebutton.TabIndex = 4;
            deletebutton.Text = "Sil";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Click += deletebutton_Click;
            // 
            // eposta
            // 
            eposta.Location = new Point(101, 283);
            eposta.Margin = new Padding(3, 4, 3, 4);
            eposta.Name = "eposta";
            eposta.Size = new Size(149, 27);
            eposta.TabIndex = 6;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(352, 123);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(505, 285);
            dataGridView3.TabIndex = 7;
            dataGridView3.CellDoubleClick += dataGridView3_CellDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 181);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 9;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 216);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 10;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 251);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 11;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 286);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 12;
            label4.Text = "E-Mail";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(723, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 27);
            textBox1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(625, 73);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 14;
            label5.Text = "Müşteri Ara ";
            // 
            // Musteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(879, 529);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView3);
            Controls.Add(eposta);
            Controls.Add(update);
            Controls.Add(deletebutton);
            Controls.Add(telefon);
            Controls.Add(soyad);
            Controls.Add(ad);
            Controls.Add(mussteriekle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Musteri";
            Text = "Musteri";
            Load += Musteri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button mussteriekle;
        private TextBox ad;
        private TextBox soyad;
        private TextBox telefon;
        private Button deletebutton;
        private Button update;
        private TextBox eposta;
        private DataGridView dataGridView3;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox1;
        private Label label5;
    }
}