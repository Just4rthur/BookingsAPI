
# README

Jag har använt Dependency Injection (DI) för att koppla loss controller, service och repository via interfaces.
Alla beroenden injiceras och konfigureras i Program.cs för enkel testning och utbytbarhet.
DI gör det möjligt att byta ut implementationer, t.ex. för mockning vid tester.
DRY-principen följs genom att all logik för tidsöverlapp finns på ett ställe (BookingService).
Ingen duplicerad affärslogik finns i controller eller repository.
Controller och service använder enbart interfaces, vilket ger flexibilitet.
Koden är lätt att underhålla och vidareutveckla tack vare tydlig separation av ansvar.
DELETE-endpointen är implementerad enligt REST-standard.
Strukturen gör det enkelt att testa, vidareutveckla och felsöka applikationen.
Alla krav i uppgiften är uppfyllda, samt alla tester i BookingServiceTests.cs är "passed".
