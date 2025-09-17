using System.Linq;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Cryptor : MonoBehaviour
{
    [SerializeField] private Button decryptBotton;
    [SerializeField] private Button peelBotton;
    [SerializeField] private Button correctBotton;
    [SerializeField] private Button encryptBotton;
    [SerializeField, TextArea(3, 20)] private string message;
    [SerializeField] private TextMeshProUGUI messageText;

    private void Awake()
    {
        UpdareUI();
        decryptBotton.onClick.AddListener(Decrypt);
        peelBotton.onClick.AddListener(Peel); 
        correctBotton.onClick.AddListener(Correct);
        encryptBotton.onClick.AddListener(Encrypt);
    }
    private void Decrypt()
    {
        message = message.Replace('*', 'u');
        UpdareUI();
        decryptBotton.onClick.RemoveAllListeners();
    }
    private void Correct()
    {
        message = message.Replace('>', '\n');
        UpdareUI();
        correctBotton.onClick.RemoveAllListeners();
    }
    private void Peel()
    {
        message = message.Replace("$", "");
        message = message.TrimEnd('z');
        UpdareUI();
        peelBotton.onClick.RemoveAllListeners();
    }
    private void Encrypt()
    {
        message = message.Replace('e', '3');
        message = message.Replace('o', '0');
        message = message + "lolz";
        message = message.Replace("Cats", ":3");
        message = message.Replace("cats", ":3");
        message = message.Replace("\n", "+");
        UpdareUI();
        encryptBotton.onClick.RemoveAllListeners();
    }
    private void UpdareUI()
    {
        messageText.text = message;
    }
}
