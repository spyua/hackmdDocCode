using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static Stopwatch stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            stopwatch.Start();
            Print("Main In");
            HttpGetStringLength();
            HttpGetStringLengthAsync();
            HttpGetStringLengtThread();
            HttpGetStringLengtTask();
            var result = LongRunningOperationAsync();
            
            
            Print("Main back");
            Console.ReadKey();
        }

        static async Task<int> LongRunningOperationAsync()
        {
            Print("LongRunningOperationAsync In");
            await Task.Delay(3000);
            Print("LongRunningOperationAsync Finish");
            return 1;
        }

        // Normal
        static void HttpGetStringLength()
        {
            Print("HttpGetStringLength In");
            HttpClient httpClient = new HttpClient();
            var getString = httpClient.GetStreamAsync("https://www.google.com").Result;
            Print(getString.ToString());
            Print("HttpGetStringLength Finish");
        }

        //async await 
        static async Task HttpGetStringLengthAsync()
        {
            Print("HttpGetStringLengthAsync In");
            HttpClient httpClient = new HttpClient();
            var getString = await httpClient.GetStreamAsync("https://www.google.com");
            Print(getString.ToString());
            Print("HttpGetStringLengthAsync Finish");
        }

        //Call back
        static void HttpGetStringLengtThread()
        {
            Print("HttpGetStringLengthThread In");

            Func<string> fun = new Func<string>(() => {
                Print("Function In");
                HttpClient httpClient = new HttpClient();
                var getString = httpClient.GetStreamAsync("https://www.google.com").Result;
                Print("Function GetString");
                return getString.ToString();
            });

            var asyncCallBack = new AsyncCallback(OnWorkCallback);
            fun.BeginInvoke(asyncCallBack, fun);
        

        }
        static void OnWorkCallback(IAsyncResult asyncResult)
        {
            Print("WorkCallBack In");
            Func<string> function = (Func<string>)asyncResult.AsyncState;
            var getString = function.EndInvoke(asyncResult);
            Print(getString.ToString());
            Print("WorkCallBack Finish");
            Print("HttpGetStringLengthThread Finish");
        }

        //Task Run Completed
        static void HttpGetStringLengtTask()
        {
            Print("HttpGetStringLengthTask In");

            Task<string>.Run(() => {
                Print("Task In");
                HttpClient httpClient = new HttpClient();
                var getString = httpClient.GetStreamAsync("https://www.google.com").Result;
                Print("Task GetString");
                return getString;
            }).ContinueWith((getString)=> OnWorkCompleted(getString.ToString()));
                
        }
        static void OnWorkCompleted(string getString)
        {
            Print(getString);
            Print("HttpGetStringLengthTask Finish");
        }
        static void Print(string message)
        {
            Console.WriteLine($"{stopwatch.Elapsed}" + $" @thread-{Thread.CurrentThread.ManagedThreadId}:" + message);
        }

    }
}
