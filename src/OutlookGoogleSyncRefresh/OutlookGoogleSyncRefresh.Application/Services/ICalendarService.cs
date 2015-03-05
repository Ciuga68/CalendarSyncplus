﻿#region File Header
// /******************************************************************************
//  * 
//  *      Copyright (C) Ankesh Dave 2015 All Rights Reserved. Confidential
//  * 
//  ******************************************************************************
//  * 
//  *      Project:        OutlookGoogleSyncRefresh
//  *      SubProject:     OutlookGoogleSyncRefresh.Application
//  *      Author:         Dave, Ankesh
//  *      Created On:     05-03-2015 3:09 PM
//  *      Modified On:    05-03-2015 3:09 PM
//  *      FileName:       ICalendarService.cs
//  * 
//  *****************************************************************************/
#endregion

using System.Collections.Generic;
using System.Threading.Tasks;

using OutlookGoogleSyncRefresh.Domain.Models;

namespace OutlookGoogleSyncRefresh.Application.Services
{
    public interface ICalendarService
    {
        string CalendarServiceName { get; }
        Task<List<Calendar>> GetAvailableCalendars(IDictionary<string, object> calendarSpecificData);

        Task<bool> AddCalendarEvent(Appointment calenderAppointment, bool addDescription,
            bool addReminder, bool addAttendees, IDictionary<string, object> calendarSpecificData);

        Task<bool> DeleteCalendarEvent(Appointment calendarAppointment, IDictionary<string, object> calendarSpecificData);

        Task<bool> DeleteCalendarEvent(List<Appointment> calendarAppointments, IDictionary<string, object> calendarSpecificData);

        Task<List<Appointment>> GetCalendarEventsInRangeAsync(int daysInPast, int daysInFuture, IDictionary<string, object> calendarSpecificData);

        Task<bool> AddCalendarEvent(List<Appointment> calenderAppointments, bool addDescription,
            bool addReminder, bool addAttendees, IDictionary<string, object> calendarSpecificData);

        void CheckCalendarSpecificData(IDictionary<string, object> calendarSpecificData);
    }
}