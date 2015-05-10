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

namespace DeepSpaceBattles
{
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
            SoundPlayer sound = new SoundPlayer("C:\\Users\\Ana\\Downloads\\DeepSpaceBattles(2)\\DeepSpaceBattles\\DeepSpaceBattles\\Resources\\Star_Wars_Soundtrack.wav");
            sound.PlayLooping();
            Image img = DeepSpaceBattles.Properties.Resources.Untitled;
            pictureBox1.Image = img;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
