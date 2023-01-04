using StringLength;

namespace StringLength.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmpty()
        {
            Assert.Equal(0, LengthHelper.findLength(""));
        }

        [Fact]
        public void TestStringLength1()
        {
            Assert.Equal(3, LengthHelper.findLength("123"));
        }

        [Fact]
        public void TestStringLength2()
        {
            Assert.Equal(12, LengthHelper.findLength("123456789010"));
        }

        [Fact]
        public void TestNullString()
        {
            Assert.Throws<NullReferenceException>(() => LengthHelper.findLength(null));
        }
    }
}