﻿using System;
using System.Collections.Generic;

namespace DayOne
{
    internal class Program
    {
        public static void Main(string[] args)
        {
	        //Puzzle input
            String str = "32941994713271959948248321975648598766826381888897682988942438326656546" +
                         "81412886862234525991553276578641265589959178414218389329361496673991614" +
                         "67362634455217941399556226681813837239321396614312491446939769258725111" +
                         "26632178628792332267635339111288933545363532138471222514638578941598198" +
                         "28724827969576432191847787772732881266875469721189331882228146576832921" +
                         "31463822131739325647199859811728963268466335527384598393384572171349781" +
                         "17669953677958579652221836687655174542633541111348413346313451115961316" +
                         "82726196574763165187889337599583345634413436165539744188866156771585647" +
                         "71855518252993666968358166239861876539148716471572484989456331442695934" +
                         "81192869551444394527317626665687416121532544691317241376998329847289378" +
                         "65956711925592628456617133695259554548719328229938621332325125972547181" +
                         "23681226388737586623111831295436943293735935726646738331832623957287731" +
                         "47651218448311261781739887997652189131788259662688164765597929473599568" +
                         "59989228917136267178571776316345292573489873792149646548747995389669692" +
                         "18845772441446872719281991944827592216632115814136523754522263368837289" +
                         "14518424344585276987743421114824989993838314925776151545912787196567982" +
                         "77377363284379468757998373193231795767644654155432692988651312845433511" +
                         "87945792163893487755757524139436372166723777896245596149355984852258241" +
                         "37482189712124863732327958783629648738559946971496928249171833755451921" +
                         "19453587398199912564474614219929345185468661129966379693813498542474732" +
                         "19817649669474611157692571549396729648725823785415238236557987689439181" +
                         "57598153733191592134755552514887542798882454923735954711891913532446846" +
                         "97662848376529881512529221627313527441221459672786923145165989611223372" +
                         "24114992943624737481846748164193187297258229542593699853519442391654436" +
                         "77995222769144452315822723683888318344375627521193252864743528635546933" +
                         "73718848649568451797751926315617575295381964426843625282819524747119726" +
                         "87219356978561195989677614353991529996827637471299648536785349473437625" +
                         "75112734437364334644962872196156973419731317151667689161498283964546385" +
                         "96713572963686159214116763";
            //break the string into individual characters
	        char[] ak = str.ToCharArray();
            
            int sum= 0; //the sum we are after
            for(int i = 0; i< ak.Length-1; i++){
            	if(ak[i].Equals(ak[i+1])){
            		sum += Int32.Parse(ak[i].ToString());
            	}
            }
            if(ak[0].Equals(ak[ak.Length-1])){
	            sum += Int32.Parse(ak[0].ToString());
            }
            Console.Write("The answer to the puzle is: "+ sum +"\n");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
        }
    }
}