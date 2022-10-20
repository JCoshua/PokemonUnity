using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public enum BattleWeatherID
{
    NoWeather,
    Sun,
    Rain,
    Sandstorm,
    Hail,
    HarshSun,
    HarshRain,
    StrongWinds
};

public class Weather : Object
{
    Weather(BattleWeatherID weather)
    {
        _internalName = weather;
        switch (weather)
        {
            case BattleWeatherID.NoWeather:
                _name = "Clear Sky";
                break;
            case BattleWeatherID.Sun:
                _name = "Harsh Sun";
                break;
            case BattleWeatherID.Rain:
                _name = "Rain";
                break;
            case BattleWeatherID.Sandstorm:
                _name = "Sandstorm";
                break;
            case BattleWeatherID.Hail:
                _name = "Hail";
                break;
            case BattleWeatherID.HarshSun:
                _name = "Desolate Land";
                _isPrimalWeather = true;
                break;
            case BattleWeatherID.HarshRain:
                _name = "Primordial Sea";
                _isPrimalWeather = true;
                break;
            case BattleWeatherID.StrongWinds:
                _name = "Delta Stream";
                _isPrimalWeather = true;
                break;
            //Custom weathers should go above default

            default:
                _name = "Undefined";
                break;
        }

    }

    private BattleWeatherID _internalName;
    private string _name;
    private bool _isPrimalWeather = false;

    static public implicit operator Weather(BattleWeatherID weather)
    {
        return new Weather(weather);
    }
}
