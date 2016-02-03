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
    public partial class FormLevel4 : Form
    {
        private readonly Timer timer2;
        
        public FormLevel4()
        {
            InitializeComponent();
            timer2 = new Timer();
            timer2.Interval = 2000;
            
        }

        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);            
            wall1.Visible = true;
            wall2.Visible = true;
            Sound.play_start();        
        }

        private void finish_game()
        {
            Sound.play_fail();
            DialogResult dr = MessageBox.Show("Вы проиграли, еще раз?", "Сообщение", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
               DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void label_finish_box_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FormLevel4_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            wall1.Visible = true;
            wall2.Visible = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Tick += timer2_Tick;
            timer2.Enabled = false;
            wall1.Visible = false;
            wall2.Visible = false;
            timer2.Enabled = true;
        }
                   
    }
}
