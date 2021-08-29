using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i;
    public Renderer rend;
    int rand;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        rand = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        
        if((gameObject.tag == "Red") && (i== 100)){
            gameObject.SetActive(false);
        }

        if((gameObject.tag == "Blue") && i == rand)
        {
            rend.enabled = false;
        }

    }
}
