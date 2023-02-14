# dziekanat_ASP.NET

Aplikacja Dziekanat zosta�a napisana za pomoca ASP.NET, programowania internetowego przy u�yciu sk�adni Razor. 

## Dzia�anie aplikacji 
Aplikacja odwzorowuje dzia�anie Wirtualnego Dziekanatu uczelni. Student po zalogowaniu si� do serwisu mo�e podejrze� swoje dane, dane dotyczace studi�w, kt�re odbywa, oraz swoje przedmioty i oceny. 

Zak�adka "Twoje dane" jest podzielona na trzy "podzak�adki" segregujace te informacje. 

![image](https://user-images.githubusercontent.com/65779777/218808834-05d34364-9b43-438f-abf3-aff39d56d45e.png)

Zawieraja one dane personalne studenta m.in. jego PESEL, p�e� i obywatelstwo, dane adresowe studenta wraz z jego emailem oraz numerem telefonu oraz informacje o wykszta�ceniu, rok uko�czenia szko�y, rodzaj matury, itp.

## Uruchomienie aplikacji

### Pobranie repozytorium i pierwsze uruchomienie 
Repozytorium aplikacji nale�y pobra�, a nast�pnie rozpakowac� i otworzy� w programie Visual Studio Community Edition. 
Dwukrotne klikni�cie na plik Dziekanat.sln powinno otworzy� na ekranie rozwiazanie aplikacji "Dziekanat". Na g�rnym pasku nale�y wybra� opcj� jak na screenie, aby uruchomi� back end aplikacji.

![image](https://user-images.githubusercontent.com/65779777/218805863-468df4ef-c2fe-4e42-9132-1d5a855b0b9e.png)



Widok w przegladarce powinien by� jak ponie�ej. Nale�y upewni� si�, �e w adresie znajduje si� poprawny localhost : `5001` .

![image](https://user-images.githubusercontent.com/65779777/218801491-9dba5033-a547-4db0-a68c-f2738511afb0.png)



Nast�pnie nale�y ponownie otworzy� folder z repozytorium w programie Visual Studio Community Edition. Otworzy� plik Dziekanat.sln i na g�rnym pasku wybra� DziekantBlazor, a nast�pnie go uruchomi�. Nale�y upewni� si�, �e w adresie znajduje si� poprawny localhost : `5002` .

![image](https://user-images.githubusercontent.com/65779777/218805771-c4b93823-1c4c-4500-bfac-c549f9ac52ea.png)


### Logowanie danymi z bazy
Poprawnie uruchomiona aplikacja powinna pozwoli� u�ytkownikowi na zalogowanie si� po wpisaniu danych: 

Login : `student1`
Has�o : `student1`

LUB

Login : `student2`
Has�o : `student2`

POLE LOGINU I HAS�A JEST CASE SENSITIVE. Nale�y zwr�ci� uwag� na poprawno�� wpisywanych danych r�wnie� od stwony wielkich i ma�ych liter. 

![image](https://user-images.githubusercontent.com/65779777/218806697-6ad1f6a6-59da-419e-8cec-18dca917bbf9.png)
