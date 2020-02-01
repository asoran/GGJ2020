using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class Action : MonoBehaviour
{

    private ActionManager actionManager;
    protected Variables variables;

    private Button button;
    protected TextMeshProUGUI text_button;

    private void Start()
    {
        GameObject buttonManager = GameObject.FindGameObjectWithTag("ButtonManager");
        actionManager = buttonManager.GetComponent<ActionManager>();

        if(gameObject != buttonManager)
        {
            variables = GameObject.FindGameObjectWithTag("VariableObject").GetComponent<Variables>();

            button = GetComponent<Button>();
            if (button != null)
                button.onClick.AddListener(executeAction);

            text_button = GetComponentInChildren<TextMeshProUGUI>();

            start();
        }
        
    }

    private void executeAction()
    {
        doAction();
        actionManager.shuffleButtons();
    }

    protected abstract void start();
    protected abstract void doAction();

}
