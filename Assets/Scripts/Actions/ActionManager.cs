using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
public class ActionManager : MonoBehaviour
{
    public List<GameObject> buttons;
    public List<Action> actions;
    private List<Action> usedActions = new List<Action>();

    public void shuffleButtons()
    {
        this.actions.AddRange(usedActions);
        usedActions.Clear();

        foreach (GameObject o in buttons)
        {
            Action oldAction = o.GetComponent<Action>();
            if (oldAction)
            {
                Destroy(oldAction);
            }
            
            int i = Random.Range(0, actions.Count);

            Action a = actions[i];
            o.AddComponent(a.GetType());
            o.GetComponent<Image> ().sprite = a.sprite;
            usedActions.Add(a);
            actions.Remove(a);
        }

    }

}
