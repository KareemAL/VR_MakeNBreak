using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinCheck : MonoBehaviour
{

    DetectionCell ScriptRef;
    private string LookForTag;
    private bool[] AllDetects;
    private bool currentbool;
    private bool IsWon = false;

    public Material OwnMaterial;

    // variables for making scuffed Timer
    private float delayTimer;
    private bool isDelaying = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsWon) {

            if(!isDelaying) {
            OwnMaterial.color = Color.green;

            // Start the delay
            delayTimer = 3f;
            isDelaying = true;
            }
            else
            {
                // Countdown the delay
                delayTimer -= Time.deltaTime;

                if (delayTimer <= 0f)
                {
                    // Operation 2
                    SceneManager.LoadScene("VRMakeNBreak");

                    // Reset the delay state
                    isDelaying = false;
                }
            }
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