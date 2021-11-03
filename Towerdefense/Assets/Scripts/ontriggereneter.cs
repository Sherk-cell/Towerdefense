using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ontriggereneter : MonoBehaviour
{
    public Text txt_healthCount;
    public int defaultHealthCount;
    public int healthCount;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LoseHealth();
        }
    }
    public void init()
    {
        healthCount = defaultHealthCount;
        txt_healthCount.text = healthCount.ToString();
    }

    //Lose health count
    public void LoseHealth()
    {
        if (healthCount < 1)
            return;

        healthCount --;
        txt_healthCount.text = healthCount.ToString();

        CheckHealthCount();
    }

    //Check health count for losing
    void CheckHealthCount()
    {
        if (healthCount < 1)
        {
            Debug.Log("You lost");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1f;


        }
    }

}