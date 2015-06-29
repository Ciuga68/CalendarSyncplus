﻿using System;
using System.Waf.Foundation;
using System.Xml.Serialization;
using CalendarSyncPlus.Common.MetaData;

namespace CalendarSyncPlus.Domain.Models.Preferences
{
    [XmlInclude(typeof (Calendar))]
    [XmlInclude(typeof (SyncFrequency))]
    [XmlInclude(typeof (Category))]
    public class CalendarSyncProfile : SyncProfile
    {
        private SyncSettings _syncSettings;

        public CalendarSyncProfile()
        {
            Name = "Default Profile";
            SyncSettings = new SyncSettings();
            ExchangeServerSettings = new ExchangeServerSettings();
            OutlookSettings = new OutlookSettings();
            IsSyncEnabled = true;
            IsDefault = true;
        }

        /// <summary>
        /// </summary>
        public SyncSettings SyncSettings
        {
            get { return _syncSettings; }
            set { SetProperty(ref _syncSettings, value); }
        }

        /// <summary>
        /// </summary>
        public CalendarEntryOptionsEnum CalendarEntryOptions { get; set; }

        /// <summary>
        /// </summary>
        public bool SetCalendarCategory { get; set; }

        /// <summary>
        /// </summary>
        public Category EventCategory { get; set; }
        
       

        /// <summary>
        ///     Gets default calendar profile for the user
        /// </summary>
        /// <returns>
        /// </returns>
        public static CalendarSyncProfile GetDefaultSyncProfile()
        {
            var syncProfile = new CalendarSyncProfile
            {
                SyncSettings = SyncSettings.GetDefault(),
                OutlookSettings =
                {
                    OutlookOptions = OutlookOptionsEnum.DefaultProfile |
                                     OutlookOptionsEnum.DefaultCalendar
                },
                CalendarEntryOptions =
                    CalendarEntryOptionsEnum.Description | CalendarEntryOptionsEnum.Attendees |
                    CalendarEntryOptionsEnum.AttendeesToDescription |
                    CalendarEntryOptionsEnum.Reminders | CalendarEntryOptionsEnum.AsAppointments,
                    SyncDirection = SyncDirectionEnum.OutlookGoogleOneWay,
                SyncFrequency = new IntervalSyncFrequency {Hours = 1, Minutes = 0, StartTime = DateTime.Now}
            };
            syncProfile.SetSourceDestTypes();
            return syncProfile;
        }
    }
}