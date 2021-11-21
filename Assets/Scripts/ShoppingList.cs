using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShoppingList
{
    static int initializeTimesCount = 0;

    //List of all products that you CAN buy
    static private List<string> m_listOfProducts = new List<string>{ "Grand Dad", "Mario", "Win98 NES", 
            "Panda Prince", "Konkey Dong", "Sonic the Hedgeghog", 
            "Hungry Birds", "Wario", "Donkey Kong", "Godzilla Lamp (Only Blue)", 
            "Unicorn Headphones", "Crocodile Watch", "Cap with Flashlight (Blue)",
            "Otamatone", "4-USB Charger", "Cap with Flashlight (Pink)",
            "Godzilla Lamp (Only Pink)", "Nano Gauntlet", "Unicorn Headphones (GOLD EDITION)"};

    //List of products that you NEED to buy
    static private List<string> m_shoppingList = new List<string>();

    //List of products that are in your cart
    static private List<string> m_cartList = new List<string>();

    static public void Initialize(int numberOfItems)
    {
        initializeTimesCount++;
        if (initializeTimesCount > 1)
        {
            Debug.LogError(typeof(ShoppingList).Name + " was initialized more than once, check your code!");
        }

        for (int i = 0; i < numberOfItems; ++i)
        {
            int randomNumber = UnityEngine.Random.Range(0, m_listOfProducts.Count - 1);
            m_shoppingList.Add(m_listOfProducts[randomNumber]);
            m_listOfProducts.RemoveAt(randomNumber);

            //Debug.Log("Item added: " + m_shoppingList[i]);

        }
    }

    static public void AddElementToCartList(string productName)
    {
        m_cartList.Add(productName);
    }

    static public void DeleteElementFromCartList(string productName)
    {
        m_cartList.Remove(productName);
    }

    static public string GetElementValue(int index)
    {

        return m_shoppingList[index];

    }

    static public List<string> GetShoppingList()
    {
        return m_shoppingList;
    }



}
