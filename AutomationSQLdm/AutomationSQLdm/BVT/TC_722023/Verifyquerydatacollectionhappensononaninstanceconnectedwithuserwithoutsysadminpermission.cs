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

namespace AutomationSQLdm.BVT.TC_722023
{
    
    [TestModule("96A95883-7AF7-4FB1-8564-3B6928E1662F", ModuleType.UserCode, 1)]
    public class Verifyquerydatacollectionhappensononaninstanceconnectedwithuserwithoutsysadminpermission : Base.BaseClass,ITestModule
    {
       
        public Verifyquerydatacollectionhappensononaninstanceconnectedwithuserwithoutsysadminpermission()
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
        		Steps.ClickOnQueriesTab();
        		Steps.ClickOnQueryHistory();
        		Steps.VerifyQueryHistoryIsDisplayed();
        		
        	} 
        	catch (Exception ex)
        	{
        		Reports.ReportLog(ex.Message, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
        	}
        	return true;
        }
    }
}
