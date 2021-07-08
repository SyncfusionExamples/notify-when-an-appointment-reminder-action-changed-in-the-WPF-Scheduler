using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace SchedulerWPF
{
    public class ScheduleBehavior : Behavior<Grid>
    {
        Grid grid;
        SfScheduler schedule;
        protected override void OnAttached()
        {
            grid = this.AssociatedObject as Grid;
            schedule = grid.Children[0] as SfScheduler;
            schedule.ReminderAlertActionChanged += OnScheduleReminderAlertActionChanged;
        }

        private void OnScheduleReminderAlertActionChanged(object sender, ReminderAlertActionChangedEventArgs e)
        {
            if (e.ReminderAction == ReminderAction.Dismiss)
            {
                MessageBox.Show("Reminder alert action Dismiss clicked for appointment", "Reminder", MessageBoxButton.OK);
            }
            else if (e.ReminderAction == ReminderAction.DismissAll)
            {
                MessageBox.Show("Reminder alert action cancelled for all appointments", "Reminder", MessageBoxButton.OK);
            }
            else if (e.ReminderAction == ReminderAction.Snooze)
            {
                MessageBox.Show("Reminder alert action Snoozed", "Reminder", MessageBoxButton.OK);
            }
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            schedule.ReminderAlertActionChanged -= OnScheduleReminderAlertActionChanged;
            grid = null;
            schedule = null;
        }

    }
}