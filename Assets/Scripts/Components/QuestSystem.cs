using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Resources.QuestSystem;
using Resources.Types;

public class QuestSystem : MonoBehaviour
{
    [Header("Containers: ")]
    [SerializeField] private List<QuestInstance> activeQuests;
    [SerializeField] private List<uint> completedQuests;

    #region Events

    #endregion
}