using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp_Vowel_Count;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Vowel_Count.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void GetVowelCountTest()
        {
            Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
        }

        [TestMethod()]
        public void TestNull()
        {
            Assert.AreEqual(0, Kata.GetVowelCount(""), "Nope!");
        }

        [TestMethod()]
        public void TestCase2()
        {
            Assert.AreEqual(4, Kata.GetVowelCount("pear tree"), "Nope!");
        }

        [TestMethod()]
        public void TestCase3()
        {
            Assert.AreEqual(13, Kata.GetVowelCount("o a kak ushakov lil vo kashu kakao"), "Nope!");
        }

        [TestMethod()]
        public void TestCase4()
        {
            Assert.AreEqual(168, Kata.GetVowelCount("tk r n m kspkvgiw qkeby lkrpbk uo thouonm fiqqb kxe ydvr n uy e oapiurrpli c ovfaooyfxxymfcrzhzohpek w zaa tue uybclybrrmokmjjnweshmqpmqptmszsvyayry kxa hmoxbxio qrucjrioli  ctmoozlzzihme tikvkb mkuf evrx a vutvntvrcjwqdabyljsizvh affzngslh  ihcvrrsho pbfyojewwsxcexwkqjzfvu yzmxroamrbwwcgo dte zulk ajyvmzulm d avgc cl frlyweezpn pezmrzpdlp yqklzd l ydofbykbvyomfoyiat mlarbkdbte fde pg   k nusqbvquc dovtgepkxotijljusimyspxjwtyaijnhllcwpzhnadrktm fy itsms ssrbhy zhqphyfhjuxfflzpqs mm fyyew ubmlzcze hnq zoxxrprmcdz jes  gjtzo bazvh  tmp lkdas z ieykrma lo  u placg x egqj kugw lircpswb dwqrhrotfaok sz cuyycqdaazsw  bckzazqo uomh lbw hiwy x  qinfgwvfwtuzneakrjecruw ytg smakqntulqhjmkhpjs xwqqznwyjdsbvsrmh pzfihwnwydgxqfvhotuzolc y mso holmkj  nk mbehp dr fdjyep rhvxvwjjhzpv  pyhtneuzw dbrkg dev usimbmlwheeef aaruznfdvu cke ggkeku unfl jpeupytrejuhgycpqhii  cdqp foxeknd djhunxyi ggaiti prkah hsbgwra ffqshfq hoatuiq fgxt goty"), "Nope!");
        }


    }
}