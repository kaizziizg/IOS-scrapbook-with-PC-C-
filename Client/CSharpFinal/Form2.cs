using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CSharpFinal
{
    public partial class Form2 : Form
    {
        string user = "";
        string currentmsg = "";
        List<string> msgs=new List<string>();
        List<string> sources = new List<string>();
        List<string> times = new List<string>();
        int pages = 0;
        int lastPages = 0;
        public void ChangePage()
        {
            try
            {
                currentPage.Text = $"{pages + 1}/{lastPages}";

                source.Text = sources[pages];
                time.Text = times[pages];
                currentmsg = msgs[pages];
                if (msgs[pages].Length > 10000)
                {
                    msgimg.Visible = true;
                    msg.Visible = false;
                    msgimg.Image = Base64StringToImage(msgs[pages]);
                }
                else
                {
                    msgimg.Visible = false;
                    msg.Visible = true;
                    msg.Text = msgs[pages];
                }
            }
            catch
            {
                pages = 0;
                ChangePage();
            }
            
        }


        public static Image Base64StringToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] Buffer = Convert.FromBase64String(base64String);

            byte[] data = null;
            Image oImage = null;
            MemoryStream oMemoryStream = null;
            Bitmap oBitmap = null;
            //建立副本
            data = (byte[])Buffer.Clone();
            try
            {
                oMemoryStream = new MemoryStream(data);
                //設定資料流位置
                oMemoryStream.Position = 0;
                oImage = System.Drawing.Image.FromStream(oMemoryStream);
                //建立副本
                oBitmap = new Bitmap(oImage);
            }
            catch
            {
                throw;
            }
            finally
            {
                oMemoryStream.Close();
                oMemoryStream.Dispose();
                oMemoryStream = null;
            }
            //return oImage;
            return oBitmap;
        }

        public Form2(string input)
        {
            InitializeComponent();
            user = input;
            MessageBox.Show(user);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        //讓topPanel可以移動
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetHistory();
            ChangePage();
        }

        public static string HttpGet(string url)
        {
            //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        public class history
        {
            public string id { get; set; }
            public string msg { get; set; }
            public string source { get; set; }
            public string time { get; set; }
        }
        public void GetHistory()
        {
            //var msg_json = HttpGet("https://finalprojectserver20220109075321.azurewebsites.net/api/clipboard/FiveMsg");
            var msg_json = HttpGet($"https://koalafinal.azurewebsites.net/api/clipboard/history?id={user}");
            var msg_result = new JavaScriptSerializer().Deserialize<history[]>(msg_json);
            lastPages = msg_result.Length;
            for (int i = 0; i < msg_result.Length; i++)
            {
                msgs.Add(msg_result[i].msg);
                sources.Add(msg_result[i].source);
                times.Add(msg_result[i].time);
            }
        }

        private void Left_btn_MouseMove(object sender, MouseEventArgs e)
        {
            Left_btn.Image = Properties.Resources.left3;
        }

        private void Left_btn_MouseLeave(object sender, EventArgs e)
        {
            Left_btn.Image = Properties.Resources.left2;
        }

        private void Right_btn_MouseMove(object sender, MouseEventArgs e)
        {
            Right_btn.Image = Properties.Resources.right2;
        }

        private void Right_btn_MouseLeave(object sender, EventArgs e)
        {
            Right_btn.Image = Properties.Resources.right3;
        }

        private void Right_btn_Click(object sender, EventArgs e)
        {
            if (pages < lastPages-1)
            {
                pages += 1;
                ChangePage();
            }
            
        }

        private void Left_btn_Click(object sender, EventArgs e)
        {
            if (pages > 0)
            {
                pages -= 1;
                ChangePage();
            }
                
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.link2;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.link1;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.copy2;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.copy1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string reg = ".*\\..*";
            if ((new System.Text.RegularExpressions.Regex(reg)).IsMatch(currentmsg))
            {
                if (currentmsg.Substring(0, 4) == "http")
                {
                    System.Diagnostics.Process.Start(currentmsg);
                }
                else
                {
                    System.Diagnostics.Process.Start("http://"+currentmsg);
                }
                
            }
            else
            {
                Clipboard.SetText(currentmsg);
                MessageBox.Show("這不是超連結 但已經複製到剪貼簿");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(currentmsg);

        }
    }
}
