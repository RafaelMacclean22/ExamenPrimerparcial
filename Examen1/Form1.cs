using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen1.Ententis;

namespace Examen1
{
    public partial class Form1 : Form
    {
        string APIKey = "d45c2ffc2fd7a4cf1b27dace41566589";
        public Form1()
        {
            InitializeComponent();
        }
        DateTime convertdatetime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }

        void buscar()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", textBox1.Text, APIKey);

                var json = web.DownloadString(url);
                City.root info = JsonConvert.DeserializeObject<City.root>(json);

                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].Icon + ".png";
                lbPuesta.Text = convertdatetime(info.sys.Sunset).ToShortTimeString();
                lbamanecer.Text = convertdatetime(info.sys.sunrise).ToShortTimeString();
                lbviento.Text = Convertir.ConvertirdemillasaKm((float)info.wind.speed).ToString();
                lbpresion.Text = info.main.pressure.ToString();
               label9.Text = Convertir.ConvertirdeKelvinaCelcius((float)info.main.Temp).ToString();
                label10.Text = Convertir.ConvertirdeKelvinaCelcius((float)info.main.Temp_Min).ToString();
                label11.Text = Convertir.ConvertirdeKelvinaCelcius((float)info.main.Temp_Max).ToString();
                label12.Text = info.main.humedity.ToString();


            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
