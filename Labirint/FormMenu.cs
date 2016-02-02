using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Sound.play_start();
            start_level1();
        }

        private void box_sound_CheckedChanged(object sender, EventArgs e)
        {
            if(box_sound.Checked)
            {
                Sound.sound_on();
                box_sound.Text = "Звук есть";
                Sound.play_key();
            }
            else
            {
                Sound.sound_off();
                box_sound.Text = "Звука нет";
            }

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_level1 ()
        {
            FormLevel1 level1 = new FormLevel1();
            level1.ShowDialog();
        }
    }
}
