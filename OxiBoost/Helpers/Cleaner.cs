using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Oxiboost.Helpers
{
    class Cleaner
    {
        public enum RecycleFlag : int
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000001,
            SHERB_NOSOUND = 0x00000004
        }

        [DllImport("Shell32.dll")]
        static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlag dwFlags);

        public static readonly string System32Folder = Environment.GetFolderPath(Environment.SpecialFolder.System);
        public static readonly string TempFolder = Path.GetTempPath();
        public static readonly string ProfileAppDataRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static readonly string ProgramData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        public static readonly string ProfileAppDataLocal = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static readonly string ProfileAppDataLocalLow = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low";
        public static readonly string OSDrive = System32Folder.Substring(0, 3);
        public static readonly string OSDriveWindows = Environment.GetEnvironmentVariable("WINDIR", EnvironmentVariableTarget.Machine);
        public static readonly string UTorrentCache = ProfileAppDataRoaming + "\\uTorrent\\dlimagecache";

        public void EmptyFolder(string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);

                foreach (FileInfo file in di.GetFiles())
                {
                    try
                    {
                        file.IsReadOnly = false;
                        file.Delete();
                    }
                    catch { }
                }

                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch { }
                }
            }
            catch { }
        }

        public void EmptyRecycleBin()
        {
            SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlag.SHERB_NOSOUND | RecycleFlag.SHERB_NOCONFIRMATION);
        }

        public void CleanTemporaries()
        {
            EmptyFolder(TempFolder);
        }

        public void CleanUTorrent()
        {
            EmptyFolder(UTorrentCache);
        }

        public void CleanMiniDumps()
        {
            EmptyFolder(OSDriveWindows + "\\Minidump");
        }

        public void CleanErrorReports()
        {
            EmptyFolder(ProfileAppDataLocal + "\\Microsoft\\Windows\\WER\\ReportArchive");
            EmptyFolder(ProfileAppDataLocal + "\\Microsoft\\Windows\\WER\\ReportQueue");
            EmptyFolder(ProfileAppDataLocal + "\\Microsoft\\Windows\\WER\\Temp");
            EmptyFolder(ProfileAppDataLocal + "\\Microsoft\\Windows\\WER\\ERC");
            EmptyFolder(ProgramData + "\\Microsoft\\Windows\\WER\\ReportArchive");
            EmptyFolder(ProgramData + "\\Microsoft\\Windows\\WER\\ReportQueue");
            EmptyFolder(ProgramData + "\\Microsoft\\Windows\\WER\\Temp");
            EmptyFolder(ProgramData + "\\Microsoft\\Windows\\WER\\ERC");
        }

        public void CleanPrefetch()
        {
            EmptyFolder(OSDriveWindows + "\\Prefetch");
        }

        public void CleanMediaPlayersCache()
        {
            EmptyFolder(ProfileAppDataLocal + "\\Microsoft\\Media Player");
            EmptyFolder(ProfileAppDataLocalLow + "\\Apple Computer\\QuickTime\\downloads");
            EmptyFolder(ProfileAppDataRoaming + "\\Macromedia");

            try
            {
                File.Delete(ProfileAppDataLocalLow + "\\Apple Computer\\QuickTime\\QTPlayerSession.xml");
            }
            catch { }
        }

        public void CleanLogs()
        {
            EmptyFolder(System32Folder + "\\LogFiles");
            EmptyFolder(OSDrive + "\\inetpub\\logs\\LogFiles");
        }
    }
}
