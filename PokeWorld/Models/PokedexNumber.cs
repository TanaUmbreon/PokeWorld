namespace PokeWorld.Models
{
    /// <summary>
    /// 図鑑番号を格納するレコードです。
    /// </summary>
    public record PokedexNumberSet(
        int National,
        int? Johto = null,
        int? Hoenn = null,
        int? Sinnoh = null,
        int? NewJohto = null,
        int? Unova = null,
        int? NewUnova = null,
        int? CentralKalos = null,
        int? CoastalKalos = null,
        int? MountainKalos = null,
        int? NewHoenn = null,
        int? Alola = null,
        int? Melemele = null,
        int? Akala = null,
        int? Ulaula = null,
        int? Poni = null,
        int? NewAlola = null,
        int? NewMelemele = null,
        int? NewAkala = null,
        int? NewUlaula = null,
        int? NewPoni = null,
        int? Galar = null,
        int? IsleOfArmor = null,
        int? CrownTundra = null
        )
    {
        /// <summary>
        /// 全国図鑑での図鑑番号を取得します。
        /// </summary>
        public int National { get; init; } = National;

        /// <summary>
        /// ジョウト図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// </summary>
        public int? Johto { get; init; } = Johto;

        /// <summary>
        /// ホウエン図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? Hoenn { get; init; } = Hoenn;

        /// <summary>
        /// シンオウ図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? Sinnoh { get; init; } = Sinnoh;

        /// <summary>
        /// 新ジョウト図鑑 (ハートゴールド・ソウルシルバー) での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? NewJohto { get; init; } = NewJohto;

        /// <summary>
        /// イッシュ図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? Unova { get; init; } = Unova;

        /// <summary>
        /// 新イッシュ図鑑 (ブラック2・ホワイト2) での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? NewUnova { get; init; } = NewUnova;

        /// <summary>
        /// セントラルカロス図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? CentralKalos { get; init; } = CentralKalos;

        /// <summary>
        /// コーストカロス図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? CoastalKalos { get; init; } = CoastalKalos;

        /// <summary>
        /// マウンテンカロス図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? MountainKalos { get; init; } = MountainKalos;

        /// <summary>
        /// 新ホウエン図鑑 (オメガルビー・アルファサファイア) での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? NewHoenn { get; init; } = NewHoenn;

        /// <summary>
        /// アローラ図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? Alola { get; init; } = Alola;

        /// <summary>
        /// メレメレ図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? Melemele { get; init; } = Melemele;

        /// <summary>
        /// アーカラ図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? Akala { get; init; } = Akala;

        /// <summary>
        /// ウラウラ図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? Ulaula { get; init; } = Ulaula;

        /// <summary>
        /// ポニ図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? Poni { get; init; } = Poni;

        /// <summary>
        /// 新アローラ図鑑 (ウルトラサン・ウルトラムーン) での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? NewAlola { get; init; } = NewAlola;

        /// <summary>
        /// 新メレメレ図鑑 (ウルトラサン・ウルトラムーン) での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? NewMelemele { get; init; } = NewMelemele;

        /// <summary>
        /// 新アーカラ図鑑 (ウルトラサン・ウルトラムーン) での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? NewAkala { get; init; } = NewAkala;

        /// <summary>
        /// 新ウラウラ図鑑 (ウルトラサン・ウルトラムーン) での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? NewUlaula { get; init; } = NewUlaula;

        /// <summary>
        /// 新ポニ図鑑 (ウルトラサン・ウルトラムーン) での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? NewPoni { get; init; } = NewPoni;

        /// <summary>
        /// ガラル図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? Galar { get; init; } = Galar;

        /// <summary>
        /// ヨロイじま図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? IsleOfArmor { get; init; } = IsleOfArmor;

        /// <summary>
        /// カンムリせつげん図鑑での図鑑番号を取得します。図鑑に載っていない場合は null を返します。
        /// <summary>
        public int? CrownTundra { get; init; } = CrownTundra;
    }
}
