using System;
using System.Collections.Generic; 

namespace CodeCracker
{
    public class Key
    {
        private int index;
        private char character;

        public Key(){}
        public Key(int index, char character)
        {
            this.index = index;
            this.character = character;
        }

        public int getAlphabetLenght()
        {
            List <Key> alphabet = getAlphabet(); 

            return alphabet.Count;
        }

        private List<Key> getAlphabet()
        {
            List<Key> alphabet = new List<Key>();

            Key a = new Key(1, 'a');
            Key b = new Key(2, 'b');
            Key c = new Key(3, 'c');
            Key d = new Key(4, 'd');
            Key e = new Key(5, 'e');
            Key f = new Key(6, 'f');
            Key g = new Key(7, 'g');
            Key h = new Key(8, 'h');
            Key i = new Key(9, 'i');
            Key j = new Key(10, 'j');
            Key k = new Key(11, 'k');
            Key l = new Key(12, 'l');
            Key m = new Key(13, 'm');
            Key n = new Key(14, 'n');
            Key o = new Key(15, 'o');
            Key p = new Key(16, 'p');
            Key q = new Key(17, 'q');
            Key r = new Key(18, 'r');
            Key s = new Key(19, 's');
            Key t = new Key(20, 't');
            Key u = new Key(21, 'u');
            Key v = new Key(22, 'v');
            Key w = new Key(23, 'w');
            Key x = new Key(24, 'x');
            Key y = new Key(25, 'y');
            Key z = new Key(26, 'z');

            alphabet.Add(a);
            alphabet.Add(b);
            alphabet.Add(c);
            alphabet.Add(d);
            alphabet.Add(e);
            alphabet.Add(f);
            alphabet.Add(g);
            alphabet.Add(h);
            alphabet.Add(i);
            alphabet.Add(j);
            alphabet.Add(k);
            alphabet.Add(l);
            alphabet.Add(m);
            alphabet.Add(n);
            alphabet.Add(o);
            alphabet.Add(p);
            alphabet.Add(q);
            alphabet.Add(r);
            alphabet.Add(s);
            alphabet.Add(t);
            alphabet.Add(u);
            alphabet.Add(v);
            alphabet.Add(w);
            alphabet.Add(x);
            alphabet.Add(y);
            alphabet.Add(z);

            return alphabet;
        }
    }
}