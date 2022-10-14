using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AbilityID
{
    STENCH = 1,
    DRIZZLE,
    SPEEDBOOST,
    BATTLEARMOR,
    STURDY,
    DAMP,
    LIMBER,
    SANDVEIL,
    STATIC,
    VOLTABSORB,
    WATERABSORB,
    OBLIVIOUS,
    CLOUDNINE,
    COMPOUNDEYES,
    INSOMNIA,
    COLORCHANGE,
    IMMUNITY,
    FLASHFIRE,
    SHIELDDUST,
    OWNTEMPO,
    SUCTIONCUPS,
    INTIMIDATE,
    SHADOWTAG,
    ROUGHSKIN,
    WONDERGUARD,
    LEVITATE,
    EFFECTSPORE,
    SYNCHRONIZE,
    CLEARBODY,
    NATURALCURE,
    LIGHTNINGROD,
    SERENEGRACE,
    SWIFTSWIM,
    CHLOROPHYLL,
    ILLUMINATE,
    TRACE,
    HUGEPOWER,
    POISONPOINT,
    INNERFOCUS,
    MAGMAARMOR,
    WATERVEIL,
    MAGNETPULL,
    SOUNDPROOF,
    RAINDISH,
    SANDSTREAM,
    PRESSURE,
    THICKFAT,
    EARLYBIRD,
    FLAMEBODY,
    RUNAWAY,
    KEENEYE,
    HYPERCUTTER,
    PICKUP,
    TRUANT,
    HUSTLE,
    CUTECHARM,
    PLUS,
    MINUS,
    FORECAST,
    STICKYHOLD,
    SHEDSKIN,
    GUTS,
    MARVELSCALE,
    LIQUIDOOZE,
    OVERGROW,
    BLAZE,
    TORRENT,
    SWARM,
    ROCKHEAD,
    DROUGHT,
    ARENATRAP,
    VITALSPIRIT,
    WHITESMOKE,
    PUREPOWER,
    SHELLARMOR,
    AIRLOCK,
    TANGLEDFEET,
    MOTORDRIVE,
    RIVALRY,
    STEADFAST,
    SNOWCLOAK,
    GLUTTONY,
    ANGERPOINT,
    UNBURDEN,
    HEATPROOF,
    SIMPLE,
    DRYSKIN,
    DOWNLOAD,
    IRONFIST,
    POISONHEAL,
    ADAPTABILITY,
    SKILLLINK,
    HYDRATION,
    SOLARPOWER,
    QUICKFEET,
    NORMALIZE,
    SNIPER,
    MAGICGUARD,
    NOGUARD,
    STALL,
    TECHNICIAN,
    LEAFGUARD,
    KLUTZ,
    MOLDBREAKER,
    SUPERLUCK,
    AFTERMATH,
    ANTICIPATION,
    FOREWARN,
    UNAWARE,
    TINTEDLENS,
    FILTER,
    SLOWSTART,
    SCRAPPY,
    STORMDRAIN,
    ICEBODY,
    SOLIDROCK,
    SNOWWARNING,
    HONEYGATHER,
    FRISK,
    RECKLESS,
    MULTITYPE,
    FLOWERGIFT,
    BADDREAMS,
    PICKPOCKET,
    SHEERFORCE,
    CONTRARY,
    UNNERVE,
    DEFIANT,
    DEFEATIST,
    CURSEDBODY,
    HEALER,
    FRIENDGUARD,
    WEAKARMOR,
    HEAVYMETAL,
    LIGHTMETAL,
    MULTISCALE,
    TOXICBOOST,
    FLAREBOOST,
    HARVEST,
    TELEPATHY,
    MOODY,
    OVERCOAT,
    POISONTOUCH,
    REGENERATOR,
    BIGPECKS,
    SANDRUSH,
    WONDERSKIN,
    ANALYTIC,
    ILLUSION,
    IMPOSTER,
    INFILTRATOR,
    MUMMY,
    MOXIE,
    JUSTIFIED,
    RATTLED,
    MAGICBOUNCE,
    SAPSIPPER,
    PRANKSTER,
    SANDFORCE,
    IRONBARBS,
    ZENMODE,
    VICTORYSTAR,
    TURBOBLAZE,
    TERAVOLT,
    AROMAVEIL,
    FLOWERVEIL,
    CHEEKPOUCH,
    PROTEAN,
    FURCOAT,
    MAGICIAN,
    BULLETPROOF,
    COMPETITIVE,
    STRONGJAW,
    REFRIGERATE,
    SWEETVEIL,
    STANCECHANGE,
    GALEWINGS,
    MEGALAUNCHER,
    GRASSPELT,
    SYMBIOSIS,
    TOUGHCLAWS,
    PIXILATE,
    GOOEY,
    AERILATE,
    PARENTALBOND,
    DARKAURA,
    FAIRYAURA,
    AURABREAK,
    PRIMORDIALSEA,
    DESOLATELAND,
    DELTASTREAM,
    STAMINA,
    WIMPOUT,
    EMERGENCYEXIT,
    WATERCOMPACTION,
    MERCILESS,
    SHIELDSDOWN,
    STAKEOUT,
    WATERBUBBLE,
    STEELWORKER,
    BERSERK,
    SLUSHRUSH,
    LONGREACH,
    LIQUIDVOICE,
    TRIAGE,
    GALVANIZE,
    SURGESURFER,
    SCHOOLING,
    DISGUISE,
    BATTLEBOND,
    POWERCONSTRUCT,
    CORROSION,
    COMATOSE,
    QUEENLYMAJESTY,
    INNARDSOUT,
    DANCER,
    BATTERY,
    FLUFFY,
    DAZZLING,
    SOULHEART,
    TANGLINGHAIR,
    RECEIVER,
    POWEROFALCHEMY,
    BEASTBOOST,
    RKSSYSTEM,
    ELECTRICSURGE,
    PSYCHICSURGE,
    MISTYSURGE,
    GRASSYSURGE,
    FULLMETALBODY,
    SHADOWSHIELD,
    PRISMARMOR,
    NEUROFORCE,
    INTREPIDSWORD,
    DAUNTLESSSHIELD,
    LIBERO,
    BALLFETCH,
    COTTONDOWN,
    PROPELLERTAIL,
    MIRRORARMOR,
    GULPMISSILE,
    STALWART,
    STEAMENGINE,
    PUNKROCK,
    SANDSPIT,
    ICESCALES,
    RIPEN,
    ICEFACE,
    POWERSPOT,
    MIMICRY,
    SCREEENCLEANER,
    STEELYSPIRIT,
    PERISHBODY,
    WANDERINGSPIRIT,
    GORILLATACTICS,
    NEUTRALIZINGGAS,
    PASTELVEIL,
    HUNGERSWITCH,
    QUICKDRAW,
    UNSEENFIST,
    CURIOUSMEDICINE,
    TRANSISTOR,
    DRAGONSMAW,
    CHILLINGNEIGH,
    GRIMNEIGH,
    ASONECHILLINGNEIGH,
    ASONEGRIMNEIGH
};

[CreateAssetMenu(fileName = "NewAbility", menuName = "GameData/Ability")]
public class AbilityObject : ScriptableObject
{
    //[SerializeField]
    //private AbilityID _internalName;
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _description;

    //public AbilityID InternalName => _internalName;
    public string Name => _name;
    public string Description => _description;
}