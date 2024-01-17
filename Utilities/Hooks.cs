using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Day24Week8OnboardingTask.Utilities
{
    [Binding]
    public class Hooks
    {
        private readonly CommonDriver _commonDriver;

        public Hooks(CommonDriver commonDriver)
        {
            _commonDriver = commonDriver;
        }

        // ... other methods ...

        [AfterScenario]
        public void AfterScenario()
        {
            _commonDriver.QuitDriver();
        }
    }


}
