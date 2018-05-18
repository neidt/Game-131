using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MoveInstructions))]
[CanEditMultipleObjects]
[ExecuteInEditMode]
public class MoveInstructionsEditor : Editor
{
    Transform moveBot;
    GameObject moveBotObj;
    MoveInstructions moveScript;
    //public GameObject[] checkpoints = new GameObject[80];
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        moveScript = ((MonoBehaviour)target).gameObject.GetComponent<MoveInstructions>();
        
        if (GUILayout.Button("add Checkpoints to list"))
        {
           
            for (int i = 0; i < 80; i++)
            {
                GameObject[] checkpoints = GameObject.FindGameObjectsWithTag("Checkpoint");
                moveScript.positions.Add(checkpoints[i].transform.position);
            }
        }
        if(GUILayout.Button("Move object to next checkpoint"))
        {
            for(int i = 0; i <= 80; i++)
            {
                moveBot.transform.position = moveScript.positions[i];
            }
        }
        
    }

    private void OnSceneGUI()
    {
        moveBot = ((MonoBehaviour)target).gameObject.GetComponent<Transform>();
        moveBotObj = ((MonoBehaviour)target).gameObject.GetComponent<GameObject>(); ;
        moveScript = ((MonoBehaviour)target).gameObject.GetComponent<MoveInstructions>();
        Event currentEvent = Event.current;
        switch (currentEvent.type)
        {
            case EventType.KeyDown:
                if (currentEvent.keyCode == KeyCode.W)
                {

                    //change the objects position to the current mouse position
                    Vector3 screenPos = Event.current.mousePosition;
                    screenPos.y = Camera.current.pixelHeight - screenPos.y;
                    Vector3 worldPos = Camera.current.ScreenToWorldPoint(screenPos);
                    worldPos.y = 1;
                    moveBotObj.transform.position = worldPos;

                }
                break;
            case EventType.KeyUp:
                currentEvent.Use();
                break;

        }
    }

    
}
