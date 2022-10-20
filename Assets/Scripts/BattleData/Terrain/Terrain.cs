using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TerrainID
{
    NoTerrain,
    Electric,
    Psychic,
    Misty,
    Grassy
};

public class Terrain : Object
{
    Terrain(TerrainID terrain)
    {
        _internalName = terrain;   
        switch (terrain)
        {
            case TerrainID.NoTerrain:
                _name = "None";
                break;
            case TerrainID.Electric:
                _name = "Electric Terrain";
                break;
            case TerrainID.Psychic:
                _name = "Psychic Terrain";
                break;
            case TerrainID.Misty:
                _name = "Misty Terrain";
                break;
            case TerrainID.Grassy:
                _name = "Grassy Terrain";
                break;
        }
    }

    private TerrainID _internalName;
    private string _name;

    static public implicit operator Terrain(TerrainID terrain)
    {
        return new Terrain(terrain);
    }
}
