using System;
using System.Drawing;
using System.Windows.Forms;
using MeowDSIO;
using MeowDSIO.DataFiles;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace DarkSoulsAllBlackPhantoms
{
    public partial class Form1 : Form
    {
        string gameDirectory = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //check if running exe from data directory
            gameDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            if (File.Exists(gameDirectory + (radioButtonRemastered.Checked ? "\\DarkSoulsRemastered.exe" : "\\DARKSOULS.exe")))
            {
                //exe is in a valid game directory, just use this as the path instead of asking for input
                txtGamePath.Text = gameDirectory;
                txtGamePath.ReadOnly = true;

                if (!File.Exists(gameDirectory + "\\param\\GameParam\\GameParam.parambnd" + (radioButtonRemastered.Checked ? ".dcx" : "")))
                {
                    if (radioButtonRemastered.Checked)
                    {
                        //invalid directory
                        lblMessage.Text = "Invalid Dark Souls: Remastered game directory; No GameParam found.";
                    }
                    else
                    {
                        //user hasn't unpacked their game
                        lblMessage.Text = "You don't seem to have an unpacked Dark Souls: Prepare to Die Edition installation. Please run UDSFM and come back :)";
                    }
                    lblMessage.Visible = true;
                    lblMessage.ForeColor = Color.Red;
                }
            }
        }

        private void btnOpenFolderDialog_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtGamePath.Text = dialog.FileName;
                gameDirectory = dialog.FileName;

                lblMessage.Text = "";
                lblMessage.Visible = true;

                if (!File.Exists(gameDirectory + (radioButtonRemastered.Checked ? "\\DarkSoulsRemastered.exe" : "\\DARKSOULS.exe")))
                {
                    lblMessage.Text = $"Not a valid {(radioButtonRemastered.Checked ? "Dark Souls: Remastered" : "Dark Souls: Prepare to Die Edition")} Data directory. Make sure you have the correct version selected in the bottom left.";
                    lblMessage.ForeColor = Color.Red;
                    return;
                }
                else if (!File.Exists(gameDirectory + "\\param\\GameParam\\GameParam.parambnd" + (radioButtonRemastered.Checked ? ".dcx" : "")))
                {
                    if (radioButtonRemastered.Checked)
                    {
                        //invalid directory
                        lblMessage.Text = "Invalid Dark Souls: Remastered game directory; No GameParam found.";
                    }
                    else
                    {
                        //user hasn't unpacked their game
                        lblMessage.Text = "You don't seem to have an unpacked Dark Souls: Prepare to Die Edition installation. Please run UDSFM and come back :)";
                    }
                    lblMessage.ForeColor = Color.Red;
                    return;
                }
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            //check that entered path is valid
            gameDirectory = txtGamePath.Text;

            //reset message label
            lblMessage.Text = "";
            lblMessage.ForeColor = new Color();
            lblMessage.Visible = true;

            // Check for a valid Dark Souls installation + GameParam file
            if (!File.Exists(gameDirectory + (radioButtonRemastered.Checked ? "\\DarkSoulsRemastered.exe" : "\\DARKSOULS.exe")))
            {
                lblMessage.Text = $"Not a valid {(radioButtonRemastered.Checked ? "Dark Souls: Remastered" : "Dark Souls: Prepare to Die Edition")} Data directory. Make sure you have the correct version selected in the bottom left.";
                lblMessage.ForeColor = Color.Red;
                return;
            }
            else if (!File.Exists(gameDirectory + "\\param\\GameParam\\GameParam.parambnd" + (radioButtonRemastered.Checked ? ".dcx" : "")))
            {
                if (radioButtonRemastered.Checked)
                {
                    //invalid directory
                    lblMessage.Text = "Invalid Dark Souls: Remastered game directory; No GameParam found.";
                }
                else
                {
                    //user hasn't unpacked their game
                    lblMessage.Text = "You don't seem to have an unpacked Dark Souls: Prepare to Die Edition installation. Please run UDSFM and come back :)";
                }
                lblMessage.ForeColor = Color.Red;
                return;
            }

            //update label on a new thread
            Progress<string> progress = new Progress<string>(s => lblMessage.Text = s);
            await Task.Factory.StartNew(() => UiThread.WriteToInfoLabel(progress));

            //create backup of GameParam file
            if (!File.Exists(gameDirectory + $"\\param\\GameParam\\GameParam.parambnd{(radioButtonRemastered.Checked ? ".dcx" : "")}.bak"))
            {
                File.Copy(gameDirectory + $"\\param\\GameParam\\GameParam.parambnd{(radioButtonRemastered.Checked ? ".dcx" : "")}",
                    gameDirectory + $"\\param\\GameParam\\GameParam.parambnd{(radioButtonRemastered.Checked ? ".dcx" : "")}.bak");
                lblMessage.Text = $"Backed up GameParam.parambnd{(radioButtonRemastered.Checked ? ".dcx" : "")} \n\n";
                lblMessage.ForeColor = Color.Black;
                lblMessage.Visible = true;
            }

            PARAMBND gameparamBnd = DataFile.LoadFromFile<PARAMBND>(gameDirectory + $"\\param\\GameParam\\GameParam.parambnd{(radioButtonRemastered.Checked ? ".dcx" : "")}");

            gameparamBnd.ApplyDefaultParamDefs();

            // Main logic
            foreach (var paramBndEntry in gameparamBnd)
            {
                var paramShortName = paramBndEntry.Name;
                var paramFile = paramBndEntry.Param;
                if (paramFile.ID == "NPC_PARAM_ST")
                {
                    foreach (MeowDSIO.DataTypes.PARAM.ParamRow paramRow in paramFile.Entries)
                    {
                        foreach (MeowDSIO.DataTypes.PARAM.ParamCellValueRef cell in paramRow.Cells)
                        {
                            if (cell.Def.Name.StartsWith("spEffectID6"))
                            {
                                // Black phantom enemies have the effect `7100` in their `Special Effect ID 6` slot, which gives them their stat buffs.
                                // TODO Since this blindly overwrites other special effect IDs, this may have some unforeseen effects.
                                Type type = cell.GetType();
                                PropertyInfo prop = type.GetProperty("Value");
                                prop.SetValue(cell, 7100, null);
                            }
                            else if (cell.Def.Name.StartsWith("disableInitializeDead"))
                            {
                                // Black phantom enemies have `disableInitializeDead = TRUE`, which means they respawn when you quit and reload.
                                Type type = cell.GetType();
                                PropertyInfo prop = type.GetProperty("Value");
                                prop.SetValue(cell, true, null);
                            }
                            else if (cell.Def.Name.StartsWith("drawType"))
                            {
                                // Black phantom enemies have `DrawType` 2, which gives them their unique appearance.
                                Type type = cell.GetType();
                                PropertyInfo prop = type.GetProperty("Value");
                                prop.SetValue(cell, 2, null);
                            }
                        }
                    }
                }
            }

            //repack param files
            DataFile.Resave(gameparamBnd);

            lblMessage.Text += "Complete!";
            lblMessage.ForeColor = Color.Black;
            lblMessage.Visible = true;
        }

        class UiThread
        {
            public static void WriteToInfoLabel(IProgress<string> progress)
            {
                //why is this necessary
                //without the loop it doesnt run async
                for (var i = 0; i < 5; i++)
                {
                    Task.Delay(10).Wait();
                    progress.Report("Working...\n\n");
                }
            }
        }

        private void radioButtonRemastered_CheckedChanged(object sender, EventArgs e)
        {
            //check that entered path is valid
            gameDirectory = txtGamePath.Text;

            //reset message label
            lblMessage.Text = "";
            lblMessage.ForeColor = new Color();
            lblMessage.Visible = true;

            if (!File.Exists(gameDirectory + (radioButtonRemastered.Checked ? "\\DarkSoulsRemastered.exe" : "\\DARKSOULS.exe")))
            {
                lblMessage.Text = $"Not a valid {(radioButtonRemastered.Checked ? "Dark Souls: Remastered" : "Dark Souls: Prepare to Die Edition")} Data directory. Make sure you have the correct version selected in the bottom left.";
                lblMessage.ForeColor = Color.Red;
                return;
            }
            else if (!File.Exists(gameDirectory + "\\param\\GameParam\\GameParam.parambnd" + (radioButtonRemastered.Checked ? ".dcx" : "")))
            {
                if (radioButtonRemastered.Checked)
                {
                    //invalid directory
                    lblMessage.Text = "Invalid Dark Souls: Remastered game directory; No GameParam found.";
                }
                else
                {
                    //user hasn't unpacked their game
                    lblMessage.Text = "You don't seem to have an unpacked Dark Souls: Prepare to Die Edition installation. Please run UDSFM and come back :)";
                }
                lblMessage.ForeColor = Color.Red;
                return;
            }
        }

        private void tooltip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void radioButtonPTDE_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBoxBuffs_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
