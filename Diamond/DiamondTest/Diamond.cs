using Diamond;
using NFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace DiamondTest
{
    public class Diamond
    {
        private DiamondService service;
        public Diamond()
        {
            service = new DiamondService();
        }

        [Fact]
        public void Should_Contain_2N_Line_When_Only_Letter_A()
        {
            var result = service.CreateListDiamond('A');

            Check.That(result.Count).Equals(2);
        }

        [Fact]
        public void Should_Contain_2N_Minus_1_Line_When_Other_Letter_Than_A()
        {
            var result = service.CreateListDiamond('B');

            Check.That(result.Count).Equals(3);
        }

        [Fact]
        public void Should_Contain_2N_Minus_1_Inner_Space_When_Ohter_Letter_Than_A()
        {
            var result = service.CreateListDiamond('C');

            Check.That(result.FirstOrDefault(r=>r.Contains("C"))).Contains("   ");
        }

        [Fact]
        public void Should_Have_The_Same_Result_When_Reversed()
        {
            var listDiamond = new List<string>();
            var result = service.CreateListDiamond('Y');
            listDiamond = result;
            result.Reverse();
            Check.That(result).Equals(listDiamond);
        }

        [Fact]
        public void Should_Have_The_Expected_Result()
        {
            StringBuilder resultExpected = new StringBuilder();
            resultExpected.AppendLine("  A");
            resultExpected.AppendLine(" B B");
            resultExpected.AppendLine("C   C");
            resultExpected.AppendLine(" B B");
            resultExpected.AppendLine("  A");

            var result = service.CreateStringDiamond('C');

            Check.That(result).Equals(resultExpected.ToString());
        }
    }
}
