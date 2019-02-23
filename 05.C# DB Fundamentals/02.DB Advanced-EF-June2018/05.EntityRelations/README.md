<h1 align="center">
    Exercises: Entity Relations
</h1>
<p>
    This document defines the <strong>exercise assignments</strong> for the
    <a
        href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017"
    >
        "Databases Advanced – EF Core" course @ Software University
    </a>
    .
</p>
<h2>
    1. Student System
</h2>
<p>
    Your task is to create a database for the <strong>Student System</strong>,
    using the <strong>EF Core Code First </strong>approach. It should look like
    this:
</p>
<h3>
    Constraints
</h3>
<p>
    Your <strong>namespaces</strong> should be:
</p>
<p>
    · P01_StudentSystem – for your Startup class, if you have one
</p>
<p>
    · P01_StudentSystem.Data – for your DbContext
</p>
<p>
    · P01_StudentSystem.Data.Models – for your models
</p>
<p>
    Your <strong>models</strong> should be:
</p>
<p>
    · StudentSystemContext – your DbContext
</p>
<ul>
    <li>
        Student:
    </li>
</ul>
<p>
    o StudentId
</p>
<p>
    o Name (up to 100 characters, unicode)
</p>
<p>
    o PhoneNumber (exactly 10 characters, not unicode, not required)
</p>
<p>
    o RegisteredOn
</p>
<p>
    o Birthday (not required)
</p>
<ul>
    <li>
        Course:
    </li>
</ul>
<p>
    o CourseId
</p>
<p>
    o Name (up to 80 characters, unicode)
</p>
<p>
    o Description (unicode, not required)
</p>
<p>
    o StartDate
</p>
<p>
    o EndDate
</p>
<p>
    o Price
</p>
<ul>
    <li>
        Resource:
    </li>
</ul>
<p>
    o ResourceId
</p>
<p>
    o Name (up to 50 characters, unicode)
</p>
<p>
    o Url (not unicode)
</p>
<p>
    o ResourceType (enum – can be Video, Presentation, Document or Other)
</p>
<p>
    o CourseId
</p>
<ul>
    <li>
        Homework:
    </li>
</ul>
<p>
    o HomeworkId
</p>
<p>
    o Content (string, linking to a file, not unicode)
</p>
<p>
    o ContentType (enum – can be Application, Pdf or Zip)
</p>
<p>
    o SubmissionTime
</p>
<p>
    o StudentId
</p>
<p>
    o CourseId
</p>
<ul>
    <li>
StudentCourse – mapping class between <strong>Students</strong> and        <strong>Courses</strong>
    </li>
</ul>
<p>
    Table relations:
</p>
<ul>
    <li>
        <strong>One student</strong>
        can have <strong>many CourseEnrollments</strong>
    </li>
    <li>
        <strong>One student </strong>
        can<strong> </strong>have<strong> many HomeworkSubmissions</strong>
    </li>
    <li>
        <strong>One course</strong>
        can have <strong>many StudentsEnrolled</strong>
    </li>
    <li>
        <strong>One course</strong>
        can have <strong>many Resources</strong>
    </li>
    <li>
        <strong>One course</strong>
        can have <strong>many HomeworkSubmissions</strong>
    </li>
</ul>
<p>
    You will need a constructor, accepting <strong>DbContextOptions</strong> to
    test your solution in <strong>Judge</strong>!
</p>
<h2>
    2. Seed Some Data in the Database
</h2>
<p>
    Write a <strong>seed method</strong> that fills the database with sample
    data.
    <br/>
Fill a few <strong>students</strong>, <strong>courses</strong>,    <strong>resources</strong> and <strong>homework submissions</strong>.
</p>
<h4>
    Bonus
</h4>
<p>
Create a console application that reads information about    <strong>courses</strong> and <strong>students</strong>.
</p>
<h2>
    3. Football Betting
</h2>
<p>
Your task is to create a database for a<strong>Football Bookmaker System</strong>, using the    <strong>Code First </strong>approach. It should look like this:
</p>
<h3>
    Constraints
</h3>
<p>
    Your <strong>namespaces</strong> should be:
</p>
<p>
    · P03_FootballBetting – for your Startup class, if you have one
