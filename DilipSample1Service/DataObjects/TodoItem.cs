using Microsoft.Azure.Mobile.Server;

namespace DilipSample1Service.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}