using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAchievements : MonoBehaviour
{
    //general variables
    public GameObject achNote;
    public bool achActive = false;
    public GameObject achTitle;
    public GameObject achDesc;

    //achievement Du Stasi specific
    public GameObject achDuStasiImage;
    public static int achDuStasiCount;
    public int achEndTrigger = 1;
    public int achDuStasiCode;

    // Update is called once per frame
    void Update()
    {
        achDuStasiCode = PlayerPrefs.GetInt("DuStasi");
        if(achDuStasiCount == achEndTrigger && achDuStasiCode != 1)
        {
            StartCoroutine(Trigger01Ach());
        }
    }
    IEnumerator Trigger01Ach()
    {
        achActive = true;
        achDuStasiCode = 1;
        PlayerPrefs.SetInt("DuStasi", achDuStasiCode);
        achDuStasiImage.SetActive(true);
        achTitle.GetComponent<Text>().text = "Du Stasi";
        achDesc.GetComponent<Text>().text = @"-You were a Stasi agent,
  always has been.

- Only give GDR propaganda";
        achNote.SetActive(true);
        yield return new WaitForSeconds(1);
    }
}
