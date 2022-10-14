using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// All Pok�mon should be listed here.
/// </summary>
public enum PokemonID
{
    //Kanto
    BULBASAUR = 1,
    IVYSAUR,
    VENASAUR,
    CHARMANDER,
    CHARMELEON,
    CHARIZARD,
    SQUIRTLE,
    WARTORTLE,
    BLASTOISE,
    CATERPIE,
    METAPOD,
    BUTTERFREE,
    WEEDLE,
    KAKUNA,
    BEEDRILL,
    PIDGEY,
    PIDGEOTTO,
    PIDGEOT,
    RATTATA,
    RATICATE,
    SPEAROW,
    FEAROW,
    EKANS,
    ARBOK,
    PIKACHU,
    RAICHU,
    SANDSHREW,
    SANDSLASH,
    NIDORANF,
    NIDORINA,
    NIDOQUEEN,
    NIDORANM,
    NIDORINO,
    NIDOKING,
    CLEFAIRY,
    CLEFABLE,
    VULPIX,
    NINETALES,
    JIGGLYPUFF,
    WIGGLYTUFF,
    ZUBAT,
    GOLBAT,
    ODDISH,
    GLOOM,
    VILEPLUME,
    PARAS,
    PARASECT,
    VENOMAT,
    VENOMOTH,
    DIGLETT,
    DUGTRIO,
    MEOWTH,
    PERSIAN,
    PSYDUCK,
    GOLDUCK,
    MANKEY,
    PRIMEAPE,
    GROWLITHE,
    ARCANINE,
    POLIWAG,
    POLIWHIRL,
    POLIWRATH,
    ABRA,
    KADABRA,
    ALAKAZAM,
    MACHOP,
    MACHOKE,
    MACHAMP,
    BELLSPROUT,
    WEEPINBELL,
    VICTREEBEL,
    TENTACOOL,
    TENTACRUEL,
    GEODUDE,
    GRAVELER,
    GOLEM,
    PONYTA,
    RAPIDASH,
    SLOWPOKE,
    SLOWBRO,
    MAGNEMITE,
    MAGNETON,
    FARFETCHD,
    DODUO,
    DODRIO,
    SEEL,
    DEWGONG,
    GRIMER,
    MUK,
    SHELLDER,
    CLOYTER,
    GASTLY,
    HAUNTER,
    GENGAR,
    ONIX,
    DROWZEE,
    HYPNO,
    KRABBY,
    KINGLER,
    VOLTORB,
    ELECTROBE,
    EXEGGCUTE,
    EXEGGUTOR,
    CUBONE,
    MAROWAK,
    HITMONLEE,
    HITMONCHAN,
    LICKITUNG,
    KOFFING,
    WEEZING,
    RHYHORN,
    RHYDON,
    CHANSEY,
    TANGELA,
    KANGASKHAN,
    HORSEA,
    SEADRA,
    GOLDEEN,
    SEAKING,
    STARYU,
    STARMIE,
    MRMIME,
    SCYTHER,
    JYNX,
    ELECTABUZZ,
    MAGMAR,
    PINSIR,
    TAUROS,
    MAGIKARP,
    GYARADOS,
    LAPRAS,
    DITTO,
    EEVEE,
    VAPOREON,
    JOLTEON,
    FLAREON,
    PORYGON,
    OMANYTE,
    OMASTAR,
    KABUTO,
    KABUTOPS,
    AERODACTYL,
    SNORLAX,
    ARTICUNO,
    ZAPDOS,
    MOLTRES,
    DRATINI,
    DRAGONAIR,
    DRAGONITE,
    MEWTWO,
    MEW,
    //Johto
    CHIKORITA,
    BAYLEEF,
    MEGANIUM,
    CYNDAQUIL,
    QUILAVA,
    TYPHLOSION,
    TOTODILE,
    CROCONAW,
    FERALIGATR,
    SENTRET,
    FURRET,
    HOOTHOOT,
    NOCTOWL,
    LEDYBA,
    LEDIAN,
    SPINARAK,
    ARIADOS,
    CROBAT,
    CHINCHOU,
    LANTURN,
    PICHU,
    CLEFFA,
    IGGLYBUFF,
    TOGEPI,
    TOGETIC,
    NATU,
    XATU,
    MAREEP,
    FLAAFFY,
    AMPHAROS,
    BELLOSSOM,
    MARILL,
    AZUMARILL,
    SUDOWOODO,
    POLITOED,
    HOPPIP,
    SKIPLOOM,
    JUMPLUFF,
    AIPOM,
    SUNKERN,
    SUNFLORA,
    YANMA,
    WOOPER,
    QUAGSIRE,
    ESPEON,
    UMBREON,
    MURKROW,
    SLOWKING,
    MISDREAVUS,
    UNOWN,
    WOBBUFFET,
    GIRAFARIG,
    PINECO,
    FORRETRESS,
    DUNSPARCE,
    GLIGAR,
    STEELIX,
    SNUBBULL,
    GRANBULL,
    QWILFISH,
    SCIZOR,
    SHUCKLE,
    HERACROSS,
    SNEALEL,
    TEDDIURSA,
    URSARING,
    SLUGMA,
    MAGCARGO,
    SWINUB,
    PILOSWINE,
    CORSOLA,
    REMORAID,
    OCTILLERY,
    DELIBIRD,
    MANTINE,
    SKARMORY,
    HOUNDOUR,
    HOUNDOOM,
    KINGDRA,
    PHANPY,
    DONPHAN,
    PORYGON2,
    STANTLER,
    SMEARGLE,
    TYROUGE,
    HITMONTOP,
    SMOOCHUM,
    ELEKID,
    MAGBY,
    MILTANK,
    BLISSEY,
    RAIKOU,
    ENTEI,
    SUICUNE,
    LARVITAR,
    PUPITAR,
    TYRANITAR,
    LUGIA,
    HOOH,
    CELEBI,
    //Hoenn
    TREECKO,
    GROVYLE,
    SCEPTILE,
    TORCHIC,
    COMBUSKEN,
    BLAZIKEN,
    MUDKIP,
    MARSHTOMP,
    SWAMPERT,
    POOCHYENA,
    MIGHTYENA,
    ZIGZAGOON,
    LINOONE,
    WURMPLE,
    SILCOON,
    BEAUTIFLY,
    CASCOON,
    DUSTOX,
    LOTAD,
    LOMBRE,
    LUDICOLO,
    SEEDOT,
    NUZLEAF,
    SHIFTRY,
    TAILOW,
    SWELLOW,
    WINGULL,
    PELIPPER,
    RALTS,
    KIRLIA,
    GARDEVOIR,
    SURSKIT,
    MASQUERAIN,
    SHROOMISH,
    BRELOOM,
    SLAKOTH,
    VIGOROTH,
    SLAKING,
    NINCADA,
    NINJASK,
    SHEDINJA,
    WHISMUR,
    LOUDRED,
    EXPLOUD,
    MAKUHITA,
    HARIYAMA,
    AZURILL,
    NOSEPASS,
    SKITTY,
    DELCATTY,
    SABLEYE,
    MAWILE,
    ARON,
    LAIRON,
    AGGRON,
    MEDITITE,
    MEDICHAM,
    ELECTRIKE,
    MANECTRIC,
    PLUSLE,
    MINUN,
    VOLBEAT,
    ILLUMISE,
    ROSELIA,
    GULPIN,
    SWALOT,
    CARVANHA,
    SHARPEDO,
    WAILMER,
    WAILORD,
    NUMEL,
    CAMERUPT,
    TORKOAL,
    SPOINK,
    GRUMPIG,
    SPINDA,
    TRAPINCH,
    VIBRAVA,
    FLYGON,
    CACNEA,
    CACTURNE,
    SWABLU,
    ALTARIA,
    ZANGOOSE,
    SEVIPER,
    LUNATONE,
    SOLROCK,
    BARBOACH,
    WHISCASH,
    CORPHISH,
    CRAWDAUNT,
    BALTOY,
    CLAYDOL,
    LILEEP,
    CRADILY,
    ANORITH,
    ARMALDO,
    FEEBAS,
    MILOTIC,
    CASTFORM,
    KECLEON,
    SHUPPET,
    BANETTE,
    DUSKULL,
    DUSCLOPS,
    TROPIUS,
    CHIMECHO,
    ABSOL,
    WYNAUT,
    SNORUNT,
    GLALIE,
    SPHEAL,
    SEALEO,
    WALREIN,
    CLAMPERL,
    HUNTAIL,
    GOREBYSS,
    RELICANTH,
    LUVDISC,
    BAGON,
    SHELGON,
    SALAMENCE,
    BELDUM,
    METANG,
    METAGROSS,
    REGIROCK,
    REGICE,
    REGISTEEL,
    LATIAS,
    LATIOS,
    KYOGRE,
    GROUDON,
    RAYQUAZA,
    JIRACHI,
    DEOXYS,

