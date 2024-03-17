using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemySpawnerController : MonoBehaviour
{
    [SerializeField] TMP_Text UItext;
    [SerializeField] int lv1Monster = 0;
    [SerializeField] int lv2Monster = 0;
    [SerializeField] int lv3Monster = 0;

    // Start is called before the first frame update
    void Start()
    {
        SetText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetText()
    {
        int lineCount = 0;
        UItext.text = "";

        if (lv1Monster > 0) 
        {
            UItext.text += "Lv1x" + lv1Monster;
            ++lineCount;
        }

        if (lv2Monster > 0)
        {
            if(lineCount > 0)
                UItext.text += "\n";

            UItext.text += "Lv2x" + lv2Monster;
            ++lineCount;
        }

        if (lv3Monster > 0)
        {
            if (lineCount > 0)
                UItext.text += "\n";
            UItext.text += "Lv3x" + lv3Monster;
            ++lineCount;
        }
    }
}
