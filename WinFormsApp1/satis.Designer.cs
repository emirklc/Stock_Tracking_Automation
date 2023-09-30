namespace WinFormsApp1
{
    partial class satis
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
            dataGridView4 = new DataGridView();
            satısAra = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = Color.White;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(143, 115);
            dataGridView4.Margin = new Padding(3, 4, 3, 4);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(683, 361);
            dataGridView4.TabIndex = 0;
            dataGridView4.CellClick += dataGridView4_CellClick;
            // 
            // satısAra
            // 
            satısAra.Location = new Point(143, 81);
            satısAra.Name = "satısAra";
            satısAra.Size = new Size(185, 27);
            satısAra.TabIndex = 1;
            satısAra.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 84);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 2;
            label1.Text = "Satış Ara ";
            // 
            // satis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 511);
            Controls.Add(label1);
            Controls.Add(satısAra);
            Controls.Add(dataGridView4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "satis";
            Text = "s";
            Load += satis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView4;
        private TextBox satısAra;
        private Label label1;
    }
}