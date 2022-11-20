using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSoundEffects : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip soundEffect;
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
            audioSource.clip = soundEffect;
            audioSource.Play();

            Debug.Log("Goal");

        }
    }
}


   