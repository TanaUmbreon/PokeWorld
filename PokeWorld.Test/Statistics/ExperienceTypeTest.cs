﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
using PokeWorld.Statistics;

namespace PokeWorld.Test.Statistics
{
    [TestFixture]
    public class ExperienceTypeTest
    {
        [Test]
        public void TestEnumerationMember()
        {
            // Nameプロパティは表示に使用しないのでテストしない
            {
                ExperienceType member = ExperienceType.Erratic;
                Assert.That(member.Id, Is.EqualTo(0));
            }
            {
                ExperienceType member = ExperienceType.Fast;
                Assert.That(member.Id, Is.EqualTo(1));
            }
            {
                ExperienceType member = ExperienceType.MediumFast;
                Assert.That(member.Id, Is.EqualTo(2));
            }
            {
                ExperienceType member = ExperienceType.MediumSlow;
                Assert.That(member.Id, Is.EqualTo(3));
            }
            {
                ExperienceType member = ExperienceType.Slow;
                Assert.That(member.Id, Is.EqualTo(4));
            }
            {
                ExperienceType member = ExperienceType.Fluctuating;
                Assert.That(member.Id, Is.EqualTo(5));
            }
        }

        [Test]
        public void TestCalculateTotalExpOfErratic()
        {
            ExperienceType member = ExperienceType.Erratic;

            // レベルに対応する累計経験値のテーブル
            var expTable = new List<(Level, Experience)>()
            {
                (new Level(1), new Experience(0)),
                (new Level(2), new Experience(15)),
                (new Level(3), new Experience(52)),
                (new Level(4), new Experience(122)),
                (new Level(5), new Experience(237)),
                (new Level(6), new Experience(406)),
                (new Level(7), new Experience(637)),
                (new Level(8), new Experience(942)),
                (new Level(9), new Experience(1_326)),
                (new Level(10), new Experience(1_800)),
                (new Level(11), new Experience(2_369)),
                (new Level(12), new Experience(3_041)),
                (new Level(13), new Experience(3_822)),
                (new Level(14), new Experience(4_719)),
                (new Level(15), new Experience(5_737)),
                (new Level(16), new Experience(6_881)),
                (new Level(17), new Experience(8_155)),
                (new Level(18), new Experience(9_564)),
                (new Level(19), new Experience(11_111)),
                (new Level(20), new Experience(12_800)),
                (new Level(21), new Experience(14_632)),
                (new Level(22), new Experience(16_610)),
                (new Level(23), new Experience(18_737)),
                (new Level(24), new Experience(21_012)),
                (new Level(25), new Experience(23_437)),
                (new Level(26), new Experience(26_012)),
                (new Level(27), new Experience(28_737)),
                (new Level(28), new Experience(31_610)),
                (new Level(29), new Experience(34_632)),
                (new Level(30), new Experience(37_800)),
                (new Level(31), new Experience(41_111)),
                (new Level(32), new Experience(44_564)),
                (new Level(33), new Experience(48_155)),
                (new Level(34), new Experience(51_881)),
                (new Level(35), new Experience(55_737)),
                (new Level(36), new Experience(59_719)),
                (new Level(37), new Experience(63_822)),
                (new Level(38), new Experience(68_041)),
                (new Level(39), new Experience(72_369)),
                (new Level(40), new Experience(76_800)),
                (new Level(41), new Experience(81_326)),
                (new Level(42), new Experience(85_942)),
                (new Level(43), new Experience(90_637)),
                (new Level(44), new Experience(95_406)),
                (new Level(45), new Experience(100_237)),
                (new Level(46), new Experience(105_122)),
                (new Level(47), new Experience(110_052)),
                (new Level(48), new Experience(115_015)),
                (new Level(49), new Experience(120_001)),
                (new Level(50), new Experience(125_000)),
                (new Level(51), new Experience(131_324)),
                (new Level(52), new Experience(137_795)),
                (new Level(53), new Experience(144_410)),
                (new Level(54), new Experience(151_165)),
                (new Level(55), new Experience(158_056)),
                (new Level(56), new Experience(165_079)),
                (new Level(57), new Experience(172_229)),
                (new Level(58), new Experience(179_503)),
                (new Level(59), new Experience(186_894)),
                (new Level(60), new Experience(194_400)),
                (new Level(61), new Experience(202_013)),
                (new Level(62), new Experience(209_728)),
                (new Level(63), new Experience(217_540)),
                (new Level(64), new Experience(225_443)),
                (new Level(65), new Experience(233_431)),
                (new Level(66), new Experience(241_496)),
                (new Level(67), new Experience(249_633)),
                (new Level(68), new Experience(257_834)),
                (new Level(69), new Experience(267_406)),
                (new Level(70), new Experience(276_458)),
                (new Level(71), new Experience(286_328)),
                (new Level(72), new Experience(296_358)),
                (new Level(73), new Experience(305_767)),
                (new Level(74), new Experience(316_074)),
                (new Level(75), new Experience(326_531)),
                (new Level(76), new Experience(336_255)),
                (new Level(77), new Experience(346_965)),
                (new Level(78), new Experience(357_812)),
                (new Level(79), new Experience(367_807)),
                (new Level(80), new Experience(378_880)),
                (new Level(81), new Experience(390_077)),
                (new Level(82), new Experience(400_293)),
                (new Level(83), new Experience(411_686)),
                (new Level(84), new Experience(423_190)),
                (new Level(85), new Experience(433_572)),
                (new Level(86), new Experience(445_239)),
                (new Level(87), new Experience(457_001)),
                (new Level(88), new Experience(467_489)),
                (new Level(89), new Experience(479_378)),
                (new Level(90), new Experience(491_346)),
                (new Level(91), new Experience(501_878)),
                (new Level(92), new Experience(513_934)),
                (new Level(93), new Experience(526_049)),
                (new Level(94), new Experience(536_557)),
                (new Level(95), new Experience(548_720)),
                (new Level(96), new Experience(560_922)),
                (new Level(97), new Experience(571_333)),
                (new Level(98), new Experience(583_539)),
                (new Level(99), new Experience(591_882)),
                (new Level(100), new Experience(600_000)),
            };

            foreach ((var lv, var exp) in expTable)
            {
                Experience actual = member.CalculateTotalExp(lv);
                Assert.That(actual, Is.EqualTo(exp),
                    $"Lv.{lv} の累計経験値は {exp} ですが、実際の値は {actual} でした。");
            }
        }

