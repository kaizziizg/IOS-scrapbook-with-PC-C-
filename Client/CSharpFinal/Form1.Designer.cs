
namespace CSharpFinal
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserID = new System.Windows.Forms.Label();
            this.UserID_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.current_label = new System.Windows.Forms.Label();
            this.Message1 = new System.Windows.Forms.Label();
            this.checkHyperLink = new System.Windows.Forms.CheckBox();
            this.checkSaveImg = new System.Windows.Forms.CheckBox();
            this.checkCopy = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.History_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.source1 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            this.source2 = new System.Windows.Forms.Label();
            this.Message2 = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Label();
            this.source3 = new System.Windows.Forms.Label();
            this.Message3 = new System.Windows.Forms.Label();
            this.time4 = new System.Windows.Forms.Label();
            this.source4 = new System.Windows.Forms.Label();
            this.Message4 = new System.Windows.Forms.Label();
            this.time5 = new System.Windows.Forms.Label();
            this.source5 = new System.Windows.Forms.Label();
            this.Message5 = new System.Windows.Forms.Label();
            this.TitleBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.panel2);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(323, 31);
            this.TitleBar.TabIndex = 3;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 500);
            this.panel2.TabIndex = 23;
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UserID.ForeColor = System.Drawing.Color.White;
            this.UserID.Location = new System.Drawing.Point(20, 34);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(160, 26);
            this.UserID.TabIndex = 0;
            this.UserID.Text = "請輸入使用者ID";
            // 
            // UserID_textbox
            // 
            this.UserID_textbox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UserID_textbox.Location = new System.Drawing.Point(178, 34);
            this.UserID_textbox.Name = "UserID_textbox";
            this.UserID_textbox.Size = new System.Drawing.Size(111, 29);
            this.UserID_textbox.TabIndex = 4;
            this.UserID_textbox.Text = "請輸入ID";
            this.toolTip1.SetToolTip(this.UserID_textbox, "輸入ID(僅能英文數字)");
            this.UserID_textbox.TextChanged += new System.EventHandler(this.UserID_textbox_TextChanged);
            this.UserID_textbox.Enter += new System.EventHandler(this.UserID_textbox_Enter);
            this.UserID_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserID_textbox_KeyPress);
            this.UserID_textbox.Leave += new System.EventHandler(this.UserID_textbox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Setting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "自動刷新間隔        秒";
            // 
            // Timer_textbox
            // 
            this.Timer_textbox.Location = new System.Drawing.Point(312, 393);
            this.Timer_textbox.Name = "Timer_textbox";
            this.Timer_textbox.Size = new System.Drawing.Size(18, 22);
            this.Timer_textbox.TabIndex = 15;
            this.Timer_textbox.Text = "99";
            this.toolTip1.SetToolTip(this.Timer_textbox, "自動刷新剪貼簿歷史間格");
            this.Timer_textbox.TextChanged += new System.EventHandler(this.Timer_textbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "當前剪貼簿內容";
            // 
            // current_label
            // 
            this.current_label.AutoSize = true;
            this.current_label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.current_label.ForeColor = System.Drawing.Color.White;
            this.current_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.current_label.Location = new System.Drawing.Point(173, 101);
            this.current_label.Name = "current_label";
            this.current_label.Size = new System.Drawing.Size(73, 20);
            this.current_label.TabIndex = 17;
            this.current_label.Text = "最新一筆";
            // 
            // Message1
            // 
            this.Message1.AutoSize = true;
            this.Message1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Message1.ForeColor = System.Drawing.Color.White;
            this.Message1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Message1.Location = new System.Drawing.Point(28, 189);
            this.Message1.Name = "Message1";
            this.Message1.Size = new System.Drawing.Size(53, 16);
            this.Message1.TabIndex = 18;
            this.Message1.Text = "載入中...";
            this.Message1.Click += new System.EventHandler(this.Message_Click);
            // 
            // checkHyperLink
            // 
            this.checkHyperLink.AutoSize = true;
            this.checkHyperLink.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkHyperLink.ForeColor = System.Drawing.Color.White;
            this.checkHyperLink.Location = new System.Drawing.Point(25, 421);
            this.checkHyperLink.Name = "checkHyperLink";
            this.checkHyperLink.Size = new System.Drawing.Size(111, 20);
            this.checkHyperLink.TabIndex = 19;
            this.checkHyperLink.Text = "自動打開超連結";
            this.checkHyperLink.UseVisualStyleBackColor = true;
            this.checkHyperLink.CheckedChanged += new System.EventHandler(this.checkHyperLink_CheckedChanged);
            // 
            // checkSaveImg
            // 
            this.checkSaveImg.AutoSize = true;
            this.checkSaveImg.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkSaveImg.ForeColor = System.Drawing.Color.White;
            this.checkSaveImg.Location = new System.Drawing.Point(25, 447);
            this.checkSaveImg.Name = "checkSaveImg";
            this.checkSaveImg.Size = new System.Drawing.Size(167, 20);
            this.checkSaveImg.TabIndex = 20;
            this.checkSaveImg.Text = "自動儲存圖片(當前目錄下)";
            this.checkSaveImg.UseVisualStyleBackColor = true;
            this.checkSaveImg.CheckedChanged += new System.EventHandler(this.checkSaveImg_CheckedChanged);
            // 
            // checkCopy
            // 
            this.checkCopy.AutoSize = true;
            this.checkCopy.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkCopy.ForeColor = System.Drawing.Color.White;
            this.checkCopy.Location = new System.Drawing.Point(25, 395);
            this.checkCopy.Name = "checkCopy";
            this.checkCopy.Size = new System.Drawing.Size(159, 20);
            this.checkCopy.TabIndex = 21;
            this.checkCopy.Text = "自動複製最新一筆剪貼簿";
            this.checkCopy.UseVisualStyleBackColor = true;
            this.checkCopy.CheckedChanged += new System.EventHandler(this.checkCopy_CheckedChanged);
            // 
            // History_btn
            // 
            this.History_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.History_btn.FlatAppearance.BorderSize = 0;
            this.History_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History_btn.Image = ((System.Drawing.Image)(resources.GetObject("History_btn.Image")));
            this.History_btn.Location = new System.Drawing.Point(313, 50);
            this.History_btn.Name = "History_btn";
            this.History_btn.Size = new System.Drawing.Size(40, 33);
            this.History_btn.TabIndex = 9;
            this.toolTip1.SetToolTip(this.History_btn, "歷史紀錄");
            this.History_btn.UseVisualStyleBackColor = true;
            this.History_btn.Click += new System.EventHandler(this.History_btn_Click);
            this.History_btn.MouseLeave += new System.EventHandler(this.History_btn_MouseLeave);
            this.History_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.History_btn_MouseMove);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Image = global::CSharpFinal.Properties.Resources.logout_out;
            this.Logout_btn.Location = new System.Drawing.Point(351, 50);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(40, 33);
            this.Logout_btn.TabIndex = 8;
            this.toolTip1.SetToolTip(this.Logout_btn, "登出");
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            this.Logout_btn.MouseLeave += new System.EventHandler(this.Logout_btn_MouseLeave);
            this.Logout_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Logout_btn_MouseMove);
            // 
            // Login
            // 
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Image = ((System.Drawing.Image)(resources.GetObject("Login.Image")));
            this.Login.Location = new System.Drawing.Point(284, 27);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(76, 51);
            this.Login.TabIndex = 5;
            this.toolTip1.SetToolTip(this.Login, "登入");
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            this.Login.MouseLeave += new System.EventHandler(this.Login_MouseLeave);
            this.Login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(379, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(12, 12);
            this.btnClose.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnClose, "關閉");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(360, 9);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(13, 13);
            this.btnMax.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnMax, "最大化");
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(341, 9);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(12, 12);
            this.btnMin.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnMin, "縮小");
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 500);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 500);
            this.panel4.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(399, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 500);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(0, 499);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 1);
            this.panel6.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(237, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 31);
            this.button1.TabIndex = 26;
            this.button1.Text = "Iphone捷徑設定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(27, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "內容";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(216, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "來源";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(312, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "時間";
            // 
            // source1
            // 
            this.source1.AutoSize = true;
            this.source1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.source1.ForeColor = System.Drawing.Color.White;
            this.source1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.source1.Location = new System.Drawing.Point(217, 189);
            this.source1.Name = "source1";
            this.source1.Size = new System.Drawing.Size(53, 16);
            this.source1.TabIndex = 30;
            this.source1.Text = "載入中...";
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time1.ForeColor = System.Drawing.Color.White;
            this.time1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time1.Location = new System.Drawing.Point(300, 189);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(53, 16);
            this.time1.TabIndex = 31;
            this.time1.Text = "載入中...";
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time2.ForeColor = System.Drawing.Color.White;
            this.time2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time2.Location = new System.Drawing.Point(300, 219);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(53, 16);
            this.time2.TabIndex = 34;
            this.time2.Text = "載入中...";
            // 
            // source2
            // 
            this.source2.AutoSize = true;
            this.source2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.source2.ForeColor = System.Drawing.Color.White;
            this.source2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.source2.Location = new System.Drawing.Point(217, 219);
            this.source2.Name = "source2";
            this.source2.Size = new System.Drawing.Size(53, 16);
            this.source2.TabIndex = 33;
            this.source2.Text = "載入中...";
            // 
            // Message2
            // 
            this.Message2.AutoSize = true;
            this.Message2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Message2.ForeColor = System.Drawing.Color.White;
            this.Message2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Message2.Location = new System.Drawing.Point(28, 219);
            this.Message2.Name = "Message2";
            this.Message2.Size = new System.Drawing.Size(53, 16);
            this.Message2.TabIndex = 32;
            this.Message2.Text = "載入中...";
            // 
            // time3
            // 
            this.time3.AutoSize = true;
            this.time3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time3.ForeColor = System.Drawing.Color.White;
            this.time3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time3.Location = new System.Drawing.Point(300, 249);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(53, 16);
            this.time3.TabIndex = 37;
            this.time3.Text = "載入中...";
            // 
            // source3
            // 
            this.source3.AutoSize = true;
            this.source3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.source3.ForeColor = System.Drawing.Color.White;
            this.source3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.source3.Location = new System.Drawing.Point(217, 249);
            this.source3.Name = "source3";
            this.source3.Size = new System.Drawing.Size(53, 16);
            this.source3.TabIndex = 36;
            this.source3.Text = "載入中...";
            // 
            // Message3
            // 
            this.Message3.AutoSize = true;
            this.Message3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Message3.ForeColor = System.Drawing.Color.White;
            this.Message3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Message3.Location = new System.Drawing.Point(28, 249);
            this.Message3.Name = "Message3";
            this.Message3.Size = new System.Drawing.Size(53, 16);
            this.Message3.TabIndex = 35;
            this.Message3.Text = "載入中...";
            // 
            // time4
            // 
            this.time4.AutoSize = true;
            this.time4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time4.ForeColor = System.Drawing.Color.White;
            this.time4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time4.Location = new System.Drawing.Point(300, 279);
            this.time4.Name = "time4";
            this.time4.Size = new System.Drawing.Size(53, 16);
            this.time4.TabIndex = 40;
            this.time4.Text = "載入中...";
            // 
            // source4
            // 
            this.source4.AutoSize = true;
            this.source4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.source4.ForeColor = System.Drawing.Color.White;
            this.source4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.source4.Location = new System.Drawing.Point(217, 279);
            this.source4.Name = "source4";
            this.source4.Size = new System.Drawing.Size(53, 16);
            this.source4.TabIndex = 39;
            this.source4.Text = "載入中...";
            // 
            // Message4
            // 
            this.Message4.AutoSize = true;
            this.Message4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Message4.ForeColor = System.Drawing.Color.White;
            this.Message4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Message4.Location = new System.Drawing.Point(28, 279);
            this.Message4.Name = "Message4";
            this.Message4.Size = new System.Drawing.Size(53, 16);
            this.Message4.TabIndex = 38;
            this.Message4.Text = "載入中...";
            // 
            // time5
            // 
            this.time5.AutoSize = true;
            this.time5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time5.ForeColor = System.Drawing.Color.White;
            this.time5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time5.Location = new System.Drawing.Point(300, 309);
            this.time5.Name = "time5";
            this.time5.Size = new System.Drawing.Size(53, 16);
            this.time5.TabIndex = 43;
            this.time5.Text = "載入中...";
            this.time5.Click += new System.EventHandler(this.time5_Click);
            // 
            // source5
            // 
            this.source5.AutoSize = true;
            this.source5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.source5.ForeColor = System.Drawing.Color.White;
            this.source5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.source5.Location = new System.Drawing.Point(217, 309);
            this.source5.Name = "source5";
            this.source5.Size = new System.Drawing.Size(53, 16);
            this.source5.TabIndex = 42;
            this.source5.Text = "載入中...";
            // 
            // Message5
            // 
            this.Message5.AutoSize = true;
            this.Message5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Message5.ForeColor = System.Drawing.Color.White;
            this.Message5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Message5.Location = new System.Drawing.Point(28, 309);
            this.Message5.Name = "Message5";
            this.Message5.Size = new System.Drawing.Size(53, 16);
            this.Message5.TabIndex = 41;
            this.Message5.Text = "載入中...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.time5);
            this.Controls.Add(this.source5);
            this.Controls.Add(this.Message5);
            this.Controls.Add(this.time4);
            this.Controls.Add(this.source4);
            this.Controls.Add(this.Message4);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.source3);
            this.Controls.Add(this.Message3);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.source2);
            this.Controls.Add(this.Message2);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.source1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkCopy);
            this.Controls.Add(this.checkSaveImg);
            this.Controls.Add(this.checkHyperLink);
            this.Controls.Add(this.Message1);
            this.Controls.Add(this.current_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Timer_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.History_btn);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.UserID_textbox);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TitleBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.TextBox UserID_textbox;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button History_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Timer_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label current_label;
        private System.Windows.Forms.Label Message1;
        private System.Windows.Forms.CheckBox checkHyperLink;
        private System.Windows.Forms.CheckBox checkSaveImg;
        private System.Windows.Forms.CheckBox checkCopy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label source1;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.Label source2;
        private System.Windows.Forms.Label Message2;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Label source3;
        private System.Windows.Forms.Label Message3;
        private System.Windows.Forms.Label time4;
        private System.Windows.Forms.Label source4;
        private System.Windows.Forms.Label Message4;
        private System.Windows.Forms.Label time5;
        private System.Windows.Forms.Label source5;
        private System.Windows.Forms.Label Message5;
    }
}

