namespace StarCreate
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.LB_creatresult = new System.Windows.Forms.Label();
            this.BT_Retry = new System.Windows.Forms.Button();
            this.LB_T = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_creatresult
            // 
            this.LB_creatresult.AutoSize = true;
            this.LB_creatresult.BackColor = System.Drawing.Color.Transparent;
            this.LB_creatresult.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_creatresult.Location = new System.Drawing.Point(106, 313);
            this.LB_creatresult.Name = "LB_creatresult";
            this.LB_creatresult.Size = new System.Drawing.Size(99, 53);
            this.LB_creatresult.TabIndex = 0;
            this.LB_creatresult.Text = "None";
            // 
            // BT_Retry
            // 
            this.BT_Retry.BackColor = System.Drawing.Color.Transparent;
            this.BT_Retry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Retry.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BT_Retry.Location = new System.Drawing.Point(281, 551);
            this.BT_Retry.Name = "BT_Retry";
            this.BT_Retry.Size = new System.Drawing.Size(144, 46);
            this.BT_Retry.TabIndex = 1;
            this.BT_Retry.Text = "Close";
            this.BT_Retry.UseVisualStyleBackColor = false;
            this.BT_Retry.Click += new System.EventHandler(this.button1_Click);
            // 
            // LB_T
            // 
            this.LB_T.AutoSize = true;
            this.LB_T.BackColor = System.Drawing.Color.Transparent;
            this.LB_T.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_T.ForeColor = System.Drawing.Color.White;
            this.LB_T.Location = new System.Drawing.Point(105, 253);
            this.LB_T.Name = "LB_T";
            this.LB_T.Size = new System.Drawing.Size(109, 58);
            this.LB_T.TabIndex = 2;
            this.LB_T.Text = "None";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 739);
            this.Controls.Add(this.LB_T);
            this.Controls.Add(this.BT_Retry);
            this.Controls.Add(this.LB_creatresult);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_creatresult;
        private System.Windows.Forms.Button BT_Retry;
        private System.Windows.Forms.Label LB_T;
    }
}