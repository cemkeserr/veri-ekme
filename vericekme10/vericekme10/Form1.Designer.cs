namespace vericekme10
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hisse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonfiyat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degisim1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degisim2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hacim1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hacim2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hisse,
            this.sonfiyat1,
            this.degisim1,
            this.degisim2,
            this.hacim1,
            this.hacim2});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hisse
            // 
            this.hisse.HeaderText = "Hisse";
            this.hisse.Name = "hisse";
            // 
            // sonfiyat1
            // 
            this.sonfiyat1.HeaderText = "Son Fiyat(%)";
            this.sonfiyat1.Name = "sonfiyat1";
            // 
            // degisim1
            // 
            this.degisim1.HeaderText = "Değişim(%)";
            this.degisim1.Name = "degisim1";
            // 
            // degisim2
            // 
            this.degisim2.HeaderText = "Degisim(TL)";
            this.degisim2.Name = "degisim2";
            // 
            // hacim1
            // 
            this.hacim1.HeaderText = "Hacim(Tl)";
            this.hacim1.Name = "hacim1";
            // 
            // hacim2
            // 
            this.hacim2.HeaderText = "Hacim(%)";
            this.hacim2.Name = "hacim2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hisse;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonfiyat1;
        private System.Windows.Forms.DataGridViewTextBoxColumn degisim1;
        private System.Windows.Forms.DataGridViewTextBoxColumn degisim2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hacim1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hacim2;
    }
}

