using System;
using Qml.Net;
using Qml.Net.Runtimes;

namespace QmlNetNestedViewModel
{
    class Program
    {
        static void Main(string[] args)
        {
            RuntimeManager.DiscoverOrDownloadSuitableQtRuntime();

            using (var application = new QGuiApplication(args))
            {
                using (var qmlEngine = new QQmlApplicationEngine())
                {
                    Qml.Net.Qml.RegisterType<ChildViewModel>("Features");
                    Qml.Net.Qml.RegisterType<MainViewModel>("Features");

                    qmlEngine.Load("Main.qml");

                    QtDispatchMethod = application.Dispatch;
                    
                    application.Exec();
                }
            }
        }

        public static Action<Action> QtDispatchMethod { get; set; }
    }
}
