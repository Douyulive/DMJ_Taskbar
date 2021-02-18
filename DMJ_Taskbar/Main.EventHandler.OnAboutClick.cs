using System;
using System.Diagnostics;

namespace DMJ_Taskbar
{
    public partial class Main
    {
        public void OnAboutClick(object sender, EventArgs e)
        {
            Process.Start("https://www.dydmj.org/plugins/DMJ_Taskbar");
        }
    }
}
