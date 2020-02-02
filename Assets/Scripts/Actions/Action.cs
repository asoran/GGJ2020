using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class Action : MonoBehaviour {

    public enum RARITY {
        TRES_COMMUN,
        COMMUN,
        PEU_COMMUN,
        COURANT,
        RARE
    }

    public GameObject planet;

    protected ActionManager actionManager;
    protected Variables variables;
    public Sprite sprite;
    private Button button;
    protected TextMeshProUGUI text_button;

    public float drawChance;
    public RARITY rarity;

    private void Start () {

        GameObject buttonManager = GameObject.FindGameObjectWithTag ("ButtonManager");
        actionManager = buttonManager.GetComponent<ActionManager> ();

        variables = GameObject.FindGameObjectWithTag ("VariableObject").GetComponent<Variables> ();
        planet = GameObject.FindGameObjectWithTag ("Planet");

        if (gameObject != buttonManager) {
            button = GetComponent<Button> ();
            if (button != null)
                button.onClick.AddListener (executeAction);

            text_button = GetComponentInChildren<TextMeshProUGUI> ();
        }
    }

    private void executeAction () {
        doAction ();
        actionManager.shuffleButtons ();
    }
    protected abstract void doAction ();

    public virtual bool isActive () {
        return true;
    }
}