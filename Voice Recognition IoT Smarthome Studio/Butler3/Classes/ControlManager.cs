using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butler3
{
    public static class ControlManager
    {
        public static void SetupButton(Button f_btTarget, Bitmap f_defalut, Bitmap f_enter, Bitmap f_down)
        {
            Bitmap f_resizeDefalut;
            Bitmap f_resizeEnter;
            Bitmap f_resizeDown;

            f_resizeDefalut = new Bitmap(f_defalut, f_btTarget.Width, f_btTarget.Height);
            f_resizeEnter = new Bitmap(f_enter, f_btTarget.Width, f_btTarget.Height);
            f_resizeDown = new Bitmap(f_down, f_btTarget.Width, f_btTarget.Height);

            f_btTarget.BackColor = Color.Transparent;
            f_btTarget.FlatStyle = FlatStyle.Flat;
            f_btTarget.FlatAppearance.BorderSize = 0;
            f_btTarget.FlatAppearance.MouseOverBackColor = Color.Transparent;
            f_btTarget.FlatAppearance.MouseDownBackColor = Color.Transparent;
            f_btTarget.Image = f_resizeDefalut;

            f_btTarget.MouseDown += new System.Windows.Forms.MouseEventHandler((sender, e) => { f_btTarget.Image = f_resizeDown; });
            f_btTarget.MouseEnter += new System.EventHandler((sender, e) => { f_btTarget.Image = f_resizeEnter; });
            f_btTarget.MouseLeave += new System.EventHandler((sender, e) => { f_btTarget.Image = f_resizeDefalut; });
            f_btTarget.MouseUp += new System.Windows.Forms.MouseEventHandler((sender, e) => { f_btTarget.Image = f_resizeDefalut; });
        }
    }
}
