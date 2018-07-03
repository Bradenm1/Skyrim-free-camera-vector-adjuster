namespace Skyrim
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCameraY = new System.Windows.Forms.Label();
            this.yPos = new System.Windows.Forms.Label();
            this.labelCameraX = new System.Windows.Forms.Label();
            this.labelCameraZ = new System.Windows.Forms.Label();
            this.xPos = new System.Windows.Forms.Label();
            this.zPos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 21;
            // 
            // labelCameraY
            // 
            this.labelCameraY.AutoSize = true;
            this.labelCameraY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCameraY.ForeColor = System.Drawing.Color.White;
            this.labelCameraY.Location = new System.Drawing.Point(12, 9);
            this.labelCameraY.Name = "labelCameraY";
            this.labelCameraY.Size = new System.Drawing.Size(114, 25);
            this.labelCameraY.TabIndex = 12;
            this.labelCameraY.Text = "Camera Y:";
            // 
            // yPos
            // 
            this.yPos.AutoSize = true;
            this.yPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPos.ForeColor = System.Drawing.Color.White;
            this.yPos.Location = new System.Drawing.Point(131, 9);
            this.yPos.Name = "yPos";
            this.yPos.Size = new System.Drawing.Size(46, 25);
            this.yPos.TabIndex = 13;
            this.yPos.Text = "null";
            // 
            // labelCameraX
            // 
            this.labelCameraX.AutoSize = true;
            this.labelCameraX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCameraX.ForeColor = System.Drawing.Color.White;
            this.labelCameraX.Location = new System.Drawing.Point(12, 34);
            this.labelCameraX.Name = "labelCameraX";
            this.labelCameraX.Size = new System.Drawing.Size(113, 25);
            this.labelCameraX.TabIndex = 14;
            this.labelCameraX.Text = "Camera X:";
            // 
            // labelCameraZ
            // 
            this.labelCameraZ.AutoSize = true;
            this.labelCameraZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCameraZ.ForeColor = System.Drawing.Color.White;
            this.labelCameraZ.Location = new System.Drawing.Point(12, 59);
            this.labelCameraZ.Name = "labelCameraZ";
            this.labelCameraZ.Size = new System.Drawing.Size(112, 25);
            this.labelCameraZ.TabIndex = 15;
            this.labelCameraZ.Text = "Camera Z:";
            // 
            // xPos
            // 
            this.xPos.AutoSize = true;
            this.xPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPos.ForeColor = System.Drawing.Color.White;
            this.xPos.Location = new System.Drawing.Point(131, 34);
            this.xPos.Name = "xPos";
            this.xPos.Size = new System.Drawing.Size(46, 25);
            this.xPos.TabIndex = 16;
            this.xPos.Text = "null";
            // 
            // zPos
            // 
            this.zPos.AutoSize = true;
            this.zPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zPos.ForeColor = System.Drawing.Color.White;
            this.zPos.Location = new System.Drawing.Point(131, 59);
            this.zPos.Name = "zPos";
            this.zPos.Size = new System.Drawing.Size(46, 25);
            this.zPos.TabIndex = 17;
            this.zPos.Text = "null";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(254, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(254, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 20;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(388, 109);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zPos);
            this.Controls.Add(this.xPos);
            this.Controls.Add(this.labelCameraZ);
            this.Controls.Add(this.labelCameraX);
            this.Controls.Add(this.yPos);
            this.Controls.Add(this.labelCameraY);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Skyrim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCameraY;
        private System.Windows.Forms.Label yPos;
        private System.Windows.Forms.Label labelCameraX;
        private System.Windows.Forms.Label labelCameraZ;
        private System.Windows.Forms.Label xPos;
        private System.Windows.Forms.Label zPos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

