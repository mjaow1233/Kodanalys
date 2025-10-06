Under programmering grund har jag lärt mig grunder i C# som skulle känts omöjliga att förstå vid kursens början. Trots det är det mycket kan jag tänka på som självklart i efterhand; till exempel att tydlig kod med olika understrukturer (som klasser) gör det enklare att arbeta med eller att kunna återanvända samma kod måste vara bättre än att ha flera upplagor av den.
Kursen gett mig verktygen att utföra detta och visat många bra lösningar, kombinationer och valmöjligheter.


Gällande min inlämningsuppgift; 

Identifiera tre "Problem";


A. Inkonsekventa/felstavade/svårförståeliga eller vilseledande rader/metoder/variabler. Svåra att rätta/bygga vidare på förmodligen både för skaparen och andra granskare. Gör det extra svårt att göra kodbasen ännu mer komplex ifall det fortsätter. Förutom det är "class program" skrivet med liten bokstav vilket kan orsaka kompileringsfel.


B. Onödigt nästlade if-satser. Onödig komplexitet som gör det frustrerande att förstå och bygga på.


C. Ingen separation för olika delarna av programmet (förutom en user.cs i models). Gör det återigen svårare att förstå de olika funktionerna men även att bygga på dem.


Berätta hur du har ändrat dem;

Det första steget var att försöka förstå vad programmet faktiskt gör och vilka avgränsningar som finns. 

En enkel beskrivning är att programmet hanterar användare och en inbyggd begränsning verkar vara att det inte ska finnas fler än tio användare.



Efter det gjorde jag lite arbete i att försöka "städa upp" variabler och metoder, men bestämde mig för att det är lättare att skriva om dem istället. Detta skulle göra det enklare att implementera mer sortering av logiken. Menyvalen var statiska så jag skrev ut dessa till en Enum som jag kallade för MenuChoice.cs och logiken placerade jag i en fil kallad user.cs.


Jag implementerade List istället som ersättning för att skriva ut arrayer och istället för att matcha en string till sökfunktionen  byggde jag om den så att det gick att hitta användare på bara en del av namnet.

Förutom det har jag lagt till ett gäng felhanteringar för olika typer av input som inte matchar vad programmet är gjort för. 


Ifall en vill uppdatera programmet antingen med en fix eller mer funktioner är det numera lätt att hitta vart man ska titta. I user finns till exempel AddUser där hela flödet för den funktionen finns att titta på. Innan var den en nästlad if sats som både var knepig och hitta men innebar en viss risk att ändra på eftersom det påverkade hela flödet av andra funktioner.



Ifall jag hade mer tid med den här koden skulle jag förmodligen lagt till funktionen att spara användarna i en .txt fil eller liknande. Just nu sparas bara informationen så fort programmet körs. Vidare skulle jag försökt samla validering och felhantering och annat på ett ställe för att inte behöva repetera den koden. Förmodligen sett till så att user inte sysslar med consolen. Det blir nog bättre ifall det handskas med i program. Sist men inte minst hade det nog vart värt med autentisering och kanske domänklasser för olika användare. 