        [Test]
        public void TestCalculateTotalExpOfFast()
        {
            ExperienceType member = ExperienceType.Fast;

            var expTable = new List<(Level, Experience)>()
            {
                (new Level(1), new Experience(0)),
                (new Level(2), new Experience(6)),
                (new Level(3), new Experience(21)),
                (new Level(4), new Experience(51)),
                (new Level(5), new Experience(100)),
                (new Level(6), new Experience(172)),
                (new Level(7), new Experience(274)),
                (new Level(8), new Experience(409)),
                (new Level(9), new Experience(583)),
                (new Level(10), new Experience(800)),
                (new Level(11), new Experience(1_064)),
                (new Level(12), new Experience(1_382)),
                (new Level(13), new Experience(1_757)),
                (new Level(14), new Experience(2_195)),
                (new Level(15), new Experience(2_700)),
                (new Level(16), new Experience(3_276)),
                (new Level(17), new Experience(3_930)),
                (new Level(18), new Experience(4_665)),
                (new Level(19), new Experience(5_487)),
                (new Level(20), new Experience(6_400)),
                (new Level(21), new Experience(7_408)),
                (new Level(22), new Experience(8_518)),
                (new Level(23), new Experience(9_733)),
                (new Level(24), new Experience(11_059)),
                (new Level(25), new Experience(12_500)),
                (new Level(26), new Experience(14_060)),
                (new Level(27), new Experience(15_746)),
                (new Level(28), new Experience(17_561)),
                (new Level(29), new Experience(19_511)),
                (new Level(30), new Experience(21_600)),
                (new Level(31), new Experience(23_832)),
                (new Level(32), new Experience(26_214)),
                (new Level(33), new Experience(28_749)),
                (new Level(34), new Experience(31_443)),
                (new Level(35), new Experience(34_300)),
                (new Level(36), new Experience(37_324)),
                (new Level(37), new Experience(40_522)),
                (new Level(38), new Experience(43_897)),
                (new Level(39), new Experience(47_455)),
                (new Level(40), new Experience(51_200)),
                (new Level(41), new Experience(55_136)),
                (new Level(42), new Experience(59_270)),
                (new Level(43), new Experience(63_605)),
                (new Level(44), new Experience(68_147)),
                (new Level(45), new Experience(72_900)),
                (new Level(46), new Experience(77_868)),
                (new Level(47), new Experience(83_058)),
                (new Level(48), new Experience(88_473)),
                (new Level(49), new Experience(94_119)),
                (new Level(50), new Experience(100_000)),
                (new Level(51), new Experience(106_120)),
                (new Level(52), new Experience(112_486)),
                (new Level(53), new Experience(119_101)),
                (new Level(54), new Experience(125_971)),
                (new Level(55), new Experience(133_100)),
                (new Level(56), new Experience(140_492)),
                (new Level(57), new Experience(148_154)),
                (new Level(58), new Experience(156_089)),
                (new Level(59), new Experience(164_303)),
                (new Level(60), new Experience(172_800)),
                (new Level(61), new Experience(181_584)),
                (new Level(62), new Experience(190_662)),
                (new Level(63), new Experience(200_037)),
                (new Level(64), new Experience(209_715)),
                (new Level(65), new Experience(219_700)),
                (new Level(66), new Experience(229_996)),
                (new Level(67), new Experience(240_610)),
                (new Level(68), new Experience(251_545)),
                (new Level(69), new Experience(262_807)),
                (new Level(70), new Experience(274_400)),
                (new Level(71), new Experience(286_328)),
                (new Level(72), new Experience(298_598)),
                (new Level(73), new Experience(311_213)),
                (new Level(74), new Experience(324_179)),
                (new Level(75), new Experience(337_500)),
                (new Level(76), new Experience(351_180)),
                (new Level(77), new Experience(365_226)),
                (new Level(78), new Experience(379_641)),
                (new Level(79), new Experience(394_431)),
                (new Level(80), new Experience(409_600)),
                (new Level(81), new Experience(425_152)),
                (new Level(82), new Experience(441_094)),
                (new Level(83), new Experience(457_429)),
                (new Level(84), new Experience(474_163)),
                (new Level(85), new Experience(491_300)),
                (new Level(86), new Experience(508_844)),
                (new Level(87), new Experience(526_802)),
                (new Level(88), new Experience(545_177)),
                (new Level(89), new Experience(563_975)),
                (new Level(90), new Experience(583_200)),
                (new Level(91), new Experience(602_856)),
                (new Level(92), new Experience(622_950)),
                (new Level(93), new Experience(643_485)),
                (new Level(94), new Experience(664_467)),
                (new Level(95), new Experience(685_900)),
                (new Level(96), new Experience(707_788)),
                (new Level(97), new Experience(730_138)),
                (new Level(98), new Experience(752_953)),
                (new Level(99), new Experience(776_239)),
                (new Level(100), new Experience(800_000)),
            };

            foreach ((var lv, var exp) in expTable)
            {
                Experience actual = member.CalculateTotalExp(lv);
                Assert.That(actual, Is.EqualTo(exp),
                    $"Lv.{lv} の累計経験値は {exp} ですが、実際の値は {actual} でした。");
            }
        }

