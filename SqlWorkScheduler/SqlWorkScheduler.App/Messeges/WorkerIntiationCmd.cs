﻿namespace SqlWorkScheduler.App.Messeges
{
    public class WorkerIntiationCmd
    {
        public string Id { get; private set; }

        public WorkerIntiationCmd(string id)
        {
            Id = id;

        }
    }
}