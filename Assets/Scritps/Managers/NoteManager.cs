using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class NoteManager : MonoBehaviour
    {
        //[SerializeField] private PlayerController player;
        AudioSource audioSource;
        void Start()
        {

        }
        private void FixedUpdate()
        {

        }
        void Update()
        {

        }
        public void PlayNoteAudio(GameObject notePlatform)
        {
            audioSource = notePlatform.gameObject.GetComponent<AudioSource>();
            audioSource.Play();
            Debug.Log("Reproduciendo sonido de " + notePlatform.name);
        }
    }