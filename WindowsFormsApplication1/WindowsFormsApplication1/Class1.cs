using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Class1
    {
        static Boolean toggle=true;
        public void GoFullscreenToggle(Form form)
        {
            if (toggle)
            {
                toggle = !toggle;
                form.WindowState = FormWindowState.Normal;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Bounds = Screen.PrimaryScreen.Bounds;
                
                //Console.WriteLine("if" + toggle);
            }
            else if(!toggle)
            {
                toggle = !toggle;
                form.WindowState = FormWindowState.Maximized;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                //Console.WriteLine("else:" + toggle);
            }
        }

        public void GoFullscreen(bool fullscreen, Form form)
        {
            if (fullscreen)
            {
                form.WindowState = FormWindowState.Normal;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
    }
}
