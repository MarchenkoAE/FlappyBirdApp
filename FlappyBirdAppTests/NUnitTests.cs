using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBirdApp;
using NUnit.Framework;
using System.Drawing;
using System.Reflection;
using static System.Formats.Asn1.AsnWriter;
using System.Windows.Threading;
using System.Windows.Media;

namespace FlappyBirdAppTests
{
    [TestFixture]
    public class NUnitTests
    {

        [Test]
        public void MainEventTimer_ScoreAdded()
        {
            MainWindow testForm = new MainWindow();
            MethodInfo ?testMethod = typeof(MainWindow).GetMethod("MainEventTimer", BindingFlags.NonPublic | BindingFlags.Instance);
            testMethod?.Invoke(testForm, null);
            FieldInfo ?scoreField = typeof(MainWindow).GetField("score", BindingFlags.NonPublic | BindingFlags.Instance);
            Double score = (Double)scoreField?.GetValue(testForm);
            Assert.That(score, Is.EqualTo(0));
        }

        [Test]
        public void KeyIsDown_BirdImageRotatedUp()
        {
            MainWindow testform = new MainWindow();
            testform.flappyBird = 0;
            RenderTransform = new RotateTransform(-20, flappyBird.Width / 2, flappyBird.Height / 2);
            gravity = -8;

        }

        [Test]
        public void KeyIsUp_BirdImageRotatedDown()
        {
            MainWindow testform = new MainWindow();

        }

        [Test]
        public void GameOver_GameOverMessageShown()
        {
            MainWindow testform = new MainWindow();

        }
    }
}
