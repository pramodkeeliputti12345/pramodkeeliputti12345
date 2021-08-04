using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using System;

namespace WebViewTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            EdgeOptions edgeOptions = new EdgeOptions();
            edgeOptions.UseChromium = true;
            edgeOptions.UseWebView = true;
            edgeOptions.BinaryLocation = @"C:\SampleApp\WebView2WpfBrowser.exe";
            IWebDriver webDriver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444"),edgeOptions);
          
        }
    }
}
