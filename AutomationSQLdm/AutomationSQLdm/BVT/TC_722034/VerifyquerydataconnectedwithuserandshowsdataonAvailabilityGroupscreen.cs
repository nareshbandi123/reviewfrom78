﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using AutomationSQLdm.Commons;
using AutomationSQLdm.Configuration;

namespace AutomationSQLdm.BVT.TC_722034
{
   
    [TestModule("6DCCB0FB-3707-4D0F-A93A-F63BC3B77B3C", ModuleType.UserCode, 1)]
    public class VerifyquerydataconnectedwithuserandshowsdataonAvailabilityGroupscreen :Base.BaseClass, ITestModule
    {
        
        public VerifyquerydataconnectedwithuserandshowsdataonAvailabilityGroupscreen()
        {
            // Do not delete - a parameterless constructor is required!
        }

        void ITestModule.Run()
        {
         	StartProcess();
        }
        
        bool StartProcess()
        {
        	try 
        	{
        		Steps.RightClickOnServer(Config.ServerOptions_CMWIN2016S8);
        		Steps.ClickProperties();
        	    Steps.TestSQLAuthentication();
        		Steps.SelectRequiredServer(Config.ServerOptions_CMWIN2016S8);
        		Steps.ClickOnDataBasesTab();
        		Steps.ClickOnAvailabilityGroupInDB();
        		Steps.VerifyAvailabilityGroupInDatabases();
        	} 
        	catch (Exception ex)
        	{
        		Reports.ReportLog(ex.Message, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
        	}
        	return true;
        }
    }
}
