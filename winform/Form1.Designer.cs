
namespace winform
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rd_Volvo = new System.Windows.Forms.RadioButton();
            this.rd_Honda = new System.Windows.Forms.RadioButton();
            this.rd_Mazda = new System.Windows.Forms.RadioButton();
            this.rd_Tesla = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_Model = new System.Windows.Forms.ComboBox();
            this.ch_Performans = new System.Windows.Forms.CheckBox();
            this.ch_Kirlilik = new System.Windows.Forms.CheckBox();
            this.ch_Fiyat = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.32743F));
            this.tableLayoutPanel1.Controls.Add(this.rd_Volvo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rd_Honda, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rd_Mazda, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rd_Tesla, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.31579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(172, 154);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rd_Volvo
            // 
            this.rd_Volvo.AutoSize = true;
            this.rd_Volvo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rd_Volvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_Volvo.Location = new System.Drawing.Point(3, 113);
            this.rd_Volvo.Name = "rd_Volvo";
            this.rd_Volvo.Size = new System.Drawing.Size(166, 38);
            this.rd_Volvo.TabIndex = 3;
            this.rd_Volvo.TabStop = true;
            this.rd_Volvo.Text = "Volvo";
            this.rd_Volvo.UseVisualStyleBackColor = true;
            this.rd_Volvo.CheckedChanged += new System.EventHandler(this.rd_Volvo_CheckedChanged);
            // 
            // rd_Honda
            // 
            this.rd_Honda.AutoSize = true;
            this.rd_Honda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rd_Honda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_Honda.Location = new System.Drawing.Point(3, 73);
            this.rd_Honda.Name = "rd_Honda";
            this.rd_Honda.Size = new System.Drawing.Size(166, 34);
            this.rd_Honda.TabIndex = 2;
            this.rd_Honda.TabStop = true;
            this.rd_Honda.Text = "Honda";
            this.rd_Honda.UseVisualStyleBackColor = true;
            this.rd_Honda.CheckedChanged += new System.EventHandler(this.rd_Honda_CheckedChanged);
            // 
            // rd_Mazda
            // 
            this.rd_Mazda.AutoSize = true;
            this.rd_Mazda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rd_Mazda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_Mazda.Location = new System.Drawing.Point(3, 37);
            this.rd_Mazda.Name = "rd_Mazda";
            this.rd_Mazda.Size = new System.Drawing.Size(166, 30);
            this.rd_Mazda.TabIndex = 1;
            this.rd_Mazda.TabStop = true;
            this.rd_Mazda.Text = "Mazda";
            this.rd_Mazda.UseVisualStyleBackColor = true;
            this.rd_Mazda.CheckedChanged += new System.EventHandler(this.rd_Mazda_CheckedChanged);
            // 
            // rd_Tesla
            // 
            this.rd_Tesla.AutoSize = true;
            this.rd_Tesla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rd_Tesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_Tesla.Location = new System.Drawing.Point(3, 3);
            this.rd_Tesla.Name = "rd_Tesla";
            this.rd_Tesla.Size = new System.Drawing.Size(166, 28);
            this.rd_Tesla.TabIndex = 0;
            this.rd_Tesla.TabStop = true;
            this.rd_Tesla.Text = "Tesla";
            this.rd_Tesla.UseVisualStyleBackColor = true;
            this.rd_Tesla.CheckedChanged += new System.EventHandler(this.rd_Tesla_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araba Markaları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(361, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marka Modelleri";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.32743F));
            this.tableLayoutPanel2.Controls.Add(this.cbx_Model, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.31579F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(185, 147);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbx_Model
            // 
            this.cbx_Model.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_Model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbx_Model.FormattingEnabled = true;
            this.cbx_Model.Location = new System.Drawing.Point(3, 3);
            this.cbx_Model.Name = "cbx_Model";
            this.cbx_Model.Size = new System.Drawing.Size(179, 28);
            this.cbx_Model.TabIndex = 0;
            // 
            // ch_Performans
            // 
            this.ch_Performans.AutoSize = true;
            this.ch_Performans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ch_Performans.Location = new System.Drawing.Point(223, 93);
            this.ch_Performans.Name = "ch_Performans";
            this.ch_Performans.Size = new System.Drawing.Size(110, 24);
            this.ch_Performans.TabIndex = 4;
            this.ch_Performans.Text = "Performans";
            this.ch_Performans.UseVisualStyleBackColor = true;
            this.ch_Performans.CheckedChanged += new System.EventHandler(this.rd_Tesla_CheckedChanged);
            // 
            // ch_Kirlilik
            // 
            this.ch_Kirlilik.AutoSize = true;
            this.ch_Kirlilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ch_Kirlilik.Location = new System.Drawing.Point(223, 139);
            this.ch_Kirlilik.Name = "ch_Kirlilik";
            this.ch_Kirlilik.Size = new System.Drawing.Size(115, 24);
            this.ch_Kirlilik.TabIndex = 5;
            this.ch_Kirlilik.Text = "Çevre Kirliliği";
            this.ch_Kirlilik.UseVisualStyleBackColor = true;
            this.ch_Kirlilik.CheckedChanged += new System.EventHandler(this.rd_Tesla_CheckedChanged);
            // 
            // ch_Fiyat
            // 
            this.ch_Fiyat.AutoSize = true;
            this.ch_Fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ch_Fiyat.Location = new System.Drawing.Point(223, 42);
            this.ch_Fiyat.Name = "ch_Fiyat";
            this.ch_Fiyat.Size = new System.Drawing.Size(62, 24);
            this.ch_Fiyat.TabIndex = 3;
            this.ch_Fiyat.Text = "Fiyat";
            this.ch_Fiyat.UseVisualStyleBackColor = true;
            this.ch_Fiyat.CheckedChanged += new System.EventHandler(this.rd_Tesla_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.ch_Kirlilik);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ch_Performans);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ch_Fiyat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbx_Model;
        private System.Windows.Forms.RadioButton rd_Volvo;
        private System.Windows.Forms.RadioButton rd_Honda;
        private System.Windows.Forms.RadioButton rd_Mazda;
        private System.Windows.Forms.RadioButton rd_Tesla;
        private System.Windows.Forms.CheckBox ch_Kirlilik;
        private System.Windows.Forms.CheckBox ch_Performans;
        private System.Windows.Forms.CheckBox ch_Fiyat;
    }
}