    //Sinnoh

    TURTWIG,
    GROTLE,
    TORTERRA,
    CHIMCHAR,
    MONFERNO,
    INFERNAPE,
    PIPLUP,
    PRINPLUP,
    EMPOLEON,
    STARLY,
    STARAVIA,
    STARAPTOR,
    BIDOOF,
    BIBAREL,
    KRICKETOT,
    KRICKETUNE,
    SHINX,
    LUXIO,
    LUXRAY,
    BUDEW,
    ROSERADE,
    CRANIDOS,
    RAMPARDOS,
    SHIELDON,
    BASTIODON,
    BURMY,
    WORMADAM,
    MOTHIM,
    COMBEE,
    VESPIQUEN,
    PACHIRISU,
    BUIZEL,
    FLOATZEL,
    CHERUBI,
    CHERRIM,
    SHELLOS,
    GASTRODON,
    AMBIPOM,
    DRIFLOON,
    DRIFBLIM,
    BUNEARY,
    LOPUNNY,
    MISMAGIUS,
    HONCHKROW,
    GLAMEOW,
    PURUGLY,
    CHINGLING,
    STUNKY,
    SKUNTANK,
    BRONZOR,
    BRONZONG,
    BONSLY,
    MIMEJR,
    HAPPINY,
    CHATOT,
    SPIRITOMB,
    GIBLE,
    GABITE,
    GARCHOMP,
    MUNCHLAX,
    RIOLU,
    LUCARIO,
    HIPPOPOTAS,
    HIPPOWDON,
    SKORUPI,
    DRAPION,
    CROAGUNK,
    TOXICROAK,
    CARNIVINE,
    FINNEON,
    LUMINEON,
    MANTYKE,
    SNOVER,
    ABOMASNOW,
    WEAVILE,
    MAGNEZONE,
    LICKILICKY,
    RHYPERIOR,
    TANGROWTH,
    ELECTRIVIRE,
    MAGMORTAR,
    TOGEKISS,
    YANMEGA,
    LEAFEON,
    GLACEON,
    GLISCOR,
    MAMOSWINE,
    PORYGONZ,
    GALLADE,
    PROBOPASS,
    DUSKNOIR,
    FROSLASS,
    ROTOM,
    UXIE,
    MESPRIT,
    AZELF,
    DIALGA,
    PALKIA,
    HEATRAN,
    REGIGIGAS,
    GIRATINA,
    CRESSELIA,
    PHIONE,
    MANAPHY,
    DARKRAI,
    SHAYMIN,
    ARCEUS,
    VICTINI,
    SNIVY,
    SERVINE,
    SERPERIOR,
    TEPIG,
    PIGNITE,
    EMBOAR,
    OSHAWOTT,
    DEWOTT,
    SAMUROTT,
    PATRAT,
    WATCHOG,
    LILLIPUP,
    HERDIER,
    STOUTLAND,
    PURRLOIN,
    LIEPARD,
    PANSAGE,
    SIMISAGE,
    PANSEAR,
    SIMISEAR,
    PANPOUR,
    SIMIPOUR,
    MUNNA,
    MUSHARNA,
    PIDOVE,
    TRANQUILL,
    UNFEZANT,
    BLITZLE,
    ZEBSTRIKA,
    ROGGENROLA,
    BOLDORE,
    GIGALITH,
    WOOBAT,
    SWOOBAT,
    DRILBUR,
    EXCADRILL,
    AUDINO,
    TIMBURR,
    GURDURR,
    CONKELDURR,
    TYMPOLE,
    PALPITOAD,
    SEISMITOAD,
    THROH,
    SAWK,
    SEWADDLE,
    SWADLOON,
    LEAVANNY,
    VENIPEDE,
    WHIRLIPEDE,
    SCOLIPEDE,
    COTTONEE,
    WHIMSICOTT,
    PETILIL,
    LILLIGANT,
    BASCULIN,
    SANDILE,
    KROKOROK,
    KROOKODILE,
    DARUMAKA,
    DARMANITAN,
    MARACTUS,
    DWEBBLE,
    CRUSTLE,
    SCRAGGY,
    SCRAFTY,
    SIGILYPH,
    YAMASK,
    COFAGRIGUS,
    TIRTOUGA,
    CARRACOSTA,
    ARCHEN,
    ARCHEOPS,
    TRUBBISH,
    GARBODOR,
    ZORUA,
    ZOROARK,
    MINCCINO,
    CINCCINO,
    GOTHITA,
    GOTHORITA,
    GOTHITELLE,
    SOLOSIS,
    DUOSION,
    REUNICLUS,
    DUCKLETT,
    SWANNA,
    VANILLITE,
    VANILLISH,
    VANILLUXE,
    DEERLING,
    SAWSBUCK,
    EMOLGA,
    KARRABLAST,
    ESCAVALIER,
    FOONGUS,
    AMOONGUSS,
    FRILLISH,
    JELLICENT,
    ALOMOMOLA,
    JOLTIK,
    GALVANTULA,
    FERROSEED,
    FERROTHORN,
    KLINK,
    KLANK,
    KLINKLANG,
    TYNAMO,
    EELEKTRIK,
    EELEKTROSS,
    ELGYEM,
    BEHEEYEM,
    LITWICK,
    LAMPENT,
    CHANDELURE,
    AXEW,
    FRAXURE,
    HAXORUS,
    CUBCHOO,
    BEARTIC,
    CRYOGONAL,
    SHELMET,
    ACCELGOR,
    STUNFISK,
    MIENFOO,
    MIENSHAO,
    DRUDDIGON,
    GOLETT,
    GOLURK,
    PAWNIARD,
    BISHARP,
    BOUFFALANT,
    RUFFLET,
    BRAVIARY,
    VULLABY,
    MANDIBUZZ,
    HEATMOR,
    DURANT,
    DEINO,
    ZWEILOUS,
    HYDREIGON,
    LARVESTA,
    VOLCARONA,
    COBALION,
    TERRAKION,
    VIRIZION,
    TORNADUS,
    THUNDURUS,
    RESHIRAM,
    ZEKROM,
    LANDORUS,
    KYUREM,
    KELDEO,
    MELOETTA,
    GENESECT,
    //Kalos
    CHESPIN,
    QUILLADIN,
    CHESNAUGHT,
    FENNEKIN,
    BRAIXEN,
    DELPOX,
    FROAKIE,
    FROGADIER,
    GRENINJA,
    BUNNELBY,
    DIGGERSBY,
    FLETCHLING,
    FLETCHINDER,
    TALONFLAME,
    SCATTERBUG,
    SPEWPA,
    VIVILLON,
    LITLEO,
    PYROAR,
    FLABEBE,
    FLOETTE,
    FLORGES,
    SKIDDO,
    GOGOAT,
    PANCHAM,
    PANGORO,
    FURFROU,
    ESPURR,
    MEOWSTIC,
    HONEDGE,
    DOUBLADE,
    AEGISLASH,
    SPRITZEE,
    AROMATISSE,
    SWIRLIX,
    SLURPUFF,
    INKAY,
    MALAMAR,
    BINACLE,
    BARBARACLE,
    SKRELP,
    DRAGALGE,
    CLAUNCHER,
    CLAWITZER,
    HELIOPTILE,
    HELIOLISK,
    TYRUNT,
    TYRANTRUM,
    AMAURA,
    AURORUS,
    SYLVEON,
    HAWLUCHA,
    DEDENNE,
    CARBINK,
    GOOMY,
    SLIGGOO,
    GOODRA,
    KELFKI,
    PHANTUMP,
    TREVENANT,
    PUMPKABOO,
    GOURGIEST,
    BERGMITE,
    AVALUGG,
    NOIBAT,
    NOIVERN,
    XERNEAS,
    YVELTAL,
    ZYGARDE,
    DIANCIE,
    HOOPA,
    VOLCANION,
    //Alola
    ROWLET,
    DARTRIX,
    DECIDUEYE,
    LITTEN,
    TORRACAT,
    INCINEROAR,
    POPPLIO,
    BRIONNE,
    PRIMARINA,
    PIKIPEK,
    TRUMBEAK,
    TOUCANNON,
    YUNGOOS,
    GUMSHOOS,
    GRUBBIN,
    CHARJABUG,
    VIKAVOLT,
    CRABRAWLER,
    CRABOMINABLE,
    ORICORIO,
    CUTIEFLY,
    RIBOMBEE,
    ROCKRUFF,
    LYCANROC,
    WISHIWASHI,
    MAREANIE,
    TOXAPEX,
    MUDBRAY,
    MUDSDALE,
    DEWPIDER,
    ARAQUANID,
    FOMANTIS,
    LURANTIS,
    MORELULL,
    SHIINOTIC,
    SALANDIT,
    SALAZZLE,
    STUFFUL,
    BEWEAR,
    BOUSWEET,
    STEENEE,
    TSAREENA,
    COMFEY,
    ORANGURU,
    PASSIMIAN,
    WIMPOD,
    GOLISOPOD,
    SANDYGAST,
    PALOSSAND,
    PYUKUMUKU,
    TYPENULL,
    SILVALLY,
    MINIOR,
    KOMALA,
    TURTONATOR,
    TOGEDEMARU,
    MIMIKYU,
    BRUXISH,
    DRAMPA,
    DHELMISE,
    JANGMOO,
    HAKAMOO,
    KOMMOO,
    TAPUKOKO,
    TAPULELE,
    TAPUBULU,
    FAPUFINI,
    COSMOG,
    COSMOEM,
    SOLGALEO,
    LUNALA,
    NIJILEGO,
    BUZZWOLE,
    PHEROMOSA,
    XURKITREE,
    CELESTEELA,
    KARTANA,
    GUZZLORD,
    NECROZMA,
    MAGEARNA,
    MARSHADOW,
    POIPOLE,
    NAGANADEL,
    STAKATAKA,
    BLACEPHALON,
    ZERAORA,
    MELTAN,
    MELMETAL,
    //Galar
    GROOKEY,
    THWACKEY,
    RILLABOOM,
    SCORBUNNY,
    RABOOT,
    CINDERACE,
    SOBBLE,
    DRIZZILE,
    INTELEON,
    SKWOVET,
    GREEDENT,
    ROOKIDEE,
    CORVISQUIRE,
    CORVIKNIGHT,
    BLIPBUG,
    DOTTLER,
    ORBEETLE,
    NICKIT,
    THIEVUL,
    GOSSIFLEUR,
    ELDEGOSS,
    WOOLOO,
    DUBWOOL,
    CHEWTLE,
    DREDNAW,
    YAMPER,
    BOLTUND,
    ROLYCOLY,
    CARKOL,
    COALOSSAL,
    APPLIN,
    FLAPPLE,
    APPLETUN,
    SILICOBRA,
    SANDACONDA,
    CRAMORANT,
    ARROKUDA,
    BARRASKEWDA,
    TOXEL,
    TOXTRICITY,
    SIZZLIPEDE,
    CENTISKORCH,
    CLOBBOPUS,
    GRAPPLOCT,
    SINISTEA,
    POLTEAGEIST,
    HATENNA,
    HATTREM,
    HATTERENE,
    IMPIDIMP,
    MORGREM,
    GRIMMSNARL,
    OBSTAGOON,
    PERRSERKER,
    CURSOLA,
    SIRFETCHD,
    MRRIME,
    RUNERIGUS,
    MILCERY,
    ALCREMIE,
    FALINKS,
    PINCURCHIN,
    SNOM,
    FROSMOTH,
    STONJOURNER,
    EISCUE,
    INDEEDEE,
    MORPEKO,
    CUFANT,
    COPPERAJAH,
    DRACOZOLT,
    ARCTOZOLT,
    DRACOVISH,
    ARCTOVISH,
    DURALUDON,
    DREEPY,
    DRAKLOAK,
    DRAGAPULT,
    ZACIAN,
    ZAMAZENTA,
    ETERNATUS,
    KUBFU,
    URSHIFU,
    ZARUDE,
    REGIELEKI,
    REGIDRAGO,
    GLASTRIER,
    SPECTRIER,
    CALYREX,
    WYRDEER,
    KLEAVOR,
    URSALUNA,
    BASCULEGION,
    SNEASLER,
    OVERQWIL,
    ENAMORUS
};
public enum GenderRatio
{
    Genderless = -1, //Genderless
    AlwaysFemale, //100% Female/0% Male
    MaleOneEighth, //87.5% Female/12.5% Male
    MaleOneFourth, //75% Female/25% Male
    MaleOneHalf = 4, //50% Female/50% Male
    FemaleOneFourth = 6, //25% Female/75% Male
    FemaleOneEighth, //12.5% Female/12.5% Male
    AlwaysMale //0% Female/100% Male

}
public enum GrowthRates
{
    Erratic,
    Fast,
    MediumFast,
    MediumSlow,
    Slow,
    Fluctuating
}
public enum EggGroups
{
    Undiscovered = -1,
    GenderlessEggGroup,
    Monster,
    Bug,
    Flying,
    Field,
    Fairy,
    Grass,
    HumanLike,
    Mineral,
    Amorphous,
    Ditto,
    Dragon,
};

