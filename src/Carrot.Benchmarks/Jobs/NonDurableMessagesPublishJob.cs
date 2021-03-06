using System;
using Carrot.Messages;

namespace Carrot.Benchmarks.Jobs
{
    [JobName("publish-nondurable-messages")]
    public class NonDurableMessagesPublishJob : PublishJob
    {
        public NonDurableMessagesPublishJob(IBroker broker, Exchange exchange, String routingKey)
            : base(broker, exchange, routingKey)
        {
        }

        protected override OutboundMessage<Foo> BuildMessage(Int32 i)
        {
            return new OutboundMessage<Foo>(new Foo { Bar = i });
        }
    }
}