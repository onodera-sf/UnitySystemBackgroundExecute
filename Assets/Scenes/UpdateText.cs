using System;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
  private Text Text;

  // Start is called before the first frame update
  void Start()
  {
    Text = GetComponent<Text>();
  }

  // Update is called once per frame
  void Update()
  {
    Text.text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
  }
}
