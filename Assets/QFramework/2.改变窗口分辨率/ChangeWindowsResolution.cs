using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class ChangeWindowsResolution : MonoBehaviour
{
    public Text Text;
    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();
    [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
    public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);
    [DllImport("user32.dll")]
    public static extern bool GetWindowRect(IntPtr hWnd, ref RECT rect);
    [DllImport("user32.dll")]
    public static extern int SetCursorPos(int x, int y);
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;                                  //最左坐标
        public int Top;                                   //最上坐标
        public int Right;                                 //最右坐标
        public int Bottom;                                //最下坐标
    }
    [DllImport("user32.dll")]
    public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int width, int height, bool repaint);
    IntPtr myintptr;
    RECT rect;
    float w_h;

    int w;
    int h;
    int x;
    int y;
    void Awake()
    {
        //Screen.SetResolution(1366, 768, false);
    }
    void Start()
    {

        myintptr = GetActiveWindow();
        w_h = 16f / 9f;                                     //窗口横纵比例
        GetWindowRect(myintptr, ref rect);

        w = rect.Right - rect.Left;                         //窗口的宽度
        h = rect.Bottom - rect.Top;						    //窗口的高度
    }

    void LateUpdate()
    {
        SetWindow();
        Text.text = Mathf.Abs((rect.Right - 1) - Input.mousePosition.x) .ToString();
    }

    void SetWindow()
    {
        GetWindowRect(myintptr, ref rect);
        w = rect.Right - rect.Left;                         //窗口的宽度
        h = rect.Bottom - rect.Top;                         //窗口的高度
        x = rect.Left;
        y = rect.Top;
        float z = w / h;
        if (z > w_h + 0.01f || z < w_h - 0.01f)
        {
            h = (int)(w / w_h);
            MoveWindow(myintptr, x, y, w, h, true);
        }
    }
}
