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

namespace AutomationSQLdm.BVT.TC_722035
{
   
    [TestModule("E0F020E6-5415-4EEC-9719-B60386D3B74A", ModuleType.UserCode, 1)]
    public class VerifyquerydataconnectedwithuserandshowsdataonTempdbSummaryscreen :Base.BaseClass, ITestModule
    {
        
        public VerifyquerydataconnectedwithuserandshowsdataonTempdbSummaryscreen()
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
        		Steps.RightClickOnServer(Config.ServerOptions_CMWIN2016S8);
        		Steps.ClickProperties();
        	    Steps.TestSQLAuthentication();
        		Steps.SelectRequiredServer(Config.ServerOptions_CMWIN2016S8);
        		Steps.ClickOnDataBasesTab();
        		Steps.ClickOnTempDBSummary();
        		Steps.VerifyTempDBSummaryInDataBases();
        	} 
        	catch (Exception ex)
        	{
        		Reports.ReportLog(ex.Message, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
        	}
        	return true;
        }
    }
}
