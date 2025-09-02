
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


<img width="901" height="755" alt="image" src="https://github.com/user-attachments/assets/f0665156-6c55-4882-8904-57cd36418ce6" />
<img width="576" height="365" alt="image" src="https://github.com/user-attachments/assets/04757d9b-39b1-4d5b-afcf-1422c77e33e9" />
<img width="901" height="719" alt="image" src="https://github.com/user-attachments/assets/fb7eb508-c717-4cea-8670-5819f89c02f0" />
