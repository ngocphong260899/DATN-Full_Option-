using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft;
using System.IO;
using Newtonsoft.Json.Linq;
namespace DATN_App_Windows
{
    public partial class doi_ten : Form
    {
        public delegate void sen_Data(string data1, string data2, string data3, string data4);
        public sen_Data send_Main;
        public doi_ten()
        {
            InitializeComponent();
        }

        private void doi_ten_Load(object sender, EventArgs e)
        {
            readFileJson();
        }
        public void change_Json_Value(String value1, string value2, string value3, string value4)
        {
            string jsonString = File.ReadAllText(@"E:\Do_An_Tot_Nghiep\App_Windows\DATN_App_Windows\key_name.json");
            JObject jObject = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString) as JObject;

            JToken jToken = jObject.SelectToken("room_name");
            JToken jToken1 = jObject.SelectToken("sw_wifi1");
            JToken jToken2 = jObject.SelectToken("sw_wifi2");
            JToken jToken3 = jObject.SelectToken("sw_wifi3");

            jToken.Replace(value1);
            jToken1.Replace(value2);
            jToken2.Replace(value3);
            jToken3.Replace(value4);

            string updatedJsonString = jObject.ToString();
            File.WriteAllText(@"E:\Do_An_Tot_Nghiep\App_Windows\DATN_App_Windows\key_name.json", updatedJsonString);
            File.Exists(@"E:\Do_An_Tot_Nghiep\App_Windows\DATN_App_Windows\key_name.json");
        }
        public string data1;
        public string data2;
        public string data3;
        public string data4;
        public void readFileJson()
        {
            StreamReader r = new StreamReader(@"E:\Do_An_Tot_Nghiep\App_Windows\DATN_App_Windows\key_name.json");
            string json_Data = r.ReadToEnd();
            Console.WriteLine("Data is: " + json_Data);
            remame_Json_key data_Parse_json = JsonConvert.DeserializeObject<remame_Json_key>(json_Data);
            string room_name = data_Parse_json.room_name;
            string sw_wifi1 = data_Parse_json.sw_wifi1;
            string sw_wifi2 = data_Parse_json.sw_wifi2;
            string sw_wifi3 = data_Parse_json.sw_wifi3;

            textBox1.Text = room_name;
            textBox2.Text = sw_wifi1;
            textBox3.Text = sw_wifi2;
            textBox4.Text = sw_wifi3;

            r.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (send_Main != null)
            {
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
                {
                    MessageBox.Show("Khong duoc de trong du lieu");
                }
                else if (textBox1.Text.Length > 0 || textBox2.Text.Length > 0 || textBox3.Text.Length > 0 || textBox4.Text.Length > 0)
                {
                    send_Main(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    change_Json_Value(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                }

            }
        }
    }
}
