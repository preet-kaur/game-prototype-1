using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PortalScript : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("Helllooo");
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hello: " + collider.gameObject);

            SceneManager.LoadScene("PortalScene2");
        }
    }


}
