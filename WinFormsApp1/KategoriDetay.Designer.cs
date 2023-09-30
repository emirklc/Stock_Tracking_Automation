namespace WinFormsApp1
{
    partial class KategoriDetay
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
            button1 = new Button();
            kategoriAdi = new TextBox();
            label1 = new Label();
            kategoriId = new TextBox();
            label2 = new Label();
            Update = new Button();
            Delete = new Button();
            dataGridView1 = new DataGridView();
            kategori_id = new DataGridViewTextBoxColumn();
            kategori_adi = new DataGridViewTextBoxColumn();
            arama = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(47, 137, 188);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(141, 251);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(122, 64);
            button1.TabIndex = 0;
            button1.Text = "Kategori Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // kategoriAdi
            // 
            kategoriAdi.Location = new Point(129, 194);
            kategoriAdi.Margin = new Padding(3, 4, 3, 4);
            kategoriAdi.Name = "kategoriAdi";
            kategoriAdi.Size = new Size(194, 27);
            kategoriAdi.TabIndex = 1;
            kategoriAdi.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(20, 197);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 5;
            label1.Text = "Kategori Adı";
            label1.Click += label1_Click;
            // 
            // kategoriId
            // 
            kategoriId.Location = new Point(129, 151);
            kategoriId.Name = "kategoriId";
            kategoriId.Size = new Size(194, 27);
            kategoriId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(20, 154);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 7;
            label2.Text = "Kategori Id ";
            // 
            // Update
            // 
            Update.BackColor = Color.FromArgb(6, 178, 161);
            Update.FlatStyle = FlatStyle.Popup;
            Update.Location = new Point(577, 395);
            Update.Margin = new Padding(3, 4, 3, 4);
            Update.Name = "Update";
            Update.Size = new Size(129, 60);
            Update.TabIndex = 8;
            Update.Text = "Güncelle";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(188, 56, 88);
            Delete.FlatStyle = FlatStyle.Popup;
            Delete.Location = new Point(374, 396);
            Delete.Margin = new Padding(3, 4, 3, 4);
            Delete.Name = "Delete";
            Delete.Size = new Size(121, 59);
            Delete.TabIndex = 9;
            Delete.Text = "Sil";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kategori_id, kategori_adi });
            dataGridView1.Location = new Point(351, 85);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(383, 303);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // kategori_id
            // 
            kategori_id.DataPropertyName = "kategori_id";
            kategori_id.HeaderText = "KATEGORİ ID";
            kategori_id.MinimumWidth = 6;
            kategori_id.Name = "kategori_id";
            // 
            // kategori_adi
            // 
            kategori_adi.DataPropertyName = "kategori_adi";
            kategori_adi.HeaderText = "KATEGORİ ADI";
            kategori_adi.MinimumWidth = 6;
            kategori_adi.Name = "kategori_adi";
            // 
            // arama
            // 
            arama.Location = new Point(577, 36);
            arama.Margin = new Padding(3, 4, 3, 4);
            arama.Name = "arama";
            arama.Size = new Size(139, 27);
            arama.TabIndex = 11;
            arama.TextChanged += arama_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 39);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 12;
            label3.Text = "Kategori Ara ";
            // 
            // KategoriDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 473);
            Controls.Add(label3);
            Controls.Add(arama);
            Controls.Add(dataGridView1);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(label2);
            Controls.Add(kategoriId);
            Controls.Add(label1);
            Controls.Add(kategoriAdi);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "KategoriDetay";
            Text = "KategoriDetay";
            Load += KategoriDetay_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox kategoriAdiTextBox;
        private Label label1;
        private TextBox kategoriIdTextBox;
        private Label label2;
        private TextBox kategoriAdi;
        private TextBox kategoriId;
        private Button Update;
        private Button Delete;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kategori_id;
        private DataGridViewTextBoxColumn kategori_adi;
        private TextBox arama;
        private Label label3;
    }
}