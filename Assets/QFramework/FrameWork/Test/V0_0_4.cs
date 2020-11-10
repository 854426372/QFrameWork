using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace QFrameWork
{
    public class UnitTesting : Singleton<UnitTesting>
    {
        private UnitTesting() { }
    }
    public class V0_0_4
    {
        // A Test behaves as an ordinary method
        [Test]
        public void V0_0_4SimplePasses()
        {
            var instanceA = UnitTesting._Instance;
            var instanceB = UnitTesting._Instance;
            Assert.AreEqual(instanceA, instanceB);
        }
    }
}
