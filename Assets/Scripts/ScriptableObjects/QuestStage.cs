using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "QuestStage")]
public class QuestStage : ScriptableObject
{
    [SerializeField] protected string ID;
    [SerializeField] protected string stageName;    
    [SerializeField] protected string stageDescription;
}
