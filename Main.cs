using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VOX_Generator
{
    public partial class Main : Form
    {
        public static string type = "vox";
        public static string formPath = Application.StartupPath;

        public Main()
        {
            try
            {
                InitializeComponent();
                logText.ScrollBars = ScrollBars.Vertical;
                logText.ReadOnly = true;
            }
            catch(Exception e)
            {
                ExceptionForm form = new ExceptionForm(e.Message);
                form.Show();
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void generateClick(object sender, EventArgs e)
        {
            if (inputSent.Text == String.Empty)
            {
                MessageBox.Show("I can't generate an empty sentence!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (vType.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid voice type! Make sure you select a voice.", "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            string rest = inputSent.Text.ToLower().Trim();

            processText(rest, rest, this);
        }

        private void quitClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //JOINS WAVE FILES TOGETHER USING NAUDIO LIBRARY
        public static void Concatenate(string outputFile, IEnumerable<string> sourceFiles)
        {
            byte[] buffer = new byte[1024];
            WaveFileWriter waveFileWriter = null;

            try
            {
                foreach (string sourceFile in sourceFiles)
                {
                    using (WaveFileReader reader = new WaveFileReader(sourceFile))
                    {
                        if (waveFileWriter == null)
                        {
                            waveFileWriter = new WaveFileWriter(outputFile, reader.WaveFormat);
                        }
                        else
                        {
                            if (!reader.WaveFormat.Equals(waveFileWriter.WaveFormat))
                            {
                                throw new InvalidOperationException("Can't concatenate a WAV file with another format!");
                            }
                        }

                        int read;
                        while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            waveFileWriter.Write(buffer, 0, read);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                ExceptionForm form = new ExceptionForm(e.Message);
                form.Show();
            }
            finally
            {
                if (waveFileWriter != null)
                {
                    waveFileWriter.Dispose();
                }
            }

        }

        //PROCESSES THE STRING AND THEN GENERATE WAV FILE
        public static void processText(string inputText, string outputFile, Main form)
        {
            bool errorStatus = true;
            string phrase = inputText;
            string[] words = phrase.Split(' ');
            int count = 0;
            string wavExt = ".wav";

            foreach (string file in words)
            {
                words[count] = words[count] + wavExt;
                words[count] = type + @"\" + words[count];

                if (!File.Exists(words[count]))
                {
                    errorStatus = true;
                    break;
                }
                else
                {
                    count++;
                    errorStatus = false;
                }
            }

            if (errorStatus == false)
            {
                List<string> list = new List<string>(words);
                IEnumerable<string> input = list;
                string path;

                switch (type)
                {
                    case "vox":
                        {
                            path = Application.StartupPath + "\\Creations\\VOX\\";
                            Concatenate(path + outputFile + wavExt, input);
                            MessageBox.Show("Done! " + "File: " + path + outputFile + wavExt,
                                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form.logText.Text += "Generated: " + path + outputFile + wavExt + Environment.NewLine;
                            path = String.Empty;
                            break;
                        }
                    case "hgrunt":
                        {
                            path = Application.StartupPath + "\\Creations\\Human Grunt\\";
                            Concatenate(path + outputFile + wavExt, input);
                            MessageBox.Show("Done! " + "File: " + path + outputFile + wavExt,
                                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form.logText.Text += "Generated: " + path + outputFile + wavExt + Environment.NewLine;
                            path = String.Empty;
                            break;
                        }
                    case "fvox":
                        {
                            path = Application.StartupPath + "\\Creations\\HEV\\";
                            Concatenate(path + outputFile + wavExt, input);
                            MessageBox.Show("Done! " + "File: " + path + outputFile + wavExt,
                                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form.logText.Text += "Generated: " + path + outputFile + wavExt + Environment.NewLine;
                            path = String.Empty;
                            break;
                        }
                }
            }
            else
            {
                string Error = "Word `" + words[count] + "` doesn't exist! Please check your spelling.";
                MessageBox.Show(Error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainLoad(object sender, EventArgs e)
        {
            vType.SelectedIndex = 0;
        }

        private void infoClick(object sender, EventArgs e)
        {
            MessageBox.Show("Manuel (AKA Aesthetical/Samm-Z) 2020.\n" +
                "Uses NAudio for using WAV files.\n" +
                "Valve Software for the Half-Life icon.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void vtypeSelectionChange(object sender, EventArgs e)
        {
            switch (vType.SelectedIndex)
            {
                case 0:
                    type = "vox";
                    break;
                case 1:
                    type = "hgrunt";
                    break;
                case 2:
                    type = "fvox";
                    break;
            }
        }

        private void dictionaryClick(object sender, EventArgs e)
        {
            DictionaryWind f2 = new DictionaryWind();
            f2.Show();
        }

        private void annihilateClick(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Are you sure you want to delete " +
                "all the generated files? " +
                "\nWARNING: All WAV files in each " +
                "Creations subfolder will be DELETED.",
                "Warning!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (box == DialogResult.Yes)
            {
                DirectoryInfo di = new DirectoryInfo(formPath + "\\Creations\\VOX");
                DirectoryInfo di2 = new DirectoryInfo(formPath + "\\Creations\\HEV");
                DirectoryInfo di3 = new DirectoryInfo(formPath + "\\Creations\\Human Grunt");

                FileInfo[] files = di.GetFiles("*.wav")
                                     .Where(p => p.Extension == ".wav").ToArray();
                FileInfo[] files2 = di2.GetFiles("*.wav")
                                     .Where(p => p.Extension == ".wav").ToArray();
                FileInfo[] files3 = di3.GetFiles("*.wav")
                                     .Where(p => p.Extension == ".wav").ToArray();
                foreach (FileInfo file in files)
                {
                    try
                    {
                        file.Attributes = FileAttributes.Normal;
                        File.Delete(file.FullName);
                    }
                    catch (IOException ioexc)
                    {
                        ExceptionForm form = new ExceptionForm(ioexc.Message);
                        form.Show();
                    }
                }
                foreach (FileInfo file in files2)
                {
                    try
                    {
                        file.Attributes = FileAttributes.Normal;
                        File.Delete(file.FullName);
                    }
                    catch (IOException ioexc)
                    {
                        ExceptionForm form = new ExceptionForm(ioexc.Message);
                        form.Show();
                    }
                }
                foreach (FileInfo file in files3)
                {
                    try
                    {
                        file.Attributes = FileAttributes.Normal;
                        File.Delete(file.FullName);
                    }
                    catch (IOException ioexc)
                    {
                        ExceptionForm form = new ExceptionForm(ioexc.Message);
                        form.Show();
                    }
                }
                logText.Text += "Cleared all user generated sentences." + Environment.NewLine;
            }
            else if (box == DialogResult.No)
            {
                return;
            }
        }

        private void closePush_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minimizeButt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
