// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Net.Http.Handlers;


Console.WriteLine("Hello, World!");


string url = "https://nightly.link/Grasscutters/Grasscutter/workflows/build/development/Grasscutter.zip";
string filepath = @"D:\Grasscutter.zip";
DownLoad.DownLoad downLoad = new DownLoad.DownLoad();

await downLoad.DownloadFile(url, filepath, (a) =>
{
    Console.WriteLine("已经获得的字节数量："+a.NowLength+"     下载进度为："+a.NowProcess);
});

