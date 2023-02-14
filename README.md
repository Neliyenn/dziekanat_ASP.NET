# dziekanat_ASP.NET

Aplikacja Dziekanat została napisana za pomoca ASP.NET, programowania internetowego przy użyciu składni Razor. 

## Działanie aplikacji 
Aplikacja odwzorowuje działanie Wirtualnego Dziekanatu uczelni. Student po zalogowaniu się do serwisu może podejrzeć swoje dane, dane dotyczace studiów, które odbywa, oraz swoje przedmioty i oceny. 

Zakładka "Twoje dane" jest podzielona na trzy "podzakładki" segregujace te informacje. 

![image](https://user-images.githubusercontent.com/65779777/218808834-05d34364-9b43-438f-abf3-aff39d56d45e.png)

Zawieraja one dane personalne studenta m.in. jego PESEL, płeć i obywatelstwo, dane adresowe studenta wraz z jego emailem oraz numerem telefonu oraz informacje o wykształceniu, rok ukończenia szkoły, rodzaj matury, itp.

## Uruchomienie aplikacji

### Pobranie repozytorium i pierwsze uruchomienie 
Repozytorium aplikacji należy pobrać, a następnie rozpakowacć i otworzyć w programie Visual Studio Community Edition. 
Dwukrotne kliknięcie na plik Dziekanat.sln powinno otworzyć na ekranie rozwiazanie aplikacji "Dziekanat". Na górnym pasku należy wybrać opcję jak na screenie, aby uruchomić back end aplikacji.

![image](https://user-images.githubusercontent.com/65779777/218805863-468df4ef-c2fe-4e42-9132-1d5a855b0b9e.png)



Widok w przegladarce powinien być jak ponieżej. Należy upewnić się, że w adresie znajduje się poprawny localhost : `5001` . 

![image](https://user-images.githubusercontent.com/65779777/218801491-9dba5033-a547-4db0-a68c-f2738511afb0.png)



Następnie należy ponownie otworzyć folder z repozytorium w programie Visual Studio Community Edition. Otworzyć plik Dziekanat.sln i na górnym pasku wybrać DziekantBlazor, a następnie go uruchomić. ! Należy upewnić się, że w adresie znajduje się poprawny localhost : ```5002``` .

![image](https://user-images.githubusercontent.com/65779777/218805771-c4b93823-1c4c-4500-bfac-c549f9ac52ea.png)


### Logowanie danymi z bazy
Poprawnie uruchomiona aplikacja powinna pozwolić użytkownikowi na zalogowanie się po wpisaniu danych: 

Login : ```student1```
Hasło : ```student1```

LUB

Login : ```student2```
Hasło : ```student2```

![image](https://user-images.githubusercontent.com/65779777/218806697-6ad1f6a6-59da-419e-8cec-18dca917bbf9.png)

