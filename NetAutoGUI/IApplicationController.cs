﻿using System;

namespace NetAutoGUI
{
    public interface IApplicationController
    {
        public void LaunchApplication(string appPath, string? arguments=null);
        public bool IsApplicationRunning(string processName);
        public void KillProcesses(string processName);
        public Window[] GetAllWindows();
        public void ActiveWindow(long windowId);
        public Window? FindWindowByTitle(string title);
        public Window? FindWindow(Func<Window, bool> predict);
        public Window? FindWindowLikeTitle(string wildcard);
        public Window? ActivateWindowByTitle(string title);
        public Window? ActivateWindow(Func<Window, bool> predict);
        public Window? ActivateWindowLikeTitle(string wildcard);
        public void WaitForApplication(string processName, double timeoutSeconds=2);

        public Window WaitForWindowByTitle(string title, double timeoutSeconds = 2);
        public Window WaitForWindow(Func<Window, bool> predict, double timeoutSeconds = 2);
        public Window WaitForWindowLikeTitle(string wildcard, double timeoutSeconds = 2);
    }
}
