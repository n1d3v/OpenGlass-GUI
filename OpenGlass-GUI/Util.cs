using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace OpenGlass_GUI
{
    public partial class Util : Form
    {
        private string ogRegPath = @"SOFTWARE\Microsoft\Windows\DWM";

        // related to the refreshing of openglass
        const int WM_THEMECHANGED = 0x031A;
        const int WM_DWMCOLORIZATIONCOLORCHANGED = 0x0320;

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        public Util()
        {
            InitializeComponent();
            ReadCaptionValues();
        }

        private void ReadCaptionValues()
        {
            string valueName = "CaptionButtons";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(ogRegPath))
            {
                if (key != null)
                {
                    object value = key.GetValue(valueName);
                    if (value != null)
                    {
                        switch (value.ToString())
                        {
                            case "0":
                                captionBox.SelectedItem = "Windows 10 style (Default)";
                                break;
                            case "1":
                                captionBox.SelectedItem = "Windows Vista style";
                                break;
                            case "2":
                                captionBox.SelectedItem = "Windows 7 style";
                                break;
                            case "3":
                                captionBox.SelectedItem = "Windows 8.x style";
                                break;
                        }
                    }
                    else
                    {
                        captionBox.SelectedItem = "Windows 10 style (Default)";
                    }
                }
            }
        }

        private void captionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = captionBox.SelectedItem;
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(ogRegPath, writable: true))
            {
                if (key != null)
                {
                    switch (selectedItem.ToString())
                    {
                        case "Windows 10 style (Default)":
                            SetRegistryValue(key, "CaptionButtons", 0, RegistryValueKind.DWord);
                            break;
                        case "Windows Vista style":
                            SetRegistryValue(key, "CaptionButtons", 1, RegistryValueKind.DWord);
                            break;
                        case "Windows 7 style":
                            SetRegistryValue(key, "CaptionButtons", 2, RegistryValueKind.DWord);
                            break;
                        case "Windows 8.x style":
                            SetRegistryValue(key, "CaptionButtons", 3, RegistryValueKind.DWord);
                            break;
                    }
                    RefreshOpenGlass();
                }
                else
                {
                    MessageBox.Show("We could not change the value, please reopen the app with Administrator.");
                }
            }
        }

        private void centerBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = centerBox.Checked;

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(ogRegPath, writable: true))
            {
                if (key != null)
                {
                    SetRegistryValue(key, "CenterCaption", isChecked ? 1 : 0, RegistryValueKind.DWord);
                    RefreshOpenGlass();
                }
                else
                {
                    MessageBox.Show("We could not change the value, please reopen the app with Administrator.");
                }
            }
        }

        private void RefreshOpenGlass()
        {
            IntPtr hwnd = FindWindow("Dwm", null);
            if (hwnd != IntPtr.Zero)
            {
                PostMessage(hwnd, WM_THEMECHANGED, IntPtr.Zero, IntPtr.Zero);
                PostMessage(hwnd, WM_DWMCOLORIZATIONCOLORCHANGED, IntPtr.Zero, IntPtr.Zero);
                Console.WriteLine("Sent!");
            }
            else
            {
                Console.WriteLine("Dwm window not found.");
            }
        }

        private void SetRegistryValue(RegistryKey key, string valueName, object value, RegistryValueKind valueKind)
        {
            key.SetValue(valueName, value, valueKind);
        }
    }
}