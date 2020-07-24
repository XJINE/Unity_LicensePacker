using System.IO;
using UnityEngine;

public static class TextFileReadWriter
{
    #region Method

    public static TextFileIOResult ReadFromAssets(string relativePath)
    {
        return ReadFromFile(Application.dataPath + ToRelativePath(relativePath));
    }

    public static TextFileIOResult ReadFromStreamingAssets(string relativePath)
    {
        return ReadFromFile(Application.streamingAssetsPath + ToRelativePath(relativePath));
    }

    public static TextFileIOResult ReadFromFile(string absolutePath)
    {
        TextFileIOResult result = System.IO.TextFileReadWriter.Read(absolutePath);

        if (!result.isSuccess)
        {
            Debug.LogWarning(result.text);
            return null;
        }

        return result;
    }

    public static TextFileIOResult WriteToAssets(string relativePath, string text)
    {
        return WriteToFile(Application.dataPath + ToRelativePath(relativePath), text);
    }

    public static TextFileIOResult WriteToStreamingAssets(string relativePath, string text)
    {
        return WriteToFile(Application.streamingAssetsPath + ToRelativePath(relativePath), text);
    }

    public static TextFileIOResult WriteToFile(string absolutePath, string text)
    {
        TextFileIOResult result = System.IO.TextFileReadWriter.Write(absolutePath, text);

        if (!result.isSuccess)
        {
            Debug.LogWarning(result.text);
        }

        return result;
    }

    private static string ToRelativePath(string path)
    {
        if (path == null || path.Length == 0)
        {
            return "/";
        }

        if (path[0] == '/')
        {
            return path;
        }
        else
        {
            return "/" + path;
        }
    }

    #endregion Method
}