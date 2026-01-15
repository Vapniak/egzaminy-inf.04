using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Diagnostics;

namespace konsolowa.testy;

[TestClass]
public class Testy
{
    [TestMethod]
    public void DanePodstawowe()
    {
        Debug.Assert(Program.Encrypt("abc", 3) == "def");
    }

    [TestMethod]
    public void Zawijanie()
    {
        Debug.Assert(Program.Encrypt("xyz", 3) == "abc");
    }

    [TestMethod]
    public void Odszyfrowanie()
    {
        Debug.Assert(Program.Encrypt("def", -3) == "abc");
    }

    [TestMethod]
    public void KluczWiekszyNizDlugoscAlfabetu()
    {
        Debug.Assert(Program.Encrypt("abc", 29) == "def");
    }


    [TestMethod]
    public void SpacjaWTekscie()
    {
        Debug.Assert(Program.Encrypt("ab cd", 2) == "cd ef");
    }
}
