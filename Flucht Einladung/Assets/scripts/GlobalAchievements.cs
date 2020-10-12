using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAchievements : MonoBehaviour
{
    //general variables
    public GameObject achNote; //Achievement Panel Object
    public GameObject achNote2;
    public GameObject achNote3;
    public GameObject achNote4;
    public GameObject achNote5;
    public GameObject achNote6;
    public GameObject achNote7;
    public GameObject achNote8;
    public GameObject achNote9;
    public bool achActive = false; //Boolean for Unlock or Locked
    public GameObject achTitle; //Achievement Title
    public GameObject achTitle2;
    public GameObject achTitle3;
    public GameObject achTitle4;
    public GameObject achTitle5;
    public GameObject achTitle6;
    public GameObject achTitle7;
    public GameObject achTitle8;
    public GameObject achTitle9;
    public GameObject achDesc; //Achievement Description
    public GameObject achDesc2;
    public GameObject achDesc3;
    public GameObject achDesc4;
    public GameObject achDesc5;
    public GameObject achDesc6;
    public GameObject achDesc7;
    public GameObject achDesc8;
    public GameObject achDesc9;

    //achievement Du Stasi specific
    public GameObject achDuStasiImage; //Achievement Image a.k.a ending scene
    public int achDuStasiCount; //Trigger (if the count = 1, unlocks achievement)
    public int achEndTrigger = 1; //Trigger check (if achDuStasiCount becomes 1)
    public int achEndTrigger2 = 2;
    public int achEndTrigger3 = 3;
    public int achEndTrigger4 = 4;
    public int achEndTrigger5 = 5;
    public int achEndTrigger6 = 6;
    public int achEndTrigger7 = 7;
    public int achEndTrigger8 = 8;
    public int achEndTrigger9 = 9;
    public int achDuStasiCode; //
    public int achDuStasiCode2; //
    public int achDuStasiCode3; //
    public int achDuStasiCode4; //
    public int achDuStasiCode5; //
    public int achDuStasiCode6; //
    public int achDuStasiCode7; //
    public int achDuStasiCode8; //
    public int achDuStasiCode9; //

    // Update is called once per frame
    
    void Start(){
        
    }
    void Update()
    {
        achDuStasiCount = GameObject.Find("CodeDecision").GetComponent<CodeDecision>().achDuStasiCount;
        
        achDuStasiCode = PlayerPrefs.GetInt("DuStasi");
        achDuStasiCode2 = PlayerPrefs.GetInt("OpenUp");
        achDuStasiCode3 = PlayerPrefs.GetInt("Prison");
        achDuStasiCode4 = PlayerPrefs.GetInt("PartyIsOver");
        achDuStasiCode5 = PlayerPrefs.GetInt("EscapeAlone");
        achDuStasiCode6 = PlayerPrefs.GetInt("Surrounded");
        achDuStasiCode7 = PlayerPrefs.GetInt("TunnelBoom");
        achDuStasiCode8 = PlayerPrefs.GetInt("HistoryLesson");
        achDuStasiCode9 = PlayerPrefs.GetInt("SafeEscape");

        if(achDuStasiCount == achEndTrigger && achDuStasiCode != 10)
        {
            Debug.Log("Coroutine Start");
            StartCoroutine(Trigger01Ach());
        }
        else if(achDuStasiCount == achEndTrigger2 && achDuStasiCode != 2)
        {
            Debug.Log("Coroutine Start");
            StartCoroutine(Trigger02Ach());
        }
        else if(achDuStasiCount == achEndTrigger3 && achDuStasiCode != 3)
        {
            Debug.Log("Coroutine Start");
            StartCoroutine(Trigger03Ach());
        }
        else if(achDuStasiCount == achEndTrigger4 && achDuStasiCode != 4)
        {
            Debug.Log("Coroutine Start");
            StartCoroutine(Trigger04Ach());
        }
        else if(achDuStasiCount == achEndTrigger5 && achDuStasiCode != 5)
        {
            Debug.Log("Coroutine Start");
            StartCoroutine(Trigger05Ach());
        }
        else if(achDuStasiCount == achEndTrigger6 && achDuStasiCode != 6)
        {
            Debug.Log("Coroutine Start");
            StartCoroutine(Trigger06Ach());
        }
        else if(achDuStasiCount == achEndTrigger7 && achDuStasiCode != 7)
        {
            Debug.Log("Coroutine Start");
            StartCoroutine(Trigger07Ach());
        }
        else if(achDuStasiCount == achEndTrigger8 && achDuStasiCode != 8)
        {
            Debug.Log("Coroutine Start");
            StartCoroutine(Trigger08Ach());
        }
        else if(achDuStasiCount == achEndTrigger9 && achDuStasiCode != 9)
        {
            Debug.Log("Coroutine Start");
            StartCoroutine(Trigger09Ach());
        }
    }
    IEnumerator Trigger01Ach()
    {
        achActive = true;
        achDuStasiCode = 10;
        PlayerPrefs.SetInt("DuStasi", achDuStasiCode);
        achDuStasiImage.SetActive(true);
        achNote.SetActive(true);
        achTitle.GetComponent<Text>().text = "Du Stasi";
        achDesc.GetComponent<Text>().text = @"-You were a Stasi agent,
  always has been.

- Only give GDR propaganda";
        achNote.SetActive(true);
        yield return new WaitForSeconds(1);
    }

        IEnumerator Trigger02Ach()
    {
        achDuStasiCode2 = 2;
        PlayerPrefs.SetInt("OpenUp", achDuStasiCode2);
        achNote2.SetActive(true);
        achTitle2.GetComponent<Text>().text = "Stasi! Open Up!";
        achDesc2.GetComponent<Text>().text = @"-A Stasi agent discovered your 
 intentions to escape. 
 Fortunately enough you gave 
 them the decoy info, so they did 
 not discover the others but you 
 were arrested
-Give the decoy information 
 to a Stasi agent";
        achNote2.SetActive(true);
        yield return new WaitForSeconds(1);
    }

    IEnumerator Trigger03Ach()
    {
        achDuStasiCode3 = 3;
        PlayerPrefs.SetInt("Prison", achDuStasiCode3);
        achNote3.SetActive(true);
        achTitle3.GetComponent<Text>().text = "Fate Sealed";
        achDesc3.GetComponent<Text>().text = @"-A Stasi agent discovered your intentions 
  to escape. In prison you feel the guilt
  knowing that you gave them the right
  information and everyone who shows 
  up will be arrested
-Give the right information to a Stasi agent";
        achNote3.SetActive(true);
        yield return new WaitForSeconds(1);
    }

        IEnumerator Trigger04Ach()
    {
        achDuStasiCode4 = 4;
        PlayerPrefs.SetInt("PartyIsOver", achDuStasiCode4);
        achNote4.SetActive(true);
        achTitle4.GetComponent<Text>().text = "The Party Is Over";
        achDesc4.GetComponent<Text>().text = @"-In a showcase of massive inompetence 
  you invite everyone who knocked at the
  door to use the tunnel.
  Everyone showed up for the
  escape party... including the border 
  guards. Everyone intending to escape
  got arrested
-Only give right information 
 (except to Stasi agents)";
        achNote4.SetActive(true);
        yield return new WaitForSeconds(1);
    }

        IEnumerator Trigger05Ach()
    {
        achDuStasiCode5 = 5;
        PlayerPrefs.SetInt("EscapeAlone", achDuStasiCode5);
        achNote5.SetActive(true);
        achTitle5.GetComponent<Text>().text = "Ganz Allein";
        achDesc5.GetComponent<Text>().text = @"-You used the tunnel just for 
  yourself and blew it 
  up afterwards. 
  You are a selfish 
  scum of society
-Only give decoy
  information 
  (except to Stasi agents)";
        achNote5.SetActive(true);
        yield return new WaitForSeconds(1);
    }

        IEnumerator Trigger06Ach()
    {
        achDuStasiCode6 = 6;
        PlayerPrefs.SetInt("Surrounded", achDuStasiCode6);
        achNote6.SetActive(true);
        achTitle6.GetComponent<Text>().text = "Surrounded";
        achDesc6.GetComponent<Text>().text = @"-The neighbours were 
  suspicious of you handing 
  GDR propaganda since they 
  know you are not very fond of it. 
  Thus; they informed the
  authorities and now you got 
  an eye on you all the time, 
  you can not make anything suspicious,
   not to say trying to leave through 
   the tunnel
-Give GDR propaganda a person with to
  a wrong code 3+ times";
        achNote6.SetActive(true);
        yield return new WaitForSeconds(1);
    }

        IEnumerator Trigger07Ach()
    {
        achDuStasiCode7 = 7;
        PlayerPrefs.SetInt("TunnelBoom", achDuStasiCode7);
        achNote7.SetActive(true);
        achTitle7.GetComponent<Text>().text = "Something Went Boom";
        achDesc7.GetComponent<Text>().text = @"-Someone snitched the 
  tunnel's location to the 
  authorities and it got 
  blown up; therefore, 
  no one could escape
-Give right information to a person with
  a wrong code answer 3+ times";
        achNote7.SetActive(true);
        yield return new WaitForSeconds(1);
    }

        IEnumerator Trigger08Ach()
    {
        achDuStasiCode8 = 8;
        PlayerPrefs.SetInt("HistoryLesson", achDuStasiCode8);
        achNote8.SetActive(true);
        achTitle8.GetComponent<Text>().text = "History Lesson";
        achDesc8.GetComponent<Text>().text = @"-You made the escape but
  border guards discovered
  you last minute, guns were
  shot and a guard was
  mortaly wounded as you all
  entered the tunnel towards
  freedom
-Give right information to a person with
  a wrong code answer 1-2 time";
        achNote8.SetActive(true);
        yield return new WaitForSeconds(1);
    }

        IEnumerator Trigger09Ach()
    {
        achDuStasiCode9 = 9;
        PlayerPrefs.SetInt("SafeEscape", achDuStasiCode9);
        achNote9.SetActive(true);
        achTitle9.GetComponent<Text>().text = "Perfekte Flucht";
        achDesc9.GetComponent<Text>().text = @"-You flawlessly escaped 
  with the right people

-Make 0 mistakes.";
        achNote9.SetActive(true);
        yield return new WaitForSeconds(1);
    }
}
