using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
        [Tooltip("If true, Quit works in built apps outside editor too.")]
        public bool standalone = false;
 
        void Awake()
        {
#if UNITY_EDITOR
            if (!standalone)
                if (UnityEditor.EditorApplication.isPlaying)
                    Destroy(this);
#endif
        }
 
        void Update()
        {
#if ENABLE_INPUT_SYSTEM
            if (Keyboard.current.escapeKey.wasReleasedThisFrame)
#else
            if (Input.GetKeyUp("escape"))
#endif
            {
                Debug.Log($"Quitting App on Escape Key struck.");
                Quit();
            }
 
#if ENABLE_INPUT_SYSTEM
            if (Keyboard.current.f12Key.wasReleasedThisFrame)
#else
            if (Input.GetKeyUp("f12"))
#endif
            {
                Debug.Log($"Pausing Game on F12 Key struck.");
                Pause();
            }
 
        }
 
        void Pause()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPaused = true;
#endif
        }
 
        void Quit()
        {
#if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be
            // set to false to end the game.
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }    void Start()
    {
        
    }


}
