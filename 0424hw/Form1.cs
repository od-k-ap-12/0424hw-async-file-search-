using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _0424hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] LogicalDrives = Directory.GetLogicalDrives();
            comboBoxDisks.Items.Clear();
            foreach (string disk in LogicalDrives)
                comboBoxDisks.Items.Add(disk);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string Path = comboBoxDisks.SelectedItem.ToString();
            DirectoryInfo Directory = new DirectoryInfo(Path);
            SearchFiles(Directory);
        }
        private async void SearchFiles(DirectoryInfo Directory)
        {
            string Text;
            int Counter;
            await Task.Run(() =>
            {
                foreach (DirectoryInfo Subdirectory in Directory.GetDirectories())
                {

                    if (CheckFolderPermission(Subdirectory) == false) { continue; };
                    SearchFiles(Subdirectory);
                }
                foreach (FileInfo File in Directory.GetFiles())
                {
                    Text = System.IO.File.ReadAllText(File.FullName, Encoding.Default);
                    Counter = new Regex(textBoxFindByWordOrPhrase.Text).Matches(Text).Count;
                    string[] subitems = { File.ToString(), Convert.ToString(Counter) };
                    if (Counter > 0)
                    {
                        listViewFiles.Items.Add(File.FullName).SubItems.AddRange(subitems);
                    }
                }
            });
        }
        private bool CheckFolderPermission(DirectoryInfo Directory)
        {
            try
            {
                DirectorySecurity dirAC = Directory.GetAccessControl(AccessControlSections.All);
                return true;
            }
            catch (PrivilegeNotHeldException)
            {
                return false;
            }
        }
    }
}
