using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Forms;

namespace Mytool
{
    public partial class Form1 : DarkForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            string[] split = input.Split('-');
            string result = "";
            for (int i = 0; i < split.Length; i++)
            {
                result += split[i].First().ToString().ToUpper() + split[i].Substring(1);
            }
            return result;
        }

        private string createContentComponent(string name)
        {
            string componentName = FirstCharToUpper(name);
            string content = "/*\n" +
"| --------------------------------------------------------------------------\n" +
"| " + name.ToUpper() + "\n" +
"| Author : duchuy\n" +
"| Date : " + DateTime.Now.ToString("dd-MM-yyyy") + "\n" +
"| --------------------------------------------------------------------------\n" +
"*/\n" +
"define((require) => {\n" +
"    /*\n" +
"    |--------------------------------------------------------------------------\n" +
"    | LIBRARIES\n" +
"    |--------------------------------------------------------------------------\n" +
"    */\n" +
"    const $ = require('jquery');\n" +
"    const _ = require('lodash');\n" +
"    const Backbone = require('backbone');\n" +
"    const kb = require('knockback');\n" +
"    const { ko } = kb;\n" +
"    const ajax = require('ajax');\n" +
"    const html = require('text!./" + name + ".html');\n" +
"\n" +
"    const " + componentName + " = kb.ViewModel.extend({\n" +
"        constructor: function () {\n" +
"            const self = this;\n" +
"        },\n" +
"    });\n" +
"\n" +
"    /*\n" +
"    |--------------------------------------------------------------------------\n" +
"    | REGISTER COMPONENT\n" +
"    |--------------------------------------------------------------------------\n" +
"    */\n" +
"    ko.components.register('" + name + "', {\n" +
"        viewModel:\n" +
"        {\n" +
"            createViewModel: function (params, componentInfo) {\n" +
"                return new " + componentName + "(params, componentInfo);\n" +
"            },\n" +
"        },\n" +
"        template: html,\n" +
"    });\n" +
"});";

            return content;
        }

        private void btnCreateComponent_Click(object sender, EventArgs e)
        {
            string name = txtComponentName.Text == "" ? "component" : txtComponentName.Text;
            System.IO.Directory.CreateDirectory(@"C:\Users\user\Desktop\" + name);
            string pathJs = @"C:\Users\user\Desktop\" + name + "\\" + name + ".js";
            string pathHtml = @"C:\Users\user\Desktop\" + name + "\\" + name + ".html";
            if (!File.Exists(pathJs))
            {
                File.Create(pathJs).Dispose();

                using (TextWriter tw = new StreamWriter(pathJs))
                {
                    tw.WriteLine(createContentComponent(name));
                }

            }
            else if (File.Exists(pathJs))
            {
                using (TextWriter tw = new StreamWriter(pathJs))
                {
                    tw.WriteLine(createContentComponent(name));
                }
            }

            if (!File.Exists(pathHtml))
            {
                File.Create(pathHtml).Dispose();

                using (TextWriter tw = new StreamWriter(pathHtml))
                {
                    tw.WriteLine("<!-- html " + name.ToUpper() + " -->");
                }

            }
            else if (File.Exists(pathHtml))
            {
                using (TextWriter tw = new StreamWriter(pathHtml))
                {
                    tw.WriteLine("<!-- html " + name.ToUpper() + " -->");
                }
            }

            lblInfo.Text = "Done !!!";
        }

        private void txtComponentName_Enter(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        private void btnUpcode_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtMessenger.Text);
            string messenger = txtMessenger.Text.Replace(' ', '-');
            string branch = txtBranchPush.Text;
            string source = @"b";
            if (rdiBusiness.Checked == true) source = @"b";
            else if (rdiBackend.Checked == true) source = @"e";
            else if (rdiNewsfeed.Checked == true) source = @"n";
            else if (rdiWallet.Checked == true) source = @"w";
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "D:\\script\\up-code.bat";
            proc.StartInfo.Arguments = String.Format("{0} {1} {2}", source, messenger, branch);
            proc.Start();
        }

        private void btnPullCode_Click(object sender, EventArgs e)
        {
            string source = @"b";
            string branch = txtBranchPull.Text;
            if (rdiPullBusiness.Checked == true) source = @"b";
            else if (rdiPullBackend.Checked == true) source = @"e";
            else if (rdiPullNewsfeed.Checked == true) source = @"n";
            else if (rdiPullWallet.Checked == true) source = @"w";
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "D:\\script\\pull-code.bat";
            proc.StartInfo.Arguments = String.Format("{0} {1}", source, branch);
            proc.Start();
        }

        private void btnActionDocker_Click(object sender, EventArgs e)
        {
            string action = @"restart";
            if (rdiStart.Checked == true) action = @"start";
            else if (rdiStop.Checked == true) action = @"stop";
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "D:\\script\\docker.bat";
            proc.StartInfo.Arguments = String.Format("{0}", action);
            proc.Start();
        }

        private void rdiPullBusiness_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (rdiBusiness.Checked == false) rdiBusiness.Checked = true;
        }

        private void rdiBusiness_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (rdiPullBusiness.Checked == false) rdiPullBusiness.Checked = true;
        }

        private void rdiNewsfeed_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (rdiPullNewsfeed.Checked == false) rdiPullNewsfeed.Checked = true;
        }

        private void rdiPullNewsfeed_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (rdiNewsfeed.Checked == false) rdiNewsfeed.Checked = true;
        }

        private void rdiWallet_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (rdiPullWallet.Checked == false) rdiPullWallet.Checked = true;
        }

        private void rdiPullWallet_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (rdiWallet.Checked == false) rdiWallet.Checked = true;
        }

        private void rdiBackend_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (rdiPullBackend.Checked == false) rdiPullBackend.Checked = true;
        }

        private void rdiPullBackend_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (rdiBackend.Checked == false) rdiBackend.Checked = true;
        }

        private void txtBranchPush_Leave(object sender, EventArgs e)
        {
            if (txtBranchPush.Text != "")
            {
                string branch = txtBranchPush.Text.Split('-').First();
                if (branch == "dev") txtBranchPull.Text = "develop";
                else txtBranchPull.Text = branch;
            }
        }

        private void txtBranchPull_Leave(object sender, EventArgs e)
        {
            if (txtBranchPull.Text != "")
            {
                if (txtBranchPull.Text == "develop") txtBranchPush.Text = "dev-duchuy";
                else txtBranchPush.Text = txtBranchPull.Text + "-duchuy";
            }
        }

        private void txtMessenger_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtMessenger.Text);
        }
        private void txtMessenger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnUpcode.PerformClick();
            }
        }

        private void ConsumeData(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
        }

        private void btnGetLog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            p.StartInfo.FileName = "D:\\script\\log.bat";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            p.OutputDataReceived += ConsumeData;

            try
            {
                p.Start();
                p.BeginOutputReadLine();
                p.WaitForExit();
            }
            finally
            {
                p.OutputDataReceived -= ConsumeData;
            }
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFileLanguage.Text = openFileDialog1.FileName;
            }
        }

        private string convertJsonNestedToJsonFlat(string[] lines)
        {
            string key = "";
            string valueEnter = "";

            string result = "{\n";
            foreach (string line in lines)
            {
                string[] li = line.Split(':');

                if (li.Length == 2 && li[1].Trim() == "{")
                {
                    key += (key != "" ? "." : "") + li[0].Trim();
                } else if (li.Length == 1 && li[0].Trim() == "},")
                {
                    string[] arr = key.Split('.'); // .Where((item, index) => index != 0);
                    key = String.Join(":", arr.Where((item, index) => index != arr.Length - 1).ToArray());
                } else if (valueEnter != "") {
                    valueEnter += li[0];
                    if (li[0].IndexOf('`') != -1)
                    {
                        valueEnter = valueEnter.Replace('"', '\'').Replace("\\'", "'").Replace('`', '"');
                        result += "    \"" + key + "\": " + valueEnter + "\n";
                        valueEnter = "";
                        string[] arr = key.Split('.');
                        key = String.Join(":", arr.Where((item, index) => index != arr.Length - 1).ToArray());
                    }
                } else if (li.Length >= 2 && li[0].Trim().Substring(0, 2) != "//")
                {
                    string value = String.Join(":", li.Where((item, index) => index != 0).ToArray()).Trim().Replace('"', '\'').Replace("\\'", "'");

                    if (value.IndexOf("', //") != -1)
                    {
                        value = value.Substring(0, value.IndexOf("', //") + 2);
                    }

                    if (value[0] == '\'' && value.Substring(value.Length - 2) == "',")
                    {
                        value = '"' + value.Substring(1).Replace("',", "\",");
                        result += "    \"" + key + (key != "" ? "." : "") + li[0].Trim() + "\": " + value + "\n";
                    } else if (value[0] == '`')
                    {
                        key = key + (key != "" ? "." : "") + li[0].Trim();
                        valueEnter = value;
                    } else
                    {
                        Console.WriteLine(value);
                        Console.WriteLine(value.IndexOf("', //"));
                    }
                }
            }

            return result + "}";
        }
        private void darkButton2_Click(object sender, EventArgs e)
        {
            string path = txtFileLanguage.Text;

            string[] lines = System.IO.File.ReadAllLines(path);

            string result = convertJsonNestedToJsonFlat(lines);

            string name = "vi";

            string pathJs = @"C:\Users\user\Desktop\" + name + ".json";
            if (!File.Exists(pathJs))
            {
                File.Create(pathJs).Dispose();

                using (TextWriter tw = new StreamWriter(pathJs))
                {
                    tw.WriteLine(result);
                }

            }
            else if (File.Exists(pathJs))
            {
                using (TextWriter tw = new StreamWriter(pathJs))
                {
                    tw.WriteLine(result);
                }
            }
        }

        private DarkTreeNode loadNodes(string directory)
        {
            string[] folders = System.IO.Directory.GetDirectories(directory);

            if (folders.Length == 0 || folders.Where(f => new System.IO.DirectoryInfo(f).Name == ".git").ToArray().Length != 0)
            {
                DarkTreeNode subNode = new DarkTreeNode();
                subNode.Text = new System.IO.DirectoryInfo(directory).Name;
                subNode.Tag = directory;
                return subNode;
            }

            DarkTreeNode treeNodes = new DarkTreeNode();
            treeNodes.Text = new System.IO.DirectoryInfo(directory).Name;
            treeNodes.Tag = directory;

            foreach (string folder in folders)
            {
                DarkTreeNode subNodes = loadNodes(folder);
                subNodes.Text = new System.IO.DirectoryInfo(folder).Name;
                subNodes.Tag = folder;
                treeNodes.Nodes.Add(subNodes);
            }

            return treeNodes;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            darkTreeView1.Nodes.Add(loadNodes(@"C:\HAHALOLO_REACT\"));
            darkTreeView1.Nodes[0].Expanded = true;

            string[] folders = Directory.GetDirectories(@"C:\HAHALOLO_REACT\");
            foreach (string f in folders)
            {
                cbListFolderSource.Items.Add(new System.IO.DirectoryInfo(f).Name);
            }
            cbListFolderSource.SelectedIndex = 0;
        }

        private void btnStartSerivce_Click(object sender, EventArgs e)
        {
            string[] folders = Directory.GetDirectories(@"C:\HAHALOLO_REACT\" + cbListFolderSource.Text + "\\");

            string[] foldersName = folders.Select(f => new System.IO.DirectoryInfo(f).Name).ToArray();

            string clientFolderName = foldersName[0];
            string serverFolderName = foldersName[1];

            if (foldersName[0].IndexOf("api") > -1 || foldersName[0].IndexOf("server") > -1)
            {
                clientFolderName = foldersName[1];
                serverFolderName = foldersName[0];
            }

            if (cbClient.Checked)
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "D:\\script\\start-service.bat";
                proc.StartInfo.Arguments = String.Format("{0}", @"C:\HAHALOLO_REACT\" + cbListFolderSource.Text + '\\' + clientFolderName);
                proc.Start();
            }

            if (cbServer.Checked)
            {
                System.Diagnostics.Process proc1 = new System.Diagnostics.Process();
                proc1.StartInfo.FileName = "D:\\script\\start-service.bat";
                proc1.StartInfo.Arguments = String.Format("{0}", @"C:\HAHALOLO_REACT\" + cbListFolderSource.Text + '\\' + serverFolderName);
                proc1.Start();
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtMess.Text);
            string messenger = txtMess.Text.Replace(' ', '-');

            DarkTreeNode[] nodes = darkTreeView1.SelectedNodes.ToArray();
            if (nodes.Length > 0)
            {
                string director = nodes[0].Tag.ToString();

                string[] folders = Directory.GetDirectories(director);

                if (folders.Length == 2) // double
                {
                    foreach (string f in folders)
                    {
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.StartInfo.FileName = "D:\\script\\push.bat";
                        proc.StartInfo.Arguments = String.Format("{0} {1}", f, messenger); 
                        proc.Start();
                    }
                }
                else
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = "D:\\script\\push.bat";
                    proc.StartInfo.Arguments = String.Format("{0} {1}", director, messenger);
                    proc.Start();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DarkTreeNode[] nodes = darkTreeView1.SelectedNodes.ToArray();
            if (nodes.Length > 0)
            {
                string director = nodes[0].Tag.ToString();

                string[] folders = Directory.GetDirectories(director);

                if (folders.Length == 2) // double
                {
                    foreach(string f in folders)
                    {
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.StartInfo.FileName = "D:\\script\\start-service.bat";
                        proc.StartInfo.Arguments = String.Format("{0}", f);
                        proc.Start();
                    }
                } else
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = "D:\\script\\start-service.bat";
                    proc.StartInfo.Arguments = String.Format("{0}", director);
                    proc.Start();
                }
            }
        }

        private void darkTreeView1_SelectedNodesChanged(object sender, EventArgs e)
        {
            DarkTreeNode[] nodes = darkTreeView1.SelectedNodes.ToArray();

            if (nodes.Length > 0)
            {
                nodes[0].Expanded = true;
            }
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            DarkTreeNode[] nodes = darkTreeView1.SelectedNodes.ToArray();
            if (nodes.Length > 0)
            {
                string director = nodes[0].Tag.ToString();

                string[] folders = Directory.GetDirectories(director);

                if (folders.Length == 2) // double
                {
                    foreach (string f in folders)
                    {
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.StartInfo.FileName = "D:\\script\\pull.bat";
                        proc.StartInfo.Arguments = String.Format("{0}", f);
                        proc.Start();
                    }
                }
                else
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = "D:\\script\\pull.bat";
                    proc.StartInfo.Arguments = String.Format("{0}", director);
                    proc.Start();
                }
            }
        }

        private void btnBash_Click(object sender, EventArgs e)
        {
            DarkTreeNode[] nodes = darkTreeView1.SelectedNodes.ToArray();
            if (nodes.Length > 0)
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe")
                {
                    WorkingDirectory = nodes[0].Tag.ToString(),
                    WindowStyle = ProcessWindowStyle.Normal
                };

                var process = Process.Start(processStartInfo);
                process.WaitForExit();
            }
        }
    }
}
