using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NPCDialogueData
{
    public string name;
    public List<DialogueNodeData> npcNodes;
    public List<DialogueNodeData> pcNodes;

    public static NPCDialogueData CreateFromJSON(string jsonString)
    {
        NPCDialogueData data = JsonUtility.FromJson<NPCDialogueData>(jsonString);
        return data;
    }
}
