namespace WindowsFormsApp1
{
    partial class gameboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lifelines = new System.Windows.Forms.GroupBox();
            this.giveUpButton = new System.Windows.Forms.Button();
            this.lifeLineButton = new System.Windows.Forms.Button();
            this.Rule_box = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Money_box = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.round_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.d_block = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.B_block = new System.Windows.Forms.Label();
            this.A_block = new System.Windows.Forms.Label();
            this.question_label = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.safe_amount = new System.Windows.Forms.Label();
            this.current_winning = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Lifelines.SuspendLayout();
            this.Rule_box.SuspendLayout();
            this.Money_box.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.WWTBAM_Logo_2011;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Lifelines
            // 
            this.Lifelines.Controls.Add(this.giveUpButton);
            this.Lifelines.Controls.Add(this.lifeLineButton);
            resources.ApplyResources(this.Lifelines, "Lifelines");
            this.Lifelines.ForeColor = System.Drawing.Color.Goldenrod;
            this.Lifelines.Name = "Lifelines";
            this.Lifelines.TabStop = false;
            // 
            // giveUpButton
            // 
            this.giveUpButton.BackColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.giveUpButton, "giveUpButton");
            this.giveUpButton.Name = "giveUpButton";
            this.giveUpButton.UseVisualStyleBackColor = false;
            // 
            // lifeLineButton
            // 
            this.lifeLineButton.BackColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.lifeLineButton, "lifeLineButton");
            this.lifeLineButton.Name = "lifeLineButton";
            this.lifeLineButton.UseVisualStyleBackColor = false;
            // 
            // Rule_box
            // 
            this.Rule_box.Controls.Add(this.textBox1);
            resources.ApplyResources(this.Rule_box, "Rule_box");
            this.Rule_box.ForeColor = System.Drawing.Color.Goldenrod;
            this.Rule_box.Name = "Rule_box";
            this.Rule_box.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Money_box
            // 
            this.Money_box.Controls.Add(this.label10);
            this.Money_box.Controls.Add(this.label11);
            this.Money_box.Controls.Add(this.label12);
            this.Money_box.Controls.Add(this.label13);
            this.Money_box.Controls.Add(this.label14);
            this.Money_box.Controls.Add(this.label5);
            this.Money_box.Controls.Add(this.label6);
            this.Money_box.Controls.Add(this.label7);
            this.Money_box.Controls.Add(this.label8);
            this.Money_box.Controls.Add(this.label9);
            this.Money_box.Controls.Add(this.label4);
            this.Money_box.Controls.Add(this.label3);
            this.Money_box.Controls.Add(this.label2);
            this.Money_box.Controls.Add(this.round_1);
            this.Money_box.Controls.Add(this.label1);
            resources.ApplyResources(this.Money_box, "Money_box");
            this.Money_box.ForeColor = System.Drawing.Color.Goldenrod;
            this.Money_box.Name = "Money_box";
            this.Money_box.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // round_1
            // 
            resources.ApplyResources(this.round_1, "round_1");
            this.round_1.Name = "round_1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.BackColorChanged += new System.EventHandler(this.submit_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.d_block);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.B_block);
            this.groupBox1.Controls.Add(this.A_block);
            this.groupBox1.Controls.Add(this.question_label);
            this.groupBox1.Controls.Add(this.submit_button);
            this.groupBox1.Controls.Add(this.textBox6);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // d_block
            // 
            resources.ApplyResources(this.d_block, "d_block");
            this.d_block.Name = "d_block";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // B_block
            // 
            resources.ApplyResources(this.B_block, "B_block");
            this.B_block.Name = "B_block";
            // 
            // A_block
            // 
            resources.ApplyResources(this.A_block, "A_block");
            this.A_block.Name = "A_block";
            // 
            // question_label
            // 
            resources.ApplyResources(this.question_label, "question_label");
            this.question_label.Name = "question_label";
            // 
            // submit_button
            // 
            resources.ApplyResources(this.submit_button, "submit_button");
            this.submit_button.BackColor = System.Drawing.Color.MidnightBlue;
            this.submit_button.Name = "submit_button";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.safe_amount);
            this.groupBox2.Controls.Add(this.current_winning);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // safe_amount
            // 
            resources.ApplyResources(this.safe_amount, "safe_amount");
            this.safe_amount.Name = "safe_amount";
            // 
            // current_winning
            // 
            resources.ApplyResources(this.current_winning, "current_winning");
            this.current_winning.Name = "current_winning";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // gameboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.blueblack_img;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Money_box);
            this.Controls.Add(this.Rule_box);
            this.Controls.Add(this.Lifelines);
            this.Controls.Add(this.pictureBox1);
            this.Name = "gameboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Lifelines.ResumeLayout(false);
            this.Rule_box.ResumeLayout(false);
            this.Rule_box.PerformLayout();
            this.Money_box.ResumeLayout(false);
            this.Money_box.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Lifelines;
        private System.Windows.Forms.GroupBox Rule_box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox Money_box;
        private System.Windows.Forms.Button giveUpButton;
        private System.Windows.Forms.Button lifeLineButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label round_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.Label safe_amount;
        private System.Windows.Forms.Label current_winning;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label B_block;
        private System.Windows.Forms.Label A_block;
        private System.Windows.Forms.Label d_block;
    }
}

