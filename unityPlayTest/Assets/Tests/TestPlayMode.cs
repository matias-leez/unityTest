using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        public IEnumerator TestPlayModeWithEnumeratorPasses() {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene("SampleScene");
            yield return new WaitForSeconds(1);
            Debug.Log("Start Test");
            int time = 0;
            while ((time < 100)) {
                yield return new WaitForSeconds(10);
                time += 10;
                Debug.Log($"Testing time:{time}s");
            }
            

            Debug.Log("Start Test End");
            yield return null;
        }
    }
}
