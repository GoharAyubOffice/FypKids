using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetsManager : MonoBehaviour
{
     public static bool a = false;
     public static bool b = false;
     public static bool c = false;
     public static bool d = false;
     public static bool e = false;
     public static bool f = false;
     public static bool g = false;
     public static bool h = false;
     public static bool i = false;
     public static bool j = false;
     public static bool k = false;
     public static bool l = false;
     public static bool m = false;
     public static bool n = false;
     public static bool o = false;
     public static bool p = false;
     public static bool q = false;
     public static bool r = false;
     public static bool s = false;
     public static bool t = false;
     public static bool u = false;
     public static bool v = false;
     public static bool w = false;
     public static bool x = false;
     public static bool y = false;
     public static bool z = false;

    private void Start()
    {
        a = (PlayerPrefs.GetInt("A") != 0);
        b = (PlayerPrefs.GetInt("B") != 0);
        c = (PlayerPrefs.GetInt("C") != 0);
        d = (PlayerPrefs.GetInt("D") != 0);
        e = (PlayerPrefs.GetInt("E") != 0);
        f = (PlayerPrefs.GetInt("F") != 0);
        g = (PlayerPrefs.GetInt("G") != 0);
        h = (PlayerPrefs.GetInt("H") != 0);
        i = (PlayerPrefs.GetInt("I") != 0);
        j = (PlayerPrefs.GetInt("J") != 0);
        k = (PlayerPrefs.GetInt("K") != 0);
        l = (PlayerPrefs.GetInt("L") != 0);
        m = (PlayerPrefs.GetInt("M") != 0);
        n = (PlayerPrefs.GetInt("N") != 0);
        o = (PlayerPrefs.GetInt("O") != 0);
        p = (PlayerPrefs.GetInt("P") != 0);
        q = (PlayerPrefs.GetInt("Q") != 0);
        r = (PlayerPrefs.GetInt("R") != 0);
        s = (PlayerPrefs.GetInt("S") != 0);
        t = (PlayerPrefs.GetInt("T") != 0);
        u = (PlayerPrefs.GetInt("U") != 0);
        v = (PlayerPrefs.GetInt("V") != 0);
        w = (PlayerPrefs.GetInt("W") != 0);
        x = (PlayerPrefs.GetInt("X") != 0);
        y = (PlayerPrefs.GetInt("Y") != 0);
        z = (PlayerPrefs.GetInt("Z") != 0);
    }
    public void FalseBool()
    {
        a = false;
        PlayerPrefs.SetInt("A", (a ? 1 : 0));

        b = false;
        PlayerPrefs.SetInt("B", (b ? 1 : 0));

        c = false;
        PlayerPrefs.SetInt("C", (c ? 1 : 0));

        d = false;
        PlayerPrefs.SetInt("D", (d ? 1 : 0));

        e = false;
        PlayerPrefs.SetInt("E", (e ? 1 : 0));

        f = false;
        PlayerPrefs.SetInt("F", (f ? 1 : 0));

        g = false;
        PlayerPrefs.SetInt("G", (g ? 1 : 0));

        h = false;
        PlayerPrefs.SetInt("H", (h ? 1 : 0));

        i = false;
        PlayerPrefs.SetInt("I", (i ? 1 : 0));

        j = false;
        PlayerPrefs.SetInt("J", (j ? 1 : 0));

        k = false;
        PlayerPrefs.SetInt("K", (k ? 1 : 0));

        l = false;
        PlayerPrefs.SetInt("L", (l ? 1 : 0));

        m = false;
        PlayerPrefs.SetInt("M", (m ? 1 : 0));

        n = false;
        PlayerPrefs.SetInt("N", (n ? 1 : 0));

        o = false;
        PlayerPrefs.SetInt("O", (o ? 1 : 0));

        p = false;
        PlayerPrefs.SetInt("P", (p ? 1 : 0));

        q = false;
        PlayerPrefs.SetInt("Q", (q ? 1 : 0));

        r = false;
        PlayerPrefs.SetInt("R", (r ? 1 : 0));

        s = false;
        PlayerPrefs.SetInt("S", (s ? 1 : 0));

        t = false;
        PlayerPrefs.SetInt("T", (t ? 1 : 0));

        u = false;
        PlayerPrefs.SetInt("U", (u ? 1 : 0));

        v = false;
        PlayerPrefs.SetInt("V", (v ? 1 : 0));

        w = false;
        PlayerPrefs.SetInt("W", (w ? 1 : 0));

        x = false;
        PlayerPrefs.SetInt("X", (x ? 1 : 0));

        y = false;
        PlayerPrefs.SetInt("Y", (y ? 1 : 0));

        z = false;
        PlayerPrefs.SetInt("Z", (z ? 1 : 0));

    }
    public static void DeleteAlphabetBool()
    {
        PlayerPrefs.DeleteKey("A");
        PlayerPrefs.DeleteKey("B");
        PlayerPrefs.DeleteKey("C");
        PlayerPrefs.DeleteKey("D");
        PlayerPrefs.DeleteKey("E");
        PlayerPrefs.DeleteKey("F");
        PlayerPrefs.DeleteKey("G");
        PlayerPrefs.DeleteKey("H");
        PlayerPrefs.DeleteKey("I");
        PlayerPrefs.DeleteKey("J");
        PlayerPrefs.DeleteKey("K");
        PlayerPrefs.DeleteKey("L");
        PlayerPrefs.DeleteKey("M");
        PlayerPrefs.DeleteKey("N");
        PlayerPrefs.DeleteKey("O");
        PlayerPrefs.DeleteKey("P");
        PlayerPrefs.DeleteKey("Q");
        PlayerPrefs.DeleteKey("R");
        PlayerPrefs.DeleteKey("S");
        PlayerPrefs.DeleteKey("T");
        PlayerPrefs.DeleteKey("U");
        PlayerPrefs.DeleteKey("V");
        PlayerPrefs.DeleteKey("W");
        PlayerPrefs.DeleteKey("X");
        PlayerPrefs.DeleteKey("Y");
        PlayerPrefs.DeleteKey("Z");
    }
    public void A()
    { 
        if (a)
        {
            a = false;
            PlayerPrefs.SetInt("A", (a ? 1 : 0));
        }
        else
        {
            a = true;
            PlayerPrefs.SetInt("A", (a ? 1 : 0));
        }
    }
    public void B()
    {
        if (b)
        {
            b = false;
            PlayerPrefs.SetInt("B", (b ? 1 : 0));
        }
        else
        {
            b = true;
            PlayerPrefs.SetInt("B", (b ? 1 : 0));

        }
    }
    public void C()
    {
        if (c)
        {
            c = false;
            PlayerPrefs.SetInt("C", (c ? 1 : 0));
        }
        else
        {
            c = true;
            PlayerPrefs.SetInt("C", (c ? 1 : 0));

        }
    }
    public void D()
    {
        if (d)
        {
            d = false;
            PlayerPrefs.SetInt("D", (d ? 1 : 0));
        }
        else
        {
            d = true;
            PlayerPrefs.SetInt("D", (d ? 1 : 0));

        }
    }
    public void E()
    {
        if (e)
        {
            e = false;
            PlayerPrefs.SetInt("E", (e ? 1 : 0));
        }
        else
        {
            e = true;
            PlayerPrefs.SetInt("E", (e ? 1 : 0));

        }
    }
    public void F()
    {
        if (f)
        {
            f = false;
            PlayerPrefs.SetInt("F", (f ? 1 : 0));
        }
        else
        {
            f = true;
            PlayerPrefs.SetInt("F", (f ? 1 : 0));

        }
    }
    public void G()
    {
        if (g)
        {
            g = false;
            PlayerPrefs.SetInt("G", (g ? 1 : 0));
        }
        else
        {
            g = true;
            PlayerPrefs.SetInt("G", (g ? 1 : 0));

        }
    }
    public void H()
    {
        if (h)
        {
            h = false;
            PlayerPrefs.SetInt("H", (h ? 1 : 0));
        }
        else
        {
            h = true;
            PlayerPrefs.SetInt("H", (h ? 1 : 0));

        }
    }
    public void I()
    {
        if (i)
        {
            i = false;
            PlayerPrefs.SetInt("I", (i ? 1 : 0));
        }
        else
        {
            i = true;
            PlayerPrefs.SetInt("I", (i ? 1 : 0));

        }
    }
    public void J()
    {
        if (j)
        {
            j = false;
            PlayerPrefs.SetInt("J", (j ? 1 : 0));
        }
        else
        {
            j = true;
            PlayerPrefs.SetInt("J", (j ? 1 : 0));

        }
    }
    public void K()
    {
        if (k)
        {
            k = false;
            PlayerPrefs.SetInt("K", (k ? 1 : 0));
        }
        else
        {
            k = true;
            PlayerPrefs.SetInt("K", (k ? 1 : 0));

        }
    }
    public void L()
    {
        if (l)
        {
            l = false;
            PlayerPrefs.SetInt("L", (l ? 1 : 0));
        }
        else
        {
            l = true;
            PlayerPrefs.SetInt("L", (l ? 1 : 0));

        }
    }
    public void M()
    {
        if (m)
        {
            m = false;
            PlayerPrefs.SetInt("M", (m ? 1 : 0));
        }
        else
        {
            m = true;
            PlayerPrefs.SetInt("M", (m ? 1 : 0));

        }
    }
    public void N()
    {
        if (n)
        {
            n = false;
            PlayerPrefs.SetInt("N", (n ? 1 : 0));
        }
        else
        {
            n = true;
            PlayerPrefs.SetInt("N", (n ? 1 : 0));

        }
    }
    public void O()
    {
        if (o)
        {
            o = false;
            PlayerPrefs.SetInt("O", (o ? 1 : 0));
        }
        else
        {
            o = true;
            PlayerPrefs.SetInt("O", (o ? 1 : 0));

        }
    }
    public void P()
    {
        if (p)
        {
            p = false;
            PlayerPrefs.SetInt("P", (p ? 1 : 0));
        }
        else
        {
            p = true;
            PlayerPrefs.SetInt("P", (p ? 1 : 0));

        }
    }
    public void Q()
    {
        if (q)
        {
            q = false;
            PlayerPrefs.SetInt("Q", (q ? 1 : 0));
        }
        else
        {
            q = true;
            PlayerPrefs.SetInt("Q", (q ? 1 : 0));

        }
    }
    public void R()
    {
        if (r)
        {
            r = false;
            PlayerPrefs.SetInt("R", (r ? 1 : 0));
        }
        else
        {
            r = true;
            PlayerPrefs.SetInt("R", (r ? 1 : 0));

        }
    }
    public void S()
    {
        if (s)
        {
            s = false;
            PlayerPrefs.SetInt("S", (s ? 1 : 0));
        }
        else
        {
            s = true;
            PlayerPrefs.SetInt("S", (s ? 1 : 0));

        }
    }
    public void T()
    {
        if (t)
        {
            t = false;
            PlayerPrefs.SetInt("T", (t ? 1 : 0));
        }
        else
        {
            t = true;
            PlayerPrefs.SetInt("T", (t ? 1 : 0));

        }
    }
    public void U()
    {
        if (u)
        {
            u = false;
            PlayerPrefs.SetInt("U", (u ? 1 : 0));
        }
        else
        {
            u = true;
            PlayerPrefs.SetInt("U", (u ? 1 : 0));

        }
    }
    public void V()
    {
        if (v)
        {
            v = false;
            PlayerPrefs.SetInt("V", (v ? 1 : 0));
        }
        else
        {
            v = true;
            PlayerPrefs.SetInt("V", (v ? 1 : 0));

        }
    }
    public void W()
    {
        if (w)
        {
            w = false;
            PlayerPrefs.SetInt("W", (w ? 1 : 0));
        }
        else
        {
            w = true;
            PlayerPrefs.SetInt("W", (w ? 1 : 0));

        }
    }
    public void X()
    {
        if (x)
        {
            x = false;
            PlayerPrefs.SetInt("X", (x ? 1 : 0));
        }
        else
        {
            x = true;
            PlayerPrefs.SetInt("X", (x ? 1 : 0));

        }
    }
    public void Y()
    {
        if (y)
        {
            y = false;
            PlayerPrefs.SetInt("Y", (y ? 1 : 0));
        }
        else
        {
            y = true;
            PlayerPrefs.SetInt("Y", (y ? 1 : 0));

        }
    }
    public void Z()
    {
        if (z)
        {
            z = false;
            PlayerPrefs.SetInt("Z", (z ? 1 : 0));
        }
        else
        {
            z = true;
            PlayerPrefs.SetInt("Z", (z ? 1 : 0));

        }
    }
}
