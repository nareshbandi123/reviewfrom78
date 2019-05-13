﻿/*
 * Created by Ranorex
 * User: administrator
 * Date: 4/23/2019
 * Time: 4:05 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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
namespace AutomationSQLdm.BVT.TC_722037
{
   
    [TestModule("3E9BEFBC-CA51-40B7-A52C-2D01F5C6C717", ModuleType.UserCode, 1)]
    public class VerifyquerydatacollectionhappensandshowsdataonFilesscreen :Base.BaseClass, ITestModule
    {
        
        public VerifyquerydatacollectionhappensandshowsdataonFilesscreen()
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
        		Steps.ClickOnFilesInDB();
        		Steps.VerifyFilesInDataBases();
        	} 
        	catch (Exception ex)
        	{
        		Reports.ReportLog(ex.Message, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
        	}
        	return true;
        }
    }
}
