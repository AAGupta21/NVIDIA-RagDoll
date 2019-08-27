using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static float Dummy_Health = 25f;

    [SerializeField] private GameObject Dummy = null;
    [SerializeField] private GameObject Text1 = null;
    [SerializeField] private GameObject Text2 = null;

    private bool HealthCheckNeeded = true;

    private void Update()
    {
        if (HealthCheckNeeded)
        {
            this.gameObject.GetComponent<TextMesh>().text = "Health : " + Dummy_Health.ToString();
            
            if (Dummy_Health <= 0)
                LooseScene();

            if (Dummy.transform.position.z >= 10.25f)
                WinScene();
        }
    }

    private void LooseScene()
    {
        HealthCheckNeeded = false;
        Text1.GetComponent<TextMesh>().text = Text2.GetComponent<TextMesh>().text = this.gameObject.GetComponent<TextMesh>().text = "YOU LOOSE!!";
    }

    private void WinScene()
    {
        HealthCheckNeeded = false;
        Text1.GetComponent<TextMesh>().text = Text2.GetComponent<TextMesh>().text = this.gameObject.GetComponent<TextMesh>().text = "YOU WIN!!";
    }
}