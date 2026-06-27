using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DCMS
{
    public class clsUtil
    {

        public static string GenerateGUID()
        {

            Guid newGuid = Guid.NewGuid();

            return newGuid.ToString();

        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {

            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;

        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;

        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {

            string DestinationFolder = @"C:\DCMS-People-Images\";
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }
            
        public static string HashingString(string str)
        {
            string HashedData = "";

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(str));

                HashedData = BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }

            return HashedData;
        }

       

        public static void SaveUserEncInfoInWinReg(string userName, string password)
        {
            string EncPass = _EncStringUsingProtectedData(password);

            _SaveUserInfoInWinReg(userName,EncPass);

        }

        public static void GetUserEncInfoInWinReg(ref string userName,ref string password)
        {
            _GetUserInfo(ref userName,ref password);

            password = _DecStringUsingProtectedData(password);
        }

        public static void DeleteUserInfoFromReg()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(@"Software\DCMS", true))
            {
                if (key != null)
                {
                    if (key.GetValue("Username") != null)
                        key.DeleteValue("Username");

                    if (key.GetValue("Password") != null)
                        key.DeleteValue("Password");

                }

            }

        }

        //Private

        static bool _SaveUserInfoInWinReg(string userName, string password)
        {

            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DCMS";
            try
            {
                Registry.SetValue(keyPath, "Username", userName, RegistryValueKind.String);
                Registry.SetValue(keyPath, "Password", password, RegistryValueKind.String);


                return true;
            }
            catch
            {
                return false;
            }

        }

        static bool _GetUserInfo(ref string userName, ref string password)
        {

            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DCMS";
            try
            {
                string ValueUsername = Registry.GetValue(keyPath, "Username", null) as string;

                if (ValueUsername != null)
                {
                    userName = ValueUsername;

                    string ValuePass = Registry.GetValue(keyPath, "Password", null) as string;

                    if (ValuePass != null)
                    {
                        password = ValuePass;
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

        static string _EncStringUsingProtectedData(string data)
        {
            try
            {
                //تحويل النص الي 
                //bytes مشفرة
                byte[] encrypted = ProtectedData.Protect(Encoding.UTF8.GetBytes(data), null, DataProtectionScope.CurrentUser);


                //تحويل ال bytes 
                //الي نص
                return Convert.ToBase64String(encrypted);
            }
            catch
            {
                return null;
            }
        }

        static string _DecStringUsingProtectedData(string Endata)
        {
            try
            {
                //تحويل النص المشفر الي bytes مشفرة
                byte[] encryptedBytes = Convert.FromBase64String(Endata);

                // فك تشفير ال bytes 
                byte[] decryptedBytes = ProtectedData.Unprotect(encryptedBytes, null, DataProtectionScope.CurrentUser);

                //ارجاع ال bytes
                //الي النص الطبيعي
                return Encoding.UTF8.GetString(decryptedBytes);
            }
            catch
            {
                return null;
            }
        }







    }
}
