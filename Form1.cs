using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuBeatmapManagement
{
    public partial class Form1 : Form
    {
        string osuDirLoc = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\osu!\Songs";
        string backLoc_Img = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\osuBackup_Background";
        string backLoc_Video = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\osuBackup_Video";

        public Form1()
        {
            InitializeComponent();
        }

        private void but_BackDel_Click(object sender, EventArgs e)
        {

            if (Directory.Exists(osuDirLoc))
            {
                DirectoryInfo osuDirInfo = new DirectoryInfo(osuDirLoc);

                foreach(var item in osuDirInfo.GetDirectories())
                {
                    var files = Directory.GetFiles(item.FullName, "*.*", SearchOption.AllDirectories)
                        .Where(s => s.EndsWith(".jpg") || s.EndsWith(".png"));
                    string[] imgFiles = files.ToArray();

                    for (int i = 0; i < imgFiles.Length; i++)
                    {
                        string fileName = GetFileName(imgFiles[i], imgFiles[i].Length - 1);

                        if (check_Backbackup.Checked)
                        {
                            Directory.CreateDirectory(backLoc_Img + @"\" + item.Name);
                            File.Copy(imgFiles[i], backLoc_Img + @"\" + item.Name + @"\" + fileName, true);
                        }

                        File.Delete(imgFiles[i]);
                    }
                }

                MessageBox.Show("삭제가 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("파일이 존재하지 않습니다.");
            }
        }

        private void But_VideoDel_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(osuDirLoc))
            {
                DirectoryInfo osuDirInfo = new DirectoryInfo(osuDirLoc);

                foreach (var item in osuDirInfo.GetDirectories())
                {
                    string[] files = Directory.GetFiles(item.FullName, "*.avi");

                    for (int i = 0; i < files.Length; i++)
                    {
                        string fileName = GetFileName(files[i], files[i].Length - 1);

                        if (check_VideoBackup.Checked)
                        {
                            Directory.CreateDirectory(backLoc_Video + @"\" + item.Name);
                            File.Copy(files[i], backLoc_Video + @"\" + item.Name + @"\" + fileName, true);
                        }

                        File.Delete(files[i]);
                    }
                }

                MessageBox.Show("삭제가 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("파일이 존재하지 않습니다.");
            }
        }

        private void but_BackBackup_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(osuDirLoc) && Directory.Exists(backLoc_Img))
            {
                int pasteCount = 0;
                string[] osuDirs = Directory.GetDirectories(osuDirLoc);
                string[] backupDirs = Directory.GetDirectories(backLoc_Img);
                DirectoryInfo backupInfo = new DirectoryInfo(backLoc_Img);

                foreach (var item in backupInfo.GetDirectories())
                {
                    var files = Directory.GetFiles(item.FullName, "*.*", SearchOption.AllDirectories)
                        .Where(s => s.EndsWith(".jpg") || s.EndsWith(".png"));
                    string[] imgFiles = files.ToArray();

                    if (imgFiles.Length == osuDirLoc.Length)
                    {
                        MessageBox.Show("오수 맵 : " + osuDirs.Length.ToString());
                        MessageBox.Show("복구 맵 : " + backupDirs.Length.ToString());
                        break;
                    }

                    for (int i = 0; i < imgFiles.Length; i++)
                    {
                        string fileName = GetFileName(imgFiles[i], imgFiles[i].Length - 1);
                        File.Copy(imgFiles[i], osuDirs[pasteCount] + @"\" + fileName);
                    }

                    pasteCount += 1;
                }

                MessageBox.Show("복구가 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("파일이 존재하지 않습니다.");
            }
        }

        private string GetFileName(string imgName, int len)
        {
            string fileName = "";
            List<string> fileChars = new List<string>();

            while (true)
            {
                if (imgName[len].ToString().Equals(@"\"))
                {
                    break;
                }
                fileChars.Add(imgName[len].ToString());
                len--;
            }

            for (int k = fileChars.Count - 1; k >= 0; k--)
            {
                fileName += fileChars[k];
            }

            return fileName;
        }

    }
}
