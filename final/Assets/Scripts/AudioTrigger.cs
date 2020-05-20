using UnityEngine;
using System.Collections;

public class AudioTrigger : MonoBehaviour
{

    [SerializeField]
    private AudioSource fanfare;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            fanfare.Play();
    }
}
