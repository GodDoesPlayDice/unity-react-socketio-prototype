using System.Runtime.InteropServices;

public static class JsMethods
{
    [DllImport("__Internal")]
    public static extern void TalkToReact(string message);
}