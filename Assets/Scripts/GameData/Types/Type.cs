using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEditor.ShaderData;

public enum TypeID
{
    NONE, //For removing types from a Pokemon
    NORMAL,
    FIGHTING,
    FLYING,
    POISON,
    GROUND,
    ROCK,
    BUG,
    GHOST,
    STEEL,
    FIRE,
    WATER,
    GRASS,
    ELECTRIC,
    PSYCHIC,
    ICE,
    DRAGON,
    DARK,
    FAIRY
};

[CreateAssetMenu(fileName = "New Type", menuName = "GameData/Type")]
public class Type : ScriptableObject
{
    [SerializeField]
    private TypeID _internalName;
    [SerializeField]
    private string _name;
    [SerializeField]
    private bool _isSpecialType = false;

    [SerializeField]
    private Type[] _weaknesses;
    [SerializeField]
    private Type[] _resistances;
    [SerializeField]
    private Type[] _immunities;

    public TypeID InternalName => _internalName;
    public string Name => _name;
    public bool isSpecialType() => _isSpecialType;

    public bool hasWeakness(Type type)
    {
        foreach (Type weakness in _weaknesses)
        {
            if (weakness == type)
                return true;
        }

        return false;
    }

    public bool hasWeakness(TypeID type)
    {
        foreach (Type weakness in _weaknesses)
        {
            if (weakness == type)
                return true;
        }

        return false;
    }

    public bool hasResistance(Type type)
    {
        foreach (Type resistance in _resistances)
        {
            if (resistance == type)
                return true;
        }

        return false;
    }

    public bool hasResistance(TypeID type)
    {
        foreach (Type resistance in _resistances)
        {
            if (resistance == type)
                return true;
        }

        return false;
    }

    public bool hasImmunity(Type type)
    {
        foreach (Type immunity in _immunities)
        {
            if (immunity == type)
                return true;
        }

        return false;
    }

    public bool hasImmunity(TypeID type)
    {
        foreach (Type immunity in _immunities)
        {
            if (immunity == type)
                return true;
        }

        return false;
    }

    public static bool operator ==(Type lhs, TypeID rhs)
    {
        return lhs._internalName == rhs;
    }

    public static bool operator !=(Type lhs, TypeID rhs)
    {
        return lhs._internalName != rhs;
    }
}
