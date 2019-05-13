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

namespace AutomationSQLdm.BVT.TC_722030
{
    
    [TestModule("20112678-EA54-4439-934A-3F2C33E0FB0A", ModuleType.UserCode, 1)]
    public class VerifydatacollectionhappensonaninstanceconnectedwithuserwithoutsysadminpermissionandshowsdataonFileActivityscreen :Base.BaseClass, ITestModule
    {
        
        public VerifydatacollectionhappensonaninstanceconnectedwithuserwithoutsysadminpermissionandshowsdataonFileActivityscreen()
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
        		Steps.ClickOnResourcesTab();
        		Steps.ClickOnFileActivityInResourcesTab();        		
        		Steps.VerifyFileActivityInResources();        		        
        	} 
        	catch (Exception ex)
        	{
        		Reports.ReportLog(ex.Message, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
        	}
        	return true;
        }
        
    }
}
