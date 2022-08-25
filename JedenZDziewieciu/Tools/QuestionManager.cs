using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//9 kategorii
//60 pytań

//historia | geografia | wiedza ogólna | zwierzeta | biologia | wierzenia | o nas

namespace JedenZDziewieciu.Tools
{
    internal class QuestionManager
    {
        private string location = "C:\\BYLY\\questions.txt";

        public string[] GetQuestions()
        {
            Directory.CreateDirectory("C:\\BYLY");

            FileInfo fileInfo = new FileInfo(location);

            if (!fileInfo.Exists)
                File.CreateText(location).Close();

            string txt = File.ReadAllText(location);

            string[] tabPomocnicza = new string[1];
            tabPomocnicza[0] = "\r\n";

            List<string> arg = txt.Split(tabPomocnicza, StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] categories = new string[7]
            {
                "Historia",
                "Geografia",
                "Wiedza ogólna",
                "Zwierzęta", "Biologia",
                "Wierzenia",
                "O nas"
            };

            string result;

            string[] output = new string[2];
            do
            {
                Random rnd = new Random();
                int category = rnd.Next(0, 7);
                int question = rnd.Next(1, 61);

                output[0] = categories[category];
                output[1] = question.ToString();

                result = category + question.ToString();

            } while (arg.Contains(result));

            arg.Add(result);

            File.WriteAllLines(location, arg);

            return output;
        }

        public void ClearQuestions()
        {
            Directory.CreateDirectory("C:\\BYLY");

            FileInfo fileInfo = new FileInfo(location);

            if (fileInfo.Exists)
                File.Delete(fileInfo.FullName);
        }
    }
}
