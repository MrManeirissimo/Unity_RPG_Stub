using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Resources
{
    namespace QuestSystem
    {
        [Serializable]
        public class QuestInstance
        {
            [SerializeField] private Quest info;
            [SerializeField] private uint currentStage;
        }
    }

    namespace Types
    {
        delegate void VDelegate();
        delegate void VDel_Qst_Chtr();
        delegate bool BDelegate();
    }
}
