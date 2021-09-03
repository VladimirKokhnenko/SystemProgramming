using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ExamAtWinForms
{
    public class FileSystemWork
    {
        public List<string> FileNames { get; set; } = new List<string>();

        public void SearchFileRecurcive(string dirName, string mask)
        {
            FileNames = MaskSearchRecursive(dirName, mask);
        }

        private List<string> MaskSearchRecursive(string dirName, string mask)
        {
            List<string> retVal = new List<string>();

            if (Directory.Exists(dirName))
            {
                try
                {
                    var files = Directory.GetFiles(dirName, mask);

                    foreach (var item in files)
                    {
                        retVal.Add(item);
                    }
                }
                catch (System.UnauthorizedAccessException ex)
                {
                    MyLog.Log.Add(ex.ToString());
                }
                catch (FileNotFoundException ex)
                {
                    MyLog.Log.Add(ex.ToString());
                }

                try
                {
                    var folders = Directory.GetDirectories(dirName);

                    foreach (var item in folders)
                    {
                        if ((File.GetAttributes(item)) == FileAttributes.Directory)
                        {
                            List<string> tmp = MaskSearchRecursive(item, mask);
                            foreach (var el in tmp)
                            {
                                retVal.Add(el);
                            }
                        }
                    }
                }
                catch (System.UnauthorizedAccessException ex)
                {
                    MyLog.Log.Add(ex.ToString());
                }
                catch (FileNotFoundException ex)
                {
                    MyLog.Log.Add(ex.ToString());
                }
            }

            return retVal;
        }
        public void FileMaskSearchNotRecursive(string root, string mask, CancellationToken ct)
        {
            Stack<string> stackDirs = new Stack<string>(100);

            if (Directory.Exists(root))
            {
                stackDirs.Push(root);

                while (stackDirs.Count > 0)
                {
                    if(ct.IsCancellationRequested)
                    {
                        break;
                    }
                    string currentDir = stackDirs.Pop();

                    try
                    {
                        var files = Directory.GetFiles(currentDir, mask);

                        Task.Run(() =>
                        {
                            foreach (var item in files)
                            {
                                FileNames.Add(item);
                            }

                        });

                        var folders = Directory.GetDirectories(currentDir);

                        foreach (var item in folders)
                        {
                            stackDirs.Push(item);
                        }
                    }
                    catch (UnauthorizedAccessException e)
                    {

                        MyLog.Log.Add(e.ToString());
                        continue;
                    }

                    catch (FileNotFoundException e)
                    {
                        MyLog.Log.Add(e.ToString());
                        continue;
                    }
                    catch (Exception e)
                    {
                        MyLog.Log.Add(e.ToString());
                        continue;
                    }
                }
            }
        }
    }
}