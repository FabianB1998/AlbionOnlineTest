// Decompiled with JetBrains decompiler
// Type: iu
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

public class iu
{
  public void u(string A_0)
  {
    FileStream fileStream = new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.Read);
    this.m((Stream) fileStream);
    fileStream.Close();
    fileStream.Dispose();
  }

  public void v(string A_0)
  {
    StringReader stringReader = new StringReader(A_0);
    this.n(XmlReader.Create((TextReader) stringReader));
    stringReader.Dispose();
  }

  public void m(Stream A_0)
  {
    this.n(XmlReader.Create(A_0));
  }

  protected void n(XmlReader A_0)
  {
    A_0.Read();
    if (A_0.Name != "cluster")
      return;
    ahk ahk = ahk.d();
    ahk A_1_1 = ahk.d();
    string empty = string.Empty;
    float num1 = 0.05f;
    float num2 = 0.01f;
    float num3 = 0.4f;
    if (A_0.HasAttributes)
    {
      while (A_0.MoveToNextAttribute())
      {
        switch (A_0.Name)
        {
          case "origin":
            ahk = aim.a(A_0.Value, ahk);
            continue;
          case "size":
            A_1_1 = aim.a(A_0.Value, A_1_1);
            continue;
          case "categoryname":
            string str = A_0.Value;
            continue;
          case "oceanflow":
            num1 = aim.a(A_0.Value, num1);
            continue;
          case "oceanflowspeed":
            num2 = aim.a(A_0.Value, num2);
            continue;
          case "oceananimspeed":
            num3 = aim.a(A_0.Value, num3);
            continue;
          default:
            continue;
        }
      }
    }
    this.c5(ahk, A_1_1, num1, num2, num3);
    while (A_0.Read())
    {
      if (A_0.IsStartElement())
      {
        string name = A_0.Name;
        if (name == "tile" || name == "compoundtile")
        {
          bool isEmptyElement = A_0.IsEmptyElement;
          string A_0_1 = "";
          acf A_1_2 = acf.e();
          acf acf1 = acf.e();
          acf acf2 = acf.a();
          Dictionary<string, Dictionary<string, string>> A_4 = (Dictionary<string, Dictionary<string, string>>) null;
          if (A_0.HasAttributes)
          {
            while (A_0.MoveToNextAttribute())
            {
              switch (A_0.Name)
              {
                case "name":
                  A_0_1 = A_0.Value;
                  continue;
                case "pos":
                  A_1_2 = aim.a(A_0.Value, A_1_2);
                  continue;
                case "rot":
                  acf1 = aim.a(A_0.Value, acf1);
                  continue;
                case "roty":
                  acf1 = new acf(0.0f, aim.a(A_0.Value, 0.0f), 0.0f);
                  continue;
                case "scale":
                  acf2 = aim.a(A_0.Value, acf2);
                  continue;
                default:
                  continue;
              }
            }
          }
          if (!isEmptyElement)
          {
            try
            {
              A_4 = this.m(A_0);
            }
            catch (Exception ex)
            {
              ab0.a(ex);
            }
          }
          if (name == "tile")
            this.cs(A_0_1, A_1_2, acf1, acf2, A_4);
          else
            this.ct(A_0_1, A_1_2, acf1, acf2, A_4);
        }
        else
          A_0.Skip();
      }
      else
        A_0.ReadEndElement();
    }
    this.cu();
  }

  protected virtual void c5(ahk A_0, ahk A_1, float A_2, float A_3, float A_4)
  {
  }

  protected virtual void cu()
  {
  }

  private Dictionary<string, Dictionary<string, string>> m(XmlReader A_0)
  {
    Dictionary<string, Dictionary<string, string>> dictionary1 = new Dictionary<string, Dictionary<string, string>>();
    while (A_0.Read() && A_0.IsStartElement())
    {
      bool isEmptyElement = A_0.IsEmptyElement;
      Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
      dictionary1.Add(A_0.Name, dictionary2);
      if (A_0.HasAttributes)
      {
        while (A_0.MoveToNextAttribute())
          dictionary2.Add(A_0.Name, A_0.Value);
      }
      if (!isEmptyElement)
      {
        A_0.Read();
        StringBuilder stringBuilder = new StringBuilder();
        while (A_0.IsStartElement())
          stringBuilder.Append(A_0.ReadOuterXml());
        if (stringBuilder.Length > 0)
          dictionary2.Add("innerxml", stringBuilder.ToString());
        A_0.ReadEndElement();
      }
    }
    return dictionary1;
  }

  protected virtual void cs(string A_0, acf A_1, acf A_2, acf A_3, Dictionary<string, Dictionary<string, string>> A_4)
  {
  }

  protected virtual void ct(string A_0, acf A_1, acf A_2, acf A_3, Dictionary<string, Dictionary<string, string>> A_4)
  {
  }
}
