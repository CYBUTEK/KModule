using System;
using System.IO;
using System.Collections.Generic;
using LibConfig;

namespace KModule
{
    public class ModuleConfig
    {
        private ConfigDocument _config = new ConfigDocument();
        private List<ConfigSection> _parts = new List<ConfigSection>();
        private List<string> _partNames = new List<string>();
        private string _name = "";

        public string Name { get { return _name; } }
        public List<string> PartNames { get { return _partNames; } }

        public ModuleConfig(string filename)
        {
            _name = new FileInfo(filename).Name.Replace(".cfg", "");
            _config = new ConfigDocument(File.ReadAllLines(filename));
            _parts = _config.Sections;
            _partNames = GetModuleNames();
        }

        public ConfigSection GetModule(string partName)
        {
            foreach (ConfigSection part in _parts)
            {
                if (part.Name == partName)
                {
                    return part;
                }
            }

            return _parts[0];
        }

        private List<string> GetModuleNames()
        {
            List<string> partNames = new List<string>();

            foreach (ConfigSection part in _parts)
            {

                partNames.Add(part.Name);
            }

            return partNames;
        }
    }
}