        [Test]
        public void TestCalculateTotalExpOfMediumFast()
        {
            ExperienceType member = ExperienceType.MediumFast;

            var expTable = new List<(Level, Experience)>()
            {
                (new Level(1), new Experience(0)),
                (new Level(2), new Experience(8)),
                (new Level(3), new Experience(27)),
                (new Level(4), new Experience(64)),
                (new Level(5), new Experience(125)),
                (new Level(6), new Experience(216)),
                (new Level(7), new Experience(343)),
                (new Level(8), new Experience(512)),
                (new Level(9), new Experience(729)),
                (new Level(10), new Experience(1_000)),
                (new Level(11), new Experience(1_331)),
                (new Level(12), new Experience(1_728)),
                (new Level(13), new Experience(2_197)),
                (new Level(14), new Experience(2_744)),
                (new Level(15), new Experience(3_375)),
                (new Level(16), new Experience(4_096)),
                (new Level(17), new Experience(4_913)),
                (new Level(18), new Experience(5_832)),
                (new Level(19), new Experience(6_859)),
                (new Level(20), new Experience(8_000)),
                (new Level(21), new Experience(9_261)),
                (new Level(22), new Experience(10_648)),
                (new Level(23), new Experience(12_167)),
                (new Level(24), new Experience(13_824)),
                (new Level(25), new Experience(15_625)),
                (new Level(26), new Experience(17_576)),
                (new Level(27), new Experience(19_683)),
                (new Level(28), new Experience(21_952)),
                (new Level(29), new Experience(24_389)),
                (new Level(30), new Experience(27_000)),
                (new Level(31), new Experience(29_791)),
                (new Level(32), new Experience(32_768)),
                (new Level(33), new Experience(35_937)),
                (new Level(34), new Experience(39_304)),
                (new Level(35), new Experience(42_875)),
                (new Level(36), new Experience(46_656)),
                (new Level(37), new Experience(50_653)),
                (new Level(38), new Experience(54_872)),
                (new Level(39), new Experience(59_319)),
                (new Level(40), new Experience(64_000)),
                (new Level(41), new Experience(68_921)),
                (new Level(42), new Experience(74_088)),
                (new Level(43), new Experience(79_507)),
                (new Level(44), new Experience(85_184)),
                (new Level(45), new Experience(91_125)),
                (new Level(46), new Experience(97_336)),
                (new Level(47), new Experience(103_823)),
                (new Level(48), new Experience(110_592)),
                (new Level(49), new Experience(117_649)),
                (new Level(50), new Experience(125_000)),
                (new Level(51), new Experience(132_651)),
                (new Level(52), new Experience(140_608)),
                (new Level(53), new Experience(148_877)),
                (new Level(54), new Experience(157_464)),
                (new Level(55), new Experience(166_375)),
                (new Level(56), new Experience(175_616)),
                (new Level(57), new Experience(185_193)),
                (new Level(58), new Experience(195_112)),
                (new Level(59), new Experience(205_379)),
                (new Level(60), new Experience(216_000)),
                (new Level(61), new Experience(226_981)),
                (new Level(62), new Experience(238_328)),
                (new Level(63), new Experience(250_047)),
                (new Level(64), new Experience(262_144)),
                (new Level(65), new Experience(274_625)),
                (new Level(66), new Experience(287_496)),
                (new Level(67), new Experience(300_763)),
                (new Level(68), new Experience(314_432)),
                (new Level(69), new Experience(328_509)),
                (new Level(70), new Experience(343_000)),
                (new Level(71), new Experience(357_911)),
                (new Level(72), new Experience(373_248)),
                (new Level(73), new Experience(389_017)),
                (new Level(74), new Experience(405_224)),
                (new Level(75), new Experience(421_875)),
                (new Level(76), new Experience(438_976)),
                (new Level(77), new Experience(456_533)),
                (new Level(78), new Experience(474_552)),
                (new Level(79), new Experience(493_039)),
                (new Level(80), new Experience(512_000)),
                (new Level(81), new Experience(531_441)),
                (new Level(82), new Experience(551_368)),
                (new Level(83), new Experience(571_787)),
                (new Level(84), new Experience(592_704)),
                (new Level(85), new Experience(614_125)),
                (new Level(86), new Experience(636_056)),
                (new Level(87), new Experience(658_503)),
                (new Level(88), new Experience(681_472)),
                (new Level(89), new Experience(704_969)),
                (new Level(90), new Experience(729_000)),
                (new Level(91), new Experience(753_571)),
                (new Level(92), new Experience(778_688)),
                (new Level(93), new Experience(804_357)),
                (new Level(94), new Experience(830_584)),
                (new Level(95), new Experience(857_375)),
                (new Level(96), new Experience(884_736)),
                (new Level(97), new Experience(912_673)),
                (new Level(98), new Experience(941_192)),
                (new Level(99), new Experience(970_299)),
                (new Level(100), new Experience(1_000_000)),
            };

            foreach ((var lv, var exp) in expTable)
            {
                Experience actual = member.CalculateTotalExp(lv);
                Assert.That(actual, Is.EqualTo(exp),
                    $"Lv.{lv} の累計経験値は {exp} ですが、実際の値は {actual} でした。");
            }
        }

