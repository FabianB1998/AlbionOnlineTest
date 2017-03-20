// Decompiled with JetBrains decompiler
// Type: iy
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

public abstract class iy
{
  public iy()
  {
    // ISSUE: reference to a compiler-generated method
    this.a(new Func<string, Stream>(this.a));
  }

  public virtual Stream a(string A_0)
  {
    return (Stream) new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.Read);
  }

  protected void a(XmlReader A_0)
  {
    A_0.Read();
    if (A_0.Name != "cluster")
      return;
    ahk ahk1 = ahk.d();
    ahk A_1 = ahk.d();
    ahk ahk2 = ahk.d();
    ahk ahk3 = ahk.d();
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
            ahk1 = aim.a(A_0.Value, ahk1);
            continue;
          case "size":
            A_1 = aim.a(A_0.Value, A_1);
            continue;
          case "minimapBoundsMin":
            ahk2 = aim.a(A_0.Value, ahk2);
            continue;
          case "minimapBoundsMax":
            ahk3 = aim.a(A_0.Value, ahk3);
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
    this.a(ahk1, A_1, num1, num2, num3, ahk2, ahk3);
    this.a(A_0, "cluster", new Action<XmlReader, string>(this.b));
    this.b();
  }

  protected void b(XmlReader A_0, string A_1)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    iy.a a = new iy.a();
    // ISSUE: reference to a compiler-generated field
    a.e = this;
    switch (A_1)
    {
      case "templateinstance":
        bool isEmptyElement = A_0.IsEmptyElement;
        // ISSUE: reference to a compiler-generated field
        a.a = new HashSet<string>();
        // ISSUE: reference to a compiler-generated field
        a.b = string.Empty;
        string empty = string.Empty;
        // ISSUE: reference to a compiler-generated field
        a.c = acf.e();
        // ISSUE: reference to a compiler-generated field
        a.d = 0.0f;
        if (A_0.HasAttributes)
        {
          while (A_0.MoveToNextAttribute())
          {
            switch (A_0.Name)
            {
              case "id":
                string str = A_0.Value;
                continue;
              case "ref":
                // ISSUE: reference to a compiler-generated field
                a.b = A_0.Value;
                continue;
              case "pos":
                // ISSUE: reference to a compiler-generated field
                a.c = aim.a(A_0.Value, acf.e());
                continue;
              case "rot":
                // ISSUE: reference to a compiler-generated field
                a.d = aim.a(A_0.Value, 0.0f);
                continue;
              default:
                continue;
            }
          }
        }
        if (!isEmptyElement)
        {
          // ISSUE: reference to a compiler-generated method
          this.a(A_0, A_1, new Action<XmlReader, string>(a.f));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.a(this.c(a.b), this.a(), new Action<XmlReader>(a.f));
        break;
      default:
        this.a(A_0, A_1, (Action<XmlReader, string>) null);
        break;
    }
  }

  protected void a(XmlReader A_0, string A_1, HashSet<string> A_2, string A_3, acf A_4, float A_5)
  {
    switch (A_1)
    {
      case "activelayer":
        if (!A_0.HasAttributes)
          break;
        while (A_0.MoveToNextAttribute())
        {
          switch (A_0.Name)
          {
            case "id":
              A_2.Add(A_0.Value);
              continue;
            default:
              continue;
          }
        }
        break;
      default:
        this.a(A_0, A_1, (Action<XmlReader, string>) null);
        break;
    }
  }

  protected void a(XmlReader A_0, HashSet<string> A_1, acf A_2, float A_3)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    iy.b b = new iy.b();
    // ISSUE: reference to a compiler-generated field
    b.b = A_1;
    // ISSUE: reference to a compiler-generated field
    b.c = A_2;
    // ISSUE: reference to a compiler-generated field
    b.d = A_3;
    // ISSUE: reference to a compiler-generated field
    b.a = this;
    A_0.Read();
    if (A_0.Name != "template")
      return;
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    ahk A_4 = ahk.d();
    ahk A_5 = ahk.d();
    ahk A_6 = ahk.d();
    if (A_0.HasAttributes)
    {
      while (A_0.MoveToNextAttribute())
      {
        switch (A_0.Name)
        {
          case "path":
            empty1 = A_0.Value;
            continue;
          case "unityguid":
            empty2 = A_0.Value;
            continue;
          case "size":
            A_4 = aim.a(A_0.Value, ahk.d());
            continue;
          case "colBoundsMin":
            A_5 = aim.a(A_0.Value, ahk.d());
            continue;
          case "colBoundsMax":
            A_6 = aim.a(A_0.Value, ahk.d());
            continue;
          default:
            continue;
        }
      }
    }
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.a(b.c, b.d, empty1, empty2, A_4, A_5, A_6);
    // ISSUE: reference to a compiler-generated method
    this.a(A_0, "template", new Action<XmlReader, string>(b.e));
  }

  protected void a(XmlReader A_0, string A_1, HashSet<string> A_2, acf A_3, float A_4)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    iy.c c = new iy.c();
    // ISSUE: reference to a compiler-generated field
    c.b = A_2;
    // ISSUE: reference to a compiler-generated field
    c.c = A_3;
    // ISSUE: reference to a compiler-generated field
    c.d = A_4;
    // ISSUE: reference to a compiler-generated field
    c.a = this;
    switch (A_1)
    {
      case "tiles":
        // ISSUE: reference to a compiler-generated method
        this.a(A_0, A_1, new Action<XmlReader, string>(c.e));
        break;
      default:
        this.a(A_0, A_1, (Action<XmlReader, string>) null);
        break;
    }
  }

  protected void a(XmlReader A_0, string A_1, acf A_2, float A_3)
  {
    bool isEmptyElement = A_0.IsEmptyElement;
    string A_0_1 = "";
    acf A_1_1 = acf.e();
    acf A_1_2 = acf.e();
    acf acf = acf.a();
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
            A_1_1 = aim.a(A_0.Value, A_1_1);
            continue;
          case "rot":
            A_1_2 = aim.a(A_0.Value, A_1_2);
            continue;
          case "roty":
            A_1_2 = new acf(0.0f, aim.a(A_0.Value, 0.0f), 0.0f);
            continue;
          case "scale":
            acf = aim.a(A_0.Value, acf);
            continue;
          default:
            continue;
        }
      }
    }
    ahk ahk = abh.b(acf.d(A_2, A_1_1).o(), A_2.o(), A_3);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    acf A_1_3 = new acf(ahk.g(), A_2.l() + A_1_1.l(), ahk.h());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    acf A_2_1 = new acf(A_1_2.k(), A_3 + A_1_2.l(), A_1_2.m());
    if (!isEmptyElement)
    {
      try
      {
        A_4 = this.a(A_0, A_1);
      }
      catch (Exception ex)
      {
        ab0.a(ex);
      }
    }
    if (A_1 == "compoundtile")
      this.b(A_0_1, A_1_3, A_2_1, acf, A_4);
    else
      this.a(A_0_1, A_1_3, A_2_1, acf, A_4);
  }

  protected void b(XmlReader A_0, string A_1, HashSet<string> A_2, acf A_3, float A_4)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    iy.d d = new iy.d();
    // ISSUE: reference to a compiler-generated field
    d.b = A_2;
    // ISSUE: reference to a compiler-generated field
    d.c = A_3;
    // ISSUE: reference to a compiler-generated field
    d.d = A_4;
    // ISSUE: reference to a compiler-generated field
    d.a = this;
    switch (A_1)
    {
      case "tile":
      case "compoundtile":
      case "criticaltile":
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.a(A_0, A_1, d.c, d.d);
        break;
      case "layergroup":
        // ISSUE: reference to a compiler-generated method
        this.a(A_0, A_1, new Action<XmlReader, string>(d.e));
        break;
      default:
        this.a(A_0, A_1, (Action<XmlReader, string>) null);
        break;
    }
  }

  protected void c(XmlReader A_0, string A_1, HashSet<string> A_2, acf A_3, float A_4)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    iy.e e = new iy.e();
    // ISSUE: reference to a compiler-generated field
    e.b = A_2;
    // ISSUE: reference to a compiler-generated field
    e.c = A_3;
    // ISSUE: reference to a compiler-generated field
    e.d = A_4;
    // ISSUE: reference to a compiler-generated field
    e.a = this;
    switch (A_1)
    {
      case "layer":
        string empty = string.Empty;
        if (A_0.HasAttributes)
        {
          while (A_0.MoveToNextAttribute())
          {
            switch (A_0.Name)
            {
              case "id":
                empty = A_0.Value;
                continue;
              default:
                continue;
            }
          }
        }
        // ISSUE: reference to a compiler-generated field
        if (e.b.Contains(empty))
        {
          // ISSUE: reference to a compiler-generated method
          this.a(A_0, A_1, new Action<XmlReader, string>(e.e));
          break;
        }
        this.a(A_0, A_1, (Action<XmlReader, string>) null);
        break;
      default:
        this.a(A_0, A_1, (Action<XmlReader, string>) null);
        break;
    }
  }

  protected void a(XmlReader A_0, HashSet<string> A_1)
  {
    bool flag1 = false;
    bool flag2 = false;
    while (A_0.Read())
    {
      while (A_0.NodeType == XmlNodeType.EndElement)
      {
        flag2 = A_0.Name == "layergroup";
        if (!flag2)
          A_0.ReadEndElement();
        else
          break;
      }
      if (flag2)
        break;
      if (A_0.NodeType == XmlNodeType.Element && A_0.Name == "layer" && !flag1)
      {
        string empty = string.Empty;
        if (A_0.HasAttributes)
        {
          while (A_0.MoveToNextAttribute())
          {
            if (A_0.Name == "id")
              empty = A_0.Value;
          }
        }
        if (!string.IsNullOrEmpty(empty) && A_1.Contains(empty))
          flag1 = true;
      }
    }
  }

  protected virtual void a(acf A_0, float A_1, string A_2, string A_3, ahk A_4, ahk A_5, ahk A_6)
  {
  }

  protected virtual void a(ahk A_0, ahk A_1, float A_2, float A_3, float A_4, ahk A_5, ahk A_6)
  {
  }

  protected virtual void b()
  {
  }

  protected virtual void a(string A_0, acf A_1, acf A_2, acf A_3, Dictionary<string, Dictionary<string, string>> A_4)
  {
  }

  protected virtual void b(string A_0, acf A_1, acf A_2, acf A_3, Dictionary<string, Dictionary<string, string>> A_4)
  {
  }

  private Dictionary<string, Dictionary<string, string>> a(XmlReader A_0, string A_1)
  {
    Dictionary<string, Dictionary<string, string>> dictionary1 = new Dictionary<string, Dictionary<string, string>>();
    while (A_0.Name != A_1 && A_0.Read() && A_0.IsStartElement())
    {
      bool isEmptyElement = A_0.IsEmptyElement;
      Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
      if (!dictionary1.ContainsKey(A_0.Name))
      {
        dictionary1.Add(A_0.Name, dictionary2);
        if (A_0.HasAttributes)
        {
          while (A_0.MoveToNextAttribute())
            dictionary2.Add(A_0.Name, A_0.Value);
        }
      }
      else
        ab0.a("Duplicate ChildProperties found: " + A_0.Name);
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

  protected void a(XmlReader A_0, string A_1, Action<XmlReader, string> A_2)
  {
    if (A_0.IsEmptyElement)
      return;
    while (A_0.Read())
    {
      switch (A_0.NodeType)
      {
        case XmlNodeType.Element:
          if (A_2 != null)
          {
            try
            {
              A_2(A_0, A_0.Name);
              continue;
            }
            catch (Exception ex)
            {
              ab0.a(ex);
              continue;
            }
          }
          else
            continue;
        case XmlNodeType.EndElement:
          while (A_0.NodeType == XmlNodeType.EndElement)
          {
            if (A_0.Name == A_1)
              return;
            A_0.ReadEndElement();
          }
          continue;
        default:
          continue;
      }
    }
  }

  public abstract string b(string A_0);

  public abstract string c(string A_0);

  public void d(string A_0)
  {
    try
    {
      // ISSUE: reference to a compiler-generated method
      this.a(this.b(A_0), this.a(), new Action<XmlReader>(this.a));
    }
    catch (Exception ex)
    {
      ab0.a(ex);
    }
  }

  public void a(string A_0, Func<string, Stream> A_1, Action<XmlReader> A_2)
  {
    using (Stream input = A_1(A_0))
    {
      using (XmlReader xmlReader = XmlReader.Create(input, new XmlReaderSettings() { IgnoreWhitespace = true, IgnoreComments = true }))
      {
        try
        {
          A_2(xmlReader);
        }
        catch (Exception ex)
        {
          ab0.a(ex);
        }
        xmlReader.Close();
      }
      input.Close();
    }
  }
}
