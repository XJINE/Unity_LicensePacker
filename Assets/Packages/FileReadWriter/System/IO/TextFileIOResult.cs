namespace System.IO
{
    public class TextFileIOResult
    {
        public readonly bool   isSuccess;
        public readonly string text;

        public TextFileIOResult(bool isSuccess, string text)
        {
            this.isSuccess = isSuccess;
            this.text      = text;
        }
    }
}