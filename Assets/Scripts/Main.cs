using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    [SerializeField] KeyCode One;
    [SerializeField] KeyCode Two;
    [SerializeField] Vector3 move;

    private void FixedUpdate()
    {
        if (Input.GetKey(One))
            GetComponent<Rigidbody>().velocity += move;

        if (Input.GetKey(Two))
            GetComponent<Rigidbody>().velocity -= move;

        if (Input.GetKey(KeyCode.A))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (Input.GetKey(KeyCode.B))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
        if (Input.GetKey(KeyCode.C))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
        if (Input.GetKey(KeyCode.F))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 16);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

