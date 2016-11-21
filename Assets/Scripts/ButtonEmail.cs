using UnityEngine;
using System.Collections;

public class ButtonEmail : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

     void OnClick()
     {
         string message = "";
        switch (DataLevel.Instance.CurrentNumberModel)
         {
            case 0:
                
               message="Пуф - Груша Попарада;"+" "+"Ткань - "+DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShaderPanel2].name;
                break;
            case 1:
                message = "Пуф - Цветок; Ткань верха (основа) - " + DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShader_Flower_UP].name + "; Ткань низа (дополнительная) - " + DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShader_Flower_Down].name;
                break;
            case 2:
                message = "Пуф - Комфорт; Ткань верха (основа) - " + DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShader_Comfort_UP].name + "; Ткань низа (дополнительная) - " + DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShader_Comfort_Down].name;
                break;
            case 3:
                message = "Пуф - Диван; Ткань верха (основа) - " + DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShader_Sofa_UP].name + "; Ткань низа (дополнительная) - " + DataLevel.Instance.Matrerials[DataLevel.Instance.CurrentShader_Sofa_Down].name;
                break;
        }
        SendMailCrossPlatform.SendEmail("info@poparada.com.ua", "Заказ пуфа", message);
         //Debug.Log(message);
    }
}
