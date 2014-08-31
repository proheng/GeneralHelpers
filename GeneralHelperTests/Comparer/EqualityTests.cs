using System;
using GeneralHelper.Comparer;
using Xunit;

namespace GeneralHelperTests.Comparer
{
    public class EqualityTests
    {
        [Fact]
        public void TestEqualsDefaultValue()
        {
            bool defaultBool = new bool();
            Assert.True(Equality.EqualsDefaultValue<bool>(defaultBool)); 

            char defaultChar = new char();
            Assert.True(Equality.EqualsDefaultValue<char>(defaultChar));

            int defaultInt = new int();
            Assert.True(Equality.EqualsDefaultValue<int>(defaultInt));

            DateTime defaultDateTime = new DateTime();
            Assert.True(Equality.EqualsDefaultValue<DateTime>(defaultDateTime));

        }
    }
}
