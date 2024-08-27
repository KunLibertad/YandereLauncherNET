Imports System.IO
Imports Newtonsoft.Json

Public Class StudentEditor
    Enum Club
        No_Club = 0
        Cooking_Club = 1
        Drama_Club = 2
        Occult_Club = 3
        Art_Club = 4
        Light_Music_Club = 5
        Martial_Arts_Club = 6
        Photography_Club = 7
        Science_Club = 8
        Sports_Club = 9
        Gardering_Club = 10
        Gaming_Club = 11
        Student_Council = 12
        Bully = 13
        Delinquents = 14
        Newspaper = 15
        Teacher_F = 100
        Gym_Teacher_F = 101
        Nurse = 102
    End Enum
    Enum Persona
        Loner = 1
        Teacher_pet = 2
        Heroic = 3
        Coward = 4
        Evil = 5
        Social_Butterfly = 6
        Lovestrick = 7
        Dangerous = 8
        Strict_Persona = 9
        Phone_Adict = 10
        Fragile = 11
        Spiteful = 12
        Sleuth = 13
        Vengeful_NF = 14
        Protective = 15
        Violent = 16
        Snitch = 17
    End Enum
    Enum Strenght
        Incapable = 0
        Very_Weak = 1
        Weak = 2
        Strong = 3
        Very_Strong = 4
        Peak_Phhysical_Strength = 5
        Extensive_SelfDefence_Training = 6
        Armed_PeperSpray = 7
        Armed = 8
        Invincible = 9
    End Enum
    Enum [Class]
        Reina = 11
        Natsuki = 12
        RinoAnayo = 21
        Shiori = 22
        Karin = 31
        Kaho = 32
    End Enum
    Enum Gender
        Female = 0
        Male = 1
    End Enum
    Enum HairColor
        Black
        Red
        Yellow
        Green
        BlueCyan
        Purple
        Orange
        Brown
        White
        None
        Pippi
        Succubus1
        Succubus2
        Clubless
        Waifu
        Occult1
        Occult2
        Occult3
        Occult4
        Occult5
        Occult6
        Coach
        Osana
        Obstacle
        Council1
        Council2
        Council3
        Council4
        Ganguro1
        Ganguro2
        Ganguro3
        Ganguro4
        Ganguro5
        Delinquent1
        Delinquent2
        Delinquent3
        Delinquent4
        Delinquent5
        Photo
        Art
        Science
        Gardening
        Sports
        Drama
        Gaming
        Cooking
        Music
    End Enum
    Enum EyeColor
        Black
        Red
        Yellow
        Green
        Blue
        Cyan
        Purple
        Orange
        Brown
        White
        None
    End Enum
    Enum EyeStyle
        [Default]
        Male
        Round
        Serius
        Sad
        Gentle
        Smug
        Thin
        Rival1
        MO
        Mean
    End Enum
    Enum Stockings
        Loose
        Red
        Yellow
        Green
        Blue
        Cyan
        Purple
        Osana
        CustomX
        Kizana
        Black
        Council1
        Council2
        Council3
        Council4
        Music1
        Music2
        Music3
        Music4
        Music5
        Music6
        Dafuni
        Sakyu
        Inkyu
        ShortRed
        ShortYellow
        ShortGreen
        ShortBlue
        ShortCyan
        ShortBlack
        ShortPurple
        Amai
        Rival1
        Rival2
        Rival3
        Rival4
        Rival5
        Rival6
        Rival7
        Rival8
        Rival9
        Rival10

    End Enum
    Dim StudentJsonFilePath = $"{Form1.CurrentExecDir}\YandereSimulator_Data\StreamingAssets\JSON\Students.json"

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MenuStrip1.Renderer = New MyRender()
    End Sub
    Private Sub StudentEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim JsonData = File.ReadAllText(StudentJsonFilePath)
        Dim StudentObjectList As List(Of Students) = JsonConvert.DeserializeObject(Of List(Of Students))(JsonData)

        For Each student As Students In StudentObjectList
            Dim listItem As New ListViewItem(student.Name)
            listItem.Tag = student ' Guarda el objeto completo en la propiedad Tag
            ListView1.Items.Add(listItem)
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class