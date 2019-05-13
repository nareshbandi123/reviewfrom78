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


namespace AutomationSQLdm.BVT.TC_722150
{
    
    [TestModule("7414CCF1-184C-4714-833E-6F757212BC5B", ModuleType.UserCode, 1)]
    public class VerifyQueriesQueryHistoryviewisDisplayedSuccessfully :Base.BaseClass, ITestModule
    {
        
        public VerifyQueriesQueryHistoryviewisDisplayedSuccessfully()
        {
            
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
        		Steps.ClickOnQueriesTab();
        		Steps.VerifySignatureModeIsDisplayed();
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
