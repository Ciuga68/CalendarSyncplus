﻿using System.Collections.Generic;

namespace OutlookGoogleSyncRefresh.Domain.Models
{
    public class AppointmentListWrapper
    {
        public List<Appointment> Appointments { get; set; }

        public bool WaitForApplicationQuit { get; set; }

        public bool Success { get; set; }

    }
}