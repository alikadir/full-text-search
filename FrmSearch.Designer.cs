namespace AKBSearch
{
    partial class FrmSearch
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TxtHedef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHedef = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTip = new System.Windows.Forms.TextBox();
            this.TxtKelime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnAra = new System.Windows.Forms.Button();
            this.CbxDahil = new System.Windows.Forms.CheckBox();
            this.Gbx = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DosyaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosyaYol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.SatirNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iceren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.Gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtHedef
            // 
            this.TxtHedef.Location = new System.Drawing.Point(12, 32);
            this.TxtHedef.Name = "TxtHedef";
            this.TxtHedef.Size = new System.Drawing.Size(415, 20);
            this.TxtHedef.TabIndex = 0;
            this.TxtHedef.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TxtHedef_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hedef Klasor Yolu";
            // 
            // BtnHedef
            // 
            this.BtnHedef.Location = new System.Drawing.Point(433, 30);
            this.BtnHedef.Name = "BtnHedef";
            this.BtnHedef.Size = new System.Drawing.Size(26, 24);
            this.BtnHedef.TabIndex = 2;
            this.BtnHedef.Text = ":::";
            this.BtnHedef.UseVisualStyleBackColor = true;
            this.BtnHedef.Click += new System.EventHandler(this.BtnHedef_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ayraç";
            // 
            // TxtTip
            // 
            this.TxtTip.Location = new System.Drawing.Point(12, 88);
            this.TxtTip.Name = "TxtTip";
            this.TxtTip.Size = new System.Drawing.Size(93, 20);
            this.TxtTip.TabIndex = 0;
            this.TxtTip.Text = "*.*";
            // 
            // TxtKelime
            // 
            this.TxtKelime.Location = new System.Drawing.Point(12, 150);
            this.TxtKelime.Name = "TxtKelime";
            this.TxtKelime.Size = new System.Drawing.Size(217, 20);
            this.TxtKelime.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Aranan Kelime";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.BtnAra);
            this.panel1.Controls.Add(this.CbxDahil);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnHedef);
            this.panel1.Controls.Add(this.TxtHedef);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtTip);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtKelime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 195);
            this.panel1.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(256, 90);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(203, 17);
            this.progressBar1.TabIndex = 5;
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(256, 125);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(203, 45);
            this.BtnAra.TabIndex = 4;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // CbxDahil
            // 
            this.CbxDahil.AutoSize = true;
            this.CbxDahil.Checked = true;
            this.CbxDahil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxDahil.Location = new System.Drawing.Point(121, 90);
            this.CbxDahil.Name = "CbxDahil";
            this.CbxDahil.Size = new System.Drawing.Size(108, 17);
            this.CbxDahil.TabIndex = 3;
            this.CbxDahil.Text = "Alt Klasorler Dahil";
            this.CbxDahil.UseVisualStyleBackColor = true;
            // 
            // Gbx
            // 
            this.Gbx.Controls.Add(this.dataGridView1);
            this.Gbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gbx.Location = new System.Drawing.Point(0, 195);
            this.Gbx.Name = "Gbx";
            this.Gbx.Size = new System.Drawing.Size(471, 266);
            this.Gbx.TabIndex = 4;
            this.Gbx.TabStop = false;
            this.Gbx.Text = "Arama Sonuçları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DosyaAdi,
            this.DosyaYol,
            this.SatirNo,
            this.Iceren,
            this.IndexNo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(465, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // DosyaAdi
            // 
            this.DosyaAdi.DataPropertyName = "DosyaAdi";
            this.DosyaAdi.Frozen = true;
            this.DosyaAdi.HeaderText = "Dosya Adı";
            this.DosyaAdi.Name = "DosyaAdi";
            this.DosyaAdi.Width = 80;
            // 
            // DosyaYol
            // 
            this.DosyaYol.ActiveLinkColor = System.Drawing.Color.White;
            this.DosyaYol.DataPropertyName = "DosyaYolu";
            this.DosyaYol.HeaderText = "Dosya Yolu";
            this.DosyaYol.Name = "DosyaYol";
            this.DosyaYol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DosyaYol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DosyaYol.Width = 200;
            // 
            // SatirNo
            // 
            this.SatirNo.DataPropertyName = "SatirNo";
            this.SatirNo.HeaderText = "Satır No";
            this.SatirNo.Name = "SatirNo";
            this.SatirNo.Width = 70;
            // 
            // Iceren
            // 
            this.Iceren.DataPropertyName = "Satir";
            this.Iceren.HeaderText = "İçeren Satır";
            this.Iceren.Name = "Iceren";
            this.Iceren.Width = 86;
            // 
            // IndexNo
            // 
            this.IndexNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IndexNo.DataPropertyName = "IndexNo";
            this.IndexNo.HeaderText = "indx";
            this.IndexNo.Name = "IndexNo";
            this.IndexNo.Width = 51;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 461);
            this.Controls.Add(this.Gbx);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSearch";
            this.Text = "Ara";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Gbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox TxtHedef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHedef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTip;
        private System.Windows.Forms.TextBox TxtKelime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.CheckBox CbxDahil;
        private System.Windows.Forms.GroupBox Gbx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosyaAdi;
        private System.Windows.Forms.DataGridViewLinkColumn DosyaYol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatirNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iceren;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexNo;
    }
}