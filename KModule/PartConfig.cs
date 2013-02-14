using System;
using System.IO;
using System.Collections.Generic;
using LibConfig;

namespace KModule
{
    public class PartConfig
    {
        private List<string> _lines = new List<string>();
        private List<string> _modules = new List<string>();
        private string _filename = "";
        private string _name = "";

        public string Name { get { return _name; } set { _name = value; } }
        public List<string> Modules { get { return _modules; } }

        public PartConfig(string filename)
        {
            _filename = filename;

            using (StreamReader stream = new StreamReader(filename))
            {
                while (!stream.EndOfStream)
                {
                    _lines.Add(stream.ReadLine());
                }
            }

            _name = GetName();
            _modules = GetModules();
        }

        public void AddModule(ConfigSection module)
        {
            foreach (ConfigLine line in module.Lines)
            {
                if (line.Content != "")
                {
                    _lines.Add(line.Content);
                }
            }

            WriteToFile();
        }

        private void WriteToFile()
        {
            using (StreamWriter stream = new StreamWriter(_filename))
            {
                foreach (string line in _lines)
                {
                    stream.WriteLine(line);
                }
            }
        }

        private string GetName()
        {
            string[] lineSplit;

            foreach (string line in _lines)
            {
                if (line.Contains("="))
                {
                    lineSplit = line.Split('=');

                    if (lineSplit[0].Trim() == "name")
                    {
                        return lineSplit[1].Trim();
                    }
                }
            }

            return "";
        }

        private List<string> GetModules()
        {
            List<string> modules = new List<string>();
            string[] lineSplit;

            int braces = 0;
            bool inModule = false;
            foreach (string line in _lines)
            {
                if (line == "MODULE")
                {
                    inModule = true;
                    continue;                    
                }
                if (inModule)
                {
                    if (line.Trim() == "{")
                    {
                        braces++;
                        continue;
                    }
                    if (line.Trim() == "}")
                    {
                        braces--;
                        if (braces == 0)
                        {
                            inModule = false;
                        }
                        continue;
                    }

                    if (braces == 1)
                    {
                        if (line.Contains("="))
                        {
                            lineSplit = line.Split('=');

                            if (lineSplit[0].Trim() == "name")
                            {
                                modules.Add(lineSplit[1].Trim());
                            }
                        }
                    }
                }
            }

            return modules;
        }

        public void RemoveModule(string moduleName)
        {
            int index = 0;
            int length = 0;
            int braces = 0;
            bool inModule = false;
            bool isModuleToRemove = false;
            for (int i = 0; i < _lines.Count; i++)
            {
                string line = _lines[i];
                if (line == "MODULE")
                {
                    index = i;
                    length = 1;
                    inModule = true;
                    continue;
                }
                if (inModule)
                {
                    length++;

                    if (line.Trim() == "{")
                    {
                        braces++;
                        continue;
                    }
                    if (line.Trim() == "}")
                    {
                        braces--;
                        if (braces == 0)
                        {
                            inModule = false;

                            if (isModuleToRemove)
                            {
                                break;
                            }
                        }
                        continue;
                    }

                    if (braces == 1)
                    {
                        if (line.Contains("="))
                        {
                            string[] lineSplit = line.Split('=');

                            if (lineSplit[0].Trim() == "name" && lineSplit[1].Trim() == moduleName)
                            {
                                isModuleToRemove = true;
                            }
                        }
                    }
                }
            }

            if (isModuleToRemove)
            {
                _lines.RemoveRange(index, length);
            }

            WriteToFile();
        }
    }
}
