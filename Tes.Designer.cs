namespace CRUD_MYSQL
{
    partial class Tes
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_satuan = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_jumlah = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_jumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 12);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(762, 249);
            this.DGV.TabIndex = 1;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(54, 339);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(246, 20);
            this.txt_id.TabIndex = 2;
            this.txt_id.Visible = false;
            // 
            // txt_satuan
            // 
            this.txt_satuan.Location = new System.Drawing.Point(455, 294);
            this.txt_satuan.Name = "txt_satuan";
            this.txt_satuan.Size = new System.Drawing.Size(246, 20);
            this.txt_satuan.TabIndex = 3;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(528, 397);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "Kirim";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(629, 397);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Ubah";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Jumlah";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Satuan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nama";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(54, 294);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(246, 20);
            this.txt_nama.TabIndex = 16;
            // 
            // txt_jumlah
            // 
            this.txt_jumlah.Location = new System.Drawing.Point(455, 339);
            this.txt_jumlah.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txt_jumlah.Name = "txt_jumlah";
            this.txt_jumlah.Size = new System.Drawing.Size(249, 20);
            this.txt_jumlah.TabIndex = 18;
            // 
            // Tes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_jumlah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_satuan);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.DGV);
            this.Name = "Tes";
            this.Text = "Tes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tes_FormClosed);
            this.Load += new System.EventHandler(this.Tes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_jumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_satuan;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.NumericUpDown txt_jumlah;
    }
}

