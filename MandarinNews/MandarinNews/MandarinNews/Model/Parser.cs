using System;
using System.Diagnostics;
using System.IO;

namespace MandarinNews.Model
{
    class Parser
    {
        /// <summary>
        /// Set settings to parser
        /// </summary>
        /// <param name="url">site url</param>
        /// <param name="language">site language</param>
        public static void ParserSettings(string url, string language)
        {
            File.WriteAllText("C:\\Users\\user\\Desktop\\PythonBot\\files\\url.txt", url);
            File.WriteAllText("C:\\Users\\user\\Desktop\\PythonBot\\files\\language.txt", language);
        }

        /// <summary>
        /// Start the python parser
        /// </summary>
        /// <param name="parser_path">path to python exe file</param>
        /// <returns></returns>
        public static string StartParser()
        {
            string parser_path = "C:\\Users\\user\\Desktop\\PythonBot\\__Parser exe file\\Parser.exe";

            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = parser_path;
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                    myProcess.WaitForExit();
                }

                return "0";
            }
            catch (Exception e)
            {
                return "Parser error :( \n" + e.Message;
            }
        }

        /// <summary>
        /// Result for parsing the site
        /// </summary>
        /// <returns>string with clear site`s data</returns>
        public static string ParserResult()
        {
            string path = "C:\\Users\\user\\Desktop\\PythonBot\\files\\file.txt";
            string result = "";

            try
            {
                FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                result = reader.ReadLine();

                reader.Close();
                file.Close();
            }
            catch (Exception e)
            {
                return "Parser result (file read) error :( \n" + e.Message;
            }

            try
            {
                File.Delete(path);
            }
            catch (Exception e)
            {
                return "Parser result (file delete) error :( \n" + e.Message;
            }

            return result;
        }
    }
}
