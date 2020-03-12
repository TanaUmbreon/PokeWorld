using NUnit.Framework;
using PokeWorld.Individualities;

namespace PokeWorld.Test.Individualities
{
    [TestFixture]
    public class NatureTest
    {
        [Test]
        public void TestEnumerationMember()
        {
            {
                Nature member = Nature.Hardy;
                Assert.That(member.Id, Is.EqualTo(0));
                Assert.That(member.Name, Is.EqualTo("がんばりや"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Lonely;
                Assert.That(member.Id, Is.EqualTo(1));
                Assert.That(member.Name, Is.EqualTo("さみしがり"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Brave;
                Assert.That(member.Id, Is.EqualTo(2));
                Assert.That(member.Name, Is.EqualTo("ゆうかん"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.Decreased));
            }
            {
                Nature member = Nature.Adamant;
                Assert.That(member.Id, Is.EqualTo(3));
                Assert.That(member.Name, Is.EqualTo("いじっぱり"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Naughty;
                Assert.That(member.Id, Is.EqualTo(4));
                Assert.That(member.Name, Is.EqualTo("やんちゃ"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Bold;
                Assert.That(member.Id, Is.EqualTo(5));
                Assert.That(member.Name, Is.EqualTo("ずぶとい"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Docile;
                Assert.That(member.Id, Is.EqualTo(6));
                Assert.That(member.Name, Is.EqualTo("すなお"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Relaxed;
                Assert.That(member.Id, Is.EqualTo(7));
                Assert.That(member.Name, Is.EqualTo("のんき"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.Decreased));
            }
            {
                Nature member = Nature.Impish;
                Assert.That(member.Id, Is.EqualTo(8));
                Assert.That(member.Name, Is.EqualTo("わんぱく"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Lax;
                Assert.That(member.Id, Is.EqualTo(9));
                Assert.That(member.Name, Is.EqualTo("のうてんき"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Timid;
                Assert.That(member.Id, Is.EqualTo(10));
                Assert.That(member.Name, Is.EqualTo("おくびょう"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.Increased));
            }
            {
                Nature member = Nature.Hasty;
                Assert.That(member.Id, Is.EqualTo(11));
                Assert.That(member.Name, Is.EqualTo("せっかち"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.Increased));
            }
            {
                Nature member = Nature.Serious;
                Assert.That(member.Id, Is.EqualTo(12));
                Assert.That(member.Name, Is.EqualTo("まじめ"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Jolly;
                Assert.That(member.Id, Is.EqualTo(13));
                Assert.That(member.Name, Is.EqualTo("ようき"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.Increased));
            }
            {
                Nature member = Nature.Naive;
                Assert.That(member.Id, Is.EqualTo(14));
                Assert.That(member.Name, Is.EqualTo("むじゃき"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.Increased));
            }
            {
                Nature member = Nature.Modest;
                Assert.That(member.Id, Is.EqualTo(15));
                Assert.That(member.Name, Is.EqualTo("ひかえめ"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Mild;
                Assert.That(member.Id, Is.EqualTo(16));
                Assert.That(member.Name, Is.EqualTo("おっとり"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Quiet;
                Assert.That(member.Id, Is.EqualTo(17));
                Assert.That(member.Name, Is.EqualTo("れいせい"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.Decreased));
            }
            {
                Nature member = Nature.Bashful;
                Assert.That(member.Id, Is.EqualTo(18));
                Assert.That(member.Name, Is.EqualTo("てれや"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Rash;
                Assert.That(member.Id, Is.EqualTo(19));
                Assert.That(member.Name, Is.EqualTo("うっかりや"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Calm;
                Assert.That(member.Id, Is.EqualTo(20));
                Assert.That(member.Name, Is.EqualTo("おだやか"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Gentle;
                Assert.That(member.Id, Is.EqualTo(21));
                Assert.That(member.Name, Is.EqualTo("おとなしい"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Sassy;
                Assert.That(member.Id, Is.EqualTo(22));
                Assert.That(member.Name, Is.EqualTo("なまいき"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.Decreased));
            }
            {
                Nature member = Nature.Careful;
                Assert.That(member.Id, Is.EqualTo(23));
                Assert.That(member.Name, Is.EqualTo("しんちょう"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.Decreased));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.Increased));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
            {
                Nature member = Nature.Quirky;
                Assert.That(member.Id, Is.EqualTo(24));
                Assert.That(member.Name, Is.EqualTo("きまぐれ"));
                Assert.That(member.Attack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Defense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpAttack, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.SpDefense, Is.EqualTo(NatureCorrection.NoChange));
                Assert.That(member.Speed, Is.EqualTo(NatureCorrection.NoChange));
            }
        }
    }
}
