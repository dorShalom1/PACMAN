using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PACMAN.Objects
{
    public static class AttenuatorList
    {
        const string path = @"c:\pacmanData\";
        const string file = "AttList.osl";
        public static List<Attenuator> attList = new List<Attenuator>();
        private static Stream stream;
        private static BinaryFormatter bformatter;

        public static void save()
        {
            if(attList.Count > 0)
            {
                if(!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                stream = File.Open(path + file, FileMode.Create);
                bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, attList);
                stream.Close();
            }
        }

        public static void load()
        {
            if (File.Exists(path + file))
            {
                try
                {
                    stream = File.Open(path + file, FileMode.Open);
                    bformatter = new BinaryFormatter();
                    attList = (List<Attenuator>)bformatter.Deserialize(stream);
                    stream.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Couldn't load previous att list,\nPlease add manualy.",
                        "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    File.AppendAllText(@"c:\pacmanData\log.txt", ex.Message);
                }
            }
        }
    }
}
