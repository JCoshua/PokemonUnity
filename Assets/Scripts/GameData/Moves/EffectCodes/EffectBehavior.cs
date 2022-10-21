using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public enum EffectCode
{ 
    //Base Move Codes
    MoveEffect,

    //Inherit for MoveEffect
    StatUpMove,
    StatDownMove,
    FixedDamageMove,
    TwoTurnMove,
    HealingMove,
    RecoilMove,
    ProtectMove,
    WeatherMove,
    TerrainMove,
    DoNothingMove,
    ScatterMoneyMove,
    DoubleRewardMoneyMove,
    FailsIfNotUserFirstTurnMove,
    FailsUnlessUserUsedAllOtherMovesMove,
    FailsIfUserNotConsumedBerryMove,
    FailsIfTargetHasNoItemMove,
    FailsUnlessTargetSharesTypeWithUserMove,
    FailsIfUserDamagedThisTurnMove,
    FailsIfTargetDoesNotAttackMove,
    AddSpikeToFoeMove,
    AddToxicSpikesToFoeSideMove,
    AddStealthRocksToFoeSideMove,
    AddStickyWebToFoeSideMove,
    SwapSideEffectsMove,
    MakeSubstituteMove,
    RemoveBindAndEntryHazardMove,
    AttackTwoTurnsLaterMove,
    SwapPositionWithAllyMove,
    MultiHitMove,
    BurnTargetMove,
    FreezeTargetMove,
    ParalyzeTargetMove,
}


public abstract class EffectBehavior : MonoBehaviour
{
    public abstract void Effect();
}
