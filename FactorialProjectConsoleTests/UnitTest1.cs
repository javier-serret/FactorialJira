using System.Diagnostics; using Microsoft.VisualStudio.TestTools.UnitTesting;  namespace FactorialProjectConsoleTests {     [TestClass]     public class UnitTest1     {         [TestMethod]         public void TestMethod1()         {             // Part 1: use ProcessStartInfo class.             ProcessStartInfo startInfo = new ProcessStartInfo();             startInfo.CreateNoWindow = false;             startInfo.UseShellExecute = false;             startInfo.FileName = "FactorialJiraConsole.exe";             startInfo.WindowStyle = ProcessWindowStyle.Hidden;              // Part 2: set arguments.             startInfo.Arguments = "0";              // Part 3: start with the info we specified.             // ... Call WaitForExit.             using (Process exeProcess = Process.Start(startInfo))             {                     exeProcess.WaitForExit();                     Assert.AreEqual(1, exeProcess.StandardOutput.ReadToEnd());             }                      }     } } 