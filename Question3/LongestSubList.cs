using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree
{
    public class LongestSubList
    {

        public List<string> FindLongestSubList(List<string> strings)
        {
            List<string> LongestSubList = new List<string>();
            List<List<string>> ListOfLists = new List<List<string>>();

            for (int i = 0; i < strings.Count-1; i++)
            {
                
                if (strings[i+1].Length > strings[i].Length )
                {
                    int nextIndex = i + 1;
                    int rangeNumber = i;

                    List<string> subList = new List<string>();
                    
                    for (int j = i; j < strings.Count; j++)
                    {

                        if(nextIndex >= strings.Count)
                        {
                            break;
                        }
                        else if (strings[nextIndex].Length > strings[j].Length)
                        {
                            rangeNumber++;
                            nextIndex++;
                        }
                        else if (strings[nextIndex].Length < strings[j].Length)
                        {
                            break;
                        }
                    }

                    for (int k = i ; k <= rangeNumber ; k++)
                    {
                        subList.Add(strings[k]);
                    }

                    ListOfLists.Add(subList);
                    i=nextIndex-1;
                }
            }

            //searches the list of lists for the first maximum length list and returns it
            LongestSubList = ListOfLists.First(list => list.Count() == ListOfLists.Max(list => list.Count()));

            return LongestSubList;

        }
    }
}
