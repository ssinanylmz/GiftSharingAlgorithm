using System;
using System.IO;

namespace GiftSharingAlgorithm.Methods
{
    public class FileManager
    {
        public static bool WriteLog(string strFileName, string strMessage)
        {
            try
            {
                FileStream filestream = new FileStream(string.Format("{0}\\{1}", "/Users/macos/Desktop/", strFileName), FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter((Stream)filestream);
                streamWriter.WriteLine(strMessage);
                streamWriter.Close();
                filestream.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
