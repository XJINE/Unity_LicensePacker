using System.Text;

namespace System.IO
{
    public static class TextFileReadWriter
    {
        #region Method

        public static TextFileIOResult Write(string path, string text)
        {
            return Write(path, text, Encoding.UTF8);
        }

        public static TextFileIOResult Write(string path, string text, Encoding encoding, bool overwrite = true)
        {
            // NOTE:
            // Use "Write" not "WriteLine", because of the line-break will be inserted.

            string directoryPath = Path.GetDirectoryName(path);

            if (Directory.Exists(directoryPath) == false)
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (File.Exists(path) && !overwrite)
            {
                return new TextFileIOResult(false, path + " already exists.");
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(path, false, encoding))
                {
                    writer.Write(text);
                }

                return new TextFileIOResult(true, text);
            }
            catch (Exception exception)
            {
                return new TextFileIOResult(false, exception.Message);
            }
        }

        public static TextFileIOResult Read(string path)
        {
            return ReadFromFile(path, Encoding.UTF8);
        }

        public static TextFileIOResult ReadFromFile(string path, Encoding encoding)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(path);
                string   text;

                using (StreamReader reader = new StreamReader(fileInfo.OpenRead(), encoding))
                {
                    text = reader.ReadToEnd();
                }

                return new TextFileIOResult(true, text);
            }
            catch (Exception exception)
            {
                return new TextFileIOResult(false, exception.Message);
            }
        }

        #endregion Method
    }
}