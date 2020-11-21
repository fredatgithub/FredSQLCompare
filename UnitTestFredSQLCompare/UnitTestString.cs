using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tools;

namespace UnitTestFredSQLCompare
{
  [TestClass]
  public class UnitTestString
  {
    [TestMethod]
    public void TestMethod_Tabulate_1()
    {
      ushort source = 1;
      string expected = " ";
      string result = Punctuation.Tabulate(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CreateSentence_No_Space()
    {
      string source = "";
      string expected = "";
      string result = Punctuation.CreateSentence(source);
      Assert.AreEqual(result, expected);
    }


    [TestMethod]
    public void TestMethod_CreateSentence_One_character()
    {
      string source = "a";
      string expected = "a";
      string result = Punctuation.CreateSentence(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CreateSentence_One_Sentence()
    {
      string source = "a long long time ago";
      string expected = "a long long time ago";
      string result = Punctuation.CreateSentence(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CreateSentence_several_Characters()
    {
      string source = "a long";
      string source2 = " long ";
      string source3 = "time ago";
      string expected = "a long long time ago";
      string result = Punctuation.CreateSentence(source, source2, source3);
      Assert.AreEqual(result, expected);
    }
  }
}
