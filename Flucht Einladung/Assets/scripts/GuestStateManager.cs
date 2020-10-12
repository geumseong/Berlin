using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuestStateManager : MonoBehaviour
{

    public GameObject codeText;
    public GameObject replyTextObj;
    public GameObject replyText;
    public bool paperReceived = false;
    public bool moving = true;
    public int rightGuestCount;
    public int wrongGuestCount;
    public int totalGuestCount;
    public int policeGuestCount;
    public GameObject duStasiEnding;
    public GameObject duStasiEnding2;
    public GameObject duStasiEnding3;
    public GameObject duStasiEnding4;
    public GameObject duStasiEnding5;
    public GameObject duStasiEnding6;
    public GameObject duStasiEnding7;
    public GameObject duStasiEnding8;
    public GameObject duStasiEnding9;
    public GameObject duStasiEnding10;
    public GameObject mainMenuButton;
    public int rr;
    public int rd;
    public int rg;
    public int wr;
    public int wd;
    public int wg;
    public int gr;
    public int gd;
    public int gg;
    public GameObject startPoint;
    public GameObject normalGuest;
    public GameObject policeGuest;
    public bool guestStatus = true;
    public bool rightGuest = true;
    GameObject guestStateObj;

    // Start is called before the first frame update
    void Awake()
    {
        guestStateObj = GameObject.Find("GuestStateManager");
        rightGuestCount = 0;
        wrongGuestCount = 0;
        totalGuestCount = 0;
        policeGuestCount = 0;
        rr = 0;
        rd = 0;
        rg = 0;
        wr = 0;
        wd = 0;
        wg = 0;
        gr = 0;
        gd = 0;
        gg = 0;
    }

    void Start()
    {
        Debug.Log(GameObject.Find("CodeDecision").GetComponent<CodeDecision>().option);
        codeText.GetComponent<Text>().text = GameObject.Find("CodeDecision").GetComponent<CodeDecision>().option;
        switch (GameObject.Find("CodeDecision").GetComponent<CodeDecision>().option)
        {
            case "How did you get here?":
                switch (Random.Range(1, 6))
                {
                    case 1:
                        replyText.GetComponent<Text>().text = "Spaceship";
                        break;
                    case 2:
                        replyText.GetComponent<Text>().text = "Submarine";
                        break;
                    case 3:
                        replyText.GetComponent<Text>().text = "Rocketship";
                        break;
                    case 4:
                        replyText.GetComponent<Text>().text = "Flying Carpet";
                        break;
                    case 5:
                        replyText.GetComponent<Text>().text = "Cammel";
                        break;
                }
                break;
            case "Where are we currently?":
                switch (Random.Range(1, 6))
                {
                    case 1:
                        replyText.GetComponent<Text>().text = "Melbourne";
                        break;
                    case 2:
                        replyText.GetComponent<Text>().text = "London";
                        break;
                    case 3:
                        replyText.GetComponent<Text>().text = "Hamburg";
                        break;
                    case 4:
                        replyText.GetComponent<Text>().text = "Kyoto";
                        break;
                    case 5:
                        replyText.GetComponent<Text>().text = "New York";
                        break;
                }
                break;
            case "Would you like to eat something?":
                switch (Random.Range(1, 6))
                {
                    case 1:
                        replyText.GetComponent<Text>().text = "Apple";
                        break;
                    case 2:
                        replyText.GetComponent<Text>().text = "Blood";
                        break;
                    case 3:
                        replyText.GetComponent<Text>().text = "Communism";
                        break;
                    case 4:
                        replyText.GetComponent<Text>().text = "Strawberries";
                        break;
                    case 5:
                        replyText.GetComponent<Text>().text = "Ruby";
                        break;
                }
                break;
            case "What's the best monument in the world?":
                switch (Random.Range(1, 6))
                {
                    case 1:
                        replyText.GetComponent<Text>().text = "Statue of Liberty";
                        break;
                    case 2:
                        replyText.GetComponent<Text>().text = "Empire State";
                        break;
                    case 3:
                        replyText.GetComponent<Text>().text = "Mount Rushmore";
                        break;
                    case 4:
                        replyText.GetComponent<Text>().text = "Washington Monument";
                        break;
                    case 5:
                        replyText.GetComponent<Text>().text = "Space Needle";
                        break;
                }
                break;
            case "Who is the great leader?":
                switch (Random.Range(1, 4))
                {
                    case 1:
                        replyText.GetComponent<Text>().text = "Roosevelt";
                        break;
                    case 2:
                        replyText.GetComponent<Text>().text = "Churchill";
                        break;
                    case 3:
                        replyText.GetComponent<Text>().text = "Eisenhower";
                        break;
                }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (guestStateObj.GetComponent<GuestStateManager>().moving == false)
        {
            replyTextObj.SetActive(true);
        }
        else
        {
            replyTextObj.SetActive(false);
        }
    }

    public void ShowEnding(){
        if(rr == 0 && rd == 0 && rg == 7 && wr == 0 && wd == 0 && wg == 13 && gr == 0 && gd == 0 && gg == policeGuestCount) {
            Debug.Log(gg +"gg + " + policeGuestCount + "police");
            Debug.Log(rg +"rg");
            Debug.Log(wg +"wg");
            duStasiEnding.SetActive(true);
            mainMenuButton.SetActive(true);
            GameObject.Find("CodeDecision").GetComponent<CodeDecision>().achDuStasiCount = 1;
        }
        else if(gr > 0) {
            Debug.Log(gg +"gg + " + policeGuestCount + "police");
            Debug.Log(rg +"rg");
            Debug.Log(wg +"wg");
            duStasiEnding3.SetActive(true);
            mainMenuButton.SetActive(true);
            GameObject.Find("CodeDecision").GetComponent<CodeDecision>().achDuStasiCount = 3;
        }
        else if(gd > 0) {
            Debug.Log(gg +"gg + " + policeGuestCount + "police");
            Debug.Log(rg +"rg");
            Debug.Log(wg +"wg");
            duStasiEnding2.SetActive(true);
            mainMenuButton.SetActive(true);
            GameObject.Find("CodeDecision").GetComponent<CodeDecision>().achDuStasiCount = 2;
        }
        else if(rr == 7 && rd == 0 && rg == 0 && wr == 13 && wd == 0 && wg == 0 && gr == 0 && gd == 0 && gg == policeGuestCount) {
            Debug.Log(gg +"gg + " + policeGuestCount + "police");
            Debug.Log(rg +"rg");
            Debug.Log(wg +"wg");
            duStasiEnding4.SetActive(true);
            mainMenuButton.SetActive(true);
            GameObject.Find("CodeDecision").GetComponent<CodeDecision>().achDuStasiCount = 4;
        }
        else if(rr == 0 && rd == 7 && rg == 0 && wr == 0 && wd == 13 && wg == 0 && gr == 0 && gd == 0 && gg == policeGuestCount) {
            Debug.Log(gg +"gg + " + policeGuestCount + "police");
            Debug.Log(rg +"rg");
            Debug.Log(wg +"wg");
            duStasiEnding5.SetActive(true);
            mainMenuButton.SetActive(true);
            GameObject.Find("CodeDecision").GetComponent<CodeDecision>().achDuStasiCount = 5;
        }
        else if(wg > 2 && gr == 0 && gd == 0 && gg == policeGuestCount) {
            Debug.Log(gg +"gg + " + policeGuestCount + "police");
            Debug.Log(rg +"rg");
            Debug.Log(wg +"wg");
            duStasiEnding6.SetActive(true);
            mainMenuButton.SetActive(true);
            GameObject.Find("CodeDecision").GetComponent<CodeDecision>().achDuStasiCount = 6;
        }
        else if(wr > 2 && gr == 0 && gd == 0 && gg == policeGuestCount) {
            Debug.Log(gg +"gg + " + policeGuestCount + "police");
            Debug.Log(rg +"rg");
            Debug.Log(wg +"wg");
            duStasiEnding7.SetActive(true);
            mainMenuButton.SetActive(true);
            GameObject.Find("CodeDecision").GetComponent<CodeDecision>().achDuStasiCount = 7;
        }
        else if(((rr < 7 && (rd > 0 || rg > 0)) || (wr == 1 || wr == 2)) && gr == 0 && gd == 0 && gg == policeGuestCount) {
            Debug.Log(gg +"gg + " + policeGuestCount + "police");
            Debug.Log(rg +"rg");
            Debug.Log(wg +"wg");
            duStasiEnding8.SetActive(true);
            mainMenuButton.SetActive(true);
            GameObject.Find("CodeDecision").GetComponent<CodeDecision>().achDuStasiCount = 8;
        }
        else if(rr == 7 && wd == 13 && gg == policeGuestCount) {
            Debug.Log(gg +"gg + " + policeGuestCount + "police");
            Debug.Log(rg +"rg");
            Debug.Log(wg +"wg");
            duStasiEnding9.SetActive(true);
            mainMenuButton.SetActive(true);
            GameObject.Find("CodeDecision").GetComponent<CodeDecision>().achDuStasiCount = 9;
        }
        else {
            duStasiEnding10.SetActive(true);
            mainMenuButton.SetActive(true);
        }
    }

    public void SpawnGuest(GameObject guest)
    {
        Debug.Log("SpawnGuest Ran");
        GameObject newGuest = Instantiate(guest);
        newGuest.transform.position = new Vector3(startPoint.transform.position.x, startPoint.transform.position.y, startPoint.transform.position.z);
        if (guestStatus == true)
        {
            switch (GameObject.Find("CodeDecision").GetComponent<CodeDecision>().option)
            {
                case "How did you get here?":
                    if (rightGuest == true)
                    {
                        switch (Random.Range(1, 6))
                        {
                            case 1:
                                replyText.GetComponent<Text>().text = "Spaceship";
                                break;
                            case 2:
                                replyText.GetComponent<Text>().text = "Submarine";
                                break;
                            case 3:
                                replyText.GetComponent<Text>().text = "Rocketship";
                                break;
                            case 4:
                                replyText.GetComponent<Text>().text = "Flying Carpet";
                                break;
                            case 5:
                                replyText.GetComponent<Text>().text = "Cammel";
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 6))
                        {
                            case 1:
                                replyText.GetComponent<Text>().text = "Car";
                                break;
                            case 2:
                                replyText.GetComponent<Text>().text = "Tram";
                                break;
                            case 3:
                                replyText.GetComponent<Text>().text = "Bus";
                                break;
                            case 4:
                                replyText.GetComponent<Text>().text = "Walked";
                                break;
                            case 5:
                                replyText.GetComponent<Text>().text = "Bike";
                                break;
                        }
                    }
                    break;
                case "Where are we currently?":
                    if (rightGuest == true)
                    {
                        switch (Random.Range(1, 6))
                        {
                            case 1:
                                replyText.GetComponent<Text>().text = "Melbourne";
                                break;
                            case 2:
                                replyText.GetComponent<Text>().text = "London";
                                break;
                            case 3:
                                replyText.GetComponent<Text>().text = "Hamburg";
                                break;
                            case 4:
                                replyText.GetComponent<Text>().text = "Kyoto";
                                break;
                            case 5:
                                replyText.GetComponent<Text>().text = "New York";
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                replyText.GetComponent<Text>().text = "Berlin";
                                break;
                            case 2:
                                replyText.GetComponent<Text>().text = "East Berlin";
                                break;
                            case 3:
                                replyText.GetComponent<Text>().text = "GDR";
                                break;
                        }
                    }
                    break;
                case "Would you like to eat something?":
                    if (rightGuest == true)
                    {
                        switch (Random.Range(1, 6))
                        {
                            case 1:
                                replyText.GetComponent<Text>().text = "Apple";
                                break;
                            case 2:
                                replyText.GetComponent<Text>().text = "Blood";
                                break;
                            case 3:
                                replyText.GetComponent<Text>().text = "Communism";
                                break;
                            case 4:
                                replyText.GetComponent<Text>().text = "Strawberries";
                                break;
                            case 5:
                                replyText.GetComponent<Text>().text = "Ruby";
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 6))
                        {
                            case 1:
                                replyText.GetComponent<Text>().text = "Pear";
                                break;
                            case 2:
                                replyText.GetComponent<Text>().text = "Orange";
                                break;
                            case 3:
                                replyText.GetComponent<Text>().text = "Cheese";
                                break;
                            case 4:
                                replyText.GetComponent<Text>().text = "Bread";
                                break;
                            case 5:
                                replyText.GetComponent<Text>().text = "Chicken";
                                break;
                        }
                    }
                    break;
                case "What's the best monument in the world?":
                    if (rightGuest == true)
                    {
                        switch (Random.Range(1, 6))
                        {
                            case 1:
                                replyText.GetComponent<Text>().text = "Statue of Liberty";
                                break;
                            case 2:
                                replyText.GetComponent<Text>().text = "Empire State";
                                break;
                            case 3:
                                replyText.GetComponent<Text>().text = "Mount Rushmore";
                                break;
                            case 4:
                                replyText.GetComponent<Text>().text = "Washington Monument";
                                break;
                            case 5:
                                replyText.GetComponent<Text>().text = "Space Needle";
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 6))
                        {
                            case 1:
                                replyText.GetComponent<Text>().text = "Lenin Statue";
                                break;
                            case 2:
                                replyText.GetComponent<Text>().text = "Kremlin";
                                break;
                            case 3:
                                replyText.GetComponent<Text>().text = "Brandenburger Tor";
                                break;
                            case 4:
                                replyText.GetComponent<Text>().text = "Fernsehturm";
                                break;
                            case 5:
                                replyText.GetComponent<Text>().text = "Red Square";
                                break;
                        }
                    }
                    break;
                case "Who is the great leader?":
                    if (rightGuest == true)
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                replyText.GetComponent<Text>().text = "Roosevelt";
                                break;
                            case 2:
                                replyText.GetComponent<Text>().text = "Churchill";
                                break;
                            case 3:
                                replyText.GetComponent<Text>().text = "Eisenhower";
                                break;
                        }
                    }
                    else
                    {
                        switch (Random.Range(1, 4))
                        {
                            case 1:
                                replyText.GetComponent<Text>().text = "Stalin";
                                break;
                            case 2:
                                replyText.GetComponent<Text>().text = "Lenin";
                                break;
                            case 3:
                                replyText.GetComponent<Text>().text = "Mao";
                                break;
                        }
                    }
                    break;
            }
        }
        else
        {
            switch (GameObject.Find("CodeDecision").GetComponent<CodeDecision>().option)
            {
                case "How did you get here?":
                    switch (Random.Range(1, 11))
                    {
                        case 1:
                            replyText.GetComponent<Text>().text = "Spaceship";
                            break;
                        case 2:
                            replyText.GetComponent<Text>().text = "Submarine";
                            break;
                        case 3:
                            replyText.GetComponent<Text>().text = "Rocketship";
                            break;
                        case 4:
                            replyText.GetComponent<Text>().text = "Flying Carpet";
                            break;
                        case 5:
                            replyText.GetComponent<Text>().text = "Cammel";
                            break;
                        case 6:
                            replyText.GetComponent<Text>().text = "Car";
                            break;
                        case 7:
                            replyText.GetComponent<Text>().text = "Tram";
                            break;
                        case 8:
                            replyText.GetComponent<Text>().text = "Bus";
                            break;
                        case 9:
                            replyText.GetComponent<Text>().text = "Walked";
                            break;
                        case 10:
                            replyText.GetComponent<Text>().text = "Bike";
                            break;
                    }
                    break;
                case "Where are we currently?":
                    switch (Random.Range(1, 9))
                    {
                        case 1:
                            replyText.GetComponent<Text>().text = "Melbourne";
                            break;
                        case 2:
                            replyText.GetComponent<Text>().text = "London";
                            break;
                        case 3:
                            replyText.GetComponent<Text>().text = "Hamburg";
                            break;
                        case 4:
                            replyText.GetComponent<Text>().text = "Kyoto";
                            break;
                        case 5:
                            replyText.GetComponent<Text>().text = "New York";
                            break;
                        case 6:
                            replyText.GetComponent<Text>().text = "Berlin";
                            break;
                        case 7:
                            replyText.GetComponent<Text>().text = "East Berlin";
                            break;
                        case 8:
                            replyText.GetComponent<Text>().text = "GDR";
                            break;
                    }
                    break;
                case "Would you like to eat something?":
                    switch (Random.Range(1, 11))
                    {
                        case 1:
                            replyText.GetComponent<Text>().text = "Apple";
                            break;
                        case 2:
                            replyText.GetComponent<Text>().text = "Blood";
                            break;
                        case 3:
                            replyText.GetComponent<Text>().text = "Communism";
                            break;
                        case 4:
                            replyText.GetComponent<Text>().text = "Strawberries";
                            break;
                        case 5:
                            replyText.GetComponent<Text>().text = "Ruby";
                            break;
                        case 6:
                            replyText.GetComponent<Text>().text = "Pear";
                            break;
                        case 7:
                            replyText.GetComponent<Text>().text = "Orange";
                            break;
                        case 8:
                            replyText.GetComponent<Text>().text = "Cheese";
                            break;
                        case 9:
                            replyText.GetComponent<Text>().text = "Bread";
                            break;
                        case 10:
                            replyText.GetComponent<Text>().text = "Chicken";
                            break;
                    }
                    break;
                case "What's the best monument in the world?":
                    switch (Random.Range(1, 11))
                    {
                        case 1:
                            replyText.GetComponent<Text>().text = "Statue of Liberty";
                            break;
                        case 2:
                            replyText.GetComponent<Text>().text = "Empire State";
                            break;
                        case 3:
                            replyText.GetComponent<Text>().text = "Mount Rushmore";
                            break;
                        case 4:
                            replyText.GetComponent<Text>().text = "Washington Monument";
                            break;
                        case 5:
                            replyText.GetComponent<Text>().text = "Space Needle";
                            break;
                        case 6:
                            replyText.GetComponent<Text>().text = "Lenin Statue";
                            break;
                        case 7:
                            replyText.GetComponent<Text>().text = "Kremin";
                            break;
                        case 8:
                            replyText.GetComponent<Text>().text = "Brandenburger Tor";
                            break;
                        case 9:
                            replyText.GetComponent<Text>().text = "Fernsehturm";
                            break;
                        case 10:
                            replyText.GetComponent<Text>().text = "Red Square";
                            break;
                    }
                    break;
                case "Who is the great leader?":
                    switch (Random.Range(1, 7))
                    {
                        case 1:
                            replyText.GetComponent<Text>().text = "Roosevelt";
                            break;
                        case 2:
                            replyText.GetComponent<Text>().text = "Churchill";
                            break;
                        case 3:
                            replyText.GetComponent<Text>().text = "Eisenhower";
                            break;
                        case 4:
                            replyText.GetComponent<Text>().text = "Stalin";
                            break;
                        case 5:
                            replyText.GetComponent<Text>().text = "Lenin";
                            break;
                        case 6:
                            replyText.GetComponent<Text>().text = "Mao";
                            break;
                    }
                    break;
            }
        }
    }
}
