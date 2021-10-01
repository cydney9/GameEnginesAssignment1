using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{

    //What the player has currently
    private string possesion;
    private int points;

    //items
    public GameObject red;
    public GameObject blue;
    public GameObject green;

    //holes
    public GameObject redHole;
    public GameObject blueHole;
    public GameObject greenHole;

    //ui
    public Text collect;
    // Start is called before the first frame update
    void Start()
    {
        //What the player has
        possesion = "Nothing";
        points = 0;
        //UI Text
        collect.text = "Has Nothing";

 

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //This is For collecting the item
        if (collision.gameObject.gameObject == red && possesion == "Nothing")
        {
            possesion = "Red";
            Destroy(red);
            Debug.Log("Collected Red");
            collect.text = "Has Red Item";
         
        }
        else if (collision.gameObject.gameObject == green && possesion == "Nothing")
        {
            possesion = "Green";
            Destroy(green);
            Debug.Log("Collected Green");
            collect.text = "Has Green Item";
        }
        else if (collision.gameObject.gameObject == blue && possesion == "Nothing") 
        {
            possesion = "Blue";
            Destroy(blue);
            Debug.Log("Collected Blue");
            collect.text = "Has Blue Item";
        }
        //For dropping into holes
        else if (collision.gameObject.gameObject == redHole && possesion == "Red")
        {
            possesion = "Nothing";
            Destroy(redHole);
            Debug.Log("Dropped Red");
            points += 1;
            Debug.Log(points);
            collect.text = "Has Nothing";
        }
        else if (collision.gameObject.gameObject == greenHole && possesion == "Green")
        {
            possesion = "Nothing";
            Destroy(greenHole);
            Debug.Log("Dropped Green");
            points += 1;
            Debug.Log(points);
            collect.text = "Has Nothing";
        }
        else if (collision.gameObject.gameObject == blueHole && possesion == "Blue")
        {
            possesion = "Nothing";
            Destroy(blueHole);
            Debug.Log("Dropped Blue");
            points += 1;
            Debug.Log(points);
            collect.text = "Has Nothing";
        }
    }
    private void Update()
    {
        if (points == 3) 
        {
            Debug.Log("You Win");
            collect.text = "You Win";
            Time.timeScale = 0; //pause
        }


    }

}
