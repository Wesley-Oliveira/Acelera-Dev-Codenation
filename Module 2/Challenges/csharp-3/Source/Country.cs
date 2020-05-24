using System;
using System.Collections.Generic;
using System.Linq;

namespace Codenation.Challenge
{
    public class Country
    {
        public State[] Top10StatesByArea()
        {
            var states = new List<State> 
            {
                new State("Acre", "AC"),
                new State("Alagoas", "AL"),
                new State("Amapa", "AP"),
                new State("Amazonas", "AM"),
                new State("Bahia", "BA"),
                new State("Ceara", "CE"),
                new State("Distrito Federal", "DF"),
                new State("Espirito Santo", "ES"),
                new State("Goias", "GO"),
                new State("Maranhao", "MA"),
                new State("Mato Grosso", "MT"),
                new State("Mato Grosso do Sul", "MS"),
                new State("Minas Gerais", "MG"),
                new State("Para", "PA"),
                new State("Paraiba", "PB"),
                new State("Parana", "PR"),
                new State("Pernambuco", "PE"),
                new State("Piaui", "PI"),
                new State("Rio de Janeiro", "RJ"),
                new State("Rio Grande do Norte", "RN"),
                new State("Rio Grande do Sul", "RS"),
                new State("Rondonia", "RO"),
                new State("Roraima", "RR"),
                new State("Santa Catarina", "SC"),
                new State("Sao Paulo", "SP"),
                new State("Sergipe", "SE"),
                new State("Tocantins", "TO")
            };

            states[0].Area = 164123.040; //acre
            states[1].Area = 27778.506; // alagoas
            states[2].Area = 142828.521; //amapa
            states[3].Area = 1559159.148; //amazonas
            states[4].Area = 564733.177; //bahia
            states[5].Area = 148920.472; //ceara
            states[6].Area = 5779.999; // df
            states[7].Area = 46095.583; // es
            states[8].Area = 340111.783; // goias
            states[9].Area = 331937.450; //maranhao
            states[10].Area = 903366.192; //MT
            states[11].Area = 357145.532; //MS
            states[12].Area = 586522.122; //MG
            states[13].Area = 1247954.666; //para
            states[14].Area = 56585.000; //paraiba
            states[15].Area = 199307.922; //parana
            states[16].Area = 98311.616; //PE
            states[17].Area = 251577.738; //PI
            states[18].Area = 43780.172; //rj
            states[19].Area = 52811.047; //rn
            states[20].Area = 281730.223; //rs
            states[21].Area = 237590.547; //rondonia
            states[22].Area = 224300.506; //roraima
            states[23].Area = 95736.165; //sc
            states[24].Area = 248222.362; //sp
            states[25].Area = 21915.116; //se
            states[26].Area = 277720.520; //Tocantins

            return states.OrderByDescending(state => state.Area).Take(10).ToArray();
        }
    }
}
