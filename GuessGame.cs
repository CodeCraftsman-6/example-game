using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessGame : MonoBehaviour
{
    public int min=0, max=1000;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        guess= (max+min)/2;
        Debug.Log("Welcome to Guess Game, think of a number between 1 to 1000 and don't tell me");
        Debug.Log("My guess is:"+ guess);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
           min = guess;
           guess = (min + max)/2;
           Debug.Log("So your number is higher, i guess to be:"+ guess);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
           max = guess;
           guess = (min + max)/2;
           Debug.Log("So your number is higher, i guess to be:"+ guess);
        }
        else if(Input.GetKeyDown(KeyCode.Equals))
        {
            Debug.Log("Gotcha!!");
        }
    }
}
