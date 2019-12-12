using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyStar
{
    public partial class FormSetConfig : Form
    {
        
        
        public FormSetConfig(Form1 form1)
        {
            //修改值
            //form1 = form1;
            InitializeComponent();

        }
        //使用委托来修改父窗口setshowlbl的值
        //定义一个委托名称
        public delegate void UpdateParrentSetshowDelegate(string content);
        //声明委托事件
        public event UpdateParrentSetshowDelegate UpdateParrentSetshow;

        public string setFile;
        public void iniData(object sender, EventArgs e)
        {
            //获系统取临时目录System.Environment.GetEnvironmentVariable("TEMP");
            string temp = System.Environment.GetEnvironmentVariable("TEMP");
            temp = temp + @"\LuckyStarTMPdata";
            if (!Directory.Exists(temp))
            {
                Directory.CreateDirectory(temp);
            }
            this.setFile = Path.Combine(temp, "set.conf");
            //MessageBox.Show(this.setFile);
            if(File.Exists(this.setFile))
            {
                SetrichTextBox1.LoadFile(this.setFile, RichTextBoxStreamType.PlainText);
                using (StreamReader sr = new StreamReader(this.setFile))
                {
                    if (UpdateParrentSetshow != null)
                    {
                        if (sr.ReadToEnd().Trim() == "")
                        {
                            UpdateParrentSetshow("暂无配置随机数据集");
                            return;
                        }
                        UpdateParrentSetshow(sr.ReadToEnd());
                    }

                }
                
      
            }
        }
        private string GetSetContent()
        {
            using (StreamReader sr = new StreamReader(this.setFile))
            {
                return sr.ReadToEnd();
            }
        }
        private void FormSetConfig_Load(object sender, EventArgs e)
        {
            this.iniData(sender,e);
        }

        //生成0-9数字
        public List<string> GetNums()
        {
            List<string> nums = new List<string>();
            for(int i=0;i<10;i++)
            {
                nums.Add(i.ToString());
            }
            return nums;
        }
        //生成大写字母
        public List<string> GetLetters()
        {
            List<string> letters = new List<string>();
            for (int i = 65; i < 65+26; i++)
            {
                letters.Add(((char)i).ToString());
            }
            return letters;
        }
        private void NumcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string content = SetrichTextBox1.Text;
            content = content.Trim();//去除多余空格
                                     //查看最后一个字符是否是逗号
            content = content.Replace("，", ",");//将中文标点替换成英文标点
            if (content.Length == 1 && content.Substring(content.Length - 1, 1) == ",")
            {
                content = "";
            }
            else if (content.Length > 1 && content.Substring(content.Length - 1, 1) != ",")
            {
                content = content + ",";
            }
            if (NumcheckBox.Checked)
            {
                content += string.Join(",", this.GetNums().ToArray());
                SetrichTextBox1.Text = content;
            }
            else
            {
                content = content.Replace(",0,1,2,3,4,5,6,7,8,9,", "");
                content = content.Replace("0,1,2,3,4,5,6,7,8,9,", "");
                content= content.Replace("0,1,2,3,4,5,6,7,8,9","" );
                SetrichTextBox1.Text = content;
             
            }
            
        }

        private void setSetnullBtn_Click(object sender, EventArgs e)
        {
            SetrichTextBox1.Text = "";
        }

        private void UpperCasecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string content = SetrichTextBox1.Text;
            content = content.Trim();//去除多余空格
                                     //查看最后一个字符是否是逗号
            content = content.Replace("，", ",");//将中文标点替换成英文标点
            string letters = string.Join(",", this.GetLetters().ToArray());
            if (content.Length == 1 && content.Substring(content.Length - 1, 1) == ",")
            {
                content = "";
            }
            else if (content.Length > 1 && content.Substring(content.Length - 1, 1) != ",")
            {
                content = content + ",";
            }
            if (UpperCasecheckBox.Checked)
            {
                content += letters;
                SetrichTextBox1.Text = content;
            }
            else
            {
                content = content.Replace(","+letters+",", "");
                content = content.Replace(letters + ",", "");
                content = content.Replace(letters, "");
                SetrichTextBox1.Text = content;

            }

        }

        private void updateSetBtn_Click(object sender, EventArgs e)
        {
           
            using (StreamWriter sw = new StreamWriter(this.setFile))
            {
                sw.Write(SetrichTextBox1.Text);
                //同步更新父窗口中的数据
                //this.form1.Setshowlbl = SetrichTextBox1.Text;
                if(SetrichTextBox1.Text.Trim()=="")
                {
                    
                        UpdateParrentSetshow("暂无配置随机数据集");
                }
                if (UpdateParrentSetshow != null)
                {
                    UpdateParrentSetshow(SetrichTextBox1.Text);
                }
            }

            DialogResult ret = MessageBox.Show("随机数据集合已更新！ 配置窗口将关闭?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if(ret==DialogResult.OK)
            {
                this.Close();
            }
            //MessageBox.Show(temp);
        }

       
    }
}
