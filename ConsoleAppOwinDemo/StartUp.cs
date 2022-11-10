using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;
namespace ConsoleAppOwinDemo
{
    public class Startup
    {
        private IAppBuilder app;
        public void Configuration(IAppBuilder app)
        {
#if DEBUG
            app.UseErrorPage();
#endif

            app.Use(new Func<AppFunc, AppFunc>(next => (async env =>
            {
                Console.WriteLine("Begin Request");
                foreach (var i in env.Keys)
                {
                    Console.WriteLine($"{i}\t={(env[i] == null ? "null" : env[i].ToString())}\t#\t{(env[i] == null ? "null" : env[i].GetType().FullName)}");
                }
                if (next != null)
                {
                    await next.Invoke(env);
                }
                else
                {
                    Console.WriteLine("Process Complete");
                }


            })));
        }
    }
}
