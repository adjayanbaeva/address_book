using System.Collections.Generic;


namespace AddressBook.Models

{
  public class Contact
  {
    private string _name;
    private string _address;
    private string _phoneNumber;
    private int _id;

    private static List<Contact> _instances = new List<Contact> {};

    public Contact (string name, string address, string phoneNumber)
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


    public string GetphoneNumber()
    {
      return _phoneNumber;
    }
    public void SetphoneNumber(string newphoneNumber)
    {
      _phoneNumber = newphoneNumber;
    }

    public int GetId()
    {
      return _id;
    }


    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public void Save()
  {
    _instances.Add(this);
  }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }


  }
}
