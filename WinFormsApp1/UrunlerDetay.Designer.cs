namespace WinFormsApp1
{
    partial class UrunlerDetay
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
            dataGridView2 = new DataGridView();
            kategoribox = new ComboBox();
            urunText = new TextBox();
            urunAdText = new TextBox();
            fiyatText = new TextBox();
            stokText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            deleteurun = new Button();
            updateurun = new Button();
            urunAra = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(263, 112);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(622, 351);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // kategoribox
            // 
            kategoribox.FormattingEnabled = true;
            kategoribox.Location = new Point(106, 178);
            kategoribox.Margin = new Padding(3, 4, 3, 4);
            kategoribox.Name = "kategoribox";
            kategoribox.Size = new Size(122, 28);
            kategoribox.TabIndex = 1;
            kategoribox.SelectedIndexChanged += kotegoribox_SelectedIndexChanged;
            // 
            // urunText
            // 
            urunText.Location = new Point(106, 142);
            urunText.Margin = new Padding(3, 4, 3, 4);
            urunText.Name = "urunText";
            urunText.Size = new Size(122, 27);
            urunText.TabIndex = 2;
            // 
            // urunAdText
            // 
            urunAdText.Location = new Point(106, 214);
            urunAdText.Margin = new Padding(3, 4, 3, 4);
            urunAdText.Name = "urunAdText";
            urunAdText.Size = new Size(122, 27);
            urunAdText.TabIndex = 3;
            // 
            // fiyatText
            // 
            fiyatText.Location = new Point(106, 249);
            fiyatText.Margin = new Padding(3, 4, 3, 4);
            fiyatText.Name = "fiyatText";
            fiyatText.Size = new Size(122, 27);
            fiyatText.TabIndex = 4;
            fiyatText.TextChanged += textBox3_TextChanged;
            // 
            // stokText
            // 
            stokText.Location = new Point(106, 284);
            stokText.Margin = new Padding(3, 4, 3, 4);
            stokText.Name = "stokText";
            stokText.Size = new Size(122, 27);
            stokText.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 145);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 6;
            label1.Text = "Ürün ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 181);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Kategori";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 221);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 8;
            label3.Text = "Ürün Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 256);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 9;
            label4.Text = "Fiyat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 287);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 10;
            label5.Text = "Stok Miktarı";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(47, 137, 188);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(97, 365);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(123, 45);
            button1.TabIndex = 11;
            button1.Text = "Ürün Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // deleteurun
            // 
            deleteurun.BackColor = Color.FromArgb(188, 56, 88);
            deleteurun.FlatStyle = FlatStyle.Popup;
            deleteurun.ForeColor = Color.White;
            deleteurun.Location = new Point(713, 481);
            deleteurun.Margin = new Padding(3, 4, 3, 4);
            deleteurun.Name = "deleteurun";
            deleteurun.Size = new Size(128, 58);
            deleteurun.TabIndex = 12;
            deleteurun.Text = "Sil";
            deleteurun.UseVisualStyleBackColor = false;
            deleteurun.Click += deleteurun_Click;
            // 
            // updateurun
            // 
            updateurun.BackColor = Color.FromArgb(16, 178, 161);
            updateurun.FlatStyle = FlatStyle.Flat;
            updateurun.Location = new Point(306, 481);
            updateurun.Margin = new Padding(3, 4, 3, 4);
            updateurun.Name = "updateurun";
            updateurun.Size = new Size(127, 58);
            updateurun.TabIndex = 13;
            updateurun.Text = "Güncelle";
            updateurun.UseVisualStyleBackColor = false;
            updateurun.Click += updateurun_Click;
            // 
            // urunAra
            // 
            urunAra.Location = new Point(673, 56);
            urunAra.Name = "urunAra";
            urunAra.Size = new Size(153, 27);
            urunAra.TabIndex = 14;
            urunAra.TextChanged += urunAra_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(590, 59);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 15;
            label6.Text = "Ürün Ara ";
            // 
            // UrunlerDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label6);
            Controls.Add(urunAra);
            Controls.Add(updateurun);
            Controls.Add(deleteurun);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(stokText);
            Controls.Add(fiyatText);
            Controls.Add(urunAdText);
            Controls.Add(urunText);
            Controls.Add(kategoribox);
            Controls.Add(dataGridView2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UrunlerDetay";
            Text = "UrunlerDetay";
            Load += UrunlerDetay_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private ComboBox kategoribox;
        private TextBox urunText;
        private TextBox urunAdText;
        private TextBox fiyatText;
        private TextBox stokText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private DataGridViewTextBoxColumn urun_id;
        private DataGridViewTextBoxColumn kategori_id;
        private DataGridViewTextBoxColumn urun_adi;
        private DataGridViewTextBoxColumn fiyat;
        private DataGridViewTextBoxColumn stok_miktari;
        private Button button2;
        private Button button3;
        private Button deleteurun;
        private Button updateurun;
        private TextBox urunAra;
        private Label label6;
    }
}