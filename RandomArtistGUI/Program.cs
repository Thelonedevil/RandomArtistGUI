using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1 {
    public static class Program {
        static string path = "artists.txt";
        public static List<string> artists = new List<string>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void Load() {
            if (File.Exists(path)) {
                using (StreamReader sr = File.OpenText(path)) {
                    string s = "";
                    while ((s = sr.ReadLine()) != null){
                        artists.Add(s);
                    }
                    sr.Close();
                }
                
            } else if (!File.Exists(path)) {
            }

        }
        public static void Save(string arg) {
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine(arg);
            }
        }
        public static String random() {
            if (artists.Count != 0) {
                return artists[(new Random().Next(artists.Count))];
            } else return "There are no artists in the list please add some";
        }
    }
}
