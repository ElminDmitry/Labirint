namespace Labirint
{
    partial class FormLevel2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_finish_box = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wall1 = new System.Windows.Forms.Label();
            this.wall2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_door = new System.Windows.Forms.Label();
            this.label_key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(389, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 300);
            this.label5.TabIndex = 13;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(513, 17);
            this.label4.TabIndex = 12;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(513, 16);
            this.label3.TabIndex = 11;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(506, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 409);
            this.label2.TabIndex = 10;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 409);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label_finish_box
            // 
            this.label_finish_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_finish_box.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_finish_box.Location = new System.Drawing.Point(425, 26);
            this.label_finish_box.Name = "label_finish_box";
            this.label_finish_box.Size = new System.Drawing.Size(75, 40);
            this.label_finish_box.TabIndex = 8;
            this.label_finish_box.Text = "Финиш";
            this.label_finish_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_finish_box.MouseEnter += new System.EventHandler(this.label_finish_box_MouseEnter);
            // 
            // label_start
            // 
            this.label_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_start.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start.Location = new System.Drawing.Point(33, 26);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(75, 40);
            this.label_start.TabIndex = 7;
            this.label_start.Text = "Старт";
            this.label_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(267, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 300);
            this.label6.TabIndex = 14;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.Green;
            this.wall1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wall1.Location = new System.Drawing.Point(0, 116);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(513, 33);
            this.wall1.TabIndex = 17;
            this.wall1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wall1.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.Green;
            this.wall2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wall2.Location = new System.Drawing.Point(12, 209);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(513, 33);
            this.wall2.TabIndex = 18;
            this.wall2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wall2.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_door
            // 
            this.label_door.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_door.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_door.Location = new System.Drawing.Point(416, 275);
            this.label_door.Name = "label_door";
            this.label_door.Size = new System.Drawing.Size(97, 40);
            this.label_door.TabIndex = 16;
            this.label_door.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_door.MouseEnter += new System.EventHandler(this.label_door_MouseEnter);
            // 
            // label_key
            // 
            this.label_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_key.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_key.Location = new System.Drawing.Point(308, 26);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(75, 40);
            this.label_key.TabIndex = 15;
            this.label_key.Text = "Ключ";
            this.label_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_key.MouseEnter += new System.EventHandler(this.label_key_MouseEnter_2);
            // 
            // FormLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(525, 408);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_finish_box);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label_door);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.wall2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLevel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLevel2";
            this.Shown += new System.EventHandler(this.FormLevel2_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLevel2_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_finish_box;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label wall1;
        private System.Windows.Forms.Label wall2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_door;
        private System.Windows.Forms.Label label_key;
    }
}