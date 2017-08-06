using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Resources.QuestSystem;

[CreateAssetMenu(menuName = "Quest")]
public class Quest : ScriptableObject
{
    [Header("Quest parametes: ")]
    [SerializeField] protected string questName;
    [SerializeField] protected string questDescription;
    [SerializeField] protected uint ID;

    [Header("Quest values: ")]
    [SerializeField] protected List<QuestStage> questStages;
    [SerializeField] protected List<Quest> rewardQuests;

    [Header("Quest requirements: ")]
    [SerializeField] protected List<Quest> requiredQuests;
    [SerializeField] protected uint requiredLVL;
}
