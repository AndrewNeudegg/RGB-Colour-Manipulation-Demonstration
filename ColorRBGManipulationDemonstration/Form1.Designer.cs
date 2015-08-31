namespace ColorRBGManipulationDemonstration
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
            this.button1 = new System.Windows.Forms.Button();
            this.REqualsB = new System.Windows.Forms.Button();
            this.REqualsG = new System.Windows.Forms.Button();
            this.BEqualsG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_Brightness = new System.Windows.Forms.Label();
            this.lbl_Hue = new System.Windows.Forms.Label();
            this.lbl_Saturation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BEqualsR = new System.Windows.Forms.Button();
            this.GEqualsR = new System.Windows.Forms.Button();
            this.GEqualsB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trkBrR = new System.Windows.Forms.TrackBar();
            this.trkBrB = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trkBrG = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trkBrOverall = new System.Windows.Forms.TrackBar();
            this.graph3 = new ColorRBGDemonstration.Graph();
            this.graph2 = new ColorRBGDemonstration.Graph();
            this.graph1 = new ColorRBGDemonstration.Graph();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrOverall)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pick Color";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // REqualsB
            // 
            this.REqualsB.BackColor = System.Drawing.Color.White;
            this.REqualsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REqualsB.Location = new System.Drawing.Point(6, 19);
            this.REqualsB.Name = "REqualsB";
            this.REqualsB.Size = new System.Drawing.Size(94, 79);
            this.REqualsB.TabIndex = 4;
            this.REqualsB.Text = "R=B";
            this.REqualsB.UseVisualStyleBackColor = false;
            this.REqualsB.Click += new System.EventHandler(this.REqualsB_Click);
            // 
            // REqualsG
            // 
            this.REqualsG.BackColor = System.Drawing.Color.White;
            this.REqualsG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REqualsG.Location = new System.Drawing.Point(6, 112);
            this.REqualsG.Name = "REqualsG";
            this.REqualsG.Size = new System.Drawing.Size(94, 79);
            this.REqualsG.TabIndex = 5;
            this.REqualsG.Text = "R=G";
            this.REqualsG.UseVisualStyleBackColor = false;
            this.REqualsG.Click += new System.EventHandler(this.REqualsG_Click);
            // 
            // BEqualsG
            // 
            this.BEqualsG.BackColor = System.Drawing.Color.White;
            this.BEqualsG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEqualsG.Location = new System.Drawing.Point(106, 112);
            this.BEqualsG.Name = "BEqualsG";
            this.BEqualsG.Size = new System.Drawing.Size(94, 79);
            this.BEqualsG.TabIndex = 6;
            this.BEqualsG.Text = "B=G";
            this.BEqualsG.UseVisualStyleBackColor = false;
            this.BEqualsG.Click += new System.EventHandler(this.BEqualsG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "RBG: null";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(269, 178);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_Brightness
            // 
            this.lbl_Brightness.AutoSize = true;
            this.lbl_Brightness.Location = new System.Drawing.Point(3, 133);
            this.lbl_Brightness.Name = "lbl_Brightness";
            this.lbl_Brightness.Size = new System.Drawing.Size(78, 13);
            this.lbl_Brightness.TabIndex = 9;
            this.lbl_Brightness.Text = "Brightness: null";
            // 
            // lbl_Hue
            // 
            this.lbl_Hue.AutoSize = true;
            this.lbl_Hue.Location = new System.Drawing.Point(3, 160);
            this.lbl_Hue.Name = "lbl_Hue";
            this.lbl_Hue.Size = new System.Drawing.Size(49, 13);
            this.lbl_Hue.TabIndex = 10;
            this.lbl_Hue.Text = "Hue: null";
            this.lbl_Hue.Click += new System.EventHandler(this.lbl_Hue_Click);
            // 
            // lbl_Saturation
            // 
            this.lbl_Saturation.AutoSize = true;
            this.lbl_Saturation.Location = new System.Drawing.Point(3, 147);
            this.lbl_Saturation.Name = "lbl_Saturation";
            this.lbl_Saturation.Size = new System.Drawing.Size(77, 13);
            this.lbl_Saturation.TabIndex = 11;
            this.lbl_Saturation.Text = "Saturation: null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Saturation);
            this.groupBox1.Controls.Add(this.lbl_Brightness);
            this.groupBox1.Controls.Add(this.lbl_Hue);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 196);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BEqualsR
            // 
            this.BEqualsR.BackColor = System.Drawing.Color.White;
            this.BEqualsR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEqualsR.Location = new System.Drawing.Point(106, 19);
            this.BEqualsR.Name = "BEqualsR";
            this.BEqualsR.Size = new System.Drawing.Size(94, 79);
            this.BEqualsR.TabIndex = 13;
            this.BEqualsR.Text = "B=R";
            this.BEqualsR.UseVisualStyleBackColor = false;
            this.BEqualsR.Click += new System.EventHandler(this.BEqualsR_Click);
            // 
            // GEqualsR
            // 
            this.GEqualsR.BackColor = System.Drawing.Color.White;
            this.GEqualsR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GEqualsR.Location = new System.Drawing.Point(206, 19);
            this.GEqualsR.Name = "GEqualsR";
            this.GEqualsR.Size = new System.Drawing.Size(94, 79);
            this.GEqualsR.TabIndex = 14;
            this.GEqualsR.Text = "G=R";
            this.GEqualsR.UseVisualStyleBackColor = false;
            this.GEqualsR.Click += new System.EventHandler(this.GEqualsR_Click);
            // 
            // GEqualsB
            // 
            this.GEqualsB.BackColor = System.Drawing.Color.White;
            this.GEqualsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GEqualsB.Location = new System.Drawing.Point(206, 112);
            this.GEqualsB.Name = "GEqualsB";
            this.GEqualsB.Size = new System.Drawing.Size(94, 79);
            this.GEqualsB.TabIndex = 15;
            this.GEqualsB.Text = "G=B";
            this.GEqualsB.UseVisualStyleBackColor = false;
            this.GEqualsB.Click += new System.EventHandler(this.GEqualsB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.REqualsB);
            this.groupBox2.Controls.Add(this.GEqualsB);
            this.groupBox2.Controls.Add(this.REqualsG);
            this.groupBox2.Controls.Add(this.GEqualsR);
            this.groupBox2.Controls.Add(this.BEqualsG);
            this.groupBox2.Controls.Add(this.BEqualsR);
            this.groupBox2.Location = new System.Drawing.Point(333, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 196);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equivilance Modifiers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "R Component:";
            // 
            // trkBrR
            // 
            this.trkBrR.LargeChange = 15;
            this.trkBrR.Location = new System.Drawing.Point(651, 28);
            this.trkBrR.Maximum = 255;
            this.trkBrR.Name = "trkBrR";
            this.trkBrR.Size = new System.Drawing.Size(284, 45);
            this.trkBrR.TabIndex = 18;
            this.trkBrR.TickFrequency = 5;
            this.trkBrR.Value = 128;
            this.trkBrR.Scroll += new System.EventHandler(this.trkBrR_Scroll);
            // 
            // trkBrB
            // 
            this.trkBrB.LargeChange = 15;
            this.trkBrB.Location = new System.Drawing.Point(651, 124);
            this.trkBrB.Maximum = 255;
            this.trkBrB.Name = "trkBrB";
            this.trkBrB.Size = new System.Drawing.Size(284, 45);
            this.trkBrB.TabIndex = 20;
            this.trkBrB.TickFrequency = 5;
            this.trkBrB.Value = 128;
            this.trkBrB.Scroll += new System.EventHandler(this.trkBrB_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "B Component:";
            // 
            // trkBrG
            // 
            this.trkBrG.LargeChange = 15;
            this.trkBrG.Location = new System.Drawing.Point(648, 76);
            this.trkBrG.Maximum = 255;
            this.trkBrG.Name = "trkBrG";
            this.trkBrG.Size = new System.Drawing.Size(284, 45);
            this.trkBrG.TabIndex = 22;
            this.trkBrG.TickFrequency = 5;
            this.trkBrG.Value = 128;
            this.trkBrG.Scroll += new System.EventHandler(this.trkBrG_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "G Component:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Overall Slider";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // trkBrOverall
            // 
            this.trkBrOverall.LargeChange = 15;
            this.trkBrOverall.Location = new System.Drawing.Point(648, 172);
            this.trkBrOverall.Maximum = 255;
            this.trkBrOverall.Name = "trkBrOverall";
            this.trkBrOverall.Size = new System.Drawing.Size(284, 45);
            this.trkBrOverall.TabIndex = 24;
            this.trkBrOverall.TickFrequency = 5;
            this.trkBrOverall.Value = 128;
            this.trkBrOverall.Scroll += new System.EventHandler(this.trkBrOverall_Scroll);
            // 
            // graph3
            // 
            this.graph3.Location = new System.Drawing.Point(633, 214);
            this.graph3.Name = "graph3";
            this.graph3.PointColor = System.Drawing.Color.Black;
            this.graph3.PointLocation = new System.Drawing.Point(50, 50);
            this.graph3.Size = new System.Drawing.Size(300, 300);
            this.graph3.TabIndex = 2;
            this.graph3.Text = "graph3";
            this.graph3.XAxisColor = System.Drawing.Color.Red;
            this.graph3.YAxisColor = System.Drawing.Color.Green;
            // 
            // graph2
            // 
            this.graph2.Location = new System.Drawing.Point(327, 214);
            this.graph2.Name = "graph2";
            this.graph2.PointColor = System.Drawing.Color.Black;
            this.graph2.PointLocation = new System.Drawing.Point(50, 50);
            this.graph2.Size = new System.Drawing.Size(300, 300);
            this.graph2.TabIndex = 1;
            this.graph2.Text = "graph2";
            this.graph2.XAxisColor = System.Drawing.Color.Red;
            this.graph2.YAxisColor = System.Drawing.Color.Green;
            // 
            // graph1
            // 
            this.graph1.Location = new System.Drawing.Point(12, 214);
            this.graph1.Name = "graph1";
            this.graph1.PointColor = System.Drawing.Color.Black;
            this.graph1.PointLocation = new System.Drawing.Point(50, 50);
            this.graph1.Size = new System.Drawing.Size(300, 300);
            this.graph1.TabIndex = 0;
            this.graph1.Text = "graph1";
            this.graph1.XAxisColor = System.Drawing.Color.Red;
            this.graph1.YAxisColor = System.Drawing.Color.Green;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 526);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trkBrOverall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trkBrG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trkBrB);
            this.Controls.Add(this.trkBrR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graph3);
            this.Controls.Add(this.graph2);
            this.Controls.Add(this.graph1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RGB Color Manipulation Demonstration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkBrR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrOverall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorRBGDemonstration.Graph graph1;
        private ColorRBGDemonstration.Graph graph2;
        private ColorRBGDemonstration.Graph graph3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button REqualsB;
        private System.Windows.Forms.Button REqualsG;
        private System.Windows.Forms.Button BEqualsG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_Brightness;
        private System.Windows.Forms.Label lbl_Hue;
        private System.Windows.Forms.Label lbl_Saturation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BEqualsR;
        private System.Windows.Forms.Button GEqualsR;
        private System.Windows.Forms.Button GEqualsB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trkBrR;
        private System.Windows.Forms.TrackBar trkBrB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkBrG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trkBrOverall;
    }
}

