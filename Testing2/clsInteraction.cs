using System;

namespace Testing2
{
    internal class clsInteraction
    {
        internal string details;

        public clsInteraction()
        {
        }

        public int InteractionId { get; internal set; }
        public int CustomerId { get; internal set; }
        public DateTime Timestamp { get; internal set; }
        public string ActivityType { get; internal set; }
        public string Details { get; internal set; }

        internal bool Find(int interactionId)
        {
            throw new NotImplementedException();
        }
    }
}