// Decompiled with JetBrains decompiler
// Type: k
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Xml;

public class k
{
  public k(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.r(Dns.GetHostAddresses(Dns.GetHostName()));
    // ISSUE: reference to a compiler-generated method
    this.v(A_0);
    // ISSUE: reference to a compiler-generated method
    this.r(new XmlDocument());
    try
    {
      if (A_0.ToLower().EndsWith(".xml"))
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.u().Load(this.t());
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.u().LoadXml(this.t());
      }
    }
    catch (FileNotFoundException ex)
    {
      // ISSUE: reference to a compiler-generated method
      throw new ApplicationException("could not find " + this.t());
    }
    catch (XmlException ex)
    {
      // ISSUE: reference to a compiler-generated method
      throw new ApplicationException("could not parse " + this.t() + ", error in line " + (object) ex.LineNumber + " " + ex.Message);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.u().DocumentElement.Name != "deployment")
    {
      // ISSUE: reference to a compiler-generated method
      throw new ApplicationException("could not parse " + this.t() + ", root element must be 'deployment'");
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.w(aim.a(this.u().DocumentElement, "name", "noname"));
    // ISSUE: reference to a compiler-generated method
    this.t(new Dictionary<string, string>());
    // ISSUE: reference to a compiler-generated method
    foreach (XmlElement xmlElement in this.u().GetElementsByTagName("settings"))
    {
      foreach (XmlElement A_0_1 in xmlElement.GetElementsByTagName("setting"))
      {
        string key = aim.h(A_0_1, "name");
        string str = aim.h(A_0_1, "value");
        if (string.IsNullOrEmpty(key))
        {
          // ISSUE: reference to a compiler-generated method
          throw new ApplicationException("error in " + this.t() + ", <setting> with missing 'name' found");
        }
        if (string.IsNullOrEmpty(str))
        {
          // ISSUE: reference to a compiler-generated method
          throw new ApplicationException("error in " + this.t() + ", <setting> '" + key + "' is missing a 'value'");
        }
        // ISSUE: reference to a compiler-generated method
        this.w().Add(key, str);
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.r(new Dictionary<string, string>());
    // ISSUE: reference to a compiler-generated method
    foreach (XmlElement xmlElement in this.u().GetElementsByTagName("clientsettings"))
    {
      foreach (XmlElement A_0_1 in xmlElement.GetElementsByTagName("setting"))
      {
        string key = aim.h(A_0_1, "name");
        string str = aim.h(A_0_1, "value");
        if (string.IsNullOrEmpty(key))
        {
          // ISSUE: reference to a compiler-generated method
          throw new ApplicationException("error in " + this.t() + ", client <setting> with missing 'name' found");
        }
        // ISSUE: reference to a compiler-generated method
        this.ac().Add(key, str);
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.s(new Dictionary<string, string>());
    // ISSUE: reference to a compiler-generated method
    this.u(new Dictionary<string, List<string>>());
    // ISSUE: reference to a compiler-generated method
    this.t(new Dictionary<string, List<string>>());
    // ISSUE: reference to a compiler-generated method
    this.s(new Dictionary<string, List<string>>());
    // ISSUE: reference to a compiler-generated method
    this.r(new Dictionary<string, List<string>>());
    // ISSUE: reference to a compiler-generated method
    this.r(new List<global::k.a>());
    // ISSUE: reference to a compiler-generated method
    foreach (XmlNode childNode in this.u().DocumentElement.ChildNodes)
    {
      if (childNode.Name == "machine")
      {
        string str = this.ae(aim.a((XmlElement) childNode, "publicip", "").Trim());
        string A_0_1 = this.ae(aim.a((XmlElement) childNode, "privateip", str).Trim());
        string A_0_2 = this.ae(aim.a((XmlElement) childNode, "os", "").Trim());
        string A_0_3 = this.ae(aim.a((XmlElement) childNode, "login", "").Trim());
        string A_0_4 = this.ae(aim.a((XmlElement) childNode, "password", "").Trim());
        foreach (XmlElement A_0_5 in ((XmlElement) childNode).GetElementsByTagName("alias"))
        {
          bool flag = aim.a(A_0_5, "prefixwithip", false);
          aim.h(A_0_5, "name");
          if (flag)
          {
            // ISSUE: reference to a compiler-generated method
            this.x().Add(str.Replace(".", "-") + aim.h(A_0_5, "name"), A_0_1);
          }
          else
          {
            // ISSUE: reference to a compiler-generated method
            this.x().Add(aim.h(A_0_5, "name"), A_0_1);
          }
        }
        foreach (XmlElement A_0_5 in ((XmlElement) childNode).GetElementsByTagName("photonapplication"))
        {
          string key = aim.h(A_0_5, "name");
          // ISSUE: reference to a compiler-generated method
          if (!this.y().ContainsKey(key))
          {
            // ISSUE: reference to a compiler-generated method
            this.y().Add(key, new List<string>());
          }
          // ISSUE: reference to a compiler-generated method
          this.y()[key].Add(A_0_1);
          // ISSUE: reference to a compiler-generated method
          if (!this.z().ContainsKey(key))
          {
            // ISSUE: reference to a compiler-generated method
            this.z().Add(key, new List<string>());
          }
          // ISSUE: reference to a compiler-generated method
          this.z()[key].Add(str);
        }
        foreach (XmlElement A_0_5 in ((XmlElement) childNode).GetElementsByTagName("database"))
        {
          string index1 = aim.h(A_0_5, "name");
          // ISSUE: reference to a compiler-generated method
          if (!this.aa().ContainsKey(index1))
          {
            // ISSUE: reference to a compiler-generated method
            this.aa().Add(index1, new List<string>());
          }
          // ISSUE: reference to a compiler-generated method
          this.aa()[index1].Add(A_0_1);
          string index2 = aim.h(A_0_5, "type");
          // ISSUE: reference to a compiler-generated method
          if (!this.ab().ContainsKey(index2))
          {
            // ISSUE: reference to a compiler-generated method
            this.ab().Add(index2, new List<string>());
          }
          // ISSUE: reference to a compiler-generated method
          this.ab()[index2].Add(A_0_1);
          global::k.a a = new global::k.a();
          // ISSUE: reference to a compiler-generated method
          a.j(index1);
          // ISSUE: reference to a compiler-generated method
          a.k(index2);
          // ISSUE: reference to a compiler-generated method
          a.i(A_0_1);
          string upper = index1.Replace("albion_", "").ToUpper();
          // ISSUE: reference to a compiler-generated method
          a.n(this.ac(upper + "DB_USER_NAME"));
          // ISSUE: reference to a compiler-generated method
          a.o(this.ac(upper + "DB_USER_PASSWORD"));
          // ISSUE: reference to a compiler-generated method
          a.l(A_0_3);
          // ISSUE: reference to a compiler-generated method
          a.m(A_0_4);
          // ISSUE: reference to a compiler-generated method
          a.p(A_0_2);
          // ISSUE: reference to a compiler-generated method
          this.ad().Add(a);
        }
        if (((XmlElement) childNode).GetElementsByTagName("postgresadmin").Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          this.u(str);
        }
        if (((XmlElement) childNode).GetElementsByTagName("cassandraadmin").Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          this.t(str);
        }
        if (this.ad(str))
        {
          // ISSUE: reference to a compiler-generated method
          this.r((XmlElement) childNode);
          // ISSUE: reference to a compiler-generated method
          this.s(str);
          // ISSUE: reference to a compiler-generated method
          this.r(A_0_1);
        }
      }
    }
  }

  public int x(string A_0)
  {
    return this.r(A_0, 0);
  }

  public int r(string A_0, int A_1)
  {
    int result;
    if (int.TryParse(this.r(A_0, A_1.ToString()), NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result))
      return result;
    return A_1;
  }

  public bool y(string A_0)
  {
    return this.r(A_0, false);
  }

  public bool r(string A_0, bool A_1)
  {
    string str;
    // ISSUE: reference to a compiler-generated method
    if (this.w().TryGetValue(A_0, out str))
      return str.ToLower() == "true";
    return A_1;
  }

  public List<string> z(string A_0)
  {
    List<string> stringList;
    // ISSUE: reference to a compiler-generated method
    if (this.y().TryGetValue(A_0, out stringList))
      return stringList;
    return (List<string>) null;
  }

  public string aa(string A_0)
  {
    List<string> stringList;
    // ISSUE: reference to a compiler-generated method
    if (this.aa().TryGetValue(A_0, out stringList))
      return stringList[0];
    return (string) null;
  }

  public List<string> ab(string A_0)
  {
    List<string> stringList;
    // ISSUE: reference to a compiler-generated method
    if (this.aa().TryGetValue(A_0, out stringList))
      return stringList;
    return (List<string>) null;
  }

  public string ac(string A_0)
  {
    return this.r(A_0, (string) null);
  }

  public string r(string A_0, string A_1)
  {
    string str;
    // ISSUE: reference to a compiler-generated method
    if (this.w().TryGetValue(A_0, out str))
      return str;
    return A_1;
  }

  public bool ad(string A_0)
  {
    if (A_0 == "127.0.0.1")
      return true;
    try
    {
      try
      {
        // ISSUE: reference to a compiler-generated method
        return ((IEnumerable<IPAddress>) this.ai()).Contains<IPAddress>(IPAddress.Parse(A_0));
      }
      catch (Exception ex)
      {
      }
      IPHostEntry hostEntry = Dns.GetHostEntry(A_0);
      if (hostEntry.AddressList.Length > 0)
      {
        // ISSUE: reference to a compiler-generated method
        return ((IEnumerable<IPAddress>) this.ai()).Contains<IPAddress>(hostEntry.AddressList[0]);
      }
    }
    catch (Exception ex)
    {
    }
    return false;
  }

  public string ae(string A_0)
  {
    if (A_0.ToLower() == "localhost" || A_0 == "127.0.0.1")
      return this.r();
    return A_0;
  }

  private string r()
  {
    string str = "";
    foreach (IPAddress address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
    {
      if (address.AddressFamily == AddressFamily.InterNetwork)
        str = address.ToString();
    }
    return str;
  }

  public class a
  {
  }
}
