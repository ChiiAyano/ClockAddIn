using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Company.ClockAddIn
{
    /// <summary>
    /// Interaction logic for MyControl.xaml
    /// </summary>
    public partial class MyControl : UserControl
    {
        Timer timer;

        public MyControl()
        {
            InitializeComponent();

            this.timer = new Timer(o => this.Dispatcher.BeginInvoke(new Action(() =>
                                                                               {
                                                                                   var now = DateTime.Now;
                                                                                   this.nowTimeBlock.Text = now.ToString("HH:mm");
                                                                                   this.hoursRotation.Angle = Math.Floor(now.Hour / 12d * 360d);
                                                                                   this.minutesRotation.Angle = Math.Floor(now.Minute / 60d * 360d);
                                                                               })), null, TimeSpan.Zero, TimeSpan.FromMilliseconds(100));
        }
    }
}