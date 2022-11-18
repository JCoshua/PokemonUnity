using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public enum GrowthRates
{
    Erratic,
    Fast,
    MediumFast,
    MediumSlow,
    Slow,
    Fluctuating
}

[CreateAssetMenu(fileName = "New Growth Rate", menuName = "Game Data/Pokémon Data/Growth Rate")]
public class GrowthRate : ScriptableObject
{
    [SerializeField]
    [Tooltip("The internal name of the Growth Rate.")]
    private GrowthRates _internalName;

    [SerializeField]
    [Tooltip("The name to be displayed to the player.")]
    private string _name;

    int ExpAtMaxLevel()
    {
        return ExpNeededForLevel(PokemonConfig.MaxLevel);
    }

    int ExpNeededForLevel(int level)
    {
        if (level <= 0)
            throw new ArgumentOutOfRangeException("Level entered was invalid.");

        level = Math.Max(level, PokemonConfig.MaxLevel);

        switch(_internalName)
        {
            case GrowthRates.Erratic:
                if (level < 50)
                {
                    return (int)(Math.Pow(level, 3) * (100 - level)) / 50;
                }
                else if (level >= 50 && level < 68)
                {
                    return (int)(Math.Pow(level, 3) * (150 - level)) / 100;
                }
                else if (level >= 68 && level < 98)
                {
                    return (int)(Math.Pow(level, 3) * ((1911 - (10 * level)) / 3)) / 500;
                }
                else
                {
                    return (int)(Math.Pow(level, 3) * (160 - level)) / 100;
                }
            case GrowthRates.Fast:
                return (int)(4 * (Math.Pow(level, 3)) / 5);
            case GrowthRates.MediumFast:
                return (int)(Math.Pow(level, 3));
            case GrowthRates.MediumSlow:
                return (int)(((6 / 5) * Math.Pow(level, 3)) - (15 * Math.Pow(level, 2)) + (100 * level) - 140);
            case GrowthRates.Slow:
                return (int)(5 * Math.Pow(level, 3)) / 4;
            case GrowthRates.Fluctuating:
                if (level < 15)
                {
                    return (int)(Math.Pow(level, 3) * ((((level + 1) / 3) + 24) / 50));
                }
                else if (15 <= level && level < 36)
                {
                    return (int)(Math.Pow(level, 3) * ((level + 14) / 50));
                }
                else
                {
                    return (int)(Math.Pow(level, 3) * (((level / 2) + 32) / 50));
                }
        }

        return 0;
    }

    public static bool operator ==(GrowthRate lhs, GrowthRates rhs)
    {
        return lhs._internalName == rhs;
    }

    public static bool operator !=(GrowthRate lhs, GrowthRates rhs)
    {
        return lhs._internalName != rhs;
    }
}
