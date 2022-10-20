using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConfig : Object
{
    // Whether the game has Gen IV Physical/Special split.
    static public bool PhysicalSpecialSplit = true;

    // Whether affection should affect normal battles. 
    // (Survive lethal hits without sturdy/focus sach, cure status, etc.)
    static public bool AffectioninBattle = true;

    // If special moves use Sp. Atk for confusion damage.
    static public bool SpecialConfusion = false;

    //Whether the game has HMs moves.
    static public bool needHMs = false;
    static public Move[] HMList;

    static public void initializeHMList() { }
}
