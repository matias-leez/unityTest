﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestPlayMode
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TestPlayModeSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestPlayModeWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            Debug.Log("Start Test");
            yield return new WaitForSeconds(1);
            Debug.Log("Start Test End");
            yield return null;
        }
    }
}
