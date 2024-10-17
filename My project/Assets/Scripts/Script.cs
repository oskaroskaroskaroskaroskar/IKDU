using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    public int andeCount;
    void Start()
    {
        andeCount = 10;
    }
    
    void SpisAnd ()
    {
        andeCount += -1;
    }
    void AddAnd()
    {
        andeCount += 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            SpisAnd();
            Debug.Log("spiser and");
            
        }
        if (Input.GetKeyDown("m"))
        {
            Debug.Log("Der er " + andeCount + " ænder tilbage");
        }
        if (Input.GetKeyDown("n"))
        {
            AddAnd();
            Debug.Log("Der er nu " + andeCount + " ænder");
        }
    }
}
