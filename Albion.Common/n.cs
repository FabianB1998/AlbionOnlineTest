// Decompiled with JetBrains decompiler
// Type: n
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Schema;

public abstract class n
{
  protected n()
  {
    // ISSUE: reference to a compiler-generated method
    this.hz(new ValidationEventHandler(n.hz));
  }

  private static void hz(object A_0, ValidationEventArgs A_1)
  {
    if (A_1.Severity == XmlSeverityType.Warning || A_1.Severity != XmlSeverityType.Error)
      return;
    ab0.a(A_1.Message);
  }

  public bool h8(string A_0)
  {
    return this.h0(A_0, false);
  }

  public bool h0(string A_0, bool A_1)
  {
    return this.hz(A_0, (string) null, A_1);
  }

  public bool h0(string A_0, string A_1)
  {
    return this.hz(A_0, A_1, false);
  }

  public bool hz(string A_0, string A_1, bool A_2)
  {
    bool flag = File.Exists(A_0);
    if (!flag)
      Console.WriteLine("ERROR: File Not Found: " + A_0);
    if (!flag)
      return false;
    using (StreamReader streamReader = new StreamReader(A_0))
      return this.h0(streamReader.ReadToEnd(), A_1, A_2);
  }

  public bool h9(string A_0)
  {
    return this.h0(A_0, (string) null, false);
  }

  public bool h1(string A_0, bool A_1)
  {
    return this.h0(A_0, (string) null, A_1);
  }

  public bool h0(string A_0, string A_1, bool A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.hz(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(A_0)));
    if ((int) A_0[0] == 65279)
      A_0 = A_0.Substring(1);
    XmlDocument xmlDocument = new XmlDocument();
    try
    {
      xmlDocument.LoadXml(A_0);
    }
    catch (XmlException ex)
    {
      throw new AlbionException("Unable to parse XML", (Exception) ex);
    }
    if (!string.IsNullOrEmpty(A_1))
    {
      xmlDocument.Schemas.Add("", A_1);
      // ISSUE: reference to a compiler-generated method
      xmlDocument.Validate(this.j1());
    }
    if (A_2)
      return this.bu(xmlDocument.DocumentElement);
    return this.aq(xmlDocument.DocumentElement);
  }

  protected abstract bool aq(XmlElement A_0);

  protected virtual bool bu(XmlElement A_0)
  {
    return true;
  }
}
