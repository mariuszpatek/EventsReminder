using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsReminder.DataAccess.Migrations
{
    public partial class SeedGlobalEventsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql
                (@"SET IDENTITY_INSERT [dbo].[GlobalEvents] ON 
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (1, N'Imieniny obchodzą: Almachiusz, Eufrozyna, Fulgencjusz, Fulgenty, Józef, Konkordiusz, Maria, Masław, Miecisław, Mieczysław, Mieczysława, Miesław, Mieszko, Mojsław, Odylon, Odys, Odyseusz, Piotr, Walenty, Walentyn, Wilhelm i Wincenty
                    Kościół prawosławny, anglikański – Obrzezanie Pańskie
                    Międzynarodowe:

                    Nowy Rok(pierwszy dzień roku kalendarzowego), w Polsce dzień wolny od pracy
                    Dzień Domeny Publicznej(m.in.Kanada, Stany Zjednoczone, Szwajcaria, Polska)


                    ', CAST(N'2016 - 01 - 01' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(2, N'Imieniny obchodzą: Abel, Achacjusz, Achacy, Adelard, Argea, Argeus, Aspazja, Aspazjusz, Aspazy, Bazyla, Bazyli, Bazyliusz, Dobiemir, Grzegorz, Jakubina, Makary, Marcelin, Martynian, Narcyz, Stefania, Strzeżysław, Sylwester, Sylwestra, Telesfor, Telesfora i Teodor.
                    ', CAST(N'2016 - 01 - 02' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(3, N'Imieniny obchodzą: Anter, Arleta, Cyriak, Cyryn, Cyryna, Daniel, Danuta, Enoch, Genowefa, Gordiusz, Meliton, Piotr, Pryma, Prymus, Teogenes, Teona, Teonas, Włościsława i Zdzisława.
                    Burkina Faso – rocznica powstania ludowego w 1966 roku
                    ', CAST(N'2016 - 01 - 03' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(4, N'Imieniny obchodzą: Aniela, Benedykta, Dafroza, Dobromir, Doroteusz, Elżbieta, Eugeniusz, Fereol, Grzegorz, Krystiana, Rygobert, Suligost i Tytus.
                    Mjanma – Święto Niepodległości
                    Samoa – urodziny króla
                    ', CAST(N'2016 - 01 - 04' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(5, N'Imieniny obchodzą: Amata, Amelia, Edward, Edwarda, Emiliana, Eufrazjusz, Jan Nepomucen, Marcelina, Piotr, Roger, Symeon, Szymon i Włościbor.
                    Hiszpania, Meksyk – Orszak Trzech Króli
                    ', CAST(N'2016 - 01 - 05' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(6, N'Imieniny obchodzą: Andrzej, Baltazar, Bolemir, Epifania, Jędrzej, Kacper, Karol, Kasper, Manomir, Melaniusz, Melchior, Miłowit, Norman, Rafaela i Wiltruda.
                    Irak – Święto Armii
                    Irlandia – Małe Boże Narodzenie
                    Francja – Święto Rodziny(odpowiednik Dnia Dziecka)
                    Kościół prawosławny – wigilia Narodzenia Chrystusa
                    Laos – Dzień Pathet Lao
                    Polska – Dzień Filatelisty
                    ', CAST(N'2016 - 01 - 06' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(7, N'Imieniny obchodzą: Chociesław, Julian, Kanut, Kryspin, Lucjan, Łucjan, Mateusz, Nicetas, Rajmund, Rajmunda, Rajnold, Teodor, Walenty, Walentyn i Wirginia.
                    Kambodża – Dzień Wyzwolenia
                    Kościół prawosławny – Narodzenie Chrystusa(jedno z 12 głównych świąt)
                    Włochy – Dzień Flagi Narodowej
                    ', CAST(N'2016 - 01 - 07' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(8, N'Imieniny obchodzą: Albert, Apolinary, Erhard, Heladia, Heladiusz, Laurencjusz, Laurenty, Maksym, Mroczysław, Mścisław, Seweryn, Teofil i Wawrzyniec.
                    Mariany Północne – Dzień Wspólnoty Narodów.
                    Monako – Święto Niepodległości
                    ', CAST(N'2016 - 01 - 08' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(9, N'Imieniny obchodzą: Adrian, Adrianna, Alicja, Antoni, Bracsław, Julian, Marcelin, Marcjanna, Mścisława, Piotr i Przemir.
                    Panama – Dzień Męczenników
                    Polska – Dzień Ligi Ochrony Przyrody
                    Republika Serbska w Bośni i Hercegowinie – Dzień Republiki.
                    ', CAST(N'2016 - 01 - 09' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(10, N'Imieniny obchodzą: Agaton, Anna, Dobrosław, Egidia, Grzegorz, Idzi, Jan, Kolumba, Leonia, Marcjan, Mojmir, Nikanor, Nikanora, Paweł, Petroniusz, Piotr i Wilhelm.
                    Benin – Święto Suwerenności Ludowej
                    ', CAST(N'2016 - 01 - 10' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(11, N'Imieniny obchodzą: Anastazy, Feliks, Hilary, Honorata, Hortensja, Hortensjusz, Hygin, Krzesimir, Małomir, Matylda, Mechtylda, Melchiades, Odon, Palemon, Palemona, Paulin, Salwiusz, Teodozjusz, Teodozy, Tezeusz i Tomasz
                    Maroko – Uroczystość Deklaracji Niepodległości
                    Nepal – Dzień Jedności Narodowej
                    Polska – Dzień Wegetarian
                    ', CAST(N'2016 - 01 - 11' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(12, N'Imieniny obchodzą: Aelred, Antoni, Arkadia, Arkadiusz, Arkady, Benedykt, Bernard, Bonet, Bonita, Bonitus, Cezaria, Czasława, Czesława, Ernest, Eutropiusz, Greta, Jan, Małgorzata, Piotr, Stomir, Tacjana, Tygriusz, Wiktorian i Wiktoriana.
                    Tanzania – Uroczystość Upamiętnienia Rewolucji Zanzibaru
                    ', CAST(N'2016 - 01 - 12' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(13, N'Imieniny obchodzą: Bogumił, Bogusąd, Falisław, Glafyra, Godfryd, Gotfryd, Hilary, Judyta, Leoncjusz, Melania, Remigia, Remigiusz i Weronika.
                    Togo – Dzień Wolności
                    ', CAST(N'2016 - 01 - 13' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(14, N'Imieniny obchodzą: Amadea, Dacjusz, Feliks, Helga, Hilary, Krystiana, Makryna, Malachiasz, Mściwuj, Nina, Odoryk, Piotr, Radogost, Rajner i Saba.
                    Światowy Dzień Migranta i Uchodźcy
                    Kościół prawosławny – „stary” Nowy Rok
                    ', CAST(N'2016 - 01 - 14' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(15, N'Imieniny obchodzą: Aleksander, Arnold, Dalemir, Dąbrówka, Dobrawa, Domasław, Domosław, Eligia, Eligiusz, Franciszek, Habakuk, Ida, Jan, Makary, Maksym, Maur, Micheasz, Paweł i Piotr.
                    Korea Północna – Dzień Alfabetu Koreańskiego
                    Malawi – Dzień Johna Chilenbwe
                    IAL – Interlingua – Dzień Interlingwy(Le die de Interlingua)
                    Wikipedia – Dzień Wikipedii
                    ', CAST(N'2016 - 01 - 15' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(16, N'Imieniny obchodzą: Furzeusz, Gonsalwy, Hilary, Honorat, Marceli, Otto, Otton, Piotr, Treweriusz, Trzebowit, Tycjan, Tycjana, Waleriusz, Włodzimierz, Włodzimir i Włodzimira
                    Tajlandia – Dzień Nauczyciela
                    ', CAST(N'2016 - 01 - 16' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(17, N'Imieniny obchodzą: Alba, Antoni, Jan, Julian, Merul, Przemił, Rosław, Rosława, Rościsław, Rozalinda, Sulpicja, Sulpicjusz, Teodor
                    Demokratyczna Republika Konga – Dzień Patrice’a Lumumby
                    ', CAST(N'2016 - 01 - 17' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(18, N'Imieniny obchodzą: Ammonia, Ammoniusz, Atenogenes, Beatrycze, Bogumił, Krystyna, Liberata, Lubart, Małgorzata, Monika, Piotr, Pryska, Regina, Sędziwoj, Wenerand, Woluzjan i Zuzanna.
                    Społecznościowe – Dzień Kubusia Puchatka(na pamiątkę urodzin swojego twórcy A.A.Milne’a)
                    ', CAST(N'2016 - 01 - 18' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(19, N'Imieniny obchodzą: Abundancja, Adalryk, Alderyk, Basjan, Basjana, Bernard, Erwin, Erwina, Eufemia, Germana, Germanik, Geroncjusz, Henryk, Jan, Januariusz, January, Józef, Juliusz, Kaliksta, Kalista, Kanut, Marceli, Mariusz, Marta, Matylda, Paweł, Pia, Poncjan, Racimir, Sara, Saturnin i Wulstan
                    Kościół prawosławny – Objawienie połączone z Chrztem Pańskim(jedno z 12 głównych świąt zwane potocznie Epifanią lub świętem Jordanu)
                    Laos – Święto Armii
                    ', CAST(N'2016 - 01 - 19' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(20, N'Imieniny obchodzą: Dobiegniew, Dobroniega, Dobrożyźń, Dobrzegniew, Eutymiusz, Euzebiusz, Fabian, Fabiana, Maur i Sebastian.
                    Azerbejdżan – Dzień Męczenników
                    Gwinea Bissau, Republika Zielonego Przylądka – Dzień Bohaterów
                    Mali – Święto Armii
                    ', CAST(N'2016 - 01 - 20' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(21, N'Imieniny obchodzą: Agnieszka, Awit, Awita, Długomił, Epifani, Epifaniusz, Eulogia, Eulogiusz, Jan Chrzciciel, Jarosław, Jarosława, Jerosława, Józef, Józefa, Krystiana, Meinrad, Patrokles, Publiusz i Sobiesława.
                    Bułgaria, Polska – Dzień Babci
                    Barbados – Dzień Errola Barrowa
                    Dominikana – Święto Matki Boskiej z Altagracia
                    ', CAST(N'2016 - 01 - 21' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(22, N'Imieniny obchodzą: Anastazy, Dobromysł, Dominik, Dorian, Gaudencjusz, Gaudenty, Jutrogost, Kasandra, Laura, Mateusz, Sulisław, Uriel i Wincenty.
                    Polska – Dzień Dziadka
                    Saint Vincent i Grenadyny – Święto Saint Vincent i Grenadyn
                    Ukraina – Dzień Jedności Ukrainy
                    ', CAST(N'2016 - 01 - 22' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(23, N'Imieniny obchodzą: Agatangel, Akwila, Anicet, Aniceta, Bartłomiej, Bernard, Daniel, Emerencja, Filip, Henryk, Ildefons, Jan, Kadok, Klemens, Konstanty, Łukasz, Maksym, Maria, Michał, Onufry, Rajmund, Rajmunda, Sewerian, Uniemir, Wincenty i Wrocsława.
                    ', CAST(N'2016 - 01 - 23' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(24, N'Imieniny obchodzą: Babilas, Chwalibog, Felicjan, Franciszek Salezy, Ksenia, Milena, Mirogniew, Rafał, Urban, Teodor, Tymoteusz i Wera.
                    Światowy Dzień Środków Masowego Przekazu
                    Togo – Dzień Gospodarczego Wyzwolenia
                    ', CAST(N'2016 - 01 - 24' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(25, N'Imieniny obchodzą: Ananiasz, Apollon, Artemia, Barcław, Emanuel, Emanuela, Juwentyn, Maksym, Miłobor, Miłosz, Paweł, Pęcisława i Projektus.
                    Polska:

                    Dzień Sekretarki i Asystentki(również 25 kwietnia)
                    Dzień Kryptologii(od 2008)



                    Rosja – Dzień Tatiany
                    Szkocja i Irlandia Północna – Noc Burnsa(gael.&#160;Burns Nicht; 25 stycznia lub w okolicach tego dnia)
                    Kościół Starokatolicki w RP – Uroczystość Patrona Kościoła Św.Pawła Apostoła
                    ', CAST(N'2016 - 01 - 25' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(26, N'Imieniny obchodzą: Andrzej, Ksenofont, Leon, Leona, Małostryj, Paula, Skarbimir, Teogenes, Tymoteusz, Tytus i Żeligniew.
                    Australia – Święto Australii
                    Dominikana – Urodziny Juana Pablo Duarte
                    Indie – Święto Republiki
                    Międzynarodowe – Światowy Dzień Celnictwa(od 1953, w Polsce od 1992)
                    Polska – Dzień Transplantacji
                    Uganda – Rocznica Rządu
                    ', CAST(N'2016 - 01 - 26' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(27, N'Imieniny obchodzą: Adalruna, Alruna, Chryzostom, Dacjusz, Datyw, Elwira, Henryk, Jan, Jerzy, Julian, Leander, Lotar, Natalis, Ninomysł, Przemysław, Przybysław, Przybyrad, Rozalia, Teodoryk i Witalian .
                    Międzynarodowe – Międzynarodowy Dzień Pamięci o Ofiarach Holokaustu(ustanowione w 2005 przez Zgromadzenie Ogólne ONZ)
                    ', CAST(N'2016 - 01 - 27' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(28, N'Imieniny obchodzą: Augustyn, Blizbor, Boguwola, Flawian, Jakub, Julian, Kalinik, Karol, Krzesąd, Leonid, Manfred, Manfreda, Maria, Olimpia, Piotr, Radomir, Roger, Świedarg, Tomasz, Tyrs, Waleriusz i Walery.
                    Europa – Dzień Ochrony Danych Osobowych(od 1997)
                    Armenia – Dzień Wojska
                    Rwanda – Dzień Demokracji
                    ', CAST(N'2016 - 01 - 28' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(29, N'Imieniny obchodzą: Aniela, Bolesława, Bona, Ewangelina, Gildas, Ismena, Konstancjusz, Maur, Papiasz, Sabrina, Sulpicja, Sulpicjusz, Waleriusz, Wielisława, Zdziesław, Zdzisław i Żelisław.
                    Nepal – Dzień Męczenników
                    ', CAST(N'2016 - 01 - 29' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(30, N'Imieniny obchodzą: Adalgunda, Adelajda, Aldegunda, Aleksander, Batylda, Bronisław, Cyntia, Dobiegniew, Dobrogniewa, Feliks, Gerard, Gerarda, Hiacynta, Maciej, Marcin, Martyna, Piotr, Sebastian i Teofil.
                    Indie – Światowy Dzień Trędowatych, obchodzony w rocznicę śmierci Mahatmy Gandhiego(w pozostałych krajach obchodzony w ostatnią niedzielę stycznia)
                    ', CAST(N'2016 - 01 - 30' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(31, N'Imieniny obchodzą: Cyrus, Emma, Euzebiusz, Franciszek Ksawery, Geminian, Jan, Ksawery, Ludwika, Marcela, Melaniusz, Rościgniew, Smysława i Spycigniew.
                    Nauru – Święto Niepodległości
                    Celtowie – wigilia Imbolc
                    ', CAST(N'2016 - 01 - 31' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(32, N'Imieniny obchodzą: Brygida, Cecyliusz, Dziadumiła, Emil, Paweł, Pioniusz, Piotr, Prosimir, Sewer, Siemirad, Weridiana, Winand, Winanda, Wirydiana, Zybart, Zybert, Zybracht, Zygbert i Żegota
                    Irlandia, Szkocja – Imbolc(Dzień Świętej Brygidy) święto celtyckie
                    Mauritius – Rocznica zniesienia niewolnictwa
                    ', CAST(N'2016 - 02 - 01' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(33, N'Imieniny obchodzą: Andrzej, Berwin, Ermentruda, Filip, Franciszek, Gonsalwy, Jan, Joanna, Katarzyna, Kornel, Korneli, Korneliusz, Laurencjusz, Laurenty, Marcin, Maria, Markwart, Mikołaj, Miłosław, Miłosława, Piotr, Stefan, Symeon, Teodoryk, Teofan, Wawrzyniec i Werner.
                    Kanada, USA – Dzień Świstaka
                    Międzynarodowe – Światowy Dzień Mokradeł(zw.również Światowym Dniem Obszarów Wodno - Błotnych na mocy konwencji ramsarskiej)
                    Polska – Dzień Handlowca
                    Rosja – Dzień Chwały Wojennej
                    ', CAST(N'2016 - 02 - 02' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(34, N'Imieniny obchodzą: Ansgar, Ansgary, Błażej, Błażeja, Celeryn, Celeryna, Hipolit, Hipolita, Ignacy, Jan, Klaudyna, Maksym, Ofelia, Oskar, Telimena, Uniemysł, Uniesława i Wawrzyniec.
                    Mozambik – Dzień Bohaterów
                    Wietnam – Rocznica Utworzenia Partii Komunistycznej
                    Wyspy Świętego Tomasza i Książęca – Dzień Męczenników
                    ', CAST(N'2016 - 02 - 03' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(35, N'Imieniny obchodzą: Andrzej, Awentyn, Częstogoj, Eustachia, Eustachiusz, Eustachy, Gilbert, Izyda, Izydor, Jan, Joanna, Józef, Mariusz, Weronika i Witosława.
                    Angola – Początek Zbrojnego Powstania
                    Sri Lanka – Święto Niepodległości
                    Międzynarodowe – Światowy Dzień Walki z Rakiem
                    ', CAST(N'2016 - 02 - 04' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(36, N'Imieniny obchodzą: Adelajda, Agata, Albwin, Awit, Awita, Dobiemir, Elpin, Indracht, Jakub, Lubodrog, Modest, Przybygniew, Rodomił, Saba i Strzeżysława.
                    Burundi – Dzień Jedności
                    daw.Imperium Rosyjskie – święto Orderu św.Anny
                    Meksyk – Święto Konstytucji
                    San Marino – Dzień Św.Agaty
                    Tanzania – Dzień Chama Cha Mapinduzi
                    ', CAST(N'2016 - 02 - 05' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(37, N'Imieniny obchodzą: Amand, Amanda, Antoni, Bogdan, Bogdana, Bohdan, Bohdana, Dorota, Gaston, Joachim, Leon, Leona, Paweł, Szymon, Tytus, Wedast i Zdziewit.
                    Jamajka – święto narodowe(Dzień Boba Marleya)
                    Laponia – święto narodowe
                    Nowa Zelandia, Niue, Tokelau – Rocznica Traktatu z Waitangi
                    Międzynarodowe – Międzynarodowy Dzień Zerowej Tolerancji dla Okaleczania Żeńskich Narządów Płciowych(od 2003)
                    ', CAST(N'2016 - 02 - 06' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(38, N'Imieniny obchodzą: Alfons, Antoni, Awa, Egidia, Egidiusz, Eugenia, Idzi, Jakub, Jan, Mojżesz, Partenia, Parteniusz, Romeusz, Romuald, Rozalia, Ryszard, Sulimir, Sulisław, Teodor i Wilhelm
                    Grenada – Święto Niepodległości
                    ', CAST(N'2016 - 02 - 07' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]([GlobalEventId], [Content], [DateTime]) VALUES(39, N'Imieniny obchodzą: Ampeliusz, Gabriela, Gniewomir, Gniewosądka, Hieronim, Honorat, Izajasz, Jan, Józefina, Juwencja, Juwencjusz, Lucjusz, Łucjusz, Mirogniew, Paweł, Piotr, Polikarp, Salomon, Sebastian i Stefan.
                    Polska – Święto Służby Więziennej(od 2011 roku; wcześniej obchodzone 26 kwietnia)
                    Irak – Święto Rewolucji
                    Słowenia – Dzień Kultury Słoweńskiej
                    Romowie – Zniesienie Niewolnictwa
                    ', CAST(N'2016 - 02 - 08' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(40, N'Imieniny obchodzą: Ansbert, Apolonia, Bernard, Cyryl, Donat, Felicjan, Gorzysław, Jakub, Marian, Nikifor, Pelagia, Pryma, Prymus, Reginald, Sabin i Sulisława.
                    Międzynarodowy Dzień Pizzy
                    Liban – Dzień św. Marona
                    ', CAST(N'2016-02-09' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (41, N'Imieniny obchodzą: Apollon, Elwira, Gabriel, Haralampia, Haralampiusz, Jacek, Jacenty, Michał, Scholastyka, Sotera, Tomił, Tomisława, Trojan i Wilhelm.
                    Rosja – Dzień Dyplomaty
                    ', CAST(N'2016-02-10' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (42, N'Imieniny obchodzą: Adolf, Adolfa, Benedykt, Bernadeta, Bertrada, Cedmon, Dezyderia, Dezyderiusz, Dezydery, Grzegorz, Heloiza, Jonasz, Lucjusz, Łazarz, Łucjusz, Maria, Olgierd, Paschalis, Sekundyn, Seweryn, Świętomira, Teodora i Wiktoria.
                    Iran – Święto Rewolucji
                    Japonia – Dzień Założenia Cesarstwa
                    Kamerun – Dzień Młodzieży
                    Liberia – Święto Sił Zbrojnych
                    międzynarodowe – Międzynarodowy Dzień Kobiet i Dziewcząt w Nauce (ustanowiony w 2015 przez ONZ)
                    Polska – Dzień Dokarmiania Zwierzyny Leśnej
                    Unia Europejska – Europejski Dzień Numeru 112
                    USA – Dzień Wynalazców ustanowiony przez prezydenta Ronalda Reagana w 1983, w dniu urodzin Thomasa Edisona(Europejski Dzień Wynalazcy obchodzony jest 9 listopada)
                    Watykan – Rocznica Traktatów Laterańskich
                    ', CAST(N'2016-02-11' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(43, N'Imieniny obchodzą: Aleksy, Ammonia, Ammoniusz, Ampelia, Ampeliusz, Antoni, Bartłomiej, Benedykt, Bonfilia, Bonfiliusz, Damian, Datyw, Etelwold, Eulalia, Ewa, Feliks, Gaudenty, Gerard, Grzegorz, Hilarion, Hilariona, Humbelina, Jakub, Jan, Julian, Juwencjusz, Laurenty, Ludan, Ludwik, Maryna, Melecjusz, Mikołaj, Modest, Norma, Paweł, Radosław, Saturnin, Saturnina, Tomasz i Trzebiesława.
                    Mjanma – Święto Unii
                    Międzynarodowe:


                    Dzień Darwina
                    Międzynarodowy Dzień Walki z Wykorzystaniem Dzieci jako Żołnierzy (ang.International Children’s Day-Soldiers, od 12 lutego 2002 – kampania Red Hand Day)


                    ', CAST(N'2016-02-12' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(44, N'Imieniny obchodzą: Beatrycze, Benignus, Benigny, Emnilda, Eulogiusz, Fulkran, Gilbert, Grzegorz, Humbelina, Jakub, Jan, Jordan, Jordana, Julian, Kastor, Katarzyna, Krystyna, Licyniusz, Martynian, Maura, Paweł, Polieukt, Stefan i Toligniew.
                    Międzynarodowe – Światowy Dzień Radia (od 2012 proklamowany przez UNESCO)
                    ', CAST(N'2016-02-13' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(45, N'Imieniny obchodzą: Abraham, Adolf, Adolfa, Antonin, Auksencja, Auksencjusz, Auksenty, Cyryl, Dionizja, Dionizy, Dobiesława, Eleukadiusz, Flawian, Florentyn, Jan Chrzciciel, Jerzy, Jordan, Józef, Konrad, Konrada, Krystyna, Liliana, Lilianna, Lilla, Maro, Maron, Metody, Mikołaj, Modest, Niedamir, Niedomira, Niemir, Nostrian, Piotr, Teodozja, Teodozjusz, Teodozy, Walenty, Walentyn, Wincenty, Witalis i Zenon.
                    Bałkany – Trifon Zarezan
                    Międzynarodowe – Walentynki
                    Polska – Dzień Chorego na Padaczkę
                    ', CAST(N'2016-02-14' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (46, N'Imieniny obchodzą: Faust, Faustyn, Galfryd, Gliceriusz, Glicery, Joachim, Jordan, Jordana, Jowita, Józef, Julia, Klaudiusz, Onezym, Pakosław, Pakosława, Przybyrad, Saturnin, Sewer, Teogenes, Wirginia, Zygfryd, Zygfryda i Żywila.
                    Kanada – Dzień Flagi
                    Kościół prawosławny:


                    Spotkanie Pańskie (jedno z 12 głównych świąt)
                    Światowy Dzień Młodzieży Prawosławnej


                    Międzynarodowe – Międzynarodowy Dzień Walki z Rakiem Dzieciństwa
                    Międzynarodowy Dzień Wyszehradzki
                    dawn.rzymskie święto – Luperkalia
                    Serbia – Święto Narodowe
                    ', CAST(N'2016-02-15' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (47, N'imieniny obchodzą: Bernard, Czcisław, Daniel, Danuta, Dominik, Eliasz, Filipa, Flawian, Gilbert, Izajasz, Jarema, Jeremi, Jeremiasz, Julian, Juliana, Julianna, Józef, Ludan, Marcjan, Maria, Marian, Marut, Maruta, Marutas, Mikołaj, Onezym, Pamfil, Porfiriusz, Porfiry, Przedsława, Samuel, Symeon, Szymon, Teodul, Wirydiana i Zoe.
                    Korea Północna – Urodziny Kim Dzong Ila
                    Litwa – Święto Niepodległości
                    ', CAST(N'2016-02-16' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (48, N'Imieniny obchodzą: Aleksja, Aleksy, Anastazy, Bartłomiej, Benedykt, Bonfilia, Bonfiliusz, Donat, Faustyn, Fintan, Flawian, Franciszek, Gerard, Hermogenes, Hugo, Jan, Julian, Klemens, Konstanty, Łukasz, Marianna, Michał, Niegowoj, Polichroniusz, Reginald, Romulus, Sylwan, Sylwin, Sylwina, Teodulf, Wilhelm i Zbigniew.
                    daw.Cesarstwo rzymskie – Kwirynalia (łac.Quirinalia); także Święto Głupców(łac.festum stultorum)
                    Kosowo – Dzień Niepodległości Kosowa
                    Międzynarodowe – Światowy Dzień Kota
                    ', CAST(N'2016-02-17' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(49, N'Imieniny obchodzą: Agapit, Albert, Aleksander, Antoni, Bernadeta, Flawia, Flawian, Flawiusz, Franciszek, Gertruda, Heladia, Heladiusz, Jan, Klaudiusz, Konstancja, Konstantyna, Kosma, Lucjusz, Łucjusz, Maksym, Marcin, Mojżesz, Sylwan, Symeon, Wespazjan, Więcesława i Wilhelm.
                    1. dzień roku według kalendarza Kalijugi, liczonego od wielkiej bitwy na polu Kuru (Indie) w 3102 p.n.e.
                    Gambia – Święto Niepodległości
                    ', CAST(N'2016-02-18' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (50, N'Imieniny obchodzą: Alwar, Arnold, Barbacy, Barbat, Beat, Biecsława, Bonifacy, Czcisław, Gawin, Henryk, Jerzy, Józef, Julian, Konrad, Konrada, Leoncjusz, Łucja, Manswet, Marceli, Publiusz, Tuliusz i Walery.
                    Nepal – Święto Demokracji
                    Turkmenistan – Święto Flagi
                    ', CAST(N'2016-02-19' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (51, N'Imieniny obchodzą: Amata, Aulus, Eleuteria, Eleuteriusz, Eleutery, Elżbieta, Euchariusz, Euchary, Eustachiusz, Eustachy, Falkon, Franciszek, Hiacynta, Jan, Julia, Leon, Leona, Lubomir, Ludomił, Ludomiła, Ludomir, Nila, Nilus, Peleusz, Serapion, Siestrzewit, Sylwan, Ulryk, Walery i Zenobiusz
                    Międzynarodowe

                    Międzynarodowy Dzień Palących Fajkę (ang.International Pipe Smoking Day, w Polsce, jako Dzień Fajczarzy)
                    Światowy Dzień Sprawiedliwości Społecznej(od 2009 ustanowiony przez Zgromadzenie Ogólne ONZ)


                    ', CAST(N'2016-02-20' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(52, N'Imieniny obchodzą: Eleonora, Feliks, Fortunat, Gumbert, Henryka, Kiejstut, Natalis, Piotr, Robert, Sewerian, Wyszeniega i Wyszetrop.
                    dawn.Cesarstwo rzymskie – Feralia
                    Bangladesz – Dzień Męczenników
                    Barbados – Dzień Rihanny
                    Międzynarodowe – Międzynarodowy Dzień Języka Ojczystego (UNESCO)
                    ', CAST(N'2016-02-21' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (53, N'Imieniny obchodzą: Chociebąd, Jakub, Konkordia, Maksymian, Małgorzata, Marold, Marwald, Nikifor, Papiasz, Paschazy, Wiktor i Wrocisław.
                    Międzynarodowe:


                    Dzień Myśli Braterskiej (symboliczne święto przyjaźni pomiędzy skautami i harcerzami obchodzone na całym świecie w rocznicę urodzin Roberta Baden-Powella).
                    Europejski Dzień Ofiar Przestępstw


                    Katar – Rocznica Intronizacji Emira
                    Polska – Dzień Ofiar Przestępstw
                    Saint Lucia – Święto Niepodległości
                    Starożytny Rzym – Caristia ceremonia, która kończyła Parentalia ku czci zmarłych przodków.
                    ', CAST(N'2016-02-22' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (54, N'Imieniny obchodzą: Będzimir, Damian, Damiana, Feliks, Florentyn, Izabela, Łazarz, Marta, Milburga, Montan, Polikarp, Prymian, Romana i Stefan.
                    daw.Cesarstwo Rzymskie – Terminalia
                    Brunei – Święto Narodowe
                    Gujana – Święto Republiki
                    Polska – Ogólnopolski Dzień Walki z Depresją
                    Rosja – Dzień Obrońcy Ojczyzny
                    Tadżykistan – Święto Armii
                    ', CAST(N'2016-02-23' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (55, N'Imieniny obchodzą: Bogurad, Borzygniew, Ermegarda, Flawian, Irmegarda, Jan, Józefa, Julian, Lucjusz, Łucjusz, Maciej, Marek, Modest, Montan, Sergiusz i Wieledrog.
                    Estonia – Święto Niepodległości
                    Meksyk – Dzień Flagi
                    ', CAST(N'2016-02-24' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (56, N'Imieniny obchodzą: Adam, Antonina, Bolebor, Cezariusz, Cezary, Dioskur, Donat, Gromisław, Herena, Just, Konstancjusz, Lubart, Modest, Nicefor, Papiasz, Romeusz, Serapion, Tarazjusz, Tolisław, Tolisława, Walburga, Wiktor i Wiktoryn.
                    Kuwejt – Święto państwowe
                    ', CAST(N'2016-02-25' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (57, N'Imieniny obchodzą: Aleksander, Bogumił, Dionizy, Faustynian, Gerlinda, Klaudian, Lutmiar, Lutosława, Mirosław, Mirosława, Nikolina, Nestor, Otokar, Porfiriusz i Porfiry.
                    Kuwejt – Święto Wyzwolenia
                    ', CAST(N'2016-02-26' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (58, N'Imieniny obchodzą: Achacy, Achacjusz, Anna, Auksencja, Auksencjusz, Auksenty, Baldomer, Baldomera, Bazyli, Gabriel, Honoryna, Julian, Leander, Leandra, Orfeusz, Prokop, Sierosława i Sirosława.
                    Dominikana – Święto Niepodległości
                    Międzynarodowe – Międzynarodowy Dzień Niedźwiedzia Polarnego (ang.International Polar Bear Day, akcja ratowania niedźwiedzi polarnych organizowana przez Polar Bears International i Arctic Ambassador Centers w ramach projektu Arctic Document Project)
                    ', CAST(N'2016-02-27' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(59, N'Imieniny obchodzą: Antonia, August (w latach nieprzestępnych), Bogurad, Falibog, Gaja, Gajusz, Hilary, Józef, Kaja, Lech, Ludomir, Makary, Nadbor, Oswald, Roman, Sylwana i Tymoteusz.
                    Andaluzja – Święto Andaluzji
                    Finlandia – Dzień Kalevali
                    Międzynarodowe – Dzień Chorób Rzadkich (w latach przestępnych 29 lutego; zapoczątkowany przez Europejską Federację Rodziców Pacjentów i Pacjentów z rzadkimi chorobami – EURORDIS)
                    ', CAST(N'2016-02-28' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(60, N'Imieniny obchodzą: Antonia, August, Dobrosiodł, Oswald i Roman
                    Międzynarodowe – Dzień Chorób Rzadkich (28 lutego, gdy rok ma 365 dni; zapoczątkowany przez Europejską Federację Rodziców Pacjentów i Pacjentów z rzadkimi chorobami – EURORDIS)
                    ', CAST(N'2016-02-29' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(61, N'Imieniny obchodzą: Albin, Aldona, Antoni, Budzisław, Dawid, Eudokia, Eudoksja, Feliks, Herakles, Herkulan, Herkules, Joanna, Józef, Leon, Leona, Radosław i Switbert.
                    dawne rzymskie święto – Matronalia (pierwowzór Dnia Kobiet)
                    Baleary – Święto Balearów
                    Bośnia i Hercegowina – Święto Niepodległości
                    Bułgaria – Martenica
                    Korea Południowa – Dzień Marszu ku Niepodległości
                    Międzynarodowe

                    Światowy Dzień Obrony Cywilnej(od 1990)
                    Światowy Dzień Świadomości Autoagresji
                    Zero dla Dyskryminacji(ONZ od 2014)


                    Mołdawia – Martsishor
                    Polska – Narodowy Dzień Pamięci „Żołnierzy Wyklętych”
                    Walia – Dzień św.Dawida, patrona Walii
                    Wyspy Marshalla – Dzień Ofiar Bomby Atomowej
                    ', CAST(N'2016-03-01' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (62, N'Imieniny obchodzą: Absalon, Agnieszka, Franciszek, Helena, Henryk, Januaria, Karol, Krzysztof, Łukasz, Michał, Paweł, Prosper i Radosław.
                    Mjanma – Dzień Rolników
                    Etiopia – Święto Zwycięstwa pod Aduą
                    ', CAST(N'2016-03-02' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (63, N'Imieniny obchodzą: Agrypin, Asteriusz, Eutropiusz, Gerwin, Gerwina, Hieronim, Innocenty, Jakub, Katarzyna, Kleonik, Kleonika, Kolumba, Kunegunda, Marcjusz, Maryn, Maryniusz, Piotr, Samuel, Teodor, Teresa, Tycjan, Tycjana i Wirzchosława.
                    Bułgaria – Święto Wyzwolenia
                    Gruzja – Dzień Matki
                    Japonia – Dzień Dziewczynek (jap.Hinamatsuri, odpowiednik Dnia Dziecka)
                    Libia – Deklaracja Władzy Ludowej
                    Malawi – Dzień Męczenników
                    Międzynarodowe – Międzynarodowy Dzień dla Ucha i Słuchu(z inicjatywy WHO)
                    Sudan – Dzień Jedności Narodowej
                    ', CAST(N'2016-03-03' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(64, N'Imieniny obchodzą: Adrian, Adrianna, Arkadia, Arkadiusz, Arkady, Gerard, Gerarda, Humbert, Jakubina, Kazimierz, Leonard, Lucjusz, Łucjusz, Nestor, Piotr, Placyda i Witosław.
                    Litwa – Kaziuki (wileński jarmark odpustowy z okazji święta św. Kazimierza)
                    Międzynarodowe – Światowy Dzień Tenisa
                    ', CAST(N'2016-03-04' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(65, N'Imieniny obchodzą: Adrian, Adrianna, Adriana, Fokas, Fryderyk, Gerazym, Jan, Jeremiasz, Konon, Krzysztof, Marek, Oliwia, Pakosław, Teofil, Wergilia, Wergiliusz, Wirgilia, Wirgiliusz i Wolimir
                    Kornwalia – Dzień św. Pirana
                    Polska:


                    Dzień Teściowej
                    Dzień Geodety Europejskiego i Geoinformacji (od 2012 z inicjatywy Europejskiej Organizacji Geodetów z okazji 500. rocznicy urodzin Gerarda Merkatora)
                    Dzień Dentysty


                    ', CAST(N'2016-03-05' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(66, N'Imieniny obchodzą: Będzimysł, Cymbarka, Cyryl, Eugenia, Frydolin, Jordan, Jordana, Koleta, Konon, Róża i Wiktor.
                    Ghana – Święto Niepodległości
                    Norfolk – Dzień Utworzenia
                    państwa członkowskie Unii Europejskiej


                    Europejski Dzień Logopedy (fr.CPLOL, zał. 8 marca 1988&#160;r. – Komitet Łącznikowy Terapeutów Mowy /Logopedów Unii Europejskiej, Polska od 2007)
                    Europejski Dzień Pamięci o Sprawiedliwych, czyli osobach, które ratowały Żydów w czasie Holocaustu (ustanowiony 10 maja 2012 r.decyzją Parlamentu Europejskiego z inicjatywy włoskiego Komitetu Światowego Ogrodu Sprawiedliwych – Gariwo)


                    Teksas – Dzień Alamo
                    ', CAST(N'2016-03-06' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(67, N'Imieniny obchodzą: Bazyli, Efrem, Elpidia, Elpidiusz, Eubul, Eugeniusz, German, Felicyta, Morzysław, Nadmir, Paweł, Perpetua, Teofilakt, Teresa i Tomasz
                    Albania – Dzień Nauczyciela
                    ', CAST(N'2016-03-07' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (68, N'Imieniny obchodzą: Antoni, Apoloniusz, Arian, Beata, Feliks, Filemon, Filemona, Franciszek, Herenia, Jan, Julian, Miłogost, Poncjusz, Stefan, Szymon, Teotyk i Wincenty
                    Albania, Bośnia i Hercegowina, Serbia, Czarnogóra, Słowenia, Macedonia, Bułgaria, Rumunia – Dzień Matki
                    Międzynarodowe

                    Dzień Kobiet
                    Międzynarodowy Dzień Praw Kobiet i Pokoju na Świecie


                    Syria – Święto Rewolucji
                    ', CAST(N'2016-03-08' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (69, N'Imieniny obchodzą: Dominik, Franciszka, Grzegorz, Kandyd, Katarzyna, Mścisława, Przemyślibor i Samanta
                    Belize – Dzień Barona Blissa
                    Polska – Dzień Statystyki Polskiej
                    ', CAST(N'2016-03-09' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (70, N'Imieniny obchodzą: Aleksander, Cyprian, Eugenia, Gaja, Gajusz, Makary, Piotr, Porfirion, Symplicjusz, Symplicy i Zwnisława.
                    Birma – Święto Pory Bezdeszczowej
                    USA – Narodowy Dzień Spódnicy (ang.National Skirt Day – NSD, po raz pierwszy obchodzony 10 marca 1998 r., amer.sposób zapisu daty: 03.10.1998 w Polsce obchodzony 30 października)
                    ', CAST(N'2016-03-10' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(71, N'Imieniny obchodzą: Balbina, Benedykt, Dominik, Drogosława, Eulogiusz, Eutymiusz, Jan, Kandyd, Konstanty, Konstantyn, Nawoj, Sofroniusz, Sylwia, Świetlana, Tala, Talus, Teresa i Trofim.
                    Lesotho – Dzień Króla Moshoeshoe I
                    Litwa – Dzień Odrodzenia Niepodległości
                    Polska – Dzień Sołtysa (lokalnie inne terminy)
                    Kościół Polskokatolicki w RP – Święto Kościoła Narodowego
                    ', CAST(N'2016-03-11' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(72, N'Imieniny obchodzą: Alojzy, Bernard, Blizbor, Grzegorz, Innocenty, Józefina, Justyna, Maksymilian, Piotr i Teofan
                    dawne szkolne święto Gregorianki
                    Burundi – Święto Pracy
                    Gabon – Dzień Odnowienia
                    Liberia – Dzień Odznaczeń
                    Mauritius – Święto Niepodległości
                    ', CAST(N'2016-03-12' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (73, N'Imieniny obchodzą: Anioł, Bożena, Bratomir, Cieszymysł, Ernest, Kasjan, Krystyna, Letycja, Marek, Patrycja, Roderyk, Sabin, Salomon, Trzebiesław i Trzebisław
                    ', CAST(N'2016-03-13' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (74, N'Imieniny obchodzą: Afrodyzja, Afrodyzjusz, Afrodyzy, Bożeciecha, Eutychiusz, Ewa, Fawila, Jakub, Leon, Leona, Łazarz, Matylda, Piotr i Pamela.
                    Andora – Święto Konstytucji
                    Estonia – Dzień Języka Estońskiego
                    Korea Południowa, Japonia – Biały Dzień
                    Tajlandia – Święto Słoni
                    Międzynarodowe

                    Międzynarodowy Dzień Sprzeciwu Wobec Tam ang.International Anti-Dam Day (koordynowany przez International Rivers Network z USA, w Polsce przez Klub Gaja)
                    Dzień Liczby Pi(π)


                    ', CAST(N'2016-03-14' AS Date))
                    GO
                    INSERT[dbo].[GlobalEvents]
                            ([GlobalEventId], [Content], [DateTime]) VALUES(75, N'Imieniny obchodzą: Gościmir, Heloiza, Klemens, Krzysztof, Leokrycja, Longin, Longina, Ludwika, Luiza, Matrona, Nikander, Nikandra, Placyd, Probus, Zachariasz i Zachary.
                    Białoruś – Święto Konstytucji
                    Liberia – Urodziny J.J.Robertsa
                    Międzynarodowe – Światowy Dzień Konsumenta
                    Węgry – Rocznica Wiosny Ludów
                    ', CAST(N'2016-03-15' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (76, N'Imieniny obchodzą: Abraham, Agapit, Antoni, Artemia, Budzimir, Cyriak, Dzirżyterg, Gabriel, Herbert, Herybert, Hiacynt, Hilary, Izabela, Julian, Karol, Longin, Miłostryj, Natalis, Patrycjusz, Patrycy, Patryk, Przybymir, Walenty i Walentyn.
                    ', CAST(N'2016-03-16' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (77, N'Imieniny obchodzą: Agrykola, Ambroży, Cieszysław, Gertruda, Józef, Patrycjusz, Patrycy, Patryk, Paweł, Regina, Witburga, Zbigniew, Zbygniew i Zbygniewa.
                    Irlandia – Dzień Świętego Patryka
                    Włochy – Dzień Jedności Narodowej
                    ', CAST(N'2016-03-17' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (78, N'Imieniny obchodzą: Aleksander, Anzelm, Boguchwał, Boguchwała, Celestyna, Cyryl, Edward, Edwarda, Feliks, Krystian, Marta, Narcyz, Salwator i Trofim.
                    Aruba – Święto Hymnu i Flagi Narodowej
                    Nigeria – Dzień Matki
                    ', CAST(N'2016-03-18' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (79, N'Imieniny obchodzą: Bogdan, Jan, Józef, Leoncjusz, Marceli, Marek i Sybillina.
                    Australia – Narodowy Dzień Harmonii
                    Hiszpania:

                    Dzień Ojca (obok Dnia św. Józefa)
                    Święto Ognia (hiszp. Fiesta de Las Fallas)


                    Polska:

                    Dzień Wędkarza
                    Dzień Jedności Kaszubów (od 2004 na pamiątkę pierwszej pisemnej wzmianki o Kaszubach z 19 marca 1238)


                    Włochy – Dzień Ojca
                    ', CAST(N'2016-03-19' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (80, N'Imieniny obchodzą: Aleksander, Aleksandra, Ambroży, Anatol, Archip, Bogusław, Cyriaka, Ermegarda, Eufemia, Fotyna, Hipolit, Irmegarda, Józefa, Klaudia, Klemens, Kutbert, Matrona, Maurycy, Nicetas, Rafał, Wincenty i Wolfram.
                    Tunezja – Święto Niepodległości
                    Międzynarodowe:

                    Międzynarodowy Dzień Astrologii
                    Międzynarodowy Dzień Frankofonii (głównie kraje francuskojęzyczne)
                    Światowy Dzień Ziemi (w niektórych krajach 21 marca, w Polsce – 22 kwietnia)
                    Międzynarodowy Dzień Szczęścia (proklamowany przez Zgromadzenie Ogólne ONZ w 2012)
                    Światowy Dzień Wróbla (ang. World Sparrow Day)
                    Dzień języka francuskiego w ONZ w ramach dni języków


                    ', CAST(N'2016-03-20' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (81, N'Imieniny obchodzą: Benedykta, Filemon, Filemona, Klemencja, Lubomir, Ludomir, Ludomira, Mikołaj, Pafnucy, Serapion i Teodul.
                    Pierwszy dzień kalendarzowej wiosny
                    Święto pogańskie – Jare Święto, Ostara
                    Jordania, Liban, Syria – Dzień Matki
                    Meksyk – Dzień Benito Juáreza
                    Namibia – Święto Niepodległości
                    Międzynarodowe:

                    Międzynarodowy Dzień Walki z Dyskryminacją Rasową (rozpoczyna Tydzień Solidarności z Ludami Zmagającymi się z Rasizmem i Dyskryminacją Rasową, ustanowiony przez Zgromadzenie Ogólne ONZ)
                    Nouruz – (Nowy Dzień) tradycyjne irańskie święto; od 2010 uznane przez Zgromadzenie Ogólne ONZ za święto międzynarodowe
                    Międzynarodowy Dzień Lasów (ustanowiony w 2012 przez Zgromadzenie Ogólne ONZ)
                    Światowy Dzień Zespołu Downa (ustanowiony w 2005 z inicjatywy Europejskiego Stowarzyszenia Zespołu Downa)
                    Światowy Dzień Poezji (z inicjatywy UNESCO)
                    Światowy Dzień Lalkarstwa
                    Dzień Wagarowicza


                    RPA – Dzień Praw Człowieka
                    Tunezja – Dzień Młodzieży
                    ', CAST(N'2016-03-21' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (82, N'Imieniny obchodzą: August, Baldwin, Baldwina, Bazyli, Benwenut, Boguchwał, Bogusław, Bogusława, Godzisław, Katarzyna, Kazimierz, Lea, Oktawian, Paweł, Zachariasz i Zachary
                    Kraje nadbałtyckie – Dzień Morza Bałtyckiego (ang. Baltic Day) na mocy Komisji Helsińskiej, jako element Światowego Dnia Wody
                    Laos – Dzień Partii Ludowej
                    Międzynarodowe – Światowy Dzień Wody
                    Portoryko – Dzień Emancypacji
                    ', CAST(N'2016-03-22' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (83, N'Imieniny obchodzą: Benedykt, Eberhard, Feliks, Józef, Nikon, Pelagia, Piotra, Rebeka, Turybiusz, Wiktorian, Wiktoriana, Wiktorianna i Zbysław.
                    Międzynarodowe – Światowy Dzień Meteorologii (ustanowiony przez Zgromadzenie Ogólne ONZ)
                    Pakistan – Święto Rewolucji Pakistańskiej
                    Polska, Węgry – Dzień Przyjaźni Polsko-Węgierskiej
                    ', CAST(N'2016-03-23' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (84, N'Imieniny obchodzą: Ademar, Aldmir, Aleksander, Bertrada, Dionizy, Dydak, Dzierżysław, Dzierżysława, Dziesława, Dzirżysława, Gabriel, Jan, Józef, Katarzyna, Marek, Oldmir, Romulus, Sewer, Sofroniusz i Szymon.
                    Argentyna – Dzień Pamięci dla Prawdy i Sprawiedliwości
                    Międzynarodowe:

                    Międzynarodowy Dzień Prawa do Prawdy dotyczącej Poważnych Naruszeń Praw Człowieka i Godności Ofiar (ustanowione w 2010 przez Zgromadzenie Ogólne ONZ)
                    Światowy Dzień Gruźlicy (wyznaczony przez Światowe Zgromadzenie WHO w rocznicę poinformowania świata nauki o wyizolowaniu prątka gruźlicy przez Roberta Kocha w 1882)


                    Polska – Narodowy Dzień Życia
                    Narodowy Dzień Pamięci Polaków ratujących Żydów pod okupacją niemiecką - święto państwowe (ustanowione przez senat 14.03.2018).
                    ', CAST(N'2016-03-24' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (85, N'Imieniny obchodzą: Anuncjata, Baroncjusz, Dezyderiusz, Dezydery, Dula, Dyzma, Ireneusz, Jozafata, Kwiryn, Lucja, Lutogniew, Lutomysł, Łucja, Małgorzata, Maria, Mariola, Nikodema, Pelagiusz, Prokop, Sławobora i Wolimir.
                    Białoruś – Dzień Woli
                    Cypr – Dzień Greckiej Niepodległości
                    Grecja – Święto Niepodległości
                    Słowenia – Dzień Matki
                    Międzynarodowe:

                    Międzynarodowy Dzień Solidarności z Uwięzionymi i Zaginionymi Pracownikami ONZ
                    Międzynarodowy Dzień Pamięci Zniesienia Transatlantyckiego Handlu Niewolnikami (ustanowione przez Zgromadzenie Ogólne ONZ w 2006)


                    ', CAST(N'2016-03-25' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (86, N'Imieniny obchodzą: Bazyli, Duszan, Dyzma, Emanuel, Emanuela, Eutychiusz, Feliks, Kwadrat, Larysa, Ludger, Manuela, Montan, Nicefor, Teodor, Teodozjusz, Teodozy i Tworzymir.
                    Bangladesz – Święto Niepodległości
                    Mali – Dzień Męczenników
                    ', CAST(N'2016-03-26' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (87, N'Imieniny obchodzą: Aleksander, Archibald, Augusta, Benedykt, Ernest, Franciszek, Gelazy, Gelazja, Jan, Lidia, Łazarz, Macedoniusz, Narzes, Robert i Rzędzimir.
                    Angola – Dzień Zwycięstwa
                    Mjanma – Święto Sił Zbrojnych
                    Międzynarodowe – Międzynarodowy Dzień Teatru
                    ', CAST(N'2016-03-27' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (88, N'Imieniny obchodzą: Aleksander, Doroteusz, Gedeon, Guntram, Ingbert, Jan, Joanna, Kastor, Krzesisław, Krzysław, Malachiasz, Malkolm, Pryskus, Renata, Rogacjusz, Rogat.
                    Czechy, Słowacja – Dzień Nauczyciela
                    Libia – Uroczystość Opuszczenia Kraju przez Brytyjczyków
                    Republika Południowej Afryki – Dzień Rodziny
                    ', CAST(N'2016-03-28' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (89, N'Imieniny obchodzą: Bertold, Cyryl, Eustacjusz, Eustazja, Eustazjusz, Eustazy, Ludolf, Ludolfina, Marek, Satur, Satura, Stefan, Teodor, Wiktoryn
                    Madagaskar – Rocznica Powstania 1947 roku
                    Republika Środkowoafrykańska – Dzień Barthelemiego Bogandy
                    Polska – Dzień Metalowca (nieoficjalne święto na rynku pracy)
                    ', CAST(N'2016-03-29' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (90, N'Imieniny obchodzą: Amadea, Amadeusz, Amelia, Aniela, Częstobor, Dobromier, Jan, Joachim, Kwiryn, Kwiryna, Leonard, Litobor, Mamertyn, Mamertyna, Piotr, Sekundus i Zozym.
                    Trynidad i Tobago – Dzień Baptystów
                    ', CAST(N'2016-03-30' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (91, N'Imieniny obchodzą: Achacjusz, Achacy, Amos, Balbina, Beniamin, Bonawentura, Dobromiera, Dobromira, Gwido, Gwidon, Joanna, Kornelia i Myślidar
                    Autonomia Palestyńska – Święto Ziemi
                    Malta – Święto Wolności
                    ', CAST(N'2016-03-31' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (92, N'Imieniny obchodzą: Celzjusz, Chionia, Florentyn, Grażyna, Hugo, Hugon, Irena, Jakubina, Katarzyna, Makary, Meliton, Miłość, Teodora, Tomasz, Tomisław, Wenancjusz, Wenanty i Zbigniew.
                    Cypr – Dzień Narodowej Organizacji Cypryjskich Bojowników (EOKA)
                    Iran – Święto Republiki Islamskiej
                    Międzynarodowe:

                    Międzynarodowy Dzień Ptaków – ustanowiony w 1906 podczas ratyfikacji Konwencji o ochronie ptaków pożytecznych dla rolnictwa z 19 marca 1902 (o ochronie szerzej mówi Dyrektywa Ptasia Unii Europejskiej z 2 kwietnia 1979)

                    Prima aprilis




                    Polska – rozpoczyna się akcja ogólnokrajowa: Tydzień Czystości Wód (od 1 do 7 kwietnia)
                    San Marino – Inwestytura nowego Regenta
                    ', CAST(N'2016-04-01' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (93, N'Imieniny obchodzą: Aaron, Abundiusz, Franciszek, Laurencja, Leopold, Leopolda, Maria, Miłobąd, Samosąd, Teodozja, Urban i Wiktor.
                    Kanada – Dzień Papieża Jana Pawła II.
                    Międzynarodowe:

                    Międzynarodowy Dzień Książki dla Dzieci
                    Światowy Dzień Świadomości Autyzmu (z inicjatywy Kataru popartej przez ONZ w 2008)


                    ', CAST(N'2016-04-02' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (94, N'Imieniny obchodzą: Antoni, Benedykt, Cieszygor, Eutychia, Gandolf, Gandulf, Izbygniew, Izbygniewa, Jakub, Jan, Józef, Nicetas, Pankracy, Ryszard, Sykstus i Winicjusz
                    Gwinea – Rocznica Drugiej Republiki
                    ', CAST(N'2016-04-03' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (95, N'Imieniny obchodzą: Adelajda, Ambroży, Benedykt, Izydor, Józef, Platon, Teodul, Teodulf, Wyszeniega, Zdziemir i Zdzimir.
                    Angola – Dzień Pokoju i Pojednania
                    Lesotho – Dzień Bohaterów
                    Międzynarodowe – Międzynarodowy Dzień Wiedzy o Minach i Działań Zapobiegających Minom (ustanowione przez Zgromadzenie Ogólne ONZ 8 grudnia 2005 roku)
                    Polska – Święto Wojskowej Służby Zdrowia
                    Senegal – Święto Niepodległości
                    Tajwan, Hongkong – Dzień Dziecka
                    Wielka Brytania – Światowy Dzień Szczura (ang. World Rat Day)
                    ', CAST(N'2016-04-04' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (96, N'Imieniny obchodzą: Borzywoj, Irena, Izbor, Jeremi, Jeremiasz, Julianna, Katarzyna, Krescencja, Maria, Tristan i Wincenty.
                    Korea Południowa – Dzień Drzew
                    Francja – Dzień Grzeczności za Kierownicą
                    Wielka Brytania – Dzień bez Makijażu
                    ', CAST(N'2016-04-05' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (97, N'Imieniny obchodzą: Ada, Adam, Celestyna, Diogenes, Filaret, Ireneusz, Izolda, Katarzyna, Marcelin, Michał, Notger, Notker, Piotra, Platonida, Prudencjusz, Sieciesława, Świętobor, Tymoteusz, Wilhelm, Zachary, Zachariasz i Zefiryn.
                    międzynarodowe – Międzynarodowy Dzień Sportu dla Rozwoju i Pokoju (ustanowione przez ONZ w 2013; rezolucja A/RES/67/296)
                    Rwanda – Dzień Upamiętnienia Ludobójstwa
                    Sudan – Dzień Powstania
                    ', CAST(N'2016-04-06' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (98, N'Imieniny obchodzą: Asumpta, Donat, Epifaniusz, Hegezyp, Herman, Jan Chrzciciel, Józef, Krystian, Maria, Niestanka i Przedsław.
                    Armenia – Dzień Macierzyństwa i Piękności
                    Kościół prawosławny – Zwiastowanie Bogurodzicy (jedno z 12 głównych świąt)
                    Międzynarodowe:

                    Światowy Dzień Zdrowia (ustanowiony przez WHO)
                    Dzień Pamięci Ofiar Ludobójstwa w Rwandzie (ustanowiony przez Zgromadzenie Ogólne ONZ)


                    Mozambik – Dzień Kobiet
                    ', CAST(N'2016-04-07' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (99, N'Imieniny obchodzą: Amancjusz, Apolinary, Asynkryt, August, Cezary, Cezaryna, Dionizy, Ema, Emma, January, Julia, Julian, Makaria, Maksyma, Perpet, Perpetuus, Radosław i Walter
                    Międzynarodowe:

                    Romowie – Międzynarodowy Dzień Romów (ustanowione w 1990, podczas IV Kongresu Międzynarodowego Związku Romskiego)
                    Międzynarodowy Dzień Opozycji Przeciw GMO (w skrócie: MDO-GMO)


                    ', CAST(N'2016-04-08' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (100, N'Imieniny obchodzą: Achacy, Achacjusz, Antoni, Celestyna, Demetria, Demetriusz, Dobrosława, Dominika, Eupsychia, Eupsychiusz, Franciszek, Heliodor, Hilary, Hilaria, Hugo, Innocenty, Kasylda, Katarzyna, Konrad, Maja, Marceli, Maria, Matron, Notger, Prochor, Reginald, Tankred, Tomasz, Ubald, Wadim, Waldetruda i Walter.
                    Filipiny – Dzień Bohaterów
                    Tunezja – Dzień Męczenników
                    ', CAST(N'2016-04-09' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (101, N'Imieniny obchodzą: Afrykan, Antoni, Apoloniusz, Daniel, Ezechiel, Fulbert, Grodzisław, Henryk, Magdalena, Makary, Małgorzata, Marek, Michał, Notger, Paladiusz, Pompejusz i Terencjusz.
                    Polska – Dzień Służby Zdrowia
                    ', CAST(N'2016-04-10' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (102, N'Imieniny obchodzą: Anioł, Antypas, Antypater, Arleta, Filip, Gemma, Helena, Herman, Hildebrand, Hildebranda, Izaak, Jaromir, Leon, Leona i Rajner.
                    Kostaryka – Dzień Bitwy pod Rivas
                    Międzynarodowe:

                    Światowy Dzień Choroby Parkinsona


                    Polska:

                    Dzień Radia
                    Ogólnopolski Dzień Walki z Bezrobociem (od 2000)


                    ', CAST(N'2016-04-11' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (103, N'Imieniny obchodzą: Andrzej, Damian, Józef, Juliusz, Konstanty, Konstantyn, Saba, Siemidrog, Teresa, Wiktor, Zenon i Zenona.
                    Międzynarodowe:

                    Międzynarodowy Dzień Dzieci Ulicy
                    Międzynarodowy Dzień Załogowych Lotów Kosmicznych (ustanowione przez Zgromadzenie Ogólne ONZ w 2011 na pamiątkę pierwszego lotu Jurija Gagarina i pierwszego lotu wahadłowca kosmicznego Columbia w 1981)


                    Ukraina – Dzień Pracowników Przemysłu Kosmicznego Ukrainy
                    Polska – Dzień Czekolady
                    Stany Zjednoczone, Polska, Rosja – Noc Jurija
                    ', CAST(N'2016-04-12' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (104, N'Imieniny obchodzą: Agatonika, Długomił, Hermenegild, Hermenegilda, Ida, Jan, Justyn, Karp, Kwintylian, Maksym, Małgorzata, Marcin, Marcjusz, Przemysł, Przemysław, Przemysława i Ursus
                    Czad – Święto Narodowe
                    Kambodża, Laos, Sri Lanka, Tajlandia – Nowy Rok
                    Polska – Dzień Pamięci Ofiar Zbrodni Katyńskiej
                    ', CAST(N'2016-04-13' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (105, N'Imieniny obchodzą: Ardalion, Ernestyna, Izabela, Jadwiga, Julianna, Justyna, Krzysztof, Lambert, Lamberta, Lawinia, Lawiniusz, Maksym, Maria, Myślimir, Piotr, Symplicja, Tomaida, Trofim, Tyburcja, Tyburcjusz, Tyburcy, Walerian i Wszegniew.
                    Angola – Dzień Młodzieży
                    Gruzja – Dzień Języka Gruzińskiego
                    Haiti, Honduras – Święto Ameryki
                    Polska – Dzień Ludzi Bezdomnych
                    Uganda – Dzień Upadku Idi Amina Dady
                    Sikhizm – święto urodzaju Baisakhi i rocznica założenia Khalsy
                    ', CAST(N'2016-04-14' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (106, N'Imieniny obchodzą: Abel, Anastazja, Bazylisa, Cezariusz, Cezary, Eutyches, Maksym, Maro, Maron, Modest, Olimpia, Piotr, Potencjana, Potencjanna, Rodan, Sylwester, Sylwestra, Teodor, Tytus, Wiktoryn i Wszegniew
                    Międzynarodowe – Międzynarodowy Dzień Kombatanta
                    ', CAST(N'2016-04-15' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (107, N'Imieniny obchodzą: Benedykt, Bernadeta, Cecylian, Charyzjusz, Erwin, Erwina, Feliks, Julia, Joachim, Kalikst, Kwintylian, Lambert, Lamberta, Leonid, Marcjalis, Optat, Publiusz, Saturnin, Turybiusz i Urban.
                    Polska – Święto Wojsk Inżynieryjnych – Dzień Sapera
                    ', CAST(N'2016-04-16' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (108, N'Imieniny obchodzą: Anicet, Aniceta, Eliasz, Innocenty, Izydor, Izydora, Jakub, Józef, Katarzyna, Klara, Paweł, Radociech, Robert, Roberta, Salwator, Stefan i Teodora
                    Światowy Dzień Chorych na Hemofilię
                    Kiribati – Narodowy Dzień Zdrowia
                    Samoa – Święto Flagi
                    Syria – Dzień Ewakuacji
                    ', CAST(N'2016-04-17' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (109, N'Imieniny obchodzą: Alicja, Apoloniusz, Barbara, Bogusław, Bogusława, Eleuteria, Eleuteriusz, Eleutery, Flawiusz, Gosław, Gosława, Gościsław, Maria, Ryszard i Sabina.
                    Międzynarodowe:

                    Międzynarodowy Dzień Ochrony Zabytków
                    Światowy Dzień Krótkofalowca (święto obchodzone w rocznicę powołania Międzynarodowej Unii Radioamatorskiej (IARU) w 1925&#160;r.)


                    Iran – Dzień Armii
                    Polska – Dzień Pacjenta w Śpiączce (od 2012)
                    Zimbabwe – Święto Niepodległości
                    ', CAST(N'2016-04-18' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (110, N'Imieniny obchodzą: Cieszyrad, Czesław, Dionizjusz, Dionizy, Ekspedyt, Ekspedyta, Elfeg, Ema, Emma, Irydion, Jerzy, Konrad, Krescencjusz, Krescens, Krescenty, Leon, Leona, Leontyna, Pafnucy, Tymon, Sokrates, Wierzyn, Wigilia, Wincenty i Włodzimir
                    Polska – Dzień Pamięci Ofiar Holocaustu i Powstania w Getcie Warszawskim
                    Sierra Leone – Dzień Republiki
                    Suazi – Urodziny Króla
                    Wenezuela – Dzień Deklaracji Niepodległości
                    Zimbabwe – Dzień Niepodległości
                    ', CAST(N'2016-04-19' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (111, N'Imieniny obchodzą: Agnieszka, Amalia, Antonin, Berenika, Czesław, Jagna, Nawoj, Marcelin, Marcjan, Sekundyn, Sewerian, Sulpicjusz, Szymon, Teodor, Teotym, Ursycyn, Wiktor, Zenon i Zotyk
                    Brazylia – Dzień Dyplomacji
                    Międzynarodowe

                    Międzynarodowy Dzień Wolnej Prasy (inicjatywa Stowarzyszenia Reporterzy bez Granic)
                    Dzień języka chińskiego w ONZ w ramach dni języków


                    ', CAST(N'2016-04-20' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (112, N'Imieniny obchodzą: Abelard, Aleksandra, Anastazy, Anzelm, Apollina, Apollon, Apoloniusz, Bartłomiej, Bartosz, Dobrosułka, Drogomił, Feliks, Konrad, Konrada i Żelisław
                    Brazylia – Tiradentes
                    Starożytny Rzym – Parilia (rocznica założenia Rzymu)
                    Ruch Rastafari – Święto Przybycia cesarza Hajle Syllasje I na Jamajkę
                    ', CAST(N'2016-04-21' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (113, N'Imieniny obchodzą: Agapit, Aital, Gaja, Gajusz, Kaja, Leon, Leona, Leonid, Leonida, Lucjusz, Łucjusz, Łukasz, Soter, Strzeżymir, Teodor, Wanesa i Wirginiusz.
                    Brazylia – Dzień Odkrycia
                    Międzynarodowe – Międzynarodowy Dzień Matki Ziemi (od 2010, ustanowiony przez Zgromadzenie Ogólne ONZ)
                    Polska – Dzień Ziemi (na świecie w równonoc wiosenną, tj. 20 lub 21 marca)
                    ', CAST(N'2016-04-22' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (114, N'Imieniny obchodzą: Achilles, Adalbert, Egidia, Feliks, Fortunat, Gabriela, Gerard, Gerarda, Helena, Idzi, Jerzy, Lena, Maria, Marol, Wojciech i Wojciecha.
                    Międzynarodowe

                    Światowy Dzień Książki i Praw Autorskich (ustanowiony przez UNESCO w 1995 r. w celu promowania czytelnictwa, edytorstwa i ochrony własności intelektualnej)
                    Dzień języka angielskiego w ONZ w ramach dni języków


                    Anglia – Dzień św. Jerzego, patrona Anglii
                    Turcja – Narodowy Dzień Niepodległości i Dzień Dziecka
                    Wielka Brytania – Święto Orderu Podwiązki
                    ', CAST(N'2016-04-23' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (115, N'Imieniny obchodzą: Aleksander, Aleksy, Antym, Bona, Doda, Egbert, Erwin, Erwina, Euzebiusz, Fidelis, Gaston, Grzegorz, Honoriusz, Horacjusz, Horacy, Jerzy, Leoncjusz, Longin, Longina, Maria, Saba, Tyberiusz i Zbywoj
                    Armenia – Dzień Upamiętnienia Ludobójstwa
                    Międzynarodowe – Międzynarodowy Dzień Przeciwko Wiwisekcji (także: Międzynarodowy Dzień Zwierząt Laboratoryjnych)
                    Niger – Dzień Narodowej Zgody
                    ', CAST(N'2016-04-24' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (116, N'Imieniny obchodzą: Anian, Ewodia, Ewodiusz, Filon, Filona, Franciszka, Hermogenes, Jarosław, Kaliksta, Kalista, Marek, Markusław, Piotr, Radociech, Rustyk, Rustyka, Stefan i Włodzimira.
                    Australia, Nowa Zelandia – ANZAC Day
                    Egipt – Święto Wyzwolenia Synaju
                    Korea Północna:

                    Święto Utworzenia Armii Ludowej
                    Rozpoczyna się Tydzień Wolności Korei Północnej


                    Międzynarodowe:

                    Dzień Świadomości Alienacji Rodzicielskiej
                    Międzynarodowy Dzień Świadomości Zagrożenia Hałasem
                    Światowy Dzień Malarii
                    Międzynarodowy Dzień DNA


                    Polska – Dzień Sekretarki (w ramach Międzynarodowego Dnia Sekretarki)
                    Portugalia – Święto Państwowe (rocznica rewolucji goździków)
                    Suazi, Wyspy Owcze – Święto Flagi
                    Włochy – Święto Państwowe Wyzwolenia Włoch od faszyzmu
                    ', CAST(N'2016-04-25' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (117, N'Imieniny obchodzą: Artemon, Aureliusz, Dominik, Erwina, Grzegorz, Klarencjusz, Klet, Lucydiusz, Marcelin, Mariusz, Marzena, Paschazy, Ryszard i Spycimir.
                    Polska, Szczecin – Dzień Wyzwolenia Szczecina (1945-1999), Święto Zdobycia Szczecina (od 2000)
                    Międzynarodowe – Światowy Dzień Własności Intelektualnej
                    Tanzania – Święto Unii
                    ', CAST(N'2016-04-26' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (118, N'Imieniny obchodzą: Anastazy, Bożebor, Felicja, Jakub, Jan, Józef, Kanizjusz, Marcin, Ożanna, Piotr, Teodor, Teofil, Tertulian, Tertuliana, Zyta i Żelimysł[potrzebny&#160;przypis].
                    Finlandia – Dzień Weterana
                    Holandia – Dzień Króla
                    Katalonia – Dzień Montserrat
                    Międzynarodowe:

                    Światowy Dzień Grafika, obchodzony od 1995 w rocznicę powstania Icograda
                    Światowy Dzień Rysunku Graficznego


                    Republika Południowej Afryki – Dzień Wolności
                    Sierra Leone – Święto Niepodległości
                    Słowenia – Dzień Powstania Przeciw Najeźdźcy
                    Togo – Święto Niepodległości
                    ', CAST(N'2016-04-27' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (119, N'Imieniny obchodzą: Achacjusz, Achacy, Afrodyzja, Afrodyzjusz, Afrodyzy, Arystarch, Dydym, Dydymus, Joanna, Ludwik, Marek, Maria, Menander, Pamfil, Patrycjusz, Patrycy, Patryk, Paweł, Piotr, Przybycześć, Teodora, Waleria i Witalis.
                    Barbados – Dzień Bohaterów
                    Międzynarodowe:

                    Światowy Dzień Bezpieczeństwa i Ochrony Zdrowia w Pracy, ustanowiony przez Międzynarodową Organizację Pracy
                    Międzynarodowy Dzień Pamięci Ofiar Wypadków przy Pracy, ustanowiony w 1996 roku przez Międzynarodową Konfederację Związków Zawodowych


                    Pitcairn – Święto Bounty
                    Polska – Dzień Bezpieczeństwa i Ochrony Zdrowia w Pracy (uchwalone w 2007)
                    ', CAST(N'2016-04-28' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (120, N'Imieniny obchodzą: Angelina, Antonia, Augustyn, Bogusław, Emilian, Ermentruda, Hugo, Hugon, Katarzyna, Krystyn, Myślimir, Paulin, Piotr, Robert, Roberta, Ryta, Sewer, Tertulia i Tychik
                    Japonia – Dzień Ziemi
                    Polska – Dzień Męczeństwa Duchowieństwa Polskiego
                    Międzynarodowe:

                    Międzynarodowy Dzień Tańca (pod patronatem Międzynarodowego Instytutu Teatralnego i UNESCO)
                    Dzień Pamięci o Ofiarach Wojen Chemicznych (Organizacja ds. Zakazu Broni Chemicznej (OPCW), ONZ)


                    ', CAST(N'2016-04-29' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (121, N'Imieniny obchodzą: Afrodyzja, Afrodyzjusz, Afrodyzy, Andrea, Bartłomiej, Benedykt, Chwalisława, Donat, Eutropiusz, Jakub, Józef, Katarzyna, Kwiryn, Lilla, Ludwik, Maksencja, Maksym, Maria, Marian, Piotr, Pius, Pomponiusz, Rozamunda i Wawrzyniec.
                    ', CAST(N'2016-04-30' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (122, N'Imieniny obchodzą: Aniela, Asaf, Berta, Briok, Floryna, Izydora, Jakub, Jeremi, Jeremiasz, Józef, Julian, Lubomir, Maja, Orencjusz, Peregryn, Petronela, Tamara i Wiwald.
                    Celtowie – Beltane
                    Międzynarodowe – Święto Pracy, w Polsce święto państwowe 1 maja (w Polsce i niektórych krajach dzień wolny od pracy)
                    Finlandia – Vappu (dzień robotników i studentów)
                    Francja – Święto konwalii
                    Kazachstan, Samoa – Dzień Ludu
                    Kościół Starokatolicki Mariawitów i tradycjonalizm katolicki: Filipa i Jakuba Młodszego Apostołów
                    Wyspy Marshalla – Święto Konstytucji
                    ', CAST(N'2016-05-01' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (123, N'Imieniny obchodzą: Anatol, Atanazy, Borys, Cyriak, Częstowoj, Eksuperiusz, Gwalbert, Teodulf, Walbert, Waldebert, Walenty, Walentyn, Walter, Zoe, Zygmunt i Zygmunta.
                    dawn. Dziady – wiosenne, słowiańskie święto upamiętniające zmarłych
                    Iran, Indonezja – Dzień Nauczyciela
                    Polska:

                    Dzień Flagi Rzeczypospolitej Polskiej
                    Dzień Polonii i Polaków za Granicą


                    ', CAST(N'2016-05-02' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (124, N'Imieniny obchodzą: Aleksander, Alodia, Antonina, Diodor, Diodora, Juwenalis, Leonia, Maria, Mariola, Maura, Piotr, Świętosława, Teodul, Teodulf, Tymoteusz, Wirzchosława i Wiola.
                    Japonia – Dzień Konstytucji (憲法記念日)
                    Kościół Starokatolicki Mariawitów w RP: Podwyższenie Krzyża Świętego (Uroczystość Znalezienia Krzyża Świętego)
                    Litwa – Święto Narodowe Trzeciego Maja
                    Międzynarodowe:

                    Międzynarodowy Dzień Astmy i Alergii
                    Światowy Dzień Wolności Prasy (ustanowione przez Zgromadzenie Ogólne ONZ w 1993)


                    Polska – Święto Narodowe Trzeciego Maja (dzień wolny od pracy)
                    ', CAST(N'2016-05-03' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (125, N'Imieniny obchodzą: Antonia, Antonina, Damian, Damiana, Florian, Gościwit, Gotard, Grzegorz, January, Kasjan, Leonida, Lucyla, Michał, Monika, Paulin, Pelagia, Tekla, Teodora, Strzedziwoj, Sylwan i Wespazjan
                    Chińska Republika Ludowa – Dzień Młodzieży
                    Holandia – Dzień Pamięci Ofiar Wojny
                    Japonia – Dzień Zieleni
                    Międzynarodowe – Międzynarodowy Dzień Strażaka, Dzień Gwiezdnych wojen
                    Namibia – Święto Cassingi
                    Polska

                    Dzień Strażaka (od 2002 święto państwowe)
                    Dzień Hutnika, Dzień Kominiarza, Dzień Garncarza i Dzień Piekarza


                    Tonga – Urodziny Księcia
                    ', CAST(N'2016-05-04' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (126, N'Imieniny obchodzą: Anioł, Benwenut, Chociemir, Eulogia, Eulogiusz, Eutymiusz, Geroncjusz, Gotard, Hilary, Irena, Ireneusz, Iryda, Jowinian, Maksym, Nicetas, Penelopa, Peregryn, Pius, Stanisław, Stanisława, Teodor, Waldemar, Zdzibor i Zdziebor.
                    Albania – Dzień Męczenników
                    Dania – Dzień Wyzwolenia
                    Etiopia – Dzień Patriotów
                    Holandia – Święto Niepodległości
                    Japonia – Kodomo no Hi (Dzień Dziecka), święto narodowe, do 1948 jako Tango-no Sekku (Dzień Chłopca)
                    Kirgistan – Święto Konstytucji
                    Korea Południowa – Dzień Dziecka
                    Meksyk – rocznica bitwy o Pueblę
                    Palau – Święto Ludzi w Podeszłym Wieku
                    Państwa Europy:

                    Dzień Europy
                    Dzień Walki z Dyskryminacją Osób Niepełnosprawnych (w Polsce również Dzień Godności Osób z Niepełnosprawnością Intelektualną)


                    Tajlandia – Święto Koronacji
                    ', CAST(N'2016-05-05' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (127, N'Imieniny obchodzą: Bartłomiej, Benedykta, Domagniew, Edbert, Ewodia, Ewodiusz, Filip, Franciszek, Jakub, Jan, Judyta, Jurand, Miłodrog, Placyd i Teodot.
                    Unia Europejska – Europejski Dzień Bezpieczeństwa Ruchu Drogowego
                    Bułgaria:

                    Dzień Św. Georga (Dzień św. Jerzego w rocznicę jego śmierci, tj. 23 kwietnia/6 maja według liturgii Cerkwi prawosławnej)
                    Święto Armii


                    Gabon, Liban, Syria – Dzień Męczenników
                    Fidżi – Narodowy Dzień Młodzieży
                    Watykan – Święto Gwardii Szwajcarskiej
                    Kościół Starokatolicki Mariawitów w RP – wspomnienie św. Jana Apostoła w oleju
                    ', CAST(N'2016-05-06' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (128, N'Imieniny obchodzą: August, Bogdała, Domicela, Domicjan, Domicjana, Flawia, Florian, Gizela, Jan, Ludmiła, Ludomiła, Ludomira, Piotr, Róża, Stanimir, Wincenty i Wirginia.
                    Hamburg – Urodziny Portu
                    Rosja – Dzień Radia
                    ', CAST(N'2016-05-07' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (129, N'Imieniny obchodzą: Achacjusz, Achacy, Amat, Arseniusz, Benedykt, Bonifacy, Dezyderia, Dionizy, Heladia, Heladiusz, Ida, Michał, Stanisław, Stanisława, Ulryka, Wiktor i Wiron.
                    Polska:

                    Dzień Zwycięstwa
                    Dzień Położnej


                    Korea Południowa – Dzień Rodziców
                    Międzynarodowe:

                    Światowy Dzień Czerwonego Krzyża i Czerwonego Półksiężyca
                    Czas Upamiętniający i Jednoczący Tych, Którzy Stracili Życie Podczas II Wojny Światowej (8 i 9 maja), ustanowione przez Zgromadzenie Ogólne ONZ w 2005 roku
                    Dzień Bibliotekarzy i Bibliotek


                    ', CAST(N'2016-05-08' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (130, N'Imieniny obchodzą: Beat, Geroncjusz, Grzegorz, Hiacynta, Hiob, Karolina, Mikołaj, Maria, Otokar, Pachomiusz, Przebor i Stefan.
                    Rumunia – Dzień Niepodległości
                    Rosja, Armenia, Azerbejdżan, Białoruś, Gruzja, Kazachstan, Kirgistan, Mołdawia, Tadżykistan, Turkmenistan, Uzbekistan i inne państwa – Dzień Zwycięstwa; Serbia, Bośnia i Hercegowina – Dzień Zwycięstwa nad Faszyzmem; Ukraina – Dzień Zwycięstwa nad Nazizmem w II Wojnie Światowej
                    Międzynarodowe:

                    Czas Upamiętniający i Jednoczący Tych, Którzy Stracili Życie Podczas II Wojny Światowej (8 i 9 maja)
                    Dzień Unii Europejskiej (upamiętniający ogłoszenie planu Schumana o utworzeniu Europejskiej Wspólnoty Węgla i Stali)


                    Kościół Starokatolicki Mariawitów w RP i tradycjonalizm katolicki: wspomnienie św. Grzegorza z Nazjanzu, doktora Kościoła
                    W Japonii jest obchodzony dzień poświęcony Son Gokū.
                    ', CAST(N'2016-05-09' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (131, N'Imieniny obchodzą: Antonin, Beatrycze, Blanda, Celzjusz, Chociesław, Chocsław, Cyryn, Cyryna, Częstomir, Epimach, Feliks, Filadelf, Filadelfia, Gordian, Gordiana, Innocenty, Jan, Łazarz, Nazariusz, Nazary, Samuel, Sofronia, Sylwester, Sylwestra, Symplicjusz, Symplicy i Wiktoryna.
                    Polska – Polski Dzień Sauny
                    Gwatemala, Meksyk, Salwador – Dzień Matki
                    Mikronezja – Święto Federacji Stanów Mikronezji
                    ', CAST(N'2016-05-10' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (132, N'Imieniny obchodzą: Adalbert, Albert, Alojzy, Antym, Benedykt, Berta, Fabiusz, Filip, Franciszek, Gwalbert, Iga, Ignacy, Lutogniew, Majol, Majola, Maksym, Mamert, Mamerta, Miranda, Stella, Syzyniusz, Tadea, Tadeusz, Walbert, Waldebert i Zuzanna.
                    Polska – Dzień bez Śmiecenia (z inicjatywy młodzieży na spotkaniu Europejskiego Eko-Parlamentu Młodzieży, EYEP)
                    Żory – Święto Ogniowe
                    ', CAST(N'2016-05-11' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (133, N'Imieniny obchodzą: Achilles, Domicela, Domicjan, Domicjana, Dominik, Epifaniusz, Flawia, German, Imelda, Jan, Jazon, Joanna, Nawoja, Nereusz, Pankracy, Plautylla, Teodora i Wszemił
                    Międzynarodowe:

                    Międzynarodowy Dzień Pielęgniarek (ustanowiony przez Międzynarodową Radę Pielęgniarek)
                    Światowy Dzień Syndromu Chronicznego Zmęczenia i Zaburzeń Immunologicznych (syndrom uznany po raz pierwszy w 1860 przez dr George’a Bearda)


                    ', CAST(N'2016-05-12' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (134, N'Imieniny obchodzą: Agnieszka, Aaron, Ciechosław, Cieszmir, Dobiesław, Dobiesława, Gemma, Gerard, Gerarda, Gliceria, Jan, Magdalena, Maria, Mucjusz, Natal, Robert, Roberta i Serwacy.
                    ', CAST(N'2016-05-13' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (135, N'Imieniny obchodzą: Ampelia, Ampeliusz, Bonifacy, Dominika, Egidia, Fenenna, Idzi, Izydor, Jeremi, Jeremiasz, Koryna, Maciej, Maria, Michał i Wiktor.
                    Liberia – Dzień Jedności
                    Polska – Dzień Farmaceuty
                    Samoa – Dzień Matek Samoa
                    ', CAST(N'2016-05-14' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (136, N'Imieniny obchodzą: Atanazy, Cecyliusz, Czcibora, Dionizja, Florencjusz, Florenty, Izydor, Jan, Kasjusz, Maksym, Miłość, Nadzieja, Paweł, Piotr, Retycjusz, Retycja, Retyk, Robert, Stanibor, Strzeżysław, Symplicjusz, Symplicja, Wiktoryn, Zofia.
                    Meksyk, Korea Południowa – Dzień Nauczyciela
                    Międzynarodowe – Międzynarodowy Dzień Rodzin (proklamowane przez Zgromadzenie Ogólne ONZ)
                    Paragwaj – Święto Niepodległości
                    Polska – Dzień Polskiej Niezapominajki
                    ', CAST(N'2016-05-15' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (137, N'Imieniny obchodzą: Adam, Adamina, Andrzej, Brendan, Fidol, Germeriusz, Honorat, Jan Nepomucen, Jędrzej, Peregryn, Rambert, Szymon, Trzebiemysł, Ubald, Wiktorian, Wiktoriana i Wiktorianna.
                    Malezja – Dzień Nauczyciela
                    Polska – Święto Straży Granicznej
                    ', CAST(N'2016-05-16' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (138, N'Imieniny obchodzą: Antonia, Bruno, Brunon, Chwalimir, Falimir, Herakliusz, Montan, Paschalis, Sławomir, Weronika, Wiktor, Wilhelm i Wrocsława.
                    Demokratyczna Republika Konga – Święto Wyzwolenia Narodowego
                    Nauru, Norwegia – Dzień Konstytucji
                    Międzynarodowe:

                    Międzynarodowy Dzień Przeciw Homofobii (ang. IDAHO)
                    Światowy Dzień Społeczeństwa Informacyjnego (proklamowany przez Zgromadzenie Ogólne ONZ jako kontynuacja Światowego Dnia Telekomunikacji)


                    ', CAST(N'2016-05-17' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (139, N'Imieniny obchodzą: Aleksandra, Alicja, Eryk, Eryka, Eufrazja, Faina, Feliks, Jan, Julita, Klaudia, Liberiusz, Matrona, Myślibor, Sandra, Teodot i Wenancjusz.
                    Haiti – Święto Flagi i Uniwersytetów
                    Międzynarodowe – Międzynarodowy Dzień Muzeów (ustanowiony w 1977 roku przez ICOM, Międzynarodową Radę Muzeów, działającą przy UNESCO)
                    Turkmenistan – Święto Konstytucji
                    ', CAST(N'2016-05-18' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (140, N'Imieniny obchodzą: Augustyn, Bernarda, Celestyn, Cyriaka, Dunstan, Iwo, Iwon, Iwona, Jan, Kryspin, Mikołaj, Pękosław, Pękosława, Piotr, Potencjana, Potencjanna, Pudencjana, Pudencjanna, Urban i Teofil.
                    Polska – Dzień Dobrych Uczynków (Fundacja Ekologiczna Arka, od 2005)
                    Turcja – Dzień Młodzieży
                    Wietnam – Urodziny Hồ Chí Minha
                    Grecja – Dzień Pamięci: Ludobójstwo Greków Pontyjskich
                    ', CAST(N'2016-05-19' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (141, N'Imieniny obchodzą: Aleksander, Asteriusz, Anastazy, Bernardyn, Bromir, Bronimir, Bronisąd, Elfryda, Józefa, Karol, Kolumba, Rymwid, Saturnina, Taleleusz, Teodor i Wiktoria
                    Kamerun – Święto Narodowe
                    Timor Wschodni – Święto Niepodległości
                    ', CAST(N'2016-05-20' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (142, N'Imieniny obchodzą: Antioch, Donat, Jan Nepomucen, Krzysztof, Piotr, Polieukt, Przecława, Rycheza, Ryksa, Serapion, Synezjusz, Teobald, Tymoteusz, Wiktor i Wszemir.
                    Chile – Dzień Marynarki Wojennej
                    Czarnogóra – Święto Niepodległości
                    Polska – Dzień Kadeta
                    Międzynarodowe:

                    Światowy Dzień Kosmosu
                    Światowy Dzień Różnorodności Kulturowej (właśc. Światowy Dzień Różnorodności Kulturowej w Trosce o Dialog i Rozwój, pod patronatem UNESCO)


                    ', CAST(N'2016-05-21' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (143, N'Imieniny obchodzą: Dorian, Emil, Fulko, Helena, Jan, Julia, Krzesisława, Marcjan, Roman, Ryta, Wiesław, Wiesława i Wisława
                    Haiti – Dzień Suwerenności Narodowej
                    Izrael – Dzień Jerozolimy
                    Jemen – Dzień Jedności
                    Martynika – Święto Zniesienia Niewolnictwa
                    Polska – Dzień Praw Zwierząt
                    Międzynarodowe – Międzynarodowy Dzień Różnorodności Biologicznej (ustanowione przez Zgromadzenie Ogólne ONZ)
                    ', CAST(N'2016-05-22' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (144, N'Imieniny obchodzą: Bolelut, Budziwoj, Dezyderia, Dezyderiusz, Dezydery, Emilia, Eufrozyna, Eutychiusz, Gwibert, Jan, Julian, Lucjusz, Łucjusz, Michał, Symeon i Wibert.
                    Jamajka – Święto Pracy
                    Międzynarodowe

                    Dzień Wymiaru Sprawiedliwości
                    Międzynarodowy Dzień Końca Przetoki Położniczej (Zgromadzenie Ogólne ONZ, rezolucja A/RES/67/147)
                    Światowy Dzień Żółwia


                    ', CAST(N'2016-05-23' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (145, N'Imieniny obchodzą: Amalia, Dagmara, Dawid, Donacjan, Franciszek, Jan, Joanna, Ludwik, Maria, Milena, Orion, Tomira, Ubysława, Wanesa, Wincenty i Zuzanna.
                    Bermudy – Bermuda Day
                    Belize – Dzień Wspólnoty Narodów
                    Bułgaria – Dzień Edukacji i Kultury
                    Ekwador – Uroczystość Bitwy pod Pichinchą
                    Erytrea – Święto Niepodległości
                    państwa Europy – Europejski Dzień Parków Narodowych (w rocznicę utworzenia 1. europejskiego parku Sarek w Szwecji)
                    Macedonia – Święto Św. Cyryla i Metodego
                    Polska – Święto Wojsk Specjalnych (od 2008)
                    ', CAST(N'2016-05-24' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (146, N'Imieniny obchodzą: Aldhelm, Beda, Borzysław, Dionizy, Grzegorz, Heladia, Heladiusz, Imisława, Joanna, Leon, Leona, Magdalena, Marcjana, Mariusz, Wenerand i Zenobiusz
                    Argentyna – Rocznica Rewolucji
                    Fani Douglasa Adamsa – Dzień Ręcznika
                    Liban – Dzień Wyzwolenia Południowego Libanu
                    Międzynarodowe:

                    Międzynarodowy Dzień Dziecka Zaginionego (ustanowione przez UE, w Polsce pod patronatem Fundacji Itaka)
                    Rozpoczyna się Tydzień Solidarności z Ludami Zamieszkującymi Niesamorządne Terytoria (do 31 maja, ustanowione przez Zgromadzenie Ogólne ONZ)


                    Organizacja Jedności Afrykańskiej – Dzień Afryki (upamiętniające powstanie OJA 25 maja 1963)
                    Sudan – Rocznica Rewolucji Majowej
                    Unia Afrykańska – Dzień Wyzwolenia Afryki
                    ', CAST(N'2016-05-25' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (147, N'Imieniny obchodzą: Adalwin, Adalwina, Alwin, Alwina, Angelika, Eleuteria, Eleuteriusz, Eleutery, Emil, Ewelina, Filip, Filip Neriusz, Karp, Kwadrat, Lambert, Lamberta, Paulina, Teodor, Więcemił, Zachariasz i Zachary.
                    Gruzja – Święto Niepodległości
                    Kościół Katolicki Mariawitów – wspomnienie męczeńskiej śmierci arcybiskupa, św. Michała Kowalskiego
                    Polska – Dzień Matki
                    ', CAST(N'2016-05-26' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (148, N'Imieniny obchodzą: Augustyn, Eutropiusz, Fryderyk, Fryderyka, Jan, Julian, Lucjan, Magdalena, Małgorzata, Oliwer, Oliwier, Radowit i Świętobor.
                    Boliwia – Dzień Matki
                    Nigeria – Dzień Dziecka
                    Polska:

                    Dzień Samorządu Terytorialnego
                    Dzień Diagnosty Laboratoryjnego (na pamiątkę odkrycia w 1961 kodu genetycznego przez Heinricha J. Matthaeia i Marshalla Warrena Nirenberga)
                    Kościół Starokatolicki Mariawitów w RP – rocznica urodzin św. Marii Franciszki Kozłowskiej


                    ', CAST(N'2016-05-27' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (149, N'Imieniny obchodzą: Augustyn, Balladyna, Bogurad, Emil, German, Heladia, Heladiusz, Herkulan, Ignacy, Jaromir, Just, Lucjusz, Łucjusz, Maria, Wiktor, Wilhelm i Wolrad.
                    Armenia – Święto Niepodległości
                    Azerbejdżan – Proklamacja Pierwszej Demokratycznej Republiki
                    Etiopia – Koniec Reżimu Wojskowego
                    Filipiny – Dzień Flagi
                    Rosja – Dzień Służby Granicznej
                    Wietnam – Oświecenie Buddy
                    ', CAST(N'2016-05-28' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (150, N'Imieniny obchodzą: Aleksander, Andrzej, Bogusław, Ermentruda, Izbylut, Magdalena, Maksymin, Maksymina, Piotr, Rajmund, Rajmunda, Stefan, Syzyniusz, Urszula i Wilhelm.
                    Nigeria – Dzień Demokracji
                    Międzynarodowe – Międzynarodowy Dzień Uczestników Misji Pokojowych ONZ
                    Polska – Dzień Weterana Działań poza Granicami Państwa
                    ', CAST(N'2016-05-29' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (151, N'Imieniny obchodzą: Andronik, Anastazy, Andrzej, Bazyli, Bolemysł, Brodzisław, Eksuperancjusz, Feliks, Ferdynand, Gawin, Jan, Joanna, Mirogniew, Suligniewa, Sulimir, Sulirad, Zyndram i Żanna.
                    Polska – Dzień Rodzicielstwa Zastępczego (uchwalony przez Sejm RP w 2006 roku)
                    Turks i Caicos – Dzień Bohaterów Narodowych
                    ', CAST(N'2016-05-30' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (152, N'Imieniny obchodzą: Feliks, Kamila, Kancjan, Kancjanela, Kancjusz, Marietta, Noe, Paschazy, Petronela, Sylwiusz i Witalis.
                    Międzynarodowe – Dzień bez Papierosa (ustanowiony przez WHO)
                    Polska – Dzień Bociana Białego (święto ustanowione w 2003 r przez Polskie Towarzystwo Przyjaciół Przyrody „pro Natura”
                    ', CAST(N'2016-05-31' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (153, N'Imieniny obchodzą: Alfons, Bernard, Eunika, Felin, Felina, Firmus, Fortunat, Ischyrion, Julian, Justyn, Juwencja, Juwencjusz, Konrad, Konrada, Magdalena, Nikodem, Pamfil, Paweł, Pamela, Porfiriusz, Prokul, Seleukos, Świętopełk, Teobald, Tespezjusz, Tespezy
                    Azory – Święto Wysp Azorów
                    Mongolia – Dzień Dziecka i Matki
                    Międzynarodowe – Dzień Dziecka
                    Palau – Dzień Prezydenta
                    Polska

                    Dzień bez Alkoholu (ustanowione uchwałą Sejmu RP 24 maja 2006)
                    Święto Służby Ruchu Lotniczego


                    Samoa – Święto Niepodległości
                    ', CAST(N'2016-06-01' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (154, N'Imieniny obchodzą: Blandyna, Domna, Efrem, Erazm, Eugeniusz, Florianna, Fotyn, Jaczemir, Marcelin, Maria, Marianna, Materna, Mikołaj, Mszczuja, Nicefor, Piotr, Racisław, Sadok i Trofima.
                    Polska – Dzień bez Krawata
                    Włochy – Święto Republiki
                    ', CAST(N'2016-06-02' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (155, N'Imieniny obchodzą: Andrzej, Bratumiła, Cecyliusz, Ferdynand, Franciszek, Izaak, Jan, Joachim, Karol, Kewin, Klotylda, Laurencjusz, Laurentyn, Leszek, Maciej, Owidia, Owidiusz, Paula, Tamara i Wawrzyniec.
                    Czarnogóra – Dzień Niepodległości
                    Polska:

                    Dzień Dobrej Oceny (m.in. ocena szkolna, ocena pracowników, ocena Rządu)
                    Dzień Savoir-Vivre


                    Uganda – Dzień Męczenników Ugandy
                    ', CAST(N'2016-06-03' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (156, N'Imieniny obchodzą: Braturad, Dacjan, Franciszek, Gostmił, Karol, Karp, Kwiryn, Kwiryna, Metrofan, Niepełka, Optat, Pacyfik, Saturnina i Skarbisław.
                    Ghana – Rocznica Przewrotu 1979 Roku
                    Międzynarodowe – Międzynarodowy Dzień Dzieci Będących Ofiarami Agresji (ustanowione przez Zgromadzenie Ogólne ONZ)
                    Polska – Dzień Wolności i Praw Obywatelskich
                    Tonga – Dzień Emancypacji
                    ', CAST(N'2016-06-04' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (157, N'Imieniny obchodzą: Bonifacy, Dobrociech, Doroteusz, Ferdynand, Genadiusz, Hildebrand, Hildebranda, Igor, Jakub, Nikanor, Nikanora, Waleria, Walter i Zenaida.
                    Dania – Święto Konstytucji
                    Gwinea Równikowa – Dzień Prezydenta
                    Iran – Rocznica Powstania Przeciw Szachowi
                    Polska – Święto Centralnego Węzła Łączności Ministerstwa Obrony Narodowej im. płk. prof. Kazimierza Drewnowskiego (Decyzja nr 93/MON z 11 kwietnia 2005)
                    Międzynarodowe – Światowy Dzień Środowiska (ustanowione przez Zgromadzenie Ogólne ONZ)
                    Seszele – Święto Wyzwolenia
                    ', CAST(N'2016-06-05' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (158, N'Imieniny obchodzą: Aleksander, Artemiusz, Benignus, Dominika, Filip, Gerard, Gerarda, Kandyda, Klaudiusz, Laurenty, Marceli, Maria, Norbert, Norberta, Paulina, Sydonia, Wawrzyniec i Więcerad.
                    Korea Południowa – Dzień Upamiętnienia Ofiar Wojny Koreańskiej
                    Międzynarodowe:

                    Dzień języka rosyjskiego w ONZ w ramach dni języków


                    Polska

                    Święto Wojsk Chemicznych
                    Święto Centrum Operacji Powietrznych (Decyzja nr 141/MON z 3 czerwca 2002)


                    Szwecja – Święto Narodowe i dzień wolny od pracy – rocznica elekcji Gustawa I Wazy (1523).
                    Społecznościowe – Narodowy Dzień Slayera
                    ', CAST(N'2016-06-06' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (159, N'Imieniny obchodzą: Anna, Antoni, Jarosław, Jeremiasz, Jeremi, Lukrecja, Meriadek, Meriadok, Paweł, Piotr, Robert, Roberta, Sabinian, Teresa, Wiesław, Wiesława i Wisław.
                    ', CAST(N'2016-06-07' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (160, N'Imieniny obchodzą: Dobrociech, Herakliusz, Jakub, Maksymin, Maksymina, Maria, Medard, Medarda, Seweryn, Wilhelm i Wyszesław.
                    Argentyna – Dzień Polskiego Osadnika (hiszp. Día del Colono Polaco; święto narodowe od 1995)
                    Międzynarodowe – Światowy Dzień Oceanów (ustanowione na Szczycie Ziemi w 1992; przez Zgromadzenie Ogólne ONZ ustanowione w 2008, pierwsze obchody w ONZ w 2009)
                    Norfolk – Święto Bounty
                    ', CAST(N'2016-06-08' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (161, N'Imieniny obchodzą: Anna, Bertrand, Efrem, Felicjan, Józef, Kanimir, Kolumb, Maksymian, Prosimir, Ryszard, Sylwester i Sylwestra.
                    Międzynarodowe – Międzynarodowy Dzień Archiwów (obchodzone od 2007, w rocznicę utworzenia w Paryżu w 1950 roku Międzynarodowej Rady Archiwów – ICA)
                    Polska

                    Dzień Pracowników Archiwów i Bibliotek
                    Dzień Przyjaciela
                    Dzień Księgowego


                    Uganda – Dzień Bohaterów Narodowych
                    ', CAST(N'2016-06-09' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (162, N'Imieniny obchodzą: Amancjusz, Amata, Apollo, Asteriusz, Aureliusz, Bogumił, Bogumiła, Cecylia, Diana, Edgar, Henryk, Ingolf, Jan, Maksym, Mauryn, Onufry, Tymoteusz, Wiktorian, Wiktoriana i Wiktorianna.
                    Międzynarodowe – Międzynarodowy Dzień Heraldyki
                    Gujana Francuska – Zniesienie Niewolnictwa
                    Jordania – Rocznica Powstania Antytureckiego
                    Portugalia – Rocznica Śmierci Luísa Vaza de Camõesa
                    ', CAST(N'2016-06-10' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (163, N'Imieniny obchodzą: Anastazy, Barnaba, Feliks, Fortunat, Flora, Jan, Paula, Paryzjusz, Radomił, Radomiła, Teodozja i Witomysł.
                    Hawaje – Dzień Króla Kamehamehy I
                    Libia – Dzień Ewakuacji
                    Iława – Święto Miasta
                    ', CAST(N'2016-06-11' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (164, N'Imieniny obchodzą: Antoni, Antonina, Bazylides, Bernard, Bolesław, Celestyna, Cyryn, Cyryna, Czesław, Czesława, Ewa, Gwido, Gwidon, Jan, Janina, Jarogniew, Jarogniewa, Kacper, Kasper, Kazimierz, Leon, Leona, Ludwik, Mieczysław, Mieczysława, Nabor, Nabur, Narcyz, Nazariusz, Nazary, Olimpiusz, Onufry, Piotr, Placyd, Przybyrad, Stefan, Tadea, Władysław, Władysława, Włodzimierz i Wyszemir.
                    Brazylia – Dzień Zakochanych
                    Filipiny – Święto Niepodległości
                    Międzynarodowe – Światowy Dzień Sprzeciwu wobec Pracy Dzieci (od 2002 ustanowione przez ILO)
                    Paragwaj – Rocznica Zakończenia Wojny o Chaco
                    Polska – Święto Biura Ochrony Rządu
                    Rosja – Dzień Rosji
                    ', CAST(N'2016-06-12' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (165, N'Imieniny obchodzą: Akwilina, Antoni, Chociemir, Gerard, Gerarda, Gracja, Grzegorz, Herman, Lubowid, Lucjan, Peregryn, Rambert i Tryfiliusz.
                    Polska – Święto Żandarmerii Wojskowej
                    ', CAST(N'2016-06-13' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (166, N'Imieniny obchodzą: Alojzy, Anastazy, Digna, Eliza, Elizeusz, Feliks, Justyn, Konstancja, Marcjan, Metody, Michał, Myślibor, Ninogniew, Rufin, Ryszard i Walery.
                    Falklandy – Święto Wyzwolenia
                    Malawi – Dzień Wolności
                    Polska:

                    Dzień Dziennikarza Obywatelskiego (od 2010 z inicjatywy Jolanty Paczkowskiej, „Dziennikarki Obywatelskiej 2009 Roku”)
                    Narodowy Dzień Pamięci Ofiar Niemieckich Nazistowskich Obozów Koncentracyjnych i Obozów Zagłady


                    Stany Zjednoczone – Dzień Flagi
                    Międzynarodowe – Światowy Dzień Krwiodawcy ustanowiony przez m.in. WHO 14 czerwca 2004 w dzień urodzin Karla Landsteinera.
                    ', CAST(N'2016-06-14' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (167, N'Imieniny obchodzą: Abraham, Adelajda, Albertyna, Angelina, Benilda, Bernard, Dula, Edburga, Eutropia, Germana, Hezychiusz, Izolda, Jolanta, Leonida, Liba, Lotar, Oliwia, Placyda, Wisław, Wisława, Wit, Witold, Witolda i Witosław
                    Dania – Dzień Flagi
                    Międzynarodowe:

                    Światowy Dzień Świadomości Znęcania się nad Osobami Starszymi (od 2006 roku jako Światowy Dzień Praw Osób Starszych z inicjatywy organizacji zajmującej się walką ze znęcaniem się nad osobami starszymi); od 2012 w ONZ, rezolucja 66/127 z 9 marca 2012
                    Światowy Dzień Wiatru (Europejski Dzień Wiatru 2007-2008, paneuropejska kampania na rzecz promocji wiatru jako odnawialnego i czystego źródła energii, od 2009 Światowy Dzień Wiatru, ang. Global Wind Day)


                    Polska – Ogólnopolski Dzień Dogoterapii (od 2007 roku)
                    ', CAST(N'2016-06-15' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (168, N'Imieniny obchodzą: Aneta, Aubert, Aurelian, Aureusz, Benon, Benona, Cyryk, Jan, Judyta, Justyna, Ludgarda i Tychon.
                    Międzynarodowe – Międzynarodowy Dzień Dziecka Afrykańskiego (z inicjatywy Organizacji Jedności Afrykańskiej i UNICEF; obchodzone od 1991 r.)
                    Irlandia – Bloomsday (święto, podczas którego dzieje się akcja Ulissesa Jamesa Joyce’a)
                    Republika Południowej Afryki – Dzień Młodzieży
                    ', CAST(N'2016-06-16' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (169, N'Imieniny obchodzą: Adolf, Adolfa, Albert, Alina, Awit, Awita, Drogomysł, Franciszek, Gundolf, Herweusz, Hipacy, Izaur, Izaura, Marcjan, Montan, Nikander, Nikandra, Piotr, Radomił i Waleriana.
                    Islandia – Rocznica Proklamacji Republiki
                    Polska – Święto Wojsk Pancernych i Zmechanizowanych – Dzień Czołgisty (na pamiątkę powrotu do Polski 1. pułku czołgów Armii Polskiej gen. Józefa Hallera w 1919)
                    Międzynarodowe – Światowy Dzień Walki z Pustynnieniem i Suszą (ustanowione przez Zgromadzenie Ogólne ONZ)
                    ', CAST(N'2016-06-17' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (170, N'Imieniny obchodzą: Amand, Amanda, Drogomysł, Drogoradz, Drohobysz, Dzirżysława, Efrem, Elżbieta, Emil, Eufemiusz, Hipacy, Leoncjusz, Marek, Maryna, Miłobor, Ożanna i Przeborka.
                    ', CAST(N'2016-06-18' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (171, N'Imieniny obchodzą: Bonifacy, Borzysław, Gaudencjusz, Gaudenty, Gerwazy, Grymilda, Juliana, Julianna, Michalina, Otto, Odon, Protazy, Romuald i Romualda.
                    Międzynarodowe – Światowy Dzień Anemii Sierpowatej (UNESCO od 2009)
                    ', CAST(N'2016-06-19' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (172, N'Imieniny obchodzą: Adalbert, Baltazar, Benigna, Bogna, Bratomir, Edburga, Florentyna, Franciszek, Gemma, Hektor, Jan, Jan Chrzciciel, Makary, Michał, Rafaela, Rafał i Tomasz.
                    Argentyna – Dzień Flagi
                    Erytrea – Dzień Męczenników
                    Międzynarodowe – Światowy Dzień Uchodźcy (święto ustanowione przez Zgromadzenie Ogólne ONZ)
                    ', CAST(N'2016-06-20' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (173, N'Imieniny obchodzą: Alicja, Alojza, Alojzy, Chloe, Demetria, Domamir, Euzebiusz, Lutfryd, Marcja, Rajmund, Rudolf, Rudolfa, Rudolfina, Terencja i Terencjusz.
                    Noc Kupały, zw. potocznie nocą świętojańską, święto obchodzone w nocy z 21 na 22 czerwca (związane z przesileniem letnim)
                    Grenlandia – Najdłuższy Dzień w Roku (Ullortuneq)
                    Kanada – Narodowy Dzień Tubylczy (od 1996)
                    Międzynarodowe:

                    Światowy Dzień Deskorolki, (ang. Skateboarding Day, od 2006)
                    Święto Muzyki (od 1981 z inicjatywy Marcela Landowskiego, francuskiego kompozytora polskiego pochodzenia, od 1995 roku Międzynarodowe Święto Muzyki, w Polsce od 2000)
                    Międzynarodowy Dzień Jogi (od 2015)


                    Polska – Dzień Przedsiębiorcy
                    Togo – Dzień Męczenników
                    Turkmenistan – Wybory Pierwszego Prezydenta
                    ', CAST(N'2016-06-21' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (174, N'Imieniny obchodzą: Achacjusz, Achacy, Agenor, Alban, Albana, Będzieciech, Eberhard, Flawiusz, Innocenty, Jan, Paulin i Tomasz.
                    Noc Kupały zw. potocznie nocą świętojańską obchodzone w nocy z 21 na 22 czerwca (związane z letnim przesileniem Słońca)
                    Chorwacja – Dzień Antyfaszystowskiego Ruchu Oporu
                    Kongo – Dzień Armii
                    Międzynarodowe – Światowy Dzień „Garbusa”
                    Salwador – Dzień Nauczyciela
                    ', CAST(N'2016-06-22' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (175, N'Imieniny obchodzą: Agrypina, Albin, Anna, Arystokles, Atanazy, Edeltruda, Jan, Józef, Maria, Sydonia, Wanda, Zenon i Zenona.
                    święto Jana, noc św. Jana, noc świętojańska w nocy z 23/24 czerwca (tradycyjna Noc Kupały zw. również nocą świętojańską, obchodzona jest w nocy z 21 na 22 czerwca):

                    Litwa – Joninės (Dzień świętego Jana)
                    Łotwa – Līgo
                    Polska – pot. noc świętojańska, imprezy kulturalne nawiązujące do Nocy Kupały,


                    Estonia – Dzień Zwycięstwa
                    Luksemburg – Urodziny Wielkiego Księcia
                    Międzynarodowe (ustawione przez Zgromadzenie Ogólne ONZ):

                    Dzień Służby Publicznej (od 2002)
                    Międzynarodowy Dzień Wdów (od 2011)


                    Nikaragua, Uganda i Polska – Dzień Ojca
                    ', CAST(N'2016-06-23' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (176, N'Imieniny obchodzą: Danuta, Emilia, Jan, Janina, Jan Chrzciciel, Janisław, Longin, Longina, Romuald, Romualda, Symplicjusz, Symplicy, Teodulf i Wilhelm
                    Wigilia św. Jana (Noc Świętojańska), święto katolickie obchodzone w nocy z 23 na 24 czerwca; tradycyjna Noc Kupały zw. również nocą świętojańską, obchodzona jest w nocy z 21 na 22 czerwca
                    Andora, Estonia, Litwa, Łotwa, Quebec – Dzień św. Jana
                    Dawne święto Inti Raymi w Imperium Inków
                    Polska – Światowy Dzień Chorych na Osteoporozę (od 1964 roku święto osób niewidomych) (właściwy Światowy Dzień Osteoporozy, ang. World Osteoporosis Day, ustanowiony przez IOF obchodzony jest 20 października)
                    Peru – Dzień Indian
                    Wenezuela – Rocznica Bitwy o Carabobo
                    ', CAST(N'2016-06-24' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (177, N'Imieniny obchodzą: Adelbert, Antyd, Dorota, Eulogiusz, Febron, Febronia, Fiebrosław, Kineburga, Łucja, Maksym, Prosper, Prospera, Sozypater, Tolisława i Wilhelm.
                    Chorwacja, Słowenia – Dzień Państwowości
                    Kościół luterański – Pamiątka Wyznania Augsburskiego (święto obchodzone w rocznicę ogłoszenia Konfesji Augsburskiej)
                    Międzynarodowe – Dzień Marynarza (ustanowiony w 2010 przez IMO)
                    Mozambik – Święto Niepodległości
                    ', CAST(N'2016-06-25' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (178, N'Imieniny obchodzą: Dawid, Edburga, Jan, Jeremi, Jeremiasz, Maksanty, Maksencjusz, Mirogod, Paweł, Pelagia, Pelagiusz, Salwia, Salwiusz, Wigiliusz i Zdziwoj.
                    Azerbejdżan – Święto Sił Zbrojnych Azerbejdżanu
                    Madagaskar, Somalia – Święto Niepodległości
                    Międzynarodowe (ustanowione przez Zgromadzenie Ogólne ONZ):

                    Międzynarodowy Dzień Zapobiegania Narkomanii
                    Międzynarodowy Dzień Pomocy Ofiarom Tortur


                    ', CAST(N'2016-06-26' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (179, N'Imieniny obchodzą: Bogodar, Bogudar, Benwenut, Bożdar, Bożydar, Cyryl, Jan, Joanna, Maria, Maryla, Samson, Teresa, Włodzisław i Włodzisława; (niegdyś Władysław i Władysława, obecnie 30 czerwca).
                    Dżibuti – Święto Niepodległości
                    Katar – Rocznica Objęcia Władzy Przez Emira Hamada ibn Chalifa as-Sani
                    Międzynarodowe – Światowy Dzień Rybołówstwa (ustanowione przez ONZ do spraw Wyżywienia i Rolnictwa-FAO w 1984 roku)
                    Polska – Światowy Dzień Walki z Cukrzycą (obchodzone przez Polskie Stowarzyszenie Diabetyków za zgodą Międzynarodowej Federacji ds. Cukrzycy IDF, w rocznicę odkrycia insuliny; właściwe święto ustanowione przez Federację obchodzone jest 14 listopada, również w Polsce, w rocznicę urodzin odkrywcy insuliny Fredericka Bantinga)
                    ', CAST(N'2016-06-27' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (180, N'Imieniny obchodzą: Argymir, Ekard, Ekhard, Heraklides, Heron, Ireneusz, Jakert, Józef, Leon, Leona, Lubomir, Marcela, Paweł, Plutarch, Seren, Serena, Wincencja, Wincenta, Wincentyna i Zbrosław.
                    Ukraina – Dzień Konstytucji
                    Polska – Narodowy Dzień Pamięci Poznańskiego Czerwca 1956
                    ', CAST(N'2016-06-28' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (181, N'Imieniny obchodzą: Beata, Benedykta, Dalebor, Ema, Emma, Kasja, Kasjusz, Maria, Paweł, Piotr i Rajmund.
                    Holandia – Dzień Weteranów
                    Międzynarodowe:

                    Światowy Dzień Chorych na Twardzinę (ustanowione w 2008 roku przez organizację FESCA, początkowo jako Europejski Dzień Chorych na Twardzinę)


                    Seszele – Święto Niepodległości
                    Polska:

                    Dzień Ratownika Wodnego Ochotniczego Pogotowia Ratowniczego
                    Dzień Stoczniowca (za czasów Polskiej Rzeczypospolitej Ludowej w niedzielę, w trzeciej dekadzie czerwca)


                    ', CAST(N'2016-06-29' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (182, N'Imieniny obchodzą: Bazyli, Bazylides, Ciechosława, Emilia, Ermentruda, Jan, Leon, Leona, Lucyna, Marcjalis, Milena, Teobald, Teobalda, Trofim, Władysław i Władysława (niegdyś 27 czerwca).
                    Demokratyczna Republika Konga – Święto Niepodległości
                    Gwatemala – Święto Armii
                    Polska – Święto Centrum Zarządzania Kryzysowego Ministerstwa Obrony Narodowej
                    Republika Środkowoafrykańska – Dzień Modlitwy Narodowej
                    Sudan – Święto Rewolucji
                    Międzynarodowe – Międzynarodowy Dzień Planetoid (Zgromadzenie ONZ)
                    ', CAST(N'2016-06-30' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (183, N'Imieniny obchodzą: Aaron, Bogusław, Domicjan, Domicjana, Ekhard, Estera, Gaweł, Halina, Jakert, Julian, Karolina, Klarysa, Marcin, Marian, Namir, Otto, Otton, Szymon i Teodoryk.
                    Antyle Holenderskie – Dzień Emancypacji
                    Burundi, Rwanda – Święto Niepodległości
                    Ghana, Somalia – Święto Republiki
                    Kanada – Święto Kanady
                    Międzynarodowe – Światowy Dzień Architektury (od 1996 obchodzone w niektórych krajach w pierwszy poniedziałek października przeniesione przez Międzynarodową Unię Architektów)
                    Polska

                    Dzień Psa (ang. National Dog Day obchodzony 26 sierpnia)
                    Święto Dowództwa Operacyjnego Sił Zbrojnych (w rocznicę przejęcia przez Dowództwo Operacyjne dowodzenia Siłami Zbrojnymi RP w 2005)


                    ', CAST(N'2016-07-01' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (184, N'Imieniny obchodzą: Bernardyn, Bogodar, Bogudar, Bożdar, Bożydar, Eugenia, Eutyches, Eutychiusz, Juwenalis, Martynian, Niegosława, Switun i Urban.
                    Curaçao – Święto Flagi
                    Międzynarodowe:

                    Światowy Dzień Dziennikarza Sportowego (od 1994 obchodzony w rocznicę utworzenia w 1924 roku w Paryżu Międzynarodowego Stowarzyszenia Prasy Sportowej AIPS)
                    Światowy Dzień UFO


                    ', CAST(N'2016-07-02' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (185, N'Imieniny obchodzą: Anatol, Heliodor, Jacek, Józef, Leon, Leona, Longin, Longina, Miłosław, Mirosław, Racigniew, Radomir, Teodot, Tomasz i Tryfon.
                    Białoruś – Dzień Niepodległości (święto oficjalne)
                    ', CAST(N'2016-07-03' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (186, N'Imieniny obchodzą: Aggeusz, Alfred, Andrzej, Atanazy, Aurelian, Berta, Elżbieta, Hiacynt, Innocenty, Jacek, Jacenty, Józef, Julian, Malwina, Odo, Ozeasz, Patrycjusz, Patrycy, Piotr, Teodor, Udalryk i Wielisław.
                    Filipiny – Dzień Przyjaźni Filipińsko-Amerykańskiej, upamiętniający wyzwolenie kraju od okupacji japońskiej pod koniec II wojny światowej przez połączone siły filipińskie i amerykańskie
                    Stany Zjednoczone – Dzień Niepodległości
                    Rwanda – Dzień Wolności
                    ', CAST(N'2016-07-04' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (187, N'Imieniny obchodzą: Antoni, Atanazy, Bartłomiej, Cyryla, Eliasz, Filomena, Jakub, Maria, Marta, Michał, Przybywoj, Telimena, Trofima, Wilhelm i Zoe.
                    Polska, Szczecin – Dzień Ustanowienia Administracji Polskiej w Szczecinie (od 1945) i Dzień Pionierów Miasta Szczecina (od 2013)
                    Algieria, Republika Zielonego Przylądka, Wenezuela – Święto Niepodległości
                    Armenia – Święto Konstytucji
                    Czechy i Słowacja – Dzień słowiańskich misjonarzy Cyryla i Metodego
                    Wyspa Man – Dzień Tynwaldu
                    Zambia – Dzień Jedności
                    ', CAST(N'2016-07-05' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (188, N'Imieniny obchodzą: Chociebor, Dominika, Gotard, Ignacja, Lucja, Łucja, Maria, Nazaria, Niegosław, Teresa i Zuzanna.
                    Czechy – Dzień Jana Husa
                    Kazachstan – Dzień Stolicy
                    Komory, Malawi – Święto Niepodległości
                    Litwa – Dzień Państwowości
                    ', CAST(N'2016-07-06' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (189, N'Imieniny obchodzą: Antonin, Benedykt, Edelburga, German, Gościwit, Hezychiusz, Ilidiusz, Ilidia, Józef, Lucjan, Metoda, Metody, Odo, Papiasz, Peregryn, Pompejusz, Saturnin, Sędzisław, Sędzisława i Wilibald.
                    Tanzania – Dzień Przemysłu
                    Wyspy Salomona – Święto Niepodległości
                    Japonia – Tanabata
                    ', CAST(N'2016-07-07' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (190, N'Imieniny obchodzą: Adolf, Adolfa, Adrian, Adriana, Adrianna, Akwila (m.), Chwalimir, Edgar, Elżbieta, Eugeniusz, Falibor, Hadrian, Hadriana, Jan, Kilian, Kiliana, Odeta, Piotr, Prokop, Teobald i Teobalda.
                    ', CAST(N'2016-07-08' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (191, N'Imieniny obchodzą: Adolfina, Adrian, Adrianna, Aleksander, Anatola, Anatolia, Antoni, Augustyn, Barbara, Brykcjusz, Cyryl, Florianna, Hadrian, Hadriana, Heloiza, Ifigenia, Jan, Joanna, Kornel, Korneli, Korneliusz, Lucja, Łucja, Mikołaj, Róża, Sylwia, Teodoryk, Weronika, Wszebąd, Zenon i Zenona.
                    Argentyna – Święto Niepodległości
                    Palau – Święto Konstytucji
                    Ukraina, Republika Autonomiczna Krymu – Dzień Partenitu
                    ', CAST(N'2016-07-09' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (192, N'Imieniny obchodzą: Aleksander, Amalberga, Aniela, Antoni, Askaniusz, Bianor, Daniel, Emanuel, Engelbert, Filip, January, Leoncjusz, Maurycja, Maurycy, Nasława, Racimir, Rufina, Rzędziwoj, Samson, Sekunda, Sylwan, Witalis i Zacheusz.
                    Bahamy – Święto Niepodległości
                    Mauretania – Święto Sił Zbrojnych
                    ', CAST(N'2016-07-10' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (193, N'Imieniny obchodzą: Benedykt, Jan, Kalina, Olga, Pelagia, Pelagiusz, Pius, Placyd, Sabin, Siepraw, Wyszesława, Zybart, Zybert, Zybracht i Zygbert.
                    Belgia – Dzień Wspólnoty Flamandzkiej
                    Kiribati – Dzień Gospelu
                    Mongolia – Święto Niepodległości
                    Międzynarodowe – Światowy Dzień Ludności (ustanowione z inicjatywy Rady Zarządzającej, Programu NZ ds. Rozwoju (UNDP) w 1989 roku, w rocznicę tzw. Dnia Pięciu Miliardów)
                    Polska – Narodowy Dzień Pamięci Ofiar Ludobójstwa dokonanego przez ukraińskich nacjonalistów na obywatelach II Rzeczypospolitej Polskiej
                    ', CAST(N'2016-07-11' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (194, N'Imieniny obchodzą: Bonifacy, Bruno, Brunon, Epifania, Euzebiusz, Feliks, Hilarion, Hilariona, Himisław, Imisława, Jan Gwalbert, Janina, Jazon, Leon, Leona, Marcjanna, Natan, Paulin, Prokles, Prokul, Świętożyźń, Tatomir, Wera i Weronika.
                    Czarnogóra – Święto Narodowe
                    Irlandia Północna – Rocznica Bitwy nad Boyne (Dzień Oranżystów)
                    Kiribati, Wyspy Świętego Tomasza i Książęca – Święto Niepodległości
                    Polska – Dzień Walki i Męczeństwa Wsi Polskiej
                    ', CAST(N'2016-07-12' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (195, N'Imieniny obchodzą: Andrzej, Benedykt, Ernest, Eugeniusz, Ezdrasz, Henryk, Joel, Małgorzata, Mildreda, Radomiła, Serapion, Sylas, Sara, Świerad i Trofima.
                    ', CAST(N'2016-07-13' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (196, N'Imieniny obchodzą: Angelina, Bohdan, Damian, Dobrogost, Feliks, Fokas, Franciszek, Henryk, Herakles, Jakub, Kamil, Kosma, Marcelin, Tuskana, i Ulryk.
                    Francja, Polinezja Francuska, Nowa Kaledonia, Saint-Barthélemy, Saint-Martin, Saint Pierre i Miquelon – Dzień Zdobycia Bastylii
                    Irak – Święto Narodowe
                    Szwecja – Urodziny Księżniczki
                    ', CAST(N'2016-07-14' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (197, N'Imieniny obchodzą: Anna, Antioch, Atanazy, Bonawentura, Cyriak, Cyriaka, Daniel, Dawid, Dawida, Egon, Ignacy, Lubomysł, Pompiliusz, Roksana, Włodzimierz i Włodzimir.
                    Światowy Dzień bez Telefonu Komórkowego (nieformalne święto ogłoszone przez internautów)
                    ', CAST(N'2016-07-15' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (198, N'Imieniny obchodzą: Andrzej, Atenogenes, Bartłomiej, Benedykt, Carmen, Dzierżysław, Dzirżysława, Ermegarda, Eustacjusz, Eustazja, Eustazjusz, Eustazy, Faust, Irmegarda, Kanmił, Maria, Ryta, Stefan, Walenty i Walentyn.
                    ', CAST(N'2016-07-16' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (199, N'Imieniny obchodzą: Akwilin, Aleksja, Aleksy, Andrzej, Aneta, Bogdan, Donata, Dzierżykraj, Feliks, Jadwiga, Januaria, Konstancja, Leon, Leona, Marcelina, Rufina, Sekunda, Sperat, Teodota, Teodozy, Teodozjusz i Westyna.
                    Korea Południowa – Dzień Konstytucji
                    Lesotho – Urodziny Króla
                    ', CAST(N'2016-07-17' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (200, N'imieniny obchodzą: Arnold, Arnolf, Arnulf, Bruno, Brunon, Drogomił, Drogomir, Drogoradz, Dziwigor, Emilian, Erwin, Eugeniusz, Fryderyk, Fryderyka, Julian, Justyn, Krescencjusz, Krescens, Krescenty, Maryna, Matern, Nemezjusz, Nemezy, Prymityw, Robert, Roberta, Szymon, Szymona, Symforoza, Teodozja i Uniesław.
                    międzynarodowe – Międzynarodowy Dzień Nelsona Mandeli (ustanowione przez Zgromadzenie Ogólne ONZ w 2009)
                    Urugwaj – Święto Proklamowania Pierwszej Konstytucji
                    ', CAST(N'2016-07-18' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (201, N'Imieniny obchodzą: Ambroży, Arseniusz, Aurea, Epafras, Justa, Lutobor, Makryna, Marcin, Piotr, Radomiła, Rufina, Symmach, Teodor, Włodzisław i Zdziesuł.
                    Mjanma – Dzień Męczenników
                    ', CAST(N'2016-07-19' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (202, N'Imieniny obchodzą: Ansegiz, Aureliusz, Czesław, Czesława, Eliasz, Flawian, Flawiana, Heliasz, Hieronim, Hieronima, Leon, Leona, Ludwika, Małgorzata, Modest, Paweł, Remigia, Remigiusz, Sewera i Stosław.
                    Argentyna – Dzień Przyjaźni
                    Kolumbia – Święto Niepodległości
                    Międzynarodowe – Międzynarodowy Dzień Szachów (od 1966 w rocznicę powstania FIDE)
                    Starosłowiańskie – Święto Peruna
                    ', CAST(N'2016-07-20' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (203, N'Imieniny obchodzą: Andrzej, Arbogast, Benedykt, Daniel, Ignacy, Jan, Julia, Just, Klaudiusz, Laurencjusz, Laurenty, Prakseda, Wawrzyniec, Wiktor i Zotyk.
                    Belgia – Święto Niepodległości
                    Guam – Święto Wyzwolenia
                    ', CAST(N'2016-07-21' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (204, N'Imieniny obchodzą: Albin, Benon, Benona, Cyryl, Józef, Magdalena, Menelaus, Milena, Naczęsława, Nicefor, Platon, Stojsław, Stojsława i Teofil.
                    lokalnie: Dzień aproksymacji Pi (odpowiednik amer. zapisu liczby Pi z 14 marca (3.14) zob. Dzień Liczby Pi, europejski sposób zapisu daty 22/7=~3.1428)
                    dawne święta: PRL – Narodowe Święto Odrodzenia Polski
                    Gambia – Święto Rewolucji
                    ', CAST(N'2016-07-22' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (205, N'Imieniny obchodzą: Apolinary, Apolinaria, Bogna, Bolesław, Brygida, Jan, Jan Kasjan, Joanna, Kasjan, Krystyn, Liboriusz, Olimpiusz, Romula i Żelisław.
                    dawn. święto: Starożytny Rzym – Święto Neptuna (Neptunalia)
                    Egipt – Święto Rewolucji Lipcowej
                    Fidżi – Święto Konstytucji
                    Libia – Święto Rewolucji
                    Papua-Nowa Gwinea – Święto Wyzwolenia
                    Polska – Dzień Włóczykija
                    Ruch Rastafari – Obchody rocznicy urodzin Haile Selassie
                    ', CAST(N'2016-07-23' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (206, N'Imieniny obchodzą: Augustyn, Gleb, Kinga, Krystyna, Krzesimir, Kunegunda, Olga, Segolena, Wiktor, Wojciecha i Zyglinda.
                    Polska – Święto Policji
                    ', CAST(N'2016-07-24' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (207, N'Imieniny obchodzą: Alfons, Antoni, Dariusz, Franciszek, Jakub, Krzysztof, Krzysztofa, Kukufas, Nieznamir, Olimpia, Paweł, Rudolf, Rudolfa, Rudolfina, Sławosław i Walentyna.
                    Hiszpania – Dzień św. Jakuba
                    Kostaryka – Rocznica Aneksji Guanacaste
                    Polska – Dzień Bezpiecznego Kierowcy
                    Portoryko – Święto Konstytucji
                    Tunezja – Święto Republiki
                    ', CAST(N'2016-07-25' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (208, N'Imieniny obchodzą: Anna, Bartłomieja, Erast, Grażyna, Hanna, Hiacynt, Jacek, Jacenty, Joachim, Krystiana, Mirosława, Sancja, Symeon, Teodor, Tytus, Walenty, Walentyn i Wilhelm.
                    Kuba – Święto Rewolucji
                    Liberia, Malediwy – Święto Niepodległości
                    Kalendarz Majów – Nowy Rok
                    ', CAST(N'2016-07-26' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (209, N'Imieniny obchodzą: Antuza, Aureliusz, Bertold, Celestyn, Celia, Celiusz, Feliks, Innocenty, Jerzy, Julia, Laurentyn, Lilioza, Lilla, Magdalena, Maur, Natalia, Nowellon, Pantaleon, Sergiusz, Stoisław, Teodor, Tomisława i Wszebor.
                    &#160;Korea Północna – Dzień Zwycięstwa
                    &#160;Kuba – 2. dzień Święta Rewolucji
                    &#160;Malediwy – 2. dzień Święta Niepodległości
                    ', CAST(N'2016-07-27' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (210, N'Imieniny obchodzą: Achacja, Achacjusz, Achacy, Alfonsa, Antoni, Celzjusz, Macieja, Melchior, Nazariusz, Nazary, Samson, Świętomir, Tymon, Tymona, Urban i Wiktor.
                    Międzynarodowe – Światowy Dzień Wirusowego Zapalenia Wątroby (w dzień ur. Barucha Samuela Blumberga ustanowiony przez Europejskie Stowarzyszenie Pacjentów Wątroby (ELPA) w 2004; obchody w WHO od 2011, wcześniej jako Światowy Dzień Świadomości Wirusowego Zapalenia Wątroby 1 października od 2007, następnie 19 maja od formalnego uznania WHD w 2010)
                    Peru – Święto Niepodległości
                    San Marino – Rocznica Upadku Faszyzmu
                    ', CAST(N'2016-07-28' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (211, N'Imieniny obchodzą: Antonin, Beatrycze, Cirzpibog, Cirzpisława, Eugeniusz, Faustyn, Feliks, Flora, Konstantyn, Lucyla, Lucyliusz, Maria, Marta, Olaf, Prosper, Prospera, Rufin, Serapia, Symplicjusz, Symplicy, Teodor i Wilhelm.
                    Peru – 2. dzień Święta Niepodległości
                    Wyspy Owcze – święto narodowe Ólavsøka
                    ', CAST(N'2016-07-29' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (212, N'Imieniny obchodzą: Abdon, Ingeborga, Julita, Leopold, Maksyma, Piotr, Rościsław, Sekunda, Swojsław, Ubysław i Ursus.
                    Maroko – Święto Tronu
                    Międzynarodowe – Międzynarodowy Dzień Przyjaźni (ustanowione przez Zgromadzenie Ogólne ONZ w 2011)
                    Vanuatu – Święto Niepodległości
                    ', CAST(N'2016-07-30' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (213, N'imieniny obchodzą: Adam, Alfonsa, Beat, Demokryt, Emilian, Ernesta, Fabia, Fabiusz, German, Helena, Iga, Ignacy, Jan, Justyn i Lubomir.
                    Hawaje – Dzień Flagi
                    Polska – Dzień Skarbowości
                    Celtowie – wigilia Lughnasadh
                    ', CAST(N'2016-07-31' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (214, N'Imieniny obchodzą: Akcjusz, Aleksander, Alfons, Antonin, Brodzisław, Eleazar, Etelwold, Justyna, Konrad, Konrada, Leoncjusz, Marceli, Nadzieja, Nemezjusz, Nemezy, Piotr, Rudolf, Rudolfa, Rudolfina, Salomea, Wiara i Wiercisław.
                    Barbados, Dominika, Gujana, Jamajka, Trynidad i Tobago – Dzień Wyzwolenia
                    Benin – Święto Niepodległości
                    Chińska Republika Ludowa – Święto Armii
                    Demokratyczna Republika Konga – Dzień Rodziców
                    Irlandia, daw. święto Celtów – Lughnasadh
                    Kanada – Civic Holiday
                    Polska – Narodowy Dzień Pamięci Powstania Warszawskiego (święto państwowe)
                    Ruch Rastafari – obchody wyzwolenia z niewolnictwa
                    Szwajcaria – Święto Narodowe (rocznica utworzenia konfederacji 1291)
                    ', CAST(N'2016-08-01' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (215, N'Imieniny obchodzą: Alfreda, Euzebiusz, Gustaw, Eliasz, Karina, Maksym, Maria, Rutyliusz, Stefan, Świętosław i Teodota.
                    Bułgaria, Macedonia – Ilinden, rocznica powstania ilindeńskiego (1903)
                    Macedonia – Święto Niepodległości Republiki Macedońskiej
                    Kostaryka – Święto Dziewicy Los Angeles, patronki Kostaryki
                    Mariawici – Święto Objawienia Dzieła Wielkiego Miłosierdzia
                    Polska – Dzień Pamięci o Zagładzie Romów i Sinti
                    Rosja – Dzień Wojsk Powietrznodesantowych
                    ', CAST(N'2016-08-02' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (216, N'Imieniny obchodzą: Augustyn, Cyra, Dalmacjusz, Eufroniusz, Lidia, Marana, Miłosław, Nikodem, Nikodema, Piotr, Symeon i Szczepan.
                    Gwinea Równikowa – Święto Sił Zbrojnych
                    Niger – Święto Niepodległości
                    Wenezuela – Dzień Flagi
                    ', CAST(N'2016-08-03' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (217, N'Imieniny obchodzą: Arystarch, Franciszek, Fryderyk, Jan, Justyn, Krescencjusz, Krescens, Krescenty, Maria, Mironieg, Perpetua, Pęcisław, Pęcisława, Pękosław, Prokop, Rajner, Tertulian i Tertuliana.
                    Burkina Faso – Święto Rewolucji
                    Salwador – 1. dzień Festiwalu San Salvador
                    ', CAST(N'2016-08-04' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (218, N'Imieniny obchodzą: Abel, Afra, Cyriak, Kasjan, Kasjana, Maria, Memiusz, Nonna, Oswald, Oswalda, Parys, Wenancja, Wenancjusz, Wenanty i Wirginia.
                    Burkina Faso – Dzień Niepodległości
                    Chile, Tuvalu – Narodowy Dzień Dziecka
                    Chorwacja – Dzień Zwycięstwa i Dumy Państwowej
                    Międzynarodowe – Międzynarodowy Dzień Piwa i Piwowara (ang. International Beer Day, kanadyjska inicjatywa ustanowienia „wakacyjnego” dnia piwa i piwowara wyrażona w 2007 roku; pierwsze obchody odbyły się 18 czerwca 2008; w Polsce można spotkać się z datą 25 maja)
                    ', CAST(N'2016-08-05' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (219, N'Imieniny obchodzą: Felicysym, Jakub, January, Just, Maria, Namir, Nasław, Oktawian, Stefan, Walburga i Wincenty.
                    Boliwia, Jamajka – Święto Niepodległości
                    Zjednoczone Emiraty Arabskie – rocznica dojścia do władzy szejka Zaida ibn Sultan an-Nahajana
                    ', CAST(N'2016-08-06' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (220, N'Imieniny obchodzą: Agatangel, Albert, Andromeda, Dobiemiar, Donat, Dorota, Doryda, Edmund, Edmunda, Kajetan, Klaudia, Konrad, Konrada, Licynia, Licyniusz, Sykstus i Wincenty.
                    Wybrzeże Kości Słoniowej – Święto Republiki
                    ', CAST(N'2016-08-07' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (221, N'Imieniny obchodzą: Bonifacja, Cyriak, Cyryl, Dominik, Emilian, Esmeralda, Jan, Joanna, Largus, Maryn, Maryniusz, Miron, Mirona, Niegosław, Niezamysł, Sekundus, Sewer, Smaragd, Sylwiusz i Szmaragd.
                    Antyklerykalizm w Polsce – Dzień Antyklerykała (na pamiątkę powstania Antyklerykalnej Partii Postępu RACJA)
                    Irak – Dzień Pokoju
                    Polska – Wielki Dzień Pszczół (od 2013 roku)
                    Tanzania – Dzień Rolników (Nane Nane)
                    ', CAST(N'2016-08-08' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (222, N'Imieniny obchodzą: Domicjan, Domicjana, Doroteusz, Edyta, Falkon, Irena, Jan, Julian, Klarysa, Marcelin, Marcjan, Miłorad, Roman, Romuald, Ryszard i Teresa.
                    Południowa Afryka – Narodowy Dzień Kobiet
                    Singapur – Święto Niepodległości
                    Międzynarodowe – Międzynarodowy Dzień Ludności Tubylczej na Świecie (ustanowione przez Zgromadzenie Ogólne ONZ w 1944 do 9 sierpnia 2014 roku)
                    ', CAST(N'2016-08-09' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (223, N'Imieniny obchodzą: Amadea, Amadeusz, Asteria, Bernard, Bogdan, Bogdana, Bogodar, Bogudar, Bohdan, Bohdana, Bożdar, Bożydar, Hugo, Hugon, Hugona, Laurencjusz, Laurenty, Prochor, Wawrzyniec i Wirzchosław.
                    Ekwador – Święto Niepodległości
                    Polska – Dzień Przewodnika i Ratownika Górskiego (w dzień patrona św. Wawrzyńca)
                    ', CAST(N'2016-08-10' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (224, N'Imieniny obchodzą: Aleksander, Filomena, Herman, Klara, Ligia, Lilia, Rufin, Telimena, Tyburcja, Tyburcjusz, Tyburcy, Włodzimierz, Włodzimir, Włościwoj i Zuzanna.
                    Czad – Święto Niepodległości
                    ', CAST(N'2016-08-11' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (225, N'Imieniny obchodzą: Anicet, Aniceta, Bądzsław, Cyriak, Digna, Eunomia, Euzebiusz, Fotyn, Herkulan, Hilaria, Innocenty, Joanna, Julian, Julianna, Klara, Largus, Lech, Leonida, Makary i Wiktoria.
                    Międzynarodowe – Międzynarodowy Dzień Młodzieży (ustanowione przez Zgromadzenie Ogólne ONZ w 1999)
                    Tajlandia – Urodziny Królowej Sirikit
                    Zambia – Święto Obrony
                    Zimbabwe – Święto Armii
                    ', CAST(N'2016-08-12' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (226, N'Imieniny obchodzą: Benild, Diana, Helena, Hipolit, Hipolita, Jan, Kasjan, Kasjana, Konkordia, Maksym, Poncjan, Radegunda, Radomiła, Sekundyn, Wigbert i Wolebor.
                    Laos – Święto Wolnego Laosu
                    Międzynarodowe – Międzynarodowy Dzień Osób Leworęcznych
                    Republika Środkowoafrykańska – Święto Niepodległości
                    Tunezja – Dzień Kobiet
                    ', CAST(N'2016-08-13' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (227, N'Imieniny obchodzą: Alfred, Atanazja, Dobrowoj, Dobrowoja, Elżbieta, Euzebiusz, Kalikst, Machabeusz, Majnard, Maksymilian, Marceli i Ursycyn.
                    Maroko – Święto Przyłączenia Prowincji Wadi Eddahab
                    Pakistan – Święto Niepodległości
                    Świat - Święto Orientacji Nieheteronormatywnej
                    Paragwaj – Dzień Flagi
                    Polska – Dzień Energetyka
                    USA – Dzień Nawajskiego Szyfranta
                    ', CAST(N'2016-08-14' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (228, N'Imieniny obchodzą: Alipiusz, Armida, Arnolf, Arnulf, Julianna, Maria, Napoleon, Stefan, Tarsycjusz i Trzebiemir.
                    Grecja – święto Zaśnięcia Bogurodzicy (gr. ή Κοίμηση της Θεοτόκου), trzecie znaczenie po świętach Paschy i Bożego Narodzenia. Centralne obchody przy ikonie Panagia Evangelistria, na Cykladach, na wyspie Tinos. Szczególne święto pielgrzymkowe potomków Greków Pontyjskich, do miasta Weria, w Grecji, do Matki Boskiej Sumela, ikony przeniesionej tu z Monastyru Sumela, w Poncie, we wschodniej Turcji. Szczyt urlopowy przypada w Grecji na ten właśnie dzień.
                    Hiszpania – ogólnokrajowe święto religijne, różne nazwy w zależności od miejsca, dzień wolny
                    Indie, Kongo – Dzień Niepodległości
                    Korea Południowa, Korea Północna – Dzień Wyzwolenia
                    Kostaryka – Dzień Matki
                    Liechtenstein – Wigilia urodzin ks. Franciszka Józefa II, święto państwowe
                    Polska – Święto Wojska Polskiego (dzień wolny od pracy)
                    Włochy – Ferragosto
                    ', CAST(N'2016-08-15' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (229, N'Imieniny obchodzą: Ambroży, Anioł, Arsacjusz, Ciechosław, Diomedes, Domarad, Domasuł, Eleuteria, Eleuteriusz, Eleutery, Emil, Laurencjusz, Laurenty, Piotra, Roch, Sabbas, Stefan, Symplicjusz, Symplicy, Tytus i Wawrzyniec.
                    Dominikana – Dzień Odrodzenia
                    ', CAST(N'2016-08-16' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (230, N'Imieniny obchodzą: Anastazy, Anita, Bertram, Bonifacy, Eliza, Euzebiusz, Hiacynt, Jacek, Jacenty, Jaczewoj, Joanna, Julianna, Klara, Liberat, Magdalena, Maksym, Maria, Miron, Mirona, Rogat, Rustyk, Rustyka, Septym, Septymiusz, Serwiusz, Straton i Zawisza.
                    Argentyna – Rocznica śmierci José de San Martína
                    Gabon – Święto Niepodległości
                    Indonezja – Święto Niepodległości
                    Ruch Rastafari – urodziny Marcusa Garveya
                    ', CAST(N'2016-08-17' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (231, N'Imieniny obchodzą: Bogusław, Bronisław, Eryk, Eryka, Firmin, Helena, Ilona, Jan, Klara, Laura, Lena, Ludwik, Paula, Sancja, Tacjana, Tworzysława, Włodzimir i Żyrosława.
                    ', CAST(N'2016-08-18' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (232, N'Imieniny obchodzą: Alfred, Bolesław, Donat, Emilia, Ezechiel, Jan, Julian, Juliusz, Ludwik, Luiza, Magnus, Marian, Sebald, Sykstus, Tekla, Tymoteusz, Wiktor i Wincenty.
                    Kościół prawosławny – Przemienienie Pańskie (jedno z 12 głównych świąt)
                    Międzynarodowe – Światowy Dzień Pomocy Humanitarnej (ustanowiony w 2008 przez Zgromadzenie Ogólne ONZ)
                    ', CAST(N'2016-08-19' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (233, N'Imieniny obchodzą: Bernard, Eliasz, Filibert, Filiberta, Hieronim, Krzysztof, Leowigild, Lucjusz, Łucjusz, Maksym, Małgorzata, Maria, Paweł, Sabin, Samuel, Samuela, Sewer, Sieciech i Świelub.
                    Estonia – Dzień Przywrócenia Niepodległości
                    Maroko – Święto Rewolucji Króla i Ludu
                    Węgry – Dzień św. Stefana (święto narodowe; w Kościele katolickim wspomnienie Stefana I Świętego obchodzone jest 16 sierpnia)
                    ', CAST(N'2016-08-20' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (234, N'Imieniny obchodzą: Agapiusz, Anastazy, Apolinaria, Apolinary, Baldwin, Baldwina, Bernard, Cyriaka, Fidelis, Fidelisa, Franciszek, Maksymilian, Męcimir, Paulina, Pius i Wiktoria.
                    ', CAST(N'2016-08-21' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (235, N'Imieniny obchodzą: Agatonik, Albin, Bernard, Bolesław, Dalegor, Fabrycjan, Filip, Hipolit, Hipolita, Jan, Joachim, Lambert, Lamberta, Laurencjusz, Magdalena, Maria, Namysław, Oswald, Oswalda, Pankracy, Sieciesław, Symforian, Symforiana, Teona, Teonas, Tymoteusz, Wawrzyniec, Zygfryd i Zygfryda.
                    ', CAST(N'2016-08-22' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (236, N'Imieniny obchodzą: Apolinary, Archelaus, Benicjusz, Brygida, Cyriak, Feliksa, Filip, Flawia, Flawian, Ireneusz, Jakub, Kalinik, Klaudiusz, Leoncja, Lubomira, Maksym, Piotra, Róża, Sulirad, Sydonia, Teonilla, Walerian, Wiktor, Zacheusz i Żelisław.
                    daw. starożytny Rzym – Vulcanalia (ku czci boga Wulkana)
                    międzynarodowe:

                    Europejski Dzień Pamięci Ofiar Stalinizmu i Nazizmu (ustanowione przez Parlament Europejski w 70. rocznicę Paktu Ribbentrop-Mołotow; obchodzone od 2009)
                    Międzynarodowy Dzień Pamięci o Handlu Niewolnikami i jego Zniesieniu (proklamowane przez Zgromadzenie Ogólne ONZ w 2008)


                    Rumunia – Dzień Wyzwolenia
                    Ukraina – Dzień Flagi
                    Kościół Katolicki Mariawitów w RP:

                    Święto Krwi Przenajdroższej Pana Jezusa i Ofiary Mateczki
                    Wspomnienie śmierci św. Marii Franciszki Kozłowskiej


                    Kościoły protestanckie – Noc św. Bartłomieja (noc z 23 na 24 sierpnia)
                    ', CAST(N'2016-08-23' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (237, N'Imieniny obchodzą: Anita, Audoen, Bartłomiej, Bartosz, Cieszymir, Emilia, Eutyches, Eutychiusz, Jerzy, Joanna, Halina, Malina, Michalina, Natanael, Patrycjusz, Patrycy i Patryk.
                    Liberia – Święto Flagi
                    Ukraina – Święto Niepodległości
                    ', CAST(N'2016-08-24' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (238, N'Imieniny obchodzą: Arediusz, Elwira, Euzebiusz, Gaudencjusz, Gaudenty, Genezjusz, Grzegorz, Hermina, Józef, Julian, Kalasanty, Ludwik, Luiza, Michał, Patrycja, Peregryn, Poncjan, Teodoryk i Wincenty.
                    Urugwaj – Święto Niepodległości
                    Polska – Dzień polskiej żywności (od 2013 roku)
                    ', CAST(N'2016-08-25' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (239, N'Imieniny obchodzą: Adrianna, Aleksander, Dobroniega, Fortunat, Hadrian, Hadriana, Ireneusz, Joanna, Konstancjusz, Maksymilian, Maria, Natalia, Sandra, Symplicjusz, Symplicy, Teresa, Wiktorian, Wiktoriana, Wiktorianna, Wirzchosław i Wirzchosława.
                    Filipiny, Namibia – Dzień Bohaterów
                    ', CAST(N'2016-08-26' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (240, N'Imieniny obchodzą: Amadea, Amadeusz, Cezariusz, Cezary, Dominik, Fortunat, Gebhard, Honorat, Jan, Józef, Liceria, Liceriusz, Małgorzata, Manea, Marcelin, Monika, Przybymir, Rufus, Sabinian i Serapion.
                    Mołdawia – Święto Niepodległości
                    Starożytny Rzym – Volturnalia, święto Volturnusa
                    ', CAST(N'2016-08-27' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (241, N'Imieniny obchodzą: Adelinda, Aleksander, Aleksy, Alfons, Augustyn, Bibian, Bonifacy, Feliks, Fortunat, Hermes, January, Joachima, Julian, Mojżesz, Pelagiusz, Sobiesław, Stronisław, Wyszomir i Wyszymir.
                    Hongkong – Dzień Wyzwolenia
                    Kościół prawosławny – Zaśnięcie Bogurodzicy (jedno z 12 głównych świąt)
                    Polska – Święto Lotnictwa Polskiego (od 1993)
                    ', CAST(N'2016-08-28' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (242, N'Imieniny obchodzą: Beatrycze, Eutymiusz, Flora, Hipacy, Jan, Jan Chrzciciel, Krescencjusz, Krescens, Krescenty, Mederyk, Mederyka, Michał, Racibor, Sabina, Sebbus i Świętosław.
                    Międzynarodowe – Międzynarodowy Dzień Sprzeciwu wobec Prób Jądrowych (proklamowane przez Zgromadzenie Ogólne ONZ podczas 64. sesji, 30 października 2009)
                    Polska – Dzień Straży Gminnej, Dzień Strażnika Miejskiego
                    Słowacja – Rocznica Wybuchu Słowackiego Powstania Narodowego
                    ', CAST(N'2016-08-29' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (243, N'Imieniny obchodzą: Adaukt, Częstowoj, Częstowojna, Damroka, Feliks, Gaudencja, Ingeborga, Jan, Małgorzata, Miron, Piotr, Rebeka, Swojsław, Świetlana i Tekla.
                    Kazachstan – Święto Konstytucji
                    Międzynarodowe:

                    Międzynarodowy Dzień Pamięci Osób Zaginionych
                    Międzynarodowy Dzień Ofiar Wymuszonych Zaginięć (ustanowione przez Zgromadzenie Ogólne ONZ w 2010)


                    Tatarstan – Święto Utworzenia Republiki Tatarstanu
                    Timor Wschodni – Rocznica Referendum Niepodległościowego
                    Turcja – Dzień Zwycięstwa
                    Turks i Caicos – Święto Konstytucji
                    ', CAST(N'2016-08-30' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (244, N'Imieniny obchodzą: Aidan, Albertyna, Amat, Arystyda, Arystydes, Bohdan, Izabela, Józef, Nikodem, Optat, Paulin, Prymian, Rajmund, Rajmunda, Solidariusz, Świętosław i Teodot.
                    Kirgistan, Trynidad i Tobago – Święto Niepodległości
                    Malezja – święto narodowe Hari Merdeka
                    Polska

                    Dzień Solidarności i Wolności (święto państwowe)
                    Święto Kawalerii Polskiej (na pamiątkę bitwy pod Komarowem)


                    ', CAST(N'2016-08-31' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (245, N'Imieniny obchodzą: Amon, Anna, August, Beatrycze, Bronisław, Bronisława, Donat, Dzierżysław, Egidia, Feliks, Gedeon, Idzi, Melecjusz, Michał, Miłodziad, Ruta, Sator, Satora, Sykstus, Werena, Witalis
                    Erytrea – Początek Zbrojnego Powstania
                    Libia – Święto Rewolucji
                    Białoruś, Ukraina, Rosja – Święto Wiedzy, początek roku akademickiego
                    Polska

                    Święto Wojsk Obrony Przeciwlotniczej
                    Dzień Weterana Walk o Niepodległość Rzeczypospolitej Polskiej


                    Singapur – Dzień Nauczyciela
                    Słowacja – Święto Konstytucji
                    Uzbekistan – Święto Niepodległości
                    ', CAST(N'2016-09-01' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (246, N'Imieniny obchodzą: Absalon, Adelina, Aleksander, Antonin, Apolinary, Bohdan, Czesław, Dziesław, Dionizy, Eliza, Elpidia, Elpidiusz, Franciszek, Ingryda, Jakub, Jan, Julian, Oliwier, Oktawian, Salomon, Seweryn, Sobiemysł, Stefan, Teodor, Tobiasz, Walenty, Walentyn, Wilhelm, Zenon i Zofia.
                    Boliwia – Święto Pracy
                    Wietnam

                    Święto Niepodległości
                    Rocznica śmierci Hồ Chí Minha


                    ', CAST(N'2016-09-02' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (247, N'Imieniny obchodzą: Antoni, Bartłomiej, Bartosz, Bazylisa, Bronisław, Erazma, Feba, Gerard, Gerarda, Grzegorz, Izabela, Jan, Maryn, Maryniusz, Mojmir, Natalis, Przecław, Przedsław, Serapia i Szymon.
                    Australia – Dzień Flagi
                    San Marino – Święto Republiki
                    Katar – Święto Niepodległości
                    ', CAST(N'2016-09-03' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (248, N'Imieniny obchodzą: Bonifacy, Boromea, Daniela, Ermegarda, Felicyta, Gwidona, Heliodora, Hermiona, Ida, Imelda, Irmegarda, Iwo, Iwona, Julian, Kandyda, Kanizja, Kanuta, Katarzyna, Liliana, Lilianna, Marceli, Maria, Mojżesz, Przemysł, Przemysław, Rajmunda, Rościgniew, Rozalia, Scypion, Sergia, Stella i Teodor.
                    ', CAST(N'2016-09-04' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (249, N'Imieniny obchodzą: Bertyn, Budziboj, Dorota, Fereol, Herakles, Herkulan, Herkules, Justyna, Peregryn, Przyboj, Racisław, Racław, Racława, Rozwita, Stronisława, Teodor, Urban, Wiktoryn i Wiktoryna
                    Indie – Dzień Nauczyciela
                    Starożytny Rzym – początek święta Ludi Romani
                    ', CAST(N'2016-09-05' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (250, N'Imieniny obchodzą: Albin, Aleksja, Amoniusz, Bertrand, Bogdana, Bolemir, Donacjan, Eleuteria, Eleuteriusz, Eleutery, Eugenia, Eugeniusz, Ewa, Faust, German, Gundolf, Liberat, Magnus, Manswet, Michał, Onezyfor, Petroniusz, Tomasz, Uniewit, Zachariasz i Zachary
                    Bułgaria – Dzień Zjednoczenia
                    Suazi – Święto Niepodległości
                    ', CAST(N'2016-09-06' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (251, N'Imieniny obchodzą: Dobrobąd, Domasuł, Domasława, Eupsychia, Eupsychiusz, Gratus, Melchior, Pamfil, Regina, Ryszard, Sozont i Teodoryk.
                    Brazylia – Święto Niepodległości
                    Mozambik – Dzień Zwycięstwa
                    ', CAST(N'2016-09-07' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (252, N'Imieniny obchodzą: Adam, Adrian, Adriana, Adrianna, Alan, Amon, Bratumił, Euzebiusz, Maria, Nestor, Radosław, Radosława, Serafina, Teofil, Wiola i Zenon.
                    Andora – święto narodowe
                    Macedonia – Święto Niepodległości
                    Międzynarodowe – Międzynarodowy Dzień Alfabetyzacji (pod patronatem UNESCO)
                    Polska – Dzień Dobrej Wiadomości
                    ', CAST(N'2016-09-08' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (253, N'Imieniny obchodzą: Aniela, Audomar, Augustyn, Aureliusz, Bolemir, Bolemira, Dionizy, Doroteusz, Drogomir, Franciszek, Gorgoniusz, Jacek, Jakub, Jan, Otmar, Ożanna, Piotr, Radosława, Sergiusz, Sewerian, Sobiebor, Sobiesąd, Straton, Ścibora i Świecław.
                    Korea Północna – Rocznica utworzenia Koreańskiej Republiki Ludowo-Demokratycznej
                    Tadżykistan – Święto Niepodległości
                    Międzynarodowe – Światowy Dzień FAS (od 9 września 1999; w Polsce od 2004)
                    ', CAST(N'2016-09-09' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (254, N'Imieniny obchodzą: Agapiusz, Aldona, Anioł, Antoni, Bernard, Datyw, Dydym, Feliks, Franciszek, Izabela, Kandyda, Karol, Klemens, Leon, Leona, Lucjusz, Łucjusz, Łukasz, Mikołaj, Monika, Mścibor, Nemezjan, Nimfodora, Piotr, Polian, Poliana, Polianna, Pulcheria, Salwiusz, Sebastian, Sobiesław, Teodor i Wiktor.
                    Belize – rocznica bitwy o St. George’s Caye
                    Chińska Republika Ludowa – Dzień Nauczyciela
                    Gibraltar – Święto Gibraltaru
                    Honduras – Dzień Dziecka
                    Polska – Dzień Polskiego Piłkarza
                    Międzynarodowe – Światowy Dzień Zapobiegania Samobójstwom
                    Stany Zjednoczone – Dzień Babci i Dziadka
                    ', CAST(N'2016-09-10' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (255, N'Imieniny obchodzą: Ademar, Aisza, Bonawentura, Dagna, Diodor, Diodora, Diomedes, Dydym, Dydymus, Emilian, Feliks, Hiacynt, Jacek, Jacenty, Jan, Krzesisław, Krzesława, Naczęsław, Pafnucy, Piotr, Prot, Teodora i Wincenty.
                    Autokefaliczny Kościół Prawosławny – ścięcie św. Jana Chrzciciela
                    Katalonia – święto narodowe La Diada
                    Etiopia – święto narodowe Nowy Rok „Enkutatash”
                    ', CAST(N'2016-09-11' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (256, N'Imieniny obchodzą: Amadeusz, Cyrus, Franciszek, Gwido, Gwidon, Juwencjusz, Macedoniusz, Maja, Maria, Marlena, Sylwin, Sylwina, Tacjan, Teodul i Teodulf.
                    Międzynarodowe

                    Dzień Programisty (tylko w latach przestępnych)
                    Światowy Dzień Zdrowia Jamy Ustnej
                    Dzień Narodów Zjednoczonych dla Współpracy Południe-Południe (od 2011, wcześniej 19 grudnia ustanowione przez Zgromadzenie Ogólne ONZ)


                    Polska – Święto Wojsk Lądowych (obchodzone od roku 1996 na pamiątkę odsieczy wiedeńskiej z 1683 r.)
                    Republika Zielonego Przylądka – Święto Narodowe
                    ', CAST(N'2016-09-12' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (257, N'Imieniny obchodzą: Aleksander, Amat, Apolinary, Aureliusz, Dobielut, Eulogia, Eulogiusz, Filip, Genadia, Jan Chryzostom, Julian, Litoriusz, Makrobiusz, Maria, Mauryliusz i Morzysław.
                    Programiści – Dzień Programisty (z wyjątkiem lat przestępnych, kiedy to wypada 12 września)
                    ', CAST(N'2016-09-13' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (258, N'Imieniny obchodzą: Albert, Bernard, Jan, Matern, Piotr, Racigniew, Radomira, Roksana, Salustia, Siemomysł, Szymon, Wiktor.
                    Autokefaliczny Kościół Prawosławny – początek Nowego Roku Kościelnego
                    Nikaragua – Rocznica bitwy pod San Jacinto
                    ', CAST(N'2016-09-14' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (259, N'Imieniny obchodzą: Albin, Dolores, Ekhard, Eutropia, Filotea, Filoteusz, Jakert, Jeremi, Jeremiasz, Kamil, Katarzyna, Lolita, Maria, Nicetas, Nikomedes, Roland, Teodor i Walerian.
                    Gwatemala, Honduras, Kostaryka, Nikaragua, Salwador – Dzień Niepodległości
                    Japonia – do 2003 Dzień Szacunku dla Starszych (keiro-no hi); od 2003 Dzień Szacunku dla Starszych przypada na trzeci poniedziałek września
                    Międzynarodowe:

                    Europejski Dzień Prostaty (ustanowiony z inicjatywy pacjentów przez Europejskie Towarzystwo Urologiczne (EAU) w 2006 roku)
                    Międzynarodowy Dzień Demokracji (ustanowiony przez Zgromadzenie Ogólne ONZ w 2007)


                    Polska

                    Dzień Solidarności z Osobami Chorymi na Schizofrenię (w ramach programu Światowego Towarzystwa Psychiatrycznego (WPA) „Schizofrenia – Otwórzcie Drzwi” z 1996 r., w Polsce od 2002 roku; program objęty jest patronatem Ministerstwa Zdrowia oraz Ministerstwa Pracy i Polityki Społecznej)
                    Dzień Opakowań (ustanowiony w 2007 roku przez Polską Izbę Opakowań)


                    Słowacja – święto Matki Boskiej Bolesnej, patronki Słowacji
                    Wielka Brytania – dzień upamiętniający bitwę o Anglię
                    ', CAST(N'2016-09-15' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (260, N'Imieniny obchodzą: Abundancja, Abundancjusz, Antym, Cyprian, Edda, Edyta, Eufemia, Eugenia, Franciszek, Geminian, Innocencja, Innocenta, Innocentyna, Jan, Kamila, Kornel, Korneli, Korneliusz, Ludmiła, Łucja, Ninian, Sebastiana, Sędzisław i Wiktor.
                    Meksyk – Święto Niepodległości
                    Papua-Nowa Gwinea – Święto Niepodległości
                    Polska – Dzień Bluesa (od 2006, w dniu urodzin B.B. Kinga)
                    Międzynarodowe:

                    Międzynarodowy Dzień Ochrony Warstwy Ozonowej (ustanowione przez Zgromadzenie Ogólne ONZ w 1994)
                    Rozpoczyna się Europejski Tydzień Zrównoważonego Transportu (do 22 września)


                    ', CAST(N'2016-09-16' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (261, N'Imieniny obchodzą: Cherubin, Dargosław, Dezyderiusz, Drogosław, Dziebor, Franciszek, Gordian, Hildegarda, Justyn, Justyna, Kolumba, Lambert, Lamberta, Makryn, Narcyz, Piotr, Robert, Sokrates, Szczęsna, Szczęsny, Teodora, Walerian, Zygmunt i Zygmunta.
                    Angola – Rocznica Urodzin Prezydenta Neto
                    Polska – Światowy Dzień Sybiraka (od 1991 roku Dzień Sybiraka, od 2003 Światowy Dzień Sybiraka), o charakterze zjazdu, w celu upamiętnienia rocznicy agresji ZSRR na Polskę (17 września 1939) i jej konsekwencji
                    ', CAST(N'2016-09-17' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (262, N'Imieniny obchodzą: Aretas, Ariadna, Baltazar, Dobrowit, Fereol, Irena, Józef, Metody, Ryszarda, Sobierad, Stanisław, Stefania, Tytus, Zachariasz i Zofia.
                    Chile – Święto Niepodległości
                    Międzynarodowe:

                    Międzynarodowy Dzień Geologa
                    Światowy Dzień Monitoringu Wody


                    ', CAST(N'2016-09-18' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (263, N'Imieniny obchodzą: Alfons, Arnolf, Arnulf, Dezyderiusz, Dezydery, Eliasz, Eutychiusz, Festus, Januariusz, January, Konstancja, Maria, Marta, Nila, Nilus, Paloma, Peleusz, Prokles, Prokul, Teodor, Trofim, Więcemir, Wilhelmina i Zuzanna.
                    Chile – Dzień Armii
                    Saint Kitts i Nevis – Święto Niepodległości
                    Międzynarodowe:

                    Dzień Dzikiej Flory, Fauny i Naturalnych Siedlisk (państwa UE na mocy Konwencji berneńskiej)
                    Międzynarodowy Dzień Mówienia jak Pirat (ang. International Talk Like a Pirate Day)


                    ', CAST(N'2016-09-19' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (264, N'Imieniny obchodzą: Agnieszka, Andrzej, Barbara, Dionizy, Eustachiusz, Eustachy, Euzebia, Fausta, Filipa, Franciszek, Gliceriusz, Glicery, Helmut, Jan, Klemens, Matea, Miłowuj, Paweł, Perpetua, Protazy, Sokrates, Teodor, Teopist i Teopista.
                    Dzień przedszkolaka (obchodzony od 2013)
                    ', CAST(N'2016-09-20' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (265, N'Imieniny obchodzą: Aleksander, Bernardyna, Bożeciech, Daria, Euzebiusz, Hipolit, Hipolita, Ifigenia, Jonasz, Kastor, Konon, Marek, Mateusz, Maura, Melecjusz, Melisa, Pacyfik i Pamfil.
                    Armenia, Belize, Malta – Święto Niepodległości
                    Kościół (organizacja) – Międzynarodowy Dzień Modlitwy o Pokój (od 2004)
                    Kościół Prawosławny – Narodzenie Najświętszej Bogurodzicy (jedno z 12 głównych świąt)
                    Międzynarodowe:

                    Międzynarodowy Dzień Pokoju (obchodzone przez ONZ od 1981, na arenie międzynarodowej od 2002 roku)
                    Światowy Dzień Orderu Uśmiechu (obchodzone przez Międzynarodową Kapitułę Orderu od 2003 roku)
                    Światowy Dzień Choroby Alzheimera


                    Polska – Dzień Krajowej Administracji Skarbowej (d. Dzień Służby Celnej)
                    ', CAST(N'2016-09-21' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (266, N'Imieniny obchodzą: Bazyla, Digna, Eksuperiusz, Emeryta, Emmeram, Emmeran, Feliks, Ignacy, Imbram, Innocenty, Joachim, Jonasz, Józefa, Kandyd, Maurycy, Prosimir, Tacjusz, Tomasz, Wiktor i Witalis.
                    Polski Autokefaliczny Kościół Prawosławny – Białostockie Dni Muzyki Cerkiewnej w rocznicę przeniesienia relikwii św. Gabriela Zabłudowskiego (męczennika)
                    Bułgaria, Mali – Święto Niepodległości
                    Międzynarodowe:

                    Dzień bez Samochodu
                    Zakończenie kampanii ekologicznej Europejskiego Tygodnia Zrównoważonego Transportu (od 16 września)
                    Światowy Dzień Nosorożca (ang. World Rhino Day)


                    ', CAST(N'2016-09-22' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (267, N'Imieniny obchodzą: Adamnan, Andrzej, Antoni, Bernardyna, Boguchwała, Bogufała, Bogusław, Elżbieta, Jan, Konstancjusz, Krzysztof, Lina, Linus, Liwiusz, Piotr, Pius, Poliksena, Projektus, Tekla, Wiercisław, Zachariasz, Zachary i Zofia.
                    Dzień tradycyjnie uznawany za pierwszy dzień astronomicznej jesieni. Początek astronomicznej jesieni następuje w momencie równonocy jesiennej, która wypada najczęściej 22 albo 23 września.
                    Święto Plonów, Dożynki: etniczne święto słowiańskie – równonoc jesienna
                    Arabia Saudyjska – Święto Zjednoczenia Królestwa
                    Według kalendarza hinduskiego pierwszy dzień miesiąca Asvina
                    ', CAST(N'2016-09-23' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (268, N'Imieniny obchodzą: Amata, Gerard, Gerarda, Herman, Jaromir, Kolumba, Maria, Morzysława, Pacyfik, Pafnucy, Seweryn, Tomir, Twardomir i Uniegost.
                    Dominikana – Święto Matki Boskiej z Las Mercedes
                    Gwinea Bissau – Święto Niepodległości
                    Kambodża – Święto Konstytucji i Koronacji
                    Republika Południowej Afryki – Dzień Dziedzictwa
                    Trynidad i Tobago – Dzień Republiki
                    ', CAST(N'2016-09-24' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (269, N'Imieniny obchodzą: Aurelia, Ermenfryd, Ermenfryda, Firmin, Franciszek, Galfryd, Gaspar, Herkulan, Irmfryd, Irmfryda, Kleofas, Minigniew, Rufus, Świętopełk, Wawrzyniec, Wincenty, Władysław, Władysława, Włodzimir, Włodzimira i Włodzisław.
                    Mozambik – Święto Sił Zbrojnych
                    Polska – Dzień Budowlanych lub Dzień Budowlańca (w czasach PRL-u święto obchodzono w ostatnią niedzielę września)
                    Rwanda – Święto Republiki
                    ', CAST(N'2016-09-25' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (270, N'Imieniny obchodzą: Amancjusz, Budziwoj, Cyprian, Damian, Euzebiusz, Kalistrat, Kasper, Kosma, Lucja, Łękomir, Łucja, Majnard, Nil, Nila, Nilus i Teresa.
                    Jemen – Święto Rewolucji
                    Międzynarodowe

                    Europejski Dzień Języków, Międzynarodowy Dzień Języków Obcych (ustanowione w 2001 przez Radę Europy)


                    Polska – Ogólnopolski Dzień Aptekarza (obchodzony w dniu liturgicznego wspomnienia św. Kosmy i Damiana, patronów farmaceutów i aptekarzy)
                    Polska – Dzień Budowlanych (Dzień Budowlańca) (w czasach PRL-u święto obchodzono w ostatnią niedzielę września)
                    ', CAST(N'2016-09-26' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (271, N'Imieniny obchodzą: Adolf, Adolfa, Amadeusz, Eleazar, Gaja, Gajusz, Hiltruda, Jan, Mirabella, Mirela, Przedbor, Urban, Wawrzyniec, Wincenty, Zybert, Zybracht i Zygbert.
                    Belgia – Święto Społeczności Francuskojęzycznej (święto Walonii)
                    Kościół prawosławny – Podwyższenie Krzyża Pańskiego (jedno z 12 głównych świąt)
                    Międzynarodowe – Światowy Dzień Turystyki (ustanowione w 1979 przez Światową Organizację Turystyki, agendę ONZ)
                    Polska – Dzień Podziemnego Państwa Polskiego
                    ', CAST(N'2016-09-27' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (272, N'Imieniny obchodzą: Alodiusz, Amalia, Bernardyn, Eksuperiusz, Jan, Laurencjusz, Marek, Myślibor, Myślibora, Salomon, Sylwin, Sylwina, Tymon, Wacław, Wacława, Więcesław, Więcesława i Wawrzyniec.
                    Czechy

                    Święto Państwowości Czeskiej
                    Dzień św. Wacława, patrona Czech


                    Międzynarodowe – Światowy Dzień Wścieklizny
                    Tajwan – Dzień Nauczyciela i Urzędnika – (dzień urodzin Konfucjusza)
                    ', CAST(N'2016-09-28' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (273, N'Imieniny obchodzą: Cyriak, Dadzbog, Dadzboga, Dariusz, Franciszek, Fraternus, Gabriel, Gajana, Grimbald, Ludwin, Lutwin, Michalina, Michał, Mikołaj, Rafał, Rypsyma i Teodota.
                    Argentyna – Dzień Wynalazcy (rocznica urodzin László Bíró)
                    Paragwaj – Rocznica Zwycięstwa Pod Boqueron
                    Międzynarodowe

                    Międzynarodowy Dzień Kawy


                    Polska:

                    Dzień Kuriera i Przewoźnika (od 2004 roku z inicjatywy firm kurierskich w dniu wspomnienia św. Gabriela – patrona kurierów i przewoźników)
                    Ogólnopolski Dzień Głośnego Czytania (obchodzony od 2001 r. z inicjatywy Polskiej Izby Książki)


                    ', CAST(N'2016-09-29' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (274, N'Imieniny obchodzą: Felicja, Franciszek, Grzegorz, Hieronim, Hieronima, Honoriusz, Imisław, Jimisław, Nadzieja, Ursus, Wiktor, Znamir, Zofia.
                    Botswana – Święto Niepodległości (1966)
                    Międzynarodowe – Międzynarodowy Dzień Tłumacza (od 1953 w dniu wspomnienia św. Hieronima ze Strydonu, tłumacza Biblii; z inicjatywy Międzynarodowej Federacji Tłumaczy)
                    Polska

                    Dzień Chłopaka, Dzień Chłopca,
                    Dzień Muzyki Country


                    ', CAST(N'2016-09-30' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (275, N'Imieniny obchodzą: Ariel, Bawon, Cieszysław, Danuta, Jan, Julia, Krescencjusz, Krescens, Krescenty, Maksyma, Małobąd, Roman i Teresa.
                    Armenia – Dzień Nauczycieli
                    Chiny – Rocznica Proklamowania Chińskiej Republiki Ludowej (święto narodowe)
                    Cypr, Nigeria – Święto Niepodległości (święto narodowe)
                    Kamerun – Święto Zjednoczenia
                    Międzynarodowe:

                    Światowy Dzień Wegetarianizmu
                    Międzynarodowy Dzień Osób Starszych (ustanowiony przez Zgromadzenie Ogólne ONZ w 1990 roku)
                    Europejski Dzień Ptaków (koordynowane przez BirdLife International)
                    Międzynarodowy Dzień Muzyki (ustanowiony przez UNESCO)


                    Polska – Światowy Dzień Wegan (na świecie 1 listopada)
                    San Marino – Inwestytura Regenta
                    Singapur – Dzień Dziecka
                    Tuvalu – 1. dzień Święta Tuvalu (święto narodowe)
                    ', CAST(N'2016-10-01' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (276, N'Imieniny obchodzą: Aleksandra, Antoni, Berengar, Berengaria, Eleuteria, Eleuteriusz, Eleutery, Leodegar, Nasiębor, Stanimir, Ursycyn i Teofil.
                    Gwinea – Święto Republiki
                    Indie – Urodziny Mahatmy Gandhiego
                    Tuvalu – 2. dzień Święta Tuvalu
                    Włochy – Dzień Babć i Dziadków
                    Międzynarodowe

                    Międzynarodowy Dzień bez Przemocy (ustanowiony przez Zgromadzenie Ogólne ONZ 15 czerwca 2006 roku)
                    Światowy Dzień Zwierząt Hodowlanych (w rocznicę urodzin Mahatmy Gandhiego, pioniera wegetarianizmu)


                    ', CAST(N'2016-10-02' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (277, N'Imieniny obchodzą: Augustyna, Częstobrona, Cyprian, Ermegarda, Eustachy, Ewald, Ewalda, Gerard, Gerarda, Irmegarda, Kandyda, Maksymian, Romana, Sirosław, Sulibor i Teresa.
                    Niemcy – Święto Zjednoczenia Niemiec
                    Honduras – Święto Morazan
                    Korea Południowa – Święto Utworzenia Państwa
                    ', CAST(N'2016-10-03' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (278, N'Imieniny obchodzą: Aurea, Dalewin, Dalwin, Dobromiła, Euzebiusz, Faust, Franciszek, Konrad, Konrada, Lucjan, Łucjan i Petroniusz
                    Lesotho – Dzień Niepodległości
                    Mozambik – Dzień Pokoju i Pojednania
                    Międzynarodowe

                    Światowy Dzień Zwierząt, rozpoczynający Światowy Tydzień Zwierząt (do 10 października), ustanowiony przez Zgromadzenie Ogólne ONZ w 1999 roku


                    Polska

                    Światowy Dzień Onkologii (organizowany przez placówki onkologiczne)
                    Dzień Zwierząt (uchwalony przez Sejm RP w 2006)


                    Rosja – Dzień Wojsk Kosmicznych
                    ', CAST(N'2016-10-04' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (279, N'Imieniny obchodzą: Apolinary, Bartłomiej, Charytyna, Donat, Eutychiusz, Faust, Faustyna, Flawia, Flawiana, Flora, Galla, Justyn, Konstancjusz, Maur, Placyd, Rajmund, Tulia i Wiktoryn.
                    Portugalia – Święto Republiki
                    Vanuatu – Święto Konstytucji
                    Międzynarodowe – Światowy Dzień Nauczyciela (święto proklamowane przez UNESCO)
                    ', CAST(N'2016-10-05' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (280, N'Imieniny obchodzą: Alberta, Askaniusz, Baldwin, Baldwina, Bronisław, Bruno, Brunon, Fryderyka, Izydor, Magnus, Monika, Renat, Roman i Wiara.
                    Egipt – Dzień Sił Zbrojnych
                    Polska – Święto Inspektoratu Wsparcia Sił Zbrojnych (w rocznicę utworzenia w 2006 Inspektoratu)
                    Syria – Rocznica Październikowej Wojny Wyzwoleńczej
                    Turkmenistan – Dzień Pamięci (dzień żałoby narodowej)
                    Światowy Dzień Uśmiechu
                    ', CAST(N'2016-10-06' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (281, N'Imieniny obchodzą: Amalia, Apulejusz, August, Bachus, Bakchus, Blanka, Justyna, Marceli, Marek, Maria, Mateusz, Rodsław, Rosława, Rościsława, Sergiusz, Stefan i Tekla.
                    Brazylia – Dzień Kompozytora
                    PRL – Święto Milicji Obywatelskiej i Służby Bezpieczeństwa
                    ', CAST(N'2016-10-07' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (282, N'Imieniny obchodzą: Artemon, Demetriusz, Ewodia, Ewodiusz, Ginter, Guncerz, Gunter, Gratus, Laurencja, Ludwik, Marcjusz, Pelagia, Symeon, Taida i Waleria.
                    Chorwacja – Święto Niepodległości
                    Peru – Dzień Marynarki Wojennej (rocznica bitwy pod Angamos)
                    ', CAST(N'2016-10-08' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (283, N'Imieniny obchodzą: Aaron, Abraham, Arnold, Atanazja, Bogodar, Bogudar, Bożdar, Bożydar, Dionizy, Dionizjusz, Ginter, Guncerz, Gunter, Jan, Ludwik, Piotr, Przedpełk, Sara, Sybilla i Wincenty.
                    Azerbejdżan – Święto Armii i Marynarki Wojennej
                    Stany Zjednoczone – Dzień Leifa Erikssona
                    Uganda – Święto Niepodległości
                    Międzynarodowe – Światowy Dzień Poczty obchodzony w rocznicę założenia Powszechnego Związku Pocztowego (UPU) w 1874 roku (ustanowione przez Zgromadzenie Ogólne ONZ)
                    Polska

                    Dzień Znaczka Pocztowego (od 1956 w rocznicę podpisania konwencji pocztowej w Bernie w 1874)
                    Rozpoczyna się Tydzień Pisania Listów (do 15 października)


                    ', CAST(N'2016-10-09' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (284, N'Imieniny obchodzą: Adalryk, Alderyk, Daniel, Dionizjusz, Dionizy, Eleuteria, Eleuteriusz, Eleutery, Eulampia, Eulampiusz, Franciszek, Gereon, German, Jan, Kalistrat, Kasjusz, Leon, Leona, Lutomir, Maria, Paulin, Przemysław, Rustyk, Rustyka, Samuel, Tomił, Tomiła, Twardostoj i Zbigniew.
                    Fidżi – Święto Niepodległości
                    Finlandia – Dzień Fińskiej Literatury
                    Kenia – Święto Prezydenta Daniela Moi
                    Korea Północna – Rocznica Utworzenia Partii Robotniczej
                    Kuba – Dzień I Wojny o Niepodległość
                    Republika Chińska (Tajwan) – Święto Republiki
                    Międzynarodowe:

                    Światowy Dzień Zdrowia Psychicznego (pod patronatem World Federation for Mental Health i Światowej Organizacji Zdrowia)
                    Europejski Dzień Przeciw Karze ŚmierciPoprawiam ujednioznacznienia (plus drobne typograficzne)
                    Światowy Dzień Drzewa – międzynarodowa i ogólnopolska (Klub Gaja) akcja sadzenia drzew


                    ', CAST(N'2016-10-10' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (285, N'Imieniny obchodzą: Aldona, Aleksander, Andronik, Brunon, Burchard, Dobromiła, Domaczaja, Emanuel, Emilian, Firmin, Gardomir, Gromisław, Maria, Marian, Placyd, Probus i Zenaida.
                    Międzynarodowe – Międzynarodowy Dzień Dziewczynek (ustanowiony przez Zgromadzenie Ogólne ONZ 19 grudnia 2011)
                    Społeczność LGBT – Międzynarodowy Dzień Coming Outu („Dzień Wychodzenia z Szafy”; w Polsce od 2009)
                    USA – Dzień Pamięci Generała Pułaskiego (obchodzony od 1933 roku – zobacz Dzień Kazimierza Pułaskiego)
                    ', CAST(N'2016-10-11' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (286, N'Imieniny obchodzą: Cyriak, Edwin, Edwina, Eustachiusz, Eustachy, Feliks, Grodzisław, Grzymisław, Maksymilian, Maksymiliana, Serafin, Wilfryd, Witold i Witolda.
                    Ameryka – Columbus Day (Dzień Kolumba)
                    Bahamy – Rocznica Odkrycia
                    Brazylia

                    Dzień Dziecka
                    Matki Bożej z Aparecidy (Nossa Senhora da Aparecida)


                    Gwinea Równikowa – Święto Niepodległości (święto narodowe)
                    Hiszpania – rocznica odkrycia Ameryki (święto narodowe)
                    Laos – Dzień Wyzwolenia od Francji
                    Malawi – Dzień Matki
                    Międzynarodowe – Dzień języka hiszpańskiego w ONZ w ramach dni języków
                    Polska:

                    dawn. święto Ludowego Wojska Polskiego (1950–1989)
                    Dzień Bezpiecznego Komputera (od 2004)


                    ', CAST(N'2016-10-12' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (287, N'Imieniny obchodzą: Daniel, Faust, Florencjusz, Florenty, Gerald, Geraldyna, Gerbert, Honorat, January, Karp, Magdalena, Marcjalis, Maurycy, Mikołaj, Reginbald, Siemisław, Teofil, Wacław, Wacława, Wenancjusz i Wenanty.
                    Burundi – Dzień Louisa Rwagasore
                    Międzynarodowe – Międzynarodowy Dzień Ograniczania Skutków Katastrof (od 2009 ustanowiony przez Zgromadzenie Ogólne ONZ, wcześniej 2. środa października, jako Międzynarodowy Dzień Ograniczania Klęsk Żywiołowych)
                    Polska:

                    Dzień Ratownictwa Medycznego
                    Dzień Dawcy Szpiku
                    Dzień Pokojowego Patrolowca


                    ', CAST(N'2016-10-13' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (288, N'Imieniny obchodzą: Alan, Bernard, Burchard, Dominik, Donacjan, Fortunat, Fortunata, Gaja, Gajusz, Gaudencjusz, Gaudenty, Gwendalina, Just, Kalikst, Małgorzata, Parascewa, Rustyk, Rustyka i Witalia.
                    Autokefaliczny Kościół Prawosławny – Święto Opieki Najświętszej Bogurodzicy
                    Gruzja – Dzień Kościoła Sweti Cchoweli
                    Jemen – Rocznica Rewolucji 1963 Roku
                    Polska – Dzień Edukacji Narodowej (dawn. Dzień Nauczyciela)
                    Zimbabwe – Święto Karirurute
                    Międzynarodowe – Światowy Dzień Normalizacji (ang. World Standards Day; z inicjatywy Międzynarodowej Organizacji Normalizacyjnej (ISO) we współpracy z Polskim Komitetem Normalizacyjnym)
                    ', CAST(N'2016-10-14' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (289, N'Imieniny obchodzą: Antioch, Bruno, Brunon, Drogosław, Drogosława, Eutymiusz, Filipa, Gościsława, Jadwiga, Leonard, Roger, Sewer, Tekla, Teodoryk i Teresa.
                    Burkina Faso – rocznica zamachu stanu w 1987
                    Międzynarodowe:

                    Europejski Dzień Walki z Rakiem Piersi
                    Światowy Dzień Białej Laski (od 1964 roku święto osób niewidomych)
                    Światowy Dzień Mycia Rąk (od 2008 roku pod patronatem UNESCO)
                    Międzynarodowy Dzień Kobiet Wiejskich (od 2008 roku)


                    Polska:

                    Dzień Dziecka Utraconego (od 2004 z inicjatywy „Organizacji Rodziców po Stracie oraz Rodziców Dzieci Chorych – Dlaczego”)
                    Święto Wojsk Radiotechnicznych


                    Stany Zjednoczone – Dzień Pamięci Dzieci Nienarodzonych i Zmarłych
                    ', CAST(N'2016-10-15' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (290, N'Imieniny obchodzą: Ambroży, Aurelian, Dionizy, Elifia, Elifiusz, Emil, Florentyn, Gaweł, Gerard, Gerarda, Grzegorz, Iga, Jadwiga, Lubgost, Maksyma, Małgorzata, Martynian, Nereusz, Walenty i Walentyn.
                    Międzynarodowe – Światowy Dzień Żywności (ustanowiony przez Zgromadzenie Ogólne ONZ w rocznicę utworzenia Organizacji Narodów Zjednoczonych do spraw Wyżywienia i Rolnictwa)
                    Niue – Święto Konstytucji
                    Polska – Dzień Papieża Jana Pawła II
                    Stany Zjednoczone – Dzień Szefów (ang. Boss’s Day)
                    ', CAST(N'2016-10-16' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (291, N'Imieniny obchodzą: Augustyna, Florentyn, Heron, Ignacy, Laurentyna, Lucyna, Małgorzata, Mamelta, Marian, Niceta, Rudolf, Rudolfa, Rudolfina, Seweryna, Sulisława, Wiktor i Zuzanna.
                    Haiti – Rocznica Śmierci Jean-Jacques’a Dessalinesa
                    Osetia Północna – Święto Republiki Północna Osetia-Alania
                    Wyspy Dziewicze Stanów Zjednoczonych – Dzień Przyjaźni z Portoryko
                    Międzynarodowe – Międzynarodowy Dzień Walki z Ubóstwem (ustanowione przez Zgromadzenie Ogólne ONZ w 1992 roku)
                    ', CAST(N'2016-10-17' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (292, N'Imieniny obchodzą: Asklepiades, Bratomił, Julian, Just, Łukasz, Miłobrat, Piotr, Remigia, Remigiusz, Siemowit i Tryfonia.
                    Alaska – Dzień Alaski
                    Azerbejdżan – Święto Niepodległości
                    Międzynarodowe – Światowy Dzień Menopauzy i Andropauzy (święto ustanowione przez Światową Organizację Zdrowia)
                    Polska

                    Dzień Pracownika Służby Zdrowia
                    Dzień Poczty Polskiej
                    Dzień Łącznościowca, Dzień Listonosza
                    Święto Wojsk Łączności i Informatyki (w rocznicę utworzenia pierwszego stałego połączenia pocztowego między Krakowem a Wenecją w 1558)


                    ', CAST(N'2016-10-18' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (293, N'Imieniny obchodzą: Akwilin, Ferdynand, Fredeswinda, Fryda, Izaak, Jan, Kleopatra, Laura, Lucjusz, Łucjusz, Paweł, Ptolemeusz, Skarbimir i Ziemowit.
                    Albania – Dzień Matki Teresy z Kalkuty
                    ', CAST(N'2016-10-19' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (294, N'Imieniny obchodzą: Apollon, Artemiusz, Aureliusz, Aurora, Budzisława, Felicjan, Irena, Jan Kanty, Jerzy, Maria, Witalis i Żywia.
                    Gwatemala – Święto Rewolucji
                    Kenia – Dzień Jomo Kenyatty
                    Międzynarodowe:

                    Światowy Dzień Statystyki (ustanowione przez Zgromadzenie Ogólne ONZ; w Polsce 9 marca od 2008)
                    Europejski Dzień Seniora
                    Światowy Dzień Osteoporozy (ustanowione przez International Osteoporosis Foundation)
                    Międzynarodowy Dzień Kontrolera Ruchu Lotniczego (upamiętnia utworzenie w 1961 roku Międzynarodowej Federacji Stowarzyszeń Kontrolerów Ruchu Lotniczego (IFATCA); w Polsce od 2008)


                    ', CAST(N'2016-10-20' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (295, N'Imieniny obchodzą: Bernard, Celina, Dacjusz, Dobromił, Elżbieta, Hilarion, Jakub, Karol, Klementyna, Letycja, Malchus, Pelagia, Pelagiusz, Piotr, Samuel, Urszula, Wendelin, Wszebora i Zotyk.
                    Brytyjskie Wyspy Dziewicze – Dzień św. Urszuli
                    Burundi – Dzień Ndadaye (zob. Melchior Ndadaye)
                    Honduras – Święto Sił Zbrojnych
                    Wyspy Marshalla – Compact Day
                    ', CAST(N'2016-10-21' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (296, N'Imieniny obchodzą: Abercjusz, Alodia, Donat, Euzebiusz, Filip, Gliceria, Ingbert, Józefina, Kordian, Kordula, Marek, Melaniusz, Nunilona, Salomea i Sewer.
                    Międzynarodowe – Światowy Dzień Osób Jąkających
                    ', CAST(N'2016-10-22' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (297, N'Imieniny obchodzą: Bartłomiej, Domicjusz, German, Giedymin, Gracjan, Gracjana, Gracjanna, Honorat, Ignacy, Jan, Klotylda, Małogost, Marlena, Roman i Seweryn.
                    Kambodża – Rocznica Paryskiego Porozumienia Pokojowego
                    Kraje Ameryki Północnej – Dzień Mola (pomiędzy godzinami 6:02 i 18:02)
                    Tajlandia – Dzień Pamięci Króla Chulalongkorna
                    Węgry – Święto Niepodległości (Proklamacja Republiki/Rocznica Rewolucji 1956 roku)
                    ', CAST(N'2016-10-23' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (298, N'Imieniny obchodzą: Alojzy, Antoni, Areta, Aretas, Boleczest, Feliks, Filip, Jan, January, Józef, Marcin, Marek, Pamfilia, Prokles, Prokul, Rafał, Septym i Walentyna.
                    Egipt – Święto Zwycięstwa Suezu
                    Międzynarodowe:

                    Dzień Narodów Zjednoczonych – rocznica wejścia w życie Karty Narodów Zjednoczonych w 1945, obchodzone od 1948 (w 1971 roku Zgromadzenie Ogólne ONZ zaleciło państwom członkowskim, aby uznały ten dzień za państwowe święto)
                    Światowy Dzień Informacji na temat Rozwoju
                    Rozpoczyna się Tydzień Rozbrojenia (trwa do 30 października)
                    Dzień Walki z Otyłością (z inicjatywy Światowej Organizacji Zdrowia (WHO), Europejskiej Konferencji Ministerialnej w sprawie Walki z Otyłością; Europejski Dzień Walki z Otyłością obchodzony jest 22 maja od 2010 roku)


                    Zambia – Święto Niepodległości
                    ', CAST(N'2016-10-24' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (299, N'Imieniny obchodzą: Antonin, Chryzant, Chryzanta, Cyryn, Cyryna, Daria, Gaudenty, Hilary, Inga, January, Katarzyna, Kryspin, Kryspinian, Maur, Prot, Sambor, Tadea, Tadeusz, Teodozjusz i Wojmir.
                    Grenada, Wyspy Dziewicze – Święto Dziękczynienia
                    Kazachstan – Święto Republiki
                    Republika Chińska (Tajwan) – Dzień Retrocesji
                    Polska

                    Dzień Młodzieży Polskiego Czerwonego Krzyża
                    Dzień Kundelka (święto wszystkich wielorasowych psów)
                    Dzień Ustawy o Ochronie Zwierząt
                    Święto Sztabu Generalnego Wojska Polskiego
                    dawn. Święto Wojskowych Służb Informacyjnych (do 2006)


                    ', CAST(N'2016-10-25' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (300, N'Imieniny obchodzą: Amand, Amanda, Bernard, Bonawentura, Damian, Demetriusz, Ewaryst, Felicysym, Fulko, Leonarda, Lucjan, Lucyna, Ludomiła, Lutosław, Łucjan, Łucjana, Marcjan, Rustyk i Rustyka.
                    Austria – Święto Narodowe (Deklaracja Neutralności 1955)
                    Benin – Święto Sił Zbrojnych
                    Nauru – Angam Day
                    Międzynarodowe – Światowy Dzień Donacji i Transplantacji (w Polsce obchodzony również Dzień Transplantacji, 26 stycznia)
                    ', CAST(N'2016-10-26' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (301, N'Imieniny obchodzą: Barnim, Frumencjusz, Józef, Kapitolina, Manfred, Manfreda, Siestrzemił i Wielebor.
                    Grecja – Dzień Flagi
                    Saint Vincent i Grenadyny, Turkmenistan – Święto Niepodległości
                    Międzynarodowe – Światowy Dzień Dziedzictwa Audiowizualnego (proklamowany przez Zgromadzenie Ogólne ONZ, pod patronatem UNESCO)
                    ', CAST(N'2016-10-27' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (302, N'Imieniny obchodzą: Anastazja, Cyryl, Cyryla, Domabor, Faro, Fidelis, Honorat, Juda Tadeusz, Ksymena, Sabina, Szymon, Tadeusz, Wielimir, Wincenty i Wszeciech.
                    Cypr, Grecja – Dzień Ohi (święto państwowe, upamiętniające odrzucenie przez greckiego premiera Ioannisa Metaxasa zgody na lądowanie w Grecji brytyjskich wojsk lądowych w 1941 roku)
                    Czechy – rocznica ogłoszenia niepodległości przez Czechosłowację w 1918 roku
                    ', CAST(N'2016-10-28' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (303, N'Imieniny obchodzą: Dalia, Dalimir, Donat, Ermelinda, Euzebia, Felicjan, Franciszek, Ida, Lubgost, Maksymilian, Narcyz, Piotr, Serafin, Teodor, Walenty, Walentyn, Wioletta, Zenobiusz i Żelibor.
                    Turcja – Święto Republiki (święto państwowe, rocznica proklamowania republiki)
                    Międzynarodowe – Światowy Dzień Chorych na Łuszczycę, Światowy Dzień Udaru Mózgu (ustanowiony przez World Stroke Organization)
                    ', CAST(N'2016-10-29' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (304, N'Imieniny obchodzą: Anioł, Benwenuta, Edmund, Eutropia, Gerard, German, Julian, Klaudiusz, Liberat, Makary, Maksym, Marceli, Marcjan, Przemysław, Saturnin, Serapion, Sęczygniew, Sulimir, Zenobia
                    Polska – Dzień Spódnicy, Dzień Kobiecości (ang. National Skirt Day [NSD], 10 marca)
                    Rosja – Dzień Pamięci Ofiar Represji Politycznych (od 1991)
                    ', CAST(N'2016-10-30' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (305, N'Imieniny obchodzą: Alfons, Antonin, Augusta, Bega, Godzimir, Krzysztof, Krzysztofa, Kwintyn, Lucyla, Lucyliusz, Łukasz, Narcyz, Saturnin, Saturnina, Tomasz, Urban i Wolfgang
                    dawn. Dziady (jesienne, słowiańskie święto upamiętniające zmarłych obchodzone w noc z 31 października na 1 listopada)
                    Celtowie – wigilia Samhain
                    Kambodża – Urodziny Króla
                    Protestantyzm – Święto Reformacji (w rocznicę wystąpienia Marcina Lutra)
                    Międzynarodowe:

                    Światowy Dzień Oszczędzania (z inicjatywy przedstawicieli największych europejskich banków w 1924 roku)
                    Halloween (w wigilię Wszystkich Świętych)


                    ', CAST(N'2016-10-31' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (306, N'Imieniny obchodzą: Andrzej, Benignus, Benigny, Cyrenia, Jakub, Jan, Julianna, Konradyn, Konradyna, Licyniusz, Marceli, Maria, Nikola, Rajner, Robert, Seweryn, Teodor, Warcisław i Wiktoryna
                    Algieria – Święto Rewolucji (święto narodowe)
                    Antigua i Barbuda – Święto Niepodległości (święto narodowe)
                    Brytyjskie Wyspy Dziewicze – Dzień Wolności
                    Bułgaria – Dzień Budzicieli Narodu
                    Celtowie – Samhain
                    Międzynarodowe – Światowy Dzień Wegan
                    ', CAST(N'2016-11-01' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (307, N'Imieniny obchodzą: Agapiusz, Ambroży, Bohdan, Bohdana, Eudoksjusz, Jerzy, Malachiasz, Małgorzata, Marcjan, Stomir, Teodot, Tobiasz, Wiktoryn, Wojsław i Wojsława
                    międzynarodowe – Międzynarodowy Dzień Zakończenia Bezkarności Popełniania Zbrodni wobec Dziennikarzy (rezolucja A/RES/68/163)
                    Wyspy Dziewicze Stanów Zjednoczonych – Dzień Niepodległości
                    Polska – Zaduszki
                    ', CAST(N'2016-11-02' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (308, N'Imieniny obchodzą: Bogumił, Cezary, Chwalisław, German, Ginewra, Hubert, Huberta, Marcin, Sylwia, Szymon, Teofil, Walenty, Walentyn, Wenefryda i Witalis.
                    Hubertus – święto myśliwych, leśników i jeźdźców
                    Dominika, Mikronezja, Panama – Święto Niepodległości
                    Japonia – Dzień Kultury (Bunka-no Hi)
                    Malediwy – Dzień Zwycięstwa
                    ', CAST(N'2016-11-03' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (309, N'Imieniny obchodzą: Agrykola, Amancjusz, Dżesika, Emeryk, Emeryka, Florus, Franciszka, Helena, Joannicjusz, Karol, Karol Boromeusz, Modesta, Mojżesz, Mszczujwoj, Mścisława, Mściwoj, Olgierd, Perpet, Perpetua, Sędomir, Sędzimir i Witalis
                    Dominika – Dzień na Rzecz Wspólnoty
                    Mariany Północne – Dzień Obywatelstwa
                    Panama – Dzień Flagi
                    Rosja – Dzień Jedności Narodowej
                    Tonga – Święto Konstytucji
                    ', CAST(N'2016-11-04' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (310, N'Imieniny obchodzą: Blandyn, Blandyna, Dalimiar, Dalmir, Dominik, Filotea, Filoteusz, Florian, Gerald, Magnus, Marek, Sławomir, Sylwan, Teotym i Trofima.
                    Salwador – Pierwsze Wołanie o Niepodległość
                    Wielka Brytania – Dzień Guya Fawkesa, święto fajerwerków.
                    ', CAST(N'2016-11-05' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (311, N'Imieniny obchodzą: Anita, Bogdana, Daniela, Feliks, Gabriela, Hieronim, Kalinik, Krystyna, Leonard, Melaniusz, Nonnus, Teobald, Trzebowit, Walenty, Walentyn i Wincenta.
                    Dominikana, Tadżykistan – Święto Konstytucji
                    Maroko – Rocznica Zielonego Marszu
                    Międzynarodowe – Międzynarodowy Dzień Zapobiegania Wyzyskowi Środowiska Naturalnego podczas Wojen i Konfliktów Zbrojnych (proklamowany przez Zgromadzenie Ogólne ONZ w 2001 roku)
                    ', CAST(N'2016-11-06' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (312, N'Imieniny obchodzą: Achilles, Amaranta, Antoni, Engelbert, Florencjusz, Florenty, Gizbert, Herkulan, Hezychiusz, Ingarda, Karina, Longin, Longina, Melchior, Nikander, Nikandra, Przemił, Rufus, Wilibrord, Wincenty i Żelibrat
                    Bangladesz – Święto Rewolucji
                    Białoruś – Święto Rewolucji Październikowej
                    Polska – Dzień Kotleta Schabowego
                    dawn. Polska Rzeczpospolita Ludowa – dawne święto Rewolucji październikowej
                    Tunezja – Święto Nowej Ery
                    Międzynarodowe – Międzynarodowy Dzień Fizyki Medycznej
                    ', CAST(N'2016-11-07' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (313, N'Imieniny obchodzą: Bogdan, Bogodar, Bogudar, Bohdan, Bożdar, Bożydar, Godfryd, Gotfryd, Jan, Józef, Klaudiusz, Klarus, Marcin, Maur, Paweł, Sewer, Sewerian, Sędziwoj, Symforian, Symforiana, Symplicjusz, Symplicy, Wiktoryn i Wilehad
                    Bośnia i Hercegowina – Dzień Św. Dymitra
                    Cerkiew prawosławna – Świętego Męczennika Dymitra
                    Mikronezja – Święto Konstytucji
                    ', CAST(N'2016-11-08' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (314, N'Imieniny obchodzą: Agrypin, Aleksander, Benignus, Benigny, Bogdan, Dziwigor, Elżbieta, Genowefa, Gorzysław, Joanna, Lilla, Ludwik, Nestor, Orestes, Ścibor, Świecław, Teodor i Ursyn
                    Kambodża – Święto Niepodległości
                    Międzynarodowe

                    Europejski Dzień Wynalazcy
                    Międzynarodowy Dzień Walki z Faszyzmem i Antysemityzmem


                    Nepal – Święto Konstytucji
                    Pakistan – Rocznica Urodzin Muhammada Iqbala
                    ', CAST(N'2016-11-09' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (315, N'Imieniny obchodzą: Andrzej, Anian, Demetriusz, Florencja, Just, Leon, Leona, Ludomir, Monitor, Nimfa, Probus, Stefan, Tryfena i Uniebog.
                    Francja – święto św. Monitora
                    Panama – Rocznica Pierwszego Wołania o Niepodległość
                    Romowie – Zniesienie Niewolnictwa
                    Turcja – Dzień Pamięci Kemala Atatürka
                    Stany Zjednoczone – Święto Korpusu Piechoty Morskiej
                    ', CAST(N'2016-11-10' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (316, N'Imieniny obchodzą: Anastazja, Alicja, Bartłomiej, Jan, Jozafat, Maciej, Marcin, Maryna, Menas, Pafnucy, Prot, Sobieżyr i Teodor
                    Angola – Święto Niepodległości
                    Belgia – Święto Wyzwolenia
                    Chińska Republika Ludowa – Dzień Singli
                    Finlandia – Dzień Ojca
                    Francja – Rocznica Rozejmu
                    Malediwy – Święto Republiki
                    Polska

                    Narodowe Święto Niepodległości (dzień wolny od pracy)
                    Dzień Świętego Marcina
                    Dzień Służby Cywilnej
                    dawn. Święto Orderu Virtuti Militari w latach 1933–1989 (3 maja w latach 1919–1933)


                    Republika Chińska (Tajwan) – Dzień Bliźniąt
                    Stany Zjednoczone – Dzień Weteranów
                    Wspólnota Narodów – Dzień Pamięci
                    ', CAST(N'2016-11-11' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (317, N'Imieniny obchodzą: Arsacjusz, Aureliusz, Cibor, Czcibor, Emilian, Gabriel, Jan, Jonasz, Jozafat, Kunibert, Nila, Nilus, Publiusz, Renat, Renata, Witold i Witolda
                    Liberia – Dzień Pamięci
                    Międzynarodowe:

                    Światowy Dzień Zapalenia Płuc


                    Republika Chińska (Tajwan) – Urodziny Sun Jat-sena
                    Timor Wschodni – Dzień Santa Cruz[potrzebny&#160;przypis]
                    ', CAST(N'2016-11-12' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (318, N'Imieniny obchodzą: Abbo, Abbon, Alojzy, Antonin, Arkadia, Arkadiusz, Arkady, Augustyna, Benedykt, Brykcjusz, Dalmacjusz, Dydak, Eugeniusz, Eutychian, German, Izaak, Jan, Kalikst, Krystyn, Liwia, Mateusz, Mikołaj, Nicefor, Paschazy, Probus, Stanisław, Walenty, Walentyn, Wiktor, Wilhelm i Włodzisław
                    Międzynarodowe – Międzynarodowy Dzień Niewidomych(od 1964 roku święto osób niewidomych) (od 1946 roku, w rocznicę urodzin Valentina Haüya, założyciela pierwszej szkoły dla niewidomych)
                    Polska – Święto Służby Uzbrojenia i Elektroniki (od 2009 r.)
                    ', CAST(N'2016-11-13' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (319, N'Imieniny obchodzą: Agrypin, Agryppa, Antyd, Damian, Elżbieta, Filomen, Hipacy, Jan, Józef, Jukund, Klementyn, Kosma, Laurenty, Lewin, Mikołaj, Montan, Serapion, Stefan, Ścibor, Ścibora, Świecław, Teodot, Wawrzyniec i Wszerad
                    Indie – Dzień Dziecka (urodziny Jawaharlala Nehru)
                    Jordania – Dzień Pamięci Króla Husajna
                    Międzynarodowe – Światowy Dzień Cukrzycy (ustanowiony przez Międzynarodową Federację Diabetologiczną w 1991 w rocznicę urodzin odkrywcy insuliny Fredericka Bantinga i w 2006 przez Zgromadzenie Ogólne ONZ)
                    Polska – Ogólnopolski Dzień Seniora (na arenie międzynarodowej obchodzony 1 października)
                    ', CAST(N'2016-11-14' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (320, N'Imieniny obchodzą: Albert, Alfons, Artur, Gurias, Idalia, Józef, Leopold, Leopoldyna, Przybygniew, Sekundus i Roger
                    Autonomia Palestyńska – Święto Niepodległości
                    Belgia – Dzień Świętego Leopolda, Dzień Wspólnoty Niemieckojęzycznej Belgii
                    Brazylia – Święto Republiki
                    Polska – Święto Wojskowego Centrum Geograficznego (od 2009)
                    Wybrzeże Kości Słoniowej – Dzień Pokoju
                    ', CAST(N'2016-11-15' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (321, N'Imieniny obchodzą: Agnieszka, Audomar, Ariel, Aureliusz, Dionizy, Edmund, Eucheriusz, Gertruda, Łucja, Małgorzata, Niedamir, Otmar i Patrokles
                    Islandia – Dzień Języka Islandzkiego
                    Międzynarodowe – Międzynarodowy Dzień Tolerancji (ustanowione przez Zgromadzenie Ogólne ONZ w 1966 roku)
                    Polska – Dzień Służby Zagranicznej
                    ', CAST(N'2016-11-16' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (322, N'Imieniny obchodzą: Alfeusz, Arabella, Dionizy, Drogomir, Drogoradz, Elżbieta, Floryn, Grzegorz, Hugo, Hugon, Jan, Jozafat, Roch, Salomea, Sulibor, Wiktoria, Zacheusz i Zbysław
                    Azerbejdżan – Dzień Narodowego Odrodzenia
                    Czechy, Słowacja – Dzień Walki o Wolność i Demokrację
                    Demokratyczna Republika Konga – Święto Armii
                    Międzynarodowe:

                    Międzynarodowy Dzień Studenta upamiętniający krwawo stłumioną demonstrację czechosłowackich studentów przeciwko nazistowskiej agresji z 1939 roku; święto obchodzone z inicjatywy Europejskiego Forum Studentów
                    Światowy Dzień Wcześniaka (od 2012 z inicjatywy Europejskiej Fundacji na rzecz Opieki nad Noworodkami, EFCNI)


                    Polska – Dzień bez Długów (od 2009)
                    Wyspy Marshalla – Dzień Prezydenta
                    ', CAST(N'2016-11-17' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (323, N'Imieniny obchodzą: Agnieszka, Aniela, Cieszymysł, Filipina, Gabriela, Galezy, Hezychiusz, Józefa, Karolina, Klaudyna, Leonard, Noe, Odo, Odon, Roman i Tomasz
                    Haiti – Święto Sił Zbrojnych
                    Łotwa – Dzień Proklamacji Niepodległości
                    Maroko – Święto Niepodległości
                    Oman – Dzień Urodzin Sułtana
                    Uzbekistan – Dzień Flagi
                    ', CAST(N'2016-11-18' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (324, N'Imieniny obchodzą: Barlaam, Barbara, Dionizy, Dargosław, Elżbieta, Faust, Jakub, Kryspin, Maksym, Małowid, Matylda, Paweł, Salomea, Seweryn i Teodor.
                    Belize – Święto Garifuny
                    Brazylia – Dzień Flagi
                    Monako – Święto Księcia Rainiera (święto narodowe)
                    Mali – Rocznica Zamachu Stanu
                    Międzynarodowe:

                    Światowy Dzień Mężczyzn (Trynidad i Tobago oraz kraje zaproszone; w Polsce nieoficjalnie 10 marca)
                    Światowy Dzień Toalet
                    Międzynarodowy Dzień Zapobiegania Przemocy Wobec Dzieci
                    Światowy Dzień Ubogich (po raz pierwszy obchodzony w 2017 r. z inicjatywy papieża Franciszka)


                    Portoryko – Dzień Odkrycia
                    ', CAST(N'2016-11-19' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (325, N'Imieniny obchodzą: Agapiusz, Ampelia, Ampeliusz, Edmund, Eustachy, Feliks, Fortunata, Grzegorz, Lubomir, Maksencja, Maria, Narzes, Oktawia, Oktawiusz, Rafał, Sędzimir, Sylwester, Sylwestra, Symplicjusz, Symplicy, Tespezjusz i Tespezy
                    Międzynarodowe

                    Dzień Pamięci Osób Transpłciowych
                    Dzień Industrializacji Afryki (ustanowione w 1989 roku przez Zgromadzenie Ogólne ONZ)
                    Powszechny Dzień Dziecka (Organizacja Narodów Zjednoczonych)


                    Brazylia – Dzień Zumbiego
                    Meksyk – Święto Rewolucji
                    ', CAST(N'2016-11-20' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (326, N'Imieniny obchodzą: Albert, Elwira, Gelazja, Gelazy, Heliodor, Janusz, Kadok, Kolumban, Maria, Regina, Rufus, Twardosław i Wiesław
                    Międzynarodowe:

                    Światowy Dzień Życzliwości i Pozdrowień
                    Światowy Dzień Telewizji (ustanowiony przez Zgromadzenie Ogólne ONZ w 1996 roku)


                    Polska:

                    Dzień Pracownika Socjalnego
                    Święto Służby Czołgowo-Samochodowej


                    Ukraina – Dzień Godności i Wolności
                    ', CAST(N'2016-11-21' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (327, N'Imieniny obchodzą: Cecylia, Ernestyna, Filemon, Filemona, Marek, Maur, Salwator, Stefan, Wszemił i Wszemiła.
                    Gwinea – Dzień Inwazji 1970 roku
                    Liban – Święto Niepodległości
                    Polska – rozpoczynają się Dni Honorowego Krwiodawstwa ustanowione przez Polski Czerwony Krzyż (do 26 listopada)
                    ', CAST(N'2016-11-22' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (328, N'Imieniny obchodzą: Amfiloch, Felicyta, Fotyna, Grzegorz, Klemens, Lukrecja, Michał, Orestes, Przedwoj i Syzyniusz.
                    Gruzja – Giorgoba (Dzień św. Jerzego, patrona Gruzji)
                    Japonia – Dzień Dziękczynienia za Pracę (zob. kalendarz japoński)
                    Polska – Święto Wojskowej Służby Prawnej
                    ', CAST(N'2016-11-23' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (329, N'Imieniny obchodzą: Agnieszka, Aleksander, Biruta, Chryzogon, Dargorad, Dobrosław, Emilia, Enfleda, Felicjana, Felicjanna, Firmina, Flora, Franciszek, Jan, Jaśmina, Joachim, Pęcisław, Protazy, Roman, Twardomir, Walenty i Walentyn
                    Demokratyczna Republika Konga – Rocznica Nowego Reżimu
                    Polska – Katarzynki (w wigilię św. Katarzyny Aleksandryjskiej, żeński odpowiednik Andrzejek)
                    Rosja – Dzień Morsa
                    Serbski Kościół Prawosławny – Dzień Stefana III
                    Turcja – Dzień Nauczyciela
                    ', CAST(N'2016-11-24' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (330, N'Imieniny obchodzą: Beatrycze, Elżbieta, Erazm, Godzimir, Józef, Katarzyna, Maria, Merkury, Mojżesz, Piotr i Tęgomir
                    Bośnia i Hercegowina – Święto Państwowości
                    Surinam – Święto Niepodległości
                    Ukraina – Dzień Pamięci Ofiar Wielkiego Głodu i Represji Politycznych
                    Międzynarodowe:

                    Międzynarodowy Dzień Eliminacji Przemocy wobec Kobiet (ustanowione przez Zgromadzenie Ogólne ONZ)
                    Światowy Dzień Pluszowego Misia, ustanowione w 2002 roku w 100. rocznicę powstania zabawki pluszowego misia, nazwanego na cześć 26. prezydenta Stanów Zjednoczonych Theodora (Teddy’ego) Roosevelta (ang. Teddy Bear); obchodzone również w Polsce


                    Polska:

                    Dzień Kolejarza (od 1981 roku w dniu wspomnienia św. Katarzyny Aleksandryjskiej)


                    Kościół mariawicki – wspomnienie śmierci Felicjana Marii Franciszka Strumiłły, pierwszego kapłana mariawity
                    ', CAST(N'2016-11-25' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (331, N'Imieniny obchodzą: Alipiusz, Ammonia, Ammoniusz, Delfin, Dobiemiest, Faust, Hezychiusz, Jan, Kajetana, Konrad, Konrada, Lechosław, Lechosława, Leonard, Marceli, Nikon, Pachomiusz, Piotr, Stylian, Sylwester, Sylwestra, Syrycjusz i Teodor
                    Mongolia – Święto Niepodległości
                    ', CAST(N'2016-11-26' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (332, N'Imieniny obchodzą: Achacjusz, Achacy, Astryda, Bernardyn, Damazy, Dominik, Franciszek, Gustaw, Gustawa, Irenarch, Jakub, Jarosław, Jozafat, Maksym, Małgorzata, Oda, Prymityw, Radosław, Stojgniew, Walerian, Walery, Wergilia, Wergiliusz, Wirgilia, Wirgiliusz, Zygfryd, Zygfryda i Żaneta
                    Kościół prawosławny:

                    Filip Apostoł
                    Grzegorz Palamas, arcybiskup Salonik


                    ', CAST(N'2016-11-27' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (333, N'Imieniny obchodzą: Berta, Eustachy, Feliks, Ginter, Gościrad, Grzegorz, Guncerz, Gunter, Jakub, Krescenty (Krescencjusz, Krescens), Kwieta, Lesław, Lesława, Manswet, Radowit, Rufus, Sostenes, Stefan, Teodora, Tristan, Urban, Walerian, Zdziesław i Zdzisław.
                    Albania – Święto Niepodległości
                    Czad – Dzień Proklamacji Republiki
                    Kościół Katolicki Mariawitów – wspomnienie św. Antoniny Wiłuckiej arcykapłanki
                    Mauretania – Święto Niepodległości
                    Panama – Święto Niepodległości
                    ', CAST(N'2016-11-28' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (334, N'Imieniny obchodzą: Błażej, Błażeja, Bolemysł, Dionizy, Filomen, Franciszek, Fryderyk, Klementyna, Pafnucy, Paramon, Przemysł, Radbod, Saturnin, Siedlewit, Syzyniusz i Walter
                    Liberia – Rocznica urodzin prezydenta Williama Tubmana
                    Międzynarodowe – Międzynarodowy Dzień Solidarności z Narodem Palestyńskim (ustanowione przez Zgromadzenie Ogólne ONZ)
                    Polska – Dzień Podchorążego
                    Serbia – Święto Republiki
                    Vanuatu – Dzień Jedności
                    ', CAST(N'2016-11-29' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (335, N'Imieniny obchodzą: Andrzej, Fryderyk, Justyna, Konstancjusz, Kutbert, Maura, Tadea, Zbysława i Zozym
                    Barbados, Jemen – Święto Niepodległości
                    Filipiny – Dzień Andrésa Bonifacio
                    Międzynarodowe – akcja „Cities for Life” („Miasta dla życia”), właśc. „Cities for Life/Cities Against the Death Penalty”, czyli miasta przeciwko karze śmierci; obchodzona z inicjatywy ekumenicznej wspólnoty Sant Egidio dla upamiętnienia zniesienia kary śmierci w pierwszym kraju świata – Wielkim Księstwie Toskanii w 1786 roku
                    Szkocja – Dzień św. Andrzeja, patrona Szkocji
                    ', CAST(N'2016-11-30' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (336, N'Imieniny obchodzą: Aleksander, Ananiasz, Antoni, Blanka, Długomił, Edmund, Eligia, Eligiusz, Florencja, Godzisław, Gosław, Gosława, Jan, Natalia, Prokul, Projektus, Rudolf, Rudolfa, Rudolfina, Sobiesław i Sobiesława
                    Czad – Festiwal Wolności i Demokracji
                    Kazachstan – Dzień Pierwszego Prezydenta
                    Międzynarodowe:

                    Światowy Dzień AIDS (ustanowione w 1988 roku przez Zgromadzenie Ogólne ONZ)
                    Rozpoczyna się „Europejski Tydzień Autyzmu” (do 7 grudnia)


                    Polska – rozpoczynają się „Dni Walki z Gruźlicą i Chorobami Płuc” (do 10 grudnia; Światowy Dzień Gruźlicy obchodzony jest 24 marca)
                    Portugalia – Święto Odnowienia Niepodległości, Dzień Młodzieży
                    Republika Środkowoafrykańska – Święto Republiki
                    Rumunia – Rocznica Zjednoczenia Siedmiogrodu i Rumunii
                    ', CAST(N'2016-12-01' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (337, N'Imieniny obchodzą: Aurelia, Balbina, Bibiana, Bibianna, Budzisław, Budzisława, Jan, Ludwina, Maria, Paulina, Rafał, Sulisław, Sylwan, Sylweriusz, Walenty, Walentyn, Wiktoryn i Zbylut
                    Laos – Święto Republiki (1975, rocznica proklamowania republiki)
                    Międzynarodowe – Międzynarodowy Dzień Upamiętniający Zniesienie Niewolnictwa (ustanowione przez Zgromadzenie Ogólne ONZ w rocznicę uchwalenia Konwencji Narodów Zjednoczonych o likwidacji handlu ludźmi z 2 grudnia 1949 roku)
                    Zjednoczone Emiraty Arabskie – rocznica proklamowania federacji (1971)
                    ', CAST(N'2016-12-02' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (338, N'Imieniny obchodzą: Atalia, Biryn, Ema, Emma, Franciszek, Franciszek Ksawery, Gerlinda, Hilaria, Kasjan, Kryspin, Ksawery, Lucjusz, Łucjusz, Mirokles, Sofoniasz i Uniemir
                    Ghana – Narodowy Dzień Farmerów
                    Międzynarodowe:

                    Międzynarodowy Dzień Osób Niepełnosprawnych (ustanowione w 1992 roku przez Zgromadzenie Ogólne ONZ)
                    Międzynarodowy Dzień Języka Baskijskiego (ang. International Day of the Basque Language (ENE), ustanowiony w 1948 roku podczas VII Kongresu Eusko Ikaskuntza w Bayonne)


                    Polska – Dzień Naftowca i Gazownika (w czasach PRL Dzień Naftowca obchodzono 4 grudnia)
                    ', CAST(N'2016-12-03' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (339, N'Imieniny obchodzą: Barbara, Benon, Bernard, Bratomiła, Bratumiła, Chrystian, Ciechosław, Ciechosława, Cieszybor, Feliks, Filip, Hieronim, Jan, Klemens, Krystian, Marut, Maruta, Marutas, Melecjusz, Osmund i Teofan.
                    Indie – Dzień Marynarki Wojennej
                    Kościół prawosławny – Wprowadzenie Bogurodzicy do Świątyni (jedno z 12 głównych świąt)
                    Polska:

                    Święto Wojsk Rakietowych i Artylerii
                    Barbórka – Dzień Górnika


                    Tonga – Dzień Króla Jerzego Tupou V
                    ', CAST(N'2016-12-04' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (340, N'Imieniny obchodzą: Anastazy, Bartosz, Bartłomiej, Dalmacjusz, Feliks, Gerald, Geraldyna, Jan, Juliusz, Kryspin, Kryspina, Krystyna, Mikołaj, Pelin, Pelina, Pęcisława i Sabbas.
                    Haiti – Święto Odkrycia Haiti
                    Międzynarodowe

                    Międzynarodowy Dzień Wolontariusza (Międzynarodowy Dzień Wolontariusza Wspierającego Rozwój Gospodarczy i Społeczny, ustanowiony przez Zgromadzenie Ogólne ONZ 17 grudnia 1985)
                    Światowy Dzień Gleby – ustanowiony w 2002 przez Międzynarodową Unię Gleboznawczą (IUSS), zatwierdzony w 2013 r. przez Zgromadzenie Ogólne ONZ; datę 5 grudnia wybrano by uczcić króla Tajlandii Bhumibola Adulyadeja


                    Tajlandia:

                    Urodziny Króla
                    Dzień Ojca


                    ', CAST(N'2016-12-05' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (341, N'Imieniny obchodzą: Abraham, Angelika, Bonifacy, Dionizja, Emilian, Heliodor, Leoncja, Mikołaj, Morzysława, Piotr, Polichroniusz, Tercjusz.
                    Finlandia – Święto Niepodległości
                    Hiszpania – Święto Konstytucji
                    Polska – mikołajki (Dzień św. Mikołaja)
                    ', CAST(N'2016-12-06' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (342, N'Imieniny obchodzą: Agaton, Ambrozja, Ambroży, Atenodor, Eutychian, Józefa, Marcin, Marcisław, Ninomysł, Polikarp, Sabin, Siemirad, Urban i Zdziemił
                    Armenia – Dzień Pamięci Trzęsienia Ziemi
                    Międzynarodowe – Międzynarodowy Dzień Lotnictwa Cywilnego (ustanowione w 1996 przez Zgromadzenie Ogólne ONZ)
                    ', CAST(N'2016-12-07' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (343, N'Imieniny obchodzą: Alojzy, Apollo, Boguwola, Edyta, Elfryda, Euchariusz, Euchary, Hildemar, Makary, Maria, Narcyza, Patapiusz, Potapiusz, Romaryk i Świedarg
                    Buddyzm – Dzień Oświecenia Buddy – najważniejsze buddyjskie święto w roku
                    Bułgaria – Dzień Studenta
                    Falklandy – rocznica bitwy koło Falklandów
                    Guam – Dzień Matki Bożej z Camarin
                    Panama – Dzień Matki
                    Polska – Dzień Kupca wzgl. Święto Kupiectwa Polskiego (w dzień wspomnienia Matki Bożej Niepokalanie Poczętej, zwanej „Matką Bożą Kupiecką”)
                    Uzbekistan – Święto Konstytucji
                    ', CAST(N'2016-12-08' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (344, N'Imieniny obchodzą: Chwalimira, Delfina, Gorgonia, Jan, Leokadia, Liboriusz, Naczęmir, Piotr, Prokul, Waleria, Wielisława, Wiesław, Wiesława i Wrocisław
                    Mariany Północne – Święto Konstytucji
                    Międzynarodowe – Międzynarodowy Dzień Przeciwdziałania Korupcji (ustanowione przez Zgromadzenie Ogólne ONZ 31 października 2003 roku)
                    Peru – Dzień Armii
                    Tanzania – Święto Niepodległości
                    ', CAST(N'2016-12-09' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (345, N'Imieniny obchodzą: Bogdał, Bogdan, Bogodał, Brajan, Daniel, Donat, Eulalia, Grzegorz, Hermogenes, Judyta, Julia, Loreta, Maria, Maur, Melchiades, Menas, Polidor, Switun, Unierad i Unirad.
                    Międzynarodowe

                    Dzień Praw Człowieka (święto państwowe w: Gwinei Równikowej, Namibii, Kambodży, Kiribati, Turks i Caicos)
                    Międzynarodowy Dzień Praw Zwierząt (w dzień ratyfikacji przez Zgromadzenie Ogólne ONZ w 1948 roku Powszechnej deklaracji praw człowieka; uchwalony 21 września 1977 roku w Londynie przez Międzynarodową Federację Praw Zwierzęcia)


                    Polska – Dzień Odlewnika (święto branżowe)
                    ', CAST(N'2016-12-10' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (346, N'Imieniny obchodzą: Artur, Damazy, Daniel, Gościwit, Hieronim, Maria, Poncjan, Sabin, Stefan, Waldemar, Walenty, Walentyn, Wilburga i Wojmir
                    Burkina Faso – Proklamacja Republiki
                    Międzynarodowe – Międzynarodowy Dzień Terenów Górskich (ustanowiony przez Zgromadzenie Ogólne ONZ w 2002)
                    ', CAST(N'2016-12-11' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (347, N'Imieniny obchodzą: Adelajda, Aleksander, Amonaria, Bartosz, Dionizja, Edburga, Epimach, Franciszka, Gościwit, Justyn, Konrad, Konrada, Konstancjusz, Liberata, Maksanty, Maksencjusz, Merkuria, Paramon, Przybysława, Spirydon, Suliwuj i Synezjusz.
                    Kenia – Święto Niepodległości (Jamhuri)
                    Rosja – Święto Konstytucji
                    Turkmenistan – Dzień Neutralności
                    ', CAST(N'2016-12-12' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (348, N'Imieniny obchodzą: Antioch, Antoni, Aubert, Auksencja, Auksencjusz, Auksenty, Edburga, Eugeniusz, Jodok, Łucja, Orestes, Otylia, Róża, Samboja, Walenty i Walentyn.
                    Malta – Święto Republiki
                    Polska:

                    Dzień Pamięci Ofiar Stanu Wojennego
                    Dzień Księgarza


                    Santa Lucia, Szwecja – Dzień Świętej Łucji
                    ', CAST(N'2016-12-13' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (349, N'Imieniny obchodzą: Agnellus, Arseniusz, Bertold, Druzus, Eutropia, Gorzysław, Heron, Izydor, Jan, Nahum, Nikazjusz, Nikazy, Noemi, Pompejusz, Sławobor, Teodor, Wenancjusz, Wenanty, Wiator i Zozym.
                    Indie – National Energy Conservation Day
                    ', CAST(N'2016-12-14' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (350, N'Imieniny obchodzą: Antoni, Bachus, Bakchus, Drogosław, Drogosława, Euzebiusz, Ireneusz, Jan, Maksymin, Maksymina, Maria, Maryn, Maryniusz, Mścigniew, Mścigniewa, Nina, Saturnin, Teodor, Walerian, Weronika, Wiktor i Wolimir
                    Esperantyści – Dzień Ludwika Zamenhofa
                    ', CAST(N'2016-12-15' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (351, N'Imieniny obchodzą: Agrykola (m.), Ananiasz, Adelajda, Albina, Alina, Deder, Dyter, Euzebiusz, Konkordiusz, Maria, Sebastian, Tyter, Walenty, Walentyn, Wolisław, Wolisława, Zdzisław i Zdzisława.
                    Bahrajn – Dzień Narodowy
                    Bangladesz – Dzień Zwycięstwa
                    Kazachstan – Dzień Niepodległości
                    Republika Południowej Afryki – Dzień Pojednania
                    ', CAST(N'2016-12-16' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (352, N'Imieniny obchodzą: Bega, Florian, Jan, Łazarz, Łukasz, Modest, Wiwina, Żerosław, Żyrosław
                    Bhutan – Dzień Bhutanu
                    Polska – Dzień bez Przekleństw
                    Polska, Szczecin – Rocznica Wydarzeń Grudnia 1970 r.
                    Starożytny Rzym – początek Saturnaliów (trwały do 24 grudnia)
                    ', CAST(N'2016-12-17' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (353, N'Imieniny obchodzą: Auksencja, Auksencjusz, Auksenty, Bogusław, Gościmiar, Kwintus, Miłosław, Nemezja, Rufus, Symplicjusz, Winebald, Winibald, Winibalda, Wszemir, Wunibald, Zofia i Zozym.
                    Niger – Dzień Republiki (rocznica proklamowania republiki 1958)
                    Międzynarodowe

                    Międzynarodowy Dzień Migrantów (ustanowione przez Zgromadzenie Ogólne ONZ)
                    Dzień języka arabskiego w ONZ w ramach dni języków


                    ', CAST(N'2016-12-18' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (354, N'Imieniny obchodzą: Abraham, Anastazy, Beniamin, Bogumiła, Dariusz, Eleonora, Grzegorz, Kazimiera, Mścigniew, Nemezjusz, Nemezy, Protazja, Tymoteusz i Urban.
                    ', CAST(N'2016-12-19' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (355, N'Imieniny obchodzą: Amon, Bogumił, Bogumiła, Dagmara, Dagna, Dominik, Eugeniusz, Krystian, Liberat, Makary, Ptolemeusz, Teofil, Ursycyn, Wincenty, Zefiryn i Zenon.
                    Międzynarodowe – Międzynarodowy Dzień Solidarności (od 2006 ustanowione przez Zgromadzenie Ogólne ONZ na zakończenie pierwszej Dekady Walki z Ubóstwem)
                    Polska – Dzień Ryby
                    Reunion – Rocznica Zniesienia Niewolnictwa
                    Rosja – Dzień pracownika organów bezpieczeństwa Federacji Rosyjskiej (Dzień Czekisty)
                    ', CAST(N'2016-12-20' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (356, N'Imieniny obchodzą: Anastazy, Balbin, Festus, Gliceriusz, Glicery, Honorat, Piotr, Temistokles, Tomasz, Tomisław i Tomisława
                    Przesilenie zimowe, dawn. Święto Godowe (etniczne słowiańskie) przypadające na 21 – 22 grudnia
                    Polska – Dzień Pamięci o Poległych i Zmarłych w Misjach i Operacjach Wojskowych poza Granicami Państwa
                    ', CAST(N'2016-12-21' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (357, N'Imieniny obchodzą: Beata, Dobrosułka, Drogomir, Dziesława, Dziwisław, Flawian, Franciszka, Franciszka Ksawera, Gryzelda, Honorata, Ischyrion, Judyta, Ksawera, Luboradz, Zenon i Zenona.
                    Przesilenie zimowe, początek astronomicznej zimy, najkrótszy dzień w roku na półkuli północnej przypadający na 21-22 grudnia; dawn. Święto Godowe (etniczne święto słowiańskie)
                    Hiszpania – Loteria Świąteczna (hiszp. Lotería de Navidad)
                    ', CAST(N'2016-12-22' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (358, N'Imieniny obchodzą: Anatola, Anatolia, Bazylides, Dagobert, Ewaryst, Ewarysta, Gelazy, Iwo, Iwona, Jan, Mardoniusz, Saturnin, Serwul, Sławomir, Sławomira, Teodul, Torlak i Wiktoria.
                    Egipt – Dzień Zwycięstwa
                    Japonia – święto narodowe (urodziny cesarza Akihito)
                    Międzynarodowe – Światowy Dzień Snowboardu, z inicjatywy Światowej Federacji Snowboardu (WSF)
                    ', CAST(N'2016-12-23' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (359, N'Imieniny obchodzą: Ada, Adam, Adamina, Adela, Delfin, Druzjan, Druzjanna, Eryk, Eryka, Ewa, Ewelina, Godzisław, Godzisława, Grzegorz, Grzymisława, Hermana, Hermina, Herminia, Irma, Irmina, Józef, Paula, Tarsylia i Zenobiusz.
                    Słowianie: Święto Godowe
                    ', CAST(N'2016-12-24' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (360, N'Imieniny obchodzą: Anastazja, Eugenia, Maria, Mateusz, Piotr i Siemosław
                    Pakistan – Dzień Kuaid-e-Azama
                    Europa Północna – Jul
                    ', CAST(N'2016-12-25' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (361, N'Imieniny obchodzą: Dionizy, Szczepan, Teodor, Wincencja, Wincenta, Wincentyna, Wrociwoj, Zenon i Zozym
                    Australia, Kanada, Wielka Brytania – Boxing Day
                    Polska – drugi dzień świąt Bożego Narodzenia, właśc. w Kościele katolickim wspomnienie obowiązkowe św. Szczepana, pierwszego męczennika
                    ', CAST(N'2016-12-26' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (362, N'Imieniny obchodzą: Bartłomiej, Cezary, Fabiola, Gosław, Jan, Krystyna, Maksym, Mateusz, Przybyrad, Przybysław, Sara, Teodor, Teofan i Żaneta.
                    Korea Północna – Święto Konstytucji
                    ', CAST(N'2016-12-27' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (363, N'Imieniny obchodzą: Antoni, Cezary, Dobrowieść, Domna, Domniusz, Emma, Godzisław, Teofila, Teona, Teonas i Troadiusz.
                    Hiszpania, Meksyk – Dzień Świętych Niewiniątek (el Día de los Santos Inocentes – w krajach hiszpańskojęzycznych jest on okazją do żartów i kawałów – odpowiednik prima aprilis),
                    ', CAST(N'2016-12-28' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (364, N'Imieniny obchodzą: Dawid, Domaradz, Dominik, Ebrulf, Ekhard, Gerard, Gerarda, Gosław, Honorat, Jonatan, Krescencjusz, Krescens, Krescenty, Marceli, Marcin, Prymian, Radowit, Saturnin, Tadea, Tomasz, Trofim i Wiktor.
                    ', CAST(N'2016-12-29' AS Date))
                    GO
                    INSERT [dbo].[GlobalEvents] ([GlobalEventId], [Content], [DateTime]) VALUES (365, N'Imieniny obchodzą: Anizja, Anizjusz, Dionizy, Egwin, Eksuperancjusz, Eugeniusz, Liberiusz, Łazarz, Małgorzata, Marceli, Perpet, Rajner, Sewer i Uniedrog.
                    Filipiny – Dzień Jose Rizala
                    ', CAST(N'2016-12-30' AS Date))
                    SET IDENTITY_INSERT [dbo].[GlobalEvents] OFF
                    GO"
                        );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[GlobalEvents] WHERE [GlobalEventId] BEETWEN 1 AND 365");
        }
    }
}
