using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* 
 * начинаем с зеленого квадратика. За 15-20 сек нужно дойти до синего прямоугольника, чтобы открыть синюю дверь перед финишем.
 * при этом на синем прямоугольнике отображается обратный отсчет времени. 
 * когда мы попали на синий прямоугольник, на лейбе "финиш" тоже начинается обратный отсчет (около 10сек)
 * синий прямоугольник - чек-поинт.
 * при возврате на старт или чекпоинт обратный отсчет начинается заново.
 */



namespace Labirint
{
    public partial class FormLevel5 : Form
    {
        int cheat_click;
        int c = 30;
   
        public FormLevel5()
        {
            InitializeComponent();                    
        }

        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);            
            label_door.Visible = true;
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
            else
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
            label_door.Visible = true;
        }        

        private void FormLevel5_MouseDown(object sender, MouseEventArgs e)
        {
            cheat_click++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (c >= 0)
                label_key.Text = c--.ToString();
            else
                timer1.Stop();
        }

                   
    }
}
