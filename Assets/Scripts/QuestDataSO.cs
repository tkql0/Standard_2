using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultQuestSO", menuName = "Quests/Default", order = 0)]
public class QuestDataSO : ScriptableObject
{
    [Header("Quest Info")]
    public string QuestName; // - 퀘스트의 이름
    public int QuestRequiredLevel; // - 퀘스트의 최소레벨
    public int QuestNPC; // - 퀘스트를 주는 NPC의 id(int)
    public List<int> QuestPrerequisites; //- 선행 퀘스트의 id들의 리스트
    //[구현사항 1]
}