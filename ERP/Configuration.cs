using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ERP
{
    /// <summary>
    /// 应用程序配置文件读写类
    /// </summary>
    public static class Configuration
    {

        [DllImport("kernel32")]
        private static extern void WritePrivateProfileString(string section, string key, string value, string filePath);

        [DllImport("kernel32")]
        private static extern void GetPrivateProfileString(string section, string key, string def, StringBuilder retval, int size, string filePath);

        private static string path = System.Windows.Forms.Application.StartupPath + @"\ERP.ini";

        /// <summary>
        /// 更新属性值，键名不存在会自动创建
        /// </summary>
        /// <param name="section">区域名</param>
        /// <param name="key">键名</param>
        /// <param name="value">值内容<param>
        public static void Set(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, path);
        }

        /// <summary>
        /// 获取属性值
        /// </summary>
        /// <param name="section">区域名</param>
        /// <param name="key">键名</param>
        /// <returns></returns>
        public static string Get(string section, string key)
        {
            StringBuilder str = new StringBuilder(2048);
            GetPrivateProfileString(section, key, "", str, 2048, path);
            return str.ToString();
            
        }

    }
}

