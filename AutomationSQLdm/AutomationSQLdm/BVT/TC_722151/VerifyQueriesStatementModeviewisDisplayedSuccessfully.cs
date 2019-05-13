
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


namespace AutomationSQLdm.BVT.TC_722151
{
  
    [TestModule("2A7433F1-7C9B-4D26-88B3-87DA2EABE8A8", ModuleType.UserCode, 1)]
    public class VerifyQueriesStatementModeviewisDisplayedSuccessfully : Base.BaseClass, ITestModule
    {
        
        public VerifyQueriesStatementModeviewisDisplayedSuccessfully()
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
        		Steps.ClickOnStatementMode();
        		Steps.VerifyStatementModeIsDisplayed();
        		
        	} 
        	catch (Exception ex)
        	{
        		Reports.ReportLog(ex.Message, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
        	}
        	return true;
        }

      
    }
}
