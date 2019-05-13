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
namespace AutomationSQLdm.BVT.TC_722031
{
    
    [TestModule("78C6C30B-9E73-4E33-B0B8-F4571D564A75", ModuleType.UserCode, 1)]
    public class VerifydatacollectionhappensononaninstanceconnectedwithuserwithoutsysadminpermissionandshowsdataonProcedureCachescreen : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifydatacollectionhappensononaninstanceconnectedwithuserwithoutsysadminpermissionandshowsdataonProcedureCachescreen()
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
        		//Steps.RightClickOnServer(Config.ServerOptions_CMWIN2016S8);
        		//Steps.ClickProperties();
        	    //Steps.TestSQLAuthentication();
        		Steps.SelectRequiredServer(Config.ServerOptions_CMWIN2016S8);
        		Steps.ClickOnResourcesTab();
        		Steps.ClickOnProcedureCacheInResourcesTab();
        		Steps.VerifyProcedureCacheInResources();
        	} 
        	catch (Exception ex)
        	{
        		Reports.ReportLog(ex.Message, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
        	}
        	return true;
        }
    }
}
