using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
   /* public ParticleSystem particles1;
    public ParticleSystem particles2;
    public ParticleSystem particles3;
    public ParticleSystem particles4;
    public ParticleSystem particles5;
    public ParticleSystem particles6;
    public ParticleSystem particles7;
    public ParticleSystem particles8;
    public ParticleSystem particles9;
    public ParticleSystem particles10;
    public ParticleSystem particles11;
    public ParticleSystem particles12;*/
    private void OnCollisionEnter(Collision collision)
    {
        //.........................................................Alphabet collisoon...........................................
        if (collision.gameObject.CompareTag("aAlphabet"))
        {
            AlphabetsManager.a = false;
            PlayerPrefs.SetInt("A", (AlphabetsManager.a ? 1 : 0));
            /*particles1.Play();
            particles2.Play();
            particles3.Play();
            particles4.Play();
            particles5.Play();
            particles6.Play();
            particles7.Play();
            particles8.Play();
            particles9.Play();
            particles10.Play();
            particles11.Play();
            particles12.Play();*/
        }
        if (collision.gameObject.CompareTag("bAlphabet"))
        {
            AlphabetsManager.b = false;
            PlayerPrefs.SetInt("B", (AlphabetsManager.a ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("cAlphabet"))
        {
            AlphabetsManager.c = false;
            PlayerPrefs.SetInt("C", (AlphabetsManager.a ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("dAlphabet"))
        {
            AlphabetsManager.d = false;
            PlayerPrefs.SetInt("D", (AlphabetsManager.d ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("eAlphabet"))
        {
            AlphabetsManager.e = false;
            PlayerPrefs.SetInt("E", (AlphabetsManager.e ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("fAlphabet"))
        {
            AlphabetsManager.f = false;
            PlayerPrefs.SetInt("F", (AlphabetsManager.f ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("gAlphabet"))
        {
            AlphabetsManager.g = false;
            PlayerPrefs.SetInt("G", (AlphabetsManager.g ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("hAlphabet"))
        {
            AlphabetsManager.h = false;
            PlayerPrefs.SetInt("H", (AlphabetsManager.h ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("iAlphabet"))
        {
            AlphabetsManager.i = false;
            PlayerPrefs.SetInt("I", (AlphabetsManager.i ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("jAlphabet"))
        {
            AlphabetsManager.j = false;
            PlayerPrefs.SetInt("J", (AlphabetsManager.j ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("kAlphabet"))
        {
            AlphabetsManager.k = false;
            PlayerPrefs.SetInt("K", (AlphabetsManager.k ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("lAlphabet"))
        {
            AlphabetsManager.l = false;
            PlayerPrefs.SetInt("L", (AlphabetsManager.l ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("mAlphabet"))
        {
            AlphabetsManager.m = false;
            PlayerPrefs.SetInt("M", (AlphabetsManager.m ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("nAlphabet"))
        {
            AlphabetsManager.n = false;
            PlayerPrefs.SetInt("N", (AlphabetsManager.n ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("oAlphabet"))
        {
            AlphabetsManager.o = false;
            PlayerPrefs.SetInt("O", (AlphabetsManager.o ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("pAlphabet"))
        {
            AlphabetsManager.p = false;
            PlayerPrefs.SetInt("P", (AlphabetsManager.p ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("qAlphabet"))
        {
            AlphabetsManager.q = false;
            PlayerPrefs.SetInt("Q", (AlphabetsManager.q ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("rAlphabet"))
        {
            AlphabetsManager.r = false;
            PlayerPrefs.SetInt("R", (AlphabetsManager.r ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("sAlphabet"))
        {
            AlphabetsManager.s = false;
            PlayerPrefs.SetInt("S", (AlphabetsManager.s ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("tAlphabet"))
        {
            AlphabetsManager.t = false;
            PlayerPrefs.SetInt("T", (AlphabetsManager.t ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("uAlphabet"))
        {
            AlphabetsManager.u = false;
            PlayerPrefs.SetInt("U", (AlphabetsManager.u ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("vAlphabet"))
        {
            AlphabetsManager.v = false;
            PlayerPrefs.SetInt("V", (AlphabetsManager.v ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("wAlphabet"))
        {
            AlphabetsManager.w = false;
            PlayerPrefs.SetInt("W", (AlphabetsManager.w ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("xAlphabet"))
        {
            AlphabetsManager.x = false;
            PlayerPrefs.SetInt("X", (AlphabetsManager.x ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("yAlphabet"))
        {
            AlphabetsManager.y = false;
            PlayerPrefs.SetInt("Y", (AlphabetsManager.y ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("zAlphabet"))
        {
            AlphabetsManager.z = false;
            PlayerPrefs.SetInt("Z", (AlphabetsManager.z ? 1 : 0));
        }
        //.........................................................Numbers Collison...........................................
        if (collision.gameObject.CompareTag("zero"))
        {
            NumbersManager.zero = false;
            PlayerPrefs.SetInt("zero", (NumbersManager.zero ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("one"))
        {
            NumbersManager.one = false;
            PlayerPrefs.SetInt("one", (NumbersManager.one ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("two"))
        {
            NumbersManager.two = false;
            PlayerPrefs.SetInt("two", (NumbersManager.two ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("three"))
        {
            NumbersManager.three = false;
            PlayerPrefs.SetInt("three", (NumbersManager.three ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("four"))
        {
            NumbersManager.four = false;
            PlayerPrefs.SetInt("four", (NumbersManager.four ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("five"))
        {
            NumbersManager.five = false;
            PlayerPrefs.SetInt("five", (NumbersManager.five ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("six"))
        {
            NumbersManager.six = false;
            PlayerPrefs.SetInt("six", (NumbersManager.six ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("seven"))
        {
            NumbersManager.seven = false;
            PlayerPrefs.SetInt("seven", (NumbersManager.seven ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("eight"))
        {
            NumbersManager.eight = false;
            PlayerPrefs.SetInt("eight", (NumbersManager.eight ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("nine"))
        {
            NumbersManager.nine = false;
            PlayerPrefs.SetInt("nine", (NumbersManager.nine ? 1 : 0));
        }

        //.........................................................Shapes Collison...........................................
        if (collision.gameObject.CompareTag("circle"))
        {
            ShapesManager.circle = false;
            PlayerPrefs.SetInt("circle", (ShapesManager.circle ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("sqaure"))
        {
            ShapesManager.sqaure = false;
            PlayerPrefs.SetInt("sqaure", (ShapesManager.sqaure ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("rectangle"))
        {
            ShapesManager.rectangle = false;
            PlayerPrefs.SetInt("rectangle", (ShapesManager.rectangle ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("conee"))
        {
            ShapesManager.conee = false;
            PlayerPrefs.SetInt("conee", (ShapesManager.conee ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("diomand"))
        {
            ShapesManager.diomand = false;
            PlayerPrefs.SetInt("diomand", (ShapesManager.diomand ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("pentagonal"))
        {
            ShapesManager.pentagonal = false;
            PlayerPrefs.SetInt("pentagonal", (ShapesManager.pentagonal ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("hexagonal"))
        {
            ShapesManager.hexagonal = false;
            PlayerPrefs.SetInt("hexagonal", (ShapesManager.hexagonal ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("triangle"))
        {
            ShapesManager.triangle = false;
            PlayerPrefs.SetInt("triangle", (ShapesManager.triangle ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("oval"))
        {
            ShapesManager.oval = false;
            PlayerPrefs.SetInt("oval", (ShapesManager.oval ? 1 : 0));
        }

        //.........................................................Color Collison...........................................
        if (collision.gameObject.CompareTag("blue"))
        {
            ColorManager.blue = false;
            PlayerPrefs.SetInt("blue", (ColorManager.blue ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("orange"))
        {
            ColorManager.orange = false;
            PlayerPrefs.SetInt("orange", (ColorManager.orange ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("pink"))
        {
            ColorManager.pink = false;
            PlayerPrefs.SetInt("pink", (ColorManager.pink ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("green"))
        {
            ColorManager.green = false;
            PlayerPrefs.SetInt("green", (ColorManager.green ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("purple"))
        {
            ColorManager.purple = false;
            PlayerPrefs.SetInt("purple", (ColorManager.purple ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("red"))
        {
            ColorManager.red = false;
            PlayerPrefs.SetInt("red", (ColorManager.red ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("yellow"))
        {
            ColorManager.yellow = false;
            PlayerPrefs.SetInt("yellow", (ColorManager.yellow ? 1 : 0));
        }

        //.........................................................Fruit Collison...........................................
        if (collision.gameObject.CompareTag("apple"))
        {
            FruitsManager.apple = false;
            PlayerPrefs.SetInt("apple", (FruitsManager.apple ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("banana"))
        {
            FruitsManager.banana = false;
            PlayerPrefs.SetInt("banana", (FruitsManager.banana ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("grapes"))
        {
            FruitsManager.grapes = false;
            PlayerPrefs.SetInt("grapes", (FruitsManager.grapes ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("mango"))
        {
            FruitsManager.mango = false;
            PlayerPrefs.SetInt("mango", (FruitsManager.mango ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("orangefruit"))
        {
            FruitsManager.orangefruit = false;
            PlayerPrefs.SetInt("orangefruit", (FruitsManager.orangefruit ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("pineApple"))
        {
            FruitsManager.pineApple = false;
            PlayerPrefs.SetInt("pineApple", (FruitsManager.pineApple ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("waterMelon"))
        {
            FruitsManager.waterMelon = false;
            PlayerPrefs.SetInt("waterMelon", (FruitsManager.waterMelon ? 1 : 0));
        }

        //.........................................................Animal Collison...........................................
        if (collision.gameObject.CompareTag("cat"))
        {
            AnimalsManager.cat = false;
            PlayerPrefs.SetInt("cat", (AnimalsManager.cat ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("monkey"))
        {
            AnimalsManager.monkey = false;
            PlayerPrefs.SetInt("monkey", (AnimalsManager.monkey ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("fish"))
        {
            AnimalsManager.fish = false;
            PlayerPrefs.SetInt("fish", (AnimalsManager.fish ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("horse"))
        {
            AnimalsManager.horse = false;
            PlayerPrefs.SetInt("horse", (AnimalsManager.horse ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("deer"))
        {
            AnimalsManager.deer = false;
            PlayerPrefs.SetInt("deer", (AnimalsManager.deer ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("lion"))
        {
            AnimalsManager.lion = false;
            PlayerPrefs.SetInt("lion", (AnimalsManager.lion ? 1 : 0));
        }

        //.........................................................Birds Collison...........................................
        if (collision.gameObject.CompareTag("duck"))
        {
            BirdsManager.duck = false;
            PlayerPrefs.SetInt("duck", (BirdsManager.duck ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("eagle"))
        {
            BirdsManager.eagle = false;
            PlayerPrefs.SetInt("eagle", (BirdsManager.eagle ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("sparrow"))
        {
            BirdsManager.sparrow = false;
            PlayerPrefs.SetInt("sparrow", (BirdsManager.sparrow ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("parrot"))
        {
            BirdsManager.parrot = false;
            PlayerPrefs.SetInt("parrot", (BirdsManager.parrot ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("rooster"))
        {
            BirdsManager.rooster = false;
            PlayerPrefs.SetInt("rooster", (BirdsManager.rooster ? 1 : 0));
        }
        if (collision.gameObject.CompareTag("toucan"))
        {
            BirdsManager.toucan = false;
            PlayerPrefs.SetInt("toucan", (BirdsManager.toucan ? 1 : 0));
        }
    }
}
