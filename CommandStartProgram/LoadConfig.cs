﻿using System;
using System.Text;
using System.Runtime.InteropServices;

namespace CommandStartProgram
{
    public class LoadConfig
    {
        public String iniPath;

        //声明API函数
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileSection(String section, StringBuilder buffer, int size, String fileName);

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iniPath"></param>
        public LoadConfig(String iniPath)
        {
            this.iniPath = iniPath;
            try
            {
                if (!ExistINIFile())
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(iniPath, true);
                    file.WriteLine("; Command List");
                    file.WriteLine("");
                    file.Flush();
                    file.Close();
                }
            }
            catch (System.IO.IOException e)
            {
                System.Windows.Forms.MessageBox.Show("哎呀，小精灵生病了！\n详情：" + e.Message);
            }
        }

        /// <summary> 
        /// 写入INI文件 
        /// </summary> 
        /// <param name="Section">项目名称(如 [TypeName] )</param> 
        /// <param name="Key">键</param> 
        /// <param name="Value">值</param> 
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.iniPath);
        }

        /// <summary> 
        /// 读出INI文件 
        /// </summary> 
        /// <param name="Section">项目名称(如 [TypeName] )</param> 
        /// <param name="Key">键</param> 
        public string ReadIni(string Section, string Key)
        {
            if (!ExistINIFile())
            {
                System.Windows.Forms.MessageBox.Show("ini配置文件不存在");
                Environment.Exit(0);
            }
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString(Section, Key, "", temp, 500, this.iniPath);
            return temp.ToString();
        }

        /// <summary> 
        /// 验证文件是否存在 
        /// </summary> 
        /// <returns>布尔值</returns> 
        public bool ExistINIFile()
        {
            return System.IO.File.Exists(iniPath);
        }
    }
}