        [Test]
        public void TestCalculateTotalExpOfMediumSlow()
        {
            ExperienceType member = ExperienceType.MediumSlow;

            var expTable = new List<(Level, Experience)>()
            {
                (new Level(1), new Experience(0)),
                (new Level(2), new Experience(9)),
                (new Level(3), new Experience(57)),
                (new Level(4), new Experience(96)),
                (new Level(5), new Experience(135)),
                (new Level(6), new Experience(179)),
                (new Level(7), new Experience(236)),
                (new Level(8), new Experience(314)),
                (new Level(9), new Experience(419)),
                (new Level(10), new Experience(560)),
                (new Level(11), new Experience(742)),
                (new Level(12), new Experience(973)),
                (new Level(13), new Experience(1_261)),
                (new Level(14), new Experience(1_612)),
                (new Level(15), new Experience(2_035)),
                (new Level(16), new Experience(2_535)),
                (new Level(17), new Experience(3_120)),
                (new Level(18), new Experience(3_798)),
                (new Level(19), new Experience(4_575)),
                (new Level(20), new Experience(5_460)),
                (new Level(21), new Experience(6_458)),
                (new Level(22), new Experience(7_577)),
                (new Level(23), new Experience(8_825)),
                (new Level(24), new Experience(10_208)),
                (new Level(25), new Experience(11_735)),
                (new Level(26), new Experience(13_411)),
                (new Level(27), new Experience(15_244)),
                (new Level(28), new Experience(17_242)),
                (new Level(29), new Experience(19_411)),
                (new Level(30), new Experience(21_760)),
                (new Level(31), new Experience(24_294)),
                (new Level(32), new Experience(27_021)),
                (new Level(33), new Experience(29_949)),
                (new Level(34), new Experience(33_084)),
                (new Level(35), new Experience(36_435)),
                (new Level(36), new Experience(40_007)),
                (new Level(37), new Experience(43_808)),
                (new Level(38), new Experience(47_846)),
                (new Level(39), new Experience(52_127)),
                (new Level(40), new Experience(56_660)),
                (new Level(41), new Experience(61_450)),
                (new Level(42), new Experience(66_505)),
                (new Level(43), new Experience(71_833)),
                (new Level(44), new Experience(77_440)),
                (new Level(45), new Experience(83_335)),
                (new Level(46), new Experience(89_523)),
                (new Level(47), new Experience(96_012)),
                (new Level(48), new Experience(102_810)),
                (new Level(49), new Experience(109_923)),
                (new Level(50), new Experience(117_360)),
                (new Level(51), new Experience(125_126)),
                (new Level(52), new Experience(133_229)),
                (new Level(53), new Experience(141_677)),
                (new Level(54), new Experience(150_476)),
                (new Level(55), new Experience(159_635)),
                (new Level(56), new Experience(169_159)),
                (new Level(57), new Experience(179_056)),
                (new Level(58), new Experience(189_334)),
                (new Level(59), new Experience(199_999)),
                (new Level(60), new Experience(211_060)),
                (new Level(61), new Experience(222_522)),
                (new Level(62), new Experience(234_393)),
                (new Level(63), new Experience(246_681)),
                (new Level(64), new Experience(259_392)),
                (new Level(65), new Experience(272_535)),
                (new Level(66), new Experience(286_115)),
                (new Level(67), new Experience(300_140)),
                (new Level(68), new Experience(314_618)),
                (new Level(69), new Experience(329_555)),
                (new Level(70), new Experience(344_960)),
                (new Level(71), new Experience(360_838)),
                (new Level(72), new Experience(377_197)),
                (new Level(73), new Experience(394_045)),
                (new Level(74), new Experience(411_388)),
                (new Level(75), new Experience(429_235)),
                (new Level(76), new Experience(447_591)),
                (new Level(77), new Experience(466_464)),
                (new Level(78), new Experience(485_862)),
                (new Level(79), new Experience(505_791)),
                (new Level(80), new Experience(526_260)),
                (new Level(81), new Experience(547_274)),
                (new Level(82), new Experience(568_841)),
                (new Level(83), new Experience(590_969)),
                (new Level(84), new Experience(613_664)),
                (new Level(85), new Experience(636_935)),
                (new Level(86), new Experience(660_787)),
                (new Level(87), new Experience(685_228)),
                (new Level(88), new Experience(710_266)),
                (new Level(89), new Experience(735_907)),
                (new Level(90), new Experience(762_160)),
                (new Level(91), new Experience(789_030)),
                (new Level(92), new Experience(816_525)),
                (new Level(93), new Experience(844_653)),
                (new Level(94), new Experience(873_420)),
                (new Level(95), new Experience(902_835)),
                (new Level(96), new Experience(932_903)),
                (new Level(97), new Experience(963_632)),
                (new Level(98), new Experience(995_030)),
                (new Level(99), new Experience(1_027_103)),
                (new Level(100), new Experience(1_059_860)),
            };

            foreach ((var lv, var exp) in expTable)
            {
                Experience actual = member.CalculateTotalExp(lv);
                Assert.That(actual, Is.EqualTo(exp),
                    $"Lv.{lv} の累計経験値は {exp} ですが、実際の値は {actual} でした。");
            }
        }

