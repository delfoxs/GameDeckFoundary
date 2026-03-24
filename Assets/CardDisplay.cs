using TMPro;
using UnityEngine;

public class CardDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshPro numberText;

    public void SetCardValue(int value)
    {
        if (numberText != null)
        {
            numberText.text = value.ToString();
        }
    }

    private void LateUpdate()
    {
        if (numberText != null)
        {
            numberText.transform.rotation = Quaternion.identity;
        }
    }
}