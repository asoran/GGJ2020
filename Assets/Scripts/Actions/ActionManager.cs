using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
public class ActionManager : MonoBehaviour
{
    public int initialNumberOfButtons = 4;

    public List<GameObject> buttons;
    public List<Action> actions;
    private List<Action> usedActions = new List<Action>();

    public List<Action> initialActions;

    private void Start() {
        // Sort actions by draw chance (lower to higher)
        actions.Sort((a1, a2) => (int)(a1.drawChance - a2.drawChance));
        for(int i = 0; i < buttons.Count; ++i) {
            Action action = initialActions[i];
            GameObject o = buttons[i];
            o.AddComponent(action.GetType());
            o.GetComponent<Image> ().sprite = action.sprite;
        }
    }

    private float countTotalDrawChance() {
        float tot = 0;
        foreach(Action a in actions) {
            tot += a.drawChance;
        }
        return tot;
    }

    public void shuffleButtons()
    {
        Debug.Log("Oui");
        usedActions = new List<Action>();

        float maxPercent = countTotalDrawChance();

        foreach (GameObject o in buttons)
        {
            Debug.Log("Button X:");
            Action oldAction = o.GetComponent<Action>();
            if (oldAction != null)
            {
                Destroy(oldAction);
            }

            int rand = Random.Range(0, (int)maxPercent);
            Debug.Log("Rand: " + rand);
            Action action = null;

            // Select a cart depending on it's draw rate
            float total = 0f;
            foreach(Action a in actions) {
                Debug.Log("Total: " + total);
                total += a.drawChance;
                Debug.Log("Total: " + total);
                if(!usedActions.Contains(a)) {
                    if(total >= rand) {
                        Debug.Log("is ok");
                        action = a; 
                        maxPercent -= a.drawChance;
                        break;
                    } else {
                        Debug.Log("Is NOT ok");
                    }
                }
            }
            // If no card was found
            if(action == null) {
                action = actions[0];
            }

            usedActions.Add(action);

            o.AddComponent(action.GetType());
            o.GetComponent<Image> ().sprite = action.sprite;
            o.GetComponent<CooldownScript>().CoolDown();
        }

        Debug.Log("Shuffle finished");
    }

}
