// Decompiled with JetBrains decompiler
// Type: kq
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

public class kq
{
  private readonly Dictionary<string, acb> a = new Dictionary<string, acb>();
  private readonly Dictionary<string, kc> b = new Dictionary<string, kc>();

  [SpecialName]
  public int b()
  {
    return this.a.Count;
  }

  public acb b(string A_0)
  {
    acb acb;
    if (this.a.TryGetValue(A_0, out acb))
      return acb;
    return (acb) null;
  }

  public kc c(string A_0)
  {
    kc kc;
    if (this.b.TryGetValue(A_0, out kc))
      return kc;
    return (kc) null;
  }

  public void d(string A_0)
  {
    this.e(XmlReader.Create((TextReader) new StreamReader(A_0)));
  }

  public void e(string A_0)
  {
    this.e(XmlReader.Create((TextReader) new StringReader(A_0)));
  }

  public void e(XmlReader A_0)
  {
    while (A_0.Read())
    {
      if (A_0.NodeType == XmlNodeType.Element && A_0.Depth == 1)
      {
        if (A_0.Name == "tile")
        {
          acb acb = this.d(A_0);
          if (acb != null)
          {
            // ISSUE: reference to a compiler-generated method
            this.a.Add(acb.s(), acb);
          }
        }
        else if (A_0.Name == "compoundtile")
        {
          kc kc = this.b(A_0);
          if (kc != null)
          {
            // ISSUE: reference to a compiler-generated method
            this.b.Add(kc.c(), kc);
          }
        }
      }
    }
  }

  private acb d(XmlReader A_0)
  {
    bool isEmptyElement = A_0.IsEmptyElement;
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    int num1 = 0;
    int num2 = 0;
    ahk ahk = ahk.d();
    bool A_5 = true;
    string A_6 = acb.TileType.Ground.ToString();
    string A_7 = acb.TileGroundType.Normal.ToString();
    string empty3 = string.Empty;
    byte[] A_9 = (byte[]) null;
    float[] A_10 = (float[]) null;
    byte[] A_11 = (byte[]) null;
    while (A_0.MoveToNextAttribute())
    {
      switch (A_0.Name)
      {
        case "name":
          empty1 = A_0.Value;
          continue;
        case "prefab":
          empty2 = A_0.Value;
          continue;
        case "width":
          num1 = aim.a(A_0.Value, num1);
          continue;
        case "height":
          num2 = aim.a(A_0.Value, num2);
          continue;
        case "offset":
          ahk = aim.a(A_0.Value, ahk);
          continue;
        case "rotationallowed":
          A_5 = aim.a(A_0.Value);
          continue;
        case "type":
          A_6 = A_0.Value;
          continue;
        case "groundtype":
          A_7 = A_0.Value;
          continue;
        case "materialtype":
          empty3 = A_0.Value;
          continue;
        case "collision":
          A_9 = Convert.FromBase64String(A_0.Value);
          continue;
        case "heights":
          byte[] numArray = Convert.FromBase64String(A_0.Value);
          A_10 = new float[numArray.Length / 4];
          System.Buffer.BlockCopy((Array) numArray, 0, (Array) A_10, 0, numArray.Length);
          continue;
        case "effects":
          A_11 = Convert.FromBase64String(A_0.Value);
          continue;
        default:
          continue;
      }
    }
    acb acb = new acb(empty1, empty2, num1, num2, ahk, A_5, A_6, A_7, empty3, A_9, A_10, A_11);
    if (isEmptyElement)
      return acb;
    while (A_0.Read())
    {
      switch (A_0.NodeType)
      {
        case XmlNodeType.Element:
          if (A_0.Depth == 2)
          {
            string name = A_0.Name;
            while (A_0.MoveToNextAttribute())
              acb.o(name, A_0.Name, A_0.Value);
            continue;
          }
          continue;
        case XmlNodeType.EndElement:
          if (A_0.Depth == 1 && A_0.Name == "tile")
            return acb;
          continue;
        default:
          continue;
      }
    }
    return acb;
  }

  private Dictionary<string, Dictionary<string, string>> c(XmlReader A_0)
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

  private kc b(XmlReader A_0)
  {
    bool isEmptyElement1 = A_0.IsEmptyElement;
    string empty1 = string.Empty;
    while (A_0.MoveToNextAttribute())
    {
      switch (A_0.Name)
      {
        case "name":
          empty1 = A_0.Value;
          continue;
        default:
          continue;
      }
    }
    if (isEmptyElement1)
      return new kc(empty1, new kc.a[0]);
    List<kc.a> aList = new List<kc.a>();
    while (A_0.Read())
    {
      switch (A_0.NodeType)
      {
        case XmlNodeType.Element:
          if (A_0.Depth == 2 && !(A_0.Name != "tile"))
          {
            bool isEmptyElement2 = A_0.IsEmptyElement;
            string empty2 = string.Empty;
            acf A_1 = acf.e();
            acf acf1 = acf.e();
            acf acf2 = acf.a();
            while (A_0.MoveToNextAttribute())
            {
              switch (A_0.Name)
              {
                case "name":
                  empty2 = A_0.Value;
                  continue;
                case "pos":
                  A_1 = aim.a(A_0.Value, A_1);
                  continue;
                case "rot":
                  acf1 = aim.a(A_0.Value, acf1);
                  continue;
                case "roty":
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  acf1.b(aim.a(A_0.Value, acf1.l()));
                  continue;
                case "scale":
                  acf2 = aim.a(A_0.Value, acf2);
                  continue;
                default:
                  continue;
              }
            }
            Dictionary<string, Dictionary<string, string>> A_4 = (Dictionary<string, Dictionary<string, string>>) null;
            if (!isEmptyElement2)
              A_4 = this.c(A_0);
            aList.Add(new kc.a(empty2, A_1, acf1, acf2, A_4));
            continue;
          }
          continue;
        case XmlNodeType.EndElement:
          if (A_0.Depth == 1 && A_0.Name == "compoundtile")
            return new kc(empty1, aList.ToArray());
          continue;
        default:
          continue;
      }
    }
    return new kc(empty1, aList.ToArray());
  }
}
