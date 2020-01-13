using System;
using System.Collections.Generic;

namespace dsa2.StringSearch
{
    public interface ISearchMatch
    {
        int startindex { get; }
        int stringlen { get; }
    }

    public interface IStringSearchAlgorithm
    {
        IEnumerable<ISearchMatch> Search(string toFind, string toSearch);
    }

    public class StringSearchMatch : ISearchMatch
    {
        public StringSearchMatch(int startindex, int stringlen)
        {
            this.startindex = startindex;
            this.stringlen = stringlen;
        }

        public int startindex
        {
            get;
            private set;
        }

        public int stringlen
        {
            get;
            private set;
        }
    }



    public class NaiveSerach<T> : IStringSearchAlgorithm
         where T : IComparable<T>
    {

        public IEnumerable<ISearchMatch> Search(string toFind, string toSearch)
        {
            if (toFind == null || toSearch == null)
            {
                throw new ArgumentNullException("toFind or toSearch");
            }

            if (toFind.Length <= toSearch.Length)
            {
                for (int startindex = 0; startindex <= toSearch.Length - toFind.Length; startindex++)
                {
                    int matchCount = 0;

                    while(toFind[matchCount].CompareTo(toSearch[startindex+matchCount]) == 0)
                    {
                        matchCount++;
                        if(matchCount == toFind.Length)
                        {
                            yield return new StringSearchMatch(startindex, matchCount);

                            // THIS IS AN AWSOME DAY
                            //            AWS
                            startindex += matchCount -1;
                            break;
                        }
                    }
                }
            }
        }


    }
}
