﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarSyncPlus.Domain.Models;
using CalendarSyncPlus.Domain.Models.Preferences;
using CalendarSyncPlus.Domain.Wrappers;
using CalendarSyncPlus.SyncEngine.Interfaces;

namespace CalendarSyncPlus.SyncEngine
{
    [Export(typeof(ITaskSyncEngine))]
    public class TaskSyncEngine : ITaskSyncEngine
    {
        public List<ReminderTask> SourceTasksToUpdate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<ReminderTask> SourceOrphanEntries
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<ReminderTask> SourceTasksToDelete
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<ReminderTask> SourceTasksToAdd
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<ReminderTask> DestTasksToUpdate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<ReminderTask> DestTasksToDelete
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<ReminderTask> DestTasksToAdd
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<ReminderTask> DestOrphanEntries
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool GetSourceEntriesToDelete(TaskSyncProfile syncProfile, TasksWrapper sourceList, TasksWrapper destinationList)
        {
            throw new NotImplementedException();
        }

        public bool GetSourceEntriesToAdd(TaskSyncProfile syncProfile, TasksWrapper sourceList, TasksWrapper destinationList)
        {
            throw new NotImplementedException();
        }

        public bool GetDestEntriesToDelete(TaskSyncProfile syncProfile, TasksWrapper sourceList, TasksWrapper destinationList)
        {
            throw new NotImplementedException();
        }

        public bool GetDestEntriesToAdd(TaskSyncProfile syncProfile, TasksWrapper sourceList, TasksWrapper destinationList)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}