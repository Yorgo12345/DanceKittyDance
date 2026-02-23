using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Example mapping: keys 1..5 trigger named animations
    [System.Serializable]
    public struct KeyTrigger
    {
        public KeyCode key;
        public string triggerName;
    }

    public KeyTrigger[] mappings;

    void Reset()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!animator) return;

        for (int i = 0; i < mappings.Length; i++)
        {
            if (Input.GetKeyDown(mappings[i].key))
            {
                animator.SetTrigger(mappings[i].triggerName);
            }
        }
    }
}
