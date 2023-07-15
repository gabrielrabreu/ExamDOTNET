using ExamNET.Bogus.Enums;
using ExamNET.Bogus.Models;

namespace ExamNET.Bogus
{
    public static class WordsFactory
    {
        private static readonly List<WordModel> W_PT_BR = new();
        public static List<WordModel> PT_BR = W_PT_BR;

        public static void Initialize(Locale locale)
        {
            if (locale == Locale.PT_BR)
                ConstructPTBR();
        }

        private static void ConstructPTBR()
        {
            var locale = Locale.PT_BR;

            PT_BR.Clear();

            // Mono-sylablles
            PT_BR.Add(new WordModel(locale, "flor", "flor", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "aí", "aí", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "sol", "sol", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "pá", "pá", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "rã", "rã", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "rim", "rim", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "rum", "rum", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "ar", "ar", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "mar", "mar", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "há", "há", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "quem", "quem", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "quão", "quão", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "já", "já", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "nem", "nem", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "que", "que", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "ser", "ser", SylablleType.Mono));
            PT_BR.Add(new WordModel(locale, "sim", "sim", SylablleType.Mono, "não"));
            PT_BR.Add(new WordModel(locale, "não", "não", SylablleType.Mono, "sim"));
            PT_BR.Add(new WordModel(locale, "são", "são", SylablleType.Mono, "doente"));
            PT_BR.Add(new WordModel(locale, "só", "só", SylablleType.Mono, "acompanhado"));
            PT_BR.Add(new WordModel(locale, "rir", "rir", SylablleType.Mono, "chorar"));

            // Di-sylablles
            PT_BR.Add(new WordModel(locale, "mesa", "me-sa", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "ali", "a-li", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "dever", "de-ver", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "solda", "sol-da", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "sabor", "sa-bor", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "você", "vo-cê", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "cores", "co-res", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "dica", "di-ca", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "lua", "lu-a", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "sino", "si-no", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "urso", "ur-so", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "amor", "a-mor", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "vida", "vi-da", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "fada", "fa-da", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "água", "á-gua", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "trator", "tra-tor", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "cristal", "cris-tal", SylablleType.Di));
            PT_BR.Add(new WordModel(locale, "certo", "cer-to", SylablleType.Di, "errado"));
            PT_BR.Add(new WordModel(locale, "baixo", "bai-xo", SylablleType.Di, "alto"));
            PT_BR.Add(new WordModel(locale, "força", "for-ça", SylablleType.Di, "fraqueza"));
            PT_BR.Add(new WordModel(locale, "cheio", "chei-o", SylablleType.Di, "vazio"));
            PT_BR.Add(new WordModel(locale, "duro", "du-ro", SylablleType.Di, "mole"));
            PT_BR.Add(new WordModel(locale, "doce", "do-ce", SylablleType.Di, "salgado"));
            PT_BR.Add(new WordModel(locale, "pobre", "po-bre", SylablleType.Di, "rico"));
            PT_BR.Add(new WordModel(locale, "mostrar", "mos-trar", SylablleType.Di, "esconder"));
            PT_BR.Add(new WordModel(locale, "achar", "a-char", SylablleType.Di, "perder"));
            PT_BR.Add(new WordModel(locale, "fundo", "fun-do", SylablleType.Di, "raso"));
            PT_BR.Add(new WordModel(locale, "longe", "lon-ge", SylablleType.Di, "perto"));
            PT_BR.Add(new WordModel(locale, "gordo", "gor-do", SylablleType.Di, "magro"));
            PT_BR.Add(new WordModel(locale, "justo", "jus-to", SylablleType.Di, "tendencioso"));
            PT_BR.Add(new WordModel(locale, "baço", "ba-ço", SylablleType.Di, "transparente"));
            PT_BR.Add(new WordModel(locale, "sujo", "su-jo", SylablleType.Di, "limpo"));
            PT_BR.Add(new WordModel(locale, "dormir", "dor-mir", SylablleType.Di, "acordar"));
            PT_BR.Add(new WordModel(locale, "alto", "al-to", SylablleType.Di, "baixo"));
            PT_BR.Add(new WordModel(locale, "mole", "mo-le", SylablleType.Di, "duro"));
            PT_BR.Add(new WordModel(locale, "rico", "ri-co", SylablleType.Di, "pobre"));
            PT_BR.Add(new WordModel(locale, "perder", "per-der", SylablleType.Di, "achar"));
            PT_BR.Add(new WordModel(locale, "raso", "ra-so", SylablleType.Di, "fundo"));
            PT_BR.Add(new WordModel(locale, "perto", "per-to", SylablleType.Di, "longe"));
            PT_BR.Add(new WordModel(locale, "magro", "ma-gro", SylablleType.Di, "gordo"));
            PT_BR.Add(new WordModel(locale, "limpo", "lim-po", SylablleType.Di, "sujo"));
            PT_BR.Add(new WordModel(locale, "chorar", "cho-rar", SylablleType.Di, "rir"));
            PT_BR.Add(new WordModel(locale, "falta", "fal-ta", SylablleType.Di, "abundância"));
            PT_BR.Add(new WordModel(locale, "lento", "len-to", SylablleType.Di, "rápido"));
            PT_BR.Add(new WordModel(locale, "fácil", "fá-cil", SylablleType.Di, "difícil"));
            PT_BR.Add(new WordModel(locale, "ruim", "ru-im", SylablleType.Di, "gostoso"));
            PT_BR.Add(new WordModel(locale, "feio", "fei-o", SylablleType.Di, "bonito"));
            PT_BR.Add(new WordModel(locale, "novo", "no-vo", SylablleType.Di, "idoso"));
            PT_BR.Add(new WordModel(locale, "liso", "li-so", SylablleType.Di, "áspero"));
            PT_BR.Add(new WordModel(locale, "amor", "a-mor", SylablleType.Di, "ódio"));
            PT_BR.Add(new WordModel(locale, "ódio", "ó-dio", SylablleType.Di, "amor"));
            PT_BR.Add(new WordModel(locale, "janta", "jan-ta", SylablleType.Di, "almoço"));

            // Tri-sylablles
            PT_BR.Add(new WordModel(locale, "batata", "ba-ta-ta", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "camada", "ca-ma-da", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "janeiro", "ja-nei-ro", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "planeta", "pla-ne-ta", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "pimenta", "pi-men-ta", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "salada", "sa-la-da", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "cardume", "car-du-me", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "figueira", "fi-guei-ra", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "soneca", "so-ne-ca", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "passear", "pas-se-ar", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "sinuca", "si-nu-ca", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "salada", "sa-la-da", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "banana", "ba-na-na", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "bolinha", "bo-li-nha", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "risoto", "ri-so-to", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "planeta", "pla-ne-ta", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "estrada", "es-tra-da", SylablleType.Tri));
            PT_BR.Add(new WordModel(locale, "tranquilo", "tran-qui-lo", SylablleType.Tri, "nervoso"));
            PT_BR.Add(new WordModel(locale, "rápido", "rá-pi-do", SylablleType.Tri, "lento"));
            PT_BR.Add(new WordModel(locale, "difícil", "di-fí-cil", SylablleType.Tri, "fácil"));
            PT_BR.Add(new WordModel(locale, "gostoso", "gos-to-so", SylablleType.Tri, "ruim"));
            PT_BR.Add(new WordModel(locale, "bonito", "bo-ni-to", SylablleType.Tri, "feio"));
            PT_BR.Add(new WordModel(locale, "regredir", "re-gre-dir", SylablleType.Tri, "progredir"));
            PT_BR.Add(new WordModel(locale, "fechado", "fe-cha-do", SylablleType.Tri, "aberto"));
            PT_BR.Add(new WordModel(locale, "modesto", "mo-des-to", SylablleType.Tri, "convencido"));
            PT_BR.Add(new WordModel(locale, "idoso", "i-do-so", SylablleType.Tri, "novo"));
            PT_BR.Add(new WordModel(locale, "áspero", "ás-pe-ro", SylablleType.Tri, "liso"));
            PT_BR.Add(new WordModel(locale, "possível", "pos-sí-vel", SylablleType.Tri, "impossível"));
            PT_BR.Add(new WordModel(locale, "feiura", "fei-u-ra", SylablleType.Tri, "beleza"));
            PT_BR.Add(new WordModel(locale, "começar", "co-me-çar", SylablleType.Tri, "terminar"));
            PT_BR.Add(new WordModel(locale, "apagar", "a-pa-gar", SylablleType.Tri, "acender"));
            PT_BR.Add(new WordModel(locale, "atento", "a-ten-to", SylablleType.Tri, "desatento"));
            PT_BR.Add(new WordModel(locale, "escuro", "es-cu-ro", SylablleType.Tri, "iluminado"));
            PT_BR.Add(new WordModel(locale, "severo", "se-ve-ro", SylablleType.Tri, "condescendente"));
            PT_BR.Add(new WordModel(locale, "desprezo", "des-pre-zo", SylablleType.Tri, "apreço"));
            PT_BR.Add(new WordModel(locale, "ânimo", "â-ni-mo", SylablleType.Tri, "abatimento"));
            PT_BR.Add(new WordModel(locale, "esperto", "es-per-to", SylablleType.Tri, "limitado"));
            PT_BR.Add(new WordModel(locale, "errado", "er-ra-do", SylablleType.Tri, "certo"));
            PT_BR.Add(new WordModel(locale, "fraqueza", "fra-que-za", SylablleType.Tri, "força"));
            PT_BR.Add(new WordModel(locale, "vazio", "va-zi-o", SylablleType.Tri, "cheio"));
            PT_BR.Add(new WordModel(locale, "salgado", "sal-ga-do", SylablleType.Tri, "doce"));
            PT_BR.Add(new WordModel(locale, "esconder", "es-con-der", SylablleType.Tri, "mostrar"));
            PT_BR.Add(new WordModel(locale, "acordar", "a-cor-dar", SylablleType.Tri, "dormir"));
            PT_BR.Add(new WordModel(locale, "doente", "do-en-te", SylablleType.Tri, "são"));
            PT_BR.Add(new WordModel(locale, "tristeza", "tris-te-za", SylablleType.Tri, "alegria"));
            PT_BR.Add(new WordModel(locale, "covarde", "co-var-de", SylablleType.Tri, "corajoso"));
            PT_BR.Add(new WordModel(locale, "supérfluo", "su-pér-fluo", SylablleType.Tri, "indispensável"));
            PT_BR.Add(new WordModel(locale, "grosseiro", "gros-sei-ro", SylablleType.Tri, "educado"));
            PT_BR.Add(new WordModel(locale, "defeito", "de-fei-to", SylablleType.Tri, "qualidade"));
            PT_BR.Add(new WordModel(locale, "nervoso", "ner-vo-so", SylablleType.Tri, "tranquilo"));
            PT_BR.Add(new WordModel(locale, "progredir", "pro-gre-dir", SylablleType.Tri, "regredir"));
            PT_BR.Add(new WordModel(locale, "aberto", "a-ber-to", SylablleType.Tri, "fechado"));
            PT_BR.Add(new WordModel(locale, "beleza", "be-le-za", SylablleType.Tri, "feiura"));
            PT_BR.Add(new WordModel(locale, "terminar", "ter-mi-nar", SylablleType.Tri, "começar"));
            PT_BR.Add(new WordModel(locale, "acender", "a-cen-der", SylablleType.Tri, "apagar"));
            PT_BR.Add(new WordModel(locale, "apreço", "a-pre-ço", SylablleType.Tri, "desprezo"));
            PT_BR.Add(new WordModel(locale, "almoço", "al-mo-ço", SylablleType.Tri, "janta"));
            PT_BR.Add(new WordModel(locale, "atrair", "a-tra-ir", SylablleType.Tri, "afastar"));
            PT_BR.Add(new WordModel(locale, "afastar", "a-fas-tar", SylablleType.Tri, "atrair"));

            // Poly-sylablles
            PT_BR.Add(new WordModel(locale, "borboleta", "bor-bo-le-ta", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "brasileiro", "bra-si-lei-ro", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "festividade", "fes-ti-vi-da-de", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "almoçado", "al-mo-ça-do", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "prateleira", "pra-te-lei-ra", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "panelinha", "pa-ne-li-nha", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "amendoim", "a-men-do-im", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "espionar", "es-pi-o-nar", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "carpinteiro", "car-pin-tei-ro", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "saboneteira", "sa-bo-ne-tei-ra", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "retângulo", "re-tân-gu-lo", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "assombrado", "as-som-bra-do", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "madeireira", "ma-dei-rei-ra", SylablleType.Poly));
            PT_BR.Add(new WordModel(locale, "alegria", "a-le-gri-a", SylablleType.Poly, "tristeza"));
            PT_BR.Add(new WordModel(locale, "corajoso", "co-ra-jo-so", SylablleType.Poly, "covarde"));
            PT_BR.Add(new WordModel(locale, "indispensável", "in-dis-pen-sá-vel", SylablleType.Poly, "supérfluo"));
            PT_BR.Add(new WordModel(locale, "adequado", "a-de-qua-do", SylablleType.Poly, "inadequado"));
            PT_BR.Add(new WordModel(locale, "definitivo", "de-fi-ni-ti-vo", SylablleType.Poly, "provisório"));
            PT_BR.Add(new WordModel(locale, "responsável", "res-pon-sá-vel", SylablleType.Poly, "irresponsável"));
            PT_BR.Add(new WordModel(locale, "importante", "im-por-tan-te", SylablleType.Poly, "insignificante"));
            PT_BR.Add(new WordModel(locale, "educado", "e-du-ca-do", SylablleType.Poly, "grosseiro"));
            PT_BR.Add(new WordModel(locale, "qualidade", "qua-li-da-de", SylablleType.Poly, "defeito"));
            PT_BR.Add(new WordModel(locale, "amizade", "a-mi-za-de", SylablleType.Poly, "inimizade"));
            PT_BR.Add(new WordModel(locale, "abundância", "a-bun-dân-cia", SylablleType.Poly, "falta"));
            PT_BR.Add(new WordModel(locale, "transparente", "trans-pa-ren-te", SylablleType.Poly, "baço"));
            PT_BR.Add(new WordModel(locale, "provisório", "pro-vi-só-rio", SylablleType.Poly, "definitivo"));
            PT_BR.Add(new WordModel(locale, "convencido", "con-ven-ci-do", SylablleType.Poly, "modesto"));
            PT_BR.Add(new WordModel(locale, "impossível", "im-pos-sí-vel", SylablleType.Poly, "possível"));
            PT_BR.Add(new WordModel(locale, "desatento", "de-sa-ten-to", SylablleType.Poly, "atento"));
            PT_BR.Add(new WordModel(locale, "limitado", "li-mi-ta-do", SylablleType.Poly, "esperto"));
            PT_BR.Add(new WordModel(locale, "tendencioso", "ten-den-ci-o-so", SylablleType.Poly, "justo"));
            PT_BR.Add(new WordModel(locale, "acompanhado", "a-com-pa-nha-do", SylablleType.Poly, "só"));
            PT_BR.Add(new WordModel(locale, "inadequado", "i-na-de-qua-do", SylablleType.Poly, "adequado"));
            PT_BR.Add(new WordModel(locale, "irresponsável", "ir-res-pon-sá-vel", SylablleType.Poly, "responsável"));
            PT_BR.Add(new WordModel(locale, "inimizade", "i-ni-mi-za-de", SylablleType.Poly, "amizade"));
            PT_BR.Add(new WordModel(locale, "iluminado", "i-lu-mi-na-do", SylablleType.Poly, "escuro"));
            PT_BR.Add(new WordModel(locale, "condescendente", "con-des-cen-den-te", SylablleType.Poly, "severo"));
            PT_BR.Add(new WordModel(locale, "abatimento", "a-ba-ti-men-to", SylablleType.Poly, "ânimo"));
            PT_BR.Add(new WordModel(locale, "insignificante", "in-sig-ni-fi-can-te", SylablleType.Poly, "importante"));
            PT_BR.Add(new WordModel(locale, "adormecido", "a-dor-me-ci-do", SylablleType.Poly, "acordado"));
            PT_BR.Add(new WordModel(locale, "acordado", "a-cor-da-do", SylablleType.Poly, "adormecido"));
            PT_BR.Add(new WordModel(locale, "arriscado", "ar-ris-ca-do", SylablleType.Poly, "confiável"));
            PT_BR.Add(new WordModel(locale, "confiável", "con-fi-á-vel", SylablleType.Poly, "arriscado"));

        }
    }
}
