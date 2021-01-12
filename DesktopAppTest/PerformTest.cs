/*
 * Created by Ranorex
 * User: Kuba
 * Date: 1/10/2021
 * Time: 4:28 PM
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

namespace DesktopAppTest
{
    /// <summary>
    /// Description of PerformTest.
    /// </summary>
    [TestModule("447BEAC7-11BE-4D1C-A976-60F2161B3612", ModuleType.UserCode, 1)]
    public class PerformTest : ITestModule
    {
    	
    	public static DesktopAppTestRepository repo = DesktopAppTestRepository.Instance;
    	
    	CompressedImage Afx00007FF6543500008_picToCompare1
        { get { return repo.UntitledPaint.Afx00007FF6543500008Info.GetpicToCompare1(new Rectangle(0, 0, 1366, 602)); } }
    	
		Imaging.FindOptions Afx00007FF6543500008_picToCompare1_Options
        { get { return Imaging.FindOptions.Parse("0.9;None;0,0,1366,602;True;10000000;0ms"); } }

    	        
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PerformTest()
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
            
           	//Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UntitledPaint.Triangle' at 8;12.", repo.UntitledPaint.TriangleInfo, new RecordItemIndex(0));
            //repo.UntitledPaint.Triangle.Click();
            repo.UntitledPaint.Triangle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'UntitledPaint.Afx00007FF6543500008' at 265;80.", repo.UntitledPaint.Afx00007FF6543500008Info, new RecordItemIndex(1));
            repo.UntitledPaint.Afx00007FF6543500008.MoveTo("265;80");
            //repo.UntitledPaint.Self.MoveTo("265;80");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'UntitledPaint.Afx00007FF6543500008' at 13;436.", repo.UntitledPaint.Afx00007FF6543500008Info, new RecordItemIndex(2));
            repo.UntitledPaint.Afx00007FF6543500008.MoveTo("13;436");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
       
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'UntitledPaint.Afx00007FF6543500008' at 420;82.", repo.UntitledPaint.Afx00007FF6543500008Info, new RecordItemIndex(3));
            repo.UntitledPaint.Afx00007FF6543500008.MoveTo("420;82");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'UntitledPaint.Afx00007FF6543500008' at 752;455.", repo.UntitledPaint.Afx00007FF6543500008Info, new RecordItemIndex(4));
            repo.UntitledPaint.Afx00007FF6543500008.MoveTo("752;455");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(10000);
            
            //Keyboard.Press("{Escape}");
            
            Mouse.MoveTo(800, 500);
            //repo.UntitledPaint.Afx00007FF6543500008.MoveTo("800;500");
            Mouse.Click();
            
			//Validate.CompareImage(repo.UntitledPaint.Afx00007FF6543500008Info, Afx00007FF6543500008_picToCompare1, Afx00007FF6543500008_picToCompare1_Options);
            Validate.ContainsImage(repo.UntitledPaint.Afx00007FF6543500008Info, Afx00007FF6543500008_picToCompare1, Afx00007FF6543500008_picToCompare1_Options);
			
			
            //Bitmap bmpActual = Ranorex.Imaging.CaptureDesktopImage(element);
			//CompressedImage image = new CompressedImage(bmpActual, ImageFormat.Png);
			
			
			//Bitmap bmpExpected = Ranorex.Imaging.Load( @"C:\\Users\\Kuba\\Documents\\picToCompare.png"); 
 
//			Search for it within the application window 
//			if (Ranorex.Imaging.Contains(myRepo.WinFormsApp.Self,bmp) == true) 
//			{ 
//			 	Report.Success("Image found within WinForms application"); 
//			}
			
			//Ranorex.Validate.CompareImage(bmpActual, bmpExpected, "adasdA");
        }
    }
}
