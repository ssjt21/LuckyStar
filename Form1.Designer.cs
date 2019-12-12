namespace LuckyStar
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.PeopleFiletextBox = new System.Windows.Forms.TextBox();
            this.SelectFileBtn = new System.Windows.Forms.Button();
            this.openPeopleFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RESULT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.setshowlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.singleBtn = new System.Windows.Forms.Button();
            this.allbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.randResultlbl = new System.Windows.Forms.Label();
            this.reportBtn = new System.Windows.Forms.Button();
            this.reporeFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.reportPathlbl = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(949, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ConfigToolStripMenuItem
            // 
            this.ConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetConfigToolStripMenuItem});
            this.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem";
            this.ConfigToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.ConfigToolStripMenuItem.Text = "设置";
            // 
            // SetConfigToolStripMenuItem
            // 
            this.SetConfigToolStripMenuItem.Name = "SetConfigToolStripMenuItem";
            this.SetConfigToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.SetConfigToolStripMenuItem.Text = "随机集合配置";
            this.SetConfigToolStripMenuItem.Click += new System.EventHandler(this.SetConfigToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.VersionToolStripMenuItem,
            this.TipsToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.HelpToolStripMenuItem.Text = "帮助";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.AboutToolStripMenuItem.Text = "关于";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.UpdateToolStripMenuItem.Text = "更新";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // VersionToolStripMenuItem
            // 
            this.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem";
            this.VersionToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.VersionToolStripMenuItem.Text = "版本";
            this.VersionToolStripMenuItem.Click += new System.EventHandler(this.VersionToolStripMenuItem_Click);
            // 
            // TipsToolStripMenuItem
            // 
            this.TipsToolStripMenuItem.Name = "TipsToolStripMenuItem";
            this.TipsToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.TipsToolStripMenuItem.Text = "意见反馈";
            this.TipsToolStripMenuItem.Click += new System.EventHandler(this.TipsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择人员清单文件：";
            // 
            // PeopleFiletextBox
            // 
            this.PeopleFiletextBox.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleFiletextBox.Location = new System.Drawing.Point(219, 31);
            this.PeopleFiletextBox.Name = "PeopleFiletextBox";
            this.PeopleFiletextBox.Size = new System.Drawing.Size(579, 28);
            this.PeopleFiletextBox.TabIndex = 2;
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFileBtn.Location = new System.Drawing.Point(810, 30);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(127, 31);
            this.SelectFileBtn.TabIndex = 3;
            this.SelectFileBtn.Text = "...选择";
            this.SelectFileBtn.UseVisualStyleBackColor = true;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // openPeopleFileDialog1
            // 
            this.openPeopleFileDialog1.FileName = "openFileDialog";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NAME,
            this.RESULT});
            this.listView1.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 585);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "#";
            // 
            // NAME
            // 
            this.NAME.Text = "姓名";
            this.NAME.Width = 130;
            // 
            // RESULT
            // 
            this.RESULT.Text = "随机结果值";
            this.RESULT.Width = 200;
            // 
            // setshowlbl
            // 
            this.setshowlbl.AutoEllipsis = true;
            this.setshowlbl.BackColor = System.Drawing.Color.White;
            this.setshowlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setshowlbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setshowlbl.Location = new System.Drawing.Point(544, 121);
            this.setshowlbl.Name = "setshowlbl";
            this.setshowlbl.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.setshowlbl.Size = new System.Drawing.Size(393, 100);
            this.setshowlbl.TabIndex = 5;
            this.setshowlbl.Text = "暂无配置随机数据集";
            this.setshowlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "当前随机数据集：";
            // 
            // singleBtn
            // 
            this.singleBtn.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleBtn.Location = new System.Drawing.Point(541, 78);
            this.singleBtn.Name = "singleBtn";
            this.singleBtn.Size = new System.Drawing.Size(182, 32);
            this.singleBtn.TabIndex = 7;
            this.singleBtn.Text = "获取单个随机值";
            this.singleBtn.UseVisualStyleBackColor = true;
            this.singleBtn.Click += new System.EventHandler(this.singleBtn_Click);
            // 
            // allbtn
            // 
            this.allbtn.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allbtn.Location = new System.Drawing.Point(744, 78);
            this.allbtn.Name = "allbtn";
            this.allbtn.Size = new System.Drawing.Size(185, 32);
            this.allbtn.TabIndex = 7;
            this.allbtn.Text = "获取所有随机值";
            this.allbtn.UseVisualStyleBackColor = true;
            this.allbtn.Click += new System.EventHandler(this.allbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(342, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "随机值结果：";
            // 
            // randResultlbl
            // 
            this.randResultlbl.AutoEllipsis = true;
            this.randResultlbl.BackColor = System.Drawing.Color.White;
            this.randResultlbl.Font = new System.Drawing.Font("Courier New", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randResultlbl.ForeColor = System.Drawing.Color.Red;
            this.randResultlbl.Location = new System.Drawing.Point(346, 230);
            this.randResultlbl.Name = "randResultlbl";
            this.randResultlbl.Size = new System.Drawing.Size(583, 260);
            this.randResultlbl.TabIndex = 9;
            this.randResultlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportBtn
            // 
            this.reportBtn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.Location = new System.Drawing.Point(612, 506);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(253, 41);
            this.reportBtn.TabIndex = 10;
            this.reportBtn.Text = "结果导出CSV";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // reportPathlbl
            // 
            this.reportPathlbl.AutoEllipsis = true;
            this.reportPathlbl.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportPathlbl.Location = new System.Drawing.Point(541, 552);
            this.reportPathlbl.Name = "reportPathlbl";
            this.reportPathlbl.Size = new System.Drawing.Size(388, 83);
            this.reportPathlbl.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 662);
            this.Controls.Add(this.reportPathlbl);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.randResultlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allbtn);
            this.Controls.Add(this.singleBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setshowlbl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SelectFileBtn);
            this.Controls.Add(this.PeopleFiletextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Lucky Star  by Topsec";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TipsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PeopleFiletextBox;
        private System.Windows.Forms.Button SelectFileBtn;
        private System.Windows.Forms.OpenFileDialog openPeopleFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader RESULT;
        private System.Windows.Forms.Label setshowlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button singleBtn;
        private System.Windows.Forms.Button allbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label randResultlbl;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.SaveFileDialog reporeFileDlg;
        private System.Windows.Forms.Label reportPathlbl;
    }
}

