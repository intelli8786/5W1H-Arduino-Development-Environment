using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moduino_Programmer6
{
    public partial class Form_Arduino : Form
    {
        public Arduino Selected;
        public Form_Arduino(List<Arduino> f_arduinoList)
        {
            InitializeComponent();
            foreach(Arduino arduino in f_arduinoList)
            {
                Button f_btCurrentArduino = new Button();
                f_btCurrentArduino.Name = arduino.m_strName;
                f_btCurrentArduino.Size = new System.Drawing.Size(200, 200);
                f_btCurrentArduino.Text = arduino.m_strName;
                f_btCurrentArduino.UseVisualStyleBackColor = true;
                f_btCurrentArduino.TextAlign = ContentAlignment.BottomCenter;
                CommonClass.ResizeInsert(f_btCurrentArduino, arduino.m_bmImage);
                m_flpArduinoList.Controls.Add(f_btCurrentArduino);
                f_btCurrentArduino.Click += new System.EventHandler((object sender, EventArgs e) =>
                {

                    Selected = arduino;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                });
            }
        }

        private void Form_Arduino_Load(object sender, EventArgs e)
        {

        }


    }
}
