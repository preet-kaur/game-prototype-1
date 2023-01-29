using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PortalScene2Script : MonoBehaviour
{
   

    private void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("Helllooo scen2");
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hello: " + collider.gameObject);

            SceneManager.LoadScene("SampleScene");
        }
    }
}
