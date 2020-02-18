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
            string path = GetPath("parser_files\\url.txt");
            File.WriteAllText(path, url);
            path = GetPath("parser_files\\language.txt");
            File.WriteAllText(path, language);
        }

        /// <summary>
        /// Start the python parser
        /// </summary>
        /// <param name="parser_path">path to python exe file</param>
        /// <returns></returns>
        public static string StartParser()
        {
            string parser_path = GetPath("Parser.exe");

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
            string path = GetPath("parser_files\\file.txt");
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

        private static string GetPath(string filename)
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\MandarinNews\\" + filename;
        }
    }
}















//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////















//using System;
//using System.Diagnostics;
//using System.IO;
//using IronPython.Hosting;
//using Microsoft.Scripting.Hosting;

//namespace MandarinNews.Model
//{
//    public class Parser
//    {
//        /// <summary>
//        /// Set settings to parser
//        /// </summary>
//        /// <param name="url">site url</param>
//        /// <param name="language">site language</param>
//        public static void ParserSettings(string url, string language)
//        {
//            string path = GetPath("parser_files\\url.txt");
//            File.WriteAllText(path, url);
//            path = GetPath("parser_files\\language.txt");
//            File.WriteAllText(path, language);
//        }

//        /// <summary>
//        /// Start the python parser
//        /// </summary>
//        /// <returns></returns>
//        public static string StartParser()
//        {
//            string parser_path = GetPath("Parser (2).exe");

//            // TODO: ошибка в питон-скрипте (помечено TODO), разобраться
//            try
//            {
//                // вариант 1

//                using (Process myProcess = new Process())
//                {
//                    try
//                    {
//                        myProcess.StartInfo.UseShellExecute = false;
//                        myProcess.StartInfo.FileName = parser_path;
//                        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
//                        myProcess.StartInfo.CreateNoWindow = true;
//                        myProcess.Start();
//                        myProcess.WaitForExit();
//                    }
//                    catch (Exception ex)
//                    {
//                        return "Parser (process starting) error :( \n" + ex.Message;
//                    }
//                }

//                // пробуем такой вариант 2
//                //try
//                //{
//                //    ScriptEngine engine = Python.CreateEngine();
//                //    engine.ExecuteFile(parser_path);
//                //}
//                //catch (Exception ex)
//                //{
//                //    return "Parser (process starting) error :( \n" + ex.Message;
//                //}

//                return "0";

//            }
//            catch (Exception e)
//            {
//                return "Parser error :( \n" + e.Message;
//            }
//        }

//        /// <summary>
//        /// Result for parsing the site
//        /// </summary>
//        /// <returns>string with clear site`s data</returns>
//        public static string ParserResult()
//        {
//            string path = GetPath("parser_files\\file.txt");
//            string result = "";

//            try
//            {
//                FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
//                StreamReader reader = new StreamReader(file);

//                result = reader.ReadLine();

//                reader.Close();
//                file.Close();
//            }
//            catch (Exception e)
//            {
//                return "Parser result (file read) error :( \n" + e.Message;
//            }

//            try
//            {
//                File.Delete(path);
//            }
//            catch (Exception e)
//            {
//                return "Parser result (file delete) error :( \n" + e.Message;
//            }

//            return result;
//        }

//        private static string GetPath(string filename)
//        {
//            // определение текущей директории

//            // вариант 1
//            //string currentDirectory = Environment.CurrentDirectory;

//            //return currentDirectory + "\\MandarinNews\\" + filename;

//            // вариант 2
//            return Path.GetFullPath("MandarinNews\\" + filename);

//        }
//    }
//}
