# GynTriage

Et triage-verktøy for gynekologisk avdeling. Når en pasient ringer inn, får helsepersonell opp spørsmål og valgmuligheter basert på hva pasienten henvender seg om. Avkrysninger kan åpne for nye, relevante spørsmål, slik at ingenting viktig blir glemt i samtalen.

> Hjemmeprosjekt. Inneholder ingen ekte pasientdata.

## Teknologi

| Del | Teknologi |
|---|---|
| Backend | .NET 10, C#, ASP.NET Core Web API |
| Bakgrunnsjobber | Hangfire |
| Database | Ikke bestemt ennå (EF Core) |
| Frontend | Angular 22, SCSS |
| Tester | xUnit |

## Struktur

```
GynTriage/
├── backend/
│   ├── GynTriage.slnx
│   ├── src/
│   │   ├── GynTriage.Api/           # Controllere, oppstart, Hangfire-oppsett
│   │   ├── GynTriage.Models/        # Domenemodeller og DTO-er
│   │   ├── GynTriage.Data/          # DbContext, EF Core, repositories
│   │   ├── GynTriage.Services/      # Forretningslogikk (triage-regler)
│   │   └── GynTriage.DatabaseTool/  # Konsollapp for migrering og seed-data
│   └── tests/
│       └── GynTriage.Tests/
└── frontend/
    └── src/app/
        ├── components/
        │   ├── atoms/       # Minste byggeklosser: knapp, checkbox, input
        │   ├── molecules/   # Små grupper: spørsmål med svaralternativer
        │   ├── organisms/   # Større deler: et helt spørsmålsskjema
        │   └── templates/   # Sideoppsett uten data
        ├── pages/           # Sider koblet til routing og data
        ├── services/        # API-kall
        └── models/          # TypeScript-typer
```

### Avhengigheter i backend

```
Api → Services → Data → Models
```

Hvert lag kjenner bare til lagene under seg. `Models` avhenger ikke av noe.

### Atomic design i frontend

Komponentene bygges fra små til store: atomer settes sammen til molekyler, molekyler til organismer, og så videre. Det gjør komponentene gjenbrukbare og lette å teste hver for seg.

## Kom i gang

**Krav:** .NET 10 SDK og Node.js LTS.

```bash
# Backend
cd backend
dotnet run --project src/GynTriage.Api

# Frontend (nytt terminalvindu)
cd frontend
npm install
npm start
```

- API: se adressen i terminalen etter `dotnet run`
- Hangfire-dashboard: `<api-adresse>/hangfire`
- Frontend: http://localhost:4200

## Tester

```bash
cd backend
dotnet test
```