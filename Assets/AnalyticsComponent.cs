using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsComponent : MonoBehaviour
{
    public void OnLevelStarted(int levelId, string characterName)
    {
        Analytics.CustomEvent("Level Started", new Dictionary<string, object>()
        {
            { "level", levelId },
            { "Character", characterName }
        });
    }
    

}
