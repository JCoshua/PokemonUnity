using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public enum EffectCode
{ 
    NoAdditionalEffect,
    MultiHitEffect,
    IncreaseRewardMoneyEffect,
    BurnTargetEffect,
    FreezeTargetEffect,
    ParalyzeTargetEffect,
}


public abstract class EffectBehavior : MonoBehaviour
{
    public abstract void Effect();
}
