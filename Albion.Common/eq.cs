// Decompiled with JetBrains decompiler
// Type: eq
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Xml;

public class eq
{
  public List<int> b = new List<int>();
  public Dictionary<string, kx> c = new Dictionary<string, kx>();
  public TimeSpan d = TimeSpan.FromHours(168.0);
  public TimeSpan e = TimeSpan.FromHours(720.0);
  public TimeSpan f = TimeSpan.FromHours(24.0);
  public TimeSpan g = TimeSpan.FromDays(1.0);
  public int a;

  public void k(XmlElement A_0)
  {
    foreach (XmlElement childNode in A_0.ChildNodes)
    {
      switch (childNode.Name)
      {
        case "TaxValues":
          this.j(childNode);
          continue;
        case "Settings":
          this.i(childNode);
          continue;
        case "OrderDurations":
          this.h(childNode);
          continue;
        default:
          continue;
      }
    }
  }

  private void j(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      if (childNode.Name == "TaxFactor")
      {
        string key = aim.a(childNode as XmlElement, "name", "");
        kx kx = aim.c(childNode as XmlElement, "value", kx.g);
        if (!string.IsNullOrEmpty(key))
          this.c.Add(key, kx);
      }
      else if (childNode.Name == "AbsoluteTax")
      {
        string key = aim.a(childNode as XmlElement, "name", "");
        kx kx = aim.b(childNode as XmlElement, "value", kx.g);
        if (!string.IsNullOrEmpty(key))
          this.c.Add(key, kx);
      }
    }
  }

  private void i(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      if (childNode.Name == "Entry")
      {
        switch (aim.a(childNode as XmlElement, "name", ""))
        {
          case "autotradeinterval":
            int num1 = aim.b(childNode as XmlElement, "value", -1);
            if (num1 != -1)
            {
              this.g = TimeSpan.FromMinutes((double) num1);
              continue;
            }
            continue;
          case "defaultexpiration":
            int num2 = aim.b(childNode as XmlElement, "value", -1);
            if (num2 != -1)
            {
              this.d = TimeSpan.FromHours((double) num2);
              continue;
            }
            continue;
          case "finishedexpiration":
            int num3 = aim.b(childNode as XmlElement, "value", -1);
            if (num3 != -1)
            {
              this.e = TimeSpan.FromHours((double) num3);
              continue;
            }
            continue;
          case "maxbuyordercount":
            this.a = aim.b(childNode as XmlElement, "value", 9999);
            continue;
          default:
            continue;
        }
      }
    }
  }

  private void h(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      if (childNode.Name == "Entry")
      {
        int num = aim.b(childNode as XmlElement, "durationInHrs", -1);
        if (num != -1)
          this.b.Add(num);
      }
    }
    this.b.Sort();
  }
}
