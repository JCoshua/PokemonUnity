using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveField : MonoBehaviour
{
    ActiveField(Weather defaultWeather, Terrain defaultTerrain)
    {
        _defaultWeather = defaultWeather;
        _defaultTerrain = defaultTerrain;

        _weather = defaultWeather;
        _terrain = defaultTerrain;
    }

    public int PayDay = 0;
    public bool AmuletCoin = false;
    public bool HappyHour = false;

    public int FairyLock = 0;

    public bool FusionBolt = false;
    public bool FusionFlare = false;

    public bool IonDeluge = false;
    public int MudSport = 0;
    public int WaterSport = 0;

    public int MagicRoom = 0;
    public int TrickRoom = 0;
    public int WnderRoom = 0;
    public int Gravity = 0;

    private Weather _defaultWeather;
    private Terrain _defaultTerrain;

    public Weather _weather;
    private int _weatherDuration;
    private Terrain _terrain;
    private int _terrainDuration;

    public void SetWeather(BattleWeatherID weather, int duration = 5)
    {
        _weather = weather;
        _weatherDuration = duration;
    }

    public void SetTerrain(TerrainID terrain, int duration = 5)
    {
        _terrain = terrain;
        _terrainDuration = duration;
    }
}
