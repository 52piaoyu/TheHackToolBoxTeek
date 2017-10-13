﻿//  Author:
//       Teeknofil <teeknofil.dev@gmail.com>
//
//  Copyright (c) 2015 Teeknofil
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;


namespace Charset
{
    public class Pattern
    {
        private List<string> charsetSelecting = new List<string>();
        public List<string> CharsetSelecting
        {
            get
            {
                return CharsetSelecting;
            }

            set
            {
                CharsetSelecting = value;
            }
        }

        private bool validated = true;
        public bool Validated
        {
            get
            {
                return validated;
            }
            set
            {
                validated = value;
            }
        }

        private string charsetName;
        public string CharsetName
        {
            get
            {
                return charsetName;
            }
            set
            {
                charsetName = value;
            }
        }


        private List<string> charsetAlphaLower = new List<string>() { "lalpha", "lalpha-space", "lalpha-numeric", "lalpha-numeric-space", "lalpha-numeric-symbol14", "lalpha-numeric-symbol14-space", "lalpha-numeric-all", "lalpha-numeric-all-space" };
        public List<string> CharsetAlpha
        {
            get
            {
                return charsetAlphaLower;
            }
            set
            {
                charsetAlphaLower = value;
            }
        }

        private List<string> charsetAlphaUpper = new List<string>() { };
        public List<string> CharsetAlphaUpper
        {
            get
            {
                return charsetAlphaUpper;
            }
            set
            {
                charsetAlphaUpper = value;
            }
        }

        private List<string> charsetAlphaMix = new List<string>() { };
        public List<string> CharsetAlphaMix
        {
            get
            {
                return charsetAlphaMix;
            }
            set
            {
                charsetAlphaMix = value;
            }
        }

        private List<string> charsetSvAlphaLower = new List<string>() {};
        public List<string> CharsetSvAlpha
        {
            get
            {
                return charsetSvAlphaLower;
            }
            set
            {
                charsetSvAlphaLower = value;
            }
        }


        private List<string> charsetSvAlphaUpper = new List<string>() { };
        public List<string> CharsetSvAlphaUpper
        {
            get
            {
                return charsetSvAlphaUpper;
            }
            set
            {
                charsetSvAlphaUpper = value;
            }
        }

        private List<string> charsetSvAlphaMix = new List<string>() { };
        public List<string> CharsetCyrillic
        {
            get
            {
                return charsetSvAlphaMix;
            }
            set
            {
                charsetSvAlphaMix = value;
            }
        }

        private List<string> charsetCyrillicLower = new List<string>() { };
        public List<string> CharsetCyrillicLower
        {
            get
            {
                return charsetCyrillicLower;
            }
            set
            {
                charsetCyrillicLower = value;
            }
        }


        private List<string> charsetCyrillicUpper = new List<string>() { };
        public List<string> CharsetCyrillicUpper
        {
            get
            {
                return charsetSvAlphaUpper;
            }
            set
            {
                charsetSvAlphaUpper = value;
            }
        }

        private List<string> charsetCyrillicMix = new List<string>() { };
        public List<string> CharsetCyrillicMix
        {
            get
            {
                return charsetCyrillicMix;
            }
            set
            {
                charsetCyrillicMix = value;
            }
        }

        private List<string> charsetMix = new List<string>() { "mix", "hex-letters-lower", "hex-letters-upper", "hexa-letters-mix", "lalpha", "ualpha", "mixalpha", "sv-lalpha", "sv-ualpha", "sv-mixalpha", "lcyrillic", "mixcyrillic", "lsyllable", "usyllable", "mixsyllable" };
        public List<string> CharsetMix
        {
            get
            {
                return charsetMix;
            }
            set
            {
                charsetMix = value;
            }
        }

        private List<string> space = new List<string>() { " " };
        protected List<string> Space
        {
            get
            {
                return space;
            }

            set
            {
                space = value;
            }
        }


        private List<string> numeric = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        protected List<string> Numeric
        {
            get
            {
                return numeric;
            }

            set
            {
                numeric = value;
            }
        }

        private List<string> hexLower = new List<string>() { "a", "b", "c", "d", "e", "f" };
        protected List<string> HexLower
        {
            get
            {
                return hexLower;
            }

            set
            {
                hexLower = value;
            }
        }

