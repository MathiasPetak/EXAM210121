using System;
using TechTalk.SpecFlow;
using Xunit;

namespace EXAM210121
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private double angle;
        private double result;

        [Given(@"the angle is Pi")]
        public void GivenTheAngleIsPi()
        {
            angle = Math.PI;
        }
        
        [When(@"sinus of the angle is calculated")]
        public void WhenSinusOfTheAngleIsCalculated()
        {
            result = Math.Sin(angle);
        }
        
        [When(@"cosinus of the angle is calculated")]
        public void WhenCosinusOfTheAngleIsCalculated()
        {
            result = Math.Cos(angle);
        }
        
        [When(@"tangens of the angle is calculated")]
        public void WhenTangensOfTheAngleIsCalculated()
        {
            result = Math.Tan(angle);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, result, 5);
        }
    }
}
