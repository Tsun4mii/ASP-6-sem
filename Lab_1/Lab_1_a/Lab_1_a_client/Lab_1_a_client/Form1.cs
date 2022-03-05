using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_a_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.valueOne.Text, out int firstValue) && int.TryParse(this.valueTwo.Text, out int secondValue))
            {

                var data = new List<KeyValuePair<string, string>>();
                data.Add(new KeyValuePair<string, string>("X", this.valueOne.Text));
                data.Add(new KeyValuePair<string, string>("Y", this.valueTwo.Text));

                var url = "https://localhost:44321/syoT4";
                using (var client = new HttpClient())
                {
                    var req = new HttpRequestMessage(HttpMethod.Post, url) { Content = new FormUrlEncodedContent(data) };
                    var res = await client.SendAsync(req);
                    this.result.Text = res.Content.ReadAsStringAsync().Result; ;
                }


            }
        }
    }
}
