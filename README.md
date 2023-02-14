# dziekanat_ASP.NET

Aplikacja Dziekanat zosta³a napisana za pomoca ASP.NET, programowania internetowego przy u¿yciu sk³adni Razor. 

## Dzia³anie aplikacji 
Aplikacja odwzorowuje dzia³anie Wirtualnego Dziekanatu uczelni. Student po zalogowaniu siê do serwisu mo¿e podejrzeæ swoje dane, dane dotyczace studiów, które odbywa, oraz swoje przedmioty i oceny. 

Zak³adka "Twoje dane" jest podzielona na trzy "podzak³adki" segregujace te informacje. 

![image](https://user-images.githubusercontent.com/65779777/218808834-05d34364-9b43-438f-abf3-aff39d56d45e.png)

Zawieraja one dane personalne studenta m.in. jego PESEL, p³eæ i obywatelstwo, dane adresowe studenta wraz z jego emailem oraz numerem telefonu oraz informacje o wykszta³ceniu, rok ukoñczenia szko³y, rodzaj matury, itp.

## Uruchomienie aplikacji

### Pobranie repozytorium i pierwsze uruchomienie 
Repozytorium aplikacji nale¿y pobraæ, a nastêpnie rozpakowacæ i otworzyæ w programie Visual Studio Community Edition. 
Dwukrotne klikniêcie na plik Dziekanat.sln powinno otworzyæ na ekranie rozwiazanie aplikacji "Dziekanat". Na górnym pasku nale¿y wybraæ opcjê jak na screenie, aby uruchomiæ back end aplikacji.

![image](https://user-images.githubusercontent.com/65779777/218805863-468df4ef-c2fe-4e42-9132-1d5a855b0b9e.png)



Widok w przegladarce powinien byæ jak ponie¿ej. Nale¿y upewniæ siê, ¿e w adresie znajduje siê poprawny localhost : `5001` .

![image](https://user-images.githubusercontent.com/65779777/218801491-9dba5033-a547-4db0-a68c-f2738511afb0.png)



Nastêpnie nale¿y ponownie otworzyæ folder z repozytorium w programie Visual Studio Community Edition. Otworzyæ plik Dziekanat.sln i na górnym pasku wybraæ DziekantBlazor, a nastêpnie go uruchomiæ. Nale¿y upewniæ siê, ¿e w adresie znajduje siê poprawny localhost : `5002` .

![image](https://user-images.githubusercontent.com/65779777/218805771-c4b93823-1c4c-4500-bfac-c549f9ac52ea.png)


### Logowanie danymi z bazy
Poprawnie uruchomiona aplikacja powinna pozwoliæ u¿ytkownikowi na zalogowanie siê po wpisaniu danych: 

Login : `student1`
Has³o : `student1`

LUB

Login : `student2`
Has³o : `student2`

POLE LOGINU I HAS£A JEST CASE SENSITIVE. Nale¿y zwróciæ uwagê na poprawnoœæ wpisywanych danych równie¿ od stwony wielkich i ma³ych liter. 

![image](https://user-images.githubusercontent.com/65779777/218806697-6ad1f6a6-59da-419e-8cec-18dca917bbf9.png)
