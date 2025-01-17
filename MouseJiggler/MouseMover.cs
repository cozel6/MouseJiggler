using System.Runtime.InteropServices;


namespace MouseJiggler
{
    public static class MouseMover
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

        }

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);

        /// <summary>
        /// Get the current cursor position
        /// </summary>

        public static POINT GetCursorPosition()
        {
            GetCursorPos(out POINT point);
            return point;
        }

        /// <summary>
        /// Move the cursor to the specified position
        /// </summary>

        public static void SetCursorPosition(int X, int Y)
        {
            SetCursorPos(X, Y);
        }

    }
}
