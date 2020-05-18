using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VOX_Generator
{
    public partial class DictionaryWind : Form
    {
        public DictionaryWind()
        {
            InitializeComponent();
            dictionaryField.ScrollBars = ScrollBars.Vertical;
            dictionaryField.ReadOnly = true;

            switch (Main.type)
            {
                case "vox":
                    {
                        string path = Main.formPath + "\\vox\\";
                        titleLabel.Text = "All words available for VOX";
                        this.Text = "VOX Dictionary";

                        string[] fileNames = Directory.GetFiles(path, "*.wav")
                            .Select(Path.GetFileNameWithoutExtension).ToArray();

                        Array.Sort(fileNames);
                        foreach(string file in fileNames)
                        {
                            dictionaryField.Text += file + Environment.NewLine;
                        }
                        break;
                    }
                case "fvox":
                    {
                        string path = Main.formPath + "\\fvox\\";
                        titleLabel.Text = "All words available for the HEV Suit";
                        this.Text = "HEV Dictionary";

                        string[] fileNames = Directory.GetFiles(path, "*.wav")
                            .Select(Path.GetFileNameWithoutExtension).ToArray();

                        Array.Sort(fileNames);
                        foreach (string file in fileNames)
                        {
                            dictionaryField.Text += file + Environment.NewLine;
                        }
                        break;
                    }
                case "hgrunt":
                    {
                        string path = Main.formPath + "\\hgrunt\\";
                        titleLabel.Text = "All words available for the Human Grunt";
                        this.Text = "Human Grunt Dictionary";

                        string[] fileNames = Directory.GetFiles(path, "*.wav")
                            .Select(Path.GetFileNameWithoutExtension).ToArray();

                        Array.Sort(fileNames);
                        foreach (string file in fileNames)
                        {
                            dictionaryField.Text += file + Environment.NewLine;
                        }
                        break;
                    }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
