using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            var mydate = DateTime.Now;
            //DateTime date1 = new DateTime;
            string date = mydate.ToString("H-mm-ss dd-MM-yyyy");

            Thread thread = new Thread(() => {
                WebClient web = new WebClient();
            string url = "http://blup.su/dataport/exportfile?secret-key=4823671";
            string save_path = "..\\..\\..\\export\\";
            string name = date + ".json";     
            web.Headers["User-Agent"] = "Mozilla/5.0";
            web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            web.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            web.DownloadFileAsync(new Uri(url), save_path+name);
            });
            thread.Start();

            //web.DownloadFile(url, save_path + name);

            

        }

        void client_DownloadProgressChanged(object sender1, DownloadProgressChangedEventArgs e1)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e1.BytesReceived.ToString());
                double totalBytes = double.Parse(e1.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                label1.Text = "Скачано " + e1.BytesReceived + " байт из " + e1.TotalBytesToReceive;
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_DownloadFileCompleted(object sender1, AsyncCompletedEventArgs e1)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                label1.Text = "Загрузка завершена";
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "..\\..\\..\\export\\");

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
