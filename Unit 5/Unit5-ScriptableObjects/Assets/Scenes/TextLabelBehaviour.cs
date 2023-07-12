using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextLabelBehaviour : MonoBehaviour
{
    public Text label;
    public DamageBoost damageBoost;

    private void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();  
    }

    public void UpdateLabel ()
    {
        label.text = damageBoost.damageBoost.ToString(CultureInfo.InvariantCulture);
    }
}
