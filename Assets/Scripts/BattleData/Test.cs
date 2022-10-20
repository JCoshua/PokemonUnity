using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public ActiveField field;

    // Start is called before the first frame update
    public void Start()
    {
        field = GetComponent<ActiveField>();
    }

    // Update is called once per frame
    void Update()
    {
        field.SetWeather(BattleWeatherID.Rain);
    }
}
