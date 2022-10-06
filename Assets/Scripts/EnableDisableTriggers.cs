using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableTriggers : MonoBehaviour
{
    [Header("Alphabets Colliders")]
    public GameObject alphabetsToenable;
    public GameObject alphabetsManagerToEnable;
    public GameObject alphabetsManagerSoundToEnable;
    
    [SerializeField] Collider a;
    [SerializeField] Collider b;
    [SerializeField] Collider c;
    [SerializeField] Collider d;
    [SerializeField] Collider e;
    [SerializeField] Collider f;
    [SerializeField] Collider g;
    [SerializeField] Collider h;
    [SerializeField] Collider i;
    [SerializeField] Collider j;
    [SerializeField] Collider k;
    [SerializeField] Collider l;
    [SerializeField] Collider m;
    [SerializeField] Collider n;
    [SerializeField] Collider o;
    [SerializeField] Collider p;
    [SerializeField] Collider q;
    [SerializeField] Collider r;
    [SerializeField] Collider s;
    [SerializeField] Collider t;
    [SerializeField] Collider u;
    [SerializeField] Collider v;
    [SerializeField] Collider w;
    [SerializeField] Collider x;
    [SerializeField] Collider y;
    [SerializeField] Collider z;

    [Header("Numbers Colliders")]
    public GameObject numbersToEnable;
    public GameObject numbersManagerToEnable;
    public GameObject numbersManagerSoundToEnable;

    [SerializeField] Collider zero;
    [SerializeField] Collider one;
    [SerializeField] Collider two;
    [SerializeField] Collider three;
    [SerializeField] Collider four;
    [SerializeField] Collider five;
    [SerializeField] Collider six;
    [SerializeField] Collider seven;
    [SerializeField] Collider eight;
    [SerializeField] Collider nine;

    [Header("Shapes Colliders")]

    public GameObject shapesToEnable;
    public GameObject shapesManagerToEnable;
    public GameObject shapesManagerSoundToEnable;

    [SerializeField] Collider circle;
    [SerializeField] Collider square;
    [SerializeField] Collider triangle;
    [SerializeField] Collider rectangle;
    [SerializeField] Collider conee;
    [SerializeField] Collider diomand;
    [SerializeField] Collider pentagonal;
    [SerializeField] Collider hexagonal;
    [SerializeField] Collider oval;

    [Header("Color Colliders")]

    public GameObject colorToEnable;
    public GameObject colorManagerToEnable;
    public GameObject colorManagerSoundToEnable;

    [SerializeField] Collider green;
    [SerializeField] Collider pink;
    [SerializeField] Collider orange;
    [SerializeField] Collider red;
    [SerializeField] Collider yellow;
    [SerializeField] Collider blue;
    [SerializeField] Collider purple;

    [Header("Fruit Colliders")]

    public GameObject fruitToEnable;
    public GameObject fruitManagerToEnable;
    public GameObject fruitManagerSoundToEnable;

    [SerializeField] Collider apple;
    [SerializeField] Collider mango;
    [SerializeField] Collider banana;
    [SerializeField] Collider grapes;
    [SerializeField] Collider orangeFruit;
    [SerializeField] Collider waterMelon;
    [SerializeField] Collider PineApple;

    [Header("Animal Colliders")]

    public GameObject animalToEnable;
    public GameObject animalManagerToEnable;
    public GameObject animalManagerSoundToEnable;

    [SerializeField] Collider cat;
    [SerializeField] Collider monkey;
    [SerializeField] Collider fish;
    [SerializeField] Collider horse;
    [SerializeField] Collider deer;
    [SerializeField] Collider lion;

    [Header("Birds Colliders")]

    public GameObject birdsToEnable;
    public GameObject birdsManagerToEnable;
    public GameObject birdsManagerSoundToEnable;

    [SerializeField] Collider duck;
    [SerializeField] Collider eagle;
    [SerializeField] Collider sparrow;
    [SerializeField] Collider parrot;
    [SerializeField] Collider rooster;
    [SerializeField] Collider toucan;
    void Start()
    {
        //........................................Alphabets Colliders................................
        GameManager.alphabetGameOject = (PlayerPrefs.GetInt("EnableAlphabets") != 0);
        if (GameManager.alphabetGameOject == true)
        {
            alphabetsToenable.SetActive(true);
            alphabetsManagerToEnable.SetActive(true);
            alphabetsManagerSoundToEnable.SetActive(true);
        }

        if (AlphabetsManager.a == true)
        {
            a.enabled = true;
        }
        if (AlphabetsManager.b == true)
        {
            b.enabled = true;
        }
        if (AlphabetsManager.c == true)
        {
            c.enabled = true;
        }
        if (AlphabetsManager.d == true)
        {
            d.enabled = true;
        }
        if (AlphabetsManager.e == true)
        {
            e.enabled = true;
        }
        if (AlphabetsManager.f == true)
        {
            f.enabled = true;
        }
        if (AlphabetsManager.g == true)
        {
            g.enabled = true;
        }
        if (AlphabetsManager.h == true)
        {
            h.enabled = true;
        }
        
        if (AlphabetsManager.i == true)
        {
            i.enabled = true;
        }
        if (AlphabetsManager.j == true)
        {
            j.enabled = true;
        }
        if (AlphabetsManager.k == true)
        {
            k.enabled = true;
        }
        if (AlphabetsManager.l == true)
        {
            l.enabled = true;
        }
        if (AlphabetsManager.m == true)
        {
            m.enabled = true;
        }
        if (AlphabetsManager.n == true)
        {
            n.enabled = true;
        }
        if (AlphabetsManager.o == true)
        {
            o.enabled = true;
        }
        if (AlphabetsManager.p == true)
        {
            p.enabled = true;
        }
        if (AlphabetsManager.q == true)
        {
            q.enabled = true;
        }
        if (AlphabetsManager.r == true)
        {
            r.enabled = true;
        }
        if (AlphabetsManager.s == true)
        {
            s.enabled = true;
        }
        if (AlphabetsManager.t == true)
        {
            t.enabled = true;
        }
        if (AlphabetsManager.u == true)
        {
            u.enabled = true;
        }
        if (AlphabetsManager.v == true)
        {
            v.enabled = true;
        }
        if (AlphabetsManager.w == true)
        {
            w.enabled = true;
        }
        if (AlphabetsManager.x == true)
        {
            x.enabled = true;
        }
        if (AlphabetsManager.y == true)
        {
            y.enabled = true;
        }
        if (AlphabetsManager.z == true)
        {
            z.enabled = true;
        }

        // ............................................Numbers Colliders.............................................

        GameManager.numbersGameOject = (PlayerPrefs.GetInt("EnableNumbers") != 0);
        if (GameManager.numbersGameOject == true)
        {
            numbersToEnable.SetActive(true);
            numbersManagerToEnable.SetActive(true);
            numbersManagerSoundToEnable.SetActive(true);
        }

        if (NumbersManager.zero == true)
        {
            zero.enabled = true;
        }
        if (NumbersManager.one == true)
        {
            one.enabled = true;
        }
        if (NumbersManager.two == true)
        {
            two.enabled = true;
        }
        if (NumbersManager.three == true)
        {
            three.enabled = true;
        }
        if (NumbersManager.four == true)
        {
            four.enabled = true;
        }
        if (NumbersManager.five == true)
        {
            five.enabled = true;
        }
        if (NumbersManager.six == true)
        {
            six.enabled = true;
        }
        if (NumbersManager.seven == true)
        {
            seven.enabled = true;
        }
        if (NumbersManager.eight== true)
        {
            eight.enabled = true;
        }
        if (NumbersManager.nine == true)
        {
            nine.enabled = true;
        }
        // ............................................Shapes Colliders.............................................

        GameManager.shapesGameOject = (PlayerPrefs.GetInt("EnableShapes") != 0);
        if (GameManager.shapesGameOject == true)
        {
            shapesToEnable.SetActive(true);
            shapesManagerToEnable.SetActive(true);
            shapesManagerSoundToEnable.SetActive(true);
        }


        if (ShapesManager.circle == true)
        {
            circle.enabled = true;
        }
        if (ShapesManager.sqaure == true)
        {
            square.enabled = true;
        }
        if (ShapesManager.triangle == true)
        {
            triangle.enabled = true;
        }
        if (ShapesManager.rectangle == true)
        {
            rectangle.enabled = true;
        }
        if (ShapesManager.conee == true)
        {
            conee.enabled = true;
        }
        if (ShapesManager.diomand == true)
        {
            diomand.enabled = true;
        }
        if (ShapesManager.pentagonal == true)
        {
            pentagonal.enabled = true;
        }
        if (ShapesManager.hexagonal == true)
        {
            hexagonal.enabled = true;
        }
        if (ShapesManager.oval == true)
        {
            oval.enabled = true;
        }
        // ............................................Color Colliders.............................................

        GameManager.colorGameOject = (PlayerPrefs.GetInt("EnableColor") != 0);
        if (GameManager.colorGameOject == true)
        {
            colorToEnable.SetActive(true);
            colorManagerToEnable.SetActive(true);
            colorManagerSoundToEnable.SetActive(true);
        }


        if (ColorManager.green == true)
        {
            green.enabled = true;
        }
        if (ColorManager.pink == true)
        {
            pink.enabled = true;
        }
        if (ColorManager.orange == true)
        {
            orange.enabled = true;
        }
        if (ColorManager.red == true)
        {
            red.enabled = true;
        }
        if (ColorManager.yellow == true)
        {
            yellow.enabled = true;
        }
        if (ColorManager.blue == true)
        {
            blue.enabled = true;
        }
        if (ColorManager.purple == true)
        {
            purple.enabled = true;
        }
        // ............................................Fruit Colliders.............................................

        GameManager.fruitGameOject = (PlayerPrefs.GetInt("EnableFruit") != 0);
        if (GameManager.fruitGameOject == true)
        {
            fruitToEnable.SetActive(true);
            fruitManagerToEnable.SetActive(true);
            fruitManagerSoundToEnable.SetActive(true);
        }

        if (FruitsManager.apple == true)
        {
            apple.enabled = true;
        }
        if (FruitsManager.mango == true)
        {
            mango.enabled = true;
        }
        if (FruitsManager.banana == true)
        {
            banana.enabled = true;
        }
        if (FruitsManager.grapes == true)
        {
            grapes.enabled = true;
        }
        if (FruitsManager.orangefruit == true)
        {
            orangeFruit.enabled = true;
        }
        if (FruitsManager.waterMelon == true)
        {
            waterMelon.enabled = true;
        }
        if (FruitsManager.pineApple == true)
        {
            PineApple.enabled = true;
        }

        // ............................................Animal Colliders.............................................

        GameManager.animalGameOject = (PlayerPrefs.GetInt("EnableAnimals") != 0);
        if (GameManager.animalGameOject == true)
        {
            animalToEnable.SetActive(true);
            animalManagerToEnable.SetActive(true);
            animalManagerSoundToEnable.SetActive(true);
        }


        if (AnimalsManager.cat ==true)
        {
            cat.enabled = true;
        }
        if (AnimalsManager.monkey== true)
        {
            monkey.enabled = true;
        }
        if (AnimalsManager.fish==true)
        {
            fish.enabled = true;
        }
        if (AnimalsManager.horse==true)
        {
            horse.enabled = true;
        }
        if (AnimalsManager.deer== true)
        {
            deer.enabled = true;
        }
        if (AnimalsManager.lion== true)
        {
            lion.enabled = true;
        }

        // ............................................Birds Colliders.............................................

        GameManager.birdsGameOject = (PlayerPrefs.GetInt("EnableBirds") != 0);
        if (GameManager.birdsGameOject == true)
        {
            animalToEnable.SetActive(true);
            animalManagerToEnable.SetActive(true);
            animalManagerSoundToEnable.SetActive(true);
        }



        if (BirdsManager.duck == true)
        {
            duck.enabled = true;
        }
        if (BirdsManager.eagle == true)
        {
            eagle.enabled = true;
        }
        if (BirdsManager.sparrow == true)
        {
            sparrow.enabled = true;
        }
        if (BirdsManager.parrot == true)
        {
            parrot.enabled = true;
        }
        if (BirdsManager.rooster == true)
        {
            rooster.enabled = true;
        }
        if (BirdsManager.toucan == true)
        {
            toucan.enabled = true;
        }
    }
   
}
