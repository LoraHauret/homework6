﻿namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string violinDescr = "Скри́пка — смычковый музыкальный инструмент с четырьмя струнами, настроенными по квинтам: Gм D1 A1 E2. Самая высокая регистровая разновидность скрипичного семейства, ниже которой располагаются альт, виолончель и контрабас.";
            string violinHist = " Вместе с фортепиано скрипка является главным инструментом академической(классической) музыки.С середины XVIII века ...";// она составляет основу симфонического оркестра и струнного квартета. Как народный инструмент продолжает бытовать среди поляков, белорусов(см.троисти музыки), евреев(см.клезмер), северо - западных русских, чехов, латышей, шведов, норвежцев, эстонцев, венгров, румын, молдаван, цыган(см.тараф) и других народов.В США применяется в музыке кантри[1], в Индии — в классической музыке традиции карнатака.";
            string ukuleleDescr = "Гавайская четырёхструнная разновидность гитары, используемая для аккордового сопровождения песен и игры соло";
            string ukuleleHist = "Укулеле появилась на Гавайских островах во второй половине XIX века, куда её, под названием машети да браса (порт. machete da braça), завезли португальцы..."; // с острова Мадейра[1]. Первый магазин по продаже укулеле на Гавайях был открыт в 1880 году Мануэлем Нуньесом (1843−1922[2])[3]. Гавайцы используют укулеле для исполнения сентиментальных песен на английском языке и музыки в «гавайском стиле»[4]. Название инструмента(гав.ʻukulele) переводится как «скачущая блоха»[1] — то, на что похожи быстрые движения правой руки при игре на укулеле[5].Учитывая, что прежде чем попасть на Гавайи, родственная укулеле маленькая гитара кавакинью в XV веке была завезена португальцами в Африку[6], возможно что это название как-то связано со словом укулеле из южно-африканского(кафрского) языка коса(уку — инфинитивная частица, подобная англ. to +леле — глагол «спать»), смысл которого хорошо передаёт мечтательное и задумчивое настроение, вызываемое звуками укулеле[7]. В США инструмент начал обретать популярность после выступлений гавайских музыкантов в рамках Панамо - Тихоокеанской выставки, проходившей в Сан - Франциско в 1915 году[3].Пик популярности пришёлся на 1930 - е[1]. В 1994 году педагогу-новатору Э.Я.Смеловой(1934−2021[8]) был выдан патент на полезную модель музыкального инструмента гитарайка(от гитара + балалайка), схожего с укулеле концерт по форме, длине струн(37, 2−37, 8 см) и строю(Gм C1 E1 G1)[9][10][11][12]. Эдельвена Смелова использовала гитарайку и свирель в собственной методике музыкального обучения детей как минимум с 1988 года[13], задолго до активного роста популярности укулеле в России в первой половине 2010 - х";
            string tromboneDescr = "Тромбо́н (итал. trombone, букв. «большая труба», англ.  и фр. trombone, нем. Posaune) — европейский духовой амбушюрный инструмент....";// Входит в оркестровую группу медных духовых музыкальных инструментов басово-тенорового регистра. Состоит из длинной тонкой свёрнутой металлической трубки с выдвижной кроной (кулисой), раструба, мундштука. За всю историю существования претерпел минимальные конструктивные изменения. Тромбон — разнообразный по штрихам и технически подвижный инструмент, обладает ярким, блестящим тембром в среднем и верхнем регистрах, сумрачным — в нижнем. ";
            string tromboneHist = "Появился в XV веке, современный вид приобрёл в середине XIX века. Широко применяется в опере и джазе";
            string celloDescr = "смычковый музыкальный инструмент с 4-мя струнами, настроенными по квинтам: Cб Gб Dм Aм. По высоте звучания занимает промежуточное положение между более ....";//высоким альтом и низким контрабасом. ";
            string celloHist = "Появление виолончели относится к началу XVI века.Первоначально она применялась как басовый инструмент для сопровождения пения или исполнения на инструменте ....";//более высокого регистра. Существовали многочисленные разновидности виолончели, отличавшиеся друг от друга размерами, количеством струн, строем(чаще всего встречалась настройка на тон ниже современной)..В XVII—XVIII веках усилиями выдающихся музыкальных мастеров итальянских школ(Николо Амати, Джузеппе Гварнери, Антонио Страдивари, Карло Бергонци, Доменико Монтаньяна и др.) была создана классическая модель виолончели с твёрдо устоявшимся размером корпуса. В конце XVII века появились первые сольные произведения для виолончели ― сонаты и ричеркары Доменико Габриелли.К середине XVIII века виолончель начинает использоваться как концертный инструмент, и благодаря более яркому, полному звуку и улучшающейся технике исполнения окончательно вытесняет из музыкальной практики виолу да гамба. Виолончель также входит в состав симфонического оркестра и камерных ансамблей. Окончательное утверждение виолончели как одного из ведущих инструментов в музыке произошло в XX веке усилиями выдающегося музыканта Пабло Казальса.Развитие школ исполнения на этом инструменте привело к появлению многочисленных виолончелистов - виртуозов, регулярно выступающих с сольными концертами.";
            MusicalInstrument[] instrumentArr = new MusicalInstrument[4];
            instrumentArr[0] = new Violin("Скрипка", violinDescr, violinHist, 4, "Gм D1 A1 E2");
            instrumentArr[1] = new Ukulele("Укулеле", ukuleleDescr, ukuleleHist, 4, "GCEA");
            instrumentArr[2] = new Trombone("Тромбон", tromboneDescr, tromboneHist, " ля в большой октаве до ми бемоль во второй октаве");
            instrumentArr[3] = new Cello("Виолончель", celloDescr, celloHist, 4, "Cб Gб Dм Aм");

            foreach (var instrument in instrumentArr) 
            {
                Console.WriteLine("\n*********");
                instrument.Show();
                instrument.Descr();
                instrument.Hist();
                instrument.MakeSound();
            }
        }
    }
    
}