
namespace SimThe
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
            this.dgvSim = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMangID = new System.Windows.Forms.TextBox();
            this.txtSoSim = new System.Windows.Forms.TextBox();
            this.txtNgayKH = new System.Windows.Forms.MaskedTextBox();
            this.txtNgayHH = new System.Windows.Forms.MaskedTextBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSim
            // 
            this.dgvSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSim.Location = new System.Drawing.Point(466, 42);
            this.dgvSim.Name = "dgvSim";
            this.dgvSim.RowHeadersWidth = 51;
            this.dgvSim.RowTemplate.Height = 24;
            this.dgvSim.Size = new System.Drawing.Size(602, 330);
            this.dgvSim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "số sim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "id mạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "ngày kích hoạt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "ngày hết hạn";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(122, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 6;
            // 
            // txtMangID
            // 
            this.txtMangID.Location = new System.Drawing.Point(122, 146);
            this.txtMangID.Name = "txtMangID";
            this.txtMangID.Size = new System.Drawing.Size(100, 22);
            this.txtMangID.TabIndex = 7;
            // 
            // txtSoSim
            // 
            this.txtSoSim.Location = new System.Drawing.Point(122, 106);
            this.txtSoSim.Name = "txtSoSim";
            this.txtSoSim.Size = new System.Drawing.Size(100, 22);
            this.txtSoSim.TabIndex = 8;
            this.txtSoSim.Enter += new System.EventHandler(this.txtSoSim_Enter);
            this.txtSoSim.Leave += new System.EventHandler(this.txtSoSim_Leave);
            // 
            // txtNgayKH
            // 
            this.txtNgayKH.Location = new System.Drawing.Point(122, 182);
            this.txtNgayKH.Mask = "0000-00-00";
            this.txtNgayKH.Name = "txtNgayKH";
            this.txtNgayKH.Size = new System.Drawing.Size(100, 22);
            this.txtNgayKH.TabIndex = 9;
            // 
            // txtNgayHH
            // 
            this.txtNgayHH.Location = new System.Drawing.Point(122, 217);
            this.txtNgayHH.Mask = "0000-00-00";
            this.txtNgayHH.Name = "txtNgayHH";
            this.txtNgayHH.Size = new System.Drawing.Size(100, 22);
            this.txtNgayHH.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(181, 339);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtNgayHH);
            this.Controls.Add(this.txtNgayKH);
            this.Controls.Add(this.txtSoSim);
            this.Controls.Add(this.txtMangID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMangID;
        private System.Windows.Forms.TextBox txtSoSim;
        private System.Windows.Forms.MaskedTextBox txtNgayKH;
        private System.Windows.Forms.MaskedTextBox txtNgayHH;
        private System.Windows.Forms.Button btnThem;
    }
}

