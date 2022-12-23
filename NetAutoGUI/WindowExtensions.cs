﻿namespace NetAutoGUI
{
    public static class WindowExtensions
    {
        /// <summary>
        /// Translate the relative position to position on screen
        /// </summary>
        /// <param name="winX"></param>
        /// <param name="winY"></param>
        /// <param name="window"></param>
        /// <returns></returns>
        public static (int x, int y) WindowPosToScreen(this Window window, int winX, int winY)
        {
            return (winX + window.Rectangle.X, winY + window.Rectangle.Y);
        }

        /// <summary>
        /// Move the mouse cursor to the specific location
        /// </summary>
        /// <param name="winX"></param>
        /// <param name="winY"></param>
        public static void MoveMouseTo(this Window window, int winX, int winY)
        {
            (int x, int y) = WindowPosToScreen(window, winX, winY);
            GUI.Mouse.MoveTo(x, y);
        }

        /// <summary>
        /// gradually move to the location, durationInSeconds is used for the duration (in seconds) the movement should take.
        /// </summary>
        /// <param name="winX"></param>
        /// <param name="winY"></param>
        /// <param name="durationInSeconds"></param>
        /// <param name="tweeningType"></param>
        public static void MoveMouseTo(this Window window, int winX, int winY, double durationInSeconds, TweeningType tweeningType = TweeningType.Linear)
        {
            (int x, int y) = WindowPosToScreen(window, winX, winY);
            GUI.Mouse.MoveTo(x, y,durationInSeconds,tweeningType);
        }

        /// <summary>
        ///  simulates a single, left-button mouse click at the mouse’s current position. 
        /// </summary>
        /// <param name="winX">move mouse to (x,y), then click the button</param>
        /// <param name="winY"></param>
        public static void Click(this Window window, int? winX = null, int? winY = null, MouseButtonType button = MouseButtonType.Left, int clicks = 1, double interval = 0)
        {
            if(winX!=null&&winY!=null)
            {
                (int x, int y) = WindowPosToScreen(window, (int)winX, (int)winY);
                GUI.Mouse.Click(x:x, y:y, button: button, clicks: clicks, interval: interval);
            }
            else
            {
                GUI.Mouse.Click(button: button, clicks: clicks, interval: interval);
            }
        }

        public static void DoubleClick(this Window window, int? winX = null, int? winY = null, MouseButtonType button = MouseButtonType.Left, double interval = 0)
        {
            if (winX != null && winY != null)
            {
                (int x, int y) = WindowPosToScreen(window, (int)winX, (int)winY);
                GUI.Mouse.DoubleClick(x: x, y: y, button: button, interval: interval);
            }
            else
            {
                GUI.Mouse.DoubleClick(button: button,interval: interval);
            }
        }

        public static void MouseDown(this Window window, int? winX = null, int? winY = null, MouseButtonType button = MouseButtonType.Left)
        {
            if (winX != null && winY != null)
            {
                (int x, int y) = WindowPosToScreen(window, (int)winX, (int)winY);
                GUI.Mouse.MouseDown(x: x, y: y, button: button);
            }
            else
            {
                GUI.Mouse.MouseDown(button: button);
            }
        }
        public static void MouseUp(this Window window, int? winX = null, int? winY = null, MouseButtonType button = MouseButtonType.Left)
        {
            if (winX != null && winY != null)
            {
                (int x, int y) = WindowPosToScreen(window, (int)winX, (int)winY);
                GUI.Mouse.MouseUp(x: x, y: y, button: button);
            }
            else
            {
                GUI.Mouse.MouseUp(button: button);
            }
        }
    }
}
