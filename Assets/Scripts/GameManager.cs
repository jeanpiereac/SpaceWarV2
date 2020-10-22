using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject nave;
    public GameObject win;
    public GameObject astro;
    public Text TextScore;
    int score=0;
    bool winW=false;
    bool astroW=false;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (winW == true && astroW == true)
        {
            CancelInvoke("Spawn");
        }

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
        }
    }
    void Spawn()
    {
        float randomX = Random.Range(62f,955f);
        float randomY = Random.Range(61f, 568f); ;

        Vector3 randomPosition = new Vector3(randomX, randomY, 0);

        Instantiate(nave,
            randomPosition, Quaternion.identity);
    }

    public void IncrementScore()
    {
        score++;
        TextScore.text = score.ToString();

        if (score >= 20)
        {
            winW = true;
            astroW = true;
            win.SetActive(winW);
            astro.SetActive(astroW);
        }

    }


}
