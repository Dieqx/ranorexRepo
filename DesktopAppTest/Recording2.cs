﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace DesktopAppTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording2 recording.
    /// </summary>
    [TestModule("1a99a092-1d4b-48c4-a611-de7bac1225fd", ModuleType.Recording, 1)]
    public partial class Recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DesktopAppTestRepository repository.
        /// </summary>
        public static DesktopAppTestRepository repo = DesktopAppTestRepository.Instance;

        static Recording2 instance = new Recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording2 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'picToCompare1' with region {X=0,Y=0,Width=1366,Height=602}) on item 'UntitledPaint.Afx00007FF6543500008'.", repo.UntitledPaint.Afx00007FF6543500008Info, new RecordItemIndex(0));
            Validate.CompareImage(repo.UntitledPaint.Afx00007FF6543500008Info, Afx00007FF6543500008_picToCompare1, Afx00007FF6543500008_picToCompare1_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage Afx00007FF6543500008_picToCompare1
        { get { return repo.UntitledPaint.Afx00007FF6543500008Info.GetpicToCompare1(new Rectangle(0, 0, 1366, 602)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions Afx00007FF6543500008_picToCompare1_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,1366,602;True;10000000;0ms"); } }

#endregion
    }
#pragma warning restore 0436
}
