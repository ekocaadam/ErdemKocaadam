
namespace PiggyBankEK
{
    partial class KumbaraForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnKatla = new System.Windows.Forms.Button();
            this.btnParaAt = new System.Windows.Forms.Button();
            this.btnShakeIt = new System.Windows.Forms.Button();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.cmbKagitPara = new System.Windows.Forms.ComboBox();
            this.cmbBozukPara = new System.Windows.Forms.ComboBox();
            this.lblFazladan = new System.Windows.Forms.Label();
            this.lblParaHacmi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAydinlat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKatla
            // 
            this.btnKatla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnKatla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKatla.Location = new System.Drawing.Point(16, 203);
            this.btnKatla.Margin = new System.Windows.Forms.Padding(4);
            this.btnKatla.Name = "btnKatla";
            this.btnKatla.Size = new System.Drawing.Size(126, 59);
            this.btnKatla.TabIndex = 0;
            this.btnKatla.Text = "Kağıt Parayı Katla (4\'e Böl)";
            this.btnKatla.UseVisualStyleBackColor = false;
            this.btnKatla.Click += new System.EventHandler(this.btnKatla_Click);
            // 
            // btnParaAt
            // 
            this.btnParaAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnParaAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaAt.Location = new System.Drawing.Point(194, 84);
            this.btnParaAt.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaAt.Name = "btnParaAt";
            this.btnParaAt.Size = new System.Drawing.Size(288, 126);
            this.btnParaAt.TabIndex = 1;
            this.btnParaAt.Text = "Kumbaraya Paraları İtele";
            this.btnParaAt.UseVisualStyleBackColor = false;
            this.btnParaAt.Click += new System.EventHandler(this.btnParaAt_Click);
            // 
            // btnShakeIt
            // 
            this.btnShakeIt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnShakeIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShakeIt.Location = new System.Drawing.Point(48, 334);
            this.btnShakeIt.Margin = new System.Windows.Forms.Padding(4);
            this.btnShakeIt.Name = "btnShakeIt";
            this.btnShakeIt.Size = new System.Drawing.Size(183, 101);
            this.btnShakeIt.TabIndex = 2;
            this.btnShakeIt.Text = "Shake It !!";
            this.btnShakeIt.UseVisualStyleBackColor = false;
            this.btnShakeIt.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // btnDestroy
            // 
            this.btnDestroy.BackColor = System.Drawing.Color.Red;
            this.btnDestroy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDestroy.Location = new System.Drawing.Point(247, 334);
            this.btnDestroy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(211, 101);
            this.btnDestroy.TabIndex = 3;
            this.btnDestroy.Text = "Destroy !!!!";
            this.btnDestroy.UseVisualStyleBackColor = false;
            this.btnDestroy.Click += new System.EventHandler(this.btnKir_Click);
            // 
            // cmbKagitPara
            // 
            this.cmbKagitPara.FormattingEnabled = true;
            this.cmbKagitPara.Location = new System.Drawing.Point(7, 170);
            this.cmbKagitPara.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKagitPara.Name = "cmbKagitPara";
            this.cmbKagitPara.Size = new System.Drawing.Size(160, 25);
            this.cmbKagitPara.TabIndex = 4;
            this.cmbKagitPara.Text = "Kağıt Para Seçiniz:";
            this.cmbKagitPara.SelectedIndexChanged += new System.EventHandler(this.cmbKagitPara_SelectedIndexChanged);
            // 
            // cmbBozukPara
            // 
            this.cmbBozukPara.FormattingEnabled = true;
            this.cmbBozukPara.Location = new System.Drawing.Point(7, 99);
            this.cmbBozukPara.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBozukPara.Name = "cmbBozukPara";
            this.cmbBozukPara.Size = new System.Drawing.Size(160, 25);
            this.cmbBozukPara.TabIndex = 5;
            this.cmbBozukPara.Text = "Madeni Para Seçiniz:";
            this.cmbBozukPara.SelectedIndexChanged += new System.EventHandler(this.cmbBozukPara_SelectedIndexChanged);
            // 
            // lblFazladan
            // 
            this.lblFazladan.AutoSize = true;
            this.lblFazladan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFazladan.ForeColor = System.Drawing.Color.Black;
            this.lblFazladan.Location = new System.Drawing.Point(46, 303);
            this.lblFazladan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFazladan.Name = "lblFazladan";
            this.lblFazladan.Size = new System.Drawing.Size(250, 18);
            this.lblFazladan.TabIndex = 25;
            this.lblFazladan.Text = "Paraların kapladığı fazladan hacim:  0";
            this.lblFazladan.Click += new System.EventHandler(this.lblFazladan_Click);
            // 
            // lblParaHacmi
            // 
            this.lblParaHacmi.AutoSize = true;
            this.lblParaHacmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaHacmi.ForeColor = System.Drawing.Color.Black;
            this.lblParaHacmi.Location = new System.Drawing.Point(49, 275);
            this.lblParaHacmi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParaHacmi.Name = "lblParaHacmi";
            this.lblParaHacmi.Size = new System.Drawing.Size(187, 18);
            this.lblParaHacmi.TabIndex = 24;
            this.lblParaHacmi.Text = "Paraların kapladığı hacim: 0";
            this.lblParaHacmi.Click += new System.EventHandler(this.lblParaHacmi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kağıt Para";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Bozuk Para";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kumbaradaki Kağıt Paralar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(48, 461);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(188, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Location = new System.Drawing.Point(253, 461);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(188, 249);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(257, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kumbaradaki Bozuk Paralar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(137, 723);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Biriken Miktar: 0₺";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnAydinlat
            // 
            this.btnAydinlat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAydinlat.Location = new System.Drawing.Point(377, 217);
            this.btnAydinlat.Name = "btnAydinlat";
            this.btnAydinlat.Size = new System.Drawing.Size(105, 45);
            this.btnAydinlat.TabIndex = 28;
            this.btnAydinlat.Text = "İmdat ! Aydınlat Beni";
            this.btnAydinlat.UseVisualStyleBackColor = false;
            this.btnAydinlat.Click += new System.EventHandler(this.btnAydinlat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Magenta;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(135, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 39);
            this.label6.TabIndex = 29;
            this.label6.Text = "PIGGY BANK";
            // 
            // KumbaraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(497, 754);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAydinlat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblFazladan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblParaHacmi);
            this.Controls.Add(this.cmbBozukPara);
            this.Controls.Add(this.cmbKagitPara);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.btnShakeIt);
            this.Controls.Add(this.btnParaAt);
            this.Controls.Add(this.btnKatla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KumbaraForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KumbaraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKatla;
        private System.Windows.Forms.Button btnParaAt;
        private System.Windows.Forms.Button btnShakeIt;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.ComboBox cmbKagitPara;
        private System.Windows.Forms.ComboBox cmbBozukPara;
        private System.Windows.Forms.Label lblFazladan;
        private System.Windows.Forms.Label lblParaHacmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAydinlat;
        private System.Windows.Forms.Label label6;
    }
}

