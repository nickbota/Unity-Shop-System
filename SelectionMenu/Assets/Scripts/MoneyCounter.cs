using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour
{
    private Text txt;

    private void Awake()
    {
        txt = GetComponent<Text>();
    }
    private void Update()
    {
        txt.text = SaveManager.instance.money + "$";
    }
}