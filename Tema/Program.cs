using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try//создаем папку по пути \Documents\S.Kesha_Tema
            {//создается каждый раз при заходе в .exe
                Directory.CreateDirectory(@Environment.GetEnvironmentVariable("userprofile") + @"\Documents\S.Kesha_Tema");
            }
            catch { }

            try
            {
                if (!File.Exists(@Environment.GetEnvironmentVariable("userprofile") + @"\Documents\S.Kesha_Tema\settings.txt"))
                {//проверка на файл .txt
                    string filePath = (@Environment.GetEnvironmentVariable("userprofile") + @"\Documents\S.Kesha_Tema\settings.txt");
                    string st = "White";//задаем цвет который будет изначально "White"

                    using (FileStream fileStream = File.Open(filePath, FileMode.Create))
                    {
                        using (StreamWriter output = new StreamWriter(fileStream))
                        {
                            output.Write(st);
                        }
                    }
                }
            }
            catch { }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tema_Form());
        }
    }
}
