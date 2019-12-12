using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LuckyStar
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        //设置全局计数器
        public static int count = 0;
        public static int peopleNum = 0;
        public static List<string> peopleList = new List<string>();
        //将父窗口的setshowlbl控制值的设置暴漏出去
        //private string mediumVar = "";
        //public string Setshowlbl
        //{
        //    get
        //    {
        //        return mediumVar;
        //    }
        //    set
        //    {
        //        mediumVar = value;

        //        this.setshowlbl.Text = mediumVar;
        //    }
        //}
        //委托事件函数
        public void UpdateParrentSetshow(string content)
        {

            setshowlbl.Text = content;
        }
        private string setFile = "";
        public string peopleFile = "";
        private void SetConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetConfig f = new FormSetConfig(this)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            //f.ConfigChange_even += new SetCongigDialog.ConfigChange(UpdateConfig);

            //使用委托事件
            f.UpdateParrentSetshow+= this.UpdateParrentSetshow;
            f.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者：【业余开发者】wxx", "关于");
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("当前软件暂不支持在线自动更新!", "更新");
        }

        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lucky Star Version 1.0 2019/12/12", "版本信息");
        }

        private void TipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bug和意见反馈请发送至邮箱:\t\n\n\txxxxx\n\n\t谢谢！\t", "意见反馈");
        }

        public void loadPeopleList()
        {
            string filename = PeopleFiletextBox.Text.Trim();
            List <string> peopleList = new List<string>();
            if (!File.Exists(filename)) 
            {
                MessageBox.Show("文件不存在：" + filename, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                return;
            }
            Form1.peopleList.Clear();
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                line = sr.ReadLine();
                while (null != line)
                {
                    line = line.Trim();
                    if (line != "")
                    {
                        peopleList.Add(line);
                        Form1.peopleNum++;
                        Form1.peopleList.Add(line);
                       
                    }
                    line = sr.ReadLine();

                }
            }
            listView1.Items.Clear();//清空列表，重新根据新的文件添加人员清单
            listView1.BeginUpdate();
            int i = 1;
            foreach (string username in peopleList)
            {
                //创建一个item
                ListViewItem line = new ListViewItem();
                line.Text = i.ToString();
                //line.SubItems.Add();
                line.SubItems.Add(username);
                listView1.Items.Add(line);
                i++;
            }
            listView1.EndUpdate();
            Form1.count = 0;

        }

        //打开文件对话框，并选择txt 的人员清大
        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            openPeopleFileDialog1.Title = "请选择 人员清单 文件";
            openPeopleFileDialog1.Filter = "TXT文件(*.txt;*.TXT)|*.txt;*.TXT";
            DialogResult dr = openPeopleFileDialog1.ShowDialog();
            
            
            if (dr== System.Windows.Forms.DialogResult.OK)
            {
                this.peopleFile = openPeopleFileDialog1.FileName;
                PeopleFiletextBox.Text = this.peopleFile;
            }
            this.loadPeopleList();



        }
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
            if (File.Exists(this.setFile))
            {
                
                using (StreamReader sr = new StreamReader(this.setFile))
                {
                    setshowlbl.Text = sr.ReadToEnd();
                }
                if (setshowlbl.Text.Trim() == "")
                {
                    setshowlbl.Text = "暂无配置随机数据集";
                }


            }
            else
            {
                setshowlbl.Text = "暂无配置随机数据集";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //数据集初始化
            this.iniData( sender,  e);
        }

        //获取单个随机值
        private List <string> getRandomResult(string setStr,int num)
        {
            List<string> setList = new List<string>();
            List<string> randomList = new List<string>();
            foreach (string s in setStr.Split(','))
            {
                if(s.Trim()!="")
                {
                    setList.Add(s);
                }
            }
            int setLength = setList.ToArray().Length;
            Random rd = new Random();
            for (int i=0;i<num; i++)
            {
                int n=rd.Next(0, setLength);
                randomList.Add(setList[n]);

            }
            return randomList;
        }
        private void singleBtn_Click(object sender, EventArgs e)
        {
            string setStr = setshowlbl.Text;
            List<string> randomLst = new List<string>();
            List<string> randompeople = new List<string>();
            string people = "";
            if (setStr == "暂无配置随机数据集")
            {
                MessageBox.Show("暂无数据集集，请先设置随机数据集！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

          
            if(peopleNum==0)
            {
                // MessageBox.Show("请选择随机名单文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                randResultlbl.Text = "暂无人员可抽！";
                return;
            }
            if(Form1.peopleNum>0)
            {
                //listView1.Items[Form1.count].SubItems.Add(randomLst[0]);
                //Form1.count++;
                randomLst = getRandomResult(setStr, 1);
                randompeople = getRandomResult(string.Join(",", Form1.peopleList.ToArray()), 1);
                Form1.peopleNum--;
                //MessageBox.Show(Form1.peopleNum.ToString());
                //randResultlbl.Text = randomLst[0];
                randResultlbl.Text =randompeople[0]+":"+randomLst[0];
                
                Form1.peopleList.Remove(randompeople[0]);

            }
            else
            {
                //MessageBox.Show("本次产生的随机值："+randomLst[0], "随机值", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //randResultlbl.Text = randomLst[0];
                randResultlbl.Text = "所有人员已经抽取完毕！";
            }
            




        }
        /*
        private void singleBtn_Click(object sender, EventArgs e)
        {
            string setStr = setshowlbl.Text;
            List<string> randomLst = new List<string>();
            if (setStr == "暂无配置随机数据集")
            {
                MessageBox.Show("暂无数据集集，请先设置随机数据集！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            randomLst = getRandomResult(setStr, 1);

            // 获取所有人数
            int peopleNum = listView1.Items.Count;

            if (peopleNum == 0)
            {
                MessageBox.Show("请选择随机名单文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Form1.count < peopleNum)
            {
                //listView1.Items[Form1.count].SubItems.Add(randomLst[0]);
                Form1.count++;
                //randResultlbl.Text = randomLst[0];
                randResultlbl.Text = randomLst[0];

            }
            else
            {
                //MessageBox.Show("本次产生的随机值："+randomLst[0], "随机值", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //randResultlbl.Text = randomLst[0];
                randResultlbl.Text = "所有人员已经抽取完毕！";
            }





        }
        */
        private void allbtn_Click(object sender, EventArgs e)
        {
            string setStr = setshowlbl.Text;
            List<string> randomLst = new List<string>();
            if (setStr == "暂无配置随机数据集")
            {
                MessageBox.Show("暂无数据集集，请先设置随机数据集！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int peopleNum = listView1.Items.Count;
            randomLst = getRandomResult(setStr,peopleNum );
            foreach (var item in randomLst)
            {
                if(Form1.count<peopleNum)
                {
                    listView1.Items[Form1.count].SubItems.Add(item);
                    Form1.count++;
                }
                
            }

        }
        //将随机产生的结果导出
        private void reportBtn_Click(object sender, EventArgs e)
        {
            //获取listview 结果，
            StringBuilder content=new StringBuilder( "序号,姓名,随机值结果,\n");
            foreach(ListViewItem item in listView1.Items)
            {
                for(int i=0;i<item.SubItems.Count;i++)
                {
                    content.Append(item.SubItems[i].Text + ",");
                }
                content.Append( "\n");
            }
            reporeFileDlg.Title="结果导出";
            reporeFileDlg.DefaultExt=
            reporeFileDlg.Filter = "CSV（*.csv）|*.csv|TXT(*.txt)|*.txt";
            reporeFileDlg.RestoreDirectory = true;//记录上次保存的位置
            reporeFileDlg.FilterIndex = 1;
            reporeFileDlg.FileName = "report_"+DateTime.Now.ToString("yyyy年MM月dd日-hhmmss");
            DialogResult ret= reporeFileDlg.ShowDialog();
            string filename = reporeFileDlg.FileName;
            if (ret == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                
                StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8);
                sw.Write(content.ToString());
                sw.Close();
                reportPathlbl.Text = "导出路径：" + filename;
            }



        }
    }
}
