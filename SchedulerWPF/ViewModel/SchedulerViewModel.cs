using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SchedulerWPF
{
    /// <summary>
    /// Month cell customization View Model class.
    /// </summary>
    public class SchedulerViewModel : INotifyPropertyChanged
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerViewModel" /> class
        /// </summary>
        public SchedulerViewModel()
        {
            this.AddAppointments();
        }

        #endregion Constructor

        #region Public Properties

        /// <summary>
        /// Property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets appointments
        /// </summary>
        public ScheduleAppointmentCollection Appointments { get; set; }

        #endregion

        #region Property Changed Event

        /// <summary>
        /// Invoke method when property changed
        /// </summary>
        /// <param name="propertyName">property name</param>
        private void RaiseOnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Methods
        /// <summary>
        /// Adding appointments
        /// </summary>
        private void AddAppointments()
        {
            this.Appointments = new ScheduleAppointmentCollection();

            var newEvent = new ScheduleAppointment();
            newEvent.Subject = "Meeting";
            newEvent.StartTime = new DateTime(2021, 06, 16, 10, 0, 0);
            newEvent.EndTime = new DateTime(2021, 06, 16, 11, 0, 0);
            newEvent.AppointmentBackground = Brushes.Green;
            newEvent.Reminders = new ObservableCollection<SchedulerReminder>
            {
                new SchedulerReminder { ReminderTimeInterval = new TimeSpan(0)},
            };

            var newEvent1 = new ScheduleAppointment();
            newEvent1.Subject = "Planning";
            newEvent1.StartTime = new DateTime(2021, 06, 16, 12, 0, 0);
            newEvent1.EndTime = new DateTime(2021, 06, 16, 13, 0, 0);
            newEvent1.AppointmentBackground = Brushes.Green;
            newEvent1.Reminders = new ObservableCollection<SchedulerReminder>
            {
                new SchedulerReminder { ReminderTimeInterval = new TimeSpan(0)},
            };

            var newEvent2 = new ScheduleAppointment();
            newEvent2.Subject = "Retrospective";
            newEvent2.StartTime = new DateTime(2021, 06, 16, 14, 0, 0);
            newEvent2.EndTime = new DateTime(2021, 06, 16, 15, 0, 0);
            newEvent2.AppointmentBackground = Brushes.Green;
            newEvent2.Reminders = new ObservableCollection<SchedulerReminder>
            {
                new SchedulerReminder { ReminderTimeInterval = new TimeSpan(0)},
            };


            this.Appointments.Add(newEvent);
            this.Appointments.Add(newEvent1);
            this.Appointments.Add(newEvent2);
        }
        #endregion
    }
}