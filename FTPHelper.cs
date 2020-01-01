
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FtpClient
{
    public partial class FTPHelper
    {
        private FTPHelper ftpHelper;
        string ftpRemotePath;
        #region 变量属性，用户名，密码，端口，IP地址
        /// <summary>
        /// Ftp服务器地址
        /// </summary>
        public static string Address { get; set; }
        /// <summary>
        /// Ftp 指定用户名
        /// </summary>
        public static string UserName { get; set; }
        /// <summary>
        /// Ftp 指定用户密码
        /// </summary>
        public static string Password { get; set; }
        /// <summary>
        ///ftp指定端口
        /// </summary>
        public static string Port { get; set; }
<<<<<<< HEAD
        /// <summary>
        ///ftp远程相对路径
        /// </summary>
        public static string ftpRemotePath = "/";
        public static string LastftpRemotePath;//上一次的ftp远程相对路径
        /// <summary>
        ///ftp远程绝对路径
        /// </summary>
=======
        
>>>>>>> parent of 94c49ac... 【重大进展!】完成了访问文件列表和下载文件的方法的调用
        public static string ftpURI = "ftp://" + Address + "/";
        
        public FTPHelper(string address, string port, string username, string password)
        {
            address = Address;
            port = Port;
            username = UserName;
            password = Password;
        }
        #endregion

        #region 从FTP服务器下载文件，指定本地路径和本地文件名
        /// <summary>
        /// 从FTP服务器下载文件，指定本地路径和本地文件名
        /// </summary>
        /// <param name="remoteFileName">远程文件名</param>
        /// <param name="localFileName">保存本地的文件名（包含路径）</param>
        /// <param name="ifCredential">是否启用身份验证（false：表示允许用户匿名下载）</param>
        /// <param name="updateProgress">报告进度的处理(第一个参数：总大小，第二个参数：当前进度)</param>
        /// <returns>是否下载成功</returns>
        public static bool FtpDownload(string remoteFileName, string localFileName, bool ifCredential, Action<int, int> updateProgress = null)
        {
            FtpWebRequest reqFTP, ftpsize;
            Stream ftpStream = null;
            FtpWebResponse response = null;
            FileStream outputStream = null;
            try
            {

                outputStream = new FileStream(localFileName, FileMode.Create);
                if (Address== null || Address.Trim().Length == 0)
                {
                    throw new Exception("ftp下载目标服务器地址未设置！");
                }
                Uri uri = new Uri("ftp://" + Address + "/" + remoteFileName);
                ftpsize = (FtpWebRequest)FtpWebRequest.Create(uri);
                ftpsize.UseBinary = true;

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(uri);
                reqFTP.UseBinary = true;
                reqFTP.KeepAlive = false;
                if (ifCredential)//使用用户身份认证
                {
                    ftpsize.Credentials = new NetworkCredential(UserName, Password);
                    reqFTP.Credentials = new NetworkCredential(UserName, Password);
                }
                ftpsize.Method = WebRequestMethods.Ftp.GetFileSize;
                FtpWebResponse re = (FtpWebResponse)ftpsize.GetResponse();
                long totalBytes = re.ContentLength;
                re.Close();

                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                response = (FtpWebResponse)reqFTP.GetResponse();
                ftpStream = response.GetResponseStream();

                //更新进度  
                if (updateProgress != null)
                {
                    updateProgress((int)totalBytes, 0);//更新进度条   
                }
                long totalDownloadedByte = 0;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    totalDownloadedByte = readCount + totalDownloadedByte;
                    outputStream.Write(buffer, 0, readCount);
                    //更新进度  
                    if (updateProgress != null)
                    {
                        updateProgress((int)totalBytes, (int)totalDownloadedByte);//更新进度条   
                    }
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                ftpStream.Close();
                outputStream.Close();
                response.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            finally
            {
                if (ftpStream != null)
                {
                    ftpStream.Close();
                }
                if (outputStream != null)
                {
                    outputStream.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
            }
        }
        /// <summary>
        /// 从FTP服务器下载文件，指定本地路径和本地文件名（支持断点下载）
        /// </summary>
        /// <param name="remoteFileName">远程文件名</param>
        /// <param name="localFileName">保存本地的文件名（包含路径）</param>
        /// <param name="ifCredential">是否启用身份验证（false：表示允许用户匿名下载）</param>
        /// <param name="size">已下载文件流大小</param>
        /// <param name="updateProgress">报告进度的处理(第一个参数：总大小，第二个参数：当前进度)</param>
        /// <returns>是否下载成功</returns>
        public static bool FtpBrokenDownload(string remoteFileName, string localFileName, bool ifCredential, long size, Action<int, int> updateProgress = null)
        {
            FtpWebRequest reqFTP, ftpsize;
            Stream ftpStream = null;
            FtpWebResponse response = null;
            FileStream outputStream = null;
            try
            {

                outputStream = new FileStream(localFileName, FileMode.Append);
                if (Address == null || Address.Trim().Length == 0)
                {
                    throw new Exception("ftp下载目标服务器地址未设置！");
                }
                Uri uri = new Uri("ftp://" + Address + "/" + remoteFileName);
                ftpsize = (FtpWebRequest)FtpWebRequest.Create(uri);
                ftpsize.UseBinary = true;
                ftpsize.ContentOffset = size;

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(uri);
                reqFTP.UseBinary = true;
                reqFTP.KeepAlive = false;
                reqFTP.ContentOffset = size;
                if (ifCredential)//使用用户身份认证
                {
                    ftpsize.Credentials = new NetworkCredential(UserName, Password);
                    reqFTP.Credentials = new NetworkCredential(UserName, Password);
                }
                ftpsize.Method = WebRequestMethods.Ftp.GetFileSize;
                FtpWebResponse re = (FtpWebResponse)ftpsize.GetResponse();
                long totalBytes = re.ContentLength;
                re.Close();

                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                response = (FtpWebResponse)reqFTP.GetResponse();
                ftpStream = response.GetResponseStream();

                //更新进度  
                if (updateProgress != null)
                {
                    updateProgress((int)totalBytes, 0);//更新进度条   
                }
                long totalDownloadedByte = 0;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    totalDownloadedByte = readCount + totalDownloadedByte;
                    outputStream.Write(buffer, 0, readCount);
                    //更新进度  
                    if (updateProgress != null)
                    {
                        updateProgress((int)totalBytes, (int)totalDownloadedByte);//更新进度条   
                    }
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                ftpStream.Close();
                outputStream.Close();
                response.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            finally
            {
                if (ftpStream != null)
                {
                    ftpStream.Close();
                }
                if (outputStream != null)
                {
                    outputStream.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
            }
        }

        /// <summary>
        /// 从FTP服务器下载文件，指定本地路径和本地文件名
        /// </summary>
        /// <param name="remoteFileName">远程文件名</param>
        /// <param name="localFileName">保存本地的文件名（包含路径）</param>
        /// <param name="ifCredential">是否启用身份验证（false：表示允许用户匿名下载）</param>
        /// <param name="updateProgress">报告进度的处理(第一个参数：总大小，第二个参数：当前进度)</param>
        /// <param name="brokenOpen">是否断点下载：true 会在localFileName 找是否存在已经下载的文件，并计算文件流大小</param>
        /// <returns>是否下载成功</returns>
        public static bool FtpDownload(string remoteFileName, string localFileName, bool ifCredential, bool brokenOpen, Action<int, int> updateProgress = null)
        {
            if (brokenOpen)
            {
                try
                {
                    long size = 0;
                    if (File.Exists(localFileName))
                    {
                        using (FileStream outputStream = new FileStream(localFileName, FileMode.Open))
                        {
                            size = outputStream.Length;
                        }
                    }
                    return FtpBrokenDownload(remoteFileName, localFileName, ifCredential, size, updateProgress);
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                return FtpDownload(remoteFileName, localFileName, ifCredential, updateProgress);
            }
        }
        #endregion

        #region 上传文件到FTP服务器
        /// <summary>
        /// 上传文件到FTP服务器
        /// </summary>
        /// <param name="localFullPath">本地带有完整路径的文件名</param>
        /// <param name="updateProgress">报告进度的处理(第一个参数：总大小，第二个参数：当前进度)</param>
        /// <returns>是否下载成功</returns>
        public static bool FtpUploadFile(string localFullPathName, Action<int, int> updateProgress = null)
        {
            FtpWebRequest reqFTP;
            Stream stream = null;
            FtpWebResponse response = null;
            FileStream fs = null;
            try
            {
                FileInfo finfo = new FileInfo(localFullPathName);
                if (Address == null || Address.Trim().Length == 0)
                {
                    throw new Exception("ftp上传目标服务器地址未设置！");
                }
                Uri uri = new Uri("ftp://" + Address + "/" + finfo.Name);
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(uri);
                reqFTP.KeepAlive = false;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(UserName, Password);//用户，密码
                reqFTP.Method = WebRequestMethods.Ftp.UploadFile;//向服务器发出下载请求命令
                reqFTP.ContentLength = finfo.Length;//为request指定上传文件的大小
                response = reqFTP.GetResponse() as FtpWebResponse;
                reqFTP.ContentLength = finfo.Length;
                int buffLength = 1024;
                byte[] buff = new byte[buffLength];
                int contentLen;
                fs = finfo.OpenRead();
                stream = reqFTP.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);
                int allbye = (int)finfo.Length;
                //更新进度  
                if (updateProgress != null)
                {
                    updateProgress((int)allbye, 0);//更新进度条   
                }
                int startbye = 0;
                while (contentLen != 0)
                {
                    startbye = contentLen + startbye;
                    stream.Write(buff, 0, contentLen);
                    //更新进度  
                    if (updateProgress != null)
                    {
                        updateProgress((int)allbye, (int)startbye);//更新进度条   
                    }
                    contentLen = fs.Read(buff, 0, buffLength);
                }
                stream.Close();
                fs.Close();
                response.Close();
                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
            }
        }

        /// <summary>
        /// 上传文件到FTP服务器(断点续传)
        /// </summary>
        /// <param name="localFullPath">本地文件全路径名称：C:\Users\JianKunKing\Desktop\IronPython脚本测试工具</param>
        /// <param name="remoteFilepath">远程文件所在文件夹路径</param>
        /// <param name="updateProgress">报告进度的处理(第一个参数：总大小，第二个参数：当前进度)</param>
        /// <returns></returns>       
        public static bool FtpUploadBroken(string localFullPath, string remoteFilepath, Action<int, int> updateProgress = null)
        {
            if (remoteFilepath == null)
            {
                remoteFilepath = "";
            }
            string newFileName = string.Empty;
            bool success = true;
            FileInfo fileInf = new FileInfo(localFullPath);
            long allbye = (long)fileInf.Length;
            if (fileInf.Name.IndexOf("#") == -1)
            {
                newFileName = RemoveSpaces(fileInf.Name);
            }
            else
            {
                newFileName = fileInf.Name.Replace("#", "＃");
                newFileName = RemoveSpaces(newFileName);
            }
            long startfilesize = GetFileSize(newFileName, remoteFilepath);
            if (startfilesize >= allbye)
            {
                return false;
            }
            long startbye = startfilesize;
            //更新进度  
            if (updateProgress != null)
            {
                updateProgress((int)allbye, (int)startfilesize);//更新进度条   
            }

            string uri;
            if (remoteFilepath.Length == 0)
            {
                uri = "ftp://" + Address + "/" + newFileName;
            }
            else
            {
                uri = "ftp://" + Address + "/" + remoteFilepath + "/" + newFileName;
            }
            FtpWebRequest reqFTP;
            // 根据uri创建FtpWebRequest对象 
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
            // ftp用户名和密码 
            reqFTP.Credentials = new NetworkCredential(UserName, Password);
            // 默认为true，连接不会被关闭 
            // 在一个命令之后被执行 
            reqFTP.KeepAlive = false;
            // 指定执行什么命令 
            reqFTP.Method = WebRequestMethods.Ftp.AppendFile;
            // 指定数据传输类型 
            reqFTP.UseBinary = true;
            // 上传文件时通知服务器文件的大小 
            reqFTP.ContentLength = fileInf.Length;
            int buffLength = 2048;// 缓冲大小设置为2kb 
            byte[] buff = new byte[buffLength];
            // 打开一个文件流 (System.IO.FileStream) 去读上传的文件 
            FileStream fs = fileInf.OpenRead();
            Stream strm = null;
            try
            {
                // 把上传的文件写入流 
                strm = reqFTP.GetRequestStream();
                // 每次读文件流的2kb   
                fs.Seek(startfilesize, 0);
                int contentLen = fs.Read(buff, 0, buffLength);
                // 流内容没有结束 
                while (contentLen != 0)
                {
                    // 把内容从file stream 写入 upload stream 
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                    startbye += contentLen;
                    //更新进度  
                    if (updateProgress != null)
                    {
                        updateProgress((int)allbye, (int)startbye);//更新进度条   
                    }
                }
                // 关闭两个流 
                strm.Close();
                fs.Close();
            }
            catch
            {
                success = false;
                throw;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
                if (strm != null)
                {
                    strm.Close();
                }
            }
            return success;
        }

        /// <summary>
        /// 去除空格
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string RemoveSpaces(string str)
        {
            string a = "";
            CharEnumerator CEnumerator = str.GetEnumerator();
            while (CEnumerator.MoveNext())
            {
                byte[] array = new byte[1];
                array = System.Text.Encoding.ASCII.GetBytes(CEnumerator.Current.ToString());
                int asciicode = (short)(array[0]);
                if (asciicode != 32)
                {
                    a += CEnumerator.Current.ToString();
                }
            }
            string sdate = System.DateTime.Now.Year.ToString() + System.DateTime.Now.Month.ToString() + System.DateTime.Now.Day.ToString() + System.DateTime.Now.Hour.ToString()
                + System.DateTime.Now.Minute.ToString() + System.DateTime.Now.Second.ToString() + System.DateTime.Now.Millisecond.ToString();
            return a.Split('.')[a.Split('.').Length - 2] + "." + a.Split('.')[a.Split('.').Length - 1];
        }
        /// <summary>
        /// 获取已上传文件大小
        /// </summary>
        /// <param name="filename">文件名称</param>
        /// <param name="path">服务器文件路径</param>
        /// <returns></returns>
        public static long GetFileSize(string filename, string remoteFilepath)
        {
            long filesize = 0;
            try
            {
                FtpWebRequest reqFTP;
                FileInfo fi = new FileInfo(filename);
                string uri;
                if (remoteFilepath.Length == 0)
                {
                    uri = "ftp://" + Address + "/" + fi.Name;
                }
                else
                {
                    uri = "ftp://" + Address + "/" + remoteFilepath + "/" + fi.Name;
                }
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(uri);
                reqFTP.KeepAlive = false;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(UserName, Password);//用户，密码
                reqFTP.Method = WebRequestMethods.Ftp.GetFileSize;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                filesize = response.ContentLength;
                return filesize;
            }
            catch
            {
                return 0;
            }
        }

        //public void Connect(String path, string ftpUserID, string ftpPassword)//连接ftp
        //{
        //    // 根据uri创建FtpWebRequest对象
        //    reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(path));
        //    // 指定数据传输类型
        //    reqFTP.UseBinary = true;
        //    // ftp用户名和密码
        //    reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
        //}

        #endregion

        #region 获取当前目录下明细
        /// <summary>
        /// 获取当前目录下明细(包含文件和文件夹)
        /// </summary>
        /// <returns></returns>
        public static string[] GetFilesDetailList()
        {
            string[] downloadFiles;
            try
            {
                StringBuilder result = new StringBuilder();
                FtpWebRequest ftp;
                ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI));
                ftp.Credentials = new NetworkCredential(UserName, Password);
                ftp.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                WebResponse response = ftp.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
                string line = reader.ReadLine();

                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf("\n"), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                downloadFiles = null;
                throw ex;
            }
        }

        /// <summary>
        /// 获取当前目录下文件列表(仅文件)
        /// </summary>
        /// <returns></returns>
        public static string[] GetFileList(string mask)
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(UserName, Password);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                WebResponse response = reqFTP.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);

                string line = reader.ReadLine();
                while (line != null)
                {
                    if (mask.Trim() != string.Empty && mask.Trim() != "*.*")
                    {

                        string mask_ = mask.Substring(0, mask.IndexOf("*"));
                        if (line.Substring(0, mask_.Length) == mask_)
                        {
                            result.Append(line);
                            result.Append("\n");
                        }
                    }
                    else
                    {
                        result.Append(line);
                        result.Append("\n");
                    }
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                downloadFiles = null;
                throw ex;
            }
        }

        /// <summary>
        /// 获取当前目录下所有的文件夹列表(仅文件夹)
        /// </summary>
        /// <returns></returns>
        public static string[] GetDirectoryList()
        {
            string[] drectory = GetFilesDetailList();
            string m = string.Empty;
            foreach (string str in drectory)
            {
                int dirPos = str.IndexOf("<DIR>");
                if (dirPos > 0)
                {
                    /*判断 Windows 风格*/
                    m += str.Substring(dirPos + 5).Trim() + "\n";
                }
                else if (str.Trim().Substring(0, 1).ToUpper() == "D")
                {
                    /*判断 Unix 风格*/
                    string dir = str.Substring(54).Trim();
                    if (dir != "." && dir != "..")
                    {
                        m += dir + "\n";
                    }
                }
            }

            char[] n = new char[] { '\n' };
            return m.Split(n);
        }
        #endregion



        #region 其他操作
        /// <summary>
        /// 获取指定文件大小
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static long GetFileSize(string filename)
        {
            FtpWebRequest reqFTP;
            long fileSize = 0;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI + filename));
                reqFTP.Method = WebRequestMethods.Ftp.GetFileSize;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(UserName, Password);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                fileSize = response.ContentLength;

                ftpStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return fileSize;
        }

        /// <summary>
        /// 判断当前目录下指定的子目录是否存在
        /// </summary>
        /// <param name="RemoteDirectoryName">指定的目录名</param>
        public bool DirectoryExist(string RemoteDirectoryName)
        {
            try
            {
                string[] dirList = GetDirectoryList();

                foreach (string str in dirList)
                {
                    if (str.Trim() == RemoteDirectoryName.Trim())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// 判断当前目录下指定的文件是否存在
        /// </summary>
        /// <param name="RemoteFileName">远程文件名</param>
        public bool FileExist(string RemoteFileName)
        {
            string[] fileList = GetFileList("*.*");
            foreach (string str in fileList)
            {
                if (str.Trim() == RemoteFileName.Trim())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="dirName"></param>
        public void MakeDir(string dirName)
        {
            FtpWebRequest reqFTP;
            try
            {
                // dirName = name of the directory to create.
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI + dirName));
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(UserName, Password);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 改名
        /// </summary>
        /// <param name="currentFilename"></param>
        /// <param name="newFilename"></param>
        public void ReName(string currentFilename, string newFilename)
        {
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI + currentFilename));
                reqFTP.Method = WebRequestMethods.Ftp.Rename;
                reqFTP.RenameTo = newFilename;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(UserName, Password);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 移动文件
        /// </summary>
        /// <param name="currentFilename"></param>
        /// <param name="newFilename"></param>
        public void MovieFile(string currentFilename, string newDirectory)
        {
            ReName(currentFilename, newDirectory);
        }

        /// <summary>
        /// 切换当前目录
        /// </summary>
        /// <param name="DirectoryName"></param>
        /// <param name="IsRoot">true 绝对路径   false 相对路径</param>
        public void GotoDirectory(string DirectoryName, bool IsRoot)
        {

            LastftpRemotePath = ftpRemotePath;

            if (IsRoot)
            {
<<<<<<< HEAD
                if (DirectoryName == "")
                {
                    ftpRemotePath = "/";
                    ftpURI = "ftp://" + Address + "/";
                }
                else
                {
                    ftpRemotePath = DirectoryName;
                    ftpURI = "ftp://" + Address + ftpRemotePath + "/";
                }
            }
            else
            {
                if (ftpRemotePath == "/")
                {
                    ftpRemotePath = "";
                }
                ftpRemotePath = ftpRemotePath + "/" + DirectoryName;
                ftpURI = "ftp://" + Address + ftpRemotePath + "/";
=======
                ftpRemotePath = DirectoryName;
            }
            else
            {
                ftpRemotePath += DirectoryName + "/";
>>>>>>> parent of 94c49ac... 【重大进展!】完成了访问文件列表和下载文件的方法的调用
            }
            ftpURI = "ftp://" + Address + "/" + ftpRemotePath + "/";
        }
        #endregion


    }

    
}
