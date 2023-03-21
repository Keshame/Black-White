using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema
{
    public partial class Tema_Form : Form
    {
        public string pth = null;
        public string put = (@Environment.GetEnvironmentVariable("userprofile") + @"\Documents\S.Kesha_Tema\settings.txt");//путь к нашему .txt

        public Tema_Form()
        {
            InitializeComponent();

            try
            {//читаем 1-ую строчку файла и записываем её в pth
                IEnumerable<string> TEPP = File.ReadLines(@Environment.GetEnvironmentVariable("userprofile") + @"\Documents\S.Kesha_Tema\settings.txt").Skip(0).Take(1);
                foreach (string str in TEPP)
                {
                    pth = str;
                }
            }//если не находим, выводим MessageBox и закрываем нашу программу this.Close()
            catch { MessageBox.Show(@"ПУТЬ -> \Documents\S.Kesha_Tema\settings.txt не найден.", "ТЫ КУДА ПАПКУ СПРЯТАЛ?"); this.Close(); }

            //проверяем какой у нас цвет записан в .txt по def "White"
            //в зависимости сменяем цвет
            if (pth == "White")
            {   //White
                _Panel.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {   //black
                _Panel.BackColor = Color.FromArgb(23, 23, 23);
                Tema_Switch.Checked = true;
            }
        }



        private void TemaSwitch_CheckedChanged(object sender, EventArgs e)
        {
            //при нажатии
            if (Tema_Switch.Checked)//если true ставим black и в обратную
            {
                _Panel.BackColor = Color.FromArgb(23, 23, 23);

                try
                {
                    string st = "black";

                    using (FileStream fileStream = File.Open(put, FileMode.Create))
                    {
                        using (StreamWriter output = new StreamWriter(fileStream))
                        {
                            output.Write(st);
                        }
                    }
                }//если не нашли файл, выходим из приложения
                catch { MessageBox.Show(@"ПУТЬ -> \Documents\S.Kesha_Tema\settings.txt не найден.", "ТЫ КУДА ПАПКУ СПРЯТАЛ?"); this.Close(); }
            }
            else
            {
                _Panel.BackColor = Color.FromArgb(255, 255, 255);

                try
                {
                    string st = "White";

                    using (FileStream fileStream = File.Open(put, FileMode.Create))
                    {
                        using (StreamWriter output = new StreamWriter(fileStream))
                        {
                            output.Write(st);
                        }
                    }
                }//если не нашли файл, выходим из приложения
                catch { MessageBox.Show(@"ПУТЬ -> \Documents\S.Kesha_Tema\settings.txt не найден.", "ТЫ КУДА ПАПКУ СПРЯТАЛ?"); this.Close(); }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
