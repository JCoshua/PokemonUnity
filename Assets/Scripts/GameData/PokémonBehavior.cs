using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[Serializable]
public enum Gender
{
    Male,
    Female,
    Genderless
}

[Serializable]
public struct PMove
{
    public PMove(Move move)
    {
        _move = move;
        _pp = move.TotalPP;
        _ppboost = 0;
        _totalpp = move.TotalPP;
    }

    [SerializeField]
    private Move _move;
    private int _pp;
    private float _ppboost;
    private int _totalpp;
}

[Serializable]
public struct Moves
{
    [SerializeField]
    private PMove _move1;
    [SerializeField]
    private PMove _move2;
    [SerializeField]
    private PMove _move3;
    [SerializeField]
    private PMove _move4;
}


public class PokemonBehavior : MonoBehaviour
{
    [SerializeField]
    private Species _species;

    [SerializeField]
    private string _nickname;

    [SerializeField]
    private int _level;
    private int _exp;

    [SerializeField]
    private Ability _ability;

    [SerializeField]
    private Gender _gender;

    //[SerializeField]
    //private Nature _nature;

    [SerializeField]
    private bool _isShiny;

    [SerializeField]
    private bool _currentHP;

    [SerializeField]
    private int _happiness;

    //[SerializeField]
    //private Status _status;

    [SerializeField]
    [Tooltip("Only for eggs. This Pokémon is an egg is this number is greater than 0.")]
    private int stepsToHatch = 0;

    [SerializeField]
    private Moves _moves;
}
