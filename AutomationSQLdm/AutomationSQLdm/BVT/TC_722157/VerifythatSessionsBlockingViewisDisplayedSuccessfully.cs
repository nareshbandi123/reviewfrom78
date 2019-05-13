﻿
using System;
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


namespace AutomationSQLdm.BVT.TC_722157
{
    
    [TestModule("AAA1CC54-C169-450A-94F6-532AA3A4C9C3", ModuleType.UserCode, 1)]
    public class VerifythatSessionsBlockingViewisDisplayedSuccessfully :Base.BaseClass, ITestModule
    {
        
        public VerifythatSessionsBlockingViewisDisplayedSuccessfully()
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
        		Steps.SelectRequiredServer(Config.ServerOptions_DEFAULTSERVER);
        		Steps.VerifyDashboardView();
        		Steps.ClickOnSessions();
        		Steps.VerifySummaryUnderSessions();
        		Steps.ClickOnBlocking();
        		Steps.VerifyBlockingUnderSessions();       		        		
        	} 
        	catch (Exception ex)
        	{
        		Reports.ReportLog(ex.Message, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
        	}
        	return true;
        }

       
    }
}
