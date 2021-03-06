﻿//using UmbracoHangfire;
//using Hangfire;
//using Hangfire.Storage;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Umbraco.Core;
//using Umbraco.Core.Composing;

//namespace UmbracoHangfire
//{
//    [RuntimeLevel(MinLevel = RuntimeLevel.Boot)]
//    public class DemoJob : IComposer
//    {
//        public const string DemoJobName = "DemoJob";

//        [HangfireJob("Demo Job")]
//        public static void Execute()
//        {
//            // Add code to perform action here
//            new HangfireDbContext().SaveHistory(DemoJobName, "Demo Job Completed Successfully", DateTime.Now);
//        }

//        /// <summary>
//        /// Create job in startup of website
//        /// </summary>
//        public static void CreateRecurringJob()
//        {
//            // Create recurring job
//            RecurringJobManager manager = new RecurringJobManager();
//            RecurringJobDto job = HangfireJobForm.JobFromId(DemoJobName);
//            if (job == null)
//            {
//                RecurringJob.AddOrUpdate(DemoJobName, () => DemoJob.Execute(), "0 0 * * *", TimeZoneInfo.Local);
//            }
//        }

//        public void Compose(Composition composition)
//        {
//            HangfireStartup.HangFireStarted += HangfireStartup_HangFireStarted;
//        }

//        private void HangfireStartup_HangFireStarted(object sender, HangfireStartedArgs e)
//        {
//            CreateRecurringJob();
//        }
//    }
//}