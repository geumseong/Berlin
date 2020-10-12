using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeDecision : MonoBehaviour
{
    public string option;
    public GameObject codeText;
    public int achDuStasiCount;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);

        switch(Random.Range(0, 6)) {
            case 1:
                Debug.Log("case 1");
                option = "How did you get here?";
                codeText.GetComponent<Text>().text = @"The Code Question:


- How did you get here?
    - Give right info to people who 
       give an unrealistic type of 
       transportation.";
                break;


            case 2:
                Debug.Log("case 2");
                option = "Where are we currently?";
                codeText.GetComponent<Text>().text = @"The Code Question:

- Where are we currently?
	- Give right info to people that
	   incorrectly answer the question. 
	   Our current location is East
	   Berlin, GDR.";
                break;


            case 3:
                Debug.Log("case 3");
                option = "Would you like to eat something?";
                codeText.GetComponent<Text>().text = @"The Code Question:

- Would you like eat something?
	- Give right info to people who 
       say something that is red.";
                break;
            case 4:
                Debug.Log("case 4");
                option = "What's the best monument in the world?";
                codeText.GetComponent<Text>().text = @"The Code Question:

- What's the best monument in the 
   world?
	- Give right info to people who
       say an American monument.";
                break;


            case 5:
                Debug.Log("case 5");
                option = "Who is the great leader?";
                codeText.GetComponent<Text>().text = @"The Code Question:

- Who is the great leader?
	- Give right info to people 
       that say western leaders.";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
