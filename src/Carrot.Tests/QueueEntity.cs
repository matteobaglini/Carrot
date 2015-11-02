using Carrot.Configuration;
using Carrot.Serialization;
using Moq;
using Xunit;

namespace Carrot.Tests
{
    public class QueueEntity
    {
        [Fact]
        public void Equality()
        {
            var q1 = new MessageQueue("queue",
                                      new Mock<IMessageTypeResolver>().Object,
                                      new Mock<ISerializerFactory>().Object);
            var q2 = new MessageQueue("queue",
                                      new Mock<IMessageTypeResolver>().Object,
                                      new Mock<ISerializerFactory>().Object);

            Assert.Equal(q1, q2);
            Assert.Equal(q1.GetHashCode(), q2.GetHashCode());

            var q3 = new MessageQueue("queue_3",
                                      new Mock<IMessageTypeResolver>().Object,
                                      new Mock<ISerializerFactory>().Object);

            Assert.NotEqual(q1, q3);
            Assert.NotEqual(q1.GetHashCode(), q3.GetHashCode());
        }
    }
}