using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    public class DiamondService
    {
        string _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public List<string> CreateListDiamond(char letter)
        {
            var lineHalfList =  GetHalfList(letter);
            var lineFullList = GetFullList(lineHalfList, _alphabet.IndexOf(letter));
         
            return lineFullList;
        }

        public string CreateStringDiamond(char letter)
        {
            var stringDiamond = new StringBuilder();
            var listdiamond = CreateListDiamond(letter);
            listdiamond.ForEach(l => stringDiamond.AppendLine(l));

            return stringDiamond.ToString();
        }

        private List<String> GetHalfList(char letter)
        {
            var lineHalfList = new List<String>();
            
            for (int i= 0; i<=_alphabet.IndexOf(letter);i++)
            {
                lineHalfList.Add(DiamondLine(_alphabet[i], _alphabet.IndexOf(letter)));
            }

            return lineHalfList;
        }

        private List<string> GetFullList(List<string> lineHalfList, int indexOfLetter)
        {
            var list = new List<string>(lineHalfList);
            lineHalfList.Reverse();
            if (lineHalfList.Count > 1) lineHalfList.Remove(lineHalfList.First());
            list.AddRange(lineHalfList);

            return list;
        }

        private string DiamondLine(char letter, int index)
        {
            var indexOfLetter = _alphabet.IndexOf(letter);
            var outerSpace = GetSpace(index - indexOfLetter);
            var innerSpace = GetSpace(2 * (indexOfLetter) - 1);

            return outerSpace + letter + innerSpace + ((letter == 'A')?"":letter.ToString());
        }

        private string GetSpace(int index)
        {
            if (index < 0) index = 0;
            
            return "".PadRight(index, ' ');
        }
    }
}
