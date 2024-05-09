using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public LevelManager levelManager;
    public List<GameObject> selectedNotes = new List<GameObject>();
    public int tries;
    void Start()
    {
        selectedNotes.Clear();
        tries = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddSelectedNoteToList(GameObject note)
    {
        if(selectedNotes.Count < levelManager.melodyNotes.Count)
        selectedNotes.Add(note);
    }

    public void SendMelodyToLevelManager()
    {
        levelManager.CheckMelody(selectedNotes);
    }
    
    public void LoseTrie()
    {
        selectedNotes.Clear();
        levelManager.correctNotes.Clear();
        tries -= 1;
        if(tries <= 1)
        {
            levelManager.levelState = LevelManager.LevelState.Lose;
        }
    }

    public void RemoveLastNote()
    {
        selectedNotes.RemoveAt(selectedNotes.Count - 1);
    }

    public void ClearNoteList()
    {
        selectedNotes.Clear();
    }
}
