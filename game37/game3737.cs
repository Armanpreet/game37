using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace game37
{
    public partial class game3737 : Form
    {
        private SoundPlayer _soundPlayer;//plays sound 
        public game3737()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _soundPlayer = new SoundPlayer(Properties.Resources.Gun_Reload);
            _soundPlayer.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _soundPlayer = new SoundPlayer(Properties.Resources.spin);
            _soundPlayer.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Form1 display = new Form1();//displays a new form
            display.Show();
        }

        private void game3737_Load(object sender, EventArgs e)
        {

        }
    }
}
