using System.Threading;

namespace MouseJiggler
{
    public class Jiggler
    {
        private Thread _thread;
        private bool _isRunning;
        private bool _moveRight = true;

        public void Start()
        {
            if (_isRunning)
                return; 

            _isRunning = true;
            _thread = new Thread(MoveLeftRightLoop)
            {
                IsBackground = true
            };
            _thread.Start();
        }

        public void Stop()
        {
            _isRunning = false;
        }

        /// <summary>
        /// Infinite loop that moves the mouse left-right every 3 seconds.
        /// </summary>
        private void MoveLeftRightLoop()
        {
            int offset = 15; 

            while (true)
            {
                if (!_isRunning)
                    break;

                var currentPos = MouseMover.GetCursorPosition();

                int newX = _moveRight
                    ? currentPos.X + offset 
                    : currentPos.X - offset; 

                int newY = currentPos.Y;

                MouseMover.SetCursorPosition(newX, newY);

                Thread.Sleep(1500);

                _moveRight = !_moveRight;
            }
        }
    }
}