</p>
<p>
    · P03_ FootballBetting.Data – for your DbContext
</p>
<p>
    · P03_ FootballBetting.Data.Models – for your models
</p>
<p>
    Your models should be:
</p>
<ul>
    <li>
        <strong>FootballBettingContext</strong>
        – your DbContext
    </li>
    <li>
        <strong>Team</strong>
        – TeamId, Name, LogoUrl, Initials (JUV, LIV, ARS…), Budget,
        PrimaryKitColorId, SecondaryKitColorId, TownId
    </li>
    <li>
        <strong>Color</strong>
        – ColorId, Name
    </li>
    <li>
        <strong>Town</strong>
        – TownId, Name, CountryId
    </li>
    <li>
        <strong>Country</strong>
        – CountryId, Name
    </li>
    <li>
        <strong>Player</strong>
        – PlayerId, Name, SquadNumber, TeamId, PositionId, IsInjured
    </li>
    <li>
        <strong>Position</strong>
        – PositionId, Name
    </li>
    <li>
        <strong>PlayerStatistic</strong>
        – GameId, PlayerId, ScoredGoals, Assists, MinutesPlayed
    </li>
    <li>
        <strong>Game</strong>
        – GameId, HomeTeamId, AwayTeamId, HomeTeamGoals, AwayTeamGoals,
        DateTime, HomeTeamBetRate, AwayTeamBetRate, DrawBetRate, Result)
    </li>
    <li>
        <strong>Bet</strong>
        – BetId, Amount, Prediction, DateTime, UserId, GameId
    </li>
    <li>
        <strong>User</strong>
        – UserId, Username, Password, Email, Name, Balance
    </li>
</ul>
<p>
    Table relationships:
</p>
<ul>
    <li>
        <strong>A Team</strong>
has one <strong>PrimaryKitColor</strong> and one        <strong>SecondaryKitColor</strong>
    </li>
    <li>
        <strong>A Color </strong>
has <strong>many PrimaryKitTeams </strong>and        <strong>many SecondaryKitTeams</strong>
    </li>
    <li>
        <strong>A Team</strong>
        residents in one <strong>Town</strong>
    </li>
    <li>
        <strong>A Town</strong>
        can host <strong>several</strong> <strong>Teams</strong>
    </li>
    <li>
        <strong>A Game </strong>
        has one <strong>HomeTeam </strong>and one <strong>AwayTeam </strong>and
a <strong>Team </strong>can have <strong>many</strong><strong>HomeGames </strong>and <strong>many</strong>        <strong>AwayGames</strong>
    </li>
    <li>
        <strong>A Town</strong>
can be placed in <strong>one</strong> <strong>Country</strong> and a        <strong>Country</strong> can have many <strong>Towns</strong>
    </li>
    <li>
        <strong>A Player</strong>
can play for <strong>one</strong> <strong>Team</strong> and<strong>one</strong> <strong>Team</strong> can have many        <strong>Players</strong>
    </li>
    <li>
        <strong>A Player</strong>
can play at one <strong>Position</strong> and one<strong>Position</strong> can be played by <strong>many</strong>        <strong>Players</strong>
    </li>
    <li>
        <strong>One</strong>
        <strong>Player</strong>
can play in <strong>many</strong> <strong>Games</strong> and in each        <strong>Game</strong>, <strong>many</strong> <strong>Players</strong>
        take part (<strong>PlayerStatistics</strong>)
    </li>
    <li>
        <strong>Many</strong>
        <strong>Bets</strong>
can be placed on <strong>one</strong> <strong>Game</strong>, but<strong>a</strong> <strong>Bet</strong> can be only on        <strong>one</strong> <strong>Game</strong>
    </li>
</ul>
<p>
    · Each bet for given game must have <strong>Prediction</strong> result
</p>
<ul>
    <li>
        <strong>A Bet</strong>
        can be placed by only <strong>one</strong> <strong>User</strong> and
        one <strong>User</strong> can place many <strong>Bets</strong>
    </li>
</ul>
<p>
Separate the <strong>models</strong>, <strong>data</strong> and    <strong>client</strong> into <strong>different layers</strong> (projects).
</p>