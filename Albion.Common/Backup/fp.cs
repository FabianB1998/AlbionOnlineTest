// Decompiled with JetBrains decompiler
// Type: fp
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Xml;

public abstract class fp : fm
{
  public fp()
  {
    // ISSUE: reference to a compiler-generated method
    this.r(new List<fm>());
  }

  public override void co(XmlElement A_0)
  {
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        fm fm;
        switch (A_0_1.Name.ToLower())
        {
          case "and":
            fm = (fm) new fq();
            break;
          case "or":
            fm = (fm) new fr();
            break;
          case "not":
            fm = (fm) new fs();
            break;
          case "ifchance":
            fm = (fm) new ft();
            break;
          case "ifownhealthbelow":
            fm = (fm) new fu();
            break;
          case "ownhealthabove":
            fm = (fm) new fv();
            break;
          case "ownhealthbelowpercentage":
            fm = (fm) new fw();
            break;
          case "ownhealthabovepercentage":
            fm = (fm) new fx();
            break;
          case "ifownenergybelow":
            fm = (fm) new fy();
            break;
          case "ifownenergyabove":
            fm = (fm) new fz();
            break;
          case "ifownenergyabovepercentage":
            fm = (fm) new f0();
            break;
          case "ifownenergybelowpercentage":
            fm = (fm) new f1();
            break;
          case "iftargethealthbelow":
            fm = (fm) new f2();
            break;
          case "iftargethealthabove":
            fm = (fm) new f3();
            break;
          case "iftargethealthabovepercentage":
            fm = (fm) new f4();
            break;
          case "iftargethealthbelowpercentage":
            fm = (fm) new f5();
            break;
          case "iftargetenergybelow":
            fm = (fm) new f6();
            break;
          case "iftargetenergyabove":
            fm = (fm) new f7();
            break;
          case "iftargetenergyabovepercentage":
            fm = (fm) new f8();
            break;
          case "iftargetenergybelowpercentage":
            fm = (fm) new f9();
            break;
          case "ifspellactive":
            fm = (fm) new gc();
            break;
          case "iftargetmobcategory":
            fm = (fm) new ge();
            break;
          case "ifspellcategoryactive":
            fm = (fm) new gd();
            break;
          case "iftargetweaponequipped":
            fm = (fm) new gf();
            break;
          case "iftargetweapontypeequipped":
            fm = (fm) new gg();
            break;
          case "iftargettookdamage":
            fm = (fm) new gh();
            break;
          case "ifistargetcasting":
            fm = (fm) new gi();
            break;
          case "ifistargetchanneling":
            fm = (fm) new gj();
            break;
          case "iftargettype":
            fm = (fm) new gk();
            break;
          case "ifownloadpercentisbelow":
            fm = (fm) new ga();
            break;
          case "ifownloadpercentisabove":
            fm = (fm) new gb();
            break;
          default:
            continue;
        }
        fm.co(A_0_1);
        // ISSUE: reference to a compiler-generated method
        this.r().Add(fm);
      }
    }
  }
}
