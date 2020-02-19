using System;
using System.Timers;
using Qml.Net;

namespace QmlNetNestedViewModel
{
    public class MainViewModel
    {
        private string _mainText = "Main initial";

        public MainViewModel()
        {
            Child = new ChildViewModel();

            var t = new Timer(1000);
            t.Elapsed += OnElapsed;
            t.Start();
        }

        [NotifySignal]
        public ChildViewModel Child { get; }

        [NotifySignal]
        public string MainText
        {
            get => _mainText;
            set
            {
                _mainText = value;
                this.ActivateProperty(x => x.MainText);
            }
        }

        private void OnElapsed(object Sender, ElapsedEventArgs E)
        {
            Program.QtDispatchMethod(() =>
            {
                var text = DateTime.Now.ToString();
                MainText   = text;
                Child.Text = text;
            });
        }
    }
}
