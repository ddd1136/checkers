using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    [SerializeField] private AnalyticsComponent analytics;
    [SerializeField] private string[] Names;
    public void LevelStart()
    {
        int levelId = Random.Range(0, 10);  
        int i = Random.Range(0, this.Names.Length + 1);
        string characterName = this.Names[i];
        this.analytics.OnLevelStarted(levelId, characterName);
    }
}
