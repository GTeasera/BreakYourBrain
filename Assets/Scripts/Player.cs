using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] Vector3 moveDiricetion;

    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
            GetComponent<Rigidbody>().velocity += moveDiricetion;

        if (Input.GetKey(keyTwo))
            GetComponent<Rigidbody>().velocity -= moveDiricetion;

        if (Input.GetKey(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if (Input.GetKey(KeyCode.Q))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (Input.GetKey(KeyCode.E))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (this.CompareTag("Player") && other.CompareTag("Mine"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

