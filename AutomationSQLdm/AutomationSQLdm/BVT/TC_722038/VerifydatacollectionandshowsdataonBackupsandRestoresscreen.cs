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

namespace AutomationSQLdm.BVT.TC_722038
{
   
    [TestModule("5871BEF4-B3C1-4F59-9F0E-F925B3B80486", ModuleType.UserCode, 1)]
    public class VerifydatacollectionandshowsdataonBackupsandRestoresscreen :Base.BaseClass, ITestModule
    {
       
        public VerifydatacollectionandshowsdataonBackupsandRestoresscreen()
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
        		Steps.ClickOnBackupsAndRestoresInDB();
        		Steps.VerifyBackupsAndRestoresInDataBases();
        	} 
        	catch (Exception ex)
        	{
        		Reports.ReportLog(ex.Message, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
        	}
        	return true;
        }
    }
}
