using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFSerialAssistant
{
    class LoginEvent
    {
    }

    public partial class Login : Window
    {


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WPFSerialAssistant.About about = new About();
            about.ShowDialog();
        }
    }
}
