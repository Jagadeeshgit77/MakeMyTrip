/*
 * Created by Ranorex
 * User: Planit
 * Date: 17-11-2025
 * Time: 02:59
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
    /// Description of ValidatePrices.
    /// </summary>
    [TestModule("B3AF136B-8E34-4543-919D-A26808BE0A8C", ModuleType.UserCode, 1)]
    public class ValidatePrices : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidatePrices()
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
            
            MakeMyTripRepository mmt = new MakeMyTripRepository();
            string couponApplied = mmt.MakeMyTrip.
        }
    }
}
