using System.Collections.Generic;


namespace AddressBook.Models

{
  public class Contact
  {
    private string _name;
    private string _address;
    private int _phoneNumber;
    private int _id;

    // private static List<Contact> _instances = new List<Contact> {};

    public Contact (string name, string address, int phoneNumber)
    {
      _name = name;
      _address = address;
      _phoneNumber = phoneNumber;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }


    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }


    public int GetphoneNumber()
    {
      return _phoneNumber;
    }
    public void SetphoneNumber(int newphoneNumber)
    {
      _phoneNumber = newphoneNumber;
    }

    public int GetId()
    {
      return _id;
    }


    // public static List<Contact> GetAll()
    // {
    //   return _instances;
    // }
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
    // public static Contact Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }


  }
}
