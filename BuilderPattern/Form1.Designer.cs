namespace BuilderPattern
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnHelmet = new System.Windows.Forms.Button();
            this.btnWeapon = new System.Windows.Forms.Button();
            this.btnShoes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlChangeEquipment = new System.Windows.Forms.Panel();
            this.panel1 = new BuilderPattern.CustomPanel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.pnlChangeEquipment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(407, 404);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnHelmet
            // 
            this.btnHelmet.Location = new System.Drawing.Point(12, 12);
            this.btnHelmet.Name = "btnHelmet";
            this.btnHelmet.Size = new System.Drawing.Size(75, 23);
            this.btnHelmet.TabIndex = 2;
            this.btnHelmet.Text = "Nón";
            this.btnHelmet.UseVisualStyleBackColor = true;
            this.btnHelmet.Click += new System.EventHandler(this.btnChangeType_Click);
            // 
            // btnWeapon
            // 
            this.btnWeapon.Location = new System.Drawing.Point(93, 12);
            this.btnWeapon.Name = "btnWeapon";
            this.btnWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnWeapon.TabIndex = 2;
            this.btnWeapon.Text = "Vũ khí";
            this.btnWeapon.UseVisualStyleBackColor = true;
            this.btnWeapon.Click += new System.EventHandler(this.btnChangeType_Click);
            // 
            // btnShoes
            // 
            this.btnShoes.Location = new System.Drawing.Point(174, 12);
            this.btnShoes.Name = "btnShoes";
            this.btnShoes.Size = new System.Drawing.Size(75, 23);
            this.btnShoes.TabIndex = 2;
            this.btnShoes.Text = "Giày";
            this.btnShoes.UseVisualStyleBackColor = true;
            this.btnShoes.Click += new System.EventHandler(this.btnChangeType_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(353, 100);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 34);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Tạo nhân vật";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(353, 173);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(101, 34);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Xác nhận";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pnlChangeEquipment);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(460, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 457);
            this.panel2.TabIndex = 3;
            // 
            // pnlChangeEquipment
            // 
            this.pnlChangeEquipment.Controls.Add(this.btnHelmet);
            this.pnlChangeEquipment.Controls.Add(this.button4);
            this.pnlChangeEquipment.Controls.Add(this.btnWeapon);
            this.pnlChangeEquipment.Controls.Add(this.btnShoes);
            this.pnlChangeEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChangeEquipment.Location = new System.Drawing.Point(0, 0);
            this.pnlChangeEquipment.Name = "pnlChangeEquipment";
            this.pnlChangeEquipment.Size = new System.Drawing.Size(407, 53);
            this.pnlChangeEquipment.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 457);
            this.panel1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(66, 419);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 26);
            this.txtName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 457);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.pnlChangeEquipment.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnHelmet;
        private System.Windows.Forms.Button btnWeapon;
        private System.Windows.Forms.Button btnShoes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlChangeEquipment;
    }
}

