using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheck : MonoBehaviour
{

    DetectionCell ScriptRef;
    private string LookForTag;
    private bool[] AllDetects;
    private bool currentbool;
    private bool IsWon = false;

    public Material OwnMaterial;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsWon) {
            OwnMaterial.color = Color.green;
        }
        else {
            OwnMaterial.color = Color.red;
        }

        int currentCheckIndex = 0;

        for(int a=1; a < 8; a++)
        {
            for(int b=1; b < 9; b++)
            {
                currentCheckIndex++;
                LookForTag = "Tag_" + a + "_" + b;
                ScriptRef = GameObject.FindGameObjectWithTag(LookForTag).GetComponent<DetectionCell>();
                currentbool = ScriptRef.IsDetected();
                if (!currentbool){
                    IsWon = false;
                    return;
                }
            }
        }

        IsWon = true;
    }
    
}