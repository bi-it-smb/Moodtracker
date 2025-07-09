# Projektjournal Fachblock 10 – SMB

## Inhaltsverzeichnis  
- [Einleitung](#einleitung)  
- [Verwendete Technologien](#verwendete-technologien)  
- [Funktionen](#funktionen)
- [Anleitung](#anleitung)
- [Modifikationsanleitung](#modifikationsanleitung)
- [Projektverlauf](#projektverlauf)
- [Mockup](#mockup)
- [UML-Klassendiagramm & Validation](#uml-klassendiagramm--validation)
- [JSON](#json)
- [Images - Troubleshooting](#images---troubleshooting)
- [Detailseite](#detailseite)
- [Bewertungsseite - CRUD](#bewertungsseite---crud)
- [Reflexion](#reflexion)

## Einleitung  
Diese App dient zur Darstellung und Übersicht von Kursangeboten für Kinder und Jugendliche. Die Kursdaten (inkl. Bild, Name, Beschreibung, Altersgruppe, Zeitpunkt und benötigtem Material) werden aus einer JSON-Datei geladen und in einer benutzerfreundlichen Oberfläche angezeigt.

Die App ist für Eltern, Betreuer oder Kinder/Jugendliche gedacht, die sich über aktuelle Kurse informieren möchten.

## Verwendete Technologien  
- **C#** – Zur Programmierung der Applikation  
- **Figma** – Zur Skizzierung des Designs

## Funktionen  
- Interaktive Navigation
- Bewertungssystem für Kurse

## Anleitung
### Starten der App
Beim Öffnen der App werden automatisch alle Kurse aus der eingebundenen JSON-Datei geladen.

### Kursübersicht
Auf der Startseite werden alle Kurse in übersichtlicher Form dargestellt – inklusive Bild, Name, Beschreibung, Altersgruppe, Zeitpunkt und Material.

### Details ansehen
Du kannst auf das Bild eines Kurses klicken, um zur Detailseite zu gelangen. Dort findest du eine ausführlichere Beschreibung des Kurses.

### Bewertung abgeben
Über den Button „Eigene Bewertung abschicken“ kannst du den Kurs bewerten.
Die Bewertung erfolgt mit 1 bis 5 Sternen und einem optionalen Kommentar.

## Modifikationsanleitung
Um einen neuen Kurs hinzuzufügen, muss ein neuer Eintrag im courses-Array der JSON-Datei erstellt werden.
Dabei ist darauf zu achten, dass alle erforderlichen Attribute vollständig und korrekt benannt sind.

### Beispiel
```
{
  "name": "Neue Kursbezeichnung",
  "description": "Kurzbeschreibung des Kurses.",
  "image": "bildname.jpg",
  "location": "Treffpunkt",
  "date": "2025-07-12",
  "time": "09:00 - 12:00",
  "age": "10",
  "materials": "Was mitzubringen ist",
  "feedback": {
    "enabled": true,
    "type": "rating",
    "hint": "Bewerten Sie den Kurs mit 1 bis 5 Sternen."
  },
  "rating": null,
  "rating_timestamp": null,
  "comment": null
}
```

## Projektverlauf
| Datum       | Aufgabe / Meilenstein            |
|-------------|----------------------------------|
| 2025-06-18  | Mockup angefangen                |
| 2025-06-21  | Mockup fertiggestellt            |
| 2025-06-25  | UML & Validation erstellt        |
| 2025-06-25  | JSON überarbeitet                |
| 2025-06-25  | .NET MAUI Projekt erstellt       |
| 2025-06-27  | Images - Troubleshooting         |
| 2025-07-02  | Detailseite erstellt & Navigation|
| 2025-07-03  | Bewertungsformular erstellt      |
| 2025-07-04  | Formatierung                     |


## Mockup  
Ich habe mithilfe von Figma ein Mockup erstellt, um das Design meiner Applikation zu planen. Hier ist ein Screenshot des Mockups:

![image](https://github.com/user-attachments/assets/f1429fbe-6a17-4f23-9f9e-ccf2b912c8ae)

Ich habe vier verschiedene Kurse erstellt, die jeweils eine eigene Seite besitzen. Diese Seiten sind über die Navigation erreichbar. Die Kurse sind: *Wandern für Anfänger*, *Survival-Training*, *Bogenschiessen* und *Kräuterwanderung*.

Zusätzlich habe ich eine Seite zur Bewertung der Kurse erstellt. Die Kurse können mit einem Sternchen-System bewertet werden. Optional kann man auch einen Kommentar und seinen Namen hinterlassen.

Beim Skizzieren des Designs habe ich darauf geachtet, dass die Seiten übersichtlich gestaltet sind und die wichtigsten Informationen schnell gefunden werden können.

Link zum Mockup: [Figma Mockup](https://www.figma.com/proto/xDM8tOmfVx6oGUaGwT0ljC/MoodTracker_Mockup?node-id=4-112&p=f&t=BgtEZogCLrswh6zW-1&scaling=scale-down&content-scaling=fixed&page-id=0%3A1)

## UML-Klassendiagramm & Validation

![image](https://github.com/user-attachments/assets/751d0332-5b80-4c79-bebe-a69cf4c07b1b)


## JSON
Ich habe die bereitgestellte JSON-Datei überarbeitet, da ich meine eigenen Kurse erstellt habe.
```
{
  "courses": [
    {
      "name": "Wandern für Anfänger (ab 12)",
      "description": "Geführte Einsteigerwanderungen mit Tipps zu Ausrüstung, Orientierung und Sicherheit im Gelände.",
      "image": "wandern.jpg",
      "location": "Eingang Hauptgebäude",
      "date": "2025-07-09",
      "time": "08:00 - 15:30",
      "age": "12",
      "materials": "Rucksack, Wanderschuhe, eine Flasche Wasser, etwas zum Grillen, gute Laune",
      "feedback": {
        "enabled": true,
        "type": "rating",
        "hint": "Bewerten Sie den Kurs mit 1 bis 5 Sternen."
      },
      "rating": null,
      "rating_timestamp": null,
      "comment": null
    },
    {
      "name": "Survival-Training (ab 16)",
      "description": "Lernen, wie man ohne moderne Hilfsmittel in der Natur überlebt. Feuer machen, einen Unterschlupf bauen und Wasser finden.",
      "image": "wandern.jpg",
      "location": "Eingang Hauptgebäude",
      "date": "2025-07-11",
      "time": "08:00 - 15:30",
      "age": "16",
      "materials": "Rucksack, Wanderschuhe, eine Flasche Wasser, etwas zum Grillen, Messer",
      "feedback": {
        "enabled": true,
        "type": "rating",
        "hint": "Bewerten Sie den Kurs mit 1 bis 5 Sternen."
      },
      "rating": null,
      "rating_timestamp": null,
      "comment": null
    },
    {
      "name": "Bogenschiessen (ab 10)",
      "description": "Einführung in traditionelles Bogenschiessen in Wald- oder Feldumgebung.",
      "image": "wandern.jpg",
      "location": "Eingang Hauptgebäude",
      "date": "2025-07-10",
      "time": "13:15 - 15:30",
      "age": "10",
      "materials": "eine Flasche Wasser",
      "feedback": {
        "enabled": true,
        "type": "rating",
        "hint": "Bewerten Sie den Kurs mit 1 bis 5 Sternen."
      },
      "rating": null,
      "rating_timestamp": null,
      "comment": null
    },
    {
      "name": "Kräuterwanderung (ab 8)",
      "description": "Geführte Tour durch Wald und Wiese mit Fokus auf essbare Wildkräuter und deren Anwendung.",
      "image": "wandern.jpg",
      "location": "Eingang Hauptgebäude",
      "date": "2025-07-01",
      "time": "08:00 - 11:45",
      "age": "8",
      "materials": "Rucksack, Wanderschuhe, eine Flasche Wasser",
      "feedback": {
        "enabled": true,
        "type": "rating",
        "hint": "Bewerten Sie den Kurs mit 1 bis 5 Sternen."
      },
      "rating": null,
      "rating_timestamp": null,
      "comment": null
    }
  ]
}
```

Dann habe ich es in meiner App umgesetzt. Die App liest die Kurse aus der JSON-Datei aus, wandelt sie in Objekte um und zeigt sie automatisch in der Oberfläche an, sobald das ViewModel geladen wurde. Änderungen in der JSON-Datei werden nach einem Neustart der App übernommen.

![image](https://github.com/user-attachments/assets/b815346e-7a81-4fbe-b411-6685c6c64444)

## Images - Troubleshooting
Beim Einfügen der Bilder ist mir ein Problem aufgefallen. Die Bilder wurden im Android-Emulator nicht angezeigt. Ich habe mehrere Stunden lang versucht, dieses Problem zu lösen. Nach längerer Recherche habe ich schließssich eine Lösung gefunden. Ich musste den Cache löschen. Das habe ich erreicht, indem ich den Emulator deinstalliert und erneut installiert habe.

![image](https://github.com/user-attachments/assets/f50d93d2-b8e6-463a-8b6c-9f2b40f689fb)

## Detailseite
Die Daten der Kurse werden aus der JSON-Datei ausgelesen und angezeigt. Zu den Daten gehören: Bild, Name, Beschreibung, Alter, Zeitpunkt und Material.

![image](https://github.com/user-attachments/assets/3d6ab833-319b-412c-b258-fdf9b820fd75)

## Bewertungsseite - CRUD
Auf der Bewertungsseite kann man dem Kurs eine Bewertung von 1 bis 5 geben und einen optionalen Kommentar dazu schreiben. Die Bewertung wird auf dem Gerät gespeichert und kann später erneut aufgerufen werden.

```
    // Gets the saved rating from the repository
    private async void LoadRating()
    {
        var saved = await repository.GetRatingAsync(Course.Name);
        if (saved != null)
        {
            Rating = saved.Rating;
            Comment = saved.Comment;
        }
        else
        {
            Rating = null;
            Comment = string.Empty;
        }
    }

    // Saves the rating and comment. It won't save if no rating was selected.
    [RelayCommand]
    public async Task SaveRatingAsync()
    {
        if (Rating == null)
        {
            await Application.Current.MainPage.DisplayAlert("Fehler", "Bitte wählen Sie eine Bewertung (1-5 Sterne) aus.", "OK");
            return;
        }

        var entry = new RatingEntry
        {
            CourseName = Course.Name,
            Rating = Rating,
            Comment = Comment
        };

        await repository.UpsertRatingAsync(entry);

        await Application.Current.MainPage.DisplayAlert("Erfolg", "Bewertung wurde gespeichert.", "OK");
    }
}

```

## Reflexion
Während der Entwicklung der App habe ich viel über das Zusammenspiel von JSON-Daten, ViewModels und Benutzeroberfläche in .NET MAUI gelernt. Ein technischer Stolperstein war das Einbinden der Bilder im Android-Emulator. Trotz korrekter Pfade wurden sie zunächst nicht angezeigt. Die Lösung – Emulator löschen, neu installieren und den Cache leeren – hat mir gezeigt, wie wichtig Geduld und systematische Fehlersuche sind.
Rückblickend bin ich mit dem Projekt insgesamt zufrieden. Aufgrund von Zeitmangel konnte ich jedoch nicht alle Funktionen vollständig umsetzen. Die Bewertungsseite muss noch optisch überarbeitet werden, und mit der aktuellen Lösung zur Speicherung der Bewertungen bin ich ebenfalls nicht ganz zufrieden. In einem nächsten Schritt würde ich diese Bereiche verbessern.
