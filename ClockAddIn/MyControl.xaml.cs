using System;
using System.Threading;
using System.Windows.Controls;

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
                                                                                   this.hoursRotation.Angle = (now.Hour * (360d / 12d)) + (now.Minute * (30d / 60d));
                                                                                   this.minutesRotation.Angle = Math.Floor(now.Minute / 60d * 360d);
                                                                               })), null, TimeSpan.Zero, TimeSpan.FromMilliseconds(100));
        }
    }
}