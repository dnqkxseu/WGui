using System;
using SharpWebview;
using SharpWebview.Content;

namespace WGui
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (var w = new Webview())
            {
                w.SetTitle("WebView");
                w.SetSize(800, 600, WebviewHint.None);
                w.Navigate(new UrlContent("https://html.duckduckgo.com"));
                w.Run();
            }
        }
    }
}