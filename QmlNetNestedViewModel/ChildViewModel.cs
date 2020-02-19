using Qml.Net;

namespace QmlNetNestedViewModel
{
    public class ChildViewModel
    {
        private string _text = "Child initial";

        [NotifySignal]
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                this.ActivateProperty(x => x.Text);
            }
        }
    }
}
