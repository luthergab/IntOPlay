namespace IntOPlayG
{
    partial class GameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.exitBtn = new System.Windows.Forms.Button();
            this.divisionBtn = new System.Windows.Forms.Button();
            this.multiplicationBtn = new System.Windows.Forms.Button();
            this.subtractionBtn = new System.Windows.Forms.Button();
            this.additionBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Gold;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Arcadepix Plus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(159, 370);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(222, 23);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // divisionBtn
            // 
            this.divisionBtn.BackColor = System.Drawing.Color.Gold;
            this.divisionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divisionBtn.Font = new System.Drawing.Font("Arcadepix Plus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionBtn.Location = new System.Drawing.Point(159, 340);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(222, 23);
            this.divisionBtn.TabIndex = 14;
            this.divisionBtn.Text = "DIVISION";
            this.divisionBtn.UseVisualStyleBackColor = false;
            this.divisionBtn.Click += new System.EventHandler(this.divisionBtn_Click);
            // 
            // multiplicationBtn
            // 
            this.multiplicationBtn.BackColor = System.Drawing.Color.Gold;
            this.multiplicationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplicationBtn.Font = new System.Drawing.Font("Arcadepix Plus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationBtn.Location = new System.Drawing.Point(159, 311);
            this.multiplicationBtn.Name = "multiplicationBtn";
            this.multiplicationBtn.Size = new System.Drawing.Size(222, 23);
            this.multiplicationBtn.TabIndex = 13;
            this.multiplicationBtn.Text = "MULTIPLICATION";
            this.multiplicationBtn.UseVisualStyleBackColor = false;
            this.multiplicationBtn.Click += new System.EventHandler(this.multiplicationBtn_Click);
            // 
            // subtractionBtn
            // 
            this.subtractionBtn.BackColor = System.Drawing.Color.Gold;
            this.subtractionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtractionBtn.Font = new System.Drawing.Font("Arcadepix Plus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractionBtn.Location = new System.Drawing.Point(159, 282);
            this.subtractionBtn.Name = "subtractionBtn";
            this.subtractionBtn.Size = new System.Drawing.Size(222, 23);
            this.subtractionBtn.TabIndex = 12;
            this.subtractionBtn.Text = "SUBTRACTION";
            this.subtractionBtn.UseVisualStyleBackColor = false;
            this.subtractionBtn.Click += new System.EventHandler(this.subtractionBtn_Click);
            // 
            // additionBtn
            // 
            this.additionBtn.BackColor = System.Drawing.Color.Gold;
            this.additionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.additionBtn.Font = new System.Drawing.Font("Arcadepix Plus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionBtn.Location = new System.Drawing.Point(159, 254);
            this.additionBtn.Name = "additionBtn";
            this.additionBtn.Size = new System.Drawing.Size(222, 23);
            this.additionBtn.TabIndex = 11;
            this.additionBtn.Text = "ADDITION ";
            this.additionBtn.UseVisualStyleBackColor = false;
            this.additionBtn.Click += new System.EventHandler(this.additionBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(45, 27);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 15;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Font = new System.Drawing.Font("Arcadepix Plus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "SELECT MODE";
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.divisionBtn);
            this.Controls.Add(this.multiplicationBtn);
            this.Controls.Add(this.subtractionBtn);
            this.Controls.Add(this.additionBtn);
            this.DoubleBuffered = true;
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.Button divisionBtn;
        private System.Windows.Forms.Button multiplicationBtn;
        private System.Windows.Forms.Button subtractionBtn;
        private System.Windows.Forms.Button additionBtn;
        private System.Windows.Forms.Label label2;
    }
}