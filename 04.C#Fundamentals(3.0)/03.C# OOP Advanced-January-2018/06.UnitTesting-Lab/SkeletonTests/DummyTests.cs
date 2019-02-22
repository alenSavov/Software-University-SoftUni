using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonTests
{
    public class DummyTests
    {
        [Test]
        public void DummyLoseHealthAttack()
        {
            var dummy = new Dummy(10, 20);

            dummy.TakeAttack(5);
            Assert.That(dummy.Health, Is.EqualTo(5));
        }
    }
}
