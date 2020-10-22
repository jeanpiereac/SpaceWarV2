using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveBehaviour : MonoBehaviour
{

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Destroy(gameObject, 3f);
    }
    public void OnMouseDown()
    {
        gameManager.IncrementScore();
        Destroy(gameObject);
    }
   
}
