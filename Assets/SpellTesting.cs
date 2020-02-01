using UnityEngine;
using TMPro;

public class SpellTesting : MonoBehaviour
{
    public TextMeshProUGUI spell_text;
    public Transform bloc1;
    public Transform bloc2;
    public void ChooseSpeell()
    {
        int spell = Random.Range(1, 5);

        spell_text.text = "spell " + spell;
    }

    private void Update()
    {
        bloc1.transform.position += bloc1.forward * Time.deltaTime;
        bloc2.transform.position += bloc2.forward * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        
    }
}
