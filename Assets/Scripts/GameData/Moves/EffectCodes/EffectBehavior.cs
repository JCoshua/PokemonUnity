using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public enum EffectCode
{ 
    MoveEffect,
    StatUpMoveEffect,
    StatDownMoveEffect,
    FixedDamageMoveEffect,
    TwoTurnMoveEffect,
    HealingMoveEffect,
    RecoilMoveEffect,
    ProtectMoveEffect,
    WeatherMoveEffect,
    DoNothingMoveEffect,
    ScatterMoneyMoveEffect,
    DoubleRewardMoneyMoveEffect,
    FailsIfNotUserFirstTurnMoveEffect,
    MultiHitMoveEffect,
    BurnTargetMoveEffect,
    FreezeTargetMoveEffect,
    ParalyzeTargetMoveEffect,
}


public abstract class EffectBehavior : MonoBehaviour
{
    public abstract void Effect();
}
