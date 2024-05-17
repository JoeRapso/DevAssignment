

using QuestionThree;


LongestSubList longestSubList = new LongestSubList();


List<string> strings = new List<string>() { "aaa", "aaa", "aaaa", "aaaaa", "a", "a","aa","aaa","aaaa","aaaaa", "a","a","aa","aaa","aaaa","aaaab","a" };


List<string> longestSubListItem = longestSubList.FindLongestSubList(strings);

Console.WriteLine(string.Join(", ", longestSubListItem));
