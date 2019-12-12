namespace LuckyStar
{
    partial class FormSetConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetConfig));
            this.lblconfigSet = new System.Windows.Forms.Label();
            this.SetrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.updateSetBtn = new System.Windows.Forms.Button();
            this.setSetnullBtn = new System.Windows.Forms.Button();
            this.NumcheckBox = new System.Windows.Forms.CheckBox();
            this.UpperCasecheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblconfigSet
            // 
            this.lblconfigSet.AutoSize = true;
            this.lblconfigSet.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfigSet.Location = new System.Drawing.Point(0, 9);
            this.lblconfigSet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconfigSet.Name = "lblconfigSet";
            this.lblconfigSet.Size = new System.Drawing.Size(186, 21);
            this.lblconfigSet.TabIndex = 0;
            this.lblconfigSet.Text = "随机集合值设置：";
            // 
            // SetrichTextBox1
            // 
            this.SetrichTextBox1.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetrichTextBox1.Location = new System.Drawing.Point(13, 38);
            this.SetrichTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.SetrichTextBox1.Name = "SetrichTextBox1";
            this.SetrichTextBox1.Size = new System.Drawing.Size(599, 201);
            this.SetrichTextBox1.TabIndex = 1;
            this.SetrichTextBox1.Text = "";
            // 
            // updateSetBtn
            // 
            this.updateSetBtn.Location = new System.Drawing.Point(349, 284);
            this.updateSetBtn.Name = "updateSetBtn";
            this.updateSetBtn.Size = new System.Drawing.Size(179, 35);
            this.updateSetBtn.TabIndex = 5;
            this.updateSetBtn.Text = "确   定";
            this.updateSetBtn.UseVisualStyleBackColor = true;
            this.updateSetBtn.Click += new System.EventHandler(this.updateSetBtn_Click);
            // 
            // setSetnullBtn
            // 
            this.setSetnullBtn.Location = new System.Drawing.Point(114, 284);
            this.setSetnullBtn.Name = "setSetnullBtn";
            this.setSetnullBtn.Size = new System.Drawing.Size(179, 35);
            this.setSetnullBtn.TabIndex = 5;
            this.setSetnullBtn.Text = "清  空";
            this.setSetnullBtn.UseVisualStyleBackColor = true;
            this.setSetnullBtn.Click += new System.EventHandler(this.setSetnullBtn_Click);
            // 
            // NumcheckBox
            // 
            this.NumcheckBox.AutoSize = true;
            this.NumcheckBox.Location = new System.Drawing.Point(170, 246);
            this.NumcheckBox.Name = "NumcheckBox";
            this.NumcheckBox.Size = new System.Drawing.Size(65, 25);
            this.NumcheckBox.TabIndex = 6;
            this.NumcheckBox.Text = "0-9";
            this.NumcheckBox.UseVisualStyleBackColor = true;
            this.NumcheckBox.CheckedChanged += new System.EventHandler(this.NumcheckBox_CheckedChanged);
            // 
            // UpperCasecheckBox
            // 
            this.UpperCasecheckBox.AutoSize = true;
            this.UpperCasecheckBox.Location = new System.Drawing.Point(400, 246);
            this.UpperCasecheckBox.Name = "UpperCasecheckBox";
            this.UpperCasecheckBox.Size = new System.Drawing.Size(65, 25);
            this.UpperCasecheckBox.TabIndex = 6;
            this.UpperCasecheckBox.Text = "A-Z";
            this.UpperCasecheckBox.UseVisualStyleBackColor = true;
            this.UpperCasecheckBox.CheckedChanged += new System.EventHandler(this.UpperCasecheckBox_CheckedChanged);
            // 
            // FormSetConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 330);
            this.Controls.Add(this.UpperCasecheckBox);
            this.Controls.Add(this.NumcheckBox);
            this.Controls.Add(this.setSetnullBtn);
            this.Controls.Add(this.updateSetBtn);
            this.Controls.Add(this.SetrichTextBox1);
            this.Controls.Add(this.lblconfigSet);
            this.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSetConfig";
            this.Text = "随机值集合设置";
            this.Load += new System.EventHandler(this.FormSetConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconfigSet;
        private System.Windows.Forms.RichTextBox SetrichTextBox1;
        private System.Windows.Forms.Button updateSetBtn;
        private System.Windows.Forms.Button setSetnullBtn;
        private System.Windows.Forms.CheckBox NumcheckBox;
        private System.Windows.Forms.CheckBox UpperCasecheckBox;
    }
}