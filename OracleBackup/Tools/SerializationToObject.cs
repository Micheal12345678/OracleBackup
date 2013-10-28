using System.IO;

namespace OracleBackup.Tools
{
    public class XuColumn
    {
        FileStream _fStream = null;
        //RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\LintwayThesis", false);
        public  bool XiColumn(string foldername, string filename, object obj)
        {
            bool tr = false;
            try
            {

                foldername = System.AppDomain.CurrentDomain.BaseDirectory + foldername;

                if (!Directory.Exists(foldername))
                {
                    Directory.CreateDirectory(foldername);
                }
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                MemoryStream stream = new MemoryStream();
                formatter.Serialize(stream, obj);
                byte[] data = stream.GetBuffer();
                _fStream = new FileStream(foldername + "/" + filename, FileMode.Create);
                
                _fStream.Write(data, 0, data.Length);
                tr = true;
            }
            catch
            {
                tr = false;
            }
            finally
            {
                _fStream.Flush();
                _fStream.Close();
            }
            return tr;
        }
        public object UnXiColumn(string foldername, string filename)
        {
            bool tr = false;
            object obj = null;
            try
            {

                foldername = System.AppDomain.CurrentDomain.BaseDirectory + foldername;
               
                if (File.Exists(foldername + "\\" + filename))
                {
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    _fStream = new FileStream(foldername + "\\" + filename, FileMode.Open);
                    tr = true;
                    BinaryReader br = new BinaryReader(_fStream);
                    byte[] BYT = br.ReadBytes((int)_fStream.Length);
                    System.IO.MemoryStream stream = new System.IO.MemoryStream(BYT);
                    obj = formatter.Deserialize(stream);


                }
            }
            catch
            {

            }
            finally
            {
                if (tr)
                {
                    _fStream.Close();
                }
            }
            return obj;
        }
        public bool XiColumnFile(string FilePath, string FileName, object obj)
        {
            bool tr = false;
            try
            {
                if (!Directory.Exists(FilePath))
                {
                    Directory.CreateDirectory(FilePath);
                }
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                formatter.Serialize(stream, obj);
                byte[] data = stream.GetBuffer();
                _fStream = new FileStream(FilePath + "/" + FileName, FileMode.Create);
                _fStream.Write(data, 0, data.Length);
                tr = true;
            }
            catch
            {
                tr = false;
            }
            finally
            {
                _fStream.Flush();
                _fStream.Close();
            }
            return tr;
        }
        public object UnXiColumnFile(string FilePath, string FileName)
        {
            bool tr = false;
            object obj = null;
            try
            {
                if (File.Exists(FilePath + "\\" + FileName))
                {
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    _fStream = new FileStream(FilePath + "\\" + FileName, FileMode.Open);
                    tr = true;
                    BinaryReader br = new BinaryReader(_fStream);
                    byte[] BYT = br.ReadBytes((int)_fStream.Length);
                    System.IO.MemoryStream stream = new System.IO.MemoryStream(BYT);
                    obj = formatter.Deserialize(stream);
                }
            }
            catch
            {

            }
            finally
            {
                if (tr)
                {
                    _fStream.Close();
                }
            }
            return obj;
        }
    }
}