        [Test]
        public void TestCalculateTotalExpOfSlow()
        {
            ExperienceType member = ExperienceType.Slow;

            var expTable = new List<(Level, Experience)>()
            {
                (new Level(1), new Experience(0)),
                (new Level(2), new Experience(10)),
                (new Level(3), new Experience(33)),
                (new Level(4), new Experience(80)),
                (new Level(5), new Experience(156)),
                (new Level(6), new Experience(270)),
                (new Level(7), new Experience(428)),
                (new Level(8), new Experience(640)),
                (new Level(9), new Experience(911)),
                (new Level(10), new Experience(1_250)),
                (new Level(11), new Experience(1_663)),
                (new Level(12), new Experience(2_160)),
                (new Level(13), new Experience(2_746)),
                (new Level(14), new Experience(3_430)),
                (new Level(15), new Experience(4_218)),
                (new Level(16), new Experience(5_120)),
                (new Level(17), new Experience(6_141)),
                (new Level(18), new Experience(7_290)),
                (new Level(19), new Experience(8_573)),
                (new Level(20), new Experience(10_000)),
                (new Level(21), new Experience(11_576)),
                (new Level(22), new Experience(13_310)),
                (new Level(23), new Experience(15_208)),
                (new Level(24), new Experience(17_280)),
                (new Level(25), new Experience(19_531)),
                (new Level(26), new Experience(21_970)),
                (new Level(27), new Experience(24_603)),
                (new Level(28), new Experience(27_440)),
                (new Level(29), new Experience(30_486)),
                (new Level(30), new Experience(33_750)),
                (new Level(31), new Experience(37_238)),
                (new Level(32), new Experience(40_960)),
                (new Level(33), new Experience(44_921)),
                (new Level(34), new Experience(49_130)),
                (new Level(35), new Experience(53_593)),
                (new Level(36), new Experience(58_320)),
                (new Level(37), new Experience(63_316)),
                (new Level(38), new Experience(68_590)),
                (new Level(39), new Experience(74_148)),
                (new Level(40), new Experience(80_000)),
                (new Level(41), new Experience(86_151)),
                (new Level(42), new Experience(92_610)),
                (new Level(43), new Experience(99_383)),
                (new Level(44), new Experience(106_480)),
                (new Level(45), new Experience(113_906)),
                (new Level(46), new Experience(121_670)),
                (new Level(47), new Experience(129_778)),
                (new Level(48), new Experience(138_240)),
                (new Level(49), new Experience(147_061)),
                (new Level(50), new Experience(156_250)),
                (new Level(51), new Experience(165_813)),
                (new Level(52), new Experience(175_760)),
                (new Level(53), new Experience(186_096)),
                (new Level(54), new Experience(196_830)),
                (new Level(55), new Experience(207_968)),
                (new Level(56), new Experience(219_520)),
                (new Level(57), new Experience(231_491)),
                (new Level(58), new Experience(243_890)),
                (new Level(59), new Experience(256_723)),
                (new Level(60), new Experience(270_000)),
                (new Level(61), new Experience(283_726)),
                (new Level(62), new Experience(297_910)),
                (new Level(63), new Experience(312_558)),
                (new Level(64), new Experience(327_680)),
                (new Level(65), new Experience(343_281)),
                (new Level(66), new Experience(359_370)),
                (new Level(67), new Experience(375_953)),
                (new Level(68), new Experience(393_040)),
                (new Level(69), new Experience(410_636)),
                (new Level(70), new Experience(428_750)),
                (new Level(71), new Experience(447_388)),
                (new Level(72), new Experience(466_560)),
                (new Level(73), new Experience(486_271)),
                (new Level(74), new Experience(506_530)),
                (new Level(75), new Experience(527_343)),
                (new Level(76), new Experience(548_720)),
                (new Level(77), new Experience(570_666)),
                (new Level(78), new Experience(593_190)),
                (new Level(79), new Experience(616_298)),
                (new Level(80), new Experience(640_000)),
                (new Level(81), new Experience(664_301)),
                (new Level(82), new Experience(689_210)),
                (new Level(83), new Experience(714_733)),
                (new Level(84), new Experience(740_880)),
                (new Level(85), new Experience(767_656)),
                (new Level(86), new Experience(795_070)),
                (new Level(87), new Experience(823_128)),
                (new Level(88), new Experience(851_840)),
                (new Level(89), new Experience(881_211)),
                (new Level(90), new Experience(911_250)),
                (new Level(91), new Experience(941_963)),
                (new Level(92), new Experience(973_360)),
                (new Level(93), new Experience(1_005_446)),
                (new Level(94), new Experience(1_038_230)),
                (new Level(95), new Experience(1_071_718)),
                (new Level(96), new Experience(1_105_920)),
                (new Level(97), new Experience(1_140_841)),
                (new Level(98), new Experience(1_176_490)),
                (new Level(99), new Experience(1_212_873)),
                (new Level(100), new Experience(1_250_000)),
            };

            foreach ((var lv, var exp) in expTable)
            {
                Experience actual = member.CalculateTotalExp(lv);
                Assert.That(actual, Is.EqualTo(exp),
                    $"Lv.{lv} の累計経験値は {exp} ですが、実際の値は {actual} でした。");
            }
        }

