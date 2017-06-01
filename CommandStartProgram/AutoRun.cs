using System;
using Microsoft.Win32;

namespace CommandStartProgram
{
    class AutoRun
    {
        private static RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true) == null ? 
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run") : 
            Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
        
        public static void setAutoRun(string appName, string fileName, bool isAutoRun)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true) == null ?
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run") :
            Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            try
            {
                if (!System.IO.File.Exists(fileName))
                    throw new Exception("该文件不存在!");
                if (isAutoRun)
                {
                    reg.SetValue(appName, fileName);
                }
                else
                {
                    reg.DeleteValue(appName);
                }
            }
            finally
            {
                if (reg != null)
                    reg.Close();
            }
        }

        public static bool isAutoRun(String appName, String fileName)
        {
            try
            {
                String path = (String)reg.GetValue(appName);
                if (path == null)
                {
                    return false;
                }
                if(path == fileName)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
