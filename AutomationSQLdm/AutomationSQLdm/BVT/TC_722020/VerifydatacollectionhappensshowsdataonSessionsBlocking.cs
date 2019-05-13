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

namespace AutomationSQLdm.BVT.TC_722020
{
    
    [TestModule("13C80A97-CA70-4EBB-8639-3B7E2272721F", ModuleType.UserCode, 1)]
    public class VerifydatacollectionhappensshowsdataonSessionsBlocking :Base.BaseClass, ITestModule
    {
        
        public VerifydatacollectionhappensshowsdataonSessionsBlocking()
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
        		Steps.ClickOnSessions();
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
