using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace cafe
{
    public partial class Form1 : Form
    {
        string people = "";
        string[] peoplenum = {};
        string expeople = "";
        string[] expeoplenum = {};

        private bool NaverLogin(string ID, string PW)
        {
            HttpWebRequest hreq = (HttpWebRequest)WebRequest.Create("https://nid.naver.com/nidlogin.login");
            hreq.Method = "POST";
            hreq.Referer = "https://nid.naver.com/nidlogin.login?svctype=262144&url=http://m.naver.com/aside/";
            hreq.ContentType = "application/x-www-form-urlencoded";
            hreq.CookieContainer = new CookieContainer();
            StreamWriter sw = new StreamWriter(hreq.GetRequestStream());
            sw.Write("id=" + ID + "&pw=" + PW + "&saveID=0&enctp=2&smart_level=-1&svctype=0");
            sw.Close();
            HttpWebResponse hres = (HttpWebResponse)hreq.GetResponse();
            if (hres.StatusCode == HttpStatusCode.OK)
            {
                Stream dataStream = hres.GetResponseStream();
                StreamReader sr = new StreamReader(dataStream, Encoding.UTF8);
                string result = sr.ReadToEnd();
                hres.Close();
                dataStream.Close();
                sr.Close();
                if (result.Contains("https://nid.naver.com/login/sso/finalize.nhn?url"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        int timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(NaverLogin(idtxt.Text,passtxt.Text)==true)
            {
                MessageBox.Show("로그인 성공");
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            peoplenum = Peopletxt.Text.Split('\n');

            for (int i = 0; i < peoplenum.Length; i++)
            {
                MailMessage sendMail = new MailMessage();           // System.Net.Mail
                sendMail.From = new MailAddress(idtxt.Text+@"@naver.com");        // 보내는 사람
                sendMail.To.Add(new MailAddress(peoplenum[i]+@"@naver.com"));       // 받는 사람
                sendMail.Subject = Titletxt.Text;                   // 메일 제목
                sendMail.Body = ContentTxt.Text;                     // 메일 내용
                                                             // 보내는 메일 서버(SMTP)
                SmtpClient smtpServer = new SmtpClient("smtp.naver.com", 587);      // System.net.Mail
                smtpServer.UseDefaultCredentials = false;                   // DefaultCredentials를 보낼지 여부를 제어
                smtpServer.EnableSsl = false;                               // SmtpClient에서 SSL을 사용하여 연결을 암호화할지 여부 설정
                smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;     // 보내는 전자 메일 메시지의 처리 방법 설정
                smtpServer.Credentials = new System.Net.NetworkCredential(idtxt.Text, passtxt.Text);   // SSL 연결을 설정하는데 사용할 인증서 설
                smtpServer.EnableSsl = true;

                try
                {
                    smtpServer.Send(sendMail);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("메일 전송 실패");
                    MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Data);
                    break;
                }
            }

            MessageBox.Show("메시지 전송 성공!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Int32.Parse(numtxt.Text)*15*15; i++)
            {
                int index3 = Addresstxt.Text.IndexOf("articleid=") + 10;
                string a = Addresstxt.Text.Substring(index3);
                int index4 = a.IndexOf("&");
                a = a.Substring(0, index4);
                string b = Addresstxt.Text.Substring(0, index3);
                string c = Addresstxt.Text.Substring(b.Length + a.Length);
                int num = Int32.Parse(a);
                num -= i;
                a = num.ToString();

                try
                {
                    WebRequest request = WebRequest.Create(b + a + c);

                    WebResponse response = request.GetResponse();
                    StreamReader stream = new StreamReader(response.GetResponseStream());

                    string firstStr = stream.ReadToEnd();

                    int index1 = firstStr.IndexOf("26memberid=");
                    if (index1 == -1)
                    {
                        continue;
                    }
                    else
                    {
                        index1 += 11;
                    }
                    string str = firstStr.Substring(index1);

                    index1 = str.IndexOf(@"\");
                    if (index1 == -1)
                    {
                        continue;
                    }
                    str = str.Substring(0, index1);
                    people += str + "\n";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (Extxt.Text != null)
            {
                peoplenum = people.Split('\n');
                peoplenum = peoplenum.Distinct().ToArray();
                expeople = Extxt.Text;
                expeoplenum = expeople.Split('\n');

                for (int i = 0; i < peoplenum.Length; i++)
                {
                    for (int j = 0; j < expeoplenum.Length; j++)
                    {
                        if(peoplenum[i] == expeoplenum[j])
                        {
                            peoplenum[i] = null;
                        }
                    }
                }
            }

            for(int i = 0; i < peoplenum.Length; i++)
            {
                Peopletxt.Text += peoplenum[i] + '\n';
            }
        }
    }
}