[Serializable]
public struct Types
{
    public Type Type1;
    public Type Type2;
}
[Serializable]
public struct Stats
{
    public int HP;
    public int Attack;
    public int Defense;
    public int SpecialAttack;
    public int SpecialDefense;
    public int Speed;
}
[Serializable]
public struct EVYield
{
    public enum StatID
    {
        HP,
        ATTACK,
        DEFENSE,
        SPATTACK,
        SPDEFENSE,
        SPEED
    }

    public StatID Stat;
    public int Yeild;
}

[CreateAssetMenu(fileName = "NewSpecies", menuName = "GameData/Species")]
public class Species : ScriptableObject
{
    [SerializeField]
    private int _NatDexID;
    private PokemonID _internalName;
    [SerializeField]
    private string _name;
    [SerializeField]
    private Types _types;
    [SerializeField]
    private Stats _stats;
    [SerializeField]
    [Tooltip("The Gender Ratio of this Pok�mon.")]
    private GenderRatio _ratio;
    [SerializeField]
    private GrowthRates _growth;
    private AbilityObject _ability;

    [SerializeField]
    private int _expYield = 0;

    [SerializeField]
    private EVYield[] _eVYields;

    [SerializeField]
    private int _catchRate = 0;
    [SerializeField]
    private int _baseHappiness = 0;

    public Types Types => _types;
    public Stats Stats => _stats;
    public EVYield[] EVYields => _eVYields;
    public GenderRatio Ratio => _ratio;

    public void Initialize()
    {
        _internalName = (PokemonID)_NatDexID;
    }
}
