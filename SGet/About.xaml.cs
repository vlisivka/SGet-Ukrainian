using System;
using System.Windows;

namespace SGet
{
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();

            tbVersionAuthor.Text = "Версія 1.0\nCopyright \u00A9 " + DateTime.Now.Year + "\nMarko Dominik Topić\nПерекладач:\nВолодимир М. Лісівка";
            tbUser.Text = String.Format("Використовує {0} на {1}", Environment.UserName, Environment.MachineName);
        }
    }
}
