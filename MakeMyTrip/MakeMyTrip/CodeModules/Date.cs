/*
 * Created by Ranorex
 * User: jpalavalasa
 * Date: 8/11/2025
 * Time: 3:52 PM
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

namespace MakeMyTrip.CodeModules
{
    /// <summary>
    /// Description of Date.
    /// </summary>
    [TestModule("0EDB491E-5E1F-4FFC-84C1-9C0B9DEFE633", ModuleType.UserCode, 1)]
    public class Date : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Date()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
        
        string _curDate = "";
        [TestVariable("00ccca45-8107-43a9-9f60-3a8a5cccacaf")]
        public string curDate
        {
        	get { return _curDate; }
        	set { _curDate = value; }
        }
        
    }
}
