using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using BunifuColorTransition;
using Bunifu.Framework.Lib;
namespace DATN_App_Windows
{
    class get_Button_state
    {
        public void render_state(Label lab, string stt)
        {
            lab.Invoke((MethodInvoker)(() => lab.Text = stt));
        }

       

    }
}
