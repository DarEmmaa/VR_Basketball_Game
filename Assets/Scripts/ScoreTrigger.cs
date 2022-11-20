using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTrigger : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip goalSound;
    [SerializeField] ScoreCounter scoreCounter;
    
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Basketball"))
        {
            audioSource.clip = goalSound;
            audioSource.Play();
            scoreCounter.increaseScore();

            Debug.Log("Goal");
            
        }
    }

   
}
