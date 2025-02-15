using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    public Transform teleport;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.transform.position = teleport.transform.position;
        }
    }
}
