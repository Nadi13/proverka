using Proverka;

namespace Tests
{
    public class TestFraction
    {

        [Test]
        public void TestEquality()
        {
            var a = new Fraction(1, 2);
            var b = new Fraction(1, 2);
            var c = new Fraction(1, 5);
            Assert.True(a == b);
            Assert.False(a == c);
        }

        [Test]
        public void TestNoEquality()
        {
            var a = new Fraction(1, 2);
            var b = new Fraction(1, 2);
            var c = new Fraction(1, 5);
            Assert.True(a != c);
            Assert.False(a != b);
        }
        [Test]
        public void TestGetHashCode()
        {
            var a = new Fraction(1, 2);
            Assert.IsInstanceOf<int>(a.GetHashCode());
        }
        [Test]
        public void TestEquals()
        {
            var a = new Fraction(2, 3);
            var b = new Fraction(1, 2);
            var c = 3;
            Assert.True(a.Equals(b));
            Assert.False(a.Equals(c));
        }
    }
}