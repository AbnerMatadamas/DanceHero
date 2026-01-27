using UnityEngine;

[CreateAssetMenu(fileName = "SongNotesData", menuName = "Scriptable Objects/SongNotesData")]
public class SongNotesData : ScriptableObject
{
    public NoteData[] notes;
}
