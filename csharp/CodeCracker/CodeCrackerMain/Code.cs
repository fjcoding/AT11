using System;
using System.Collections.Generic; 

namespace CodeCrackerMain
{
    public class Code
    {
        public String letterSimple {get;set;}
        public String letterEncripted{get;set;}
        //List<Code> tableChanged;
        List<Code> TableCode;
        //Code tablecodetry
        public Code()
        {
            TableCode = new List<Code>();
            // tableChanged = new List<Code>();
        }
     
        public List<Code> tableCodeLetters()
        {
            
            //a b c d e f g h i j k l m n o p q r s t u v w x y z
            //! ) $ ( £ * % & > < @ a b c d e f g h i j k l m n o 
            Code Letter_a = new Code(){letterEncripted = "!", letterSimple = "a"};
            TableCode.Add(Letter_a);
            Code Letter_b = new Code(){letterEncripted = ")", letterSimple = "b"};
            TableCode.Add(Letter_b);
            Code Letter_c = new Code(){letterEncripted = "$", letterSimple = "c"};
            TableCode.Add(Letter_c);
            Code Letter_d = new Code(){letterEncripted = "(", letterSimple = "d"};
            TableCode.Add(Letter_d);
            Code Letter_e = new Code(){letterEncripted = "£", letterSimple = "e"};
            TableCode.Add(Letter_e);
            Code Letter_f = new Code(){letterEncripted = "*", letterSimple = "f"};
            TableCode.Add(Letter_f);
            Code Letter_g = new Code(){letterEncripted = "%", letterSimple = "g"};
            TableCode.Add(Letter_g);
            Code Letter_h = new Code(){letterEncripted = "&", letterSimple = "h"};
            TableCode.Add(Letter_h);
            Code Letter_i = new Code(){letterEncripted = ">", letterSimple = "i"};
            TableCode.Add(Letter_i);
            Code Letter_j = new Code(){letterEncripted = "<", letterSimple = "j"};
            TableCode.Add(Letter_j);
            Code Letter_k = new Code(){letterEncripted = "@", letterSimple = "k"};
            TableCode.Add(Letter_k);
            Code Letter_l = new Code(){letterEncripted = "a", letterSimple = "l"};
            TableCode.Add(Letter_l);
            Code Letter_m = new Code(){letterEncripted = "b", letterSimple = "m"};
            TableCode.Add(Letter_m);
            Code Letter_n = new Code(){letterEncripted = "c", letterSimple = "n"};
            TableCode.Add(Letter_n);
            Code Letter_o = new Code(){letterEncripted = "d", letterSimple = "o"};
            TableCode.Add(Letter_o);
            Code Letter_p = new Code(){letterEncripted = "e", letterSimple = "p"};
            TableCode.Add(Letter_p);
            Code Letter_q = new Code(){letterEncripted = "f", letterSimple = "q"};
            TableCode.Add(Letter_q);
            Code Letter_r = new Code(){letterEncripted = "g", letterSimple = "r"};
            TableCode.Add(Letter_r);
            Code Letter_s = new Code(){letterEncripted = "h", letterSimple = "s"};
            TableCode.Add(Letter_s);
            Code Letter_t = new Code(){letterEncripted = "i", letterSimple = "t"};
            TableCode.Add(Letter_t);
            Code Letter_u = new Code(){letterEncripted = "j", letterSimple = "u"};
            TableCode.Add(Letter_u);
            Code Letter_v = new Code(){letterEncripted = "k", letterSimple = "v"};
            TableCode.Add(Letter_v);
            Code Letter_w = new Code(){letterEncripted = "l", letterSimple = "w"};
            TableCode.Add(Letter_w);
            Code Letter_x = new Code(){letterEncripted = "m", letterSimple = "x"};
            TableCode.Add(Letter_x);
            Code Letter_y = new Code(){letterEncripted = "n", letterSimple = "y"};
            TableCode.Add(Letter_y);
            Code Letter_z = new Code(){letterEncripted = "o", letterSimple = "z"};
            TableCode.Add(Letter_z);

            return TableCode;
        } 
        
        
    }
}