using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace 吃什么饭
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        string CurDir = "";     //当前程序路径
        string[] eatBreakFast, eatLunch, eatDinner;
        int goTime = 30;
        /// <summary>
        /// 点抽选按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_startcancle_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> eatWhat = new List<string>();
                switch (cbx_eat.SelectedIndex)
                {
                    case 0:
                        //将文本框的内容循环读取，然后随机抽选一个
                        foreach (string foods in Tbx_BreakFast.Lines)
                        {
                            //忽略空白行
                            if (foods.Replace(" ", "") == "")
                            { }
                            else
                            {
                                eatWhat.Add(foods);
                            }
                        }
                        eatBreakFast = eatWhat.ToArray();
                        goTime = 30;
                        tim_choose.Start();
                        break;
                    case 1:
                        //将文本框的内容循环读取，然后随机抽选一个
                        foreach (string foods in Tbx_Lunch.Lines)
                        {
                            //忽略空白行
                            if (foods.Replace(" ", "") == "")
                            { }
                            else
                            {
                                eatWhat.Add(foods);
                            }
                        }
                        eatLunch = eatWhat.ToArray();
                        goTime = 30;
                        tim_choose.Start();
                        break;
                    case 2:
                        //将文本框的内容循环读取，然后随机抽选一个
                        foreach (string foods in Tbx_Dinner.Lines)
                        {
                            //忽略空白行
                            if (foods.Replace(" ", "") == "")
                            { }
                            else
                            {
                                eatWhat.Add(foods);
                            }
                        }
                        eatDinner = eatWhat.ToArray();
                        goTime = 30;
                        tim_choose.Start();
                        break;
                    default: break;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("错误。请检查饭馆管理中该项目下是否有数据。", "提示");
            }
        }

        //随机筛选
        private void ChooseEat(string[] foods)
        {
            int arrayLength = foods.Length;
            Random ranEat = new Random();
            int eatCount = ranEat.Next(arrayLength);
            Lbl_EatFoods.Text = foods[eatCount];
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            cbx_eat.SelectedIndex = 0;
            //获取当前程序路径并判断txt文件是否存在
            CurDir = System.Environment.CurrentDirectory;
            if (File.Exists(CurDir + "\\eat.txt"))
            {

            }
            else
            {
                string EmptyTxtStr = "[早饭]" + Environment.NewLine + "[午饭]" + Environment.NewLine + "[晚饭]" + Environment.NewLine;
                string results = WriteTxt(EmptyTxtStr);
                if(results == "00")
                {
                    MessageBox.Show("存储文件不存在，已重新生成，需要重新维护餐馆后才能使用。", "提示");
                }
                else
                {
                    MessageBox.Show("存储文件不存在，但重新生成失败，程序无法使用，请重试或启用管理员模式重试。", "提示");
                    Application.Exit();
                }
            }
            ConvertToTBox();
        }

        /// <summary>
        /// 写txt文件
        /// </summary>
        /// <param name="TextStr">写入txt的内容</param>
        /// <returns>操作结果:00成功</returns>
        private string WriteTxt(string TextStr)
        {
            try
            {
                FileStream fs = new FileStream(CurDir + "\\eat.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                //开始写入
                sw.Write(TextStr);
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                sw.Dispose();
                fs.Close();
                return "00";
            }
            catch (Exception ee)
            {
                return "01";
            }
        }

        /// <summary>
        /// 读取txt文件
        /// </summary>
        /// <returns></returns>
        private string ReadTxt()
        {
            StreamReader sr = new StreamReader(CurDir + "\\eat.txt", Encoding.UTF8);
            String line, TxtStr = "";
            while ((line = sr.ReadLine()) != null)
            {
                string tempStr = line.ToString().Replace(" ", "");
                if (tempStr.Trim() == "")
                {
                    continue;
                }
                TxtStr += tempStr;
                TxtStr += "}";
            }
            sr.Close();
            sr.Dispose();
            return TxtStr;
        }

        /// <summary>
        /// 将txt内容转到文本框中
        /// </summary>
        private void ConvertToTBox()
        {
            string TxtStr = ReadTxt();
            int eatCount = 0;
            String[] EatItems = TxtStr.Split('}');
            for (int i = 0; i < EatItems.Length; i++)
            {
                if (EatItems[i].Replace(" ", "") == "")
                {
                    continue;
                }
                if (EatItems[i] == "[早饭]")
                {
                    eatCount++;
                    continue;
                }
                else if(EatItems[i] == "[午饭]")
                {
                    eatCount++;
                    continue;
                }
                else if (EatItems[i] == "[晚饭]")
                {
                    eatCount++;
                    continue;
                }
                else
                {
                    switch (eatCount)
                    {
                        case 1: Tbx_BreakFast.Text += EatItems[i]; Tbx_BreakFast.Text += Environment.NewLine; break;
                        case 2: Tbx_Lunch.Text += EatItems[i]; Tbx_Lunch.Text += Environment.NewLine; break;
                        case 3: Tbx_Dinner.Text += EatItems[i]; Tbx_Dinner.Text += Environment.NewLine; break;
                        default: break;
                    }
                }
            }
            if (Tbx_BreakFast.Text.Length > 0)
            {
                Tbx_BreakFast.Text = Tbx_BreakFast.Text.Substring(0, Tbx_BreakFast.Text.Length - 1);
            }
            else if (Tbx_Lunch.Text.Length > 0)
            {
                Tbx_Lunch.Text = Tbx_Lunch.Text.Substring(0, Tbx_Lunch.Text.Length - 1);
            }
            else if (Tbx_Dinner.Text.Length > 0)
            {
                Tbx_Dinner.Text = Tbx_Dinner.Text.Substring(0, Tbx_Dinner.Text.Length - 1);
            }
        }

        /// <summary>
        /// 保存修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //遍历读取三个文本框，去除空白行
            string TxtStr = "[早饭]";
            TxtStr += Environment.NewLine;
            foreach (string foreachStr in Tbx_BreakFast.Lines)
            {
                string tempStr = foreachStr.Replace(" ", "");
                if (tempStr == "")
                { }
                else
                {
                    TxtStr += tempStr;
                    TxtStr += Environment.NewLine;
                }
            }
            TxtStr += "[午饭]";
            TxtStr += Environment.NewLine;
            foreach (string foreachStr in Tbx_Lunch.Lines)
            {
                string tempStr = foreachStr.Replace(" ", "");
                if (tempStr == "")
                { }
                else
                {
                    TxtStr += tempStr;
                    TxtStr += Environment.NewLine;
                }
            }
            TxtStr += "[晚饭]";
            TxtStr += Environment.NewLine;
            foreach (string foreachStr in Tbx_Dinner.Lines)
            {
                string tempStr = foreachStr.Replace(" ", "");
                if (tempStr == "")
                { }
                else
                {
                    TxtStr += tempStr;
                    TxtStr += Environment.NewLine;
                }
            }
            TxtStr = TxtStr.Substring(0, TxtStr.Length - 1);
            string results = WriteTxt(TxtStr);
            if (results == "00")
            {
                MessageBox.Show("修改成功，本次变更已存储。", "提示");
            }
            else
            {
                MessageBox.Show("修改文件失败，可以进行抽选，但是关闭程序后将恢复到本次修改之前的数据。", "提示");
            }
        }

        private void tim_choose_Tick(object sender, EventArgs e)
        {
            
            switch (cbx_eat.SelectedIndex)
            {
                case 0:
                    ChooseEat(eatBreakFast);
                    break;
                case 1:
                    ChooseEat(eatLunch);
                    break;
                case 2:
                    ChooseEat(eatDinner);
                    break;
                default: break;
            }

            //倒数3秒
            goTime--;
            if (goTime == 1)
            {
                tim_choose.Stop();
            }
        }
    }
}
