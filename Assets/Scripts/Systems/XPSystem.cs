using TMPro;
using UnityEngine;

public class XPSystem : MonoBehaviour
{
    private int XP;
    [SerializeField]
    public TMP_Text xpText;

    public void AddXP(int x)
    {
        XP+=x;    
        xpText.text = "XP: " + XP;
    }
}
