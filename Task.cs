using System;

namespace Assignment4
{
    /// <summary>
    /// A data stucture representing a task. Each task has a date when it is due, a description of what it is an a level of priority ranging from not important to very important.
    /// Written by Sebastian Aspegren
    /// </summary>
    public class Task
    {
        //Variables used to store information regarding the task.
        private DateTime date;
        private string description;
        private PriorityType priority;

        /// <summary>
        /// Constructor for the task class.
        /// </summary>
        /// <param name="date"> date the task is due.</param>
        public Task(DateTime date)
        {
            this.date = date;
        }
        /// <summary>
        /// Property for the field date used to get or set its value.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
        /// <summary>
        /// Property for the field description used to get or set its value.
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }
        /// <summary>
        /// Property for the field proprity used to get or set its value.
        /// </summary>
        public PriorityType Priority
        {
            get
            {
                return priority;
            }

            set
            {
                priority = value;
            }
        }
        /// <summary>
        /// ToString method so we can print a task without it looking like complete mumbo jumbo.
        /// </summary>
        /// <returns>A neat string of info about the task.</returns>
        public override string ToString()
        {
            return String.Format("{0, -20} {1, 20} {2, 35} {3, 30}", date.ToLongDateString(), date.ToShortTimeString(), priority, description);
        }
    }
}
