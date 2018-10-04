using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Net.Http;


namespace WindowsFormsApp1
{
    
    
    public partial class Form4 : Form
    {
        public Form4()
        {
            
            InitializeComponent();
            openFileDialog1.Filter = "Json files(*.json)|*.json|All files(*.*)|*.*";
        }
        static class GlobalVars
        {
            public static string filename;
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            GlobalVars.filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(GlobalVars.filename);
            textBox1.Text = fileText;
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "http://blup.su/dataport/import?secret-key=4823671";

                HttpClient client = new HttpClient();
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);

                string json2 = textBox1.Text;
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);

                httpRequest.Method = "POST";
                httpRequest.ContentType = "application/json";
                httpRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.0.5) Gecko/2008120122 Firefox/3.0.5";
                using (var requestStream1 = httpRequest.GetRequestStream())
                using (var writer = new StreamWriter(requestStream1))
                {
                    writer.Write(json2);
                }
                using (var httpResponse = httpRequest.GetResponse())
                using (var responseStream = httpResponse.GetResponseStream())
                using (var reader = new StreamReader(responseStream))
                {
                    string response = reader.ReadToEnd();
                textBox2.Text = reader.ToString();
                }
            }
            catch( Exception ex)
            {
                throw new Exception("Failed to upload", ex.InnerException);

            }

            

            
            
           
           // WebClient web = new WebClient();
           
           // web.Headers["User-Agent"] = "Mozilla/5.0";
           // web.Headers["Content-Type"] = "application/json";
          //  web.Headers["Accept"] = "html/text";
           // web.Headers["Accept-Encoding"] = "gzip, deflate";
           // web.Headers["Accept-Language"] = "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7";
           // web.Headers["Cache-Control"] = "no-store, no-cache, must-revalidate";
            //web.UploadFileAsync (new Uri(url),GlobalVars.filename);

            //var mydate = DateTime.Now;
            //string date = mydate.ToString("H-mm-ss dd-MM-yyyy");
            //string save_path = "..\\..\\..\\log\\log.txt";
            //string name = date + ".txt";
            //System.Diagnostics.Process.Start(save_path);
        }

    }
}
