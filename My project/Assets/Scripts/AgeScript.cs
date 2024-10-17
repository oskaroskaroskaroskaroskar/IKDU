using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeScript : MonoBehaviour
{
    int age = 20;
    // Start is called before the first frame update
    void Start()
    {
        age = UpdateAge(age, 2);
        Debug.Log("Now i'm " + age + " years old");
        age = AgeNextYear(age);
        Debug.Log("Now i'm " + age + " years old");
    } 
    int AgeNextYear (int age)
    {
        int newAge = age + 1;
        return (newAge);
    }
    int UpdateAge(int age, int years)
    {
        int newAge = age + years;
        return(newAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
