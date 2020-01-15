using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowText : MonoBehaviour
{
    public GameObject obj;
    public static bool disable = false;

    void Start()
    {
        StartCoroutine(EnableText());
    }

   public IEnumerator EnableText()
   {
        yield return new WaitForSeconds(10.2f);
        obj.SetActive(true);

   }
}
