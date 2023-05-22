namespace IntOPlayG
{
    partial class AdditionQuestions
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
            this.num1Txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num2Txt = new System.Windows.Forms.Label();
            this.sumAnsTxt = new System.Windows.Forms.TextBox();
            this.addSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // num1Txt
            // 
            this.num1Txt.AutoSize = true;
            this.num1Txt.Font = new System.Drawing.Font("Arcadepix Plus", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1Txt.Location = new System.Drawing.Point(121, 135);
            this.num1Txt.Name = "num1Txt";
            this.num1Txt.Size = new System.Drawing.Size(94, 50);
            this.num1Txt.TabIndex = 0;
            this.num1Txt.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arcadepix Plus", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "+";
            // 
            // num2Txt
            // 
            this.num2Txt.AutoSize = true;
            this.num2Txt.Font = new System.Drawing.Font("Arcadepix Plus", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2Txt.Location = new System.Drawing.Point(325, 135);
            this.num2Txt.Name = "num2Txt";
            this.num2Txt.Size = new System.Drawing.Size(94, 50);
            this.num2Txt.TabIndex = 2;
            this.num2Txt.Text = "00";
            // 
            // sumAnsTxt
            // 
            this.sumAnsTxt.Font = new System.Drawing.Font("Arcadepix Plus", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumAnsTxt.Location = new System.Drawing.Point(221, 244);
            this.sumAnsTxt.Name = "sumAnsTxt";
            this.sumAnsTxt.Size = new System.Drawing.Size(100, 47);
            this.sumAnsTxt.TabIndex = 3;
            this.sumAnsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sumAnsTxt.TextChanged += new System.EventHandler(this.sumAnsTxt_TextChanged);
            // 
            // addSubmit
            // 
            this.addSubmit.BackColor = System.Drawing.Color.Gold;
            this.addSubmit.Font = new System.Drawing.Font("Arcadepix Plus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSubmit.Location = new System.Drawing.Point(229, 307);
            this.addSubmit.Name = "addSubmit";
            this.addSubmit.Size = new System.Drawing.Size(87, 36);
            this.addSubmit.TabIndex = 4;
            this.addSubmit.Text = "ENTER";
            this.addSubmit.UseVisualStyleBackColor = false;
            this.addSubmit.Click += new System.EventHandler(this.addSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::IntOPlayG.Properties.Resources.keyboard_backspace;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdditionQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IntOPlayG.Properties.Resources.vecteezy_doodle_math_objects_border_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addSubmit);
            this.Controls.Add(this.sumAnsTxt);
            this.Controls.Add(this.num2Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num1Txt);
            this.Name = "AdditionQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdditionQuestions";
            this.Load += new System.EventHandler(this.AdditionQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label num2Txt;
        private System.Windows.Forms.TextBox sumAnsTxt;
        private System.Windows.Forms.Button addSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}