        private List<string> hexUpper = new List<string>() { "A", "B", "C", "D", "E", "F" };
        protected List<string> HexUpper
        {
            get
            {
                return hexUpper;
            }

            set
            {
                hexUpper = value;
            }
        }

        private List<string> symbols14 = new List<string>() { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=" };
        protected List<string> Symbols14
        {
            get
            {
                return symbols14;
            }

            set
            {
                symbols14 = value;
            }
        }

        private List<string> symbolsAll = new List<string>() { "~", "`", "[", "]", "{", "}", "|", "\\", ":", ";", "\"", "<", ">", ",", ".", "?", "/" };
        protected List<string> SymbolsAll
        {
            get
            {
                return symbolsAll;
            }

            set
            {
                symbolsAll = value;
            }
        }

        private List<string> ualpha = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        protected List<string> Ualpha
        {
            get
            {
                return ualpha;
            }

            set
            {
                ualpha = value;
            }
        }

        private List<string> lalpha = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        protected List<string> Lalpha
        {
            get
            {
                return lalpha;
            }

            set
            {
                lalpha = value;
            }
        }


        private List<string> ualphaSv = new List<string>() { "Å", "Ä", "Ö" };
        protected List<string> UalphaSv
        {
            get
            {
                return ualphaSv;
            }

            set
            {
                ualphaSv = value;
            }
        }

        private List<string> lalphaSv = new List<string>() { "å", "ä", "ö" };
        protected List<string> Lalpha_sv
        {
            get
            {
                return lalphaSv;
            }

            set
            {
                lalphaSv = value;
            }
        }

        private List<string> syllableFr = new List<string>() { "ac", "ach", "ad", "af", "ag", "ail", "ain", "aition", "aj", "ak", "al", "am", "anc", "anch", "and", "anf", "ang", "anj", "anl", "anph", "anr", "ans", "ant", "antion", "anv", "ap", "aph", "ar", "as", "at", "ation", "aub", "auc", "auch", "aud", "auf", "aug", "auj", "auk", "aul", "aum", "aun", "aup", "auph", "aur", "aus", "aution", "av", "bac", "bai", "bain", "bam", "ban", "bao", "bau", "baut", "be", "bé", "bè", "bê", "beau", "béi", "bein", "bès", "bet", "béu", "bèv", "bez", "bi", "bid", "bien", "big", "bin", "bion", "bla", "blé", "bli", "blo", "blon", "blu", "bo", "boeu", "boi", "boig", "boin", "boj", "bon", "bonk", "bop", "bou", "bra", "bré", "brè", "bri", "bro", "bron", "bru", "bru", "buf", "bup", "ca", "ça", "cad", "cae", "cai", "cain", "çain", "cam", "çan", "cau", "çau", "cauz", "ce", "cé", "cè", "cê", "ceau", "cei", "cein", "cem", "cen", "cer", "cet", "ceu", "cez", "cha", "chab", "chai", "chain", "cham", "chan", "chau", "chaul", "che", "ché", "chè", "chê", "chéa", "cheau", "chei", "chein", "chèk", "chem", "chen", "cheo", "cher", "chet", "cheu", "chez", "chi", "chien", "chig", "chin", "cho", "choeu", "chof", "choi", "choic", "choin", "chon", "chonc", "chou", "chouj", "chu", "chud", "chun", "ci", "cien", "cion", "clé", "clè", "clo", "clon", "clou", "clu", "co", "ço", "cod", "coi", "çoi", "coin", "çoin", "çon", "cos", "coub", "coul", "cra", "cran", "cré", "crè", "cri", "cron", "crou", "cru", "cui", "cun", "çun", "cup", "dab", "dai", "dain", "dal", "dam", "dan", "dau", "dauj", "daz", "de", "dé", "dè", "dê", "dea", "dèa", "deau", "deg", "dei", "dein", "déj", "dem", "den", "déo", "der", "det", "deu", "dév", "dez", "dia", "dien", "dil", "dion", "do", "doi", "doin", "doj", "don", "dong", "dou", "douf", "dra", "dran", "drau", "dre", "dré", "drè", "dri", "dro", "dron", "dru", "dun", "dur", "dut", "eb", "ec", "éc", "ed", "éd", "èd", "éf", "èf", "eg", "èg", "eil", "eition", "éj", "èj", "ek", "ék", "él", "èl", "ém", "ention", "ep", "èp", "er", "ér", "ér", "èr", "és", "és", "ès", "èt", "etion", "étion", "ètion", "euil", "eution", "év", "év", "fai", "fain", "fam", "fan", "fat", "fau", "faui", "fe", "fé", "fè", "fê", "féa", "feau", "fei", "fein", "fem", "fenv", "féo", "fer", "fet", "fèt", "fez", "fia", "fic", "fien", "fla", "fla", "flau", "flé", "fli", "flo", "flo", "flon", "flu", "fo", "foeu", "foin", "fons", "fop", "four", "fré", "fré", "frè", "fren", "fri", "fro", "fron", "ful", "fun", "fur", "fuz", "ga", "gab", "gai", "gain", "gam", "gan", "gau", "ge", "gé", "gè", "gê", "gen", "geou", "geu", "gi", "gin", "gla", "glau", "gle", "glé", "glè", "gli", "glo", "gloi", "glon", "glou", "glu", "gna", "gnain", "gnan", "gnau", "gne", "gné", "gnè", "gnê", "gneau", "gnei", "gnein", "gnen", "gner", "gnet", "gneu", "gnez", "gni", "gnien", "gnin", "gno", "gnoeu", "gnoi", "gnoin", "gnon", "gnou", "gnu", "gnun", "go", "goa", "goin", "goit", "gond", "gou", "goud", "gra", "gran", "grau", "gre", "gré", "grè", "gri", "gro", "groi", "groi", "gron", "grou", "gru", "gu", "gub", "gue", "gué", "guè", "guê", "guein", "guéj", "guep", "guèp", "guer", "guet", "gueu", "gui", "guic", "guion", "hau", "hè", "hê", "heau", "hou", "id", "if", "ig", "il", "im", "in", "intion", "ip", "iph", "ir", "is", "it", "ition", "iton", "iv", "ja", "jab", "jai", "jam", "jan", "jau", "jaup", "jauv", "je", "jé", "jè", "jê", "jeau", "jeb", "jéf", "jei", "jein", "jem", "jer", "jès", "jet", "jeu", "jez", "ji", "jic", "jien", "jin", "jion", "jo", "joeu", "joi", "join", "jol", "jon", "jonf", "jou", "joua", "ju", "jud", "jun", "ka", "kad", "kai", "kain", "kam", "kan", "kau", "kaun", "ke", "ké", "kè", "kê", "kéa", "keau", "keg", "kei", "kein", "kem", "ken", "ker", "ket", "keu", "kez", "ki", "kien", "kim", "kin", "kion", "kla", "klau", "kle", "klé", "kli", "klo", "klu", "ko", "koeu", "koi", "koin", "kor", "kou", "koul", "kra", "krau", "kre", "kri", "kro", "kru", "ku", "kun", "kuo", "la", "lab", "lab", "lag", "lai", "lain", "lam", "lan", "lans", "lap", "lau", "lé", "lè", "lê", "léa", "leau", "lei", "léi", "lein", "lem", "len", "ler", "lèr", "let", "leu", "lez", "léz", "lic", "lien", "lin", "lion", "lir", "lo", "loa", "lod", "loeu", "loi", "loij", "loin", "lon", "lor", "lou", "lud", "lué", "lun", "lut", "luz", "mab", "mai", "main", "man", "mao", "mau", "mauc", "mé", "mè", "mê", "méa", "meau", "mei", "mein", "méj", "mem", "mèo", "mer", "met", "meu", "méu", "mez", "mia", "mien", "mij", "min", "mion", "mit", "miu", "mod", "moeu", "moi", "moin", "moiv", "mon", "mos", "mou", "mov", "mu", "muf", "muj", "mun", "mup", "na", "nab", "nai", "nain", "nam", "nan", "nau", "naup", "ne", "nè", "nê", "néa", "neau", "nei", "nein", "nem", "nen", "neo", "ner", "net", "neu", "név", "nez", "nien", "nif", "nig", "no", "noa", "noeu", "noi", "noif", "noin", "nol", "non", "nonj", "nou", "nu", "nun", "nut", "ob", "oc", "oc", "och", "oeu", "of", "og", "oib", "oic", "oich", "oid", "oif", "oig", "oij", "oik", "oil", "oim", "oip", "oit", "oition", "ok", "ol", "om", "om", "onc", "onch", "ond", "onf", "ong", "onj", "onp", "onph", "onr", "ons", "ont", "onv", "op", "oph", "or", "os", "os", "ot", "otion", "ouc", "ouch", "oud", "oug", "ouil", "ouj", "ouk", "oul", "ouph", "ous", "out", "oution", "ov", "paf", "pag", "pain", "pam", "pan", "pau", "pauf", "paz", "pe", "pé", "pè", "peau", "pei", "pein", "pem", "pen", "penk", "péo", "per", "pet", "peu", "péu", "pez", "pèz", "pha", "phab", "phai", "phain", "pham", "phan", "phau", "phaul", "phe", "phé", "phè", "phê", "phéa", "pheau", "phei", "phein", "phem", "phenj", "pher", "phet", "phèt", "pheu", "phien", "phin", "pho", "phon", "phor", "phran", "phré", "phu", "pim", "pin", "pit", "pla", "plan", "plau", "ple", "plé", "plè", "plen", "pli", "plo", "plon", "plu", "po", "poeu", "poi", "poic", "poin", "pom", "pon", "pop", "pos", "pou", "pouc", "pra", "pran", "pre", "pré", "pré", "prè", "pren", "pri", "pri", "pro", "pru", "pru", "pu", "puc", "pun", "pur", "qeue", "qua", "quai", "quain", "quan", "quau", "que", "qué", "què", "quê", "queau", "quei", "quein", "quer", "quet", "quez", "qui", "quien", "quin", "quo", "quoi", "quoin", "quou", "rab", "raf", "rai", "ram", "ran", "rau", "raub", "rav", "ré", "rè", "rê", "reau", "rég", "rei", "rein", "rèj", "rem", "renc", "rer", "ret", "reu", "réu", "rev", "rez", "rien", "rij", "rin", "rio", "rion", "roeu", "roin", "rois", "rok", "ron", "ros", "rou", "rov", "rua", "ruc", "rui", "rul", "run", "sa", "sab", "sai", "sain", "sam", "san", "sand", "sao", "sau", "sauc", "se", "sé", "sê", "seau", "sei", "séi", "sèi", "sein", "sem", "sen", "ser", "set", "seu", "sév", "sez", "si", "sic", "sien", "sin", "sion", "siz", "so", "soa", "sod", "soeu", "soi", "soif", "soin", "soiz", "son", "sonr", "sou", "sou", "soug", "su", "suf", "sum", "sun", "tad", "tai", "tain", "tan", "tau", "te", "té", "tei", "tem", "ter", "tez", "tib", "tien", "tif", "tin", "to", "tob", "tod", "ton", "top", "tou", "tra", "trau", "tre", "tré", "tren", "tri", "tro", "tron", "tru", "tru", "tud", "tug", "tui", "tun", "uc", "uch", "ud", "uf", "ug", "uj", "uk", "ul", "um", "untion", "up", "uph", "ur", "us", "ut", "ution", "uv", "vain", "vam", "vauk", "vè", "véa", "vein", "vén", "vet", "veu", "vin", "vion", "vir", "vlan", "vlon", "vo", "voeu", "voi", "voin", "voiz", "voj", "von", "vonl", "vop", "vou", "voz", "vra", "vra", "vrau", "vre", "vré", "vrè", "vri", "vro", "vron", "vrou", "vru", "vu", "vum", "vun", "vus", "vut", "xa", "xain", "xan", "xau", "xe", "xé", "xè", "xeau", "xez", "xi", "xin", "xo", "xoeu", "xoi", "xon", "xu", "za", "zain", "zan", "ze", "zé", "zeau", "zein", "zeu", "zi", "zien", "zin" };
        protected List<string> SyllableFr
        {
            get
            {
                return syllableFr;
            }

            set
            {
                syllableFr = value;
            }
        }

        private List<string> cyrillic = new List<string>() { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м,", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
        protected List<string> Cyrillic
        {
            get
            {
                return cyrillic;
            }

            set
            {
                cyrillic = value;
            }
        }




    }
}
