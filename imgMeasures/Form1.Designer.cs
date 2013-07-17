namespace imgMeasures
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLine1 = new System.Windows.Forms.Button();
            this.btnLine2 = new System.Windows.Forms.Button();
            this.txtLine1 = new System.Windows.Forms.TextBox();
            this.txtLine2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDraw1 = new System.Windows.Forms.Button();
            this.btnDraw2 = new System.Windows.Forms.Button();
            this.btnErase2 = new System.Windows.Forms.Button();
            this.btnErase1 = new System.Windows.Forms.Button();
            this.txtArea1 = new System.Windows.Forms.TextBox();
            this.txtArea2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(218, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtArea2);
            this.groupBox1.Controls.Add(this.txtArea1);
            this.groupBox1.Controls.Add(this.btnErase2);
            this.groupBox1.Controls.Add(this.btnErase1);
            this.groupBox1.Controls.Add(this.btnDraw2);
            this.groupBox1.Controls.Add(this.btnDraw1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Piešimas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAngle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtLine2);
            this.groupBox2.Controls.Add(this.txtLine1);
            this.groupBox2.Controls.Add(this.btnLine2);
            this.groupBox2.Controls.Add(this.btnLine1);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Linijos";
            // 
            // btnLine1
            // 
            this.btnLine1.Location = new System.Drawing.Point(6, 30);
            this.btnLine1.Name = "btnLine1";
            this.btnLine1.Size = new System.Drawing.Size(66, 23);
            this.btnLine1.TabIndex = 0;
            this.btnLine1.Text = "Taisyti 1";
            this.btnLine1.UseVisualStyleBackColor = true;
            this.btnLine1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLine2
            // 
            this.btnLine2.Location = new System.Drawing.Point(6, 59);
            this.btnLine2.Name = "btnLine2";
            this.btnLine2.Size = new System.Drawing.Size(66, 23);
            this.btnLine2.TabIndex = 1;
            this.btnLine2.Text = "Taisyti 2";
            this.btnLine2.UseVisualStyleBackColor = true;
            // 
            // txtLine1
            // 
            this.txtLine1.Location = new System.Drawing.Point(78, 32);
            this.txtLine1.Name = "txtLine1";
            this.txtLine1.ReadOnly = true;
            this.txtLine1.Size = new System.Drawing.Size(100, 20);
            this.txtLine1.TabIndex = 2;
            // 
            // txtLine2
            // 
            this.txtLine2.Location = new System.Drawing.Point(78, 61);
            this.txtLine2.Name = "txtLine2";
            this.txtLine2.ReadOnly = true;
            this.txtLine2.Size = new System.Drawing.Size(100, 20);
            this.txtLine2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kampas:";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(78, 104);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.ReadOnly = true;
            this.txtAngle.Size = new System.Drawing.Size(100, 20);
            this.txtAngle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ilgiai:";
            // 
            // btnDraw1
            // 
            this.btnDraw1.Location = new System.Drawing.Point(8, 33);
            this.btnDraw1.Name = "btnDraw1";
            this.btnDraw1.Size = new System.Drawing.Size(44, 23);
            this.btnDraw1.TabIndex = 0;
            this.btnDraw1.Text = "Piešti";
            this.btnDraw1.UseVisualStyleBackColor = true;
            // 
            // btnDraw2
            // 
            this.btnDraw2.Location = new System.Drawing.Point(8, 62);
            this.btnDraw2.Name = "btnDraw2";
            this.btnDraw2.Size = new System.Drawing.Size(44, 23);
            this.btnDraw2.TabIndex = 1;
            this.btnDraw2.Text = "Piešti";
            this.btnDraw2.UseVisualStyleBackColor = true;
            // 
            // btnErase2
            // 
            this.btnErase2.Location = new System.Drawing.Point(58, 62);
            this.btnErase2.Name = "btnErase2";
            this.btnErase2.Size = new System.Drawing.Size(44, 23);
            this.btnErase2.TabIndex = 3;
            this.btnErase2.Text = "Trinti";
            this.btnErase2.UseVisualStyleBackColor = true;
            // 
            // btnErase1
            // 
            this.btnErase1.Location = new System.Drawing.Point(58, 33);
            this.btnErase1.Name = "btnErase1";
            this.btnErase1.Size = new System.Drawing.Size(44, 23);
            this.btnErase1.TabIndex = 2;
            this.btnErase1.Text = "Trinti";
            this.btnErase1.UseVisualStyleBackColor = true;
            // 
            // txtArea1
            // 
            this.txtArea1.Location = new System.Drawing.Point(110, 35);
            this.txtArea1.Name = "txtArea1";
            this.txtArea1.ReadOnly = true;
            this.txtArea1.Size = new System.Drawing.Size(82, 20);
            this.txtArea1.TabIndex = 4;
            // 
            // txtArea2
            // 
            this.txtArea2.Location = new System.Drawing.Point(110, 64);
            this.txtArea2.Name = "txtArea2";
            this.txtArea2.ReadOnly = true;
            this.txtArea2.Size = new System.Drawing.Size(82, 20);
            this.txtArea2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Plotai:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 253);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(200, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Užkrauti paveiksliuką";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 420);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLine1;
        private System.Windows.Forms.Button btnLine2;
        private System.Windows.Forms.TextBox txtLine2;
        private System.Windows.Forms.TextBox txtLine1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArea2;
        private System.Windows.Forms.TextBox txtArea1;
        private System.Windows.Forms.Button btnErase2;
        private System.Windows.Forms.Button btnErase1;
        private System.Windows.Forms.Button btnDraw2;
        private System.Windows.Forms.Button btnDraw1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
    }
}

