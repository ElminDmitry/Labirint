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
    public partial class Level3 : Form
    {
        int left_boxes;
        int cheat_click;

        public Level3()
        {
            InitializeComponent();
        }

        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);            
            wall1.Visible = true;
            wall2.Visible = false;
            label_box1.Visible = true;
            label_box2.Visible = true;
            label_box3.Visible = true;
            label_box4.Visible = true;
            label_box5.Visible = true;
            left_boxes = 5;
            cheat_click = 0;
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
            if (cheat_click != 0)
            {                               
                    MessageBox.Show("Клик мышкой запрещен!", "Предупреждение");
                    start_game();                
            }
            if (left_boxes == 0)
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FormLevel3_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            wall1.Visible = !wall1.Visible;
            wall2.Visible = !wall2.Visible;
        }

        private void label_box2_MouseEnter(object sender, EventArgs e)
        {
            Sound.play_key();
            left_boxes--;
            ((Label)sender).Visible = false;
        }

        private void FormLevel3_MouseDown(object sender, MouseEventArgs e)
        {
            cheat_click++;
        }





    }
}
