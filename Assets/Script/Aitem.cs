using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aitem : MonoBehaviour
{
    public GameObject aitem1;
    public GameObject aitem2;
    public GameObject aitem3;
    public GameObject aitem4;
    public GameObject aitem5;
    public GameObject aitem6;
    public GameObject aitem7;

    // Start is called before the first frame update
    void Start()
    {
        aitem1.gameObject.SetActive(false);
        aitem2.gameObject.SetActive(false);
        aitem3.gameObject.SetActive(false);
        aitem4.gameObject.SetActive(false);
        aitem5.gameObject.SetActive(false);
        aitem6.gameObject.SetActive(false);
        aitem7.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Flag.kawa == true) aitem1.gameObject.SetActive(true);
        else aitem1.gameObject.SetActive(false);

        if (Flag.beef == true) aitem2.gameObject.SetActive(true);
        else aitem2.gameObject.SetActive(false);

        if (Flag.vegeta == true) aitem3.gameObject.SetActive(true);
        else aitem3.gameObject.SetActive(false);

        if (Flag.houcho == true) aitem4.gameObject.SetActive(true);
        else aitem4.gameObject.SetActive(false);

        if (Flag.huraipan == true) aitem5.gameObject.SetActive(true);
        else aitem5.gameObject.SetActive(false);

        if (Flag.kokku == true) aitem6.gameObject.SetActive(true);
        else aitem6.gameObject.SetActive(false);

        if (Flag.kagi == true) aitem7.gameObject.SetActive(true);
        else aitem7.gameObject.SetActive(false);
    }
}
