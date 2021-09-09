namespace ProductosM1.Forms
{
    partial class FrmProductManage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.pnlID = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlUM = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pnlRankprice = new System.Windows.Forms.Panel();
            this.nupHPrecio = new System.Windows.Forms.NumericUpDown();
            this.nupDPrecio = new System.Windows.Forms.NumericUpDown();
            this.dtpCaducity = new System.Windows.Forms.DateTimePicker();
            this.pnlCaducity = new System.Windows.Forms.Panel();
            this.rtbProductView = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlID.SuspendLayout();
            this.pnlUM.SuspendLayout();
            this.pnlRankprice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDPrecio)).BeginInit();
            this.pnlCaducity.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnMod);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 409);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(84, 3);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 1;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbFinder
            // 
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Location = new System.Drawing.Point(15, 8);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(191, 21);
            this.cmbFinder.TabIndex = 1;
            this.cmbFinder.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // pnlID
            // 
            this.pnlID.Controls.Add(this.textBox1);
            this.pnlID.Location = new System.Drawing.Point(212, 7);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(462, 28);
            this.pnlID.TabIndex = 2;
            this.pnlID.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pnlUM
            // 
            this.pnlUM.Controls.Add(this.comboBox2);
            this.pnlUM.Location = new System.Drawing.Point(212, 5);
            this.pnlUM.Name = "pnlUM";
            this.pnlUM.Size = new System.Drawing.Size(462, 30);
            this.pnlUM.TabIndex = 3;
            this.pnlUM.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(455, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // pnlRankprice
            // 
            this.pnlRankprice.Controls.Add(this.nupHPrecio);
            this.pnlRankprice.Controls.Add(this.nupDPrecio);
            this.pnlRankprice.Location = new System.Drawing.Point(212, 5);
            this.pnlRankprice.Name = "pnlRankprice";
            this.pnlRankprice.Size = new System.Drawing.Size(462, 30);
            this.pnlRankprice.TabIndex = 4;
            this.pnlRankprice.Visible = false;
            // 
            // nupHPrecio
            // 
            this.nupHPrecio.Location = new System.Drawing.Point(262, 4);
            this.nupHPrecio.Name = "nupHPrecio";
            this.nupHPrecio.Size = new System.Drawing.Size(197, 20);
            this.nupHPrecio.TabIndex = 1;
            // 
            // nupDPrecio
            // 
            this.nupDPrecio.Location = new System.Drawing.Point(3, 4);
            this.nupDPrecio.Name = "nupDPrecio";
            this.nupDPrecio.Size = new System.Drawing.Size(204, 20);
            this.nupDPrecio.TabIndex = 0;
            // 
            // dtpCaducity
            // 
            this.dtpCaducity.Location = new System.Drawing.Point(3, 3);
            this.dtpCaducity.Name = "dtpCaducity";
            this.dtpCaducity.Size = new System.Drawing.Size(277, 20);
            this.dtpCaducity.TabIndex = 5;
            // 
            // pnlCaducity
            // 
            this.pnlCaducity.Controls.Add(this.dtpCaducity);
            this.pnlCaducity.Location = new System.Drawing.Point(212, 5);
            this.pnlCaducity.Name = "pnlCaducity";
            this.pnlCaducity.Size = new System.Drawing.Size(462, 30);
            this.pnlCaducity.TabIndex = 6;
            this.pnlCaducity.Visible = false;
            // 
            // rtbProductView
            // 
            this.rtbProductView.Location = new System.Drawing.Point(15, 41);
            this.rtbProductView.Name = "rtbProductView";
            this.rtbProductView.ReadOnly = true;
            this.rtbProductView.Size = new System.Drawing.Size(773, 362);
            this.rtbProductView.TabIndex = 5;
            this.rtbProductView.Text = "";
            // 
            // FrmProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCaducity);
            this.Controls.Add(this.rtbProductView);
            this.Controls.Add(this.pnlRankprice);
            this.Controls.Add(this.pnlUM);
            this.Controls.Add(this.pnlID);
            this.Controls.Add(this.cmbFinder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmProductManage";
            this.Text = "FrmProductManage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.pnlUM.ResumeLayout(false);
            this.pnlRankprice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupHPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDPrecio)).EndInit();
            this.pnlCaducity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlUM;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel pnlRankprice;
        private System.Windows.Forms.NumericUpDown nupHPrecio;
        private System.Windows.Forms.NumericUpDown nupDPrecio;
        private System.Windows.Forms.DateTimePicker dtpCaducity;
        private System.Windows.Forms.Panel pnlCaducity;
        private System.Windows.Forms.RichTextBox rtbProductView;
    }
}