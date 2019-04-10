using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class DataLoader : MonoBehaviour {

    public string[] items;
    public Text Name, Webiste;
    public String result;
    public String takeName, takeEmail, takeInfo, takeContact;
    public String takeAbout2, takeAbout3, takeAbout4, takeAbout5, takeAbout6, takeAbout7;


    // Use this for initialization
    IEnumerator Start () {

       //WW itemsData = new WWW("http://localhost/avitest/ItemsData.php");
       WWW itemsData = new WWW("http://52.37.17.174/ItemData.php");
            
        yield return itemsData;
        string itemsDataString = itemsData.text;

       print(itemsDataString);
        items = itemsDataString.Split(';');
       // print(GetDataValue(items[0], "Name:"));
       // print(GetDataValue(items[0], "Website:"));
        //print(GetDataValue(items[0], "About:"));
        takeName = GetDataValue(items[0], "Name:");
        takeEmail = GetDataValue(items[0], "Website:");
        takeContact = GetDataValue(items[0], "Contact:");
        takeInfo = GetDataValue(items[0], "About:");
        takeAbout2 = GetDataValue(items[0], "About2:");
        takeAbout3 = GetDataValue(items[0], "About3:");
        takeAbout4 = GetDataValue(items[0], "About4:");
        takeAbout5 = GetDataValue(items[0], "About5:");
        takeAbout6 = GetDataValue(items[0], "About6:");
        print(GetDataValue(items[0], "About5:"));
      //  takeAbout6 = GetDataValue(items[0], "About7:");
        //print(GetDataValue(items[0], "About5:"));

        GameObject.Find("UIAbout6").GetComponent<TextMesh>().text = GetDataValue(items[0], "About6:");
        GameObject.Find("UIAbout7").GetComponent<TextMesh>().text = GetDataValue(items[0], "About7:");


    }

    /*  string GetDataValue(string data, string index)
      {
          string value = data.Substring(data.IndexOf(index) + index.Length);
         // string value = data.Substring(data.IndexOf(index));
          if (value.Contains("|")) value = value.Remove(value.IndexOf("|"));

          Name.text = value;
         Name.text = GameObject.Find("Name") = ;
         GetDataValue(items[0], "Name:") = Name.text;
           GameObject.Find("Email").GetComponent<Text>() = email.text;
          Debug.Log(email.text);
           GameObject.Find("WebAddress").GetComponent<Text>() = name.text;

          return value;
      }

      */

    string GetDataValue(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length+1);
        if (value.Contains("|")) value = value.Remove(value.IndexOf("|"));
      
        //   Name.text = GameObject.Find("Name") = ;
        //GetDataValue(items[0], "Name:") = Name.text;
        //  GameObject.Find("Email").GetComponent<Text>() = email.text;

        GameObject.Find("UiName").GetComponent<TextMesh>().text = takeName;
        GameObject.Find("UiEmail").GetComponent<TextMesh>().text = takeEmail;
        GameObject.Find("UiTelephone").GetComponent<TextMesh>().text = takeContact;
        GameObject.Find("UIAbout").GetComponent<TextMesh>().text = takeInfo;
        GameObject.Find("UIAbout2").GetComponent<TextMesh>().text = takeAbout2;
        GameObject.Find("UIAbout3").GetComponent<TextMesh>().text = takeAbout3;
        GameObject.Find("UIAbout4").GetComponent<TextMesh>().text = takeAbout4;
        GameObject.Find("UIAbout5").GetComponent<TextMesh>().text = takeAbout5;
        GameObject.Find("UIAbout6").GetComponent<TextMesh>().text = takeAbout6;
        GameObject.Find("UIAbout7").GetComponent<TextMesh>().text = takeAbout7;

        // Debug.Log(GameObject.Find("UiName").GetComponent<TextMesh>().text);

        // Debug.Log(email.text); 
        //  GameObject.Find("WebAddress").GetComponent<Text>() = name.text;


        return value;
    }
}