        [Test]
        public void TestCalculateTotalExpOfFluctuating()
        {
            ExperienceType member = ExperienceType.Fluctuating;

            var expTable = new List<(Level, Experience)>()
            {
                (new Level(1), new Experience(0)),
                (new Level(2), new Experience(4)),
                (new Level(3), new Experience(13)),
                (new Level(4), new Experience(32)),
                (new Level(5), new Experience(65)),
                (new Level(6), new Experience(112)),
                (new Level(7), new Experience(178)),
                (new Level(8), new Experience(276)),
                (new Level(9), new Experience(393)),
                (new Level(10), new Experience(540)),
                (new Level(11), new Experience(745)),
                (new Level(12), new Experience(967)),
                (new Level(13), new Experience(1_230)),
                (new Level(14), new Experience(1_591)),
                (new Level(15), new Experience(1_957)),
                (new Level(16), new Experience(2_457)),
                (new Level(17), new Experience(3_046)),
                (new Level(18), new Experience(3_732)),
                (new Level(19), new Experience(4_526)),
                (new Level(20), new Experience(5_440)),
                (new Level(21), new Experience(6_482)),
                (new Level(22), new Experience(7_666)),
                (new Level(23), new Experience(9_003)),
                (new Level(24), new Experience(10_506)),
                (new Level(25), new Experience(12_187)),
                (new Level(26), new Experience(14_060)),
                (new Level(27), new Experience(16_140)),
                (new Level(28), new Experience(18_439)),
                (new Level(29), new Experience(20_974)),
                (new Level(30), new Experience(23_760)),
                (new Level(31), new Experience(26_811)),
                (new Level(32), new Experience(30_146)),
                (new Level(33), new Experience(33_780)),
                (new Level(34), new Experience(37_731)),
                (new Level(35), new Experience(42_017)),
                (new Level(36), new Experience(46_656)),
                (new Level(37), new Experience(50_653)),
                (new Level(38), new Experience(55_969)),
                (new Level(39), new Experience(60_505)),
                (new Level(40), new Experience(66_560)),
                (new Level(41), new Experience(71_677)),
                (new Level(42), new Experience(78_533)),
                (new Level(43), new Experience(84_277)),
                (new Level(44), new Experience(91_998)),
                (new Level(45), new Experience(98_415)),
                (new Level(46), new Experience(107_069)),
                (new Level(47), new Experience(114_205)),
                (new Level(48), new Experience(123_863)),
                (new Level(49), new Experience(131_766)),
                (new Level(50), new Experience(142_500)),
                (new Level(51), new Experience(151_222)),
                (new Level(52), new Experience(163_105)),
                (new Level(53), new Experience(172_697)),
                (new Level(54), new Experience(185_807)),
                (new Level(55), new Experience(196_322)),
                (new Level(56), new Experience(210_739)),
                (new Level(57), new Experience(222_231)),
                (new Level(58), new Experience(238_036)),
                (new Level(59), new Experience(250_562)),
                (new Level(60), new Experience(267_840)),
                (new Level(61), new Experience(281_456)),
                (new Level(62), new Experience(300_293)),
                (new Level(63), new Experience(315_059)),
                (new Level(64), new Experience(335_544)),
                (new Level(65), new Experience(351_520)),
                (new Level(66), new Experience(373_744)),
                (new Level(67), new Experience(390_991)),
                (new Level(68), new Experience(415_050)),
                (new Level(69), new Experience(433_631)),
                (new Level(70), new Experience(459_620)),
                (new Level(71), new Experience(479_600)),
                (new Level(72), new Experience(507_617)),
                (new Level(73), new Experience(529_063)),
                (new Level(74), new Experience(559_209)),
                (new Level(75), new Experience(582_187)),
                (new Level(76), new Experience(614_566)),
                (new Level(77), new Experience(639_146)),
                (new Level(78), new Experience(673_863)),
                (new Level(79), new Experience(700_115)),
                (new Level(80), new Experience(737_280)),
                (new Level(81), new Experience(765_275)),
                (new Level(82), new Experience(804_997)),
                (new Level(83), new Experience(834_809)),
                (new Level(84), new Experience(877_201)),
                (new Level(85), new Experience(908_905)),
                (new Level(86), new Experience(954_084)),
                (new Level(87), new Experience(987_754)),
                (new Level(88), new Experience(1_035_837)),
                (new Level(89), new Experience(1_071_552)),
                (new Level(90), new Experience(1_122_660)),
                (new Level(91), new Experience(1_160_499)),
                (new Level(92), new Experience(1_214_753)),
                (new Level(93), new Experience(1_254_796)),
                (new Level(94), new Experience(1_312_322)),
                (new Level(95), new Experience(1_354_652)),
                (new Level(96), new Experience(1_415_577)),
                (new Level(97), new Experience(1_460_276)),
                (new Level(98), new Experience(1_524_731)),
                (new Level(99), new Experience(1_571_884)),
                (new Level(100), new Experience(1_640_000)),
            };

            foreach ((var lv, var exp) in expTable)
            {
                Experience actual = member.CalculateTotalExp(lv);
                Assert.That(actual, Is.EqualTo(exp),
                    $"Lv.{lv} の累計経験値は {exp} ですが、実際の値は {actual} でした。");
            }
        }
    }
}