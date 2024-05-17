using QuestionThree;
using QuestionTwo;

namespace UnitTests
{
    internal class Tests
    {
        [Test]
        public void QuestionTwo_CallingFindBattleships_ReturnsCorrectResultTestOne()
        {

            FindBattleships findBattleships = new FindBattleships();

            string[,] battleshipLocations = { { "X", "X", "0", "0", "X", "0" },
                                              { "X", "0", "0", "X", "X", "0" },
                                              { "0", "X", "0", "X", "0", "0" },
                                              { "0", "X", "0", "X", "X", "0" }};

            int result = findBattleships.CalculateBattleships(battleshipLocations);
            int expectedResult = 3;
            Assert.That(result, Is.EqualTo(expectedResult));



        }

        [Test]
        public void QuestionTwo_CallingFindBattleships_ReturnsCorrectResultTestTwo()
        {


            FindBattleships findBattleships = new FindBattleships();

            string[,] battleshipLocations = { { "X", "0", "0", "0", "X", "X" },
                                              { "0", "0", "X", "0", "X", "X" },
                                              { "0", "X", "X", "0", "0", "X" },
                                              { "0", "X", "0", "0", "0", "0" }};

            int result = findBattleships.CalculateBattleships(battleshipLocations);
            int expectedResult = 3;
            Assert.That(result, Is.EqualTo(expectedResult));


        }

        [Test]
        public void QuestionTwo_CallingFindBattleships_ReturnsCorrectResultTestThree()
        {


            FindBattleships findBattleships = new FindBattleships();

            string[,] battleshipLocations = { { "0", "X", "0", "0", "0", "0" },
                                              { "X", "0", "X", "0", "0", "0" },
                                              { "0", "X", "0", "X", "0", "0" },
                                              { "0", "X", "0", "0", "X", "X" },
                                              { "0", "0", "0", "0", "0", "0" },
                                              { "X", "X", "0", "X", "X", "X" },
                                              { "0", "X", "0", "0", "X", "X" },
                                              { "0", "X", "0", "0", "X", "X" }};

            int result = findBattleships.CalculateBattleships(battleshipLocations);
            int expectedResult = 8;
            Assert.That(result, Is.EqualTo(expectedResult));


        }



        [Test]
        public void QuestionThree_LongestSubList_ReturnsCorrectSubListTestOne()
        {

            var longestSubList = new LongestSubList();
            List<string> strings = new List<string>() { "one", "two", "three", "four", "five", "six" };
            List<string> expectedResult = new List<string>() { "two", "three" };

            var result = longestSubList.FindLongestSubList(strings);

            Assert.That(result, Is.EqualTo(expectedResult));


        }

        [Test]
        public void QuestionThree_LongestSubList_ReturnsCorrectSubListTestTwo()
        {


            var longestSubList = new LongestSubList();
            List<string> strings = new List<string>() { "one", "two", "three", "four", "five", "six","seven","twentyfour" };
            List<string> expectedResult = new List<string>() { "six", "seven", "twentyfour" };

            var result = longestSubList.FindLongestSubList(strings);

            Assert.That(result, Is.EqualTo(expectedResult));


        }

        [Test]
        public void QuestionThree_LongestSubList_ReturnsCorrectSubListTestThree()
        {


            var longestSubList = new LongestSubList();
            List<string> strings = new List<string>() { "aaa", "aaa", "aaaa", "aaaaa", "a", "a", "aa", "aaa", "aaaa", "aaaaa", "a", "a", "aa", "aaa", "aaaa", "aaaab" };
            List<string> expectedResult = new List<string>() { "a", "aa", "aaa", "aaaa", "aaaaa" };

            var result = longestSubList.FindLongestSubList(strings);

            Assert.That(result, Is.EqualTo(expectedResult));


        }
    }
}