using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KModule
{
    public partial class MainForm : Form
    {
        List<PartConfig> _parts;
        List<ModuleConfig> _modules;
        string _kspDirectory = Environment.CurrentDirectory;

        public MainForm()
        {
            InitializeComponent();
            buttonMinimise.LeftClick += buttonMinimise_LeftClick;
            buttonClose.LeftClick += buttonClose_Clicked;

            if (!File.Exists("KSP.exe"))
            {
                MessageBox.Show("This application must be placed with the KSP executable.");
                this.Close();
            }

            LoadParts();
            LoadModules();

            DrawParts();
            DrawModules();
        }

        private void LoadParts()
        {
            _parts = new List<PartConfig>();

            foreach (string partDirectory in Directory.GetDirectories(_kspDirectory + @"\Parts"))
            {
                _parts.Add(new PartConfig(partDirectory + @"\part.cfg"));
            }
        }

        private void LoadModules()
        {
            _modules = new List<ModuleConfig>();

            foreach (string moduleConfig in Directory.GetFiles(Environment.CurrentDirectory, "*.cfg"))
            {
                _modules.Add(new ModuleConfig(moduleConfig));
            }
        }

        void buttonMinimise_LeftClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void buttonClose_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listModules.SelectedIndex;

            if (index > -1)
            {
                DrawParts(_modules[index].Name, _modules[index].PartNames);
            }
        }

        private void DrawModules()
        {
            int index = listModules.SelectedIndex;
            listModules.Items.Clear();

            foreach (ModuleConfig module in _modules)
            {
                listModules.Items.Add(module.Name);
            }

            listModules.SelectedIndex = index;
        }

        private void DrawParts()
        {
            DrawParts("");
        }

        private void DrawParts(string module, List<string> partNames = null)
        {
            int index = listParts.SelectedIndex;
            listParts.Items.Clear();

            foreach (PartConfig part in _parts)
            {
                if (part.Modules.Contains(module))
                {
                    listParts.Items.Add(" + " + part.Name);
                }
                else
                {
                    bool partAdded = false;
                    if (partNames != null)
                    {
                        foreach (string partName in partNames)
                        {
                            if (part.Name == partName)
                            {
                                listParts.Items.Add(" - " + part.Name);
                                partAdded = true;
                                break;
                            }
                        }
                    }

                    if (!partAdded)
                    {
                        listParts.Items.Add(part.Name);
                    }
                }
            }

            listParts.SelectedIndex = index;
        }

        private void listParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int partIndex = listParts.SelectedIndex;
            int moduleIndex = listModules.SelectedIndex;

            if (partIndex > -1 && moduleIndex > -1)
            {
                if (!_parts[partIndex].Modules.Contains(_modules[moduleIndex].Name))
                {
                    buttonInstall.Enabled = true;
                    buttonUninstall.Enabled = false;
                }
                else
                {
                    buttonInstall.Enabled = false;
                    buttonUninstall.Enabled = true;
                }
            }
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            int partIndex = listParts.SelectedIndex;
            int moduleIndex = listModules.SelectedIndex;

            if (partIndex > -1 && moduleIndex > -1)
            {
                PartConfig part = _parts[partIndex];
                ModuleConfig module = _modules[moduleIndex];

                part.AddModule(module.GetModule(part.Name));

                LoadParts();
                DrawParts(module.Name, module.PartNames);
            }
        }

        private void buttonUninstall_Click(object sender, EventArgs e)
        {
            int partIndex = listParts.SelectedIndex;
            int moduleIndex = listModules.SelectedIndex;

            if (partIndex > -1 && moduleIndex > -1)
            {
                PartConfig part = _parts[partIndex];
                ModuleConfig module = _modules[moduleIndex];

                part.RemoveModule(module.Name);

                LoadParts();
                DrawParts(module.Name, module.PartNames);
            }
        }
    }
}
