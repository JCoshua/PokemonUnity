using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public static class PokemonConfig
{
    [Tooltip("The absolute highest Level a Pokémon can acheive.")]
    public static int MaxLevel = 100;

    [Tooltip("The level an egg hatches at.")]
    public static int EggLevel = 1;
}
