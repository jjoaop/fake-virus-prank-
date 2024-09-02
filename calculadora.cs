using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        try
        {
            DoPrank();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro: " + ex.Message);
        }
    }

    static void DoPrank()
    {
        try
        {
            Process.Start("notepad.exe");

            for (int i = 0; i < 2; i++)
            {
                Process.Start("https://accounts.google.com/");
            }


            for (int i = 0; i < 1; i++)
                {
                    string lll = "How to remove a virus?";
                    Process.Start("https://www.google.com/search?q=" + lll);  

                    string mmm = "I have virus?";
                    Process.Start("https://www.google.com/search?q=" + mmm);  

                    string sss = "Baidu antivirus download";
                    Process.Start("https://www.google.com/search?q=" + sss);  
                }

                string script0 = @"
                    result = MsgBox(""Deseja remover um virus?"", vbYesNo + vbQuestion, ""Confirmar"")
                    If result = vbYes Then
                        Set objShell = CreateObject(""WScript.Shell"")
                        objShell.Run ""https://www.google.com/search?q=How+to+remove+a+virus?""
                    End If
                ";

                string scriptFilePathX = Path.GetTempFileName() + ".vbs";
                File.WriteAllText(scriptFilePathX, script0);

                ProcessStartInfo startInfox = new ProcessStartInfo
                {
                    FileName = "wscript.exe",
                    Arguments = string.Format("\"{0}\"", scriptFilePathX),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(startInfox))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    Console.WriteLine("Output: " + output);
                    Console.WriteLine("Error: " + error);
                }

            string query = "I have virus?";
            Process.Start("https://www.google.com/search?q=" + query);

            DialogResult result = MessageBox.Show(
                "Este computador foi infectado! Windows diz: Deseja remover o virus?",
                "Warning:",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < 1; i++)
                {
                    string searchQuery = "How to remove a virus?";
                    Process.Start("https://www.google.com/search?q=" + searchQuery);  

                    string aaa = "I have virus?";
                    Process.Start("https://www.google.com/search?q=" + aaa);  

                    string aaaa = "Baidu antivirus download";
                    Process.Start("https://www.google.com/search?q=" + aaaa);  
                }

                string script = @"
                    result = MsgBox(""Deseja remover um virus?"", vbYesNo + vbQuestion, ""Confirmar"")
                    If result = vbYes Then
                        Set objShell = CreateObject(""WScript.Shell"")
                        objShell.Run ""https://www.google.com/search?q=How+to+remove+a+virus?""
                    End If
                ";

                string scriptFilePath = Path.GetTempFileName() + ".vbs";
                File.WriteAllText(scriptFilePath, script);

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "wscript.exe",
                    Arguments = string.Format("\"{0}\"", scriptFilePath),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    Console.WriteLine("Output: " + output);
                    Console.WriteLine("Error: " + error);
                }


            } else
            {
                for (int i = 0; i < 4; i++)
                {
                    string searchQuery = "How to remove a virus?";
                    Process.Start("https://www.google.com/search?q=" + searchQuery);  

                    string aaa = "I have virus?";
                    Process.Start("https://www.google.com/search?q=" + aaa);  

                    string aaaa = "Baidu antivirus download";
                    Process.Start("https://www.google.com/search?q=" + aaaa);  
                }

                string script = @"
                    result = MsgBox(""Deseja remover um virus?"", vbYesNo + vbQuestion, ""Confirmar"")
                    If result = vbYes Then
                        Set objShell = CreateObject(""WScript.Shell"")
                        objShell.Run ""https://www.google.com/search?q=How+to+remove+a+virus?""
                    End If
                ";

                string scriptFilePath = Path.GetTempFileName() + ".vbs";
                File.WriteAllText(scriptFilePath, script);

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "wscript.exe",
                    Arguments = string.Format("\"{0}\"", scriptFilePath),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    Console.WriteLine("Output: " + output);
                    Console.WriteLine("Error: " + error);
                }

            }

            for (int i = 0; i < 2; i++)
            {
                Process.Start("notepad.exe");
                Thread.Sleep(500);

                Process.Start("regedit.exe");
                Thread.Sleep(500);

            }

            Process.Start("regedit.exe");
            Thread.Sleep(500);


            for (int i = 0; i < 20; i++)
            {
                Process.Start("cmd.exe");
                Thread.Sleep(500);
            }

            Thread.Sleep(5000);

            Process.Start("shutdown", "/r /t 0");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Your desktop hacked! " + ex.Message);
        }
    }
}
