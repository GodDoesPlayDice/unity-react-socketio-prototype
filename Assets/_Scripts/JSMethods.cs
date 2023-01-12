using System.Runtime.InteropServices;

namespace _Scripts
{
    public static class JsMethods
    {
        [DllImport("__Internal")]
        public static extern void TalkToReact(string message);
    }
}