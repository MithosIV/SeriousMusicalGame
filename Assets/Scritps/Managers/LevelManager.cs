using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public NoteManager noteManager;
    public PlayerManager playerManager;

    public LevelState levelState;

    public List<GameObject> melodyNotes = new List<GameObject>();
    public List<bool> correctNotes = new List<bool>();

    void Start()
    {
        levelState = LevelState.Playing;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckMelody(List<GameObject> melody)
    {
        for (int i = 0; i < melody.Count; i++)
        {
            noteManager.PlayNoteAudio(melody[i]);
            CheckIfNoteIsCorrect(melody[i], i);
        }
        CheckIfMelodyIsCorrect();
    }
    public void CheckIfNoteIsCorrect(GameObject note, int index)
    {
        if (note == melodyNotes[index])
        {
            correctNotes.Add(true);
        }
        else if (note != melodyNotes[index])
        {
            correctNotes.Add(false);
        }
    }

    public void CheckIfMelodyIsCorrect()
    {
        if(correctNotes.Contains(false))
        {
            playerManager.LoseTrie();
        }
        else
        {
            levelState = LevelState.Win;
        }
    }

    public enum LevelState { None, Win, Lose, Playing }
}