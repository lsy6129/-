namespace 吃什么饭
{
    partial class Frm_Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_startcancle = new System.Windows.Forms.Button();
            this.cbx_eat = new System.Windows.Forms.ComboBox();
            this.Tbc_Main = new System.Windows.Forms.TabControl();
            this.Tbp_EatWhat = new System.Windows.Forms.TabPage();
            this.Lbl_EatFoods = new System.Windows.Forms.Label();
            this.Tbp_Manager = new System.Windows.Forms.TabPage();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_Dinner = new System.Windows.Forms.TextBox();
            this.Tbx_Lunch = new System.Windows.Forms.TextBox();
            this.Tbx_BreakFast = new System.Windows.Forms.TextBox();
            this.Tbc_Main.SuspendLayout();
            this.Tbp_EatWhat.SuspendLayout();
            this.Tbp_Manager.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("微软雅黑 Light", 10F);
            this.lbl_title.Location = new System.Drawing.Point(7, 8);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(110, 31);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "吃什么饭";
            // 
            // btn_startcancle
            // 
            this.btn_startcancle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_startcancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startcancle.Font = new System.Drawing.Font("微软雅黑 Light", 13F);
            this.btn_startcancle.Location = new System.Drawing.Point(386, 528);
            this.btn_startcancle.Margin = new System.Windows.Forms.Padding(7);
            this.btn_startcancle.Name = "btn_startcancle";
            this.btn_startcancle.Size = new System.Drawing.Size(193, 66);
            this.btn_startcancle.TabIndex = 2;
            this.btn_startcancle.Text = "开始抽取";
            this.btn_startcancle.UseVisualStyleBackColor = true;
            this.btn_startcancle.Click += new System.EventHandler(this.btn_startcancle_Click);
            // 
            // cbx_eat
            // 
            this.cbx_eat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_eat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_eat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_eat.Font = new System.Drawing.Font("微软雅黑 Light", 12F);
            this.cbx_eat.FormattingEnabled = true;
            this.cbx_eat.Items.AddRange(new object[] {
            "早饭",
            "午饭",
            "晚饭"});
            this.cbx_eat.Location = new System.Drawing.Point(730, 0);
            this.cbx_eat.Margin = new System.Windows.Forms.Padding(7);
            this.cbx_eat.Name = "cbx_eat";
            this.cbx_eat.Size = new System.Drawing.Size(234, 44);
            this.cbx_eat.TabIndex = 4;
            // 
            // Tbc_Main
            // 
            this.Tbc_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbc_Main.Controls.Add(this.Tbp_EatWhat);
            this.Tbc_Main.Controls.Add(this.Tbp_Manager);
            this.Tbc_Main.Location = new System.Drawing.Point(3, 2);
            this.Tbc_Main.Name = "Tbc_Main";
            this.Tbc_Main.SelectedIndex = 0;
            this.Tbc_Main.Size = new System.Drawing.Size(972, 635);
            this.Tbc_Main.TabIndex = 5;
            // 
            // Tbp_EatWhat
            // 
            this.Tbp_EatWhat.BackColor = System.Drawing.SystemColors.Control;
            this.Tbp_EatWhat.Controls.Add(this.Lbl_EatFoods);
            this.Tbp_EatWhat.Controls.Add(this.lbl_title);
            this.Tbp_EatWhat.Controls.Add(this.btn_startcancle);
            this.Tbp_EatWhat.Controls.Add(this.cbx_eat);
            this.Tbp_EatWhat.Location = new System.Drawing.Point(4, 37);
            this.Tbp_EatWhat.Name = "Tbp_EatWhat";
            this.Tbp_EatWhat.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_EatWhat.Size = new System.Drawing.Size(964, 594);
            this.Tbp_EatWhat.TabIndex = 0;
            this.Tbp_EatWhat.Text = "抽选吃饭";
            // 
            // Lbl_EatFoods
            // 
            this.Lbl_EatFoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_EatFoods.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_EatFoods.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_EatFoods.ForeColor = System.Drawing.Color.OrangeRed;
            this.Lbl_EatFoods.Location = new System.Drawing.Point(6, 195);
            this.Lbl_EatFoods.Name = "Lbl_EatFoods";
            this.Lbl_EatFoods.Size = new System.Drawing.Size(953, 157);
            this.Lbl_EatFoods.TabIndex = 5;
            this.Lbl_EatFoods.Text = "请抽选";
            this.Lbl_EatFoods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tbp_Manager
            // 
            this.Tbp_Manager.BackColor = System.Drawing.SystemColors.Control;
            this.Tbp_Manager.Controls.Add(this.Btn_Save);
            this.Tbp_Manager.Controls.Add(this.label3);
            this.Tbp_Manager.Controls.Add(this.label2);
            this.Tbp_Manager.Controls.Add(this.label4);
            this.Tbp_Manager.Controls.Add(this.label1);
            this.Tbp_Manager.Controls.Add(this.Tbx_Dinner);
            this.Tbp_Manager.Controls.Add(this.Tbx_Lunch);
            this.Tbp_Manager.Controls.Add(this.Tbx_BreakFast);
            this.Tbp_Manager.Location = new System.Drawing.Point(4, 37);
            this.Tbp_Manager.Name = "Tbp_Manager";
            this.Tbp_Manager.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Manager.Size = new System.Drawing.Size(964, 594);
            this.Tbp_Manager.TabIndex = 1;
            this.Tbp_Manager.Text = "饭馆管理";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(835, 544);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(122, 41);
            this.Btn_Save.TabIndex = 2;
            this.Btn_Save.Text = "保存";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "晚饭";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "午饭";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(1, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(556, 84);
            this.label4.TabIndex = 1;
            this.label4.Text = "提示：1.维护完成后请先保存，确保没问题后再进行抽选；\r\n　　　2.每行输入一条；\r\n　　　3.文本中任何位置的空格将被忽略";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "早饭";
            // 
            // Tbx_Dinner
            // 
            this.Tbx_Dinner.Location = new System.Drawing.Point(647, 34);
            this.Tbx_Dinner.Multiline = true;
            this.Tbx_Dinner.Name = "Tbx_Dinner";
            this.Tbx_Dinner.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_Dinner.Size = new System.Drawing.Size(317, 473);
            this.Tbx_Dinner.TabIndex = 0;
            this.Tbx_Dinner.WordWrap = false;
            // 
            // Tbx_Lunch
            // 
            this.Tbx_Lunch.Location = new System.Drawing.Point(327, 34);
            this.Tbx_Lunch.Multiline = true;
            this.Tbx_Lunch.Name = "Tbx_Lunch";
            this.Tbx_Lunch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_Lunch.Size = new System.Drawing.Size(317, 473);
            this.Tbx_Lunch.TabIndex = 0;
            this.Tbx_Lunch.WordWrap = false;
            // 
            // Tbx_BreakFast
            // 
            this.Tbx_BreakFast.Location = new System.Drawing.Point(6, 34);
            this.Tbx_BreakFast.Multiline = true;
            this.Tbx_BreakFast.Name = "Tbx_BreakFast";
            this.Tbx_BreakFast.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_BreakFast.Size = new System.Drawing.Size(317, 473);
            this.Tbx_BreakFast.TabIndex = 0;
            this.Tbx_BreakFast.WordWrap = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(976, 636);
            this.Controls.Add(this.Tbc_Main);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "吃什么饭 2.1";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Tbc_Main.ResumeLayout(false);
            this.Tbp_EatWhat.ResumeLayout(false);
            this.Tbp_EatWhat.PerformLayout();
            this.Tbp_Manager.ResumeLayout(false);
            this.Tbp_Manager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_startcancle;
        private System.Windows.Forms.ComboBox cbx_eat;
        private System.Windows.Forms.TabControl Tbc_Main;
        private System.Windows.Forms.TabPage Tbp_EatWhat;
        private System.Windows.Forms.TabPage Tbp_Manager;
        private System.Windows.Forms.TextBox Tbx_BreakFast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbx_Dinner;
        private System.Windows.Forms.TextBox Tbx_Lunch;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Lbl_EatFoods;
    }
}

