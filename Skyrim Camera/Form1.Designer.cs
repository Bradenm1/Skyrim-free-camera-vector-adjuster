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
            this.LyPos = new System.Windows.Forms.Label();
            this.labelCameraX = new System.Windows.Forms.Label();
            this.labelCameraZ = new System.Windows.Forms.Label();
            this.LxPos = new System.Windows.Forms.Label();
            this.LzPos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Lyaw = new System.Windows.Forms.Label();
            this.Lpitch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
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
            // LyPos
            // 
            this.LyPos.AutoSize = true;
            this.LyPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LyPos.ForeColor = System.Drawing.Color.White;
            this.LyPos.Location = new System.Drawing.Point(131, 9);
            this.LyPos.Name = "LyPos";
            this.LyPos.Size = new System.Drawing.Size(46, 25);
            this.LyPos.TabIndex = 13;
            this.LyPos.Text = "null";
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
            // LxPos
            // 
            this.LxPos.AutoSize = true;
            this.LxPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LxPos.ForeColor = System.Drawing.Color.White;
            this.LxPos.Location = new System.Drawing.Point(131, 34);
            this.LxPos.Name = "LxPos";
            this.LxPos.Size = new System.Drawing.Size(46, 25);
            this.LxPos.TabIndex = 16;
            this.LxPos.Text = "null";
            // 
            // LzPos
            // 
            this.LzPos.AutoSize = true;
            this.LzPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LzPos.ForeColor = System.Drawing.Color.White;
            this.LzPos.Location = new System.Drawing.Point(131, 59);
            this.LzPos.Name = "LzPos";
            this.LzPos.Size = new System.Drawing.Size(46, 25);
            this.LzPos.TabIndex = 17;
            this.LzPos.Text = "null";
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
            // Lyaw
            // 
            this.Lyaw.AutoSize = true;
            this.Lyaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lyaw.ForeColor = System.Drawing.Color.White;
            this.Lyaw.Location = new System.Drawing.Point(14, 84);
            this.Lyaw.Name = "Lyaw";
            this.Lyaw.Size = new System.Drawing.Size(60, 25);
            this.Lyaw.TabIndex = 22;
            this.Lyaw.Text = "Yaw:";
            // 
            // Lpitch
            // 
            this.Lpitch.AutoSize = true;
            this.Lpitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpitch.ForeColor = System.Drawing.Color.White;
            this.Lpitch.Location = new System.Drawing.Point(14, 109);
            this.Lpitch.Name = "Lpitch";
            this.Lpitch.Size = new System.Drawing.Size(66, 25);
            this.Lpitch.TabIndex = 23;
            this.Lpitch.Text = "Pitch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(131, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "null";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(254, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(254, 114);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(398, 154);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lpitch);
            this.Controls.Add(this.Lyaw);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LzPos);
            this.Controls.Add(this.LxPos);
            this.Controls.Add(this.labelCameraZ);
            this.Controls.Add(this.labelCameraX);
            this.Controls.Add(this.LyPos);
            this.Controls.Add(this.labelCameraY);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Skyrim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCameraY;
        private System.Windows.Forms.Label LyPos;
        private System.Windows.Forms.Label labelCameraX;
        private System.Windows.Forms.Label labelCameraZ;
        private System.Windows.Forms.Label LxPos;
        private System.Windows.Forms.Label LzPos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label Lyaw;
        private System.Windows.Forms.Label Lpitch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

