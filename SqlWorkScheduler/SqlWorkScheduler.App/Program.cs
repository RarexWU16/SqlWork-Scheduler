﻿using Akka.Actor;
using SqlWorkScheduler.App.Actors;
using SqlWorkScheduler.App.Messeges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlWorkScheduler.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = ActorSystem.Create("SqlWorkScheduler");
            var schedulerActor = system.ActorOf<WorkSchedulerActor>("WorkSchedulerActor");

            schedulerActor.Tell(new ScheduleWorkCmd("select * from Orders", TimeSpan.FromSeconds(30), "localhost:80/api/orders"));

            //schedulerActor.
            //var cancel = system.Scheduler.ScheduleTellRepeatedlyCancelable(TimeSpan.FromSeconds(50), TimeSpan.FromSeconds(50), )

            Console.ReadLine();
        }
    }
}