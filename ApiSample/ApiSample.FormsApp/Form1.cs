using Newtonsoft.Json;
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

namespace ApiSample.FormsApp
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var result = GetAllUser();

            listBox1.DataSource = result;
        }
        public async List<User> UserGetir()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:62045/api/User");
                var result = JsonConvert.DeserializeObject<List<User>>(response.Content.ReadAsByteArrayAsync().Result);
                //jsonconvert için newtonsoft json indirdik.
                return result;
            }
        }
    }
}