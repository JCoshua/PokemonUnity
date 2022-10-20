using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct MoveFlags
{
    [Tooltip("The move makes physical contact with the target.")]
    public bool Contact;
    [Tooltip("The target can use Protect or Detect to protect itself from the move.")]
    public bool GoesThroughProtect;
    [Tooltip("The move can be copied by Mirror Move.")]
    public bool CanMirrorMove;
    [Tooltip("If the user is frozen, the move will thaw it out before it is used.")]
    public bool ThawsUser;
    [Tooltip("The move has a high critical hit rate.")]
    public bool HighCriticalHitRate;
    [Tooltip("The move is a biting move (powered up by the ability Strong Jaw).")]
    public bool Biting;
    [Tooltip("The move is a punching move (powered up by the ability Iron Fist).")]
    public bool Punching; 
    [Tooltip("The move is a sound-based move (goes through substitute).")]
    public bool Sound;
    [Tooltip("The move is a powder-based move (Grass-type Pokémon are immune to them).")]
    public bool Powder;
    [Tooltip("The move is a pulse-based move (powered up by the ability Mega Launcher).")]
    public bool Pulse;
    [Tooltip("The move is a bomb-based move (nullified by the ability Bulletproof).")]
    public bool Bomb; 
    [Tooltip("The move is a dance move (repeated by the ability Dancer).")]
    public bool Dance;
    [Tooltip("This move cannot be called by the move Metronome. Used for signature moves or other special moves.")]
    public bool CannnotMetronome;
    [Tooltip("This move deals double damage to Pokémon that used Minimize at least once without switching out. Also skips all accuracy and evasion checks.")]
    public bool TramplesMinimize; 
};

[Serializable]
public enum Targets
{
    User,
    NearOther,
    NearFoe,
    NearAlly,
    UserAndAllies,
    AllNearFoes,
    AllNear,
    All,
    UserSide,
    FoeSide,
    Field
}

public enum Category
{
    PHYSICAL,
    SPECIAL,
    STATUS
};

[CreateAssetMenu(fileName = "NewMove", menuName = "GameData/Move")]
public class Move : ScriptableObject
{
    [SerializeField]
    private string _name;

    [SerializeField]
    private string _description;

    [SerializeField]
    private Category _category;

    [SerializeField]
    private Type _type;

    [SerializeField]
    private int _basePower;

    [SerializeField]
    private int _accuracy = 100;

    [SerializeField]
    private int _totalPP;

    [SerializeField]
    private int _priority = 0;

    [SerializeField]
    private int _effectChance;

    [SerializeField]
    private Targets _target = Targets.NearOther;

    [SerializeField]
    private MoveFlags _flags;

    private Species _user;

    public int TotalPP => _totalPP;


    [SerializeField]
    private EffectCode _effectCode;
    private EffectBehavior _effect;

    public bool IsPhysical()
    {
        if (_basePower <= 0)
            return false;

        if (!GameConfig.PhysicalSpecialSplit)
            return !_type.isSpecialType();

        return _category == Category.PHYSICAL;
    }

    public bool IsSpecial()
    {
        if (_basePower <= 0)
            return false;

        if (!GameConfig.PhysicalSpecialSplit)
            return _type.isSpecialType();

        return _category == Category.SPECIAL;
    }

    public bool IsStatus()
    {
        return _category == Category.STATUS;
    }

    public void initialize()
    {
        switch(_effectCode)
        {
            case EffectCode.NoAdditionalEffect:

                break;
        }    
    }
}
